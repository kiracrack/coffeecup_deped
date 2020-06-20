Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPayrollAttendanceView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmShiftSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGridviewAppearance(Gridview1)
        shiftcode.Text = qrysingledata("shiftcode", "shiftcode", "where employeeid='" & employeeid.Text & "'", "tblemployees")
        Me.Text = qrysingledata("fullname", "fullname", "where employeeid='" & employeeid.Text & "'", "tblemployees")
        LoadData()
    End Sub
    Public Sub LoadData()
        LoadXgrid("call sp_payrollcomputeattendance(FALSE,'" & payrollcode.Text & "','" & employeeid.Text & "')", "sp_payrollshowattendance(FALSE,'" & payrollcode.Text & "','" & employeeid.Text & "')", Em, Gridview1, Me)
        XgridHideColumn({"id"}, Gridview1)
        XgridColAlign({"AttendanceDate", "DayOfWeek", "MorningIn", "MorningOut", "NoonIn", "NoonOut", "OvertimeIn", "OvertimeOut", "RenderedHours", "Late", "Undertime", "Overtime"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"RenderedHours", "Late", "Undertime", "Overtime"}, Gridview1)
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
     
End Class