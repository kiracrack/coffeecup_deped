Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmHistory_AllocatedExpenses
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then
           

        ElseIf keyData = (Keys.Control) + Keys.P Then
            printreport()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub printreport()
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("There's no transaction to print!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim report As New rptInventorySummary()

        report.officeid.Text = officeid.Text
        report.txtReportPeriod.Text = "As of " & Format(Now.ToString("MMMM dd, yyyy"))
        report.txtReportType.Text = XtraTabControl1.SelectedTabPage.Text
        report.txtReportTitle.Text = UCase(Me.Text)
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        report.ShowRibbonPreviewDialog()
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        If countqry("tblreportsetting", "formname='" & Me.Text & "'") = 0 Then
            com.CommandText = "insert into tblreportsetting set formname='" & Me.Name & "',title='" & Me.Text & "'" : com.ExecuteNonQuery()
        End If
        filterReceived()
        LoadGridviewAppearance(GridView1)
    End Sub

    Public Sub filterReceived()
        LoadXgrid("Select ponumber as 'PO Number', " _
                           + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tblpurchaseorderitem.PRODUCTID) as 'Product', " _
                           + " tblprocategory.description as 'Category', " _
                           + " Quantity,Unit, total as 'Amount', date_format(datetrn, '%Y-%m-%d %r') as 'Date Purchased',(select companyname from tblglobalvendor where vendorid=tblpurchaseorderitem.vendorid) as 'Vendor', Remarks " _
                           + " from tblpurchaseorderitem inner join tblprocategory on tblpurchaseorderitem.catid = tblprocategory.catid where allocatedrefcode='" & refcode.Text & "'" _
                           + " ", "tblpurchaseorderitem", Em, GridView1, Me)


        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        GridView1.BestFitColumns()
        GridView1.Columns("Remarks").Width = 250
        XgridColAlign({"PO Number", "Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Amount").Width = 150
        XgridColCurrency({"Amount"}, GridView1)

        XgridGroupSummaryCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2 : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterReceived()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        printreport()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
       
    End Sub

End Class