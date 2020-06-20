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
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        If txtOfficeName.Text = "" Then
            XtraMessageBox.Show("Please select office name", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOfficeName.Focus()
            Exit Sub
        End If
        frmPayrollEmployeeManagement.setCompany(officeid.Text)
    End Sub
End Class