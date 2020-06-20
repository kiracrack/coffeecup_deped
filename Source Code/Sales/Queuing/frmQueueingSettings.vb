Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins

Public Class frmQueueingSettings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Public Sub filter()
        LoadXgrid("Select queuecode,Icon, Description from tblsalesqueuingslip where groupcode='" & groupcode.Text & "' order by queuecode asc ", "tblsalesqueuingslip", Em, GridView_items, Me)
        GridView_items.BestFitColumns()
        XgridHideColumn({"queuecode"}, GridView_items)
        GridView_items.Columns("Icon").Width = 50
        GridView_items.Columns("Description").Width = 200

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtDescription.Text = "" Then
            XtraMessageBox.Show("Please provide description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            com.CommandText = "insert into tblsalesqueuingslip set groupcode='" & groupcode.Text & "',queuecode='" & id.Text & "', description='" & rchar(txtDescription.Text) & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblsalesqueuingslip set groupcode='" & groupcode.Text & "', description='" & rchar(txtDescription.Text) & "' where queuecode='" & id.Text & "'" : com.ExecuteNonQuery()
        End If
        UpdateIcon("queuecode='" & id.Text & "'", "icon", "tblsalesqueuingslip", System.Drawing.Imaging.ImageFormat.Png, picIcon, Me)
        txtDescription.Text = "" : txtDescription.Focus() : id.Text = getcodeid("queuecode", "tblsalesqueuingslip", "100") : mode.Text = ""
        filter()
        XtraMessageBox.Show("Item successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblsalesqueuingslip where queuecode='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
        End While
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView_items.GetFocusedRowCellValue("queuecode").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView_items.GetFocusedRowCellValue("queuecode").ToString
        mode.Text = "edit"
    End Sub


    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView_items)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(GridView2)

        LoadGridviewAppearance(GridGroup)

        com.CommandText = "select * from tblgeneralsettings where companycode='" & GlobalOrganizationCode & "'" : rst = com.ExecuteReader
        While rst.Read
            ckEnableFeatures.Checked = rst("enablequeuingslip")
            txtQueueType.Text = rst("queuingsliptype").ToString
            txtprocat.Text = rst("queuingproductcategory").ToString
        End While
        rst.Close()
        filter()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSave.Visible = True
        Else
            cmdSave.Visible = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
            Em.ContextMenuStrip = gridmenustrip
        Else
            cmdEdit.Visible = False
            Em.ContextMenuStrip = Nothing
        End If
        If mode.Text <> "edit" Then
            id.Text = getcodeid("queuecode", "tblsalesqueuingslip", "100")
        End If
        ShowUnfilteredClient()
        ShowfilteredClients()
        LoadQueueGroup()
    End Sub
 
    Public Sub LoadQueueGroup()
        LoadXgridLookupEdit("select groupcode,DESCRIPTION 'Select Group' from tblsalesqueuinggroup order by groupcode asc", "tblsalesqueuinggroup", txtQueueGroup, GridGroup, Me)
        GridGroup.Columns("groupcode").Visible = False
    End Sub

    Private Sub txtQueueGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQueueGroup.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtQueueGroup.Properties.View.FocusedRowHandle.ToString)
        groupcode.Text = txtQueueGroup.Properties.View.GetFocusedRowCellValue("groupcode").ToString()
        txtQueueGroup.Text = txtQueueGroup.Properties.View.GetFocusedRowCellValue("Select Group").ToString()
        filter()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub DeleteDeletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteDeletedToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE from tblsalesqueuingslip where queuecode='" & GridView_items.GetFocusedRowCellValue("queuecode").ToString & "'" : com.ExecuteNonQuery()
            filter()
        End If
    End Sub

    Private Sub ckEnableFeatures_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableFeatures.CheckedChanged
        If ckEnableFeatures.Checked = True Then
            txtQueueType.Enabled = True
            tabItems.PageEnabled = True
            tabFilters.PageEnabled = True
        Else
            txtQueueType.Enabled = False
            tabItems.PageEnabled = False
            tabFilters.PageEnabled = False
        End If
    End Sub

    Private Sub cmdSaveFeatures_Click(sender As Object, e As EventArgs) Handles cmdSaveFeatures.Click
        com.CommandText = "update tblgeneralsettings set enablequeuingslip=" & ckEnableFeatures.CheckState & ", queuingsliptype='" & rchar(txtQueueType.Text) & "', queuingproductcategory='" & txtprocat.Text & "' where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
        XtraMessageBox.Show("Features successfully saved", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

   
    Private Sub picIcon_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles picIcon.Validating
        ResizeImage(picIcon, 80, Me)
    End Sub

#Region "PERMISSION FILTER"
    Public Sub ShowUnfilteredClient()
        Dim cifquery As String = ""
        com.CommandText = "select permissioncode from tblsalesqueuingfilter" : rst = com.ExecuteReader
        While rst.Read
            cifquery = cifquery + "'" & rst("permissioncode").ToString & "',"
        End While
        rst.Close()
        If cifquery.Length > 0 Then
            cifquery = cifquery.Remove(cifquery.Length - 1, 1)
            cifquery = " where authCode not in(" & cifquery & ")"
        End If
        LoadXgrid("select authCode, authDescription as 'User Permission' from tbluserauthority " & cifquery & " order by authDescription asc", "tbluserauthority", Em_unfiltered, GridView1, Me)
        GridView1.Columns("authCode").Visible = False
    End Sub

    Public Sub ShowfilteredClients()
        LoadXgrid("select permissioncode, (select authDescription from tbluserauthority where authCode= tblsalesqueuingfilter.permissioncode) as 'User Permission',(select description from tblsalesqueuinggroup where groupcode=tblsalesqueuingfilter.groupcode) as `Group` from tblsalesqueuingfilter order by (select authDescription from tbluserauthority where authCode= tblsalesqueuingfilter.permissioncode)  asc", "tblsalesqueuingfilter", Em_filtered, GridView2, Me)
        GridView2.Columns("permissioncode").Visible = False
    End Sub


    Private Sub cmdMoveRight_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "insert into tblsalesqueuingfilter set permissioncode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "authCode").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub

    Private Sub cmdMoveLeft_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To GridView2.SelectedRowsCount - 1
            com.CommandText = "delete from tblsalesqueuingfilter where permissioncode='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "permissioncode").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredClient()
        ShowfilteredClients()

    End Sub


    Public Sub SetGroup(ByVal groupcodes As String, ByVal group As String)
        For I = 0 To GridView2.SelectedRowsCount - 1
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "Group", group)
            com.CommandText = "update tblsalesqueuingfilter set groupcode='" & groupcodes & "' where permissioncode='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "permissioncode").ToString & "'" : com.ExecuteNonQuery()
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        frmQueuingGroup.Show(Me)
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmSetQueueGroup.Show(Me)
    End Sub
#End Region

   
End Class