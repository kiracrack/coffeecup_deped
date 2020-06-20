Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.XtraSplashScreen
Imports MySql.Data.MySqlClient

Public Class frmPayrollPeriod
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPayrollPeriod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadScheduleType()
        ShowPayrollPeriodStatus()
    End Sub
    Public Sub ShowPayrollPeriodStatus()
        If countqry("tblpayrollperiod", "createdby='" & globaluserid & "' and approved=0") > 0 Then
            com.CommandText = "select *,(select description from tblpayrollschedule where code=tblpayrollperiod.schedulecode) as 'schedule' from tblpayrollperiod where createdby='" & globaluserid & "' and approved=0" : rst = com.ExecuteReader
            While rst.Read
                payrollcode.Text = rst("payrollcode")
                txtScheduleType.Text = rst("schedule").ToString
                schedulecode.Text = rst("schedulecode").ToString
                ckComputeAttendance.Checked = rst("computeattendance")
                txtPeriodFrom.EditValue = CDate(rst("datefrom").ToString)
                txtPeriodTo.EditValue = CDate(rst("dateto").ToString)
                txtDescription.Text = rst("remarks").ToString
            End While
            rst.Close()
            Dim TotalUncapture As Integer = qrysingledata("cnt", "count(*) as cnt", " tblemployees inner join tblpayrollbasicrate on tblemployees.positioncode = tblpayrollbasicrate.code where schedulecode='" & schedulecode.Text & "' and employeeid not in (select employeeid from tblpayrollattendance where payrollcode='" & payrollcode.Text & "') and actived=1 and resigned=0")
            If TotalUncapture > 0 Then
                cmdCaptureRemaining.Visible = True
                cmdCaptureRemaining.Text = "Capture Remaining " & TotalUncapture
            Else
                cmdCaptureRemaining.Visible = False
            End If
            txtScheduleType.Properties.ReadOnly = True
            txtPeriodFrom.Properties.ReadOnly = True
            txtPeriodTo.Properties.ReadOnly = True
            txtDescription.Properties.ReadOnly = True
            cmdCreate.Enabled = False
            cmdCancel.Visible = True
        Else
            txtScheduleType.Properties.ReadOnly = False
            txtPeriodFrom.Properties.ReadOnly = False
            txtPeriodTo.Properties.ReadOnly = False
            txtDescription.Properties.ReadOnly = False
            cmdCreate.Enabled = True
            cmdCancel.Visible = False
        End If
    End Sub

    Public Sub LoadScheduleType()
        LoadXgridLookupEdit("select code, Description as 'Select',computeattendance from tblpayrollschedule", "tblpayrollschedule", txtScheduleType, gv_scheduletype, Me)
        gv_scheduletype.Columns("code").Visible = False
        gv_scheduletype.Columns("computeattendance").Visible = False
    End Sub
    Private Sub txtPayoutSchedule_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScheduleType.EditValueChanged
        On Error Resume Next
        schedulecode.Text = txtScheduleType.Properties.View.GetFocusedRowCellValue("code").ToString
        ckComputeAttendance.Checked = CBool(txtScheduleType.Properties.View.GetFocusedRowCellValue("computeattendance").ToString)
    End Sub

    Private Sub txtPeriodFrom_EditValueChanged(sender As Object, e As EventArgs) Handles txtPeriodFrom.EditValueChanged, txtPeriodTo.EditValueChanged
        payrollcode.Text = globaluserid & "P" & CDate(txtPeriodFrom.EditValue).ToString("yyyy") & "-" & CDate(txtPeriodFrom.EditValue).ToString("MMdd") & "-" & CDate(txtPeriodTo.EditValue).ToString("MMdd")
        txtDescription.Text = "Payroll covered from " & CDate(txtPeriodFrom.EditValue).ToString("MM/dd/yyyy") & " to " & CDate(txtPeriodTo.EditValue).ToString("MM/dd/yyyy")
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        If txtScheduleType.Text = "" Then
            XtraMessageBox.Show("Please select payroll type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtScheduleType.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter remarks!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            dst = New DataSet
            msda = New MySqlDataAdapter("select * from tblemployees inner join tblpayrollbasicrate on tblemployees.positioncode = tblpayrollbasicrate.code where schedulecode='" & schedulecode.Text & "' and employeeid not in (select employeeid from tblpayrollattendance where payrollcode='" & payrollcode.Text & "') and resigned=0 and actived=1 order by fullname asc", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    Dim totaldays As Integer = DateDiff(DateInterval.Day, txtPeriodFrom.EditValue, txtPeriodTo.EditValue)
                    For I = 0 To totaldays
                        Dim def_1st_in As Date = Nothing : Dim def_1st_out As Date = Nothing : Dim def_2nd_in As Date = Nothing : Dim def_2nd_out As Date = Nothing : Dim totalhours As Integer = 0
                        com.CommandText = "select * from tblpayrollshiftsettings where shiftcode='" & .Rows(cnt)("shiftcode").ToString() & "'" : rst = com.ExecuteReader
                        While rst.Read
                            def_1st_in = rst("def_1st_in").ToString
                            def_1st_out = rst("def_1st_out").ToString
                            def_2nd_in = rst("def_2nd_in").ToString
                            def_2nd_out = rst("def_2nd_out").ToString
                            totalhours = rst("totalhours")
                        End While
                        rst.Close()
                        If countqry("tblpayrollattendance", "payrollcode='" & payrollcode.Text & "' and employeeid='" & .Rows(cnt)("employeeid").ToString() & "' and attendancedate='" & ConvertDate(CDate(txtPeriodFrom.EditValue).AddDays(I)) & "'") = 0 Then
                            com.CommandText = "insert into tblpayrollattendance set payrollcode='" & payrollcode.Text & "', " _
                                       + " employeeid='" & .Rows(cnt)("employeeid").ToString() & "', " _
                                       + " biometricid='" & .Rows(cnt)("biometricid").ToString() & "', " _
                                       + " shiftcode='" & .Rows(cnt)("shiftcode").ToString() & "', " _
                                       + " attendancedate='" & ConvertDate(CDate(txtPeriodFrom.EditValue).AddDays(I)) & "', " _
                                       + " dayofweek='" & If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday, "SUNDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Monday, "MONDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Tuesday, "TUESDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Wednesday, "WEDNESDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Thursday, "THURSDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Friday, "FRIDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "SATURDAY", ""))))))) & "', " _
                                       + " regularday='" & If(Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "1", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday And CBool(.Rows(cnt)("enablesaturday").ToString()) = True, "1", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And CBool(.Rows(cnt)("enablesunday").ToString()) = True, "1", "0"))) & "', " _
                                       + " 1st_timein=" & If(Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "'" & ConvertServerTime(def_1st_in) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday And CBool(.Rows(cnt)("enablesaturday").ToString()) = True, "'" & ConvertServerTime(def_1st_in) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And CBool(.Rows(cnt)("enablesunday").ToString()) = True, "'" & ConvertServerTime(def_1st_in) & "'", "null"))) & ", " _
                                       + " 1st_timeout=" & If(Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "'" & ConvertServerTime(def_1st_out) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday And CBool(.Rows(cnt)("enablesaturday").ToString()) = True, "'" & ConvertServerTime(def_1st_out) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And CBool(.Rows(cnt)("enablesunday").ToString()) = True, "'" & ConvertServerTime(def_1st_out) & "'", "null"))) & ", " _
                                       + " 2nd_timein=" & If(Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "'" & ConvertServerTime(def_2nd_in) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday And CBool(.Rows(cnt)("enablesaturday").ToString()) = True, "'" & ConvertServerTime(def_2nd_in) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And CBool(.Rows(cnt)("enablesunday").ToString()) = True, "'" & ConvertServerTime(def_2nd_in) & "'", "null"))) & ", " _
                                       + " 2nd_timeout=" & If(Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "'" & ConvertServerTime(def_2nd_out) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday And CBool(.Rows(cnt)("enablesaturday").ToString()) = True, "'" & ConvertServerTime(def_2nd_out) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And CBool(.Rows(cnt)("enablesunday").ToString()) = True, "'" & ConvertServerTime(def_2nd_out) & "'", "null"))) & ", " _
                                       + " regworkedhour='" & totalhours & "', " _
                                       + " renderedcount='" & totalhours * 60 & "', " _
                                       + " capturedby='" & globaluserid & "', datecaptured=current_timestamp" : com.ExecuteNonQuery()
                        End If
                    Next
                End With
            Next
            SplashScreenManager.CloseForm()
            ShowPayrollPeriodStatus()
            com.CommandText = "insert into tblpayrollperiod set payrollcode='" & payrollcode.Text & "', schedulecode='" & schedulecode.Text & "', computeattendance='" & ckComputeAttendance.CheckState & "', remarks='" & rchar(txtDescription.Text) & "', datefrom='" & ConvertDate(txtPeriodFrom.EditValue) & "', dateto='" & ConvertDate(txtPeriodTo.EditValue) & "', createdby='" & globaluserid & "', datecreated=current_timestamp" : com.ExecuteNonQuery()
            XtraMessageBox.Show("Payroll period successfully created!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If XtraMessageBox.Show("Are you sure you want to continue? " & Environment.NewLine & Environment.NewLine & "  NOTE: All computation and attendance will lost and there's no undo function for this.", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tblpayrollperiod where payrollcode='" & payrollcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblpayrollattendance where payrollcode='" & payrollcode.Text & "'" : com.ExecuteNonQuery()
            ShowPayrollPeriodStatus()
            XtraMessageBox.Show("Payroll period successfully cancelled!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCaptureRemaining_Click(sender As Object, e As EventArgs) Handles cmdCaptureRemaining.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            dst = New DataSet
            msda = New MySqlDataAdapter("select * from tblemployees inner join tblpayrollbasicrate on tblemployees.positioncode = tblpayrollbasicrate.code where schedulecode='" & schedulecode.Text & "' and employeeid not in (select employeeid from tblpayrollattendance where payrollcode='" & payrollcode.Text & "') and resigned=0 and actived=1 order by fullname asc", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    Dim totaldays As Integer = DateDiff(DateInterval.Day, txtPeriodFrom.EditValue, txtPeriodTo.EditValue)
                    For I = 0 To totaldays
                        Dim def_1st_in As Date = Nothing : Dim def_1st_out As Date = Nothing : Dim def_2nd_in As Date = Nothing : Dim def_2nd_out As Date = Nothing : Dim totalhours As Integer = 0
                        com.CommandText = "select * from tblpayrollshiftsettings where shiftcode='" & .Rows(cnt)("shiftcode").ToString() & "'" : rst = com.ExecuteReader
                        While rst.Read
                            def_1st_in = rst("def_1st_in").ToString
                            def_1st_out = rst("def_1st_out").ToString
                            def_2nd_in = rst("def_2nd_in").ToString
                            def_2nd_out = rst("def_2nd_out").ToString
                            totalhours = rst("totalhours")
                        End While
                        rst.Close()
                        If countqry("tblpayrollattendance", "payrollcode='" & payrollcode.Text & "' and employeeid='" & .Rows(cnt)("employeeid").ToString() & "' and attendancedate='" & ConvertDate(CDate(txtPeriodFrom.EditValue).AddDays(I)) & "'") = 0 Then
                            com.CommandText = "insert into tblpayrollattendance set payrollcode='" & payrollcode.Text & "', " _
                                       + " employeeid='" & .Rows(cnt)("employeeid").ToString() & "', " _
                                       + " biometricid='" & .Rows(cnt)("biometricid").ToString() & "', " _
                                       + " shiftcode='" & .Rows(cnt)("shiftcode").ToString() & "', " _
                                       + " attendancedate='" & ConvertDate(CDate(txtPeriodFrom.EditValue).AddDays(I)) & "', " _
                                       + " dayofweek='" & If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday, "SUNDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Monday, "MONDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Tuesday, "TUESDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Wednesday, "WEDNESDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Thursday, "THURSDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Friday, "FRIDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "SATURDAY", ""))))))) & "', " _
                                       + " regularday='" & If(Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "1", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday And CBool(.Rows(cnt)("enablesaturday").ToString()) = True, "1", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And CBool(.Rows(cnt)("enablesunday").ToString()) = True, "1", "0"))) & "', " _
                                       + " 1st_timein=" & If(Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "'" & ConvertServerTime(def_1st_in) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday And CBool(.Rows(cnt)("enablesaturday").ToString()) = True, "'" & ConvertServerTime(def_1st_in) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And CBool(.Rows(cnt)("enablesunday").ToString()) = True, "'" & ConvertServerTime(def_1st_in) & "'", "null"))) & ", " _
                                       + " 1st_timeout=" & If(Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "'" & ConvertServerTime(def_1st_out) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday And CBool(.Rows(cnt)("enablesaturday").ToString()) = True, "'" & ConvertServerTime(def_1st_out) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And CBool(.Rows(cnt)("enablesunday").ToString()) = True, "'" & ConvertServerTime(def_1st_out) & "'", "null"))) & ", " _
                                       + " 2nd_timein=" & If(Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "'" & ConvertServerTime(def_2nd_in) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday And CBool(.Rows(cnt)("enablesaturday").ToString()) = True, "'" & ConvertServerTime(def_2nd_in) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And CBool(.Rows(cnt)("enablesunday").ToString()) = True, "'" & ConvertServerTime(def_2nd_in) & "'", "null"))) & ", " _
                                       + " 2nd_timeout=" & If(Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And Not CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday, "'" & ConvertServerTime(def_2nd_out) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Saturday And CBool(.Rows(cnt)("enablesaturday").ToString()) = True, "'" & ConvertServerTime(def_2nd_out) & "'", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = DayOfWeek.Sunday And CBool(.Rows(cnt)("enablesunday").ToString()) = True, "'" & ConvertServerTime(def_2nd_out) & "'", "null"))) & ", " _
                                       + " regworkedhour='" & totalhours & "', " _
                                       + " renderedcount='" & totalhours * 60 & "', " _
                                       + " capturedby='" & globaluserid & "', datecaptured=current_timestamp" : com.ExecuteNonQuery()
                        End If
                    Next
                End With
            Next
            SplashScreenManager.CloseForm()
            ShowPayrollPeriodStatus()
            XtraMessageBox.Show("Payroll period successfully created!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class