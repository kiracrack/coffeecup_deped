Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmVerifiedCheckDeposit
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCheckingAccounts()
       
    End Sub

    Public Sub LoadCheckingAccounts()
        LoadXgridLookupEdit("select bankcode, accountname as 'Account Name'  " _
                           + " from tblbankaccounts where bankaccounts=1", "tblbankaccounts", txtChargeFrom, gridDepositTo, Me)

        gridDepositTo.Columns("bankcode").Visible = False
        gridDepositTo.SelectRow(1)
    End Sub

    Private Sub txtDueFrom_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChargeFrom.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtChargeFrom.Properties.View.FocusedRowHandle.ToString)
        creditAccount.Text = txtChargeFrom.Properties.View.GetFocusedRowCellValue("bankcode").ToString()
        txtChargeFrom.Text = txtChargeFrom.Properties.View.GetFocusedRowCellValue("Account Name").ToString()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtChargeFrom.Text = "" Then
            XtraMessageBox.Show("Please select bank accounts to deposit? ", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChargeFrom.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmTransactionClearing.validatingcheckdeposit(creditAccount.Text)
            Me.Close()
        End If
    End Sub
End Class