Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins

Public Class frmCardPaymentType
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Public Sub filter()
        LoadXgrid("Select bankcode, bankname as 'Card Type' from tblsalescardtype order by bankname asc ", "tblsalescardtype", Em, GridView1, Me)
        GridView1.BestFitColumns()
        XgridHideColumn({"bankcode"}, GridView1)

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtBankName.Text = "" Then
            XtraMessageBox.Show("Please provide Card Type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBankName.Focus()
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            com.CommandText = "insert into tblsalescardtype set bankname='" & rchar(txtBankName.Text) & "'" : com.ExecuteNonQuery()

        Else
            com.CommandText = "update tblsalescardtype set bankname='" & rchar(txtBankName.Text) & "' where bankcode='" & id.Text & "'" : com.ExecuteNonQuery()
        End If
        txtBankName.Text = "" : txtBankName.Focus()
        filter()
        XtraMessageBox.Show("Bank Account successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblsalescardtype where bankcode='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtBankName.Text = rst("bankname").ToString
        End While
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("bankcode").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("bankcode").ToString
        mode.Text = "edit"
    End Sub

 
    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
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
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub
 
End Class