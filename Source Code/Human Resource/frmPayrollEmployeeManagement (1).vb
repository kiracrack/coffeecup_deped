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
        LoadOffice()
        loadEmployeeType()
        FilterEmployee()
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
            LoadXgrid("select employeeid as 'Employee ID',(select officename from tblcompoffice where officeid=tblemployees.officeid) as 'Office', Fullname,(select description from tblemployeetype where code = tblemployees.employeetypecode) as 'Employee Type', (select description from tblpayrollposition where code = tblemployees.positioncode) as 'Position', date_format(birthdate,'%Y-%m-%d') as 'Birth Date', Nationality, Religion, civilstatus as 'Civil Status' from tblemployees where resigned=0 " & If(ckViewAllType.Checked = True, "", " and employeetypecode='" & typecode.Text & "'") & If(ckViewAllOffice.Checked = True, "", " and officeid='" & officeid.Text & "'") & " order by lastname,firstname asc", "tblemployees", Em, gridview1, Me)
            XgridColAlign({"Employee ID", "Birth Date"}, gridview1, DevExpress.Utils.HorzAlignment.Center)

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

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmPayrollEmployeeInformation.txtEmployeeid.Text = gridview1.GetFocusedRowCellValue("Employee ID").ToString : frmPayrollEmployeeInformation.mode.Text = "edit"
        frmPayrollEmployeeInformation.Show()
    End Sub

    Private Sub cmdSetCompany_Click(sender As Object, e As EventArgs) Handles cmdSetCompany.Click
        frmSetPayrollOffice.Show(Me)
    End Sub

    Public Function setCompany(ByVal office As String)
        For I = 0 To gridview1.SelectedRowsCount - 1
            com.CommandText = "update tblemployees set officeid='" & office & "' where employeeid='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Employee ID").ToString & "'" : com.ExecuteNonQuery()
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

    Private Sub cmdSetEmployeeType_Click(sender As Object, e As EventArgs) Handles cmdSetEmployeeType.Click
        frmSetPayrollEmployeeType.Show(Me)
    End Sub

    Public Function setEmployeeType(ByVal typecode As String)
        For I = 0 To gridview1.SelectedRowsCount - 1
            com.CommandText = "update tblemployees set employeetypecode='" & typecode & "' where employeeid='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Employee ID").ToString & "'" : com.ExecuteNonQuery()
        Next
        FilterEmployee()
        Return 0
    End Function

   
End Class