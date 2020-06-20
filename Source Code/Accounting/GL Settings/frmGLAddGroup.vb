Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils

Public Class frmGLAddGroup
    Dim onload As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGLGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        If mode.Text = "edit" Then
            LoadGLItemInfo()
        Else
            itemcode.ReadOnly = False
        End If
    End Sub

    Public Sub LoadGLItemInfo()
        com.CommandText = "select * from tblglitem  where itemcode='" & itemcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtItemName.Text = rst("itemname").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If itemcode.Text = "" Then
            XtraMessageBox.Show("Please provide Item Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            itemcode.Focus()
            Exit Sub
        ElseIf txtItemName.Text = "" Then
            XtraMessageBox.Show("Please provide gl item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItemName.Focus()
            Exit Sub
        ElseIf countqry("tblglitem", "itemcode='" & itemcode.Text & "' and itemcode<>'" & itemcode.Text & "'") > 0 Then
            XtraMessageBox.Show("Item code already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            itemcode.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblglitem set groupcode='" & itemcode.Text & "', glgroup=1, itemname='" & rchar(txtItemName.Text) & "', parent='', gl=0, sl=0, level=0 where itemcode='" & itemcode.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblglitem set groupcode='" & itemcode.Text & "',itemcode='" & itemcode.Text & "', glgroup=1, itemname='" & rchar(txtItemName.Text) & "', parent='', gl=0, sl=0, level=0" : com.ExecuteNonQuery()
        End If
        txtItemName.Text = "" : itemcode.Text = "" : itemcode.Focus()
        XtraMessageBox.Show("GL group successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class