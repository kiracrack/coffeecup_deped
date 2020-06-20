Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmVerifiedVoucherConfirmation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtReceiverName.Text = "" Then
            XtraMessageBox.Show("Please enter receiver name? ", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReceiverName.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmTransactionClearing.validatingVoucherPayment(txtReceiverName.Text)
            Me.Close()
        End If
    End Sub
End Class