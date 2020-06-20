Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmSudgestionBox
    Public Sub Filter()
        LoadXgrid("Select id,refnumber, " & If(LCase(globaluser) = "root", "(select officename from tblcompoffice where officeid = tblsuggestionbox.officeid) as 'Office',", "") & If(LCase(globaluser) = "root", "(select fullname from tblaccounts where accountid = tblsuggestionbox.submitby) as 'Submit By',", "") & "  version as 'Version',systemname as 'System Type',date_format(datesubmitted,'%Y-%m-%d') as 'Date',Details, Resolved, (select if(count(*)>0, 'YES', 'NO') from filedir.tblattachmentlogs where refnumber = tblsuggestionbox.refnumber) as 'Attachment' from tblsuggestionbox " & If(LCase(globaluser) = "root", "", "where  submitby='" & globaluserid & "'") & " order by datesubmitted desc", "tblsuggestionbox", Em, GridView1, Me)
        XgridHideColumn({"id", "refnumber"}, GridView1)
        XgridColAlign({"Version", "Date", "Attachment"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub frmPrmtEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        txtVersion.Text = fversion
        Filter()
        If LCase(globaluser) = "root" Then
            cmdResolvedIssue.Visible = True
        Else
            cmdResolvedIssue.Visible = False
        End If
    End Sub

    Private Sub menu_Refresh_Click(sender As Object, e As EventArgs) Handles menu_Refresh.Click
        Filter()
    End Sub

    Private Sub txtAttachment1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtFilePath.ButtonClick
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = GlobalFiletypeSupport
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                'Read the contents of the file
                txtFilePath.Text = objOpenFileDialog.FileName
                If checkAttachment(txtFilePath.Text) = False Then
                    txtFilePath.BackColor = Color.Red
                Else
                    txtFilePath.BackColor = Color.White
                End If
            Catch fileException As Exception
                Throw fileException
            End Try
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If txtFeatures.Text = "" Then
            MessageBox.Show("Please enter your suggestion or error report!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFeatures.Focus()
            Exit Sub
        ElseIf checkAttachment(txtFilePath.Text) = False Then
            MessageBox.Show("Attached file is too large!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFilePath.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim refno As String = getGlobalTrnid(6, globaluserid)
            If txtFilePath.Text <> "" Then
                AddAttachmentPackage(refno, "suggestion-box", {txtFilePath.Text})
            End If

            com.CommandText = "insert into tblsuggestionbox set refnumber='" & refno & "', version='" & txtVersion.Text & "', systemname='" & txtSystemName.Text & "', datesubmitted=current_timestamp,officeid='" & globalofficeid & "', submitby='" & globaluserid & "', details='" & rchar(txtFeatures.Text) & "'" : com.ExecuteNonQuery()
            txtFeatures.Text = "" : Filter() : txtFilePath.Text = ""
            MessageBox.Show("Report successfully submitted!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ResolvedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdResolvedIssue.Click
        If XtraMessageBox.Show("Are you sure you want to resolved this issue? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblsuggestionbox set resolved=1 where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            Filter()
            MessageBox.Show("Issue successfully Resolved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ViewAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAttachmentToolStripMenuItem.Click
        If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Attachment").ToString = "NO" Then
            MessageBox.Show("No file attached!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Me.WindowState = FormWindowState.Minimized
        ViewAttachmentPackage_Database({GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "refnumber").ToString}, "suggestion-box")
    End Sub
End Class