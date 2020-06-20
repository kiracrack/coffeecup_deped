Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.Security
Imports System.IO

Public Class frmDBFileUploader
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyDataGridView.RowCount = 0 Then
            MsgBox("Please select file to attached", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MyDataGridView.RowCount > 0 Then
            For I = 0 To MyDataGridView.RowCount - 1
                If MyDataGridView.Rows(I).Cells("Error").Value() = "1" Then
                    MsgBox("Please check your selected file not more than " & FormatNumber((GlobalAllowableAttachSize / 1024), 2) & " KB", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Next
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If MyDataGridView.RowCount > 0 Then
                For I = 0 To MyDataGridView.RowCount - 1
                    AddAttachmentPackage(trncode.Text, "default", {MyDataGridView.Rows(I).Cells("Location").Value()})
                Next
            End If
            MsgBox("Atachment successfully uploaded!", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        InitializeOpenFileDialog()
        MyDataGridView.Rows.Clear()
        MyDataGridView.ColumnCount = 5
        MyDataGridView.ColumnHeadersVisible = True

        MyDataGridView.Columns(0).Name = "File Name"
        MyDataGridView.Columns(1).Name = "File Sized"
        MyDataGridView.Columns(2).Name = "Location"
        MyDataGridView.Columns(3).Name = "Error"
        MyDataGridView.Columns(4).Name = "database"

        GridColumnAlignment(MyDataGridView, {"File Sized"}, DataGridViewContentAlignment.MiddleRight)
        GridHideColumn(MyDataGridView, {"Location", "Error", "database"})
        'showExistingFile()
    End Sub
    'Public Sub showExistingFile()
    '    MyDataGridView.Rows.Clear()
    '    com.CommandText = "select * from filedir.tblattachmentlogs where refnumber='" & trncode.Text & "'" : rst = com.ExecuteReader
    '    While rst.Read
    '        MyDataGridView.Rows.Add(rst("filename").ToString, FormatNumber((rst("filesize") / 1024), 2) & " KB", "", 0, rst("databasename").ToString)
    '    End While
    '    rst.Close()
    'End Sub
    'Public Sub DeleteFile()
    '    If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
    '            If rw.Cells("database").Value.ToString <> "" Then
    '                com.CommandText = "delete from filedir." & rw.Cells("database").Value.ToString & " where filename='" & rw.Cells("File Name").Value.ToString & "' and refnumber='" & trncode.Text & "'" : com.ExecuteNonQuery()
    '                com.CommandText = "delete from filedir.tblattachmentlogs where filename='" & rw.Cells("File Name").Value.ToString & "' and refnumber='" & trncode.Text & "'" : com.ExecuteNonQuery()
    '            Else

    '            End If
    '        Next
    '    End If
    'End Sub
    'Public Sub LoadCategory()
    '    msda = New MySqlDataAdapter("select id, Description from tblcategory order by description asc", conn)
    '    MyDataGridView.DataSource = Nothing : dst = New DataSet
    '    msda.Fill(dst, 0)
    '    MyDataGridView.DataSource = dst.Tables(0)
    '    MyDataGridView.Columns("id").Visible = False

    'End Sub

    'Private Sub DeleteCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCategoryToolStripMenuItem.Click
    '    If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
    '        com.CommandText = "delete from tblcategory where id='" & MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
    '        LoadCategory()
    '        MsgBox("Category successfully deleted!", MsgBoxStyle.Information)
    '    End If
    'End Sub

    Public Sub InitializeOpenFileDialog()
        ' Set the file dialog to filter for graphics files. 
        Me.OpenFileDialog1.Filter = _
                "All files (*.*)|*.*"

        ' Allow the user to select multiple images. 
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "My Image Browser"
    End Sub


    Private Sub cmdBrowseFile_Click(sender As Object, e As EventArgs) Handles cmdBrowseFile.Click
        Dim FileSize As UInt32 : Dim rawData() As Byte : Dim fs As FileStream

        Dim dr As DialogResult = Me.OpenFileDialog1.ShowDialog()
        If (dr = System.Windows.Forms.DialogResult.OK) Then
            ' Read the files 
            Dim file As String
            For Each file In OpenFileDialog1.FileNames
                : rawData = Nothing : FileSize = Nothing
                fs = New FileStream(file, FileMode.Open, FileAccess.Read)
                FileSize = fs.Length

                Try
                    MyDataGridView.Rows.Add(System.IO.Path.GetFileNameWithoutExtension(file), FormatNumber((FileSize / 1024), 2) & " KB", file, If(checkAttachment(file) = False, 1, 0), "")
                Catch SecEx As SecurityException
                    ' The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" & _
                        "Error message: " & SecEx.Message & "\n\n" & _
                        "Details (send to Support):\n\n" & SecEx.StackTrace)
                Catch ex As Exception
                    ' Could not load the image - probably permissions-related.
                    MessageBox.Show(("Cannot display the image: " & file.Substring(file.LastIndexOf("\"c)) & _
                    ". You may not have permission to read the file, or " + "it may be corrupt." _
                    & ControlChars.Lf & ControlChars.Lf & "Reported error: " & ex.Message))
                End Try
            Next file
            GridColumnAlignment(MyDataGridView, {"File Sized"}, DataGridViewContentAlignment.MiddleRight)
            GridHideColumn(MyDataGridView, {"Location", "Error"})
            If MyDataGridView.RowCount > 0 Then
                For i = 0 To MyDataGridView.RowCount - 1
                    If MyDataGridView.Rows(i).Cells("Error").Value() = "1" Then
                        MyDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
                        MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                Next
            End If
        End If
    End Sub

End Class
