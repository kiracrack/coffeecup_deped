Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmHistory_BillingsAndPayments
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
        UpdateReportTitle(Me.Text, "", Me)
        If CheckSelectedRow("id", GridView1) = True Then
            Dim report As New rptInventorySummary()
            
            report.officeid.Text = officeid.Text
            report.txtReportPeriod.Text = "As of " & Format(Now.ToString("MMMM dd, yyyy"))
            report.txtReportType.Text = XtraTabControl1.SelectedTabPage.Text
            report.txtReportTitle.Text = UCase(XtraTabControl1.SelectedTabPage.Text & " of " & StrConv(Me.Text, VbStrConv.ProperCase))
            report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            report.ShowRibbonPreviewDialog()
            SplashScreenManager.CloseForm()
        End If
    End Sub
    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        filterReceived()
        LoadGridviewAppearance(GridView1)
    End Sub

    Public Sub filterReceived()
        LoadXgrid("Select Quantity, Unit, COST as 'Unit Price', Total, date_format(datetrn, '%Y-%m-%d %r') as  'Date Payments', (select companyname from tblglobalvendor where vendorid = tblpurchasedclosed.vendorid) as 'Vendor',  Remarks from tblpurchasedclosed where tblpurchasedclosed.officeid='" & officeid.Text & "' and tblpurchasedclosed.productid='" & itemid.Text & "' " _
                          + " Union select  Quantity, Unit, unitcost, total, date_format(datetrn, '%Y-%m-%d %r'), (select companyname from tblglobalvendor where vendorid = tblinventorylogs.vendorid) as 'Vendor',Remarks from tblinventorylogs where  tblinventorylogs.officeid='" & officeid.Text & "' and tblinventorylogs.productid='" & itemid.Text & "'" _
                          + " order by 'Date Transaction' ", "tblpurchasedclosed", Em, GridView1, Me)

        GridView1.Columns("Vendor").ColumnEdit = MemoEdit
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit

        XgridColCurrency({"Unit Price", "Total"}, GridView1)
        GridView1.BestFitColumns()
        GridView1.Columns("Unit Price").Width = 100
        GridView1.Columns("Vendor").Width = 250
        GridView1.Columns("Remarks").Width = 350
        GridView1.Columns("Total").Width = 180

        XgridColAlign({"Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryNumber({"Quantity"}, GridView1)
        XgridGeneralSummaryCurrency({"Total"}, GridView1)
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2 : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterReceived()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        printreport()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
End Class