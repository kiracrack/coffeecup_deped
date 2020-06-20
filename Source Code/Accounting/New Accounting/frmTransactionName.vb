Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils

Public Class frmTransactionName
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmTransactionName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGroup()
    End Sub


    Public Sub LoadGroup()
        LoadXgridLookupSearch("select id, description as 'Select' from tblgltransactiongroup", "tblgltransactiongroup", txtGroup, gvGroup, Me)
        gvGroup.Columns("id").Visible = False
    End Sub

    Private Sub txtGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroup.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtGroup.Properties.View.FocusedRowHandle.ToString)
        groupid.Text = txtGroup.Properties.View.GetFocusedRowCellValue("id").ToString()
        filterName()
    End Sub

    Public Sub filterName()
        If groupid.Text = "" Then Exit Sub
        LoadXgrid("Select id, Description,sp_command as 'SP Command' from tblgltransactionname where groupid='" & groupid.Text & "' order by Description", "tblgltransactionname", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"SP Command"}, GridView1, HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub


    Private Sub txtdescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescription.KeyPress
        If e.KeyChar() = Chr(13) Then
            cmdSave.PerformClick()
        End If
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtdescription.Text = "" Then
            XtraMessageBox.Show("Please provide transaction item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdescription.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblgltransactionname set description='" & rchar(txtdescription.Text) & "',sp_command='" & txtSP_Command.Text & "' where id='" & itemid.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblgltransactionname set groupid='" & groupid.Text & "', description='" & rchar(txtdescription.Text) & "',sp_command='" & txtSP_Command.Text & "' " : com.ExecuteNonQuery()
        End If
        txtdescription.Text = "" : itemid.Text = "" : txtSP_Command.Text = "" : mode.Text = "" : filterName()
        XtraMessageBox.Show("Transaction Name successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        itemid.Text = GridView1.GetFocusedRowCellValue("id").ToString
        txtdescription.Text = GridView1.GetFocusedRowCellValue("Description").ToString
        txtSP_Command.Text = GridView1.GetFocusedRowCellValue("SP Command").ToString
        mode.Text = "edit"
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to Continue? there's is no undo function once the code is deleted? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tblgltransactionname where id='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblgltransactiontagging where itemid='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            filterName()
            XtraMessageBox.Show("Transaction Name successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterName()
    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        XtraMessageBox.Show("Stored Procedure Command: is a accounting reports generator command base on transaction setup! ask your IT or programmer for assistance", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class