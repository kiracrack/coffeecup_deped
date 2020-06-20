Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class frmPayrollProcessing
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
 
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPayrollProcessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gridview1)
        LoadToComboBox("description", "tblemployeelevel", txtLevel, True)
        LoadPayrollCode()
    End Sub

    Private Sub txtOfficeName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtLevel.SelectedValueChanged
        emplevel.Text = qrysingledata("code", "code", "where description='" & txtLevel.Text & "'", "tblemployeelevel")
        FilterEmployee()
    End Sub

    Public Sub LoadPayrollCode()
        LoadXgridLookupEdit("select payrollcode as 'Payroll Code', date_format(datefrom,'%Y-%m-%d') as 'Period From', date_format(dateto,'%Y-%m-%d') as 'Period To',schedulecode from tblpayrollperiod where approved=0 order by datefrom asc", "tblpayrollperiod", txtPayrollCode, gv_scheduletype, Me)
        gv_scheduletype.Columns("schedulecode").Visible = False
        gv_scheduletype.BestFitColumns()
        gv_scheduletype.Columns("Payroll Code").Width = 120
        
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridview1.RowCellStyle
        Dim View As GridView = sender
        If View.GetRowCellDisplayText(e.RowHandle, View.Columns("Approved")).ToString = "1" Then
            e.Appearance.ForeColor = DefaultForeColor
        Else
            If View.GetRowCellDisplayText(e.RowHandle, View.Columns("Checked")).ToString = "1" Then
                e.Appearance.ForeColor = Color.Green
            Else
                e.Appearance.ForeColor = Color.Red
            End If
        End If
    End Sub
    Private Sub txtPayrollCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayrollCode.EditValueChanged
        On Error Resume Next
        payrollcode.Text = txtPayrollCode.Properties.View.GetFocusedRowCellValue("Payroll Code").ToString
        schedulecode.Text = txtPayrollCode.Properties.View.GetFocusedRowCellValue("schedulecode").ToString
        txtDateFrom.Text = txtPayrollCode.Properties.View.GetFocusedRowCellValue("Period From").ToString
        txtDateTo.Text = txtPayrollCode.Properties.View.GetFocusedRowCellValue("Period To").ToString
    End Sub

    Private Sub cmdLoadData_Click(sender As Object, e As EventArgs) Handles cmdLoadData.Click
        FilterEmployee()
    End Sub

    Public Sub FilterEmployee()
        Try
            com.CommandText = "call sp_payrollprocessing(TRUE,'CURRENT','" & txtPayrollCode.Text & "','" & txtPayrollCode.Properties.View.GetFocusedRowCellValue("Period To").ToString & "')" : com.ExecuteNonQuery()
            LoadXgrid("SELECT EmployeeID,ScheduleCode,Office,Department,Fullname,EmployeeStatus,BasicRate,TotalWorkingDays,RenderedDays,Absent,HalfDay,LateCount,TotalLate,UndertimeCount,TotalUndertime,OvertimeCount,TotalOvertime,TotalAbsent,TotalHalfday,SSS,Philhealth,Pagibig,Savings,OtherDeduction,OtherAdditional,Gross,(OtherDeduction+sss+philhealth+pagibig+savings+TotalLate+TotalUndertime+TotalAbsent+TotalHalfDay) as TotalDeduction,(OtherAdditional+TotalOvertime) as TotalAdditional,(OtherAdditional+TotalOvertime) + Gross as NetGross,((OtherAdditional+TotalOvertime) + Gross)-(OtherDeduction+sss+philhealth+pagibig+savings+TotalLate+TotalUndertime+TotalAbsent+TotalHalfday) as NetPay, Checked, Approved,'                         ' as 'Employee Signature' from coffeecup_reports.tblpayrollprocessing " & If(CheckEdit1.Checked = True, "", " where EmpLevel='" & emplevel.Text & "'  ") & " order by Office,Department,Fullname asc", "tblpayrollprocessing", Em, gridview1, Me)
            XgridHideColumn({"ScheduleCode", "EmployeeID", "Approved", "Checked"}, gridview1)
            XgridColAlign({"EmployeeStatus", "BasicRate", "TotalWorkingDays", "RenderedDays", "Absent", "HalfDay", "LateCount", "UndertimeCount", "OvertimeCount"}, gridview1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"TotalLate", "TotalUndertime", "TotalOvertime", "TotalAbsent", "TotalHalfday", "SSS", "Philhealth", "Pagibig", "Savings", "OtherDeduction", "OtherAdditional", "Gross", "TotalDeduction", "TotalAdditional", "NetGross", "NetPay"}, gridview1)
            XgridGeneralSummaryCurrency({"TotalLate", "TotalUndertime", "TotalOvertime", "TotalAbsent", "TotalHalfday", "SSS", "Philhealth", "Pagibig", "Savings", "OtherDeduction", "OtherAdditional", "Gross", "TotalDeduction", "TotalAdditional", "NetGross", "NetPay"}, gridview1)
            XgridGroupSummaryCurrency({"TotalLate", "TotalUndertime", "TotalOvertime", "TotalAbsent", "TotalHalfday", "SSS", "Philhealth", "Pagibig", "Savings", "OtherDeduction", "OtherAdditional", "Gross", "TotalDeduction", "TotalAdditional", "NetGross", "NetPay"}, gridview1)
            gridview1.BestFitColumns()
            CheckApprovedAttendance()

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

   
    Public Sub CheckApprovedAttendance()
        If countqry("tblpayrollattendance inner join tblemployees on tblpayrollattendance.employeeid = tblemployees.employeeid and resigned=0 and actived=1", "payrollcode='" & txtPayrollCode.Text & "' and approved=0") > 0 Then
            cmdApprove.Visible = False
        Else
            cmdApprove.Visible = True
        End If
    End Sub
    Private Sub cmdClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmPayrollAttendance.payrollcode.Text = payrollcode.Text
        frmPayrollAttendance.employeeid.Text = gridview1.GetFocusedRowCellValue("EmployeeID").ToString
        frmPayrollAttendance.Show(Me)
    End Sub

    Private Sub ViewDeductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDeductionToolStripMenuItem.Click
        frmPayrollProcessPayslip.mode.Text = "" : frmPayrollProcessPayslip.mode.Text = "current"
        frmPayrollProcessPayslip.payrollcode.Text = txtPayrollCode.Text
        frmPayrollProcessPayslip.employeeid.Text = gridview1.GetFocusedRowCellValue("EmployeeID").ToString
        frmPayrollProcessPayslip.schedulecode.Text = gridview1.GetFocusedRowCellValue("ScheduleCode").ToString
        frmPayrollProcessPayslip.txtPayrolldate.Text = txtPayrollCode.Properties.View.GetFocusedRowCellValue("Period To").ToString
        frmPayrollProcessPayslip.Show(Me)
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE FROM tblpayrollpayslip where payrollcode='" & payrollcode.Text & "';" : com.ExecuteNonQuery()
            com.CommandText = "DELETE FROM tblpayrollpayremittance where payrollcode='" & payrollcode.Text & "';" : com.ExecuteNonQuery()
            For I = 0 To gridview1.RowCount - 1
                com.CommandText = "CALL sp_payrollprocesspayslip(TRUE,'UPLOAD','" & payrollcode.Text & "','" & gridview1.GetRowCellValue(I, "EmployeeID").ToString & "','" & schedulecode.Text & "','" & txtPayrollCode.Properties.View.GetFocusedRowCellValue("Period To").ToString & "')" : com.ExecuteNonQuery()
            Next
            com.CommandText = "call sp_payrollprocessing(TRUE,'UPLOAD','" & txtPayrollCode.Text & "','" & txtPayrollCode.Properties.View.GetFocusedRowCellValue("Period To").ToString & "')" : com.ExecuteNonQuery()
            com.CommandText = "DELETE FROM tblpayrollpayslip where payrollcode='" & txtPayrollCode.Text & "' and amount=0;" : com.ExecuteNonQuery()
            com.CommandText = "DELETE FROM tblpayrollpayremittance where payrollcode='" & txtPayrollCode.Text & "' and employee_share=0 and employer_share=0;" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblpayrollperiod set approved=1, approvedby='" & globaluserid & "', dateapproved=current_timestamp" : com.ExecuteNonQuery()
           
            XtraMessageBox.Show("Payroll " & txtPayrollCode.Text & " successfully pproved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
 
    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
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

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
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
            LoadXgrid("CALL sp_payrollprocesspayslip(FALSE,'EXPORT_DEDUCTION','" & payrollcode.Text & "','','" & schedulecode.Text & "','')", "sp_payrollprocesspayslip(FALSE,'EXPORT_DEDUCTION','" & payrollcode.Text & "','','" & schedulecode.Text & "','')", GridControl1, GridView2, Me)
            XgridColCurrency({"Amount"}, GridView2)
            GridView2.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
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
            LoadXgrid("CALL sp_payrollprocesspayslip(FALSE,'EXPORT_ADDITIONAL','" & payrollcode.Text & "','','" & schedulecode.Text & "','')", "sp_payrollprocesspayslip(FALSE,'EXPORT_ADDITIONAL','" & payrollcode.Text & "','','" & schedulecode.Text & "','')", GridControl1, GridView2, Me)
            XgridColCurrency({"Amount"}, GridView2)
            GridView2.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtLevel.Enabled = False
        Else
            txtLevel.Enabled = True
        End If
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        PrintDatagridview(If(CheckEdit1.Checked = True, "ALL EMPLOYEES", txtLevel.Text) & "</br>" & txtPayrollCode.Text, "PAYROLL SUMMARY (" & txtPayrollCode.Text & ")", "Period Covered: " & txtDateFrom.Text & " - " & txtDateTo.Text, gridview1, Me)
    End Sub
End Class