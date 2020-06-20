Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class frmPayrollEmployeeManagement
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()

        ElseIf keyData = (Keys.Control) + (Keys.P) Then
            cmdPrint.PerformClick()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPayrollEmployeeManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        LoadGridviewAppearance(grid_office)
        LoadGridviewAppearance(gv_EmployeeType)
        LoadGridviewAppearance(gridview1)
        LoadOffice()
        loadEmployeeType()
        FilterEmployee()
        
    End Sub

    Private Sub ResetAttendancePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAttendancePasswordToolStripMenuItem.Click
        frmChangeAttendancePassword.txtEmployeeID.Text = gridview1.GetFocusedRowCellValue("Employee ID").ToString
        frmChangeAttendancePassword.Show()
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Select' from tblcompoffice order by officename", "tblcompoffice", txtOffice, grid_office, Me)
        grid_office.Columns("officeid").Visible = False
    End Sub
    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
        FilterEmployee()
    End Sub

    Public Sub loadEmployeeType()
        LoadXgridLookupEdit("select code, description as 'Select' from tblemployeetype order by description", "tblemployeetype", txtEmployeeType, gv_EmployeeType, Me)
        gv_EmployeeType.Columns("code").Visible = False
    End Sub
    Private Sub txtEmployeeType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeType.EditValueChanged
        On Error Resume Next
        typecode.Text = txtEmployeeType.Properties.View.GetFocusedRowCellValue("code").ToString
        FilterEmployee()
    End Sub

    Private Sub ckViewAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckViewAllType.CheckedChanged, ckViewAllOffice.CheckedChanged
        FilterEmployee()
    End Sub
    Public Sub FilterEmployee()
        Try
            LoadXgrid("select employeeid as 'Employee ID',(select officename from tblcompoffice where officeid=tblemployees.officeid) as 'Office',(select departmentname from tblcompdepartments where depid=tblemployees.depid) as 'Department', Fullname, Position, (select description from tblemployeetype where code = tblemployees.employeetypecode) as 'Employee Status', (select description from tblemployeelevel where code=tblemployees.emplevel) as 'Level', (select ratepermonth from tblpayrollbasicrate where code = tblemployees.positioncode) as 'Basic Rate', (select description from tblpayrollshiftsettings where shiftcode=tblemployees.shiftcode) as 'Shift Type', date_format(birthdate,'%Y-%m-%d') as 'Birth Date', Nationality, Religion, civilstatus as 'Civil Status',date_format(datehired,'%Y-%m-%d') as 'Date Hired',date_format(dateregular,'%Y-%m-%d') as 'Date Regular', Actived, Resigned " & If(ckResigned.Checked = True, ",date_format(dateresigned,'%M %d, %Y') as 'Date Resigned'", "") & " from tblemployees where resigned=" & ckResigned.CheckState & " and actived=" & ckActived.CheckState & " " & If(ckViewAllType.Checked = True, "", " and employeetypecode='" & typecode.Text & "'") & If(ckViewAllOffice.Checked = True, "", " and officeid='" & officeid.Text & "'") & " order by lastname,firstname asc", "tblemployees", Em, gridview1, Me)
            'LoadXgrid("CALL sp_payrollshowemployee(" & If(ckViewAllType.Checked = True, "", " and employeetypecode='" & typecode.Text & "'") & If(ckViewAllOffice.Checked = True, "", " and officeid='" & officeid.Text & "'") & ")", "CALL sp_payrollshowemployee(" & If(ckViewAllType.Checked = True, "", " and employeetypecode='" & typecode.Text & "'") & If(ckViewAllOffice.Checked = True, "", " and officeid='" & officeid.Text & "'") & ")", Em, gridview1, Me)
            XgridColAlign({"Employee ID", "Birth Date", "Level", "Date Hired", "Date Regular"}, gridview1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Basic Rate"}, gridview1)
            XgridGeneralSummaryCurrency({"Basic Rate"}, gridview1)
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

  
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        FilterEmployee()
    End Sub

#Region "GRID SECURITY FILTER"

    Private Sub Em_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmPayrollEmployeeInformation.txtEmployeeid.Text = gridview1.GetFocusedRowCellValue("Employee ID").ToString : frmPayrollEmployeeInformation.mode.Text = "edit"
            If frmPayrollEmployeeInformation.Visible = True Then
                frmPayrollEmployeeInformation.Focus()
            Else
                frmPayrollEmployeeInformation.Show()
            End If
        End If
    End Sub

    Private Sub Em_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseDown
        MenuFilter()
    End Sub

    Private Sub Em_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseUp
        MenuFilter()
    End Sub

    Private Sub Em_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Em.Move
        MenuFilter()
    End Sub

    Public Sub MenuFilter()
        On Error Resume Next
        If CBool(gridview1.GetFocusedRowCellValue("Actived")) = True Then
            cmdActiveInactive.Text = "Set employee inactived"
        Else
            cmdActiveInactive.Text = "Set employee actived"
        End If
    End Sub

#End Region

#Region "UPDATE EMPLOYEE RECORD"
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmPayrollEmployeeInformation.txtEmployeeid.Text = gridview1.GetFocusedRowCellValue("Employee ID").ToString : frmPayrollEmployeeInformation.mode.Text = "edit"
        If frmPayrollEmployeeInformation.Visible = True Then
            frmPayrollEmployeeInformation.Focus()
        Else
            frmPayrollEmployeeInformation.Show()
        End If
    End Sub

    Private Sub cmdSetCompany_Click(sender As Object, e As EventArgs) Handles cmdSetCompany.Click
        frmSetPayrollOffice.Show(Me)
    End Sub

    Public Function setCompany(ByVal office As String, ByVal department As String)
        For I = 0 To gridview1.SelectedRowsCount - 1
            com.CommandText = "update tblemployees set officeid='" & office & "', depid='" & department & "' where employeeid='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Employee ID").ToString & "'" : com.ExecuteNonQuery()
        Next
        FilterEmployee()
        Return 0
    End Function

    Private Sub cmdSetPosition_Click(sender As Object, e As EventArgs) Handles cmdSetPosition.Click
        frmSetPayrollPosition.Show(Me)
    End Sub

    Public Function setPosition(ByVal positionCode As String)
        For I = 0 To gridview1.SelectedRowsCount - 1
            com.CommandText = "update tblemployees set positioncode='" & positionCode & "' where employeeid='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Employee ID").ToString & "'" : com.ExecuteNonQuery()
        Next
        FilterEmployee()
        Return 0
    End Function

    Public Function setlevel(ByVal emplevel As String)
        For I = 0 To gridview1.SelectedRowsCount - 1
            com.CommandText = "update tblemployees set emplevel='" & emplevel & "' where employeeid='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Employee ID").ToString & "'" : com.ExecuteNonQuery()
        Next
        FilterEmployee()
        Return 0
    End Function

    Private Sub cmdSetEmployeeType_Click(sender As Object, e As EventArgs) Handles cmdSetEmployeeType.Click
        frmSetPayrollEmployeeStatus.Show(Me)
    End Sub

    Public Function setEmployeeType(ByVal typecode As String)
        For I = 0 To gridview1.SelectedRowsCount - 1
            com.CommandText = "update tblemployees set employeetypecode='" & typecode & "' where employeeid='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Employee ID").ToString & "'" : com.ExecuteNonQuery()
        Next
        FilterEmployee()
        Return 0
    End Function

    Private Sub cmdChangeShift_Click(sender As Object, e As EventArgs) Handles cmdChangeShift.Click
        frmSetPayrollShift.Show(Me)
    End Sub

    Public Function setShift(ByVal typecode As String)
        For I = 0 To gridview1.SelectedRowsCount - 1
            com.CommandText = "update tblemployees set shiftcode='" & typecode & "' where employeeid='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Employee ID").ToString & "'" : com.ExecuteNonQuery()
        Next
        FilterEmployee()
        Return 0
    End Function

    Private Sub cmdResigned_Click(sender As Object, e As EventArgs) Handles cmdResigned.Click
        If CBool(gridview1.GetFocusedRowCellValue("Resigned").ToString) = True Then
            If XtraMessageBox.Show("Are you sure you want to tag as hired selected employee? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tblemployees set resigned=0 where employeeid='" & gridview1.GetFocusedRowCellValue("Employee ID").ToString & "'" : com.ExecuteNonQuery()
                FilterEmployee()
                XtraMessageBox.Show("Employee successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            frmSetPayrollResigned.Show(Me)
        End If
    End Sub
    Public Function setResigned(ByVal effectivitydate As Date)
        For I = 0 To gridview1.SelectedRowsCount - 1
            com.CommandText = "update tblemployees set resigned=1, dateresigned='" & ConvertDate(effectivitydate) & "' where employeeid='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Employee ID").ToString & "'" : com.ExecuteNonQuery()
        Next
        FilterEmployee()
        Return 0
    End Function

#End Region
  
    Private Sub cmdActiveInactive_Click(sender As Object, e As EventArgs) Handles cmdActiveInactive.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If CBool(gridview1.GetFocusedRowCellValue("Actived")) = True Then
                com.CommandText = "update tblemployees set actived=0 where employeeid='" & gridview1.GetFocusedRowCellValue("Employee ID").ToString & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblemployees set actived=1 where employeeid='" & gridview1.GetFocusedRowCellValue("Employee ID").ToString & "'" : com.ExecuteNonQuery()
            End If
            FilterEmployee()
        End If
    End Sub
 
    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintGeneralReport(Me.Text, Me.Text, gridview1, Me)
    End Sub

    
    Private Sub ckActived_CheckedChanged(sender As Object, e As EventArgs) Handles ckActived.CheckedChanged
        FilterEmployee()
    End Sub

    Private Sub ckResigned_CheckedChanged(sender As Object, e As EventArgs) Handles ckResigned.CheckedChanged
        FilterEmployee()
    End Sub

    Private Sub SetEmployeeLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetEmployeeLevelToolStripMenuItem.Click
        frmSetEmployeeLevel.Show(Me)
    End Sub
End Class