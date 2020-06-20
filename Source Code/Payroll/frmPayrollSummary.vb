Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmPayrollSummary
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPayrollSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gridview1)
        LoadPayrollCode()
    End Sub
    Public Sub LoadPayrollCode()
        LoadXgridLookupEdit("select payrollcode as 'Payroll Code', date_format(datefrom,'%Y-%m-%d') as 'Period From', date_format(dateto,'%Y-%m-%d') as 'Period To' from tblpayrollperiod where approved=1 order by datefrom asc", "tblpayrollperiod", txtPayrollCode, gv_scheduletype, Me)
        gv_scheduletype.BestFitColumns()
        gv_scheduletype.Columns("Payroll Code").Width = 120

    End Sub

    Private Sub txtPayrollCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayrollCode.EditValueChanged
        On Error Resume Next
        payrollcode.Text = txtPayrollCode.Properties.View.GetFocusedRowCellValue("Payroll Code").ToString

    End Sub

    Private Sub cmdLoadData_Click(sender As Object, e As EventArgs) Handles cmdLoadData.Click
        FilterEmployee()
    End Sub

    Public Sub FilterEmployee()
        Try
            LoadXgrid("call sp_payrollprocessing(FALSE,'SUMMARY','" & txtPayrollCode.Text & "','" & txtPayrollCode.Properties.View.GetFocusedRowCellValue("Period To").ToString & "')", "call sp_payrollprocessing(TRUE,'CURRENT','" & txtPayrollCode.Text & "','" & txtPayrollCode.Properties.View.GetFocusedRowCellValue("Period To").ToString & "')", Em, gridview1, Me)
            XgridHideColumn({"payrollcode", "EmployeeID"}, gridview1)
            XgridColAlign({"EmployeeStatus", "Position", "TotalWorkingDays", "RenderedDays", "Absent", "HalfDay", "LateCount", "UndertimeCount", "OvertimeCount"}, gridview1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"TotalLate", "TotalUndertime", "TotalOvertime", "TotalAbsent", "TotalHalfday", "Tax", "SSS", "Philhealth", "Pagibig", "Savings", "OtherDeduction", "OtherAdditional", "Gross", "TotalDeduction", "TotalAdditional", "NetGross", "NetPay"}, gridview1)
            gridview1.BestFitColumns()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Query:" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
        Catch errMS As Exception
            XtraMessageBox.Show("Query:" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
        End Try
    End Sub

    Private Sub cmdClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmPayrollAttendanceView.payrollcode.Text = payrollcode.Text
        frmPayrollAttendanceView.employeeid.Text = gridview1.GetFocusedRowCellValue("EmployeeID").ToString
        frmPayrollAttendanceView.Show(Me)
    End Sub

    Private Sub ViewDeductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDeductionToolStripMenuItem.Click
        frmPayrollProcessPayslip.mode.Text = "" : frmPayrollProcessPayslip.mode.Text = "summary"
        frmPayrollProcessPayslip.payrollcode.Text = txtPayrollCode.Text
        frmPayrollProcessPayslip.employeeid.Text = gridview1.GetFocusedRowCellValue("EmployeeID").ToString
        frmPayrollProcessPayslip.Show(Me)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintPayroll.ItemClick
        If txtPayrollCode.Text = "" And gridview1.RowCount = 0 Then
            XtraMessageBox.Show("Please select payrollcode to continue!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim report As New rptPayrollSummary()
        report.Landscape = True
        report.PaperKind = System.Drawing.Printing.PaperKind.A2
        report.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        report.txtPayrollCode.Text = txtPayrollCode.Text
        com.CommandText = "select * from tblpayrollperiod where payrollcode='" & payrollcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            report.txtPayrollPeriod.Text = rst("datefrom").ToString & " - " & rst("dateto").ToString
            report.txtRemarks.Text = rst("remarks").ToString
        End While
        rst.Close()
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        report.ShowRibbonPreviewDialog()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportSummary.ItemClick
        If txtPayrollCode.Text = "" And gridview1.RowCount = 0 Then
            XtraMessageBox.Show("Please select payrollcode to continue!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = txtPayrollCode.Text & ".xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            gridview1.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportDeduction.ItemClick
        If txtPayrollCode.Text = "" And gridview1.RowCount = 0 Then
            XtraMessageBox.Show("Please select payrollcode to continue!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = txtPayrollCode.Text & "-deduction.xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            LoadXgrid("SELECT PayrollCode, (select fullname from tblemployees where employeeid =tblpayrollpayslip.employeeid) as 'Employee Name', Description, datecover as 'Date Cover',Amount, Remarks  FROM `tblpayrollpayslip` where payrollcode='" & txtPayrollCode.Text & "' and deduction=1 order by description, (select fullname from tblemployees where employeeid =tblpayrollpayslip.employeeid) asc", "tblpayrollpayslip", GridControl1, GridView2, Me)
            XgridColCurrency({"Amount"}, GridView2)
            XgridColAlign({"Date Cover"}, GridView2, DevExpress.Utils.HorzAlignment.Center)
            GridView2.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdExportAdditional_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportAdditional.ItemClick
        If txtPayrollCode.Text = "" And gridview1.RowCount = 0 Then
            XtraMessageBox.Show("Please select payrollcode to continue!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = txtPayrollCode.Text & "-additional.xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            LoadXgrid("SELECT PayrollCode, (select fullname from tblemployees where employeeid =tblpayrollpayslip.employeeid) as 'Employee Name', Description, datecover as 'Date Cover', Amount, Remarks  FROM `tblpayrollpayslip` where payrollcode='" & txtPayrollCode.Text & "' and deduction=0 order by description, (select fullname from tblemployees where employeeid =tblpayrollpayslip.employeeid) asc", "tblpayrollpayslip", GridControl1, GridView2, Me)
            XgridColCurrency({"Amount"}, GridView2)
            XgridColAlign({"Date Cover"}, GridView2, DevExpress.Utils.HorzAlignment.Center)
            GridView2.ExportToXlsx(saveFileDialog1.FileName)

            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class