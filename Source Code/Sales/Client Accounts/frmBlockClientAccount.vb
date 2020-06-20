Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmBlockClientAccount
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmDepositOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If txtremarks.Text = "Please enter reason.." Or txtremarks.Text = "" Then
            XtraMessageBox.Show("Please enter cancellation reason", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtremarks.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to cancel this request?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmClientManagement.BlockClient(If(txtremarks.Text = "Please enter reason..", "", txtremarks.Text))

            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub txtremarks_GotFocus(sender As Object, e As EventArgs) Handles txtremarks.GotFocus
        If txtremarks.Text = "Please enter reason.." Then
            txtremarks.Text = ""
        End If
    End Sub

    Private Sub txtremarks_LostFocus(sender As Object, e As EventArgs) Handles txtremarks.LostFocus
        If txtremarks.Text = "" Then
            txtremarks.Text = "Please enter reason.."
        End If
    End Sub

   
End Class