Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmConfirmedRequestProcessing
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmConfirmedRequestProcessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If txtremarks.Text = "Please enter message.." Or txtremarks.Text = "" Then
            XtraMessageBox.Show("Please enter message", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtremarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblrequisitions set hold=0 where pid='" & pid.Text & "'" : com.ExecuteNonQuery()

            RecordApprovingHistory("requisition", pid.Text, pid.Text, "processed", txtremarks.Text)
            XtraMessageBox.Show("Request successfully submited as for Approval!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            pid.Text = ""
            frmRequisitionsManagement.FilterOption()
            Me.Hide()
            frmProceedNewRequest.Close()
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub txtremarks_GotFocus(sender As Object, e As EventArgs) Handles txtremarks.GotFocus
        If txtremarks.Text = "Please enter message.." Then
            txtremarks.Text = ""
        End If
    End Sub

    Private Sub txtremarks_LostFocus(sender As Object, e As EventArgs) Handles txtremarks.LostFocus
        If txtremarks.Text = "" Then
            txtremarks.Text = "Please enter message.."
        End If
    End Sub

   
End Class