Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmProductDiscount
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gvDiscount)
        LoadGridviewAppearance(GridView1)
        LoadProduct()
        LoadGeneralDiscount()
        LoadDiscountedProduct()
        LoadClientGroup()
        LoadCategory()
        LoadClientDiscount()
    End Sub

    Public Sub LoadClientGroup()
        LoadXgridLookupSearch("SELECT groupcode, groupname as 'Select Group' from tblclientgroup order by groupname asc", "tblclientgroup", txtClientGroup, gridClientGroup, Me)
        gridClientGroup.Columns("groupcode").Visible = False
    End Sub

    Private Sub txtClientGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClientGroup.EditValueChanged
        On Error Resume Next
        groupcif.Text = txtClientGroup.Properties.View.GetFocusedRowCellValue("groupcode").ToString()
        LoadClientDiscount()
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupSearch("SELECT catid, description as 'Select Category' from tblprocategory order by description asc", "tblprocategory", txtCategory, category, Me)
        category.Columns("catid").Visible = False
    End Sub

    Private Sub txtCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategory.EditValueChanged
        On Error Resume Next
        catid.Text = txtCategory.Properties.View.GetFocusedRowCellValue("catid").ToString()
    End Sub

    Private Sub cmdSaveClientDiscount_Click(sender As Object, e As EventArgs) Handles cmdSaveClientDiscount.Click
        If txtClientGroup.Text = "" Then
            XtraMessageBox.Show("Please client group!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClientGroup.Focus()
            Exit Sub
        ElseIf txtCategory.Text = "" Then
            XtraMessageBox.Show("Please category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCategory.Focus()
            Exit Sub
        ElseIf txDiscountrate.Text = "0.00" Then
            XtraMessageBox.Show("Please Enter Discount Rate!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txDiscountrate.Focus()
            Exit Sub
        ElseIf countqry("tblclientdiscounts", "cifid='" & groupcif.Text & "' and catid='" & catid.Text & "' and id<>'" & id.Text & "'") > 0 Then
            XtraMessageBox.Show("Category already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCategory.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to save discount rate?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode2.Text = "edit" Then
                com.CommandText = "update tblclientdiscounts set cifid='" & groupcif.Text & "', catid='" & catid.Text & "', discounttype='" & radDiscountType2.EditValue & "', discountrate='" & Val(CC(txDiscountrate.Text)) & "'  where id='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblclientdiscounts set cifid='" & groupcif.Text & "', catid='" & catid.Text & "', discounttype='" & radDiscountType2.EditValue & "', discountrate='" & Val(CC(txDiscountrate.Text)) & "'" : com.ExecuteNonQuery()
            End If
            txtCategory.Properties.DataSource = Nothing
            txtCategory.Text = "" : catid.Text = "" : mode2.Text = ""
            LoadCategory() : LoadClientDiscount()
            XtraMessageBox.Show("Discount rate successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub LoadClientDiscount()
        LoadXgrid("select id, (select groupname from tblclientgroup where groupcode=tblclientdiscounts.cifid) as 'Client Group', (select description from tblprocategory where catid=tblclientdiscounts.catid) as 'Category', ucase(discounttype) as 'Discount Type', discountrate as 'Discount Rate' from tblclientdiscounts where cifid='" & groupcif.Text & "'", "tblclientdiscounts", Em2, GridView2, Me)
        GridView2.Columns("id").Visible = False
        GridView2.Columns("Discount Rate").Width = 80
        XgridColAlign({"Discount Rate", "Discount Type"}, GridView2, DevExpress.Utils.HorzAlignment.Center)
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If XtraMessageBox.Show("Are you sure you want to edit selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            id.Text = GridView2.GetFocusedRowCellValue("id").ToString
            Dim strproduct As String = ""
            com.CommandText = "select *,(select groupname from tblclientgroup where groupcode=tblclientdiscounts.cifid) as cif, (select description from tblprocategory where catid=tblclientdiscounts.catid) as 'Product' from tblclientdiscounts where id='" & id.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                groupcif.Text = rst("cifid").ToString
                txtClientGroup.Text = rst("cif").ToString
                strproduct = rst("Product").ToString
                radDiscountType2.EditValue = rst("discounttype").ToString
                catid.Text = rst("catid").ToString
                txDiscountrate.Text = rst("discountrate").ToString
            End While
            rst.Close()
            txtCategory.Text = strproduct
            mode2.Text = "edit"
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If XtraMessageBox.Show("Are you sure you want to delete selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView2.SelectedRowsCount - 1
                com.CommandText = "delete from tblclientdiscounts where id='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadClientDiscount()
        End If

    End Sub
#Region "General Discount"
    Public Sub LoadGeneralDiscount()
        LoadXgrid("select productid, itemname as 'Discount Name', sellingprice as 'Discount Rate' from tblglobalproducts where allownegativeinputs=1 and deleted=0", "tblglobalproducts", gridDiscount, gvDiscount, Me)
        gvDiscount.Columns("productid").Visible = False
        gvDiscount.Columns("Discount Rate").Width = 80
        XgridColCurrency({"Discount Rate"}, gvDiscount)
        XgridColAlign({"Discount Rate"}, gvDiscount, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub cmdSaveDiscount_Click(sender As Object, e As EventArgs) Handles cmdSaveDiscount.Click
        If Globaldefaultdiscountcategory = "" Then
            XtraMessageBox.Show("There is no default discount category. Please contact your system administrator!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If gmode.text = "edit" Then
            com.CommandText = "UPDATE tblglobalproducts set itemname='" & txtDiscountName.Text & "',sellingprice='" & Val(CC(txtGrate.Text)) & "' where productid='" & gcode.Text & "'" : com.ExecuteNonQuery()
            LoadGeneralDiscount()
        Else
            Dim code As String = getproid()
            com.CommandText = "insert into tblglobalproducts set productid='" & code & "', catid='" & Globaldefaultdiscountcategory & "', itemname='" & txtDiscountName.Text & "',sellingprice='" & Val(CC(txtGrate.Text)) & "',unit='NA',enablesell=1,forcontract=1,allownegativeinputs=1,entryby='" & globaluserid & "',salemode='esba', dateentered=current_timestamp" : com.ExecuteNonQuery()
            LoadGeneralDiscount()
        End If
        gmode.Text = "" : gmode.Text = "" : txtDiscountName.Text = "" : txtDiscountRate.Text = "" : ckFixRate.Checked = False : txtDiscountName.Focus()
    End Sub

#End Region

#Region "PRODUCT DISCOUNT"
    Private Sub cmdEditGDiscount_Click(sender As Object, e As EventArgs) Handles cmdEditGDiscount.Click
        If XtraMessageBox.Show("Are you sure you want to edit selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            gcode.Text = gvDiscount.GetFocusedRowCellValue("productid").ToString
            Dim strproduct As String = ""
            com.CommandText = "select * from tblglobalproducts where productid='" & gcode.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtDiscountName.Text = rst("itemname").ToString
                If Val(rst("sellingprice").ToString) = 0 Then
                    ckFixRate.Checked = False
                    txtGrate.Text = "0"
                Else
                    ckFixRate.Checked = True
                    txtGrate.Text = rst("sellingprice").ToString
                End If
            End While
            rst.Close()
            gmode.Text = "edit"
        End If
    End Sub

    Private Sub ckFixRate_CheckedChanged(sender As Object, e As EventArgs) Handles ckFixRate.CheckedChanged
        If ckFixRate.Checked = True Then
            txtGrate.Enabled = True
        Else
            txtGrate.Enabled = False
            txtGrate.Text = "0"
        End If
    End Sub
    Public Sub LoadProduct()
        LoadXgridLookupSearch("select productid, itemname as 'Product Name' from tblglobalproducts where enablesell = 1 and actived = 1", "tblglobalproducts", txtProduct, gridProduct, Me)
        gridProduct.Columns("productid").Visible = False
    End Sub
    Private Sub txtItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProduct.Properties.View.FocusedRowHandle.ToString)
        productid.Text = txtProduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtProduct.Text = txtProduct.Properties.View.GetFocusedRowCellValue("Product Name").ToString()

    End Sub
    Public Sub LoadDiscountedProduct()
        LoadXgrid("select id, (select itemname from tblglobalproducts where productid=tblproductdiscounts.productid and actived=1) as 'Product',ucase(discounttype) as 'Discount Type', discountrate as 'Discount Rate',affectclient as 'Affect Discounted Client',incondition as 'Condition',amount as 'Total Purchased' from tblproductdiscounts", "tblproductdiscounts", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        GridView1.Columns("Discount Rate").Width = 80
        XgridColCurrency({"Total Purchased"}, GridView1)
        XgridColAlign({"Discount Rate", "Discount Type", "Affect Discounted Client", "Condition"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtProduct.Text = "" Then
            XtraMessageBox.Show("Please Select Product!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProduct.Focus()
            Exit Sub
        ElseIf txtDiscountRate.Text = "0.00" Then
            XtraMessageBox.Show("Please Enter Discount Rate!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDiscountRate.Focus()
            Exit Sub
        ElseIf ckCondition.Checked = True And txtTotalPurchase.Text = "0.00" Then
            XtraMessageBox.Show("Please Enter Total Purchased!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDiscountRate.Focus()
            Exit Sub
        ElseIf countqry("tblproductdiscounts", "productid='" & productid.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Product discounts is already added!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProduct.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to save product  discount?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblproductdiscounts set productid='" & productid.Text & "', discounttype='" & radDiscountType.EditValue & "', discountrate='" & Val(CC(txtDiscountRate.Text)) & "',affectclient=" & ckAffectClient.CheckState & ",incondition=" & ckCondition.CheckState & ",amount='" & Val(CC(txtTotalPurchase.Text)) & "' where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblproductdiscounts set  productid='" & productid.Text & "', discounttype='" & radDiscountType.EditValue & "', discountrate='" & Val(CC(txtDiscountRate.Text)) & "', affectclient=" & ckAffectClient.CheckState & ",incondition=" & ckCondition.CheckState & ",amount='" & Val(CC(txtTotalPurchase.Text)) & "'" : com.ExecuteNonQuery()
            End If
            txtProduct.Properties.DataSource = Nothing
            txtProduct.Text = "" : productid.Text = "" : txtDiscountRate.Text = "0" : txtTotalPurchase.Text = "0" : mode.Text = ""
            LoadProduct() : LoadDiscountedProduct()
            XtraMessageBox.Show("Discount rate successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If XtraMessageBox.Show("Are you sure you want to edit selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            trnid.Text = GridView1.GetFocusedRowCellValue("id").ToString
            Dim strproduct As String = ""
            com.CommandText = "select *, (select itemname from tblglobalproducts where productid=tblproductdiscounts.productid and actived=1) as 'Product' from tblproductdiscounts where id='" & trnid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                strproduct = rst("Product").ToString
                radDiscountType.EditValue = rst("discounttype").ToString
                productid.Text = rst("productid").ToString
                txtDiscountRate.Text = rst("discountrate").ToString
                ckAffectClient.Checked = rst("affectclient")
                ckCondition.Checked = rst("incondition")
                txtTotalPurchase.Text = rst("amount").ToString
            End While
            rst.Close()
            txtProduct.Text = strproduct
            mode.Text = "edit"
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to delete selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblproductdiscounts where id='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            LoadDiscountedProduct()
        End If
    End Sub

    Private Sub ckCondition_CheckedChanged(sender As Object, e As EventArgs) Handles ckCondition.CheckedChanged
        If ckCondition.Checked = True Then
            lblTotalPurchase.Enabled = True
            txtTotalPurchase.Enabled = True
        Else
            lblTotalPurchase.Enabled = False
            txtTotalPurchase.Enabled = False
            txtTotalPurchase.Text = "0"
        End If
    End Sub
#End Region

  
 

  
End Class