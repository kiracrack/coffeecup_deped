Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPayrollAutoAddAllowances
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
        loadDeduction()
        LoadScheduleType()
        RadioGroup1.SelectedIndex = 0
        If RadioGroup1.SelectedIndex = 0 Then
            loadEmployeeType()
        Else
            loadEmployeePosition()
        End If
        LoadData()
        LoadGridviewAppearance(Gridview1)
        LoadGridviewAppearance(gv_EmployeeType)
        LoadGridviewAppearance(gv_Deduction)
        LoadGridviewAppearance(gv_scheduletype)
    End Sub
    Public Sub LoadScheduleType()
        LoadXgridLookupEdit("select code, Description as 'Select' from tblpayrollschedule", "tblpayrollschedule", txtScheduleType, gv_scheduletype, Me)
        gv_scheduletype.Columns("code").Visible = False
    End Sub
    Private Sub txtPayoutSchedule_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScheduleType.EditValueChanged
        On Error Resume Next
        schedulecode.Text = txtScheduleType.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub loadDeduction()
        LoadXgridLookupEdit("select code, description as 'Select' from tblpayrolldedaddtype where deduction = 0", "tblpayrolldedaddtype", txtAdditional, gv_Deduction, Me)
        gv_Deduction.Columns("code").Visible = False
    End Sub
    Private Sub txtdedRange_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdditional.EditValueChanged
        On Error Resume Next
        dedaddcode.Text = txtAdditional.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub

    Public Sub loadEmployeeType()
        LoadXgridLookupEdit("select code, description as 'Select' from tblemployeetype order by description", "tblemployeetype", txtEmployeeType, gv_EmployeeType, Me)
        gv_EmployeeType.Columns("code").Visible = False
    End Sub
    Private Sub txtEmployeeType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeType.EditValueChanged
        On Error Resume Next
        employeetypecode.Text = txtEmployeeType.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub

    Public Sub loadEmployeePosition()
        LoadXgridLookupEdit("select code, description as 'Select' from tblpayrollbasicrate order by description", "tblpayrollbasicrate", txtEmployeeType, gv_EmployeeType, Me)
        gv_EmployeeType.Columns("code").Visible = False
    End Sub
    Private Sub txtPosition_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeType.EditValueChanged
        On Error Resume Next
        employeetypecode.Text = txtEmployeeType.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub LoadData()
        LoadXgrid("select id,case when autoaddtype = 0 then (select description from tblemployeetype where code = tblpayrollautoaddallowances.subjectto) else (select description from tblpayrollbasicrate where code = tblpayrollautoaddallowances.subjectto) end as 'Subject to', " _
                            + " (select description from tblpayrolldedaddtype where code =  tblpayrollautoaddallowances.addcode) as 'Additional Type', (select description from tblpayrollschedule where code=tblpayrollautoaddallowances.schedule) as 'Schedule' ,Amount, case when active =1 then 'Active' else 'Inactive' end as 'Status' from tblpayrollautoaddallowances where autoaddtype='" & RadioGroup1.SelectedIndex & "'", "tblpayrollautoaddallowances", Em, Gridview1, Me)
        Gridview1.Columns("id").Visible = False
        XgridColCurrency({"Amount"}, Gridview1)
        XgridColAlign({"Status"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles Gridview1.RowCellStyle
        Dim View As GridView = sender
        'e.Appearance.BackColor2 = Color.LightCyan
        If gen_filterappearance = True Then
            If e.Column.FieldName = "Status" Then
                Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
                If status = "Inactive" Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.ForeColor = Color.White
                End If
            End If
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If CheckSelectedRow("Subject to", Gridview1) = True Then
            If XtraMessageBox.Show("Are you sure you want to edit selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                mode.Text = "edit" : code.Text = Gridview1.GetFocusedRowCellValue("id").ToString
                LoadDetails(code.Text)
            End If
        End If
    End Sub
    Public Sub LoadDetails(ByVal id As String)
        If code.Text = "" Then Exit Sub
        com.CommandText = "select *,(select description from tblpayrolldedaddtype where code =  tblpayrollautoaddallowances.addcode) as 'additional', " _
                                + " (select description from tblpayrollschedule where code=tblpayrollautoaddallowances.schedule) as 'sched', " _
                                + " case when autoaddtype = 0 then (select description from tblemployeetype where code = tblpayrollautoaddallowances.subjectto) else (select description from tblpayrollbasicrate where code = tblpayrollautoaddallowances.subjectto) end  as 'subjecttodesc' from tblpayrollautoaddallowances where id='" & id & "'" : rst = com.ExecuteReader
        While rst.Read
            RadioGroup1.SelectedIndex = rst("autoaddtype").ToString
            txtEmployeeType.Text = rst("subjecttodesc").ToString
            employeetypecode.Text = rst("subjectto").ToString
            txtAdditional.Text = rst("additional").ToString
            schedulecode.Text = rst("schedule").ToString
            txtScheduleType.Text = rst("sched").ToString
            dedaddcode.Text = rst("addcode").ToString
            txtAmount.Text = rst("amount").ToString
        End While
        rst.Close()
    End Sub
    Public Sub ClearField()
        mode.Text = "" : code.Text = ""
        txtEmployeeType.Properties.DataSource = Nothing
        txtEmployeeType.Text = ""
        employeetypecode.Text = ""
        txtAdditional.Properties.DataSource = Nothing
        txtAdditional.Text = ""
        dedaddcode.Text = ""
        loadDeduction()
        loadEmployeeType()
        txtAmount.Text = "0.00"
    End Sub

    Private Sub cmdAttendanceSettings_Click(sender As Object, e As EventArgs) Handles cmdAttendanceSettings.Click
        If txtEmployeeType.Text = "" Then
            XtraMessageBox.Show("Please select employee type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmployeeType.Focus()
            Exit Sub
        ElseIf txtAdditional.Text = "" Then
            XtraMessageBox.Show("Please select additional type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAdditional.Focus()
            Exit Sub
        ElseIf txtScheduleType.Text = "" Then
            XtraMessageBox.Show("Please select schedule!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtScheduleType.Focus()
            Exit Sub
        ElseIf Val(CC(txtAmount.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter amount!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmount.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblpayrollautoaddallowances set autoaddtype = '" & RadioGroup1.SelectedIndex.ToString & "', " _
                                    + " subjectto='" & employeetypecode.Text & "', " _
                                    + " addcode='" & dedaddcode.Text & "', " _
                                    + " schedule = '" & schedulecode.Text & "', " _
                                    + " amount='" & Val(CC(txtAmount.Text)) & "' where id='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblpayrollautoaddallowances set autoaddtype = '" & RadioGroup1.SelectedIndex.ToString & "', " _
                                    + " subjectto='" & employeetypecode.Text & "', " _
                                    + " addcode='" & dedaddcode.Text & "', " _
                                    + " schedule = '" & schedulecode.Text & "', " _
                                    + " amount='" & Val(CC(txtAmount.Text)) & "'" : com.ExecuteNonQuery()
        End If

        ClearField() : LoadData() : txtEmployeeType.Focus()
        XtraMessageBox.Show("Auto add successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadData()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.SelectedIndex = 0 Then
            loadEmployeeType()
        Else
            loadEmployeePosition()
        End If
        lblsubject.Text = "Subject to (" & RadioGroup1.Text & ")"
        LoadData()
    End Sub
#Region "GRID SECURITY FILTER"

    Private Sub Em_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseDown
        MenuFilter()
    End Sub

    Private Sub Em_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseUp
        MenuFilter()
    End Sub

    Private Sub Em_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Em.Move
        MenuFilter()
    End Sub

    Public Sub MenuFilter()
        On Error Resume Next
        If Gridview1.GetFocusedRowCellValue("Status").ToString = "Active" Then
            cmdActiveInactive.Text = "Make Inactive"
        Else
            cmdActiveInactive.Text = "Make Active"
        End If
    End Sub

#End Region
    Private Sub ActiveInactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdActiveInactive.Click
        If CheckSelectedRow("Subject to", Gridview1) = True Then
            If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If Gridview1.GetFocusedRowCellValue("Status").ToString = "Active" Then
                    com.CommandText = "update tblpayrollautoaddallowances set active=0 where id='" & Gridview1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update tblpayrollautoaddallowances set active=1 where id='" & Gridview1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
                End If
                LoadData()
            End If
        End If
    End Sub
End Class