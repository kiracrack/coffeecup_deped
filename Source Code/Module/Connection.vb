Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports DevExpress.XtraEditors
Imports Microsoft.Win32
Imports System.Security.Cryptography
Imports System.Security.Principal

Module Connection
    Public conn As New MySqlConnection 'for MySQLDatabase Connection
    Public msda As MySqlDataAdapter 'is use to update the dataset and datasource
    Public dst As New DataSet 'miniature of your table - cache table to client
    Public com As New MySqlCommand
    Public rst As MySqlDataReader
    Public cb As MySqlCommandBuilder

    ' LOCALHOST
    Public sqlconnectionname As String
    Public sqlserver As String
    Public sqlport As String
    Public sqluser As String
    Public sqlpass As String
    Public sqldatabase As String
    Public sqljoinbase As String
    Public conString As String
    Public file_conn As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".conn"
    Public file_conn_dir As String = Application.StartupPath.ToString & "\Connection"
    Public System_config As String = Application.StartupPath.ToString & "\System.config"
    Public ZIPFILE_LOCATION As String = Application.StartupPath.ToString & "\Archived\"


    Public connclient As New MySqlConnection 'for MySQLDatabase Connection
    Public msdaclient As MySqlDataAdapter 'is use to update the dataset and datasource
    Public da As MySqlDataAdapter 'is use to update the dataset and datasource
    Public dstclient As New DataSet 'miniature of your table - cache table to client
    Public st As New DataSet 'miniature of your table - cache table to client
    Public comclient As New MySqlCommand
    Public rstclient As MySqlDataReader
    Public ConnectedServer As Boolean = False

    Public clientconnectionname As String = ""
    Public clientserver As String = ""
    Public clientport As String = ""
    Public clientuser As String = ""
    Public clientpass As String = ""
    Public clientdatabase As String = ""

    Public regGlobalkey As String = "ALTER_RPOMS"
    Public AttachmentRefno(50) As String
   
    Public Sub connectServer()
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(file_conn)
        Dim br As String = sr.ReadLine() : sr.Close()
        strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
        For Each word In strSetup.Split(New Char() {","c})
            If cnt = 0 Then
                sqlconnectionname = word
            ElseIf cnt = 1 Then
                sqlserver = word
            ElseIf cnt = 2 Then
                sqlport = word
            ElseIf cnt = 3 Then
                sqluser = word
            ElseIf cnt = 4 Then
                sqlpass = word
            ElseIf cnt = 5 Then
                sqldatabase = word
            ElseIf cnt = 6 Then
                sqljoinbase = word
            End If
            cnt = cnt + 1
        Next
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & " ; password=" & sqlpass & " ; database=" & sqldatabase & " ; Allow Zero Datetime=True ; Connection Timeout=28800 ; allow user variables=true"
            'conString = "server=" & sqlserver & ";  Port=" & sqlport & "; user=" & sqluser & " ; password=" & sqlpass & "; database=" & sqldatabase & "; Allow Zero Datetime=True ; Connection Timeout=28800"
            com.CommandTimeout = 28800
            com.Connection = conn
            conn.Open()
            If countqry("tblaccounts", "username='root'") = 0 Then
                com.CommandText = "insert into tblaccounts set accountid=100,fullname='SYSTEM ADMINISTRATOR', designation='ROOT SYSTEM',username='ROOT', password='" & EncryptTripleDES("ROOT" + "12sysadmin10134") & "',datereg=current_timestamp,status=1,coffeecupuser=0,coffeecupposition=''" : com.ExecuteNonQuery()
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmConnectionSetup.ShowDialog()
            Exit Sub
        Catch errMS As Exception
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmConnectionSetup.ShowDialog()
            Exit Sub
        End Try
    End Sub

    Public Function ChangeConnection(ByVal connection As String) As Boolean
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(connection)
        Dim br As String = sr.ReadLine() : sr.Close()
        strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
        For Each word In strSetup.Split(New Char() {","c})
            If cnt = 0 Then
                sqlconnectionname = word
            ElseIf cnt = 1 Then
                sqlserver = word
            ElseIf cnt = 2 Then
                sqlport = word
            ElseIf cnt = 3 Then
                sqluser = word
            ElseIf cnt = 4 Then
                sqlpass = word
            ElseIf cnt = 5 Then
                sqldatabase = word
            ElseIf cnt = 6 Then
                sqljoinbase = word
            End If
            cnt = cnt + 1
        Next
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                conn = Nothing
                com.Connection = Nothing
                msda.Dispose()
                dst.Dispose()
                com.Dispose()
                rst = Nothing
            End If
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & " ; password=" & sqlpass & " ; database=" & sqldatabase & " ; Allow Zero Datetime=True ; Connection Timeout=28800 ; allow user variables=true"
            com.CommandTimeout = 28800
            com.Connection = conn
            conn.Open()

            If countqry("tblaccounts", "username='root'") = 0 Then
                com.CommandText = "insert into tblaccounts set accountid=100,fullname='SYSTEM ADMINISTRATOR', designation='ROOT SYSTEM',username='ROOT', password='" & EncryptTripleDES("ROOT" + "12sysadmin10134") & "',datereg=current_timestamp,status=1,coffeecupuser=0,coffeecupposition=''" : com.ExecuteNonQuery()
            End If
            Return True
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Catch errMS As Exception
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmConnectionSetup.ShowDialog()
            Return False
        End Try
        Return True
    End Function
    Public Sub Changeserver()
        Try
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabase & ";Connection Timeout=28800;  Allow Zero Datetime=True"
            conn.Open()
            com.Connection = conn
            com.CommandTimeout = 28800
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
            Exit Sub
        Catch errMS As Exception
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
            Exit Sub
        End Try
    End Sub

    Public Function OpenClientServer() As Boolean
        Try
            connclient = New MySql.Data.MySqlClient.MySqlConnection
            connclient.ConnectionString = "server=" & clientserver & "; Port=" & clientport & "; user id=" & clientuser & "; password=" & clientpass & "; database=" & clientdatabase & "; Connection Timeout=10; allow user variables=true"
            connclient.Open()
            comclient.Connection = connclient
            comclient.CommandTimeout = 0
            OpenClientServer = True

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OpenClientServer = False
            Return False
        Catch errMS As Exception
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OpenClientServer = False
            Return False
        End Try
    End Function
End Module
