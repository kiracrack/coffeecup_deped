Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Public Class frmStockoutDepedItemsDetails
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        End If
        Return ProcessCmdKey
    End Function

    Public Sub displayCurrentItems()
        LoadXgrid("Select (select ITEMNAME from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'Item Name', " _
                         + " (select description from tblprocategory where CATID = tblstockoutitem.CATID) as 'Category', " _
                         + " Quantity,Unit ,Remarks, " _
                         + " (select fullname as FULLNAME from tblaccounts where accountid=tblstockoutitem.requestby) as 'Requested by', " _
                         + " date_format(datetrn,'%Y-%m-%d %r') as 'Stockout Date', " _
                         + " (select fullname from tblaccounts where accountid = tblstockoutitem.trnby) as 'Stockout By' " _
                         + " from tblstockoutitem " _
                         + " where batchcode ='" & batchcode.Text & "'", "tblstockoutitem", Em, GridView1, Me)
        XgridColAlign({"Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign({"Stockout Date"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub frmWidrawalItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        displayCurrentItems()
        LoadGridviewAppearance(GridView1)
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim report As New rptStockoutSummary()

        report.txtBatchcode.Text = batchcode.Text
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        report.ShowRibbonPreviewDialog()
        SplashScreenManager.CloseForm()
    End Sub
End Class