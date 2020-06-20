Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmDirectPurchaseOrderItem
    Private Sub frmSelectPOItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
     
        txtfilter.Focus()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdBaritemAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdBaritemAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.F3) Then
            txtfilter.SelectAll()
            txtfilter.Focus()

        ElseIf keyData = (Keys.F5) Then
            filterItem()

        ElseIf keyData = (Keys.Control + Keys.N) Then
            If globalAllowAdd = True Or LCase(globaluser) = "root" Then
                BarButtonItem3.PerformClick()
            End If

        End If

        Return ProcessCmdKey
    End Function
 
    Public Sub filterItem()
        If ckCompanyProducts.Checked = True Then
            LoadXgrid("select productid, itemname as 'Product',tblitemvendor.Unit,tblitemvendor.procost as 'Unit Price'  " _
                                  + " from tblglobalproducts inner join tblitemvendor on tblglobalproducts.productid = tblitemvendor.itemid where vendorid='" & vendorid.Text & "' and deleted=0 order by itemname asc", "tblglobalproducts", Em, GridView1, Me)
        Else
            LoadXgrid("select productid, itemname as 'Product',  Unit, purchasedprice as 'Unit Price' from tblglobalproducts where itemname like '%" & txtfilter.Text & "%' or productid like '%" & txtfilter.Text & "%' and deleted=0 order by itemname asc", "tblglobalproducts", Em, GridView1, Me)
        End If

        GridView1.Columns("productid").Visible = False
        GridView1.Columns("Product").Width = 600
        XgridColCurrency({"Unit Price"}, GridView1)
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        filterItem()
    End Sub

    Private Sub SelectItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectItemToolStripMenuItem.Click
        If CheckSelectedRow("productid", GridView1) = True Then
            frmDirectPurchaseOrderItemSelect.txtItemname.Text = GridView1.GetFocusedRowCellValue("Product").ToString()
            frmDirectPurchaseOrderItemSelect.ponumber.Text = ponumber.Text
            frmDirectPurchaseOrderItemSelect.officeid.Text = officeid.Text
            frmDirectPurchaseOrderItemSelect.vendorid.Text = vendorid.Text
            frmDirectPurchaseOrderItemSelect.proid.Text = GridView1.GetFocusedRowCellValue("productid").ToString()
            frmDirectPurchaseOrderItemSelect.txtsti.Text = GridView1.GetFocusedRowCellValue("Unit Price").ToString()
            frmDirectPurchaseOrderItemSelect.Show(Me)
        End If
    End Sub

    
    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            filterItem()
            SplashScreenManager.CloseForm()
        End If
    End Sub
     
    Private Sub EditParticularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("productid") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        EditProduct(GridView1.GetFocusedRowCellValue("productid").ToString, Me)
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        AddProduct("po", Me)
    End Sub

    Private Sub ckCompanyProducts_CheckedChanged(sender As Object, e As EventArgs) Handles ckCompanyProducts.CheckedChanged
        If ckCompanyProducts.Checked = True Then
            filterItem()
        Else
            If txtfilter.Text = "" Then Exit Sub
              filterItem()
        End If

    End Sub

    Private Sub Em_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Em.KeyPress
        If e.KeyChar = Chr(13) Then
            SelectItemToolStripMenuItem.PerformClick()
        End If
    End Sub
End Class