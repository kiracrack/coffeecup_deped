Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils

Public Class frmTransactionCode
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmGLGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        ClearFields()
        filter()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
    End Sub
    Public Sub ClearFields()
        code.Text = getcodeid("itemcode", "tbltransactioncode", "10001")
        mode.Text = ""
    End Sub
     
    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tbltransactioncode where itemcode='" & code.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtItemName.Text = rst("itemname").ToString
        End While
        rst.Close()
        If mode.Text = "edit" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Public Sub filter()
        LoadXgrid("Select itemcode as 'Code' ,itemname as 'Transaction Name' from tbltransactioncode", "tbltransactioncode", Em, GridView1, Me)
        GridView1.BestFitColumns()
        XgridColAlign({"Code"}, GridView1, HorzAlignment.Center)
        XgridColWidth({"Code"}, GridView1, 70)
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please provide Item Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub
        ElseIf txtItemName.Text = "" Then
            XtraMessageBox.Show("Please provide transaction item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItemName.Focus()
            Exit Sub
 
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tbltransactioncode set itemname='" & rchar(txtItemName.Text) & "'  where itemcode='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tbltransactioncode set itemcode='" & code.Text & "', itemname='" & rchar(txtItemName.Text) & "' " : com.ExecuteNonQuery()
        End If
        txtItemName.Text = "" : ClearFields() : filter()
        XtraMessageBox.Show("TRansaction code successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        mode.Text = "edit"
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to Continue? there's is no undo function once the code is deleted? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tbltransactioncode where itemcode='" & GridView1.GetFocusedRowCellValue("Code").ToString & "'" : com.ExecuteNonQuery()
            filter() : ClearFields()
            XtraMessageBox.Show("Code successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frmTransactionCodeFilter.ShowDialog(Me)
    End Sub
End Class