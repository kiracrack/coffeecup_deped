Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmProductDirect2
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
      
        ElseIf countqry("tblglobalproducts", "itemname='" & rchar(txtitem.Text) & "' and unit='" & txtUnit.Text & "' and catid='" & catid.Text & "' and productid<>'" & productid.Text & "'") > 0 Then
            XtraMessageBox.Show("Duplicate particular item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtitem.SelectAll()
            txtitem.Focus()
            Exit Sub
        End If
        '#insert new revised product
        com.CommandText = "Update tblglobalproducts set itemname='" & rchar(txtitem.Text) & "',  unit='" & txtUnit.Text & "', purchasedprice='" & Val(CC(txtPurchasePrice.Text)) & "', sellingprice='" & Val(CC(txtSellingPrice.Text)) & "',vatableitem=" & ckVatEnable.CheckState & ",svchargeitem=" & ckServiceCharge.CheckState & " where productid='" & productid.Text & "' " : com.ExecuteNonQuery()
        com.CommandText = "update tblinventory set productname='" & rchar(txtitem.Text) & "', unit='" & txtUnit.Text & "', sellingprice='" & Val(CC(txtSellingPrice.Text)) & "' where productid='" & productid.Text & "'" : com.ExecuteNonQuery()

        If frmProductManagement.Visible = True Then
            frmProductManagement.UpdateProduct(txtitem.Text, txtUnit.Text, txtPurchasePrice.Text, txtSellingPrice.Text, "")
        End If
        Me.Close()
    End Sub

    Private Sub ViewProInfo()
        com.CommandText = "select *, (select description from tblprocategory where catid = tblglobalproducts.catid) as catproduct  from tblglobalproducts where productid='" & productid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtitem.Text = rst("itemname").ToString
            txtUnit.Text = rst("unit").ToString
            catid.Text = rst("catid").ToString
            txtPurchasePrice.Text = rst("purchasedprice").ToString
            txtSellingPrice.Text = rst("sellingprice").ToString
            ckVatEnable.Checked = CBool(rst("vatableitem"))
            ckServiceCharge.Checked = CBool(rst("svchargeitem").ToString)
        End While
        rst.Close()
    End Sub
   
    Private Sub txtSellingPrice_GotFocus(sender As Object, e As EventArgs) Handles txtSellingPrice.GotFocus
        txtSellingPrice.SelectAll()
    End Sub

End Class