Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmVerifiedCreditCard
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        'txtrate.Text = "0"
        txtVerifiedAmount.Text = txtTotalCreditCardAmount.Text
    End Sub
  
    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtrate.EditValueChanged
        txtVerifiedAmount.Text = Val(CC(txtTotalCreditCardAmount.Text)) - Val((Val(CC(txtrate.Text)) / 100) * Val(CC(txtTotalCreditCardAmount.Text)))
    End Sub

    Private Sub txtVerifiedAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtVerifiedAmount.EditValueChanged
        txtrate.Text = Val(100 - ((Val(CC(txtVerifiedAmount.Text)) / Val(CC(txtTotalCreditCardAmount.Text))) * 100))
    End Sub
    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmTransactionClearing.ValidatingCreditCard(txtrate.Text, txtVerifiedAmount.Text)
            Me.Close()
        End If
    End Sub
End Class