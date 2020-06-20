Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid

Public Class frmClientPaymentHistory
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
                dateQuery = " and datetrn between '" & ConvertDate(txtdateFrom.Text) & "' and '" & ConvertDate(txtDateTo.Text) & "' "
            End If
            dst = Nothing
            LoadXgrid("select trnid as 'Reference No', totalamount as 'Total Amount', " _
                            + " ifnull((select amount from tblsalescashpayment where batchcode = tblpaymenttransactions.trnid),0) as 'Cash Payment', " _
                            + " ifnull((select sum(amount) from tblsaleschecktransaction where referenceno = tblpaymenttransactions.trnid),0) as 'Check Payment', " _
                            + " ifnull((select sum(amount) from tblsalescardtransaction where referenceno = tblpaymenttransactions.trnid),0) as 'Card Payment', " _
                            + " ifnull((select sum(amount) from tblsalesdepositpaymenttransaction where batchcode = tblpaymenttransactions.trnid and cancelled=0),0) as 'Deposit Payment', " _
                            + " if(ifnull((select sum(amount) from tblsalescashpayment where batchcode = tblpaymenttransactions.trnid and cancelled=0),0) +ifnull((select sum(amount) from tblsaleschecktransaction where referenceno = tblpaymenttransactions.trnid and cancelled=0),0) +ifnull((select sum(amount) from tblsalescardtransaction where referenceno = tblpaymenttransactions.trnid and cancelled=0),0) +ifnull((select sum(amount) from tblsalesdepositpaymenttransaction where batchcode = tblpaymenttransactions.trnid and cancelled=0),0)=0,paymentamount, " _
                            + " ifnull((select sum(amount) from tblsalescashpayment where batchcode = tblpaymenttransactions.trnid and cancelled=0),0) + " _
                            + " ifnull((select sum(amount) from tblsaleschecktransaction where referenceno = tblpaymenttransactions.trnid and cancelled=0),0) + " _
                            + " ifnull((select sum(amount) from tblsalescardtransaction where referenceno = tblpaymenttransactions.trnid and cancelled=0),0) + " _
                            + " ifnull((select sum(amount) from tblsalesdepositpaymenttransaction where batchcode = tblpaymenttransactions.trnid and cancelled=0),0)) as 'Total Payment',datetrn as 'Date Payment',(select fullname from tblaccounts where accountid=tblpaymenttransactions.trnby) as 'Posted By' " _
                             + " from tblpaymenttransactions where accountno='" & accountno.Text & "' and cancelled=0 " & dateQuery & " order by datetrn;", "tblpaymenttransactions", Em, gridview1, Me)

            XgridColCurrency({"Total Amount", "Cash Payment", "Check Payment", "Card Payment", "Deposit Payment", "Total Payment"}, gridview1)
            gridview1.BestFitColumns()
            XgridColWidth({"Total Amount", "Cash Payment", "Check Payment", "Card Payment", "Deposit Payment", "Total Payment"}, gridview1, 120)
            XgridColAlign({"Reference No"}, gridview1, DevExpress.Utils.HorzAlignment.Center)

            XgridGeneralSummaryCurrency({"Total Payment"}, gridview1)


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
End Class