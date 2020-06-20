Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.XtraSplashScreen
Imports MySql.Data.MySqlClient

Public Class frmPayrollLoadAttendanceNotFound
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub frmPayrollLoadAttendanceNotFound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadData()
        LoadGridviewAppearance(Gridview1)
        com.CommandText = "select * from tblpayrollperiod where payrollcode='" & payrollcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            schedulecode.Text = rst("schedulecode").ToString
            txtPeriodFrom.EditValue = CDate(rst("datefrom").ToString)
            txtPeriodTo.EditValue = CDate(rst("dateto").ToString)
        End While
        rst.Close()
    End Sub
    Public Sub LoadData()
        LoadXgrid("select employeeid, Fullname, (select description from tblpayrollbasicrate where code = tblemployees.positioncode) as 'Position' from tblemployees inner join tblpayrollbasicrate on tblemployees.positioncode = tblpayrollbasicrate.code where schedulecode='" & schedulecode.Text & "' and employeeid not in (select employeeid from tblpayrollattendance where payrollcode='" & payrollcode.Text & "') and resigned=0 order by fullname asc", "tblemployees", Em, Gridview1, Me)
        XgridHideColumn({"employeeid"}, Gridview1)
    End Sub

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
           
            XtraMessageBox.Show("Attendance successfully created", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Dim totaldays As Integer = DateDiff(DateInterval.Day, txtPeriodFrom.EditValue, txtPeriodTo.EditValue)
        'Dim str As String = ""
        'For I = 0 To totaldays
        '    str += ConvertDate(CDate(txtPeriodFrom.EditValue).AddDays(I)) & " - " & If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = 0, "SUNDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = 1, "MONDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = 2, "TUESDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = 3, "WEDNESDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = 4, "THURSDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = 5, "FRIDAY", If(CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek = 6, "SATURDAY", ""))))))) & Chr(13)
        '    'str += ConvertDate(CDate(txtPeriodFrom.EditValue).AddDays(I)) & " - " & CDate(txtPeriodFrom.EditValue).AddDays(I).DayOfWeek & Chr(13)
        'Next
        'MsgBox(str)
    End Sub
End Class