Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmFFETypeManagement
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
        LoadGridviewAppearance(gridcategory)
        clearfields()
        filter()
        LoadCategory()
        VerifyPermission()
    End Sub

    Public Sub filter()
        LoadXgrid("Select code, Description,if((select count(*) from tblinventoryffesetup where ffetype=tblinventoryffetype.code)>0,'YES','-') as 'Configured' from tblinventoryffetype where catid='" & catid.Text & "'", "tblinventoryffetype", Em, GridView1, Me)
        GridView1.Columns("code").Visible = False
        GridView1.Columns("Description").Width = 300
        XgridColAlign({"Configured"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtCategory.Text = "" Then
            XtraMessageBox.Show("Please select category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCategory.Focus()
            Exit Sub
        ElseIf txtdesc.Text = "" Then
            XtraMessageBox.Show("Please enter description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        ElseIf countqry("tblinventoryffetype", "description='" & rchar(txtdesc.Text) & "' and catid='" & catid.Text & "' and code<>'" & id.Text & "'") > 0 Then
            XtraMessageBox.Show("Description is already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            com.CommandText = "insert into tblinventoryffetype set catid='" & catid.Text & "', description='" & rchar(txtdesc.Text) & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblinventoryffetype set catid='" & catid.Text & "', description='" & rchar(txtdesc.Text) & "' where code='" & id.Text & "' " : com.ExecuteNonQuery()
        End If
        clearfields()
        filter()
        VerifyPermission()
        XtraMessageBox.Show("FFE Type Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select *, (select description from tblprocategory where catid = tblinventoryffetype.catid) as 'category' from tblinventoryffetype where code='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("description").ToString
            txtCategory.Text = rst("category").ToString
            catid.Text = rst("catid").ToString
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
    Public Sub LoadCategory()
        LoadXgridLookupSearch("SELECT catid, Description from tblprocategory where ffe=1", "tblprocategory", txtCategory, gridcategory, Me)
        gridcategory.Columns("catid").Visible = False
    End Sub
    Private Sub txtCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategory.EditValueChanged
        On Error Resume Next
        catid.Text = txtCategory.Properties.View.GetFocusedRowCellValue("catid").ToString()
        filter()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If GridView1.GetFocusedRowCellValue("code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("code", "code", "tblinventoryffetype", GridView1, Me)
        End If
    End Sub

    Private Sub ConfigureRequiredInputsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigureRequiredInputsToolStripMenuItem.Click
        frmFFEFieldSetup.Text = GridView1.GetFocusedRowCellValue("Description").ToString
        frmFFEFieldSetup.ffetype.Text = GridView1.GetFocusedRowCellValue("code").ToString
        frmFFEFieldSetup.ShowDialog(Me)
    End Sub
End Class