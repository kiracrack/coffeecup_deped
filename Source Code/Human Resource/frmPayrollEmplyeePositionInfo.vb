Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPayrollEmplyeePositionInfo
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
        LoadScheduleType()

        If mode.Text = "edit" Then
            ShowPositionInfo()
        End If
        LoadGridviewAppearance(gv_scheduletype)
    End Sub
    Public Sub LoadScheduleType()
        LoadXgridLookupEdit("select code, Description as 'Select' from tblpayrollschedule where computeattendance=1", "tblpayrollschedule", txtScheduleType, gv_scheduletype, Me)
        gv_scheduletype.Columns("code").Visible = False
    End Sub
    Private Sub txtPayoutSchedule_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScheduleType.EditValueChanged
        On Error Resume Next
        schedulecode.Text = txtScheduleType.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub

#Region "SALARY COMPUTATION"
    Private Sub txtMonthlyRate_EditValueChanged(sender As Object, e As EventArgs) Handles txtMonthlyRate.EditValueChanged
        LoadFullComputation()
    End Sub
    Public Sub LoadFullComputation()
        txtDailyRate.Text = Val(CC(txtMonthlyRate.Text)) / GlobalTotalWorkingDays
        txtRatePerHour.Text = Val(CC(txtDailyRate.Text)) / GlobalTotalWorkingHours
        txtRatePerMinute.Text = Val(CC(txtRatePerHour.Text)) / 60
        LoadLateOption()
        LoadUndertimeOption()
        LoadOvertimeOption()
        LoadNightShiftOption()
    End Sub

    Public Sub LoadLateOption()
        If ck_late.Checked = True Then
            If mode.Text <> "edit" Then
                If txtLateType.Text = "MINUTE" Then
                    txtLateRate.Text = txtRatePerMinute.Text
                Else
                    txtLateRate.Text = txtRatePerHour.Text
                End If
            End If
        End If
    End Sub

    Public Sub LoadUndertimeOption()
        If ck_undertime.Checked = True Then
            If mode.Text <> "edit" Then
                If txtUndertimeType.Text = "MINUTE" Then
                    txtUndertimeRate.Text = txtRatePerMinute.Text
                Else
                    txtUndertimeRate.Text = txtRatePerHour.Text
                End If
            End If
        End If
    End Sub

    Public Sub LoadOvertimeOption()
        If ck_overtime.Checked = True Then
            If mode.Text <> "edit" Then
                If txtOvertimeType.Text = "MINUTE" Then
                    txtOvertimeRate.Text = txtRatePerMinute.Text
                Else
                    txtOvertimeRate.Text = txtRatePerHour.Text
                End If
            End If
        End If
    End Sub

    Public Sub LoadNightShiftOption()
        If ck_nightdiff.Checked = True Then
            If mode.Text <> "edit" Then
                If txtNightDiffType.Text = "MINUTE" Then
                    txtNightDiffRate.Text = txtRatePerMinute.Text
                Else
                    txtNightDiffRate.Text = txtRatePerHour.Text
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub code_EditValueChanged(sender As Object, e As EventArgs) Handles code.EditValueChanged
        ShowPositionInfo()
    End Sub

    Public Sub ShowPositionInfo()
        com.CommandText = "select *, (select description from tblpayrollschedule where code=tblpayrollbasicrate.schedulecode) as 'schedule' from tblpayrollbasicrate where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            schedulecode.Text = rst("schedulecode").ToString
            txtScheduleType.Text = rst("schedule").ToString
            txtMonthlyRate.Text = rst("ratepermonth").ToString
            txtDailyRate.Text = rst("rateperday").ToString
            txtRatePerHour.Text = rst("rateperhour").ToString
            txtRatePerMinute.Text = rst("rateperminute").ToString
            cktaxexcempt.Checked = rst("taxexcempt")
            ckGsisSss.Checked = rst("sss")
            ckPhilHealth.Checked = rst("philhealth")
            ckPagibig.Checked = rst("pagibig")
            ckPersonalSavings.Checked = rst("savings")

            ck_late.Checked = rst("enablelate")
            txtLateRate.Text = rst("laterate").ToString
            txtLateType.Text = rst("latetype").ToString

            ck_undertime.Checked = rst("enableundertime")
            txtUndertimeRate.Text = rst("undertimerate").ToString
            txtUndertimeType.Text = rst("undertimetype").ToString

            ck_overtime.Checked = rst("enableovertime")
            txtOvertimeRate.Text = rst("overtimerate").ToString
            txtOvertimeType.Text = rst("overtimetype").ToString

            ck_nightdiff.Checked = rst("enablensd")
            txtNightDiffRate.Text = rst("nsdrate").ToString
            txtNightDiffType.Text = rst("nsdtype").ToString
            txtNSDfrom.EditValue = rst("nsdtimefrom")
            txtNSDto.EditValue = rst("nsdtimeto")

            ckEnableSaturday.Checked = rst("enablesaturday")
            txtSaturdayRate.Text = rst("saturdayrate").ToString
            ckEnableSunday.Checked = rst("enablesunday")
            txtSundayRate.Text = rst("sundayrate").ToString
            ckDoublePayHoliday.Checked = rst("doublepayholiday")
        End While
        rst.Close()
    End Sub

#Region "Attendance Settings"
    Private Sub ck_late_CheckedChanged(sender As Object, e As EventArgs) Handles ck_late.CheckedChanged
        If ck_late.Checked = False Then
            txtLateRate.Enabled = False : txtLateRate.Text = "0.00"
            txtLateType.Enabled = False : txtLateType.SelectedIndex = 0
        Else
            txtLateRate.Enabled = True
            txtLateType.Enabled = True
        End If
        LoadLateOption()
    End Sub

    Private Sub ck_undertime_CheckedChanged(sender As Object, e As EventArgs) Handles ck_undertime.CheckedChanged
        If ck_undertime.Checked = False Then
            txtUndertimeRate.Enabled = False : txtUndertimeRate.Text = "0.00"
            txtUndertimeType.Enabled = False : txtUndertimeType.SelectedIndex = 0
        Else
            txtUndertimeRate.Enabled = True
            txtUndertimeType.Enabled = True
        End If
        LoadUndertimeOption()
    End Sub

    Private Sub ck_overtime_CheckedChanged(sender As Object, e As EventArgs) Handles ck_overtime.CheckedChanged
        If ck_overtime.Checked = False Then
            txtOvertimeRate.Enabled = False : txtOvertimeRate.Text = "0.00"
            txtOvertimeType.Enabled = False : txtOvertimeType.SelectedIndex = 0
        Else
            txtOvertimeRate.Enabled = True
            txtOvertimeType.Enabled = True
        End If
        LoadOvertimeOption()
    End Sub

    Private Sub ck_nightdiff_CheckedChanged(sender As Object, e As EventArgs) Handles ck_nightdiff.CheckedChanged
        If ck_nightdiff.Checked = False Then
            txtNightDiffRate.Enabled = False : txtNightDiffRate.Text = "0.00"
            txtNightDiffType.Enabled = False : txtNightDiffType.SelectedIndex = 0
            txtNSDfrom.Enabled = False
            txtNSDto.Enabled = False
        Else
            txtNightDiffRate.Enabled = True
            txtNightDiffType.Enabled = True
            txtNSDfrom.Enabled = True
            txtNSDto.Enabled = True
        End If
        LoadNightShiftOption()
    End Sub

    Private Sub txtLateType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtLateType.SelectedValueChanged
        LoadLateOption()
    End Sub

    Private Sub txtUndertimeType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtUndertimeType.SelectedValueChanged
        LoadUndertimeOption()
    End Sub

    Private Sub txtOvertimeType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtOvertimeType.SelectedValueChanged
        LoadOvertimeOption()
    End Sub

    Private Sub txtNightDiffType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtNightDiffType.SelectedValueChanged
        LoadNightShiftOption()
    End Sub
#End Region

#Region "SATURDAY AND SUNDAY OPTION"
    Private Sub ckEnableSaturday_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableSaturday.CheckedChanged
        If ckEnableSaturday.Checked = True Then
            txtSaturdayRate.Enabled = True
            If mode.Text <> "edit" Then
                txtSaturdayRate.Text = txtDailyRate.Text
            End If
        Else
            txtSaturdayRate.Enabled = False
            txtSaturdayRate.Text = "0.00"
        End If
    End Sub

    Private Sub ckEnableSunday_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableSunday.CheckedChanged
        If ckEnableSunday.Checked = True Then
            txtSundayRate.Enabled = True
            If mode.Text <> "edit" Then
                txtSundayRate.Text = txtDailyRate.Text
            End If
        Else
            txtSundayRate.Enabled = False
            txtSundayRate.Text = "0.00"
        End If
    End Sub
#End Region

    Private Sub cmdAttendanceSettings_Click(sender As Object, e As EventArgs) Handles cmdAttendanceSettings.Click
        If txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter rate description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        ElseIf txtScheduleType.Text = "" Then
            XtraMessageBox.Show("Please select payout schedule!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtScheduleType.Focus()
            Exit Sub
        End If
        Dim ColumnQuery As String = " description='" & txtDescription.Text & "', " _
                               + " schedulecode='" & schedulecode.Text & "', " _
                               + " totalhours='" & GlobalTotalWorkingHours & "', " _
                               + " ratepermonth='" & Val(CC(txtMonthlyRate.Text)) & "', " _
                               + " rateperday='" & Val(CC(txtDailyRate.Text)) & "', " _
                               + " rateperhour='" & Val(CC(txtRatePerHour.Text)) & "', " _
                               + " rateperminute='" & Val(CC(txtRatePerMinute.Text)) & "', " _
                               + " taxexcempt='" & cktaxexcempt.CheckState & "', " _
                               + " sss='" & ckGsisSss.CheckState & "', " _
                               + " philhealth='" & ckPhilHealth.CheckState & "', " _
                               + " pagibig='" & ckPagibig.CheckState & "', " _
                               + " savings='" & ckPersonalSavings.CheckState & "', " _
                               + " enablelate='" & ck_late.CheckState & "', " _
                               + " laterate='" & Val(CC(txtLateRate.Text)) & "', " _
                               + " latetype='" & txtLateType.Text & "', " _
                               + " enableundertime='" & ck_undertime.CheckState & "', " _
                               + " undertimerate='" & Val(CC(txtUndertimeRate.Text)) & "', " _
                               + " undertimetype='" & txtUndertimeType.Text & "', " _
                               + " enableovertime='" & ck_overtime.CheckState & "', " _
                               + " overtimerate='" & Val(CC(txtOvertimeRate.Text)) & "', " _
                               + " overtimetype='" & txtOvertimeType.Text & "', " _
                               + " enablensd='" & ck_nightdiff.CheckState & "', " _
                               + " nsdrate='" & Val(CC(txtNightDiffRate.Text)) & "', " _
                               + " nsdtype='" & txtNightDiffType.Text & "', " _
                               + " nsdtimefrom='" & ConvertServerTime(txtNSDfrom.Text) & "', " _
                               + " nsdtimeto='" & ConvertServerTime(txtNSDto.Text) & "', " _
                               + " enablesaturday='" & ckEnableSaturday.CheckState & "', " _
                               + " saturdayrate='" & Val(CC(txtSaturdayRate.Text)) & "', " _
                               + " enablesunday='" & ckEnableSunday.CheckState & "', " _
                               + " sundayrate='" & Val(CC(txtSundayRate.Text)) & "', " _
                               + " doublepayholiday='" & ckDoublePayHoliday.CheckState & "'"

        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblpayrollbasicrate set " & ColumnQuery & " where code='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "INSERT INTO tblpayrollbasicrate set " & ColumnQuery : com.ExecuteNonQuery()
        End If
        frmPayrollEmplyeePosition.LoadData()
        XtraMessageBox.Show("Position successfull added!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub


End Class