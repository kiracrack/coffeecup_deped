Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmReportOption
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
    Public gv As DataGridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmDepositOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

    End Sub

      
    Private Sub cmdFinish_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click
        Me.Close()
    End Sub
End Class