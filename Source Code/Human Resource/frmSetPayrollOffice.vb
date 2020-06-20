Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetPayrollOffice
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmSetPayrollCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadClientGroup()
    End Sub
    Public Sub LoadClientGroup()
        LoadToComboBox("officename", "tblcompoffice", txtOfficeName, True)
    End Sub

    Private Sub txtOfficeName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtOfficeName.SelectedValueChanged
        officeid.Text = qrysingledata("officeid", "officeid", "where officename='" & txtOfficeName.Text & "'", "tblcompoffice")
        LoadToComboBox("departmentname", "tblcompdepartments where officeid='" & officeid.Text & "'", txtDepartments, True)
    End Sub
    Private Sub txtDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtDepartments.SelectedIndexChanged
        depid.Text = qrysingledata("depid", "depid", "where officeid='" & officeid.Text & "' and departmentname='" & txtDepartments.Text & "'", "tblcompdepartments")
    End Sub
    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        If txtOfficeName.Text = "" Then
            XtraMessageBox.Show("Please select office name", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOfficeName.Focus()
            Exit Sub
        End If
        frmPayrollEmployeeManagement.setCompany(officeid.Text, depid.Text)
    End Sub

    
End Class