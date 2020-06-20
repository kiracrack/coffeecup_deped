Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPayrollDepartments
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Control + Keys.W Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub frmPayrollDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadData()
        loadAssignedOffice()
        LoadGridviewAppearance(Gridview1)
        depid.Text = getcodeid("depid", "tblcompdepartments", "1000")
    End Sub
    Public Sub loadAssignedOffice()
        LoadXgridLookupSearch("select officeid as code, officename as 'Select' from tblcompoffice order by officename", "tblcompoffice", txtOffice, gv_assignoffice, Me)
        gv_assignoffice.Columns("code").Visible = False
    End Sub
    Private Sub txtAssignOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub LoadData()
        LoadXgrid("select  depid as 'Code', (select officename from tblcompoffice where officeid=tblcompdepartments.officeid) as 'Office', departmentname as 'Department Name' from tblcompdepartments order by code asc", "tblcompdepartments", Em, Gridview1, Me)
        XgridColAlign({"Code"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
        Gridview1.Columns("Office").Group()
        Gridview1.ExpandAllGroups()
        XgridColWidth({"Code"}, Gridview1, 100)
        XgridColWidth({"Department Name"}, Gridview1, 300)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE FROM tblcompdepartments where depid='" & Gridview1.GetFocusedRowCellValue("Code").ToString & "'" : com.ExecuteNonQuery()
            LoadData()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadData()
    End Sub

    Private Sub cmdSaveInfo_Click(sender As Object, e As EventArgs) Handles cmdSaveInfo.Click
        If txtOffice.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.Focus()
            Exit Sub
        ElseIf txtDepartmentName.Text = "" Then
            XtraMessageBox.Show("Please enter department name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDepartmentName.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblcompdepartments set officeid='" & officeid.Text & "', departmentname='" & rchar(txtDepartmentName.Text) & "' where depid='" & depid.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "INSERT INTO tblcompdepartments set depid='" & depid.Text & "', officeid='" & officeid.Text & "', departmentname='" & rchar(txtDepartmentName.Text) & "'" : com.ExecuteNonQuery()
        End If
        LoadData() : depid.Text = getcodeid("depid", "tblcompdepartments", "1000") : txtDepartmentName.Text = "" : txtDepartmentName.Focus()
        XtraMessageBox.Show("Record successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub LoadInfo()
        com.CommandText = "select *,(select officename from tblcompoffice where officeid=tblcompdepartments.officeid) as office from tblcompdepartments where depid='" & depid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            txtOffice.Text = rst("office").ToString
            txtDepartmentName.Text = rst("departmentname").ToString
        End While
        rst.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        mode.Text = "edit"
        depid.Text = Gridview1.GetFocusedRowCellValue("Code").ToString
        LoadInfo()
    End Sub
End Class