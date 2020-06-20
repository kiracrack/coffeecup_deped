Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmClientGroup
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClientGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadData()
        LoadGridviewAppearance(GridView1)
        If mode.Text <> "edit" Then
            code.Text = getcodeid("groupcode", "tblclientgroup", "100")
        End If
    End Sub

    Public Sub LoadData()
        LoadXgrid("select groupcode as 'Code', groupname as 'Group Name', `Default` from tblclientgroup", "tblclientgroup", Em, GridView1, Me)

        GridView1.Columns("Code").Width = 80
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        ' GridView1.SelectRow(1)
    End Sub
 
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please Enter Group Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter Group Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        ElseIf countqry("tblclientgroup", "groupcode='" & code.Text & "' ") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Group Code already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf countqry("tblclientgroup", "groupname='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Group Name already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblclientgroup set groupname='" & rchar(UCase(txtDescription.Text)) & "' where groupcode='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblclientgroup set groupcode='" & code.Text & "', groupname='" & rchar(UCase(txtDescription.Text)) & "'" : com.ExecuteNonQuery()
            End If

            LoadData()
            mode.Text = ""
            code.Text = getcodeid("groupcode", "tblclientgroup", "100")
            XtraMessageBox.Show("Group successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select * from tblclientgroup where groupcode='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("groupname").ToString
        End While
        rst.Close()
        mode.Text = "edit"

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tblclientgroup where groupcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadData() : code.Text = getcodeid("groupcode", "tblclientgroup", "100")
                XtraMessageBox.Show("Group successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub SetDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetDefaultToolStripMenuItem.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to set as default selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tblclientgroup set `default`=0 " : com.ExecuteNonQuery()
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "update tblclientgroup set `default`=1 where groupcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadData()
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub
End Class