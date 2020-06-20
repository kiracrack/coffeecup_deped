Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils

Public Class frmTAGManagement
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmTransactionGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        filter()
    End Sub

    Public Sub filter()
        LoadXgrid("Select id, Description from tblgltaggingaccountgroup order by Description", "tblgltaggingaccountgroup", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        GridView1.BestFitColumns()
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtdescription.Text = "" Then
            XtraMessageBox.Show("Please provide transaction group name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdescription.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblgltaggingaccountgroup set description='" & rchar(txtdescription.Text) & "' where id='" & groupid.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblgltaggingaccountgroup set description='" & rchar(txtdescription.Text) & "'" : com.ExecuteNonQuery()
        End If
        txtdescription.Text = "" : groupid.Text = "" : mode.Text = "" : filter()
        XtraMessageBox.Show("Account Group successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        groupid.Text = GridView1.GetFocusedRowCellValue("id").ToString
        txtdescription.Text = GridView1.GetFocusedRowCellValue("Description").ToString
        mode.Text = "edit"
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to Continue? there's is no undo function once the code is deleted? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tblgltaggingaccountgroup where id='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            filter()
            XtraMessageBox.Show("Group successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub txtdescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescription.KeyPress
        If e.KeyChar() = Chr(13) Then
            cmdSave.PerformClick()
        End If
    End Sub
End Class