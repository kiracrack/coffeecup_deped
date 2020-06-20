Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Public Class frmProductManagement
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.F1) Then
            If globalAllowEdit = True Or LCase(globaluser) = "root" Then
                cmdAddSupplierForItem.PerformClick()
            End If
        
        ElseIf keyData = (Keys.F2) Then
            If globalAllowEdit = True Or LCase(globaluser) = "root" Then
                cmdEdit.PerformClick()
            End If

        ElseIf keyData = (Keys.F3) Then
            txtfilter.SelectAll()
            txtfilter.Focus()

        ElseIf keyData = (Keys.F4) Then
            If globalAllowDelete = True Or LCase(globaluser) = "root" Then
                cmdRemove.PerformClick()
            End If

        ElseIf keyData = (Keys.Control) + Keys.N Then
            If globalAllowAdd = True Or LCase(globaluser) = "root" Then
                AddProduct("", Me)
            End If

        End If
        Return ProcessCmdKey
    End Function


    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter(txtfilter.Text)
    End Sub

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCategory()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdBarAddNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdBarAddNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If MdiCoffeeCup.cmdSupplierManagement.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            If globalAllowEdit = True Or LCase(globaluser) = "root" Then
                cmdEdit.Visible = True
                cmdAddSupplierForItem.Visible = True
                cmdBarAddSupplier.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                cmdEdit.Visible = False
                cmdAddSupplierForItem.Visible = False
                cmdBarAddSupplier.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        Else
            cmdBarAddSupplier.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If MdiCoffeeCup.cmdCFFEInventory.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            cmdFFEassetType.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdFFEassetType.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Visible = True
        Else
            cmdRemove.Visible = False
        End If
        If globalAllowEdit = True Or globalAllowDelete = True Or LCase(globaluser) = "root" Then
            Em.ContextMenuStrip = gridmenustrip
        Else
            Em.ContextMenuStrip = Nothing
        End If
    End Sub
    Public Sub LoadCategory()
        LoadXgridLookupSearch("select catid,DESCRIPTION 'Select Category',ffe from tblprocategory order by DESCRIPTION asc", "tblprocategory", txtprocat, combogrid, Me)
        combogrid.Columns("catid").Visible = False
        combogrid.Columns("ffe").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocat.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("catid").ToString()
        ckFFE.Checked = CBool(txtprocat.Properties.View.GetFocusedRowCellValue("ffe").ToString())
        If ckFFE.Checked = True Then
            SetFFEAssetTypeToolStripMenuItem.Visible = True
        Else
            SetFFEAssetTypeToolStripMenuItem.Visible = False
        End If
        filter("%")
    End Sub

    Public Sub UpdateProduct(ByVal productname As String, ByVal unit As String, ByVal purchasePrice As Double, ByVal sellingCost As Double, ByVal partnumber As String)
        If GridView1.Columns("Particular").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Particular", productname)
        End If
        If GridView1.Columns("Unit").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Unit", unit)
        End If
        If GridView1.Columns("Purchased Price").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Purchased Price", FormatNumber(purchasePrice, 2))
        End If
        If GridView1.Columns("Selling Price").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Selling Price", FormatNumber(sellingCost, 2))
        End If
        If GlobalProductTemplate = 3 Then
            If GridView1.Columns("Part Number").Visible = True Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Part Number", partnumber)
            End If
        End If
    End Sub

    
    Public Sub UpdateProduct4(ByVal barcode As String, ByVal productname As String, ByVal unit As String, ByVal PurchasePrice As Double, ByVal sellingCost As Double, ByVal sellingCost1 As Double, ByVal sellingCost2 As Double, ByVal sellingCost3 As Double, ByVal sellingCost4 As Double, ByVal partnumber As String)
        If GridView1.Columns("Barcode").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Barcode", barcode)
        End If
        If GridView1.Columns("Particular").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Particular", productname)
        End If
        If GridView1.Columns("Unit").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Unit", unit)
        End If
        If GridView1.Columns("Purchased Price").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Purchased Price", FormatNumber(PurchasePrice, 2))
        End If
        If GridView1.Columns("Selling Price (Default)").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Selling Price (Default)", FormatNumber(sellingCost, 2))
        End If
        If GridView1.Columns("Selling Price1").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Selling Price1", FormatNumber(sellingCost1, 2))
        End If
        If GridView1.Columns("Selling Price2").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Selling Price2", FormatNumber(sellingCost2, 2))
        End If
        If GridView1.Columns("Selling Price3").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Selling Price3", FormatNumber(sellingCost3, 2))
        End If
        If GridView1.Columns("Selling Price4").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Selling Price4", FormatNumber(sellingCost4, 2))
        End If

        If GridView1.Columns("Part Number").Visible = True Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Part Number", partnumber)
        End If
        If GlobalEnableEncryptNumbers = True Then
            filter(txtfilter.Text)
        End If
    End Sub

    Public Sub filter(ByVal keywords As String)
        Dim ProductTemplate As String = ""
        LoadXgrid("Select catid, productid as 'Item Code', " _
                            + " ITEMNAME as 'Particular', " _
                            + " (select DESCRIPTION from tblprocategory where CATID = tblglobalproducts.CATID) as 'Category', " _
                            + " (select DESCRIPTION from tblprosubcategory where subcatid = tblglobalproducts.subcatid) as 'Article Name', " _
                            + If(ckFFE.Checked = True, "(select description from tblinventoryffetype where code=tblglobalproducts.ffetype) as 'Asset Type', ", "") _
                            + If(EnableModuleSales = True, "(select sum(quantity) from tblinventory where productid=tblglobalproducts.productid) as 'Available Quantity',", "") & "  Unit,  " _
                            + " (select count(*) from tblitemvendor where itemid = tblglobalproducts.PRODUCTID) as 'Total Supplier' " _
                            + ProductTemplate _
                            + " from tblglobalproducts where deleted=0 " & If(CheckEdit1.Checked = True, "", " and catid='" & catid.Text & "' ") & " " _
                            + " and (ITEMNAME like '%" & rchar(keywords) & "%' or PRODUCTID like '%" & rchar(keywords) & "%' or (select DESCRIPTION from tblprocategory where CATID = tblglobalproducts.CATID) like '%" & rchar(keywords) & "%' or (select DESCRIPTION from tblprosubcategory where subcatid = tblglobalproducts.subcatid) like '%" & rchar(keywords) & "%'  or partnumber like '%" & rchar(keywords) & "%') " _
                            + " order by itemname asc", "tblglobalproducts", Em, GridView1, Me)

        GridView1.Columns("Total Supplier").Width = 90

        XgridColAlign({"Item Code", "Available Quantity", "Barcode", "Non Inventory", "Total Supplier", "Article Name", "Enable Selling", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign({"Selling Rate", "Selling Price", "Selling Price (Default)", "Selling Price1", "Selling Price2", "Selling Price3", "Selling Price4", "Purchase Price (Encypt)", "Selling Price (Encypt)", "Selling Price1 (Encypt)", "Selling Price2 (Encypt)", "Selling Price3 (Encypt)", "Selling Price4 (Encypt)"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Purchased Price", "Selling Rate", "Selling Price", "Selling Price (Default)", "Selling Price1", "Selling Price2", "Selling Price3", "Selling Price4"}, GridView1)
        GridView1.Columns("Item Code").Width = 110
        GridView1.Columns("Unit").Width = 100
        'SaveFilterColumn(GridView1, Me.Text & "-" & If(CheckEdit1.Checked = True, "ALL", catid.Text) & If(ckFFE.Checked = True, "-FFE", ""))
        XgridHideColumn({"catid"}, GridView1)
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Item Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        EditProduct(GridView1.GetFocusedRowCellValue("Item Code").ToString, Me)
    End Sub


    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If GridView1.GetFocusedRowCellValue("Item Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete selected product? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblglobalproducts set deleted=1,datedeleted=current_timestamp,deletedby='" & globalfullname & "' where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code") & "' " : com.ExecuteNonQuery()
            Next
            GridView1.DeleteSelectedRows()
        End If
    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem1.ItemClick
        Me.Close()
    End Sub

    
    Private Sub FormatGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub AddVendorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddSupplierForItem.Click
        If GridView1.GetFocusedRowCellValue("Item Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        frmVendorsProductInfo.itemid.Text = GridView1.GetFocusedRowCellValue("Item Code").ToString
        frmVendorsProductInfo.Show()
    End Sub

    Private Sub txtfilter_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfilter.EditValueChanged

    End Sub

    'Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBarAddSupplier.ItemClick
    '    If GridView1.GetFocusedRowCellValue("Item Code") = "" Then
    '        XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Exit Sub
    '    End If
    '    frmVendorsProductInfo.itemid.Text = GridView1.GetFocusedRowCellValue("Item Code").ToString
    '    frmVendorsProductInfo.Show(Me)
    'End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBarAddNew.ItemClick
        AddProduct("", Me)
    End Sub

    Private Sub BarCheckItem1_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Cursor = Cursors.WaitCursor
        filter(txtfilter.Text)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtfilter.Text = "" Then Exit Sub
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            filter(txtfilter.Text)
            SplashScreenManager.CloseForm()
        End If
    End Sub

    Private Sub cmdColumnFilter_Click(sender As Object, e As EventArgs)
        Dim colname As String = ""
        Dim I As Integer = 0
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtprocat.Properties.ReadOnly = True
        Else
            txtprocat.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub Em_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Em.KeyPress
        If e.KeyChar() = Chr(13) Then
            If globalAllowEdit = True Or LCase(globaluser) = "root" Then
                If GridView1.GetFocusedRowCellValue("Item Code") = "" Then
                    XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If GlobalProductTemplate = 2 Then
                    frmProductDirect2.productid.Text = GridView1.GetFocusedRowCellValue("Item Code").ToString
                    frmProductDirect2.Show(Me)

                ElseIf GlobalProductTemplate = 3 Then
                    frmProductDirect3.productid.Text = GridView1.GetFocusedRowCellValue("Item Code").ToString
                    frmProductDirect3.Show(Me)

                ElseIf GlobalProductTemplate = 4 Then
                    frmProductDirect4.productid.Text = GridView1.GetFocusedRowCellValue("Item Code").ToString
                    frmProductDirect4.Show(Me)
                End If
            End If
        End If
    End Sub

    Private Sub ckFFE_CheckedChanged(sender As Object, e As EventArgs) Handles ckFFE.CheckedChanged
        If ckFFE.Checked = True And globalAllowAdd = True Then
            cmdFFEassetType.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdFFEassetType.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        filter("%")
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintDatagridview(Me.Text, "DATABASE RECORDS", If(CheckEdit1.Checked = True, "ALL PRODUCTS", txtprocat.Text), GridView1, Me)
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub ViewPriceListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPriceListToolStripMenuItem.Click
        frmProductPriceList.productid.Text = GridView1.GetFocusedRowCellValue("Item Code").ToString
        frmProductPriceList.productname.Text = GridView1.GetFocusedRowCellValue("Particular").ToString
        If frmProductPriceList.Visible = True Then
            frmProductPriceList.Focus()
        Else
            frmProductPriceList.Show(Me)
        End If
    End Sub

    Public Sub SetFFEAssetType(ByVal AssetType As String, ByVal ffetypecode As String, ByVal catid As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "catid").ToString = catid Then
                If countqry("tblinventoryffedetails", "productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "'") > 0 Then
                    If XtraMessageBox.Show("System found " & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Particular").ToString & " ffe inventory already recorded! replacing with new FFE asset type will removed existing record." & Environment.NewLine & Environment.NewLine & "NOTE: if not aware of this please select no. and contact your IT Department for assistance" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        com.CommandText = "DELETE from tblinventoryffedetails where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblglobalproducts set ffetype='" & ffetypecode & "' where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblinventoryffe set ffetype='" & ffetypecode & "',flaged=1, flagedreason='FFE asset type was changed by " & StrConv(globalfullname, VbStrConv.ProperCase) & "' where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "'" : com.ExecuteNonQuery()
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Asset Type", AssetType)
                    End If
                Else
                    com.CommandText = "update tblglobalproducts set ffetype='" & ffetypecode & "' where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "'" : com.ExecuteNonQuery()
                    com.CommandText = "update tblinventoryffe set ffetype='" & ffetypecode & "' where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "'" : com.ExecuteNonQuery()
                    GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Asset Type", AssetType)
                End If
            End If
        Next
    End Sub

    Public Sub SetCategory(ByVal categoryname As String, ByVal catid As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblglobalproducts set  catid='" & catid & "' where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblinventory set catid='" & catid & "', categoryname='" & rchar(categoryname) & "' where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "' and quantity > 0 " : com.ExecuteNonQuery()
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Category", categoryname)
        Next
    End Sub
    Public Sub SetSubCategory(ByVal categoryname As String, ByVal catid As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblglobalproducts set subcatid='" & catid & "' where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblofficeequipment set subcatid='" & catid & "' where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblinventory set subcatid='" & catid & "', subcatname='" & rchar(categoryname) & "' where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Item Code").ToString & "'" : com.ExecuteNonQuery()
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Article Name", categoryname)
        Next
    End Sub

    Private Sub SetFFEAssetTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetFFEAssetTypeToolStripMenuItem.Click
        frmSetFFEAssetType.catid.Text = GridView1.GetFocusedRowCellValue("catid").ToString
        If frmSetFFEAssetType.Visible = True Then
            frmSetFFEAssetType.Focus()
        Else
            frmSetFFEAssetType.Show(Me)
        End If
    End Sub

    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If frmSetFFEAssetType.Visible = True Then
            frmSetFFEAssetType.catid.Text = GridView1.GetFocusedRowCellValue("catid").ToString
        End If
    End Sub

    Private Sub cmdFFEassetType_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdFFEassetType.ItemClick
        frmFFETypeManagement.ShowDialog(Me)
    End Sub

    Private Sub SetProductCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetProductCategoryToolStripMenuItem.Click
        If frmSetProductCategory.Visible = True Then
            frmSetProductCategory.Focus()
        Else
            frmSetProductCategory.Show(Me)
        End If
    End Sub

    Private Sub cmdBarAddSupplier_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBarAddSupplier.ItemClick
        If frmProductSubCategory.Visible = True Then
            frmProductSubCategory.Focus()
        Else
            frmProductSubCategory.Show(Me)
        End If
    End Sub

    Private Sub SetSubProductCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetSubProductCategoryToolStripMenuItem.Click
        frmSetProductSubCategory.catid.Text = GridView1.GetFocusedRowCellValue("catid").ToString
        If frmSetProductSubCategory.Visible = True Then
            frmSetProductSubCategory.Focus()
        Else
            frmSetProductSubCategory.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text & "-" & If(CheckEdit1.Checked = True, "ALL", catid.Text) & If(ckFFE.Checked = True, "-FFE", ""))
        frmColumnFilter.ShowDialog(Me)
    End Sub
End Class