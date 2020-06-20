Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPayrollAddingDedadd
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
        LoadData()
        LoadPayrollCode()
        LoadDedAdd()
        LoadGridviewAppearance(Gridview1)
        LoadGridviewAppearance(gv_payrollcode)
        LoadGridviewAppearance(gv_employee)
        LoadGridviewAppearance(gv_dedAddType)
        txtDateTransaction.EditValue = CDate(Now.ToShortDateString)
    End Sub

    Public Sub LoadPayrollCode()
        LoadXgridLookupEdit("select payrollcode as 'Payroll Code', date_format(datefrom,'%Y-%m-%d') as 'Period From', date_format(dateto,'%Y-%m-%d') as 'Period To' from tblpayrollperiod where approved=0 order by datefrom asc", "tblpayrollperiod", txtPayrollCode, gv_payrollcode, Me)
        gv_payrollcode.BestFitColumns()
        gv_payrollcode.Columns("Payroll Code").Width = 120
    End Sub
    Private Sub txtPayrollCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayrollCode.EditValueChanged
        On Error Resume Next
        LoadEmployee()
        LoadData()
    End Sub

    Public Sub LoadEmployee()
        LoadXgridLookupSearch("select employeeid, fullname as 'Select' from tblemployees where actived=1 and employeeid in (select distinct employeeid from tblpayrollattendance where payrollcode='" & txtPayrollCode.Text & "') order by fullname", "tblemployees", txtEmployee, gv_employee, Me)
        gv_employee.Columns("employeeid").Visible = False
    End Sub
    Private Sub txtEmployee_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployee.EditValueChanged
        On Error Resume Next
        employeeid.Text = txtEmployee.Properties.View.GetFocusedRowCellValue("employeeid").ToString
         
    End Sub
    Public Sub LoadDedAdd()
        LoadXgridLookupEdit("select code, description as 'Select' from tblpayrolldedaddtype inner join tblpayrollsettings on deduction=" & radDedAdd.EditValue & " and tblpayrolldedaddtype.code not in (tblpayrollsettings.defaultsss,tblpayrollsettings.defaultpagibig,tblpayrollsettings.defaultphilhealth,tblpayrollsettings.defaulttax,tblpayrollsettings.defaultsavings)  order by description asc;", "tblpayrolldedaddtype", txtDedAddType, gv_dedAddType, Me)
        gv_dedAddType.Columns("code").Visible = False
    End Sub
    Private Sub txtdedRange_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDedAddType.EditValueChanged
        On Error Resume Next
        dedaddcode.Text = txtDedAddType.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub

    Public Sub LoadData()
        LoadXgrid("select id, (select fullname from tblemployees where employeeid=tblpayrolldedaddsummary.employeeid) as 'Employee Name', " _
                            + " description as '" & If(radDedAdd.EditValue = True, "Deduction", "Additional") & " Type', Remarks, date_format(datecover,'%Y-%m-%d') as 'Date Cover', Amount from tblpayrolldedaddsummary where payrollcode='" & txtPayrollCode.Text & "' and deduction=" & radDedAdd.EditValue & "", "tblpayrolldedaddsummary", Em, Gridview1, Me)
        Gridview1.Columns("id").Visible = False
        XgridColCurrency({"Amount"}, Gridview1)
        XgridColAlign({"Date Cover"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Public Sub ClearField()
        employeeid.Text = ""
        txtEmployee.Properties.DataSource = Nothing
        txtEmployee.Text = ""
        LoadEmployee()
        txtRemarks.Text = "Remarks.."
        txtAmount.Text = "0.00"
    End Sub

    Private Sub cmdAttendanceSettings_Click(sender As Object, e As EventArgs) Handles cmdAttendanceSettings.Click
        If txtPayrollCode.Text = "" Then
            XtraMessageBox.Show("Please select payroll code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPayrollCode.Focus()
            Exit Sub
        ElseIf txtEmployee.Text = "" Then
            XtraMessageBox.Show("Please select employee!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmployee.Focus()
            Exit Sub
        ElseIf txtDedAddType.Text = "" Then
            XtraMessageBox.Show("Please select " & If(radDedAdd.EditValue = True, "Deduction", "Additional") & " type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDedAddType.Focus()
            Exit Sub
        
        ElseIf Val(CC(txtAmount.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter amount!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmount.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblpayrolldedaddsummary set payrollcode = '" & txtPayrollCode.Text & "', " _
                                  + " employeeid='" & employeeid.Text & "', " _
                                  + " dedaddcode='" & dedaddcode.Text & "', " _
                                  + " description = '" & rchar(txtDedAddType.Text) & "', " _
                                  + " remarks = '" & If(txtRemarks.Text = "Remarks..", "", rchar(txtRemarks.Text)) & "', " _
                                  + " deduction = " & radDedAdd.EditValue & ", " _
                                  + " amount='" & Val(CC(txtAmount.Text)) & "', " _
                                  + " datecover='" & ConvertDate(txtDateTransaction.EditValue) & "'" : com.ExecuteNonQuery()

            ClearField() : LoadData() : txtEmployee.Focus() : txtEmployee.ShowPopup()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadData()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radDedAdd.SelectedIndexChanged
        LoadDedAdd()
        lblTitle.Text = "Add " & If(radDedAdd.EditValue = True, "Deduction", "Additional")
        lblsubject.Text = "Select " & If(radDedAdd.EditValue = True, "Deduction", "Additional") & " Type"
        LoadData()
    End Sub

    Private Sub ActiveInactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdActiveInactive.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "Delete from tblpayrolldedaddsummary where id='" & Gridview1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            LoadData()
        End If
    End Sub

    Private Sub txtRemarks_GotFocus(sender As Object, e As EventArgs) Handles txtRemarks.GotFocus
        If txtRemarks.Text = "Remarks.." Then
            txtRemarks.Text = ""
        End If
    End Sub

    Private Sub txtRemarks_LostFocus(sender As Object, e As EventArgs) Handles txtRemarks.LostFocus
        If txtRemarks.Text = "" Then
            txtRemarks.Text = "Remarks.."
        End If
    End Sub
End Class