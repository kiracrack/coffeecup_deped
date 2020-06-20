Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmClinics
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClinics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadData()
        LoadGridviewAppearance(GridView1)
        If mode.Text <> "edit" Then
            code.Text = getcodeid("clinicid", "tblclinics", "100")
        End If
    End Sub

    Public Sub LoadData()
        LoadXgrid("select clinicid as 'Code', Description  from tblclinics", "tblclinics", Em, GridView1, Me)

        GridView1.Columns("Code").Width = 80
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        ' GridView1.SelectRow(1)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please Enter Clinic Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        ElseIf countqry("tblclinics", "clinicid='" & code.Text & "' ") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Clinic Code already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf countqry("tblclinics", "Description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Description already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblclinics set Description='" & rchar(UCase(txtDescription.Text)) & "' where clinicid='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblclinics set clinicid='" & code.Text & "', Description='" & rchar(UCase(txtDescription.Text)) & "'" : com.ExecuteNonQuery()
            End If

            LoadData()
            mode.Text = ""
            code.Text = getcodeid("clinicid", "tblclinics", "100")
            XtraMessageBox.Show("Clinic Type successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select * from tblclinics where clinicid='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("Description").ToString
        End While
        rst.Close()
        mode.Text = "edit"

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tblclinics where clinicid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadData() : code.Text = getcodeid("clinicid", "tblclinics", "100")
                XtraMessageBox.Show("Clinic successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub
 
End Class