Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Skins

Public Class frmConversation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.Shift) + Keys.Enter Then
            Dim array As New ArrayList(txtMessage.Lines)
            txtMessage.Lines = CType(array.ToArray(GetType(String)), String())

        ElseIf keyData = Keys.Enter Then
            txtMessage.EnterMoveNextControl = True
            cmdaction.PerformClick()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmNotifyUpdates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        GridView1.RowHeight = 15
        GridView1.ColumnPanelRowHeight = 24
        GridView1.BorderStyle = BorderStyles.NoBorder
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsBehavior.[ReadOnly] = True

        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False

        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsView.ShowAutoFilterRow = False
        GridView1.OptionsView.ShowIndicator = False
        GridView1.OptionsView.EnableAppearanceEvenRow = True
        GridView1.OptionsView.EnableAppearanceOddRow = True
        'GridView1.OptionsView.ShowHorzLines = False
        GridView1.OptionsView.ShowVerticalLines = False
        GridView1.OptionsView.ShowViewCaption = False

        txtMessage.Focus()
        filterchatbox()
    End Sub

    Public Sub filterchatbox()
        LoadXgrid("select concat((select ifnull(nickname,fullname) from tblaccounts where accountid = tblsystemcontrol.userid),': ', Message), datesent as dt from tblsystemcontrol where  userid='" & globaluserid & "' union " _
                            + " select concat((select ifnull(nickname,fullname) from tblaccounts where accountid = tblsystemcontrol.actionby),': ', Message), datesent as dt from tblsystemcontrol  where  actionby='" & globaluserid & "' order by dt;", "tblsystemcontrol", Em, GridView1, Me)

        GridView1.Columns("dt").Visible = False
        GridView1.MoveLast()
    End Sub
    'Private Sub gridview1_RowCellStyle(ByVal senders As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
    '    Dim View As GridView = senders
    '    Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("isread"))
    '    If status = "1" Then
    '        e.Appearance.BackColor = Color.LightYellow
    '        e.Appearance.ForeColor = Color.Black
    '        e.Appearance.Font = New Font("Tahoma", 8.25)
    '    End If
    'End Sub
    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        cmdaction.Enabled = False
        cmdaction.Text = "Sending"
        RemoveSpecialChar(PanelControl1)
        timertransfer.Enabled = True
    End Sub

    Private Sub timertransfer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timertransfer.Tick
        timertransfer.Enabled = False
        connectChat()
    End Sub
    Public Sub connectChat()
        Try
            RemoveSpecialChar(PanelControl1)
            'com.CommandText = "insert into tblsystemcontrol set officeid='" & recipient.Text & "', reference='" & sender.Text & "', n_title='New Message', n_description='" & txtMessage.Text & "',n_type='chat', n_by='" & globaluserid & "',n_datetime=current_timestamp"
            com.ExecuteNonQuery()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdaction.Enabled = True
            cmdaction.Text = "Send"
            Exit Sub
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdaction.Enabled = True
            cmdaction.Text = "Send"
            Exit Sub
        End Try
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

End Class