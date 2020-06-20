Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmDirectPOUpdateInvoiceDetails
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        'txtrate.Text = "0"
        com.CommandText = "select * from tblpurchaseorder where ponumber='" & ponumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtInvoiceNumber.Text = rst("invoiceno").ToString
            txtTotalAmount.Text = rst("subtotal").ToString
            txtVat.Text = rst("vat").ToString
            txtCharges.Text = rst("charges").ToString
            txtDiscount.Text = rst("discount").ToString
            txtVerifiedAmount.Text = rst("totalamount").ToString
        End While
        rst.Close()
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtVat.EditValueChanged, txtCharges.EditValueChanged, txtDiscount.EditValueChanged
        txtVerifiedAmount.Text = Val(CC(txtTotalAmount.Text)) + Val(CC(txtCharges.Text)) - Val(CC(txtDiscount.Text)) - Val(CC(txtVat.Text))
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If XtraMessageBox.Show("Are you sure you want to Update Invoice Details? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblpurchaseorder set invoiceno='" & txtInvoiceNumber.Text & "', vat='" & Val(CC(txtVat.Text)) & "', charges='" & Val(CC(txtCharges.Text)) & "', discount='" & Val(CC(txtDiscount.Text)) & "', totalamount='" & Val(CC(txtVerifiedAmount.Text)) & "' where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
            If frmDirectPurchaseOrder.Visible = True Then
                frmDirectPurchaseOrder.filter()
            End If
            If frmPurchaseOrder.Visible = True Then
                frmPurchaseOrder.FilterOption()
            End If
            Me.Close()
        End If
    End Sub
End Class