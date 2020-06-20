Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmColumnFilter
    Public xgrid As DevExpress.XtraGrid.Views.Grid.GridView
    Public xcmd As Windows.Forms.ToolStripMenuItem
    Public xfilterName As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMemberColumnChooser_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\_config")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\_config")
        End If
        Dim file_conn As String = Application.StartupPath.ToString & "\_config\" & xfilterName
        CheckedListBox1.Items.Clear()
        For Each strresult In txtColumn.Text.Split(New Char() {","c})
            CheckedListBox1.Items.Add(strresult)
        Next
        If System.IO.File.Exists(Application.StartupPath & "\_config\" & xfilterName) = True Then
            Dim sr As StreamReader = File.OpenText(file_conn)
            Try
                Dim columnChoosed As String = sr.ReadLine()
                Dim cnt As Integer = 0
                For Each strresult In DecryptTripleDES(columnChoosed).Split(New Char() {","c})
                    If strresult = 0 Then
                        CheckedListBox1.SetItemCheckState(cnt, CheckState.Checked)
                    End If
                    cnt = cnt + 1
                Next
                sr.Close()
            Catch errMS As Exception
                sr.Close()
            End Try
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If
    End Sub
    Public Function GetFilterInfo(ByVal optxgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal filterName As String)
        xgrid = optxgrid : xfilterName = filterName
        Return 0
    End Function
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdUpdate.Click
        If CheckedListBox1.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select atleast 1 column to continue save settings!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CheckedListBox1.Focus()
            Exit Sub
        End If

        Dim strCheckedItem As String = ""
        Dim detail As String = ""
        Dim detailsFile As StreamWriter = Nothing
        Dim I As Integer = 0
        For I = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(I) = True Then
                strCheckedItem += 0 & ","
            Else
                strCheckedItem += 1 & ","
            End If

        Next
        If System.IO.File.Exists(Application.StartupPath & "\_config\" & xfilterName) = True Then
            System.IO.File.Delete(Application.StartupPath & "\_config\" & xfilterName)
        End If
        detailsFile = New StreamWriter(Application.StartupPath & "\_config\" & xfilterName, True)

        detail = strCheckedItem.Remove(strCheckedItem.Count - 1, 1)
        detailsFile.WriteLine(EncryptTripleDES(detail))
        detailsFile.Close()
        SaveFilterColumn(xgrid, xfilterName)
        XtraMessageBox.Show("Selected column successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For I = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemCheckState(I, CheckState.Checked)
            Next
        Else
            For I = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemCheckState(I, CheckState.Unchecked)
            Next
        End If
       
    End Sub
End Class