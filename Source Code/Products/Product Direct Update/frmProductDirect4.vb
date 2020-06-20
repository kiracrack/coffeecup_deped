Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmProductDirect4
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Enter) Then
            If txtitem.Focus = True Then
                txtSellingPrice.Focus()
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmParticularInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        'SkinManager.EnableMdiFormSkins()
        LoadToComboBox("unit", "tblglobalproducts", txtUnit, True)
        ViewProInfo()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveParticular.Click
        If productid.Text = "" Then
            XtraMessageBox.Show("Please enter itemcode!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            productid.Focus()
            Exit Sub
        ElseIf txtitem.Text = "" Then
            XtraMessageBox.Show("Please provide particular name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtitem.Focus()
            Exit Sub
        ElseIf txtUnit.Text = "" Then
            XtraMessageBox.Show("Please select unit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnit.Focus()
            Exit Sub
        ElseIf countqry("tblglobalproducts", "barcode='" & txtBarcode.Text & "' and productid<>'" & productid.Text & "'") > 0 And txtBarcode.Text <> "" Then
            XtraMessageBox.Show("Barcode already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBarcode.SelectAll()
            txtBarcode.Focus()
            Exit Sub
        ElseIf countqry("tblglobalproducts", "itemname='" & rchar(txtitem.Text) & "' and unit='" & txtUnit.Text & "'  and productid<>'" & productid.Text & "'") > 0 Then
            XtraMessageBox.Show("Duplicate particular item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtitem.SelectAll()
            txtitem.Focus()
            Exit Sub
        End If
        '#insert new revised product
        com.CommandText = "Update tblglobalproducts set itemname='" & rchar(txtitem.Text) & "', " _
                                + "barcode='" & txtBarcode.Text & "', " _
                                + " partnumber='" & rchar(txtPartNumber.Text) & "', " _
                                + " unit='" & txtUnit.Text & "', " _
                                + " purchasedprice='" & Val(CC(txtPurchasePrice.Text)) & "', " _
                                + " sellingprice='" & Val(CC(txtSellingPrice.Text)) & "', " _
                                + " sellingprice1='" & Val(CC(txtSellingPrice1.Text)) & "', " _
                                + " sellingprice2='" & Val(CC(txtSellingPrice2.Text)) & "', " _
                                + " sellingprice3='" & Val(CC(txtSellingPrice3.Text)) & "', " _
                                + " sellingprice4='" & Val(CC(txtSellingPrice4.Text)) & "', " _
                                + " approved=" & If(LCase(globaluser) = "root", True, False) & " " _
                                + " where productid='" & productid.Text & "' " : com.ExecuteNonQuery()

        com.CommandText = "update tblinventory set productname='" & rchar(txtitem.Text) & If(txtPartNumber.Text <> "", " " + rchar(txtPartNumber.Text), "") & "', unit='" & txtUnit.Text & "',  sellingprice='" & Val(CC(txtSellingPrice.Text)) & "' where productid='" & productid.Text & "' and quantity > 0 " : com.ExecuteNonQuery()
        If frmProductManagement.Visible = True Then
            frmProductManagement.UpdateProduct4(txtBarcode.Text, txtitem.Text, txtUnit.Text, txtPurchasePrice.Text, txtSellingPrice.Text, txtSellingPrice1.Text, txtSellingPrice2.Text, txtSellingPrice3.Text, txtSellingPrice4.Text, txtPartNumber.Text)
        End If
        Me.Close()
    End Sub

    Private Sub ViewProInfo()
        com.CommandText = "select *, case when purchasedprice = 0 then (select procost from tblitemvendor where itemid = tblglobalproducts.productid order by lastupdate desc limit 1) else purchasedprice end as 'purchasedcost', " _
                            + " (select description from tblprocategory where catid = tblglobalproducts.catid) as catproduct  from tblglobalproducts where productid='" & productid.Text & "' and actived=1"
        rst = com.ExecuteReader
        While rst.Read
            txtBarcode.Text = rst("barcode").ToString
            txtitem.Text = rst("itemname").ToString
            txtPartNumber.Text = rst("partnumber").ToString
            txtUnit.Text = rst("unit").ToString
            txtPurchasePrice.Text = rst("purchasedprice").ToString
            txtSellingPrice.Text = rst("sellingprice").ToString
            txtSellingPrice1.Text = rst("sellingprice1").ToString
            txtSellingPrice2.Text = rst("sellingprice2").ToString
            txtSellingPrice3.Text = rst("sellingprice3").ToString
            txtSellingPrice4.Text = rst("sellingprice4").ToString
        End While
        rst.Close()
    End Sub
  
    Private Sub txtSellingPrice_GotFocus(sender As Object, e As EventArgs) Handles txtSellingPrice.GotFocus
        txtSellingPrice.SelectAll()
    End Sub
End Class