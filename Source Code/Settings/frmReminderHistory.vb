Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Skins

Public Class frmReminderHistory
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
        LoadGridviewAppearance(GridView1)
        txtMessage.Focus()
        filterchatbox()
        ShowReminder()
    End Sub
    Public Sub ShowReminder()
        com.CommandText = "select * from tblreminders where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtTitle.Text = rst("title").ToString
            txtContent.Text = rst("details").ToString
            txtDateFollowup.Text = rst("followupdate").ToString
        End While
        rst.Close()
    End Sub
    Public Sub filterchatbox()
        LoadXgrid("Select Remarks, lcase(postedby) as 'Posted By',  date_format(dateposted,'%Y-%m-%d') as 'Date Posted'  from tblreminderslogs where reminderscode='" & code.Text & "'" _
                           + " order by dateposted asc", "tblreminderslogs", Em, GridView1, Me)

        GridView1.MoveLast()
    End Sub
     
    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        cmdaction.Enabled = False
        cmdaction.Text = "Posting"
        RemoveSpecialChar(PanelControl1)
        connectChat()
    End Sub

   
    Public Sub connectChat()
        Try
            RemoveSpecialChar(PanelControl1)
            com.CommandText = "insert into tblreminderslogs set reminderscode='" & code.Text & "', remarks='" & rchar(txtMessage.Text) & "', dateposted=current_timestamp, postedby='" & globalfullname & "'" : com.ExecuteNonQuery()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdaction.Enabled = True
            cmdaction.Text = "Post"
            Exit Sub
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdaction.Enabled = True
            cmdaction.Text = "Post"
            Exit Sub
        End Try
        txtMessage.Text = ""
        filterchatbox()
        cmdaction.Enabled = True
        cmdaction.Text = "Post"
        txtMessage.Focus()
    End Sub

    Private Sub txtMessage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessage.EditValueChanged
        If txtMessage.Text <> "" Then
            cmdaction.Enabled = True
        Else
            cmdaction.Enabled = False
        End If
    End Sub

End Class