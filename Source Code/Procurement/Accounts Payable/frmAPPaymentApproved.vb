Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI

Public Class frmAPPaymentApproved
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        Dim firstDayofMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)

        ListView1.View = View.Details

        ListView1.Columns.Add("Request No.", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Office", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Pay To", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Description", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Payment Type", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Reference No.", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Total Amount", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("Status", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Date Approved", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("pid", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("officeid", -2, HorizontalAlignment.Center)


        ListView1.Columns(0).Width = 90
        ListView1.Columns(1).Width = 140
        ListView1.Columns(2).Width = 150
        ListView1.Columns(3).Width = 150
        ListView1.Columns(4).Width = 0
        ListView1.Columns(5).Width = 90
        ListView1.Columns(6).Width = 90
        ListView1.Columns(7).Width = 110
        ListView1.Columns(8).Width = 150
        ListView1.Columns(9).Width = 0
        ListView1.Columns(10).Width = 0
        LoadDetails()

    End Sub


    Public Sub LoadDetails()
        ListView1.Items.Clear()
        com.CommandText = "Select *, voucherno as 'Request No.',  " _
                                        + " (select officename from tblcompoffice where officeid=tblvouchers.officeid) as 'Office', " _
                                        + " (select companyname from tblglobalvendor where vendorid=tblvouchers.payto) as 'Pay To', " _
                                        + " Description, " _
                                        + " ucase(VoucherType) as 'Payment Type', ponumber as 'Reference No.', amount as 'Total Amount', " _
                                        + " date_format(datetrn, '%Y-%m-%d %r') as 'Date Requested', " _
                                        + " (select fullname from tblaccounts where accountid=tblvouchers.trnby) as 'Requested By', " _
                                        + " if(Verified=1,'APPROVED','PENDING') as Status, date_format(dateverified, '%Y-%m-%d %r') as 'Date Approved' " _
                                        + " from tblvouchers where verified=1 and paid=0 and cleared=0 and cancelled=0 and " _
                                        + " (voucherno like '%" & txtSearch.Text & "%' or (select officename from tblcompoffice where officeid=tblvouchers.officeid) like '%" & txtSearch.Text & "%') order by dateverified desc" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("Request No.").ToString, 0)
            item1.SubItems.Add(rst("Office").ToString)
            item1.SubItems.Add(rst("Pay To").ToString)
            item1.SubItems.Add(rst("Description").ToString)
            item1.SubItems.Add(rst("Payment Type").ToString)
            item1.SubItems.Add(rst("Reference No.").ToString)
            item1.SubItems.Add(FormatNumber(rst("Total Amount").ToString, 2))
            item1.SubItems.Add(rst("Status").ToString)
            item1.SubItems.Add(rst("Date Approved").ToString)
            item1.SubItems.Add(rst("pid").ToString)
            item1.SubItems.Add(rst("officeid").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If GlobalPOPaymentGLItemCode = "" Then
            XtraMessageBox.Show("Global Payment GL Item for Purchase Order not set!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each itm As ListViewItem In ListView1.CheckedItems
                Dim voucherLocation = Application.StartupPath.ToString & "\Transaction\Accounts Payable\" & Format(CDate(itm.SubItems(8).Text), "yyyy-MM-dd")
                If (Not System.IO.Directory.Exists(voucherLocation)) Then
                    System.IO.Directory.CreateDirectory(voucherLocation)
                End If
                Dim report As New rptAccountsPayable()
                LoadXgrid("select (select itemname from tblglitem where itemcode=tblvouchersdetail.itemcode) as 'Item Name', Remarks, Amount  from tblvouchersdetail where voucherno='" & itm.SubItems(0).Text & "'", "tblvouchersdetail", Em, GridView1, Me)

                XgridColCurrency({"Amount"}, GridView1)
                ' GridView1.Columns("Amount").Width = 2

                GridView1.Columns("Amount").Summary.Clear()
                GridView1.Columns("Amount").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:n}")
                CType(GridView1.Columns("Amount").View, GridView).OptionsView.ShowFooter = True

                report.XrBarCode1.Text = itm.SubItems(0).Text
                report.txtOfficename.Text = itm.SubItems(1).Text
                report.voucherno.Text = itm.SubItems(0).Text
                report.pid.Text = "Reference #: " & itm.SubItems(5).Text
                report.txtVendorSuplier.Text = "SUPPLIER: " & itm.SubItems(2).Text
                report.txtAmount.Text = "TOTAL AMOUNT: " & GridView1.Columns("Amount").SummaryText
                report.txtCheckDate.Text = "Date: " & Format(CDate(itm.SubItems(8).Text), "MMMM dd, yyyy")

                report.PaperKind = System.Drawing.Printing.PaperKind.Letter
                report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Em))
                If Not (System.IO.File.Exists(voucherLocation & "\" & itm.SubItems(0).Text & " - " & rchar(itm.SubItems(2).Text.Replace("/", "")) & ".pdf")) Then
                    System.IO.File.Delete(voucherLocation & "\" & itm.SubItems(0).Text & " - " & rchar(itm.SubItems(2).Text.Replace("/", "")) & ".pdf")
                End If
                report.ExportToPdf(voucherLocation & "\" & itm.SubItems(0).Text & " - " & rchar(itm.SubItems(2).Text.Replace("/", "")) & ".pdf")
                AddAttachmentPackage(itm.SubItems(0).Text, "accounts-payable", {voucherLocation & "\" & itm.SubItems(0).Text & " - " & rchar(itm.SubItems(2).Text.Replace("/", "")) & ".pdf"})


                com.CommandText = "insert into tblglaccountledger (officeid,batchcode,journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                         + "select '" & itm.SubItems(10).Text & "','" & itm.SubItems(9).Text & "','payable-accounts',payto,voucherno,'" & GlobalPOPaymentGLItemCode & "', description, 0, amount,current_timestamp,trnby,1,'" & globaluserid & "',current_timestamp from tblvouchers where voucherno='" & itm.SubItems(0).Text & "'" : com.ExecuteNonQuery()

                com.CommandText = "Update tblpurchaseorder set paymentupdated=1  where ponumber='" & itm.SubItems(5).Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "Update tblvouchers set paid=1, purchaseorder=1,datepaid=current_timestamp,cleared=1,datecleared=current_timestamp where voucherno='" & itm.SubItems(0).Text & "'" : com.ExecuteNonQuery()
                RecordApprovingHistory("payment request", itm.SubItems(9).Text, itm.SubItems(0).Text, "paid", "Ref#" & itm.SubItems(0).Text & " AP document generated")
            Next
 
            LoadDetails()
            XtraMessageBox.Show("Selected item successfully confirmed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = True
            Next
        Else
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = False
            Next
        End If
    End Sub


    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtSearch.Text = "" Then Exit Sub
            LoadDetails()
        End If
    End Sub
End Class