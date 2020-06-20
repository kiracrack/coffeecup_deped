Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmProductArticle
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
  

End Class