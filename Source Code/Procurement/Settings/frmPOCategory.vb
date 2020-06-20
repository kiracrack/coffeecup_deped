Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmPOCategory
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
        filter()
        Em.ForceInitialize()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdTabSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdsave.Enabled = True
        Else
            cmdTabSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdsave.Enabled = False
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

    Public Sub filter()
        LoadXgrid("Select POTypeID as 'Code', Description,case when enablepo=1 then 'Yes' else 'No' end as 'Enable PO' from tblrequesttype", "tblrequesttype", Em, GridView1, Me)
        XgridColAlign({"Code", "Enable PO"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Code").Width = 70
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click, cmdTabSave.ItemClick
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please provide description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If

        If mode.Text <> "edit" Then
            If countqry("tblrequesttype", "POTYPEID='" & id.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate category ID Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                id.Focus()
                Exit Sub
            End If

            com.CommandText = "insert into tblrequesttype set POTYPEID='" & id.Text & "', DESCRIPTION='" & txtdesc.Text & "',enablepo=" & ckenablePO.CheckState & "" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblrequesttype set DESCRIPTION='" & txtdesc.Text & "',enablepo=" & ckenablePO.CheckState & "  where POTYPEID='" & id.Text & "'" : com.ExecuteNonQuery()
        End If
        clearfields()
        filter()
        XtraMessageBox.Show("Category successfully save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = getPOcatid()
        txtdesc.Text = ""
        mode.Text = ""
        If mode.Text = "edit" Then
            cmdTabSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdsave.Enabled = True
        Else
            cmdTabSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdsave.Enabled = False
        End If
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblrequesttype where POTYPEID='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("description").ToString
            ckenablePO.Checked = rst("enablepo")
        End While
        rst.Close()
        If mode.Text = "edit" Then
            cmdTabSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdsave.Enabled = True
        Else
            cmdTabSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdsave.Enabled = False
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            mode.Text = ""
            id.Text = GridView1.GetFocusedRowCellValue("Code").ToString
            mode.Text = "edit"
            SplitContainerControl1.Collapsed = False
        End If
    End Sub

    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                DeleteRow("Code", "POTYPEID", "tblrequesttype", GridView1, Me)
            End If
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        clearfields()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

End Class