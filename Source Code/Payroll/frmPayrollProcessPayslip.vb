Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen
Imports System.IO


Public Class frmPayrollProcessPayslip
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
        'LoadGridviewAppearance(Gridview1)
        If mode.Text = "current" Then
            LoadData(True)
        Else
            LoadData(False)
        End If
    End Sub

    Public Sub LoadData(ByVal current As Boolean)
        com.CommandText = "select a.*,e.position, (select img from filedir.tblemployeepic where employeeid=a.employeeid) as img, e.profilepic " & If(current = True, ",(OtherAdditional+TotalOvertime) as TotalAdditional,(OtherDeduction+sss+philhealth+pagibig+savings+TotalLate+TotalUndertime+if(MonthlyRate=1,TotalAbsent,0)+((rateperday/2) * Halfday)) as TotalDeduction,(OtherAdditional+TotalOvertime) + Gross as NetGross,((OtherAdditional+TotalOvertime) + Gross)-(OtherDeduction+sss+philhealth+pagibig+savings+TotalLate+TotalUndertime+if(MonthlyRate=1,TotalAbsent,0)+(rateperday/2) * Halfday) as NetPay  FROM coffeecup_reports.tblpayrollprocessing", "FROM tblpayrollsummary") & " as a  inner join tblemployees as e on a.employeeid = e.employeeid where a.EmployeeID='" & employeeid.Text & "' and payrollcode='" & payrollcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtfullname.Text = "NAME: " & rst("Fullname").ToString
            txtPosition.Text = "POSITION: " & rst("position").ToString
            txtOffice.Text = "OFFICE: " & rst("Office").ToString
            txtStatus.Text = "EMPLOYEE STATUS: " & rst("EmployeeStatus").ToString
            txtSalaryRate.Text = "SALARY RATE: " & rst("SalaryRate").ToString
            txtGross.Text = "GROSS: " & FormatNumber(rst("Gross").ToString, 2)
            txtAbsent.Text = rst("totalabsent").ToString
            txtHalfDay.Text = rst("TotalHalfday").ToString
            txtLate.Text = rst("TotalLate").ToString
            txtUndertime.Text = rst("TotalUndertime").ToString
            txtOvertime.Text = rst("TotalOvertime").ToString
            txtAdditional.Text = rst("TotalAdditional").ToString
            txtDeduction.Text = rst("TotalDeduction").ToString
            txtNetGross.Text = rst("NetGross").ToString
            txtNetPay.Text = rst("NetPay").ToString

            If rst("profilepic").ToString <> "" Then
                imgBytes = CType(rst("profilepic"), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                ProfilePic.Image = img
            End If

        End While
        rst.Close()
        ckCurrent.Checked = current
        LoadXgrid("CALL sp_payrollprocesspayslip(" & If(mode.Text = "current", "TRUE,'CURRENT'", "FALSE,'SUMMARY'") & ",'" & payrollcode.Text & "','" & employeeid.Text & "','" & schedulecode.Text & "','" & txtPayrolldate.Text & "')", "sp_payrollprocesspayslip(true,'" & payrollcode.Text & "','" & employeeid.Text & "','" & schedulecode.Text & "','" & txtPayrolldate.Text & "')", Em, Gridview1, Me)
        XgridColCurrency({"Deduction", "Additional"}, Gridview1)
        XgridGeneralSummaryCurrency({"Deduction", "Additional"}, Gridview1)
    End Sub

    Private Sub cmdLoadData_Click(sender As Object, e As EventArgs) Handles cmdLoadData.Click
        Dim report As New rptPayrollPayslip()
        
        com.CommandText = "select * from tblpayrollperiod where payrollcode='" & payrollcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            report.txtPayrollCode.Text = payrollcode.Text
            report.txtPayrollPeriod.Text = rst("datefrom").ToString & " - " & rst("dateto").ToString
        End While
        rst.Close()
        com.CommandText = "select a.*,e.position,e.profilepic " & If(ckCurrent.Checked = True, ",(OtherAdditional+TotalOvertime) as TotalAdditional,(OtherDeduction+sss+philhealth+pagibig+savings+TotalLate+TotalUndertime+if(MonthlyRate=1,TotalAbsent,0)+((rateperday/2) * Halfday)) as TotalDeduction,(OtherAdditional+TotalOvertime) + Gross as NetGross,((OtherAdditional+TotalOvertime) + Gross)-(OtherDeduction+sss+philhealth+pagibig+savings+TotalLate+TotalUndertime+if(MonthlyRate=1,TotalAbsent,0)+(rateperday/2) * Halfday) as NetPay  FROM coffeecup_reports.tblpayrollprocessing", "FROM tblpayrollsummary") & " as a  inner join tblemployees as e on a.employeeid = e.employeeid where a.EmployeeID='" & employeeid.Text & "' and payrollcode='" & payrollcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            report.txtEmployeeName.Text = rst("Fullname").ToString
            report.txtPosition.Text = rst("position").ToString
            report.txtOffice.Text = rst("Office").ToString
            report.txtEmployeeStatus.Text = rst("EmployeeStatus").ToString
            report.txtSalaryRate.Text = rst("SalaryRate").ToString
            report.txtGross.Text = FormatNumber(rst("Gross").ToString, 2)
        End While
        rst.Close()
        report.txtAbsent.Text = txtAbsent.Text
        report.txtHalfDay.Text = txtHalfDay.Text
        report.txtLate.Text = txtLate.Text
        report.txtUndertime.Text = txtUndertime.Text
        report.txtOvertime.Text = txtOvertime.Text
        report.txtAdditional.Text = txtAdditional.Text
        report.txtNetGross.Text = txtNetGross.Text
        report.txtTotalDeduction.Text = txtDeduction.Text
        report.txtNetPay.Text = txtNetPay.Text
        Em.MainView.PaintStyleName = "Web"
        'Em.MainView.ActivePaintStyleName = "Web"
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        'SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        report.ShowRibbonPreviewDialog()
        'SplashScreenManager.CloseForm()
    End Sub

End Class