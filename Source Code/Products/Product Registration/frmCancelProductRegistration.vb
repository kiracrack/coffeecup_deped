Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmCancelProductRegistration
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCancelRequest_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        txtrequestby.Text = ""
        txtdetails.Text = ""
        pid.Text = ""
    End Sub

    Private Sub frmCancelRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMove.Click
        If txtdetails.Text = "" Then
            XtraMessageBox.Show("Please enter reason/remarks!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdetails.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmProductRequestList.CancelledRequest(txtdetails.Text)
            Me.Close()
        End If
    End Sub
End Class