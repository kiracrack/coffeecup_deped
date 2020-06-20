Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmCheckSettings
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
        ElseIf keyData = (Keys.Control) + Keys.P Then
            BarButtonItem2.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub filter()
        LoadXgrid("Select checkcode as 'Check Code', checkname as 'Check Name', numberofpages as 'No. of Pages', remainingpages as 'Remaining Pages' from tblpaymentcheck order by datesaved asc", "tblpaymentcheck", Em, GridView1, Me)
        GridView1.BestFitColumns()
        XgridColAlign({"Check Code", "No. of Pages", "Remaining Pages"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please provide check code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub
        ElseIf txtCheckName.Text = "" Then
            XtraMessageBox.Show("Please provide check name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckName.Focus()
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            If countqry("tblpaymentcheck", "checkcode='" & code.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate check code! Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                code.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblpaymentcheck set checkcode='" & code.Text & "', checkname='" & rchar(txtCheckName.Text) & "', numberofpages='" & Val(CC(txtNumberofPages.Text)) & "',remainingpages='" & Val(CC(txtNumberofPages.Text)) & "', datesaved=current_timestamp"
            com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblpaymentcheck set checkname='" & rchar(txtCheckName.Text) & "', numberofpages='" & Val(CC(txtNumberofPages.Text)) & "' where checkcode='" & code.Text & "'"
            com.ExecuteNonQuery()
        End If
        clearfields()
        filter()
        XtraMessageBox.Show("Check successfully save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub clearfields()
        code.Text = getcodeid("checkcode", "tblpaymentcheck", "100001")
        txtCheckName.Text = ""
        txtNumberofPages.Text = ""
        mode.Text = ""
        If mode.Text = "edit" Then
            code.Properties.ReadOnly = True
            txtNumberofPages.Properties.ReadOnly = True
        Else
            code.Properties.ReadOnly = False
            txtNumberofPages.Properties.ReadOnly = False
        End If
        If mode.Text = "edit" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblpaymentcheck where checkcode='" & code.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtCheckName.Text = rst("checkname").ToString
            txtNumberofPages.Text = rst("numberofpages").ToString
        End While
        rst.Close()

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Check Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Check Code").ToString
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
        clearfields()
        LoadGridviewAppearance(GridView1)
        filter()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
            Em.ContextMenuStrip = gridmenustrip
        Else
            cmdEdit.Visible = False
            Em.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub
 
End Class