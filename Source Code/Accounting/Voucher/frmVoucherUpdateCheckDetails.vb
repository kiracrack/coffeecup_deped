Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmVoucherUpdateCheckDetails
    Public ConfirmVoucher As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmVoucherOtherExpense_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmConfirmedVoucherProcessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtCheckDate.EditValue = CDate(Now)
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If MessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tbldisbursementvoucher set checkno='" & txtCheckNumber.Text & "', checkdate='" & ConvertDate(txtCheckDate.EditValue) & "', checkamount='" & Val(CC(txtCheckAmount.Text)) & "'  where voucherno='" & voucherno.Text & "'" : com.ExecuteNonQuery()
            frmVoucherSummary.FilterVoucherSummary()
            XtraMessageBox.Show("Check successfully updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub


    Private Sub cmdCheckPrint_Click(sender As Object, e As EventArgs) Handles cmdCheckPrint.Click
        frmPrintCheck.txtCheckPayee.Text = "*** " & txtClaimant.Text & " ***"
        frmPrintCheck.txtAmount.Text = "*** " & txtCheckAmount.Text & " ***"
        frmPrintCheck.txtCheckDate.Text = "*** " & CDate(txtCheckDate.EditValue).ToString("MMMM dd, yyyy") & " ***"
        frmPrintCheck.txtNumberInWords.Text = "*** " & ConvertCurrencyToEnglish(Val(CC(txtCheckAmount.Text))) & " ***"
        frmPrintCheck.ShowDialog(Me)
    End Sub
End Class