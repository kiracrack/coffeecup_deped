Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmConnectionSetup
    Private Sub frmConnectionSetup_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub frmBackuptool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        clientserver = ""
        clientuser = ""
        clientpass = ""
        clientdatabase = ""
        connclient.Close()
    End Sub
    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If txtServerhost.Text = "" Then
            MessageBox.Show("Please enter Server host!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtServerhost.Focus()
            Exit Sub
        ElseIf txtusername.Text = "" Then
            MessageBox.Show("Please enter username!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Focus()
            Exit Sub
        End If
        If (Not System.IO.Directory.Exists(file_conn_dir)) Then
            System.IO.Directory.CreateDirectory(file_conn_dir)
        End If
        Try
            clientserver = txtServerhost.Text
            clientport = txtPort.Text
            clientuser = txtusername.Text
            clientpass = txtpassword.Text
            clientdatabase = txtDatabase.Text

            If OpenClientServer() = True Then
                Dim detailsFile As StreamWriter = Nothing
                If ckDefault.Checked = True Then
                    If System.IO.File.Exists(file_conn) = True Then
                        System.IO.File.Delete(file_conn)
                    End If
                    detailsFile = New StreamWriter(file_conn, True)
                    detailsFile.WriteLine(EncryptTripleDES(txtConnectionName.Text & "," & txtServerhost.Text & "," & txtPort.Text & "," & txtusername.Text & "," & txtpassword.Text & "," & txtDatabase.Text & "," & txtJoinbase.Text))
                    detailsFile.Close()

                    If System.IO.File.Exists(file_conn_dir & "\" & txtConnectionName.Text) = True Then
                        System.IO.File.Delete(file_conn_dir & "\" & txtConnectionName.Text)
                    End If
                    detailsFile = Nothing
                    detailsFile = New StreamWriter(file_conn_dir & "\" & txtConnectionName.Text, True)
                    detailsFile.WriteLine(EncryptTripleDES(txtConnectionName.Text & "," & txtServerhost.Text & "," & txtPort.Text & "," & txtusername.Text & "," & txtpassword.Text & "," & txtDatabase.Text & "," & txtJoinbase.Text))
                    detailsFile.Close()
                    MessageBox.Show("Connection Successfully Activated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End
                Else
                    If System.IO.File.Exists(file_conn_dir & "\" & txtConnectionName.Text) = True Then
                        System.IO.File.Delete(file_conn_dir & "\" & txtConnectionName.Text)
                    End If
                    detailsFile = Nothing
                    detailsFile = New StreamWriter(file_conn_dir & "\" & txtConnectionName.Text, True)
                    detailsFile.WriteLine(EncryptTripleDES(txtConnectionName.Text & "," & txtServerhost.Text & "," & txtPort.Text & "," & txtusername.Text & "," & txtpassword.Text & "," & txtDatabase.Text & "," & txtJoinbase.Text))
                    detailsFile.Close()
                    MessageBox.Show("Connection Successfully Save", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                            & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub
 
End Class