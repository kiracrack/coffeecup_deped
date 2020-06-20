Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetEmployeeLevel
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
        LoadToComboBox("description", "tblemployeelevel", txtLevel, True)
    End Sub

    Private Sub txtOfficeName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtLevel.SelectedValueChanged
        positioncode.Text = qrysingledata("code", "code", "where description='" & txtLevel.Text & "'", "tblemployeelevel")
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        If txtLevel.Text = "" Then
            XtraMessageBox.Show("Please select level", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLevel.Focus()
            Exit Sub
        End If
        frmPayrollEmployeeManagement.setlevel(positioncode.Text)
    End Sub
End Class