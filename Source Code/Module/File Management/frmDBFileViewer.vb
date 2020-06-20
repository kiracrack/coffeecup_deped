Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.Security
Imports System.IO

Public Class frmDBFileViewer
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        MyDataGridView.Rows.Clear()
        MyDataGridView.ColumnCount = 4
        MyDataGridView.ColumnHeadersVisible = True

        MyDataGridView.Columns(0).Name = "File Name"
        MyDataGridView.Columns(1).Name = "File Sized"
        MyDataGridView.Columns(2).Name = "database"
        MyDataGridView.Columns(3).Name = "archivedname"

        GridColumnAlignment(MyDataGridView, {"File Sized"}, DataGridViewContentAlignment.MiddleRight)
        GridHideColumn(MyDataGridView, {"database", "archivedname"})
        showExistingFile()
    End Sub
    Public Sub showExistingFile()
        MyDataGridView.Rows.Clear()
        com.CommandText = "select * from filedir.tblattachmentlogs where refnumber='" & trncode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            MyDataGridView.Rows.Add(rst("filename").ToString, FormatNumber((rst("filesize") / 1024), 2) & " KB", rst("databasename").ToString, rst("archievedname").ToString)
        End While
        rst.Close()
    End Sub

    Private Sub DeleteCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCategoryToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                If rw.Cells("database").Value.ToString <> "" Then
                    com.CommandText = "delete from filedir." & rw.Cells("database").Value.ToString & " where filename='" & rw.Cells("File Name").Value.ToString & "' and refnumber='" & trncode.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "delete from filedir.tblattachmentlogs where filename='" & rw.Cells("File Name").Value.ToString & "' and refnumber='" & trncode.Text & "'" : com.ExecuteNonQuery()
                    DelFileFromZip(rw.Cells("database").Value.ToString.Replace("tbl", ""), rw.Cells("archivedname").Value.ToString)
                End If
            Next
            showExistingFile()
        End If
    End Sub
End Class
