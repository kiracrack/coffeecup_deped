Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmUtilUnitConvertion

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub trnid_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trnid.EditValueChanged
        com.CommandText = "select * from tblinventory where trnid = '" & trnid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            productid_source.Text = rst("productid").ToString
            officeid.Text = rst("officeid").ToString
            'vendorid.Text = rst("vendorid").ToString
            txtproduct.Text = rst("productname").ToString
            txtOldQuantity.Text = rst("quantity").ToString
            txtNewQuantity.Text = rst("quantity").ToString
            txtCurrentUnitType.Text = rst("unit").ToString
            txtCurrentUnitCost.Text = rst("purchasedprice").ToString
            txtCurrentUnitCost.Text = rst("purchasedprice").ToString
        End While
        rst.Close()

        com.CommandText = "select *,(select itemname from tblglobalproducts where productid=tblunitconverter.productid_target) as 'productname', " _
            + " (select unit from tblglobalproducts where productid=tblunitconverter.productid_target) as 'unittype' from tblunitconverter where productid_source = '" & productid_source.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtConvertProductName.Text = rst("productname").ToString
            txtConvertUnitType.Text = rst("unittype").ToString
            productid_converted.Text = rst("productid_target").ToString
            txtQuantity_s.Text = rst("quantity_source").ToString
            txtQuantity_t.Text = rst("quantity_target").ToString
        End While
        rst.Close()
        Calculator()
    End Sub

    Public Function Calculator()
        Dim getQuantity As Double = 0 : Dim getUnitCost As Double = 0

        getQuantity = txtQuantity_t.EditValue / txtQuantity_s.EditValue
        txtConvertQuantity.EditValue = getQuantity * txtNewQuantity.EditValue

        getUnitCost = Val(CC(txtCurrentUnitCost.Text)) * txtQuantity_s.EditValue
        txtConvertUnitCost.Text = FormatNumber(getUnitCost / txtQuantity_t.EditValue)

        Return 0
    End Function

    
    Private Sub txtquan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewQuantity.GotFocus
        txtNewQuantity.SelectionStart = 0
        txtNewQuantity.SelectionLength = Len(txtNewQuantity.Text)
    End Sub

    Private Sub txtNewQuantity_EditValueChanged(sender As Object, e As EventArgs) Handles txtNewQuantity.EditValueChanged
        Calculator()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If Val(CC(txtNewQuantity.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter valid quantity", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewQuantity.Focus()
            Exit Sub
        ElseIf Val(CC(txtNewQuantity.Text)) > Val(CC(txtOldQuantity.Text)) Then
            XtraMessageBox.Show("Maximum quantity can convert is " & FormatNumber(txtOldQuantity.Text, 2) & " " & txtCurrentUnitType.Text, compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewQuantity.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            UpdateInventory("Unit Convertion", "", officeid.Text, "", "", productid_converted.Text, txtConvertQuantity.EditValue, txtConvertUnitCost.EditValue, "Converted from " & LCase(txtCurrentUnitType.Text), "", "", Now)
            StockoutInventory("Unit Convertion", trnid.Text, officeid.Text, productid_source.Text, txtNewQuantity.EditValue, Val(CC(txtConvertUnitCost.Text)), "Converted to " & LCase(txtConvertUnitType.Text), globalofficeid, "", "", Now)
            XtraMessageBox.Show("Product successfuly converted!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class