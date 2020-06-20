Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmUtilUpdateInventoryInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub trnid_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trnid.EditValueChanged
        com.CommandText = "select *, (select ITEMNAME from tblglobalproducts where productid = tblinventory.productid and actived=1) as 'PRODUCTS', " _
                                 + " (select officename from tblcompoffice where officeid = tblinventory.officeid) as '" & GlobalOfficeCaption & "' " _
                                 + " from tblinventory where trnid = '" & trnid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtproduct.Text = rst("PRODUCTS").ToString
            txtStockRef.Text = rst("stockref").ToString
            txtNewUnitCost.Text = rst("purchasedprice").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If Val(CC(txtNewUnitCost.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter valid unit cost!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewUnitCost.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to update selected inventory?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblinventory set stockref='" & txtStockRef.Text & "',purchasedprice='" & Val(CC(txtNewUnitCost.Text)) & "' where trnid = '" & trnid.Text & "'" : com.ExecuteNonQuery()
            XtraMessageBox.Show("inventory Successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            If frmInventoryConsumables.Visible = True Then
                frmInventoryConsumables.FilterInventoryReports()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub frmReportDamage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub

End Class