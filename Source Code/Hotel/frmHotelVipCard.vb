Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmHotelVipCard
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
            code.Text = getcodeid("vipcode", "tblhotelviptype", "100")
        End If
    End Sub

    Public Sub LoadData()
        LoadXgrid("select vipcode as 'Code', Description,EnableLimit, creditlimit as 'Credit Limit' from tblhotelviptype", "tblhotelviptype", Em, GridView1, Me)

        GridView1.Columns("Code").Width = 80
        XgridColCurrency({"Credit Limit"}, GridView1)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        ' GridView1.SelectRow(1)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please Enter Vip Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        ElseIf Val(CC(txtCreditLimit.Text)) <= 0 And ckCreditLimit.Checked = True Then
            XtraMessageBox.Show("Please Enter Credit limit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCreditLimit.Focus()
            Exit Sub
        ElseIf countqry("tblhotelviptype", "vipcode='" & code.Text & "' ") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Vip Code already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf countqry("tblhotelviptype", "Description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Description already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblhotelviptype set Description='" & rchar(UCase(txtDescription.Text)) & "',enablelimit=" & ckCreditLimit.CheckState & ", creditlimit='" & Val(CC(txtCreditLimit.Text)) & "' where vipcode='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblhotelviptype set vipcode='" & code.Text & "', Description='" & rchar(UCase(txtDescription.Text)) & "', enablelimit=" & ckCreditLimit.CheckState & ", creditlimit='" & Val(CC(txtCreditLimit.Text)) & "'" : com.ExecuteNonQuery()
            End If

            LoadData()
            mode.Text = ""
            code.Text = getcodeid("vipcode", "tblhotelviptype", "100")
            XtraMessageBox.Show("VIP Type successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select * from tblhotelviptype where vipcode='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("Description").ToString
            ckCreditLimit.Checked = rst("enablelimit")
            txtCreditLimit.Text = rst("creditlimit").ToString
        End While
        rst.Close()
        mode.Text = "edit"

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tblhotelviptype where vipcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadData() : code.Text = getcodeid("vipcode", "tblhotelviptype", "100")
                XtraMessageBox.Show("Vip successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub ckCreditLimit_CheckedChanged(sender As Object, e As EventArgs) Handles ckCreditLimit.CheckedChanged
        If ckCreditLimit.Checked = True Then
            txtCreditLimit.Enabled = True
        Else
            txtCreditLimit.Enabled = False
            txtCreditLimit.Text = "0"
        End If
    End Sub
End Class