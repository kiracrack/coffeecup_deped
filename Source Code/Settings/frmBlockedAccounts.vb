Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmBlockedAccounts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmBlockedAccounts_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        txtdetails.Text = ""
    End Sub

    Private Sub frmBlockedRequisition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMove.Click
        If txtdetails.Text = "" Then
            XtraMessageBox.Show("Please enter reason!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdetails.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmUsersAccounts.BlockedAccounts(txtdetails.Text)
            Me.Close()
        End If
    End Sub
End Class