Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmActivateEngine
    Private Sub frmBackuptool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtSystemKey.Text = getMacAddress()
    End Sub
    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If txtActivationCode.Text = "" Then
            MessageBox.Show("Please enter activation key!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtActivationCode.Focus()
            Exit Sub
        ElseIf txtActivationCode.Text <> EncryptTripleDES(txtSystemKey.Text) Then
            MessageBox.Show("Please enter valid activation key!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtActivationCode.Focus()
            Exit Sub
        End If

        Try
            com.CommandText = "update tblcompanysettings set enginecode='" & txtActivationCode.Text & "' where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
            SendSystemActivationStatus(EncryptTripleDES(txtSystemKey.Text), "Not specified")
            MessageBox.Show("System successfully activated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        End
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

    End Sub
End Class