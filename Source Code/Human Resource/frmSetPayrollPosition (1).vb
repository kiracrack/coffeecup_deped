Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetPayrollPosition
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmSetPayrollPosition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadEmployeePosition()
    End Sub
    Public Sub LoadEmployeePosition()
        LoadToComboBox("description", "tblpayrollposition", txtPosition, True)
    End Sub

    Private Sub txtOfficeName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtPosition.SelectedValueChanged
        positioncode.Text = qrysingledata("code", "code", "where description='" & txtPosition.Text & "'", "tblpayrollposition")
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        If txtPosition.Text = "" Then
            XtraMessageBox.Show("Please select position", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Exit Sub
        End If
        frmPayrollEmployeeManagement.setPosition(positioncode.Text)
    End Sub
End Class