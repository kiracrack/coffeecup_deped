Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPayrollAttendanceConsole
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
 

    Private Sub frmShiftSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadYear()
        LoadData()
        LoadGridviewAppearance(Gridview1)
    End Sub
    Public Sub LoadData()
        If txtYear.Text = "Year" Or txtMonth.Text = "Month" Or txtDay.Text = "Day" Then Exit Sub
        LoadXgrid("select  employeeid, date_format(logindate,'%Y-%m-%d') as 'logdate', (select fullname from tblemployees where employeeid =tblpayrollattendancelog.employeeid) as 'Employee Name', " _
                                    + " date_format(1st_timein,'%r') as 'Morning IN', date_format(1st_timeout,'%r') as 'Morning Out', " _
                                    + " date_format(2nd_timein,'%r') as 'Afternoon IN', date_format(2nd_timeout,'%r') as 'Afternoon Out', " _
                                    + " date_format(3rd_timein,'%r') as 'Overtime IN', date_format(3rd_timeout,'%r') as 'Overtime OUT' from tblpayrollattendancelog where date_format(logindate,'%Y-%m-%d') = '" & txtYear.Text & "-" & CDate(txtDay.Text & "/" & txtMonth.Text & "/" & txtYear.Text).ToString("MM") & "-" & txtDay.Text & "' order by 1st_timein asc", "tblpayrollattendancelog", Em, Gridview1, Me)
        Gridview1.Columns("employeeid").Visible = False
        Gridview1.Columns("logdate").Visible = False
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

    Public Sub LoadYear()
        LoadToComboBoxQuery("str", "distinct date_format(logindate,'%Y') as str", "tblpayrollattendancelog order by date_format(logindate,'%Y') asc", txtYear)
    End Sub
   
    Private Sub txtYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtYear.SelectedValueChanged
        LoadMonth()
        LoadData()
    End Sub

    Public Sub LoadMonth()
        LoadToComboBoxQuery("str", "distinct date_format(logindate,'%M') as str", "tblpayrollattendancelog where date_format(logindate,'%Y')='" & txtYear.Text & "' order by date_format(logindate,'%m') asc", txtMonth)
    End Sub
 
    Private Sub txtMonth_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtMonth.SelectedValueChanged
        LoadDay()
        LoadData()
    End Sub

    Public Sub LoadDay()
        LoadToComboBoxQuery("str", "distinct  date_format(logindate,'%d') as str", "tblpayrollattendancelog where date_format(logindate,'%M')='" & txtMonth.Text & "' order by date_format(logindate,'%d') asc", txtDay)
    End Sub

   
    Private Sub txtDay_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtDay.SelectedValueChanged
        LoadData()
    End Sub

    Private Sub Gridview1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles Gridview1.FocusedRowChanged
        If Gridview1.RowCount = 0 Then Exit Sub
        ShowPicture(Gridview1.GetFocusedRowCellValue("employeeid").ToString, Gridview1.GetFocusedRowCellValue("logdate").ToString)
    End Sub
  
    Private Sub ckViewPicture_CheckedChanged(sender As Object, e As EventArgs) Handles ckViewPicture.CheckedChanged
        If ckViewPicture.Checked = True Then
            SplitContainerControl1.CollapsePanel = SplitCollapsePanel.None
        Else
            SplitContainerControl1.CollapsePanel = SplitCollapsePanel.Panel2
        End If
    End Sub
End Class