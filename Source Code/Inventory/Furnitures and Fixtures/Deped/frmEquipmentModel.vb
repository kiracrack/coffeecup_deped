Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmEquipmentModel
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        filterSetup()
    End Sub

    Public Sub filterSetup()
        LoadXgrid("Select code, Description from tblofficeequipmentmodel where productid='" & productid.Text & "' order by description asc", "tblofficeequipmentmodel", Em, GridView1, Me)
        GridView1.Columns("code").Visible = False
        GridView1.Columns("Description").Width = 300
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please enter Model Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        ElseIf countqry("tblofficeequipmentmodel", "description='" & rchar(txtdesc.Text) & "' and productid='" & productid.Text & "' and code<>'" & id.Text & "'") > 0 Then
            XtraMessageBox.Show("Description is already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If

        If mode.Text <> "edit" Then
            com.CommandText = "insert into tblofficeequipmentmodel set productid='" & productid.Text & "', description='" & rchar(txtdesc.Text) & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblofficeequipmentmodel set productid='" & productid.Text & "', description='" & rchar(txtdesc.Text) & "' where code='" & id.Text & "' " : com.ExecuteNonQuery()
        End If
        filterSetup()
        txtdesc.Text = ""
        mode.Text = ""
        id.Text = ""
        txtdesc.Focus()
        XtraMessageBox.Show("Setup Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblofficeequipmentmodel where code='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("description").ToString
        End While
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("code").ToString
        mode.Text = "edit"
        SplitContainerControl1.Collapsed = False
        If mode.Text = "edit" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
    End Sub

     
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filterSetup()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If GridView1.GetFocusedRowCellValue("code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("code", "code", "tblofficeequipmentmodel", GridView1, Me)
        End If
    End Sub
End Class