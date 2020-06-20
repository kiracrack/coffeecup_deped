Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI

Public Class frmPrintCheck
    Private Sub frmCancelRequest_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        txtCheckPayee.Text = ""
        txtAmount.Text = "0"
        txtCheckDate.Text = ""
    End Sub

    Private Sub frmCancelRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

    End Sub
   
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim report As New rptCheckPrint()
        report.txtCheckPayee.Text = txtCheckPayee.Text
        report.txtCheckDate.Text = txtCheckDate.Text
        report.txtNumberInWords.Text = txtNumberInWords.Text
        report.txtCheckAmount.Text = txtAmount.Text
        report.ShowRibbonPreviewDialog()
    End Sub

   
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        Me.Close()
    End Sub
End Class