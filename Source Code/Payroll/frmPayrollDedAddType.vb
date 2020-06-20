Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPayrollDedAddType
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub frmShiftSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        ClearField()
        LoadData()
        LoadGridviewAppearance(Gridview1)
        If deduction.Text = "1" Then
            Me.Text = "Deduction Entries"
            lblTitle.Text = "Deduction Entries"
            lblDescription.Text = "Deduction Description"
        Else
            Me.Text = "Additional Entries"
            lblTitle.Text = "Additional Entries"
            lblDescription.Text = "Additional Description"
        End If
    End Sub
    Public Sub LoadData()
        If deduction.Text = "1" Then
            LoadXgrid("select Code, Description from tblpayrolldedaddtype where deduction=1 order by code asc", "tblpayrolldedaddtype", Em, Gridview1, Me)
        Else
            LoadXgrid("select Code, Description from tblpayrolldedaddtype where deduction=0 order by code asc", "tblpayrolldedaddtype", Em, Gridview1, Me)
        End If
        Gridview1.Columns("Code").Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If CheckSelectedRow("Description", Gridview1) = True Then
            mode.Text = "edit" : code.Text = Gridview1.GetFocusedRowCellValue("Code").ToString
            LoadDetails(code.Text)
        End If
    End Sub
    Public Sub LoadDetails(ByVal id As String)
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblpayrolldedaddtype where code='" & id & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
        End While
        rst.Close()
    End Sub
    Public Sub ClearField()
        mode.Text = "" : code.Text = ""
        txtDescription.Text = ""
    End Sub

    Private Sub submitData()
        If txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            If deduction.Text = "1" Then
                com.CommandText = "update tblpayrolldedaddtype set description='" & rchar(txtDescription.Text) & "',deduction=1 where code='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblpayrolldedaddtype set description='" & rchar(txtDescription.Text) & "',deduction=0 where code='" & code.Text & "'" : com.ExecuteNonQuery()
            End If
        Else
            If deduction.Text = "1" Then
                com.CommandText = "insert into tblpayrolldedaddtype set description='" & rchar(txtDescription.Text) & "',deduction=1 " : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblpayrolldedaddtype set description='" & rchar(txtDescription.Text) & "',deduction=0 " : com.ExecuteNonQuery()
            End If
        End If
        ClearField() : LoadData()
        '   XtraMessageBox.Show(lblDescription.Text & " successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadData()
    End Sub

    Private Sub txtDescription_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescription.EditValueChanged

    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If e.KeyChar() = Chr(13) Then
            submitData()
        End If
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE FROM tblpayrolldedaddtype where code='" & Gridview1.GetFocusedRowCellValue("Code").ToString & "'" : com.ExecuteNonQuery()
            LoadData()
        End If
    End Sub
End Class