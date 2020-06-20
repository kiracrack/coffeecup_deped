Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils

Public Class frmTAGDetails
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmGLAccountTaggingGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGroup()
    End Sub

    Public Sub LoadGroup()
        LoadXgridLookupSearch("select id, description as 'Select' from tblgltaggingaccountgroup", "tblgltaggingaccountgroup", txtGroup, gvGroup, Me)
        gvGroup.Columns("id").Visible = False
    End Sub

    Private Sub txtGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroup.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtGroup.Properties.View.FocusedRowHandle.ToString)
        groupid.Text = txtGroup.Properties.View.GetFocusedRowCellValue("id").ToString()
        LoadTaggedAccount()
    End Sub

    Public Sub LoadTaggedAccount()
        If groupid.Text = "" Then Exit Sub
        LoadXgrid("Select id,referenceno as 'Target Reference', Description,(select itemname from tblglitem where itemcode=tblgltaggingaccountdetails.itemcode and companyid=tblgltaggingaccountdetails.companyid) as 'Tagged Title' from tblgltaggingaccountdetails where groupid='" & groupid.Text & "' order by Description", "tblgltaggingaccountdetails", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"Target Reference"}, GridView1, HorzAlignment.Center)
        GridView1.BestFitColumns()
        GridView1.Columns("Target Reference").Width = 100

    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtGroup.Text = "" Then
            XtraMessageBox.Show("Please account group name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGroup.Focus()
            Exit Sub
        End If
        frmGLBrowseSourceTable.ckAccount.Checked = True
        frmGLBrowseSourceTable.groupid.Text = groupid.Text
        frmGLBrowseSourceTable.Show(Me)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to Continue? there's is no undo function once the code is deleted? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tblgltaggingaccountdetails where id='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            LoadTaggedAccount()
            XtraMessageBox.Show("Account successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadTaggedAccount()
    End Sub
 
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        frmTAGManagement.ShowDialog(Me)
        LoadGroup()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmTAGUpdateAccountTitle.Show(Me)
    End Sub

    Public Function UpdateAccountTitle(ByVal itemcode As String, ByVal companyid As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblgltaggingaccountdetails set companyid='" & companyid & "', itemcode='" & itemcode & "'  where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
        Next
    End Function

    Public Function UpdateAccountTitleCation(ByVal AccountTitle As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Tagged Title", AccountTitle)
        Next
    End Function

End Class