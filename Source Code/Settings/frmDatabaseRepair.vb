Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmDatabaseRepair
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmDepositOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadDatabases()
    End Sub
    Public Sub LoadDatabases()
        com.CommandText = "show databases;" : rst = com.ExecuteReader
        While rst.Read
            txtReportForm.Properties.Items.Add(rst("Database").ToString)
        End While
        rst.Close()
    End Sub

  
    Private Sub cmdFinish_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click
        Dim Command As String = "mysqlcheck -h " & sqlserver & " -P " & sqlport & " -u " & sqluser & " -p" & sqlpass & " --repair """ & txtReportForm.Text & """"
        Shell("cmd /k" & Command & " & exit", AppWinStyle.NormalFocus, True)
        MsgBox("Database successfully repaired", MsgBoxStyle.Information)
    End Sub
End Class