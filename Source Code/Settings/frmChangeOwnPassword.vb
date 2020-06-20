Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmChangeOwnPassword
    Private Sub frmChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        txtCurrentPassword.Text = "password"
        txtNewPassword.Text = "password"
        txtVerifyPassword.Text = "password"
    End Sub
    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVerifyPassword.KeyPress
        If e.KeyChar() = Chr(13) Then
            cmdSaveButton.PerformClick()
        End If
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If countqry("tblaccounts", "password='" & EncryptTripleDES(UCase(globaluser) + txtCurrentPassword.Text) & "'") = 0 Then
            XtraMessageBox.Show("Invalid your current password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCurrentPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text = "" Or txtNewPassword.Text = "password" Then
            XtraMessageBox.Show("Please enter password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewPassword.Focus()
            Exit Sub
        ElseIf txtVerifyPassword.Text = "" Then
            XtraMessageBox.Show("Please enter verify password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text <> txtVerifyPassword.Text Then
            XtraMessageBox.Show("Password did not match! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewPassword.Text = ""
            txtVerifyPassword.Text = ""
            txtNewPassword.Focus()
            Exit Sub
        End If
        com.CommandText = "update tblaccounts set password='" & EncryptTripleDES(UCase(globaluser) + txtVerifyPassword.Text) & "' where accountid='" & globaluserid & "'" : com.ExecuteNonQuery()
        XtraMessageBox.Show("Password successfully changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class