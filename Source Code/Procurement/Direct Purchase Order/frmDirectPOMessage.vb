Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins

Public Class frmDirectPOMessage
    Public confirmedPO As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        If txtMessage.Text = "" Then
            XtraMessageBox.Show("Please enter message!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMessage.Focus()
            Exit Sub
        End If
        confirmedPO = True
        Me.Close()
    End Sub
End Class