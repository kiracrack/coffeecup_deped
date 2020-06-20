Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Public Class frmStockoutDepedInventory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.F3) Then
            txtfilter.Focus()
        ElseIf keyData = Keys.F1 Then

        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmWidrawalInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        filter()
        LoadGridviewAppearance(inventoryGrid)
    End Sub
    Public Sub filter()
        LoadXgrid("Select trnid, productname as 'Product Name', " _
                        + " categoryname  as 'Category', " _
                        + " quantity as 'Quantity', Unit, purchasedprice as 'Unit Cost' " _
                        + " from tblinventory where officeid='" & officeid.Text & "' and (productname like '%" & txtfilter.Text & "%' or productid like '%" & txtfilter.Text & "%')  and quantity > 0  order by productname asc", "tblinventory", Em, inventoryGrid, Me)
        inventoryGrid.BestFitColumns()
        inventoryGrid.Columns("trnid").Visible = False
        XgridColAlign({"Quantity"}, inventoryGrid, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Product Name", "Category"}, inventoryGrid, 180)
        XgridColCurrency({"Unit Cost"}, inventoryGrid)

    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Private Sub Em_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Em.KeyPress
        If e.KeyChar() = Chr(13) Then
            ShowStockoutQuan()
        End If
    End Sub
    Private Sub Em_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Em.DoubleClick
        ShowStockoutQuan()
    End Sub

    Private Sub menuView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuView.Click
        ShowStockoutQuan()
    End Sub
    Public Sub ShowStockoutQuan()
        If CheckSelectedRow("Product Name", inventoryGrid) = True Then
            If mode.Text = "batch" Then
                frmStockoutDepedQuantity.officeid.Text = officeid.Text
                frmStockoutDepedQuantity.alllocatedofficeid.Text = alllocatedofficeid.Text
                frmStockoutDepedQuantity.batchcode.Text = batchcode.Text
                frmStockoutDepedQuantity.txtDateStockout.Text = txtDate.Text
                frmStockoutDepedQuantity.stockid.Text = inventoryGrid.GetFocusedRowCellValue("trnid").ToString
                frmStockoutDepedQuantity.Show(Me)
            Else
                frmStockoutQuantity.batchcode.Text = batchcode.Text
                frmStockoutQuantity.officeid.Text = officeid.Text
                frmStockoutQuantity.stockid.Text = inventoryGrid.GetFocusedRowCellValue("trnid").ToString
                frmStockoutQuantity.Show(Me)
            End If

        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ShowStockoutQuan()
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            filter()
        End If
    End Sub


End Class