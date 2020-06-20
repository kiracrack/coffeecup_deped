Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmActivateNewExpiration
    Private Sub frmBackuptool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtMacAddress.Text = getMacAddress()
    End Sub
    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            Dim newExpiration As String = ""
            If txtActivationCode.Text = "" Then
                MessageBox.Show("Please enter activation key!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtActivationCode.Focus()
                Exit Sub
            End If

            For Each strLine As String In DecryptTripleDES(txtActivationCode.Text).Split(vbCrLf)
                Dim word As String() = strLine.Split("|")
                If word(0) = getMacAddress() Then
                    newExpiration = word(1)
                    com.CommandText = "update tblcompanysettings set expirydate='" & EncryptTripleDES(newExpiration) & "' where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
                    SendSystemActivationStatus(word(0), CDate(word(1)).ToString("MMMM dd, yyyy"))
                    com.CommandText = "UPDATE tblcompanysettings set tokencode='" & EncryptTripleDES("ACTIVED") & "'" : com.ExecuteNonQuery()
                    MessageBox.Show("System successfully activated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End
                Else
                    MessageBox.Show("Invalid activation key", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        End
    End Sub
End Class