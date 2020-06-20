Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmVendorsProductInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
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
   
    Private Sub frmVendorsItem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub
    Private Sub frmAddVendorItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gridcompoffice)
        LoadGridviewAppearance(g_Vendor)
        loadItem()
        loadVendors()
        loadCompOffice()
        filter()
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
    Public Sub filter()
        LoadXgrid("Select id,(select officename from tblcompoffice where officeid = tblitemvendor.officeid) as '" & GlobalOfficeCaption & "', " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblitemvendor.vendorid) as 'Supplier or Vendor name', " _
                                + " procost as 'Unit Cost' from tblitemvendor where itemid = '" & itemid.Text & "'", "tblitemvendor", Em, GridView1, Me)
        GridView1.ExpandAllGroups()
        GridView1.Columns("id").Visible = False
        GridView1.Columns(GlobalOfficeCaption).Group()
        GridView1.ExpandAllGroups()
        XgridColCurrency({"Unit Cost"}, GridView1)
    End Sub
    Public Sub loadVendors()
        LoadXgridLookupSearch("SELECT vendorid,COMPANYNAME as 'Supplier' from tblglobalvendor order by COMPANYNAME desc", "tblglobalvendor", txtVendor, g_Vendor, Me)
        g_Vendor.Columns("vendorid").Visible = False
    End Sub
    Private Sub txtsuplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendor.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVendor.Properties.View.FocusedRowHandle.ToString)
        vendorid.Text = txtVendor.Properties.View.GetFocusedRowCellValue("vendorid").ToString()
        txtVendor.Text = txtVendor.Properties.View.GetFocusedRowCellValue("Supplier").ToString()
    End Sub
    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as '" & GlobalOfficeCaption & "' from tblcompoffice", "tblcompoffice", txtofficename, gridcompoffice, Me)
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
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtofficename.Text = "" Then
            XtraMessageBox.Show("Please select item!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtofficename.Focus()
            Exit Sub
        ElseIf txtVendor.Text = "" Then
            XtraMessageBox.Show("Please select supplier!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVendor.Focus()
            Exit Sub
        ElseIf txtunit.Text = "" Then
            XtraMessageBox.Show("Please provide unit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtunit.Focus()
            Exit Sub
        ElseIf txtcost.Text = "" Then
            XtraMessageBox.Show("Please provide cost!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcost.Focus()
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            com.CommandText = "insert into tblitemvendor set officeid='" & officeid.Text & "', vendorid = '" & vendorid.Text & "', itemid='" & itemid.Text & "', UNIT='" & txtunit.Text & "',PROCOST='" & Val(CC(txtcost.Text)) & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblitemvendor set officeid='" & officeid.Text & "', vendorid = '" & vendorid.Text & "', itemid='" & itemid.Text & "', UNIT='" & txtunit.Text & "',PROCOST='" & Val(CC(txtcost.Text)) & "' where id = '" & id.Text & "'" : com.ExecuteNonQuery()
        End If

        filter()
        clearfields()
        txtofficename.Focus()
        XtraMessageBox.Show("Supplier or Vendor successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub clearfields()
        txtofficename.Properties.DataSource = Nothing
        txtofficename.Text = ""
        officeid.Text = ""
        loadCompOffice()

        txtVendor.Properties.DataSource = Nothing
        txtVendor.Text = ""
        vendorid.Text = ""
        loadVendors()
        txtcost.Text = "0.00"
        mode.Text = ""
        id.Text = ""
    End Sub
    Public Sub loadItem()
        com.CommandText = "select * from tblglobalproducts where productid='" & itemid.Text & "'"
        rst = com.ExecuteReader()
        While rst.Read
            txtitemname.Text = rst("itemname").ToString
            txtunit.Text = rst("unit").ToString
        End While
        rst.Close()
    End Sub
    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select *,(select officename from tblcompoffice where officeid = tblitemvendor.officeid) as '" & GlobalOfficeCaption & "', " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblitemvendor.vendorid) as VendorNAME, " _
                                + " (select itemname from tblglobalproducts where productid = tblitemvendor.itemid) as product " _
                                + " from tblitemvendor where id='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtitemname.Text = rst("product").ToString
            itemid.Text = rst("itemid").ToString
            txtofficename.Text = rst(GlobalOfficeCaption).ToString
            officeid.Text = rst("officeid").ToString
            txtVendor.Text = rst("VendorNAME").ToString
            vendorid.Text = rst("vendorid").ToString
            txtunit.Text = rst("UNIT").ToString
            txtcost.Text = rst("PROCOST").ToString
        End While
        rst.Close()
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckSelectedRow(GlobalOfficeCaption, GridView1) = True Then
            mode.Text = ""
            id.Text = GridView1.GetFocusedRowCellValue("id").ToString
            mode.Text = "edit"
        End If
    End Sub
    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If CheckSelectedRow(GlobalOfficeCaption, GridView1).ToString = True Then
            If XtraMessageBox.Show("Are you sure you want to permanently delete this item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                DeleteRow("id", "id", "tblitemvendor", GridView1, Me)
            End If
        End If
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub
    Private Sub FormatGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatGridToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        clearfields()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAddVendor.ItemClick
        frmVendorInformation.ShowDialog(Me)
        loadVendors()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        PrintGeneralReport("ITEM SUPPLIER REPORT", "PRODUCT NAME: " & txtitemname.Text, GridView1, Me)
    End Sub
End Class