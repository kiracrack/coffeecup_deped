Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmStockHouse
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
    
    Public Sub filter()
        LoadXgrid("Select stockhouseid, stockhousename as 'Stock House', (select officename from tblcompoffice where officeid = tblstockhouse.officeid) as '" & GlobalOfficeCaption & "' from tblstockhouse", "tblstockhouse", Em, GridView1, Me)
        GridView1.Columns("stockhouseid").Visible = False
        GridView1.Columns(GlobalOfficeCaption).Group()
        GridView1.ExpandAllGroups()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please provide stock house name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        ElseIf txtInventory.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtInventory.Focus()
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            If countqry("tblstockhouse", "stockhouseid='" & id.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate Stock House ID Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                id.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblstockhouse set stockhouseid='" & id.Text & "', stockhousename='" & txtdesc.Text & "',officeid='" & officeid.Text & "' "
            com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblstockhouse set stockhousename='" & txtdesc.Text & "',officeid='" & officeid.Text & "' where stockhouseid='" & id.Text & "' "
            com.ExecuteNonQuery()
        End If
        clearfields()
        filter()
        VerifyPermission()
        XtraMessageBox.Show("Stock House Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = getStockhouseid()
        txtdesc.Text = ""
        If mode.Text = "edit" Then
            txtInventory.Properties.DataSource = Nothing
            txtInventory.Text = ""
            officeid.Text = ""
        End If
        mode.Text = ""
        If mode.Text = "edit" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select *,(select officename from tblcompoffice where officeid = tblstockhouse.officeid) as '" & GlobalOfficeCaption & "' from tblstockhouse where stockhouseid='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("stockhousename").ToString
            txtInventory.Text = rst(GlobalOfficeCaption).ToString
            officeid.Text = rst("officeid").ToString
        End While
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("stockhouseid") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("stockhouseid").ToString
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

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gv_inventory)
        clearfields()
        filter()
        loadInventoryTo()
        lbloffice.Text = "Select " & GlobalOfficeCaption
        VerifyPermission()
    End Sub
    Public Sub VerifyPermission()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
         If globalAllowEdit = True  Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
         If globalAllowDelete = True  Or LCase(globaluser) = "root" Then
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
    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as '" & GlobalOfficeCaption & "' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
        Me.txtInventory.Properties.DisplayMember = GlobalOfficeCaption
        Me.txtInventory.Properties.ValueMember = GlobalOfficeCaption
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If GridView1.GetFocusedRowCellValue("stockhouseid") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("stockhouseid", "stockhouseid", "tblstockhouse", GridView1, Me)
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCancel.ItemClick
        clearfields()
    End Sub
End Class