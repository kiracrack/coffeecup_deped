Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmVerifiedPurchaseOrder
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        'txtrate.Text = "0"
        txtVerifiedAmount.Text = txtTotalAmount.Text
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtVat.EditValueChanged, txtCharges.EditValueChanged, txtDiscount.EditValueChanged
        txtVerifiedAmount.Text = Val(CC(txtTotalAmount.Text)) + Val(CC(txtCharges.Text)) - Val(CC(txtDiscount.Text)) - Val(CC(txtVat.Text))
    End Sub
 
    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtInvoiceNumber.Text = "" Then
            MsgBox("Please enter Invoice Number!", MsgBoxStyle.Exclamation, "Error Message")
            txtInvoiceNumber.Focus()
            Exit Sub
        ElseIf countqry("tblpurchaseorder", "invoiceno='" & txtInvoiceNumber.Text & "' and cancelled=0") > 0 Then
            MsgBox("Invoice number already exists!", MsgBoxStyle.Exclamation, "Error Message")
            txtInvoiceNumber.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmTransactionClearing.ValidatingPurchaseOrder(txtInvoiceNumber.Text, Val(CC(txtVat.Text)), Val(CC(txtCharges.Text)), Val(CC(txtDiscount.Text)), Val(CC(txtVerifiedAmount.Text)))
            Me.Close()
        End If
    End Sub
End Class