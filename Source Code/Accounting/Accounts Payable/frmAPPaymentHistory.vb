Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid

Public Class frmAPPaymentHistory
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = (Keys.Control) + Keys.P Then
            ' printreport()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClientPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

        txtdateFrom.EditValue = Now
        txtDateTo.EditValue = Now
        LoadGridviewAppearance(gridview1)

        FilterTransaction()
    End Sub

    Public Sub FilterTransaction()
        Try
            If accountno.Text = "" Then Exit Sub
            Dim dateQuery As String = ""

            If ckViewAllTransaction.Checked = True Then
                dateQuery = ""
            Else
                dateQuery = " and b.voucherdate between '" & ConvertDate(txtdateFrom.Text) & "' and '" & ConvertDate(txtDateTo.Text) & "' "
            End If
            dst = Nothing
            LoadXgrid("select b.voucherno as 'Voucher No.',date_format(b.voucherdate,'%Y-%m-%d') as 'Date', case when `check`=1 then 'Check Payment' when cash=1 then 'Cash Payment' when ca=1 then 'Cash Advance'  end as 'Clasification', b.Amount, (select accountname from tblbankaccounts where bankcode=b.sourcefund) as 'Source Fund',`Check`, b.CheckNo as 'Check No.',date_format(b.CheckDate,'%Y-%m-%d') as 'Check Date', b.Note, date_format(b.datetrn,'%Y-%m-%d %r') as 'Date Posted' from tbldisbursementvoucher as b  where b.cleared=1 and b.vendorid='" & accountno.Text & "'    " & dateQuery & " order by b.datetrn;", "tbldisbursementvoucher", Em, gridview1, Me)

            XgridColAlign({"Voucher No.", "Date", "Clasification", "Source Fund", "Check No.", "Check Date", "Date Posted"}, gridview1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Amount"}, gridview1)
            gridview1.BestFitColumns()
            XgridColWidth({"Amount"}, gridview1, 120)
           
            XgridGeneralSummaryCurrency({"Amount"}, gridview1)


        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMS.Message & vbCrLf _
                            & "Details:" & errMS.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        FilterTransaction()
    End Sub

    Private Sub ckCash_CheckedChanged(sender As Object, e As EventArgs) Handles ckViewAllTransaction.CheckedChanged
        If ckViewAllTransaction.Checked = True Then
            txtdateFrom.Enabled = False
            txtDateTo.Enabled = False
        Else
            txtdateFrom.Enabled = True
            txtDateTo.Enabled = True
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ExportGridToExcel(Me.Text + "(" + If(ckViewAllTransaction.Checked = True, "all transaction", ConvertDate(txtdateFrom.EditValue) + "-" + ConvertDate(txtDateTo.EditValue)) + ")", gridview1)
    End Sub

    Private Sub accountno_EditValueChanged(sender As Object, e As EventArgs) Handles accountno.EditValueChanged
        FilterTransaction()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintDatagridview(txtsuppliername.Text, Me.Text, If(ckViewAllTransaction.Checked = True, "All Transaction", "Date " & txtdateFrom.Text + " - " + txtDateTo.Text), gridview1, Me)
    End Sub
End Class