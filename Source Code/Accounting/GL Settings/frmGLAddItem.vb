Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils

Public Class frmGLAddItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGLGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGLGroup()
        If mode.Text = "edit" Then
            itemcode.ReadOnly = True
            LoadGLItemInfo()
        Else
            itemcode.ReadOnly = False
        End If
    End Sub

    Public Sub LoadGLItemInfo()
        Dim glgroup As String = "" : Dim glparent As String = "" : Dim gllevel As Integer = 0 : Dim cksl As Boolean = False
        com.CommandText = "select *,(select itemname from tblglitem where itemcode=a.groupcode) as groupname,(select itemname from tblglitem where itemcode=a.parent) as parents from tblglitem as a where a.itemcode='" & itemcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            groupcode.Text = rst("groupcode").ToString
            glgroup = rst("groupname").ToString
            txtItemName.Text = rst("itemname").ToString
            gllevel = rst("level")
            gl.Checked = rst("gl")
            cksl = rst("sl")
            parentcode.Text = rst("parent").ToString
            glparent = rst("parents").ToString
        End While
        rst.Close()
        txtGLGroup.Text = glgroup
        txtParent.Text = glparent
        sl.Checked = cksl
        txtLevel.Text = gllevel
        LoadParent(txtLevel.Text)
    End Sub

    Public Sub LoadGLGroup()
        LoadXgridLookupSearch("SELECT itemcode, itemname as 'Group Name' FROM `tblglitem` where glgroup=1 ", "tblglitem", txtGLGroup, gridGLGroup, Me)
        gridGLGroup.Columns("itemcode").Visible = False
    End Sub

    Private Sub txtGLGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGLGroup.EditValueChanged
        On Error Resume Next
        Dim iCurrentRowitemcode As Integer = CInt(txtGLGroup.Properties.View.FocusedRowHandle.ToString)
        groupcode.Text = txtGLGroup.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
        LoadParent(txtLevel.Text)
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
       
        ElseIf countqry("tblglitem", "itemcode='" & itemcode.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Item code already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            itemcode.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblglitem set groupcode='" & groupcode.Text & "', glgroup=0, itemname='" & rchar(txtItemName.Text) & "', parent='" & parentcode.Text & "', gl=" & gl.CheckState & ", sl=" & sl.CheckState & ", level=" & txtLevel.Text & " where itemcode='" & itemcode.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblglitem set groupcode='" & groupcode.Text & "', itemcode='" & itemcode.Text & "', glgroup=0,  itemname='" & rchar(txtItemName.Text) & "', parent='" & parentcode.Text & "', gl=" & gl.CheckState & ", sl=" & sl.CheckState & ", level=" & txtLevel.Text & "" : com.ExecuteNonQuery()
        End If
        txtItemName.Text = "" : itemcode.Text = "" : itemcode.Focus()
        XtraMessageBox.Show("GL item successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub LoadParent(ByVal level As Integer)
        LoadXgridLookupSearch("SELECT itemcode, itemname as 'Parent' FROM `tblglitem` where groupcode='" & groupcode.Text & "' and level=" & level - 1 & " ", "tblglitem", txtParent, gridglparent, Me)
        gridglparent.Columns("itemcode").Visible = False
    End Sub

    Private Sub txtParent_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParent.EditValueChanged
        On Error Resume Next
        Dim iCurrentRowitemcode As Integer = CInt(txtParent.Properties.View.FocusedRowHandle.ToString)
        parentcode.Text = txtParent.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub

    Private Sub txtLevel_EditValueChanged(sender As Object, e As EventArgs) Handles txtLevel.EditValueChanged
        LoadParent(txtLevel.Text)
    End Sub
 
    Private Sub sl_CheckedChanged(sender As Object, e As EventArgs) Handles sl.CheckedChanged
        If sl.Checked = True Then
            txtLevel.Enabled = True
            txtParent.Enabled = True
        Else
            txtLevel.Enabled = False
            txtParent.Enabled = False
        End If
        LoadParent(txtLevel.Text)
    End Sub
End Class