Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins

Public Class frmQuantitySelect
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.Control) + Keys.Enter Then
            cmdaction.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmQuantitySelect_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        proid.Text = ""
        mode.Text = ""
        catid.Text = ""
        txtVendor.Properties.DataSource = Nothing
        txtVendor.Text = ""
        vendorid.Text = ""
        txtsti.Text = ""
        trnid.Text = ""
        tempCost.Text = ""
        txtproduct.Text = ""
        txtremarks.Text = ""
        officeid.Text = ""
    End Sub
    Private Sub frmQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(g_Vendor)
        LoadGridviewAppearance(g_product)
        If mode.Text <> "edit" Then
            id.Text = getGlobalTrnid(GlobalOrganizationCode, globaluserid)
            txtquan.Text = "1"
        End If
        txtquan.Focus()
        loadVendors()
        loadPOdetails()
        loadProducts()
    End Sub

    Public Sub loadProducts()
        LoadXgridLookupSearch("SELECT ffecode, productname as 'Select Item', acctableperson as 'Accountable Person' from tblinventoryffe where officeid='" & officeid.Text & "'", "tblinventoryffe", txtInventory, g_product, Me)
        g_product.OptionsView.ShowGroupPanel = True
        g_product.Columns("ffecode").Visible = False
    End Sub
     
    Private Sub txtInventory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtInventory.Properties.View.FocusedRowHandle.ToString)
        ffecode.Text = txtInventory.Properties.View.GetFocusedRowCellValue("ffecode").ToString()
    End Sub
    Public Sub loadPOdetails()
        com.CommandText = "select *, (select officename from tblcompoffice where officeid =tblrequisitions.officeid ) as '" & GlobalOfficeCaption & "', (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'REQUEST' from tblrequisitions where PID='" & pid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
        End While
        rst.Close()
    End Sub
   
    Private Sub ckAllSupplier_CheckedChanged(sender As Object, e As EventArgs)
        loadVendors()
    End Sub
    Public Sub loadVendors()
        LoadXgridLookupSearch("select vendorid, companyname as 'Vendor/Supplier', (select procost from tblitemvendor where vendorid=tblglobalvendor.vendorid order by lastupdate desc limit 1) as 'Latest Unit Cost' from tblglobalvendor order by companyname asc", "tblglobalvendor", txtVendor, g_Vendor, Me)
        txtVendor.Properties.PopupFormSize = New Size(480, 350)
        g_Vendor.Columns("vendorid").Visible = False
    End Sub
    Private Sub txtsuplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendor.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVendor.Properties.View.FocusedRowHandle.ToString)
        vendorid.Text = txtVendor.Properties.View.GetFocusedRowCellValue("vendorid").ToString()
        txtsti.Text = txtVendor.Properties.View.GetFocusedRowCellValue("Latest Unit Cost").ToString()
        tempCost.Text = txtVendor.Properties.View.GetFocusedRowCellValue("Latest Unit Cost").ToString()
        txtquan.Focus()
    End Sub

    Private Sub txtquan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtquan.GotFocus
        txtquan.SelectionStart = 0
        txtquan.SelectionLength = Len(txtquan.Text)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If Val(CC(txtquan.Text)) <= 0 Then
            XtraMessageBox.Show("Quantity missing entry!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtquan.Focus()
            Exit Sub
        ElseIf txtVendor.Text = "" Then
            XtraMessageBox.Show("Please select vendor!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVendor.Focus()
            Exit Sub
        ElseIf txtunit.Text = "" Then
            XtraMessageBox.Show("Please select unit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtunit.Focus()
            Exit Sub

        ElseIf txtsti.Text = "" Then
            XtraMessageBox.Show("Estimate Cost missing entry!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtsti.Focus()
            Exit Sub
        End If

        If Val(CC(txtsti.Text)) <> Val(CC(tempCost.Text)) Then
            If XtraMessageBox.Show("System detected current price of a product has been changed!" & vbNewLine & "Do you want to update the product database record of the current price? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If countqry("tblitemvendor", " itemid='" & proid.Text & "' and vendorid = '" & vendorid.Text & "' and officeid='" & officeid.Text & "' ") = 0 Then
                    com.CommandText = "INSERT INTO tblitemvendor set itemid='" & proid.Text & "', vendorid = '" & vendorid.Text & "', officeid='" & officeid.Text & "', unit='" & txtunit.Text & "', procost='" & Val(CC(txtsti.Text)) & "', lastupdate=current_timestamp" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update tblitemvendor set unit='" & txtunit.Text & "', procost='" & Val(CC(txtsti.Text)) & "', lastupdate=current_timestamp where itemid='" & proid.Text & "' and vendorid = '" & vendorid.Text & "' and officeid='" & officeid.Text & "'" : com.ExecuteNonQuery()
                End If
            End If
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblrequisitionsitem set QUANTITY='" & Val(CC(txtquan.Text)) & "', " _
                                                  + " vendorid='" & vendorid.Text & "', " _
                                                  + " UNIT='" & txtunit.Text & "', " _
                                                  + " COST='" & Val(CC(txtsti.Text)) & "', " _
                                                  + " TOTAL='" & Val(CC(txttotal.Text)) & "', " _
                                                  + " allocatedrefcode='" & ffecode.Text & "'," _
                                                  + " remarks='" & rchar(txtremarks.Text) & "' where TRNID='" & trnid.Text & "'"
            com.ExecuteNonQuery()
            frmProceedNewRequest.filter()
        Else
            com.CommandText = "insert into tblrequisitionsitem set pid='" & pid.Text & "', officeid='" & officeid.Text & "', " _
                                                   + " PRODUCTID='" & proid.Text & "', " _
                                                   + " CATID='" & catid.Text & "', " _
                                                   + " vendorid='" & vendorid.Text & "', " _
                                                   + " UNIT='" & txtunit.Text & "', " _
                                                   + " QUANTITY='" & Val(CC(txtquan.Text)) & "', " _
                                                   + " COST='" & Val(CC(txtsti.Text)) & "', " _
                                                   + " TOTAL='" & Val(CC(txttotal.Text)) & "', " _
                                                   + " allocatedrefcode='" & ffecode.Text & "'," _
                                                   + " remarks='" & rchar(txtremarks.Text) & "',trnby='" & globaluserid & "', datetrn=current_timestamp"
            com.ExecuteNonQuery()
            frmProceedNewRequest.filter()
        End If
        txtquan.Focus()
        frmSelectRequestItem.txtfilter.SelectAll()
        frmSelectRequestItem.txtfilter.Focus()
        mode.Text = ""
        Me.Close()
    End Sub

    Public Sub calctotal()
        Dim quan : Dim stm : Dim ttl
        quan = CC(txtquan.Text)
        stm = CC(txtsti.Text)
        ttl = Val(quan) * Val(stm)

        txttotal.Text = Format(ttl, "n")
    End Sub

    Private Sub proid_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proid.EditValueChanged
        If proid.Text = "" Then Exit Sub
        If mode.Text = "edit" Then
            com.CommandText = "select *,(select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID) as 'ITEMNAME', " _
                                    + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid) as 'VendorNAME', " _
                                    + " (select tblglobalproducts.itemname from tblinventoryffe inner join tblglobalproducts on tblinventoryffe.productid = tblglobalproducts.productid where tblinventoryffe.ffecode=tblrequisitionsitem.allocatedrefcode) as 'allocated' " _
                                    + " from tblrequisitionsitem where TRNID='" & trnid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                catid.Text = rst("CATID").ToString
                vendorid.Text = rst("vendorid").ToString
                txtproduct.Text = rst("ITEMNAME").ToString
                txtquan.Text = rst("QUANTITY").ToString
                txtVendor.Text = rst("VendorNAME").ToString
                txtunit.Text = rst("UNIT").ToString
                If rst("allocatedrefcode").ToString <> "" Then
                    ckAllocated.Checked = True
                    txtInventory.Text = rst("allocated").ToString
                    ffecode.Text = rst("allocatedrefcode").ToString
                End If
                txtremarks.Text = rst("remarks").ToString
                txtsti.Text = Format(Val(rst("COST")), "n")
                tempCost.Text = rst("COST").ToString
            End While
            rst.Close()
        Else
            com.CommandText = "select * from tblglobalproducts where PRODUCTID='" & proid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                catid.Text = rst("CATID").ToString
                txtunit.Text = rst("UNIT").ToString
                txtproduct.Text = rst("ITEMNAME").ToString
            End While
            rst.Close()

            com.CommandText = "select *,(select officename from tblcompoffice where officeid = tblitemvendor.officeid) as '" & GlobalOfficeCaption & "', " _
                              + " (select COMPANYNAME from tblglobalvendor where vendorid = tblitemvendor.vendorid) as VendorNAME " _
                              + " from tblitemvendor where itemid='" & proid.Text & "' and officeid='" & officeid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                txtVendor.Text = rst("VendorNAME").ToString
                vendorid.Text = rst("vendorid").ToString
                txtsti.Text = Format(Val(rst("PROCOST")), "n")
                tempCost.Text = rst("PROCOST").ToString
            End While
            rst.Close()
        End If
    End Sub

    Private Sub txtquan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtquan.EditValueChanged
        calctotal()
    End Sub

    Private Sub txtsti_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsti.EditValueChanged
        calctotal()
    End Sub
 
  
    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles ckAllocated.CheckedChanged
        If ckAllocated.Checked = True Then
            txtInventory.Properties.ReadOnly = False
        Else
            txtInventory.Properties.ReadOnly = True
        End If
    End Sub

 
    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        frmVendorInformation.ShowDialog(Me)
        loadVendors()
    End Sub
End Class