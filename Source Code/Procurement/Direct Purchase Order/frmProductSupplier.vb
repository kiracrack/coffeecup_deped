Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmProductSupplier
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

 
        End If
        Return ProcessCmdKey
    End Function
    
    Private Sub frmVendorsItem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub
    Private Sub frmAddVendorItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gridcompoffice)
        LoadGridviewAppearance(gridSupplier)

        loadSupplier()
        loadCompOffice()
        loadProducts()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdAddVendor.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdAddVendor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Visible = True
        Else
            cmdRemove.Visible = False
        End If
    End Sub
    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as '" & GlobalOfficeCaption & "' from tblcompoffice where enableoperation=1 order by officename asc", "tblcompoffice", txtofficename, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False
        Me.txtofficename.Properties.DisplayMember = GlobalOfficeCaption
        Me.txtofficename.Properties.ValueMember = GlobalOfficeCaption
    End Sub
    Private Sub txtcompoffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtofficename.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtofficename.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtofficename.Properties.View.GetFocusedRowCellValue("officeid").ToString
        txtofficename.Text = txtofficename.Properties.View.GetFocusedRowCellValue(GlobalOfficeCaption).ToString
    End Sub

    Public Sub loadSupplier()
        LoadXgridLookupSearch("SELECT vendorid,COMPANYNAME as 'Supplier' from tblglobalvendor order by COMPANYNAME asc", "tblglobalvendor", txtSupplier, gridSupplier, Me)
        gridSupplier.Columns("vendorid").Visible = False
    End Sub

    Private Sub txtsuplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupplier.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtSupplier.Properties.View.FocusedRowHandle.ToString)
        vendorid.Text = txtSupplier.Properties.View.GetFocusedRowCellValue("vendorid").ToString()
        txtSupplier.Text = txtSupplier.Properties.View.GetFocusedRowCellValue("Supplier").ToString()
        loadProducts()

    End Sub

    Public Sub loadProducts()
        LoadXgridLookupSearch("SELECT productid, itemname as 'Product Name',purchasedprice,unit from tblglobalproducts where actived=1 and productid not in (select itemid from tblitemvendor where vendorid='" & vendorid.Text & "') order by itemname", "tblglobalvendor", txtProductName, gridProduct, Me)
        gridProduct.Columns("productid").Visible = False
        gridProduct.Columns("purchasedprice").Visible = False
        gridProduct.Columns("unit").Visible = False
    End Sub

    Private Sub txtProductName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductName.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProductName.Properties.View.FocusedRowHandle.ToString)
        itemid.Text = txtProductName.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtProductName.Text = txtProductName.Properties.View.GetFocusedRowCellValue("Supplier").ToString()
        txtcost.Text = txtProductName.Properties.View.GetFocusedRowCellValue("purchasedprice").ToString()
        txtunit.Text = txtProductName.Properties.View.GetFocusedRowCellValue("unit").ToString()
    End Sub
 
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtofficename.Text = "" Then
            XtraMessageBox.Show("Please select item!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtofficename.Focus()
            Exit Sub
        ElseIf txtSupplier.Text = "" Then
            XtraMessageBox.Show("Please select supplier!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSupplier.Focus()
            Exit Sub
        ElseIf txtunit.Text = "" Then
            XtraMessageBox.Show("Please provide unit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtunit.Focus()
            Exit Sub
        ElseIf txtcost.Text = "" Then
            XtraMessageBox.Show("Please provide unit cost!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcost.Focus()
            Exit Sub
        End If
        If Mode.Text <> "edit" Then
            com.CommandText = "insert into tblitemvendor set officeid='" & officeid.Text & "', vendorid = '" & vendorid.Text & "', itemid='" & itemid.Text & "', UNIT='" & txtunit.Text & "',PROCOST='" & Val(CC(txtcost.Text)) & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblitemvendor set officeid='" & officeid.Text & "', vendorid = '" & vendorid.Text & "', itemid='" & itemid.Text & "', UNIT='" & txtunit.Text & "',PROCOST='" & Val(CC(txtcost.Text)) & "' where id = '" & id.Text & "'" : com.ExecuteNonQuery()
        End If

        clearfields()
        txtofficename.Focus()
        XtraMessageBox.Show("Supplier or Vendor successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub clearfields()
        txtProductName.Properties.DataSource = Nothing
        txtProductName.Text = ""
        itemid.Text = ""
        loadProducts()
        txtcost.Text = "0.00"
        mode.Text = ""
        id.Text = ""
    End Sub
    
    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Mode.Text = "" Then Exit Sub
        com.CommandText = "select *,(select officename from tblcompoffice where officeid = tblitemvendor.officeid) as '" & GlobalOfficeCaption & "', " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblitemvendor.vendorid) as VendorNAME, " _
                                + " (select itemname from tblglobalproducts where productid = tblitemvendor.itemid) as product " _
                                + " from tblitemvendor where id='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtProductName.Text = rst("product").ToString
            itemid.Text = rst("itemid").ToString
            txtofficename.Text = rst(GlobalOfficeCaption).ToString
            officeid.Text = rst("officeid").ToString
            txtSupplier.Text = rst("VendorNAME").ToString
            vendorid.Text = rst("vendorid").ToString
            txtunit.Text = rst("UNIT").ToString
            txtcost.Text = rst("PROCOST").ToString
        End While
        rst.Close()
    End Sub
   
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        clearfields()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAddVendor.ItemClick
        frmVendorInformation.ShowDialog(Me)
        loadSupplier()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
End Class