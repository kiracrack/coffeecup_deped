Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPayrollAttendance
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub frmShiftSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        ClearField()
        LoadGridviewAppearance(Gridview1)
        shiftcode.Text = qrysingledata("shiftcode", "shiftcode", "where employeeid='" & employeeid.Text & "'", "tblemployees")
        Me.Text = qrysingledata("fullname", "fullname", "where employeeid='" & employeeid.Text & "'", "tblemployees")
        LoadData()
    End Sub
 
    Public Sub LoadData()
        If countqry("tblpayrollattendance", "payrollcode='" & payrollcode.Text & "' and employeeid='" & employeeid.Text & "' and approved=1") > 0 Then
            LoadXgrid("call sp_payrollcomputeattendance(FALSE,'" & payrollcode.Text & "','" & employeeid.Text & "')", "sp_payrollshowattendance(FALSE,'" & payrollcode.Text & "','" & employeeid.Text & "')", Em, Gridview1, Me)
        Else
            LoadXgrid("call sp_payrollcomputeattendance(TRUE,'" & payrollcode.Text & "','" & employeeid.Text & "')", "sp_payrollshowattendance(TRUE,'" & payrollcode.Text & "','" & employeeid.Text & "')", Em, Gridview1, Me)
        End If

        XgridHideColumn({"id"}, Gridview1)
        XgridColAlign({"AttendanceDate", "DayOfWeek", "ShiftSchedule", "MorningIn", "MorningOut", "NoonIn", "NoonOut", "OvertimeIn", "OvertimeOut", "RenderedHours", "Late", "Undertime", "Overtime"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"RenderedHours"}, Gridview1)
        XgridGeneralSummaryCurrency({"RenderedHours", "Late", "Undertime", "Overtime"}, Gridview1)
        XgriDisableColumn({"AttendanceDate", "DayOfWeek", "ShiftSchedule", "MorningIn", "MorningOut", "NoonIn", "NoonOut", "OvertimeIn", "OvertimeOut"}, Gridview1)
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles Gridview1.RowCellStyle
        Dim View As GridView = sender
        If View.GetRowCellDisplayText(e.RowHandle, View.Columns("Absent")).ToString = "Checked" Then
            e.Appearance.ForeColor = Color.Red
        End If
        If View.GetRowCellDisplayText(e.RowHandle, View.Columns("DayOfWeek")).ToString = "SUNDAY" Then
            e.Appearance.ForeColor = Color.Green
        End If
        If View.GetRowCellDisplayText(e.RowHandle, View.Columns("HalfDay")).ToString = "Checked" Then
            e.Appearance.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If CheckSelectedRow("AttendanceDate", Gridview1) = True Then
            If XtraMessageBox.Show("Are you sure you want to edit selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                mode.Text = "edit" : id.Text = Gridview1.GetFocusedRowCellValue("id").ToString
                EnableInputs()
                LoadDetails(id.Text)
            End If
        End If
    End Sub
    Public Sub LoadDetails(ByVal attid As String)
        If id.Text = "" Then Exit Sub
        com.CommandText = "select *,concat(date_format(attendancedate,'%M %d, %Y'),' ', DayOfWeek) as attdate from tblpayrollattendance where id='" & attid & "'" : rst = com.ExecuteReader
        While rst.Read
            txtAttendanceDate.Text = rst("attdate").ToString
            ckAbsent.Checked = rst("absent")
            ckHalfDay.Checked = rst("halfday")
            txt_first_in.EditValue = If(rst("1st_timein").ToString = "", "", rst("1st_timein"))
            txt_first_out.EditValue = If(rst("1st_timeout").ToString = "", "", rst("1st_timeout"))
            txt_second_in.EditValue = If(rst("2nd_timein").ToString = "", "", rst("2nd_timein"))
            txt_second_out.EditValue = If(rst("2nd_timeout").ToString = "", "", rst("2nd_timeout"))
            txt_third_in.EditValue = If(rst("3rd_timein").ToString = "", "", rst("3rd_timein"))
            txt_third_out.EditValue = If(rst("3rd_timeout").ToString = "", "", rst("3rd_timeout"))
            ckApproveOvertime.Checked = rst("overtimeapproved")
            txtRemarks.Text = rst("remarks").ToString
        End While
        rst.Close()
        If txt_first_in.Text = "" And txt_first_out.Text = "" And txt_second_in.Text = "" And txt_second_out.Text = "" Then
            com.CommandText = "select * from tblpayrollshiftsettings where shiftcode='" & shiftcode.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txt_first_in.EditValue = rst("def_1st_in")
                txt_first_out.EditValue = rst("def_1st_out")
                txt_second_in.EditValue = rst("def_2nd_in")
                txt_second_out.EditValue = rst("def_2nd_out")
            End While
            rst.Close()
        End If
        If txtAttendanceDate.Text = "" Then
            txtAttendanceDate.Properties.Appearance.BackColor = DefaultBackColor
        Else
            txtAttendanceDate.Properties.Appearance.BackColor = Color.Yellow
        End If
        If ckAbsent.Checked = True Then
            DisableInputs()
        Else
            EnableInputs()
        End If
    End Sub
    Public Sub ClearField()
        mode.Text = "" : id.Text = ""
        txtAttendanceDate.Text = ""
        If txtAttendanceDate.Text = "" Then
            txtAttendanceDate.Properties.Appearance.BackColor = DefaultBackColor
        Else
            txtAttendanceDate.Properties.Appearance.BackColor = Color.Yellow
        End If
        ckAbsent.Checked = False
        ckHalfDay.ReadOnly = False
        txt_first_in.EditValue = ""
        txt_first_out.EditValue = ""
        txt_second_in.EditValue = ""
        txt_second_out.EditValue = ""
        txt_third_in.EditValue = ""
        txt_third_out.EditValue = ""
        ckApproveOvertime.Checked = False
        txtRemarks.Text = ""
       
        DisableInputs()
    End Sub
    Public Sub DisableInputs()
        ckHalfDay.Checked = False
        ckHalfDay.ReadOnly = True
        txt_first_in.ReadOnly = True
        txt_first_out.ReadOnly = True
        txt_second_in.ReadOnly = True
        txt_second_out.ReadOnly = True
        txt_third_in.ReadOnly = True
        txt_third_out.ReadOnly = True
        ckApproveOvertime.Checked = False
        ckApproveOvertime.ReadOnly = True
        txtRemarks.ReadOnly = True
    End Sub
    Public Sub EnableInputs()
        ckHalfDay.ReadOnly = False
        txt_first_in.ReadOnly = False
        txt_first_out.ReadOnly = False
        txt_second_in.ReadOnly = False
        txt_second_out.ReadOnly = False
        txt_third_in.ReadOnly = False
        txt_third_out.ReadOnly = False
        ckApproveOvertime.ReadOnly = False
        txtRemarks.ReadOnly = False

    End Sub
    Private Sub cmdAttendanceSettings_Click(sender As Object, e As EventArgs) Handles cmdAttendanceSettings.Click

        If ((txt_first_in.Text <> "" Or txt_first_out.Text <> "") And (txt_second_in.Text <> "" Or txt_second_out.Text <> "")) And ckHalfDay.Checked = True And ckAbsent.Checked = False Then
            XtraMessageBox.Show("Please remove time either morning or afternoon!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf (txt_first_in.Text = "" Or txt_first_out.Text = "" Or txt_second_in.Text = "" Or txt_second_out.Text = "") And ckHalfDay.Checked = False And ckAbsent.Checked = False Then
            XtraMessageBox.Show("Invalid attendance time inputs!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblpayrollattendance set absent='" & ckAbsent.CheckState & "',halfday='" & ckHalfDay.CheckState & "', " _
                             + " 1st_timein=" & If(txt_first_in.Text = "" Or ckAbsent.Checked = True, "null", "'" & ConvertServerTime(txt_first_in.Text) & "'") & ", " _
                             + " 1st_timeout=" & If(txt_first_out.Text = "" Or ckAbsent.Checked = True, "null", "'" & ConvertServerTime(txt_first_out.Text) & "'") & ", " _
                             + " 2nd_timein=" & If(txt_second_in.Text = "" Or ckAbsent.Checked = True, "null", "'" & ConvertServerTime(txt_second_in.Text) & "'") & ", " _
                             + " 2nd_timeout=" & If(txt_second_out.Text = "" Or ckAbsent.Checked = True, "null", "'" & ConvertServerTime(txt_second_out.Text) & "'") & ", " _
                             + " 3rd_timein=" & If(txt_third_in.Text = "" Or ckAbsent.Checked = True, "null", "'" & ConvertServerTime(txt_third_in.Text) & "'") & ", " _
                             + " 3rd_timeout=" & If(txt_third_out.Text = "" Or ckAbsent.Checked = True, "null", "'" & ConvertServerTime(txt_third_out.Text) & "'") & ", " _
                             + " overtimeapproved='" & ckApproveOvertime.CheckState & "'," _
                             + " remarks='" & rchar(txtRemarks.Text) & "', " _
                             + " checked=1, checkedby='" & globaluserid & "' " _
                             + " where id='" & id.Text & "'" : com.ExecuteNonQuery()
        End If
        ClearField() : LoadData()
        XtraMessageBox.Show("Shift type successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
 
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadData()
    End Sub

   

    Private Sub txt_first_in_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_first_in.KeyDown
        If e.KeyCode = Keys.Delete Then
            txt_first_in.EditValue = Nothing
        End If
    End Sub
    Private Sub txt_first_out_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_first_out.KeyDown
        If e.KeyCode = Keys.Delete Then
            txt_first_out.EditValue = Nothing
        End If
    End Sub

    Private Sub txt_second_in_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_second_in.KeyDown
        If e.KeyCode = Keys.Delete Then
            txt_second_in.EditValue = Nothing
        End If
    End Sub
    Private Sub txt_second_out_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_second_out.KeyDown
        If e.KeyCode = Keys.Delete Then
            txt_second_out.EditValue = Nothing
        End If
    End Sub

    Private Sub txt_third_in_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_third_in.KeyDown
        If e.KeyCode = Keys.Delete Then
            txt_third_in.EditValue = Nothing
        End If
    End Sub
    Private Sub txt_third_out_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_third_out.KeyDown
        If e.KeyCode = Keys.Delete Then
            txt_third_out.EditValue = Nothing
        End If
    End Sub

    Private Sub ckAbsent_CheckedChanged(sender As Object, e As EventArgs) Handles ckAbsent.CheckedChanged
        If ckAbsent.Checked = True Then
            DisableInputs()
        Else
            EnableInputs()
        End If
    End Sub

    Private Sub txtAttendanceDate_EditValueChanged(sender As Object, e As EventArgs) Handles txtAttendanceDate.EditValueChanged
        If txtAttendanceDate.Text = "" Then
            cmdAttendanceSettings.Visible = False
            cmdApproveAttendance.Visible = True
        Else
            cmdAttendanceSettings.Visible = True
            cmdApproveAttendance.Visible = False
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdApproveAttendance.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblpayrollattendance set approved=1, approvedby='" & globaluserid & "' where employeeid='" & employeeid.Text & "' and payrollcode='" & payrollcode.Text & "'" : com.ExecuteNonQuery()
            frmPayrollProcessing.FilterEmployee()
            XtraMessageBox.Show("Attendance was successfull approve!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub OverideAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverideAttendanceToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To Gridview1.RowCount - 1
                com.CommandText = "update tblpayrollattendance set restday=" & CBool(Gridview1.GetRowCellValue(I, "RestDay").ToString()) & ", " _
                           + " absent=" & CBool(Gridview1.GetRowCellValue(I, "Absent").ToString()) & ", " _
                           + " halfday=" & CBool(Gridview1.GetRowCellValue(I, "HalfDay").ToString()) & ", " _
                           + " overtimeapproved=" & CBool(Gridview1.GetRowCellValue(I, "ApprovedOvertime").ToString()) & ", " _
                           + " renderedcount='" & Val(Gridview1.GetRowCellValue(I, "RenderedHours").ToString()) & "'," _
                           + " latecount='" & Val(Gridview1.GetRowCellValue(I, "Late").ToString()) & "', " _
                           + " undertimecount='" & Val(Gridview1.GetRowCellValue(I, "Undertime").ToString()) & "', " _
                           + " overtimecount='" & Val(Gridview1.GetRowCellValue(I, "Overtime").ToString()) & "', " _
                           + " remarks='" & rchar(Gridview1.GetRowCellValue(I, "Remarks").ToString()) & "', " _
                           + " checked=1, checkedby='" & globaluserid & "', approved=1, approvedby='" & globaluserid & "' " _
                           + " where id='" & Gridview1.GetRowCellValue(I, "id").ToString() & "'" : com.ExecuteNonQuery()
            Next
            XtraMessageBox.Show("Attendance was successfull Overide!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub ShowPicture(ByVal empid As String, ByVal logindate As String)
        com.CommandText = "select * from filedir.tblattendanceimage where employeeid='" & empid & "' and logindate='" & logindate & "'" : rst = com.ExecuteReader
        While rst.Read
            pic_morning_1.Image = convertSQlImage("1st_timein")
            pic_morning_2.Image = convertSQlImage("1st_timeout")
            pic_afternoon_1.Image = convertSQlImage("2nd_timein")
            pic_afternoon_2.Image = convertSQlImage("2nd_timeout")
            pic_overtime_1.Image = convertSQlImage("3rd_timein")
            pic_overtime_2.Image = convertSQlImage("3rd_timeout")
        End While
        rst.Close()
    End Sub
    Public Function convertSQlImage(ByVal fld As String) As Image
        If rst(fld).ToString <> "" Then
            imgBytes = CType(rst(fld), Byte())
            stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
            img = Image.FromStream(stream)
            convertSQlImage = img
        End If
    End Function

    Private Sub Gridview1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles Gridview1.FocusedRowChanged
        If Gridview1.RowCount = 0 Then Exit Sub
        ShowPicture(employeeid.Text, ConvertDate(Gridview1.GetFocusedRowCellValue("AttendanceDate").ToString))
    End Sub
End Class