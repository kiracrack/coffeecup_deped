Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetPayrollResigned
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmSetPayrollResigned_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtEffectivityDate.EditValue = Now
    End Sub
     
    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        frmPayrollEmployeeManagement.setResigned(txtEffectivityDate.EditValue)
    End Sub
End Class