Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmCoffeecupClientAccess

    Private Sub frmChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadPermission()
        LoadCurrentAccess()
        SetIcon(Me)
    End Sub

    Public Sub LoadPermission()
        LoadXgridLookupSearch("select authcode, authDescription as 'Permission' from tbluserauthority", "tbluserauthority", txtPermission, gridPermission, Me)
        gridPermission.Columns("authcode").Visible = False
    End Sub

    Private Sub txtPermission_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPermission.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtPermission.Properties.View.FocusedRowHandle.ToString)
        code.Text = txtPermission.Properties.View.GetFocusedRowCellValue("authcode").ToString()
        txtPermission.Text = txtPermission.Properties.View.GetFocusedRowCellValue("Permission").ToString()
    End Sub
    Public Sub LoadCurrentAccess()
        LoadXgrid("select id, (select authDescription from tbluserauthority where authCode=tblaccountaccess.permission) as 'Permission', defaultaccess as 'Default' from tblaccountaccess where userid='" & userid.Text & "'", "tbldeprecitionofassets", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        XgridColAlign({"Default"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
        If countqry("tblaccountaccess", "userid='" & userid.Text & "' and defaultaccess=1") > 0 Then
            ckdefault.Checked = False
            ckdefault.Enabled = False
        Else
            ckdefault.Enabled = True
        End If
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If txtPermission.Text = "" Then
            XtraMessageBox.Show("Please select permission!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPermission.Focus()
            Exit Sub
        ElseIf countqry("tblaccountaccess", "userid='" & userid.Text & "' and permission='" & code.Text & "'") > 0 Then
            XtraMessageBox.Show("Permission already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPermission.Focus()
            Exit Sub
        End If

        com.CommandText = "insert into tblaccountaccess set userid='" & userid.Text & "', permission='" & code.Text & "',defaultaccess=" & ckdefault.CheckState & " " : com.ExecuteNonQuery()
        If ckdefault.Checked = True Then
            com.CommandText = "update tblaccounts set coffeecupuser=1, coffeecupposition='" & code.Text & "' where accountid='" & userid.Text & "'" : com.ExecuteNonQuery()
        End If
        txtPermission.Properties.DataSource = Nothing
        txtPermission.Text = ""
        code.Text = ""
        LoadPermission()
        LoadCurrentAccess()
    End Sub

    Private Sub cmdremove_Click(sender As Object, e As EventArgs) Handles cmdremove.Click
        If XtraMessageBox.Show("Are you sure you want to continue remove?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If CBool(GridView1.GetFocusedRowCellValue("Default").ToString()) = True Then
                com.CommandText = "update tblaccounts set coffeecupuser=0, coffeecupposition='' where accountid='" & userid.Text & "'" : com.ExecuteNonQuery()
            End If
            DeleteRow("id", "id", "tblaccountaccess", GridView1, Me)
            LoadCurrentAccess()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadCurrentAccess()
    End Sub
End Class