Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmComunicationBox
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmForApprovalList_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(Grid_chat)
        LoadGridviewAppearance(grid_latest)
        LoadGridviewAppearance(grid_attachment)
        filterchatbox()
        filterNotifbox()
        filterAttachmentBox()
        'Grid_chat.RowHeight = 15
        'Grid_chat.ColumnPanelRowHeight = 24
        'Grid_chat.BorderStyle = BorderStyles.Default
        'Grid_chat.OptionsBehavior.Editable = False
        'Grid_chat.OptionsBehavior.[ReadOnly] = True

        'Grid_chat.OptionsSelection.EnableAppearanceFocusedCell = False

        'Grid_chat.OptionsView.ShowGroupPanel = False
        'Grid_chat.OptionsView.ShowAutoFilterRow = False
        'Grid_chat.OptionsView.ShowIndicator = False

        'Grid_chat.OptionsView.ShowHorizontalLines = True
        'Grid_chat.OptionsView.ShowViewCaption = False

        'grid_latest.RowHeight = 15
        'grid_latest.ColumnPanelRowHeight = 24
        'grid_latest.BorderStyle = BorderStyles.Default
        'grid_latest.OptionsBehavior.Editable = False
        'grid_latest.OptionsBehavior.[ReadOnly] = True

        'grid_latest.OptionsSelection.EnableAppearanceFocusedCell = False

        'grid_latest.OptionsView.ShowGroupPanel = False
        'grid_latest.OptionsView.ShowAutoFilterRow = False
        'grid_latest.OptionsView.ShowIndicator = False

        'grid_latest.OptionsView.ShowHorizontalLines = True
        'grid_latest.OptionsView.ShowViewCaption = False

        filter()
        txtMessage.Focus()
    

    End Sub
    Public Sub filterchatbox()
        If officeid.Text = "" Then Exit Sub
        LoadXgrid("select forsync,concat(n_datetime,' - ',(select lcase(officename) from tblcompoffice where officeid = tblnotifylist.officeid),'\n', 'Sender : ',(select lcase(fullname) from tblaccounts where accountid = tblnotifylist.n_by ),'\n', n_description,'\n') as 'n_description' from tblnotifylist where officeid='" & officeid.Text & "' order by n_datetime asc;", "tblnotifylist", Em_chat, Grid_chat, Me)
        Grid_chat.BestFitColumns()
        Grid_chat.Columns("forsync").Visible = False
        Grid_chat.Columns("n_description").ColumnEdit = MemoEdit
        Grid_chat.MoveLast()
    End Sub
    Public Sub filterNotifbox()
        LoadXgrid("select concat(n_datetime,' - ',(select lcase(officename) from tblcompoffice where officeid = tblnotifylist.officeid),'\n', 'Sender : ',(select lcase(fullname) from tblaccounts where accountid = tblnotifylist.n_by ),'\n', n_description,'\n') as 'n_description' from tblnotifylist order by n_datetime asc;", "tblnotifylist", em_latest, grid_latest, Me)
        grid_latest.BestFitColumns()
        'grid_latest.Columns("n_datetime").Width = 150
        grid_latest.Columns("n_description").ColumnEdit = MemoEdit
        grid_latest.MoveLast()
    End Sub

    Public Sub filterAttachmentBox()
        LoadXgrid("select reference, concat(n_datetime,' - ',(select lcase(officename) from tblcompoffice where officeid = tblnotifylist.officeid),'\n','Request #: ', reference,'\n', 'Sender : ', (select lcase(fullname) from tblaccounts where accountid = tblnotifylist.n_by ),'\n', n_description,'\n') as 'n_description' from tblnotifylist where n_type='att_type_or' order by n_datetime asc;", "tblnotifylist", Em_attachment, grid_attachment, Me)
        grid_attachment.BestFitColumns()
        grid_attachment.Columns("reference").Visible = False
        grid_attachment.Columns("n_description").ColumnEdit = MemoEdit
        grid_attachment.MoveLast()
    End Sub

    Public Sub filter()
        LoadXgrid("Select officeid, officename as '" & GlobalOfficeCaption & "',cast((select if(count(*)=0,'',count(*)) from tblnotifylist where officeid = tblcompoffice.officeid and isread=1) as char(100)) as 'read' from tblcompoffice order by officename asc", "tblcompoffice", Em, GridView1, Me)
        GridView1.Columns("officeid").Visible = False
        GridView1.Columns("read").Width = 70
        XgridColAlign({"read"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal senders As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = senders
        Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("read"))
        If Val(status) > 0 Then
            e.Appearance.BackColor = Color.Yellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font("Tahoma", 8.25)
        End If
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        Dim I As Integer = 0
        For I = 0 To GridView1.SelectedRowsCount - 1
            'Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
            com.CommandText = "insert into tblnotifylist set officeid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "officeid") & "', reference='" & globaluserid & "', n_title='New Message', n_description='" & txtMessage.Text & "',n_type='chat', n_by='" & globaluserid & "',n_datetime=current_timestamp"
            com.ExecuteNonQuery()
        Next
        txtMessage.Text = ""
        txtMessage.Focus()
        filterchatbox()
        cmdaction.Enabled = True
        cmdaction.Text = "Send"
    End Sub

    Private Sub txtMessage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessage.EditValueChanged
        If txtMessage.Text <> "" Then
            cmdaction.Enabled = True
        Else
            cmdaction.Enabled = False
        End If
    End Sub

    Private Sub GridView1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.GotFocus
        On Error Resume Next
        DisplayItemsInfo(GridView1.GetFocusedRowCellValue("officeid").ToString())
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        On Error Resume Next
        DisplayItemsInfo(GridView1.GetFocusedRowCellValue("officeid").ToString())
    End Sub
    Private Sub GridView1_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        On Error Resume Next
        DisplayItemsInfo(GridView1.GetFocusedRowCellValue("officeid").ToString())
    End Sub
    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        On Error Resume Next
        DisplayItemsInfo(GridView1.GetFocusedRowCellValue("officeid").ToString())
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        On Error Resume Next
        DisplayItemsInfo(GridView1.GetFocusedRowCellValue("officeid").ToString())
    End Sub
    Public Function DisplayItemsInfo(ByVal id As String)
        officeid.Text = id
        filterchatbox()
        XtraTabControl1.SelectedTabPage = tabChatbox
        com.CommandText = "update tblnotifylist set isread=0 where officeid='" & officeid.Text & "'" : com.ExecuteNonQuery()
        Return 0
    End Function

    Private Sub txtMessage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMessage.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtMessage.Text <> "" Then
                cmdaction.PerformClick()
            End If
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanging(sender As Object, e As XtraTab.TabPageChangingEventArgs) Handles XtraTabControl1.SelectedPageChanging
        'If XtraTabControl1.SelectedTabPage Is tabChatbox Then
        '    filterchatbox()
        'ElseIf XtraTabControl1.SelectedTabPage Is tabLatestNotification Then
        '    filterNotifbox()
        'End If
    End Sub

    
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterchatbox()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        filterNotifbox()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        filterAttachmentBox()
    End Sub

    Private Sub ViewAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAttachmentToolStripMenuItem.Click
        If countqry("tblblobattachment", "refnumber='" & grid_attachment.GetFocusedRowCellValue("reference").ToString & "'") = 0 Then
            XtraMessageBox.Show("There's no attachment to view", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ViewAttachmentPackage_Database({grid_attachment.GetFocusedRowCellValue("reference").ToString}, "")
    End Sub

   
End Class