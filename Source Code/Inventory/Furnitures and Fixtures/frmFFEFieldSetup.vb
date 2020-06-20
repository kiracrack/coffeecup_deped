Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmFFEFieldSetup
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
        clearfields()
        filterSetup()
        VerifyPermission()
    End Sub

    Public Sub filterSetup()
        LoadXgrid("Select id, sortorder as 'Order', Description, Required from tblinventoryffesetup where ffetype='" & ffetype.Text & "' order by sortorder asc", "tblinventoryffesetup", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        GridView1.Columns("Description").Width = 300
        XgridColAlign({"Order"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtOrder.Text = "" Then
            XtraMessageBox.Show("Please enter sort order!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOrder.Focus()
            Exit Sub
        ElseIf txtdesc.Text = "" Then
            XtraMessageBox.Show("Please enter Column Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        ElseIf countqry("tblinventoryffesetup", "description='" & rchar(txtdesc.Text) & "' and ffetype='" & ffetype.Text & "' and id<>'" & id.Text & "'") > 0 Then
            XtraMessageBox.Show("Description is already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If
        If countqry("tblinventoryffedetails", "ffetype='" & ffetype.Text & "'") > 0 Then
            If XtraMessageBox.Show("Editing this entries will system automatically marked as flaged to all assets are linked to this assets type!" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                If mode.Text <> "edit" Then
                    com.CommandText = "insert into tblinventoryffesetup set ffetype='" & ffetype.Text & "', sortorder='" & txtOrder.Text & "',fieldname='" & rchar(LCase(txtdesc.Text.Replace(" ", "-"))) & "', description='" & rchar(txtdesc.Text) & "', required=" & CheckEdit1.CheckState & "" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update tblinventoryffesetup set ffetype='" & ffetype.Text & "', sortorder='" & txtOrder.Text & "', description='" & rchar(txtdesc.Text) & "', required=" & CheckEdit1.CheckState & " where id='" & id.Text & "' " : com.ExecuteNonQuery()
                End If
                ' com.CommandText = "UPDATE tblinventoryffe set flaged=1,flagedreason='Assets details has changed by " & StrConv(globalfullname, VbStrConv.ProperCase) & "' where ffetype='" & ffetype.Text & "'" : com.ExecuteNonQuery()
                clearfields()
                filterSetup()
                VerifyPermission()
                XtraMessageBox.Show("Setup Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If mode.Text <> "edit" Then
                com.CommandText = "insert into tblinventoryffesetup set ffetype='" & ffetype.Text & "', sortorder='" & txtOrder.Text & "',fieldname='" & rchar(LCase(txtdesc.Text.Replace(" ", "-"))) & "', description='" & rchar(txtdesc.Text) & "', required=" & CheckEdit1.CheckState & "" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblinventoryffesetup set ffetype='" & ffetype.Text & "', sortorder='" & txtOrder.Text & "', description='" & rchar(txtdesc.Text) & "', required=" & CheckEdit1.CheckState & " where id='" & id.Text & "' " : com.ExecuteNonQuery()
            End If
            clearfields()
            filterSetup()
            VerifyPermission()
            XtraMessageBox.Show("Setup Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub clearfields()
        txtdesc.Text = ""
        If mode.Text = "edit" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
        mode.Text = ""
        id.Text = ""
        txtOrder.Text = Val(countqry("tblinventoryffesetup", "ffetype='" & ffetype.Text & "'")) + 1
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblinventoryffesetup where id='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtOrder.Text = rst("sortorder").ToString
            txtdesc.Text = rst("description").ToString
            ffetype.Text = rst("ffetype").ToString
            CheckEdit1.Checked = rst("required")
        End While
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        mode.Text = "edit"
        SplitContainerControl1.Collapsed = False
        If mode.Text = "edit" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
    End Sub


    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Public Sub VerifyPermission()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Visible = True
        Else
            cmdRemove.Visible = False
        End If
        If globalAllowEdit = True Or globalAllowDelete = True Or LCase(globaluser) = "root" Then
            Em.ContextMenuStrip = gridmenustrip
        Else
            Em.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filterSetup()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("id", "id", "tblinventoryffesetup", GridView1, Me)
        End If
    End Sub

    Private Sub ReOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReOrderToolStripMenuItem.Click
        For I = 0 To GridView1.RowCount - 1
            com.CommandText = "Update tblinventoryffesetup set sortorder=" & I + 1 & " where id='" & GridView1.GetRowCellValue(I, "id").ToString & "'" : com.ExecuteNonQuery()
        Next
        filterSetup()
    End Sub
End Class