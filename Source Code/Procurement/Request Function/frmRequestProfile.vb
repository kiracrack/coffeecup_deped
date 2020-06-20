Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.GridColumnSummaryItem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.Data

Public Class frmRequestProfile
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Function formatcurrency(ByVal i As Integer)
        GridView1.Columns(i).DisplayFormat.FormatType = FormatType.Numeric
        GridView1.Columns(i).DisplayFormat.FormatString = "n"
        Return 0
    End Function

    Private Sub frmPurchaseItems_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        pid.Text = ""
    End Sub
    Private Sub frmPurchaseItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        ' LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(GridView2)
        LoadGridviewAppearance(GridView3)
        LoadGridviewAppearance(GridView4)
        lblOffice.Text = GlobalOfficeCaption
        loaddetails(pid.Text)
        filter(pid.Text)
        filterBranch(pid.Text)
        filterApprovalLogs()
        filterTransactionOrderOrder(pid.Text)
    End Sub

    Public Function loaddetails(ByVal id As String)
        com.CommandText = "select *, date_format(DATEREQUEST,'%M %d, %Y') as 'dr',date_format(dateapproved,'%M %d, %Y') as 'da', " _
                                 + " (select officename from tblcompoffice where officeid =tblrequisitions.officeid ) as 'office', " _
                                 + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'REQUEST', " _
                                 + " (select DESCRIPTION from tblrequesttype where POTYPEID = tblrequisitions.POTYPEID) as 'POTYPE', " _
                                 + " (select designation from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'DESIGNATION', " _
                                 + " (select fullname from tblaccounts where accountid = tblrequisitions.trnby) as 'popurchaser', " _
                                 + " case when cancelled=1 and disapproved=0 then 'CANCELLED' " _
                                          + " when cancelled=0 and disapproved=1 then 'DISAPPROVED' " _
                                          + " when hold=1 then 'ON HOLD' " _
                                          + " when ((corporatelevel=0 and approvedbranch=1) or (corporatelevel=1 and approvedbranch=1 and approvedcorporate=1)) then 'APPROVED' " _
                                          + " else 'FOR APPROVAL' end as 'Status', " _
                                 + " if(corporatelevel=1,'CORPORATE','" & UCase(GlobalOfficeCaption) & "') as applevel" _
                                 + " from tblrequisitions where pid='" & id & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtoffice.Text = rst("office").ToString
            txtRequestby.Text = rst("REQUEST").ToString
            txtDesignation.Text = rst("DESIGNATION").ToString
            txtdatereq.Text = rst("dr").ToString
            txtdetails.Text = rst("DETAILS").ToString
            txtStatus.Text = UCase(rst("Status").ToString)
            txtpotype.Text = rst("POTYPE").ToString
            txtPurchaser.Text = rst("popurchaser").ToString
            txtDateApproved.Text = rst("da").ToString
            txtApprovingLevel.Text = rst("applevel").ToString
            If rst("revised") = True And rst("trnrefno").ToString <> "manual-requisition" Then
                tabOriginal.PageVisible = True
            Else
                tabOriginal.PageVisible = False
            End If
        End While
        rst.Close()

        If txtStatus.Text = "APPROVED" Then
            txtStatus.Properties.Appearance.BackColor = Color.Lime
            txtStatus.Properties.Appearance.ForeColor = Color.Black
            cmdPrint.Visible = True

        ElseIf txtStatus.Text = "FOR APPROVAL" Or txtStatus.Text = "ON HOLD" Then
            txtStatus.Properties.Appearance.BackColor = Color.Orange
            txtStatus.Properties.Appearance.ForeColor = Color.Black
            cmdPrint.Visible = False

        ElseIf txtStatus.Text = "DISAPPROVED" Or txtStatus.Text = "CANCELLED" Then
            txtStatus.Properties.Appearance.BackColor = Color.Red
            txtStatus.Properties.Appearance.ForeColor = Color.White
            cmdPrint.Visible = False

        End If
        Return 0
    End Function
    Public Function filter(ByVal pid As String)
        LoadXgrid("Select  (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Particular', " _
                                + " ifnull((select sum(quantity) from tblinventory where quantity>0 and officeid=tblrequisitionsitem.officeid and productid=tblrequisitionsitem.productid),0) as 'Onhand Quantity', " _
                                + " QUANTITY as 'Quantity'," _
                                + " UNIT as 'Unit', " _
                                + " COST as 'Cost', " _
                                + " TOTAL as 'Total', " _
                                + " Remarks, " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid ) as 'Vendor' " _
                                + " from tblrequisitionsitem " _
                                + " where pid='" & pid & "'", "tblrequisitionsitem", Em, GridView1, Me)
        XgridColCurrency({"Cost"}, GridView1)
        XgridColCurrency({"Total"}, GridView1)
        GridView1.BestFitColumns()
        'GridView1.Columns("Quantity").Width = 60
        'GridView1.Columns("Onhand Quantity").Width = 80
        GridView1.Columns("Cost").Width = 100
        GridView1.Columns("Total").Width = 120
        GridView1.Columns("Remarks").Width = 250
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        RemovedNoValueColumn("Remarks", GridView1, Me)
        XgridColAlign({"Quantity", "Unit", "Onhand Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("Total").Summary.Clear()
        GridView1.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n}")
        CType(GridView1.Columns("Total").View, GridView).OptionsView.ShowFooter = True

        Return 0
    End Function
    Public Function filterBranch(ByVal pid As String)
        LoadXgrid("Select  (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionslogsitem.PRODUCTID ) as 'Particular', " _
                                + " (select DESCRIPTION from tblprocategory where CATID = tblrequisitionslogsitem.CATID ) as 'Category', " _
                                + " ifnull((select sum(quantity) from tblinventory where quantity>0 and officeid=tblrequisitionslogsitem.officeid and productid=tblrequisitionslogsitem.productid),0) as 'Onhand Quantity', " _
                                + " QUANTITY as 'Quantity'," _
                                + " UNIT as 'Unit', " _
                                + " COST as 'Cost', " _
                                + " TOTAL as 'Total', " _
                                + " Remarks, " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionslogsitem.vendorid ) as 'Vendor' " _
                                + " from tblrequisitionslogsitem " _
                                + " where pid='" & pid & "'", "tblrequisitionslogsitem", Em_Branch, GridView4, Me)
        XgridColCurrency({"Cost"}, GridView4)
        XgridColCurrency({"Total"}, GridView4)
        GridView4.BestFitColumns()
        'GridView4.Columns("Quantity").Width = 60
        GridView4.Columns("Cost").Width = 100
        GridView4.Columns("Total").Width = 120
        GridView4.Columns("Remarks").Width = 250
        'GridView4.Columns("Particular").ColumnEdit = MemoEdit
        GridView4.Columns("Remarks").ColumnEdit = MemoEdit

        XgridColAlign({"Quantity", "Unit"}, GridView4, DevExpress.Utils.HorzAlignment.Center)

        GridView4.Columns("Total").Summary.Clear()
        GridView4.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n}")
        CType(GridView4.Columns("Total").View, GridView).OptionsView.ShowFooter = True

        Return 0
    End Function
    Public Sub filterApprovalLogs()
        LoadXgrid("select CONFIRMBY as 'Confirmed by', " _
                      + " tblapprovalhistory.REMARKS as 'Remarks', " _
                      + " CONCAT(UCASE(SUBSTRING(`status`, 1, 1)),LOWER(SUBSTRING(`status`, 2)))  as 'Status', " _
                      + " appdescription as 'Transaction Type'," _
                      + " DATECONFIRM as 'Date Confirmed' " _
                      + " from tblapprovalhistory  WHERE referenceno = '" & pid.Text & "' order by DATECONFIRM asc", "tblapprovalhistory", Bm, GridView2, Me)

        GridView2.Columns("Remarks").ColumnEdit = MemoEdit
        GridView2.Columns("Remarks").Width = 200
    End Sub

    Public Function filterTransactionOrderOrder(ByVal pid As String)
        LoadXgrid("Select  ponumber as 'Reference No.', " _
                   + " if(forpo=1,'PURCHASE ORDER','PAYMENT ORDER') as 'Transaction Type', " _
                   + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', " _
                   + " (select sum(total) from tblrequisitionsitem where pid=tblpurchaseorder.requestref and vendorid =  tblpurchaseorder.vendorid) as 'Total', " _
                   + " case when corporatelevel=1 then 'CORPORATE MAIN' else '" & UCase(GlobalOfficeCaption) & "' end as 'Request Level', " _
                   + " (select fullname from tblaccounts where accountid = tblpurchaseorder.createby) as 'Created By', date_format(datetrn,'%Y-%m-%d') as 'Date Created',date_format(datetrn,'%r') as 'Time Created', " _
                   + PurchaseOrderStatus.Remove(PurchaseOrderStatus.Length - 2, 2) _
                   + " from tblpurchaseorder where requestref='" & pid & "' order by datetrn desc", "tblpurchaseorder", em2, GridView3, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpurchaseorder")
        em2.DataSource = dst.Tables("tblpurchaseorder")

        '############## MAIN Gridview #####################

        GridView3.BestFitColumns()
        XgridColCurrency({"Total"}, GridView3)
        XgridColWidth({"Total"}, GridView3, 120)
        XgridColAlign({"Reference No.", "Date Created", "Time Created", "Status"}, GridView3, HorzAlignment.Center)

        Dim item1 As New GridGroupSummaryItem()
        item1.FieldName = "Total"
        item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item1.DisplayFormat = "{0:n} Php"
        item1.ShowInGroupColumnFooter = GridView3.Columns("Total")

        GridView3.GroupSummary.Add(item1)
        GridView3.Columns("Total").SummaryItem.SummaryType = SummaryItemType.Sum
        GridView3.Columns("Total").SummaryItem.DisplayFormat = "{0:n}"
        GridView3.Columns("Total").SummaryItem.Tag = 1
        CType(GridView3.Columns("Total").View, GridView).OptionsView.ShowFooter = True


    End Function

    Private Sub cmdViewItem_Click(sender As Object, e As EventArgs) Handles cmdViewItem.Click
        If GridView3.GetFocusedRowCellValue("Transaction Type").ToString = "PURCHASE ORDER" Then
            frmPurchaseOrderProfile.mode.Text = "po"
        Else
            frmPurchaseOrderProfile.mode.Text = ""
        End If
        frmPurchaseOrderProfile.ponumber.Text = GridView3.GetFocusedRowCellValue("Reference No.").ToString
        frmPurchaseOrderProfile.Show(Me)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim report As New rptPurchaseRequest()
        report.pid.Text = StrConv(pid.Text, vbUpperCase)

        com.CommandText = "select *,(select fullname from tblaccounts where accountid=tblrequisitions.requestby) as 'requestor', " _
                        + " (select designation from tblaccounts where accountid=tblrequisitions.requestby) as 'position', " _
                        + " (select DESCRIPTION from tblrequesttype where POTYPEID=tblrequisitions.POTYPEID) as 'potype' from tblrequisitions where pid='" & pid.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            report.txtRequestby.Text = StrConv(rst("requestor").ToString, vbUpperCase)
            report.txtdesignation.Text = rst("position").ToString
            report.txtoffice.Text = txtoffice.Text
            report.txtDateRequest.Text = "Date Request: " & CDate(rst("daterequest").ToString).ToString("MMMM dd, yyyy hh:mm:ss tt")
            report.txtpurchasetype.Text = UCase(rst("potype").ToString)
            report.txtdetails.Text = rst("details").ToString
            report.officeid.Text = rst("officeid").ToString

        End While
        rst.Close()


        XgridColCurrency({"Cost"}, GridView1)
        XgridColCurrency({"Total"}, GridView1)

        XgridColAlign({"Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Total").Summary.Clear()
        GridView1.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n}")
        CType(GridView1.Columns("Total").View, GridView).OptionsView.ShowFooter = True
        GridView1.BestFitColumns()
        report.PaperKind = System.Drawing.Printing.PaperKind.Letter
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Em))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        filterApprovalLogs()
    End Sub

    Private Sub ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        filterApprovalLogs()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        PrintGeneralReport(txtpotype.Text, "Approval History Request No. " & pid.Text, GridView2, Me)
    End Sub
End Class