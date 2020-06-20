Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmBackupTool

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If XtraMessageBox.Show("Are you sure continue backup data? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "MySQL File (*.sql)|*.sql"
            saveFileDialog1.FileName = txtKey.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim MyInput As String = txtKey.Text
                Dim process As System.Diagnostics.Process
                Dim processStartInfo As System.Diagnostics.ProcessStartInfo
                processStartInfo = New System.Diagnostics.ProcessStartInfo
                processStartInfo.FileName = "cmd.exe"

                If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                    processStartInfo.Verb = "runas"
                Else
                    ' No need to prompt to run as admin
                End If
                processStartInfo.Arguments = "/C mysqldump --opt --host " & sqlserver & " --password=" & sqlpass & " --user=" & sqluser & " --database " & sqldatabase & " -r  """ & saveFileDialog1.FileName & """"
                processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                processStartInfo.UseShellExecute = True
                process = System.Diagnostics.Process.Start(processStartInfo)
                'System.Threading.Thread.Sleep()
                process.WaitForExit()
                If process.HasExited Then
                    XtraMessageBox.Show("Database " & txtKey.Text & " Successfully Backed up!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
            
          
            Try
                
            Catch errMS As Exception
                XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub frmdbUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtKey.Text = "coffecup " & GetDateTimeID() & ".sql"
    End Sub

End Class