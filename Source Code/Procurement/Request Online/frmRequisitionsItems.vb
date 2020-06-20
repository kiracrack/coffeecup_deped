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
Imports DevExpress.XtraSplashScreen

Public Class frmRequisitionsItems
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPurchaseItems_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        pid.Text = ""
    End Sub
    Private Sub frmPurchaseItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        ' LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(GridView2)
        lblOffice.Text = GlobalOfficeCaption
    End Sub

    Private Sub pid_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pid.EditValueChanged
        If pid.Text = "" Then Exit Sub
        loaddetails()
        filterActual()
        filterApprovalLogs()
    End Sub
    
    Public Function loaddetails()
        Dim received As Boolean = False
        com.CommandText = "select *, (select officename from tblcompoffice where officeid =tblrequisitions.officeid ) as '" & GlobalOfficeCaption & "', " _
                                 + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'REQUEST', " _
                                 + " (select DESCRIPTION from tblrequesttype where POTYPEID = tblrequisitions.POTYPEID) as 'POTYPE', " _
                                 + " (select designation from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'DESIGNATION', " _
                                 + " case when corporatelevel=1 then 'CORPORATE MAIN' else '" & UCase(GlobalOfficeCaption) & "' end as disbursement, " _
                                 + " case when cancelled=1 and disapproved=0 then 'Cancelled' " _
                                          + " when cancelled=0 and disapproved=1 then 'Disapproved' " _
                                          + " when hold=1 then 'On Hold' " _
                                          + " when approvedbranch=0 then 'Pending' " _
                                          + " else 'Approved' end as 'Status' " _
                                 + " from tblrequisitions where pid='" & pid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            txtoffice.Text = rst(GlobalOfficeCaption).ToString
            reqid.Text = rst("REQUESTBY").ToString
            txtRequestby.Text = rst("REQUEST").ToString
            txtDesignation.Text = rst("DESIGNATION").ToString
            txtdatereq.Text = rst("DATEREQUEST").ToString
            txtdetails.Text = rst("DETAILS").ToString
            txtpotype.Text = rst("POTYPE").ToString
            txtDisbursement.Text = rst("disbursement").ToString
            If GlobalDirectApprovedPr = True Then
                txtStatus.Text = "REQUISITION"
            Else
                txtStatus.Text = UCase(rst("Status").ToString)
            End If
            received = CBool(rst("received"))
        End While
        rst.Close()

        If txtStatus.Text = "APPROVED" Or txtStatus.Text = "REQUISITION" Then
            txtStatus.Properties.Appearance.BackColor = Color.Lime
            txtStatus.Properties.Appearance.ForeColor = Color.Black
            cmdPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            If received = False Then
                cmdConfirm.Visible = True
            Else
                cmdConfirm.Visible = False
            End If
        ElseIf txtStatus.Text = "FOR APPROVAL" Or txtStatus.Text = "ON HOLD" Or txtStatus.Text.Contains("PENDING") = True Then
            txtStatus.Properties.Appearance.BackColor = Color.Orange
            txtStatus.Properties.Appearance.ForeColor = Color.Black
            cmdPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdConfirm.Visible = False

        ElseIf txtStatus.Text = "DISAPPROVED" Or txtStatus.Text = "CANCELLED" Then
            txtStatus.Properties.Appearance.BackColor = Color.Red
            txtStatus.Properties.Appearance.ForeColor = Color.White
            cmdPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdConfirm.Visible = False

        End If
        Return 0
    End Function
    Public Function filterActual()
        LoadXgrid("Select trnid, (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Particular', " _
                                + " ifnull((select sum(quantity) from tblinventory where quantity>0 and officeid=tblrequisitionsitem.officeid and productid=tblrequisitionsitem.productid),0) as 'Onhand Quantity', " _
                                + " QUANTITY as 'Quantity'," _
                                + " UNIT as 'Unit', " _
                                + " COST as 'Cost', " _
                                + " TOTAL as 'Total', " _
                                + " Remarks, " _
                                + " (select companyname from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid) as 'Vendor' " _
                                + " from tblrequisitionsitem " _
                                + " where pid='" & pid.Text & "'", "tblrequisitionsitem", Em, GridView1, Me)
        XgridHideColumn({"trnid"}, GridView1)
        XgridColCurrency({"Cost", "Total"}, GridView1)
        GridView1.BestFitColumns()
        GridView1.Columns("Onhand Quantity").Width = 60
        GridView1.Columns("Quantity").Width = 60
        GridView1.Columns("Cost").Width = 100
        GridView1.Columns("Total").Width = 120
        GridView1.Columns("Remarks").Width = 250
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        XgridColAlign({"Onhand Quantity", "Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        RemovedNoValueColumn("Remarks", GridView1, Me)
        GridView1.Columns("Total").Summary.Clear()
        GridView1.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n}")
        CType(GridView1.Columns("Total").View, GridView).OptionsView.ShowFooter = True

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
    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filterActual()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        filterApprovalLogs()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmUserProfile.formatGrid(GridView2)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
        Dim report As New rptPurchaseRequest()
        report.pid.Text = pid.Text

        com.CommandText = "select *,(select fullname from tblaccounts where accountid=tblrequisitions.requestby) as 'requestor', " _
                        + " (select designation from tblaccounts where accountid=tblrequisitions.requestby) as 'position', " _
                        + " (select DESCRIPTION from tblrequesttype where POTYPEID=tblrequisitions.POTYPEID) as 'potype' from tblrequisitions where pid='" & pid.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            report.txtRequestby.Text = StrConv(rst("requestor").ToString, vbUpperCase)
            report.txtdesignation.Text = rst("position").ToString
            report.txtoffice.Text = txtoffice.Text
            report.txtDateRequest.Text = CDate(rst("daterequest").ToString).ToString("MMMM dd, yyyy hh:mm:ss tt")
            report.txtpurchasetype.Text = UCase(rst("potype").ToString)
            report.txtdetails.Text = rst("details").ToString
            report.officeid.Text = rst("officeid").ToString
        End While
        rst.Close()

        report.PaperKind = System.Drawing.Printing.PaperKind.Letter
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Em))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If countqry("tblrequisitionsitem", "ifnull((select companyname from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid),'') = '' and pid='" & pid.Text & "'") > 0 Then
            XtraMessageBox.Show("Please update supplier for each item! before submitting for approval", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblrequisitions set received=1 where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            RecordApprovingHistory("requisition", pid.Text, pid.Text, "Processed", "Requisition recieved and submitted for approval")
            NextEmailCorporateLevelRequisitionApprover(pid.Text, txtpotype.Text, "")
            InsertEmailNotification("requisition", getEmailAccount(reqid.Text), "RECEIVED REQUEST AND SUBMITED FOR CORPORATE APPROVAL (" & pid.Text & ") ", FormatingEmailRequisition(pid.Text, UCase(txtpotype.Text)), "")
            cmdConfirm.Visible = False
            frmOnlineRequisitionList.FilterOption()
            XtraMessageBox.Show("Request successfully received and submitted for approval", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdPrintApprovalHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintApprovalHistory.ItemClick
        PrintGeneralReport(txtpotype.Text, "Approval History Request No. " & pid.Text, GridView2, Me)
    End Sub

    Private Sub SetSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetSupplierToolStripMenuItem.Click
        frmChangeProductSupplier.mode.Text = "online"
        frmChangeProductSupplier.Show(Me)
    End Sub
    Public Function UpdateSupplier(ByVal vendorid As String)
        Dim I As Integer = 0
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblrequisitionsitem set vendorid='" & vendorid & "' where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
        Next
        filterActual()
        Return True
    End Function

    Private Sub ChangeUnitCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeUnitCostToolStripMenuItem.Click
        frmChangePrice.pid.Text = pid.Text
        frmChangePrice.trnid.Text = GridView1.GetFocusedRowCellValue("trnid").ToString
        frmChangePrice.txtQuantity.Text = GridView1.GetFocusedRowCellValue("Quantity").ToString
        frmChangePrice.txtUnitCost.Text = GridView1.GetFocusedRowCellValue("Cost").ToString
        frmChangePrice.Text = GridView1.GetFocusedRowCellValue("Particular").ToString
        frmChangePrice.ShowDialog(Me)
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "DELETE FROM tblrequisitionsitem where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                RecordApprovingHistory("requisition", pid.Text, pid.Text, "item remove", "Remove item name " & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Particular").ToString)
            Next
            filterActual()
        End If
    End Sub
End Class