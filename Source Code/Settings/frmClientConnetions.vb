Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmClientConnetions
    Dim cpass As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.F12) Then
            frmConnectionSetup.ShowDialog(Me)
        End If
        Return ProcessCmdKey
    End Function

    
    Private Sub frmClientConnetions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillComboFromFile()
    End Sub
    Private Sub FillComboFromFile()
        Dim path As String = ""
        path = Application.StartupPath.ToString & "\Connection\"
        txtServer.Properties.Items.Clear()
        file_conn_dir = path
        For Each file As String In System.IO.Directory.GetFiles(path)
            txtServer.Properties.Items.Add(UCase(System.IO.Path.GetFileNameWithoutExtension(file)))
        Next
    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        If txtServer.Text = "" Then Exit Sub
        If XtraMessageBox.Show("Are you sure you want to continue switch connection?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim strSetup As String = ""
            Dim sr As StreamReader = File.OpenText(file_conn_dir & "\" & txtServer.Text)
            Dim br As String = sr.ReadLine() : sr.Close()
            strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In strSetup.Split(New Char() {","c})
                If cnt = 0 Then
                    clientconnectionname = word
                ElseIf cnt = 1 Then
                    clientserver = word
                ElseIf cnt = 2 Then
                    clientport = word
                ElseIf cnt = 3 Then
                    clientuser = word
                ElseIf cnt = 4 Then
                    clientpass = word
                ElseIf cnt = 5 Then
                    clientdatabase = word
                End If
                cnt = cnt + 1
            Next
            If System.IO.File.Exists(file_conn) = True Then
                System.IO.File.Delete(file_conn)
            End If
            Dim detailsFile As StreamWriter = Nothing
            detailsFile = New StreamWriter(file_conn, True)
            detailsFile.WriteLine(EncryptTripleDES(clientconnectionname & "," & clientserver & "," & clientport & "," & clientuser & "," & clientpass & "," & clientdatabase & ",none"))
            detailsFile.Close()
            MessageBox.Show("Connection Successfully Activated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' End
        End If
    End Sub
End Class