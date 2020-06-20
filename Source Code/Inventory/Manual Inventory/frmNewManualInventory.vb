Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.IO
Imports DevExpress.Skins

Public Class frmNewManualInventory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Public Sub loadProducts()
        LoadXgridLookupSearch("SELECT distinct(productid),tblglobalproducts.catid, if(partnumber='' or partnumber is null,itemname,concat(itemname,'-',partnumber)) as 'Select Product' , Unit, purchasedprice from tblglobalproducts inner join tblprocategory on  tblprocategory.catid = tblglobalproducts.catid where deleted=0 and consumable=1 order by itemname asc ", "tblglobalproducts", txtProduct, g_product, Me)
        g_product.BestFitColumns()
        g_product.Columns("productid").Visible = False
        g_product.Columns("catid").Visible = False
        g_product.Columns("purchasedprice").Visible = False

    End Sub

    Private Sub txtProduct_Click(sender As Object, e As EventArgs) Handles txtProduct.Click
        g_product.BestFitColumns()
    End Sub
    Private Sub txtProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProduct.Properties.View.FocusedRowHandle.ToString)
        productid.Text = txtProduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        catid.Text = txtProduct.Properties.View.GetFocusedRowCellValue("catid").ToString()
        txtUnit.Text = txtProduct.Properties.View.GetFocusedRowCellValue("Unit").ToString()
        txtUnitCost.Text = txtProduct.Properties.View.GetFocusedRowCellValue("purchasedprice").ToString()
        txtProduct.Text = txtProduct.Properties.View.GetFocusedRowCellValue("Select Product").ToString()

        If txtProduct.Text = "" Then
            cmdEditItem.Enabled = False
        Else
            cmdEditItem.Enabled = True
        End If
        txtQuantity.Focus()
    End Sub

    Private Sub frmManualStockin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        loadProducts()
    End Sub

    Private Sub frmInventoryManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(g_product)
        LoadGridviewAppearance(gridcompoffice)
        LoadGridviewAppearance(gridstockhouse)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gridvendor)
        loadCompOffice()
        loadProducts()
        loadVendor()
        batchcode.Text = getGlobalTrnid("BAT", globaluserid)
        trncode.Text = getGlobalTrnid("mtr", globaluserid)
        txtdatepurchased.EditValue = CDate(Now).ToString("MMMM dd, yyyy")
        filterBatch()
        If AppEnableBeginvendor = True Then
            txtVendor.Text = AppBeginvendorName
            vendorid.Text = AppBeginvendorId
        End If
    End Sub
    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as '" & GlobalOfficeCaption & "' from tblcompoffice order by officename asc", "tblcompoffice", txtoffice, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False
        Me.txtoffice.Properties.DisplayMember = GlobalOfficeCaption
        Me.txtoffice.Properties.ValueMember = GlobalOfficeCaption
    End Sub
    Private Sub txtcompoffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtoffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
        txtoffice.Text = txtoffice.Properties.View.GetFocusedRowCellValue(GlobalOfficeCaption).ToString
        LoadStockhouse()
    End Sub
    Public Sub LoadStockhouse()
        If officeid.Text = "" Then Exit Sub
        LoadXgridLookupSearch("select stockhouseid, stockhousename as 'Stock House' from tblstockhouse where officeid='" & officeid.Text & "' order by stockhousename asc", "tblstockhouse", txtStockHouse, gridstockhouse, Me)
        gridstockhouse.Columns("stockhouseid").Visible = False
    End Sub

    Private Sub txtStockHouse_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStockHouse.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
        stockhouseid.Text = txtStockHouse.Properties.View.GetFocusedRowCellValue("stockhouseid").ToString
        txtStockHouse.Text = txtStockHouse.Properties.View.GetFocusedRowCellValue(GlobalOfficeCaption).ToString
    End Sub

    Public Sub loadVendor()
        LoadXgridLookupSearch("select vendorid, companyname as 'Supplier' from tblglobalvendor order by companyname asc", "tblglobalvendor", txtVendor, gridvendor, Me)
        gridvendor.Columns("vendorid").Visible = False
    End Sub

    Private Sub txtVendor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendor.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
        vendorid.Text = txtVendor.Properties.View.GetFocusedRowCellValue("vendorid").ToString
        txtVendor.Text = txtVendor.Properties.View.GetFocusedRowCellValue("Supplier").ToString
    End Sub
    Public Sub filterBatch()
        LoadXgrid("Select id,(select if(partnumber='' or partnumber is null,ITEMNAME,concat(ITEMNAME,'-',partnumber)) from tblglobalproducts where productid=tblinventorylogs.productid and actived=1) as 'Particular', " _
                           + " Quantity, Unit,unitcost as 'Unit Cost',Total, (select companyname from tblglobalvendor where vendorid = tblinventorylogs.vendorid ) as 'Vendor',Remarks, (select officename from tblcompoffice where officeid = tblinventorylogs.officeid) as '" & GlobalOfficeCaption & "', " _
                           + " ifnull((select stockhousename from tblstockhouse where stockhouseid=tblinventorylogs.stockhouseid),'Default') as 'Stock House' " _
                           + " from tblinventorylogs where confirmed=0 and trnby='" & globaluserid & "' " _
                           + " order by datetrn asc", "tblinventorylogs", Em, GridView1, Me)

        GridView1.BestFitColumns()
        GridView1.Columns("id").Visible = False
        ' gridview1.Columns("officeid").Visible = False
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        XgridColCurrency({"Unit Cost"}, GridView1)
        XgridColCurrency({"Total"}, GridView1)
        'XgridColAlign("Particular ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign({"Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

    End Sub
    Private Sub cmdconfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim tempquan = 0
        If txtoffice.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        ElseIf txtProduct.Text = "" Then
            XtraMessageBox.Show("Please select Particular!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProduct.Focus()
            Exit Sub
        ElseIf Val(CC(txtQuantity.Text)) <= 0 Then
            XtraMessageBox.Show("Please proper quantity!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQuantity.Focus()
            Exit Sub
        ElseIf Val(txtUnitCost.Text) < 0 Then
            XtraMessageBox.Show("Please enter proper cost!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnitCost.Focus()
            Exit Sub
        End If
        com.CommandText = "update tblglobalproducts set purchasedprice='" & Val(CC(txtUnitCost.Text)) & "' where productid='" & productid.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "Insert into tblinventorylogs set officeid='" & officeid.Text & "', stockref='" & txtStockNo.Text & "', invoiceno='" & txtInvoiceNo.Text & "', " _
                                                                      + " stockhouseid='" & If(txtStockHouse.Text = "", "default", stockhouseid.Text) & "', " _
                                                                      + " batchcode='" & batchcode.Text & "', " _
                                                                      + " trncode='" & trncode.Text & "', " _
                                                                      + " catid='" & catid.Text & "', " _
                                                                      + " productid='" & productid.Text & "', " _
                                                                      + " quantity=" & Val(CC(txtQuantity.Text)) & ", " _
                                                                      + " unit='" & txtUnit.Text & "', " _
                                                                      + " unitcost='" & Val(CC(txtUnitCost.Text)) & "', " _
                                                                      + " total='" & Val(CC(txtTotalAmount.Text)) & "', " _
                                                                      + " datepurchased='" & ConvertDate(txtdatepurchased.EditValue) & "', " _
                                                                      + " vendorid='" & If(vendorid.Text = "", AppBeginvendorId, vendorid.Text) & "', " _
                                                                      + " remarks='" & rchar(txtitemremarks.Text) & "', " _
                                                                      + " datetrn=current_timestamp, " _
                                                                      + " trnby='" & globaluserid & "', " _
                                                                      + " confirmed=0" : com.ExecuteNonQuery()
        filterBatch()
        Clearfields()
    End Sub
    Public Sub Clearfields()
        txtProduct.Properties.DataSource = Nothing
        txtProduct.Text = ""
        productid.Text = ""
        loadProducts()
        trncode.Text = getGlobalTrnid("mtr", globaluserid)
        txtdatepurchased.EditValue = Now
        txtQuantity.Text = "0"
        txtUnit.Text = ""
        txtUnitCost.Text = "0.00"
       
        txtitemremarks.Text = ""
        txtProduct.Focus()
        txtProduct.ShowPopup()
    End Sub

    Private Sub cmdconfirm_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles cmdAddItem.Click
        AddProduct("", Me)
    End Sub

    Private Sub txtcost_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtQuantity.EditValueChanged, txtUnitCost.EditValueChanged
        calctotal()
       
    End Sub
    Public Sub calctotal()
        Dim ttl
        ttl = Val(CC(txtQuantity.Text)) * Val(CC(txtUnitCost.Text))
        txtTotalAmount.Text = Format(Val(ttl), "n")
        If Val(CC(txtUnitCost.Text)) > 0 Then
            Me.AcceptButton = cmdAdd
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterBatch()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdConfirm.Click
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Theres no item to save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Continue confirm batch inventory?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            dst = New DataSet
            msda = New MySqlDataAdapter("Select * from tblinventorylogs where confirmed=0 and trnby='" & globaluserid & "'", conn)
            msda.Fill(dst, 0)
            ProgressBarControl1.Visible = True
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = GridView1.RowCount - 1
            ProgressBarControl1.Properties.Minimum = 0
            ProgressBarControl1.Position = 0
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    UpdateInventory("Manual Inventory", .Rows(cnt)("stockref").ToString(), .Rows(cnt)("officeid").ToString(), .Rows(cnt)("vendorid").ToString(), .Rows(cnt)("stockhouseid").ToString(), .Rows(cnt)("productid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("unitcost").ToString())), .Rows(cnt)("remarks").ToString(), "", .Rows(cnt)("invoiceno").ToString(), CDate(.Rows(cnt)("datepurchased").ToString()))
                    com.CommandText = "update tblinventorylogs set confirmed=1 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                End With
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            ProgressBarControl1.Update()
            ProgressBarControl1.Refresh()
            ProgressBarControl1.Visible = False
            filterBatch()
            batchcode.Text = getGlobalTrnid("BAT", globaluserid)
            frmManualInventoryHistory.filter()
            XtraMessageBox.Show("Inventory successfully updated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RemoveParticularToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveParticularToolStripMenuItem.Click
        If CheckSelectedRow("id", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to continue this action?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "delete from tblinventorylogs where id='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
                GridView1.DeleteSelectedRows()
            End If
        End If
    End Sub

    Private Sub cmdEditItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdEditItem.Click
        If productid.Text = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        EditProduct(productid.Text, Me)
        txtProduct.Properties.DataSource = Nothing
        txtProduct.Text = ""
    End Sub

   
End Class