Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSystemOwnerConfirmation
    Public Authourized As Boolean = False
    Private Sub frmChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        txtpassword.Text = "password"
    End Sub
    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar() = Chr(13) Then
            If EncryptTripleDES(txtpassword.Text) = "ckJGxZFQSsD8dSPKNksWrw==" Then
                Authourized = True
                Me.Close()
            Else
                Authourized = False
                XtraMessageBox.Show("Pasword not authorized!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub
End Class