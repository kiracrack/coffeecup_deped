Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmProceedNewRequest
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Enter) Then
            If CheckSelectedRow("productid", GridView1) = True Then
                selectCurrPro()
            End If
        ElseIf keyData = (Keys.F4) Then
            Me.Close()

        ElseIf keyData = (Keys.F5) Then
            cmdadd.PerformClick()

        ElseIf keyData = (Keys.F7) Then
            cmdPrint.PerformClick()

        ElseIf keyData = (Keys.Control) + Keys.P Then
            ShowReportPO()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPurchaseOrder_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MdiCoffeeCup.cmdNewRequest.Enabled = True

    End Sub

    Private Sub frmPurchaseRequest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If GridView1.RowCount = 0 Then
            If XtraMessageBox.Show("Are you sure you want to close current request? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "DELETE FROM tblrequisitions where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub frmNewPackage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        loaddetails()
        MdiCoffeeCup.cmdNewRequest.Enabled = False
        LoadGridviewAppearance(GridView1)
        lblOffice.Text = GlobalOfficeCaption
        filter()
    End Sub
    Public Sub loaddetails()
        com.CommandText = "select *, (select officename from tblcompoffice where officeid =tblrequisitions.officeid ) as '" & GlobalOfficeCaption & "', " _
                                 + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'REQUEST', " _
                                 + " (select DESCRIPTION from tblrequesttype where POTYPEID = tblrequisitions.POTYPEID) as 'POTYPE', " _
                                 + " (select designation from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'DESIGNATION', " _
                                 + " case when corporatelevel=1 then 'CORPORATE LEVEL' else '" & UCase(GlobalOfficeCaption) & "' end as level from tblrequisitions where PID='" & pid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            txtoffice.Text = rst(GlobalOfficeCaption).ToString
            txtRequestby.Text = rst("REQUEST").ToString
            potypeid.Text = rst("potypeid").ToString
            txtpotype.Text = rst("POTYPE").ToString
            txtDesignation.Text = rst("DESIGNATION").ToString
            txtdatereq.Text = CDate(rst("DATEREQUEST").ToString)
            txtdetails.Text = rst("DETAILS").ToString
            txtDisbursement.Text = rst("level").ToString
        End While
        rst.Close()
    End Sub
    Public Sub filter()
        LoadXgrid("Select trnid,productid,vendorid,(select itemname from tblglobalproducts where productid = tblrequisitionsitem.productid ) as 'Particular', " _
                      + " QUANTITY as 'Quantity'," _
                      + " UNIT as 'Unit', " _
                      + " COST as 'Cost', " _
                      + " TOTAL as 'Total', " _
                      + " Remarks, " _
                      + " ifnull((select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid ),'Unregistered Vendor') as 'Vendor' " _
                      + " from tblrequisitionsitem " _
                      + " where pid='" & pid.Text & "'", "tblrequisitionsitem", Em, GridView1, Me)

        XgridHideColumn({"trnid", "productid", "vendorid"}, GridView1)
        XgridColCurrency({"Cost", "Total"}, GridView1)

        GridView1.BestFitColumns()
        GridView1.Columns("Quantity").Width = 60
        GridView1.Columns("Cost").Width = 100
        GridView1.Columns("Total").Width = 140
        GridView1.Columns("Remarks").Width = 250
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        XgridColAlign({"Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        RemovedNoValueColumn("Remarks", GridView1, Me)

        GridView1.Columns("Total").Summary.Clear()
        GridView1.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n} Php")
        CType(GridView1.Columns("Total").View, GridView).OptionsView.ShowFooter = True

    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        If gen_filterappearance = True Then
            Dim View As GridView = sender
            Dim vendor As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Vendor"))
            If vendor = "Unregistered Vendor" Then
                If e.Column.FieldName = "Vendor" Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.ForeColor = Color.White
                End If
            End If
        End If
    End Sub


    Public Sub ShowReportPO()
        Dim report As New rptPurchaseRequest()
        report.pid.Text = pid.Text
        report.txtRequestby.Text = StrConv(txtRequestby.Text, vbUpperCase)
        report.txtdesignation.Text = txtDesignation.Text
        report.txtoffice.Text = txtoffice.Text
        report.txtDateRequest.Text = CDate(txtdatereq.Text).ToString("MMMM dd, yyyy hh:mm:ss tt")
        report.txtpurchasetype.Text = UCase(txtpotype.Text)
        report.txtdetails.Text = txtdetails.Text

        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        report.ShowRibbonPreviewDialog()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuclose.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdadd.ItemClick
        frmSelectRequestItem.officeid.Text = officeid.Text
        frmSelectRequestItem.pid.Text = pid.Text
        frmSelectRequestItem.potypeid.Text = potypeid.Text
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmSelectRequestItem.Show(Me)
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Unable to continue! there are no item(s) to approve!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'GridView1.BestFitColumns()
        ShowReportPO()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdfinish.ItemClick
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Unable to continue! there are no item(s) to approve!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf countqry("tblrequisitionsitem", "vendorid = '' and pid='" & pid.Text & "'") > 0 Then
            XtraMessageBox.Show("Unable to continue! Some particular(s) have no vendor assigned, please review your request!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If XtraMessageBox.Show("Are you sure you want to submit this request for approval? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmConfirmedRequestProcessing.pid.Text = pid.Text
            frmConfirmedRequestProcessing.Show(Me)
        End If
    End Sub

    Private Sub EditQuantityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditQuantityToolStripMenuItem.Click
        If CheckSelectedRow("productid", GridView1) = True Then
            selectCurrPro()
        End If
    End Sub
    Public Sub selectCurrPro()
        frmQuantitySelect.trnid.Text = GridView1.GetFocusedRowCellValue("trnid").ToString()
        frmQuantitySelect.mode.Text = "edit"
        frmQuantitySelect.officeid.Text = officeid.Text
        frmQuantitySelect.proid.Text = GridView1.GetFocusedRowCellValue("productid").ToString()
        frmQuantitySelect.pid.Text = pid.Text
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmQuantitySelect.Show(Me)
        SplashScreenManager.CloseForm()
    End Sub

    Public Function UpdateSupplier(ByVal vendorid As String)
        Dim I As Integer = 0
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblrequisitionsitem set vendorid='" & vendorid & "' where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
        Next
        filter()
        Return True
    End Function


    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If CheckSelectedRow("trnid", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                DeleteRow("trnid", "trnid", "tblrequisitionsitem", GridView1, Me)
            End If
        End If
    End Sub

    Private Sub SetSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetSupplierToolStripMenuItem.Click
        frmChangeProductSupplier.mode.Text = "new"
        frmChangeProductSupplier.Show(Me)
    End Sub
End Class