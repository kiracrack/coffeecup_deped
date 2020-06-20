Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI

Public Class frmForwardPO
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

        ListView1.Columns.Add("PO Number", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Office", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Supplier", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Total", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("Date Approved", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("ref", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("vendorid", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Note", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("officeid", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("requestby", -2, HorizontalAlignment.Left)

        ListView1.Columns(0).Width = 80
        ListView1.Columns(1).Width = 140
        ListView1.Columns(2).Width = 150
        ListView1.Columns(3).Width = 90
        ListView1.Columns(4).Width = 150
        ListView1.Columns(5).Width = 0
        ListView1.Columns(6).Width = 0
        ListView1.Columns(7).Width = 0
        ListView1.Columns(8).Width = 0
        ListView1.Columns(9).Width = 0
        LoadPurchaseOrder()

    End Sub


    Public Sub LoadPurchaseOrder()
        ListView1.Items.Clear()
        com.CommandText = "Select *, requestref, ponumber as 'PO Number', " _
                   + " (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) as 'Office', " _
                   + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', " _
                   + " (select requestby from tblrequisitions where pid=tblpurchaseorder.requestref) as 'requestby', " _
                   + " totalamount as 'Total', " _
                   + " date_format(dateverified,'%Y-%m-%d %r') as 'Date Approved',vendorid " _
                   + " from tblpurchaseorder " _
                   + " where verified=1 and forpo=1 and tblpurchaseorder.cancelled=0 and forwarded=0 " _
                   + " and  (ponumber like '%" & txtSearch.Text & "%' or " _
                   + " (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) like '%" & txtSearch.Text & "%' or " _
                   + " (select sum(total) from tblrequisitionsitem where pid=tblpurchaseorder.requestref and vendorid =  tblpurchaseorder.vendorid) like '%" & txtSearch.Text & "%' or " _
                   + " date_format(tblpurchaseorder.datetrn,'%Y-%m-%d') like '%" & txtSearch.Text & "%' or " _
                   + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) like '%" & txtSearch.Text & "%' or " _
                   + " date_format(datetrn,'%Y-%m-%d') like '%" & txtSearch.Text & "%') order by datetrn desc" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("PO Number").ToString, 0)
            item1.SubItems.Add(rst("Office").ToString)
            item1.SubItems.Add(rst("Supplier").ToString)
            item1.SubItems.Add(FormatNumber(rst("Total").ToString, 2))
            item1.SubItems.Add(rst("Date Approved").ToString)
            item1.SubItems.Add(rst("requestref").ToString)
            item1.SubItems.Add(rst("vendorid").ToString)
            item1.SubItems.Add(rst("note").ToString)
            item1.SubItems.Add(rst("officeid").ToString)
            item1.SubItems.Add(rst("requestby").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()


    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Dim poLocation As String = "'" : Dim selectedPO(5) As String
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim cnt As Integer = 0
            For Each itm As ListViewItem In ListView1.CheckedItems
                selectedPO(cnt) = itm.SubItems(0).Text
                poLocation = Application.StartupPath.ToString & "\Purchase Order\" & Format(CDate(itm.SubItems(4).Text), "yyyy-MM-dd")
                If (Not System.IO.Directory.Exists(poLocation)) Then
                    System.IO.Directory.CreateDirectory(poLocation)
                End If
                Dim report As New rptPurchaseOrder()
                LoadXgrid("Select QUANTITY as 'Quantity'," _
                         + " UNIT as 'Unit', " _
                         + " itemname as 'Particular', " _
                         + " COST as 'Cost', " _
                         + " TOTAL as 'Total' " _
                         + " from tblpurchaseorderitem  " _
                         + " where ponumber='" & itm.SubItems(0).Text & "'", "tblpurchaseorderitem", gcontrol_po, gridview_po, Me)

                XgridColCurrency({"Cost", "Total"}, gridview_po)
                XgridColAlign({"Quantity", "Unit"}, gridview_po, DevExpress.Utils.HorzAlignment.Center)

                gridview_po.Columns("Quantity").Width = 2
                gridview_po.Columns("Unit").Width = 2
                gridview_po.Columns("Cost").Width = 2
                gridview_po.Columns("Total").Width = 2

                gridview_po.Columns("Total").Summary.Clear()
                gridview_po.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n}")
                CType(gridview_po.Columns("Total").View, GridView).OptionsView.ShowFooter = True

                report.XrBarCode1.Text = itm.SubItems(0).Text
                report.txtOfficename.Text = itm.SubItems(1).Text
                report.txtPONumber.Text = itm.SubItems(0).Text
                report.pid.Text = "Reference #: " & itm.SubItems(5).Text
                report.txtVendorSuplier.Text = "SUPPLIER: " & itm.SubItems(2).Text
                report.txtAmount.Text = "TOTAL AMOUNT: " & gridview_po.Columns("Total").SummaryText
                report.txtCheckDate.Text = "Date: " & Format(CDate(itm.SubItems(4).Text), "MMMM dd, yyyy")


                If GlobalPOExpiry = 0 Then
                    report.lblnote.Visible = False
                    report.lblNoteTitle.Visible = False
                    report.txtValidDate.Visible = False
                End If

                report.txtNotePo.Text = itm.SubItems(7).Text
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter

                report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(gcontrol_po))
                If Not (System.IO.File.Exists(poLocation & "\PO" & itm.SubItems(0).Text & " - " & rchar(itm.SubItems(2).Text.Replace("/", "")) & ".pdf")) Then
                    System.IO.File.Delete(poLocation & "\PO" & itm.SubItems(0).Text & " - " & rchar(itm.SubItems(2).Text.Replace("/", "")) & ".pdf")
                End If
                report.ExportToPdf(poLocation & "\PO" & itm.SubItems(0).Text & " - " & rchar(itm.SubItems(2).Text.Replace("/", "")) & ".pdf")
                AddAttachmentPackage(itm.SubItems(0).Text, "purchase-order", {poLocation & "\PO" & itm.SubItems(0).Text & " - " & rchar(itm.SubItems(2).Text.Replace("/", "")) & ".pdf"})

                Dim getPOtypeid As String = qrysingledata("potypeid", "potypeid", "tblrequisitions where pid='" & itm.SubItems(5).Text & "'")
                RecordApprovingHistory("purchase order", itm.SubItems(5).Text, itm.SubItems(0).Text, "Forwarded", "PO#" & itm.SubItems(0).Text & " Forwarded")
                InsertEmailNotification("requisition", getEmailAccount(itm.SubItems(9).Text), "PURCHASE ORDER FORWARDED (" & itm.SubItems(0).Text & ")", FormatingEmailPurchaseOrder(itm.SubItems(0).Text), "")
                com.CommandText = "update tblpurchaseorder set forwarded=1 where ponumber='" & itm.SubItems(0).Text & "'" : com.ExecuteNonQuery()
                cnt = cnt + 1
            Next
            LoadPurchaseOrder()
            ViewAttachmentPackage_Database(selectedPO, "purchase-order")
            XtraMessageBox.Show("Selected purchase order successfully forwarded!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            LoadPurchaseOrder()
        End If
    End Sub
End Class