Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmInventoryConsumables
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If
        ElseIf keyData = Keys.F3 Then
            txtFilterName.SelectAll()
            txtFilterName.Focus()

        ElseIf keyData = (Keys.Control) + Keys.P Then
            PrintReport()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        loadInventoryTo()
        loadCategory()
 
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(GridView2)
        LoadGridviewAppearance(gv_inventory)

        CheckUserAccess()
        If LCase(globaluser) = "root" Then
            cmdBalanceForward.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdBalanceForward.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub

    Public Sub CheckUserAccess()
        If ckStockSequence.Checked = True Then
            If GlobalEnableConsumableAdjustment = True Then
                If globalApproverPermission = True Or LCase(globaluser) = "root" Then
                    cmdAdjustment.Visible = True
                Else
                    cmdAdjustment.Visible = False
                End If
            Else
                cmdAdjustment.Visible = False
            End If


            If globalAllowDelete = True Or LCase(globaluser) = "root" Then
                cmdRemove.Visible = True
            Else
                cmdRemove.Visible = False
            End If

            If globalAllowEdit = True Or LCase(globaluser) = "root" Then
                cmdStockout.Visible = True
                cmdUpdateInfo.Visible = True
            Else
                cmdStockout.Visible = False
                cmdUpdateInfo.Visible = False
            End If
        Else
            cmdAdjustment.Visible = False
            cmdRemove.Visible = False
            cmdStockout.Visible = False
            cmdUpdateInfo.Visible = False
        End If

    End Sub
    Private Sub ck_category_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_category.CheckedChanged
        If ck_category.Checked = True Then
            txtcategory.Enabled = False
            txtcategory.Properties.DataSource = False
            txtcategory.Text = ""
        Else
            loadCategory()
            txtcategory.Enabled = True
        End If
    End Sub
    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Inventory' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()

    End Sub

    Private Sub cmdaction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        'If ck_category.Checked = True And ck_inventory.Checked = True Then
        '    If XtraMessageBox.Show("Viewing large data may take a while, depending on the amount of data. " & Environment.NewLine & "Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
        '        FilterInventoryReports()
        '    End If
        'Else
        '    FilterInventoryReports()
        'End If
        FilterInventoryReports()
        SplashScreenManager.CloseForm()
    End Sub

    Public Sub FilterInventoryReports()
        If ckStockSequence.Checked = True Then
            filterInventoryDetails()
        Else
            filterInventorySummary()
        End If
    End Sub
    Public Sub filterInventorySummary()
        LoadXgrid("Select officeid,(select officename from tblcompoffice where officeid=tblinventory.officeid) as 'OFFICE' , " _
                        + " productid as 'Product No.', " _
                        + " subcatname as 'Article Name'," _
                        + " productname as 'Particular', " _
                        + If(GlobalEnableStockHouse = True, "ifnull((select stockhousename from tblstockhouse where stockhouseid=tblinventory.stockhouseid),'MAIN STOCK HOUSE') as 'Stock House',", "") _
                        + " categoryname as 'Category', " _
                        + " Case when prepaid=1 then 'Prepaid' else 'On hand' end as 'Inventory Type', " _
                        + " sum(quantity) as 'Available Quantity',Unit, " _
                        + " date_format(lastupdate, '%Y-%m-%d %r') as 'Last Update' " _
                        + " from tblinventory where  " _
                        + If(ck_category.Checked = True, "", " catid='" & catid.Text & "' and ") _
                        + If(ck_inventory.Checked = True, "", " officeid ='" & officeid.Text & "' and ") _
                        + " quantity > 0 and (productname like '%" & rchar(txtFilterName.Text) & "%' or productid like '%" & rchar(txtFilterName.Text) & "%') group by officeid,productid order by productname,quantity asc" _
                        + " ", "tblinventory", Em, GridView1, Me)

        If ck_inventory.Checked = True Then
            GridView1.Columns("OFFICE").Group()
            GridView1.ExpandAllGroups()
        Else
            GridView1.Columns("OFFICE").Visible = False
        End If

        GridView1.Columns("officeid").Visible = False
        XgridColAlign({"Product No.", "Article Name", "Last Update"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()

        XgridColCurrencyDecimalCount({"Available Quantity"}, 4, GridView1)
        GridView1.Columns("Available Quantity").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        GridView1.Columns("Inventory Type").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        CheckUserAccess()
    End Sub

    Public Sub filterInventoryDetails()
        LoadXgrid("Select trnid, trnid as 'Stock No.', stockref as 'Stock Ref', officeid,catid, " _
                        + " (select officename from tblcompoffice where officeid=tblinventory.officeid) as 'OFFICE' , " _
                        + " productid as 'Product No.', " _
                        + " subcatname as 'Article Name'," _
                        + " productname as 'Particular', " _
                        + If(GlobalEnableStockHouse = True, "ifnull((select stockhousename from tblstockhouse where stockhouseid=tblinventory.stockhouseid),'MAIN STOCK HOUSE') as 'Stock House',", "") _
                        + " categoryname as 'Category', " _
                        + " Case when prepaid=1 then 'Prepaid' else 'On hand' end as 'Inventory Type', " _
                        + " quantity as 'Available Quantity',Unit, " _
                        + " purchasedprice as 'Purchased Price',(purchasedprice*QUANTITY) as 'Total', " _
                        + If(EnableModuleSales = True, " sellingprice  as 'Selling Price', ", "") _
                        + " date_format(lastupdate, '%Y-%m-%d %r') as 'Last Update', " _
                        + " date_format(lastupdate, '%Y-%m-%d %r') as 'Date Inventory' " _
                        + " from tblinventory where " _
                        + If(ck_showzeroquantity.Checked = True, " ", " quantity>0 and ") _
                        + If(ck_category.Checked = True, "", " catid='" & catid.Text & "' and ") _
                         + If(ck_inventory.Checked = True, "", " officeid ='" & officeid.Text & "' and ") _
                        + " (productname like '%" & rchar(txtFilterName.Text) & "%' or productid like '%" & rchar(txtFilterName.Text) & "%') order by productname,quantity asc" _
                        + " ", "tblinventory", Em, GridView1, Me)

        If ck_inventory.Checked = True Then
            GridView1.Columns("OFFICE").Group()
            GridView1.ExpandAllGroups()
        Else
            GridView1.Columns("OFFICE").Visible = False
        End If

        GridView1.Columns("trnid").Visible = False
        GridView1.Columns("officeid").Visible = False
        GridView1.Columns("catid").Visible = False
        XgridColAlign({"Product No.", "Last Update", "Date Inventory", "Stock No.", "Stock Ref"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()

        GridView1.Columns("Total").Width = 120

        XgridColCurrencyDecimalCount({"Available Quantity"}, 4, GridView1)
        XgridColCurrency({"Purchased Price"}, GridView1)
        XgridColCurrency({"Total"}, GridView1)

        GridView1.Columns("Available Quantity").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        GridView1.Columns("Inventory Type").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center

        XgridColCurrency({"Total", "Selling Price"}, GridView1)
        XgridGroupSummaryCurrency({"Total", "Selling Price"}, GridView1)
        XgridGeneralSummaryCurrency({"Total", "Selling Price"}, GridView1)
         
        CheckUserAccess()
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        cmdHistory.PerformClick()
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If gen_filterappearance = True Then
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Available Quantity"))
            If Val(CC(status)) <= 2 Then
                e.Appearance.ForeColor = Color.Red
                ' e.Appearance.ForeColor = Color.White
            ElseIf Val(CC(status)) > 2 And Val(CC(status)) <= 6 Then
                e.Appearance.ForeColor = Color.Maroon
                ' e.Appearance.ForeColor = Color.Black
            End If
        End If
    End Sub

    Public Sub loadCategory()
        LoadXgridLookupEdit("select distinct(tblpurchaseorderitem.CATID), tblprocategory.DESCRIPTION from tblprocategory inner join tblpurchaseorderitem where tblpurchaseorderitem.CATID= tblprocategory.CATID and consumable=1 ", "tblprocategory", txtcategory, GridView2, Me)
        GridView2.Columns("CATID").Visible = False
    End Sub

    Private Sub txtcategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcategory.EditValueChanged
        catid.Text = ""
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtcategory.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtcategory.Properties.View.GetFocusedRowCellValue("CATID").ToString()
        txtcategory.Text = txtcategory.Properties.View.GetFocusedRowCellValue("DESCRIPTION").ToString()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        cmdaction.PerformClick()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2 : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub checkother_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadCategory()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub ViewInventoryDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdHistory.Click
        frmHistory_Consumables.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
        frmHistory_Consumables.itemid.Text = GridView1.GetFocusedRowCellValue("Product No.").ToString
        If ckStockSequence.Checked = True Then
            frmHistory_Consumables.stockno.Text = GridView1.GetFocusedRowCellValue("Stock Ref").ToString
        End If

        frmHistory_Consumables.Text = GridView1.GetFocusedRowCellValue("Particular").ToString

        If frmHistory_Consumables.Visible = False Then
            frmHistory_Consumables.Show(Me)
        End If
    End Sub


    Private Sub ck_inventory_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
        End If
    End Sub


    Public Sub PrintReport()
       
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        GenerateInventoryDepedTemplate(Now, "select * from tblinventory where " _
                      + If(ck_showzeroquantity.Checked = True, " (quantity>0 or quantity=0)  ", "  quantity>0   ") _
                      + If(ck_category.Checked = True, "", " and catid='" & catid.Text & "'  ") _
                       + If(ck_inventory.Checked = True, "", " and officeid ='" & officeid.Text & "' ") & " order by subcatname, productname asc ", Me)
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub
    Private Sub rc_rdamage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdjustment.Click
        If CheckSelectedRow("Product No.", GridView1) = True Then
            frmUtilAdjustment.trnid.Text = GridView1.GetFocusedRowCellValue("trnid").ToString
            frmUtilAdjustment.Show(Me)
        End If
    End Sub
    Public Sub ItemAdjustmentValue(ByVal quantity As Double, ByVal unitcost As Double, ByVal sellingcost As Double, ByVal total As Double)
        For I = 0 To GridView1.SelectedRowsCount - 1
            If GridView1.Columns("Available Quantity").Visible = True Then
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Available Quantity", quantity)
            End If
            If GridView1.Columns("Purchased Price").Visible = True Then
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Purchased Price", unitcost)
            End If
            If GridView1.Columns("Selling Price").Visible = True Then
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Selling Price", sellingcost)
            End If
            If GridView1.Columns("Total").Visible = True Then
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Total", total)
            End If
        Next

    End Sub

    Private Sub BarCheckItem1_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub RemoveInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item?" & Environment.NewLine & Environment.NewLine & "NOTE: There's no UNDO function to retrived deleted inventory!", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            DeleteRow("trnid", "trnid", "tblinventory", GridView1, Me)
        End If
    End Sub

    Private Sub cmdExportToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel("Inventory consumable summary " & If(ck_inventory.Checked = True, "all office", txtInventory.Text) & " as of " & CDate(Now).ToString("yyyy-MM-dd"), GridView1)
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        frmLockInventoryCutoff.ShowDialog(Me)
    End Sub

    Private Sub txtFilterName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFilterName.KeyPress
        If e.KeyChar() = Chr(13) Then
            If ck_inventory.Checked = False And txtInventory.Text = "" Then
                XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtInventory.Focus()
                Exit Sub
            ElseIf ck_category.Checked = False And txtcategory.Text = "" Then
                XtraMessageBox.Show("Please select category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcategory.Focus()
                Exit Sub
            End If
            FilterInventoryReports()
            txtFilterName.SelectAll()
            txtFilterName.Focus()
        End If
    End Sub

    Private Sub UnitConverterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitConverterToolStripMenuItem.Click
        If CheckSelectedRow("Product No.", GridView1) = True Then
            If ckStockSequence.Checked = False Then
                'XtraMessageBox.Show("Current Product currently not configure, Please add product convertion to this item!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                frmUtilUnitConverterInfo.productid_source.Text = GridView1.GetFocusedRowCellValue("Product No.").ToString
                frmUtilUnitConverterInfo.txtSourceProduct.Text = GridView1.GetFocusedRowCellValue("Particular").ToString
                frmUtilUnitConverterInfo.txtSourceUnitType.Text = GridView1.GetFocusedRowCellValue("Unit").ToString
                frmUtilUnitConverterInfo.txtSourceQuantity.Text = "1"
                frmUtilUnitConverterInfo.txtTargetQuantity.Focus()
                frmUtilUnitConverterInfo.Show(Me)
            Else
                If countqry("tblunitconverter", "productid_source='" & GridView1.GetFocusedRowCellValue("Product No.").ToString & "'") = 0 Then
                    XtraMessageBox.Show("Current Product currently not configure, Please add product convertion to this item!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    frmUtilUnitConverterInfo.productid_source.Text = GridView1.GetFocusedRowCellValue("Product No.").ToString
                    frmUtilUnitConverterInfo.txtSourceProduct.Text = GridView1.GetFocusedRowCellValue("Particular").ToString
                    frmUtilUnitConverterInfo.txtSourceUnitType.Text = GridView1.GetFocusedRowCellValue("Unit").ToString
                    frmUtilUnitConverterInfo.txtSourceQuantity.Text = "1"
                    frmUtilUnitConverterInfo.txtTargetQuantity.Focus()
                    frmUtilUnitConverterInfo.Show(Me)
                Else
                    frmUtilUnitConvertion.trnid.Text = GridView1.GetFocusedRowCellValue("trnid").ToString
                    frmUtilUnitConvertion.Show(Me)
                End If
            End If
        End If
    End Sub

    Private Sub cmdStockout_Click(sender As Object, e As EventArgs) Handles cmdStockout.Click
        If CheckSelectedRow("Particular", GridView1) = True Then
            frmStockoutQuantity.stockid.Text = GridView1.GetFocusedRowCellValue("trnid").ToString
            If frmStockoutQuantity.Visible = True Then
                frmStockoutQuantity.Focus()
            Else
                frmStockoutQuantity.Show(Me)
            End If
        End If
    End Sub
 
    
    Private Sub ckStockSequence_CheckedChanged(sender As Object, e As EventArgs) Handles ckStockSequence.CheckedChanged
        FilterInventoryReports()
    End Sub

    Private Sub cmdUpdateInfo_Click(sender As Object, e As EventArgs) Handles cmdUpdateInfo.Click
        If CheckSelectedRow("Product No.", GridView1) = True Then
            frmUtilUpdateInventoryInfo.trnid.Text = GridView1.GetFocusedRowCellValue("trnid").ToString
            frmUtilUpdateInventoryInfo.Show(Me)
        End If
    End Sub
 
    Private Sub cmdBalanceForward_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBalanceForward.ItemClick
        frmInventoryBalanceForward.Show(Me)
    End Sub
End Class