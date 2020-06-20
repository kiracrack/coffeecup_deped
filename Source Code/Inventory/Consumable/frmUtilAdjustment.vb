Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmUtilAdjustment

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
            productid.Text = rst("PRODUCTID").ToString
            officeid.Text = rst("officeid").ToString
            txtproduct.Text = rst("PRODUCTS").ToString
            txtStock.Text = rst(GlobalOfficeCaption).ToString
            txtOldQuantity.Text = rst("QUANTITY").ToString
            txtNewQuantity.Text = rst("QUANTITY").ToString
            txtunit.Text = rst("unit").ToString
            txtNewUnitCost.Text = rst("purchasedprice").ToString
            txtOldUnitCost.Text = rst("purchasedprice").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If Val(CC(txtNewQuantity.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter valid quantity!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewQuantity.Focus()
            Exit Sub
        ElseIf Val(CC(txtNewUnitCost.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter valid unit cost!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewUnitCost.Focus()
            Exit Sub
        ElseIf Val(CC(txtOldQuantity.Text)) = Val(CC(txtNewQuantity.Text)) Then
            XtraMessageBox.Show("Please enter valid unit cost!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewUnitCost.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            XtraMessageBox.Show("Please provide remarks!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRemarks.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to adjust current inventory?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblinventoryadjustment set productid='" & productid.Text & "',officeid ='" & officeid.Text & "',  " _
                               + " fromquantity = '" & Val(CC(txtOldQuantity.Text)) & "'," _
                               + " newquantity = '" & Val(CC(txtNewQuantity.Text)) & "'," _
                               + " fromamount = '" & Val(CC(txtOldUnitCost.Text)) & "'," _
                               + " newamount = '" & Val(CC(txtNewUnitCost.Text)) & "'," _
                               + " remarks = '" & rchar(txtRemarks.Text) & "', dateadj=current_timestamp, trnby='" & globaluserid & "'"
            com.ExecuteNonQuery()
            com.CommandText = "update tblinventory set quantity='" & Val(CC(txtNewQuantity.Text)) & "',purchasedprice='" & Val(CC(txtNewUnitCost.Text)) & "' where trnid = '" & trnid.Text & "'" : com.ExecuteNonQuery()
            'If Val(CC(txtOldQuantity.Text)) < Val(CC(txtNewQuantity.Text)) Then
            '    LogInventoryLedger("Inventory Adjustment", officeid.Text, productid.Text, Val(CC(txtNewQuantity.Text)) - Val(CC(txtOldQuantity.Text)), 0, rchar(txtRemarks.Text), globalofficeid)
            'ElseIf Val(CC(txtOldQuantity.Text)) > Val(CC(txtNewQuantity.Text)) Then
            '    LogInventoryLedger("Inventory Adjustment", officeid.Text, productid.Text, 0, Val(CC(txtOldQuantity.Text)) - Val(CC(txtNewQuantity.Text)), rchar(txtRemarks.Text), globalofficeid)
            'End If

            XtraMessageBox.Show("inventory Successfully adjusted!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNewQuantity.Text = "0"
            txtunit.Text = ""
            txtOldQuantity.Text = ""
            txtOldUnitCost.Text = ""
            txtNewUnitCost.Text = ""
            txtRemarks.Text = ""
            If frmInventoryConsumables.Visible = True Then
                frmInventoryConsumables.FilterInventoryReports()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub frmReportDamage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        lblOffice.Text = "Current " & GlobalOfficeCaption
    End Sub
    Private Sub txtquan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewQuantity.GotFocus
        txtNewQuantity.SelectionStart = 0
        txtNewQuantity.SelectionLength = Len(txtNewQuantity.Text)
    End Sub

    
End Class