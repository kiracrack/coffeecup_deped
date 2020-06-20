Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetPayrollEmployeeType
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmSetPayrollEmployeeType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadEmployeePosition()
    End Sub
    Public Sub LoadEmployeePosition()
        LoadToComboBox("description", "tblemployeetype", txtEmployeeType, True)
    End Sub

    Private Sub txtOfficeName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtEmployeeType.SelectedValueChanged
        positioncode.Text = qrysingledata("code", "code", "where description='" & txtEmployeeType.Text & "'", "tblemployeetype")
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        If txtEmployeeType.Text = "" Then
            XtraMessageBox.Show("Please select employee type", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmployeeType.Focus()
            Exit Sub
        End If
        frmPayrollEmployeeManagement.setEmployeeType(positioncode.Text)
    End Sub
End Class