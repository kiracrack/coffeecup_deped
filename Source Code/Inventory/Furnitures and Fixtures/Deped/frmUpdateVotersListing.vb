Imports DevExpress.XtraEditors

Public Class frmUpdateVotersListing
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

     Private Sub frmChangeLeader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)

    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        If txtStartingNo.Text = "" Then
            XtraMessageBox.Show("Please enter beginning number", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmDepedFFESummary.UpdateListingNo(txtStartingNo.Text)
        Me.Close()
    End Sub

    Private Sub txtStartingNo_EditValueChanged(sender As Object, e As EventArgs) Handles txtStartingNo.EditValueChanged
        txtEndingNo.Text = Val(txtStartingNo.Text) + Val(txtTotalSelected.Text)
    End Sub
End Class