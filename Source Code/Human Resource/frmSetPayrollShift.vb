Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetPayrollShift
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmSetPayrollShift_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadShift()
    End Sub
    Public Sub LoadShift()
        LoadToComboBox("description", "tblpayrollshiftsettings", txtPosition, True)
    End Sub

    Private Sub txtOfficeName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtPosition.SelectedValueChanged
        code.Text = qrysingledata("shiftcode", "shiftcode", "where description='" & txtPosition.Text & "'", "tblpayrollshiftsettings")
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        If txtPosition.Text = "" Then
            XtraMessageBox.Show("Please select position", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Exit Sub
        End If
        frmPayrollEmployeeManagement.setShift(code.Text)
    End Sub
End Class