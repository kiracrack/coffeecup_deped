Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPayrollDeductionRange
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
        loadDeductionRange()
        LoadGridviewAppearance(Gridview1)
        LoadGridviewAppearance(gv_DeductionRange)
    End Sub

    Public Sub loadDeductionRange()
        LoadXgridLookupEdit("select code, description as 'Select' from tblpayrolldedaddtype inner join tblpayrollsettings " _
                                + " on (tblpayrolldedaddtype.code = tblpayrollsettings.defaultsss or tblpayrolldedaddtype.code = tblpayrollsettings.defaultpagibig  or tblpayrolldedaddtype.code = tblpayrollsettings.defaultphilhealth  or tblpayrolldedaddtype.code = tblpayrollsettings.defaultsavings)", "tblpayrolldedaddtype", txtdedRange, gv_DeductionRange, Me)
        gv_DeductionRange.Columns("code").Visible = False
    End Sub
    Private Sub txtdedRange_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdedRange.EditValueChanged
        On Error Resume Next
        dedaddcode.Text = txtdedRange.Properties.View.GetFocusedRowCellValue("code").ToString
        If dedaddcode.Text <> "" Then
            LoadData()
        End If
    End Sub
    Public Sub LoadData()
        LoadXgrid("select id,range_from as 'Range From',range_to as 'Range To', employee_share as 'Employee Share', employer_share as 'Employer Share' from tblpayrolldeductionrange where dedaddcode='" & dedaddcode.Text & "' order by range_to asc", "tblpayrolldeductionrange", Em, Gridview1, Me)
        Gridview1.Columns("id").Visible = False
        XgridColCurrency({"Range From", "Range To", "Employee Share", "Employer Share"}, Gridview1)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If CheckSelectedRow("Range From", Gridview1) = True Then
            If XtraMessageBox.Show("Are you sure you want to edit selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                mode.Text = "edit" : code.Text = Gridview1.GetFocusedRowCellValue("id").ToString
                LoadDetails(code.Text)
            End If
        End If
    End Sub
    Public Sub LoadDetails(ByVal id As String)
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblpayrolldeductionrange where id='" & id & "'" : rst = com.ExecuteReader
        While rst.Read
            txtRange_from.Text = rst("range_from").ToString
            txtRange_to.Text = rst("range_to").ToString
            txtemployeeShare.Text = rst("employee_share").ToString
            txtEmployerShare.Text = rst("employer_share").ToString
        End While
        rst.Close()
    End Sub
    Public Sub ClearField()
        mode.Text = "" : code.Text = ""
        txtRange_from.Text = "0.00"
        txtRange_to.Text = "0.00"
        txtemployeeShare.Text = "0.00"
        txtEmployerShare.Text = "0.00"
    End Sub

    Private Sub cmdAttendanceSettings_Click(sender As Object, e As EventArgs) Handles cmdAttendanceSettings.Click
        If txtdedRange.Text = "" Then
            XtraMessageBox.Show("Please select default deduction!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdedRange.Focus()
            Exit Sub
        ElseIf Val(CC(txtRange_from.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter range from value!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRange_from.Focus()
            Exit Sub
        ElseIf Val(CC(txtRange_to.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter range to value!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRange_to.Focus()
            Exit Sub
        ElseIf Val(CC(txtemployeeShare.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter employee share value!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtemployeeShare.Focus()
            Exit Sub
       
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblpayrolldeductionrange set dedaddcode='" & dedaddcode.Text & "', " _
                                + " range_from='" & CC(txtRange_from.Text) & "', " _
                                + " range_to='" & CC(txtRange_to.Text) & "', " _
                                + " employee_share='" & CC(txtemployeeShare.Text) & "', " _
                                + " employer_share='" & CC(txtEmployerShare.Text) & "' where id='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblpayrolldeductionrange set dedaddcode='" & dedaddcode.Text & "', " _
                                + " range_from='" & CC(txtRange_from.Text) & "', " _
                                + " range_to='" & CC(txtRange_to.Text) & "', " _
                                + " employee_share='" & CC(txtemployeeShare.Text) & "', " _
                                + " employer_share='" & CC(txtEmployerShare.Text) & "'" : com.ExecuteNonQuery()
        End If

        ClearField() : LoadData() : txtRange_from.Focus()
        XtraMessageBox.Show("Deduction range successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadData()
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE FROM tblpayrolldeductionrange where id='" & Gridview1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            LoadData()
        End If
    End Sub
End Class