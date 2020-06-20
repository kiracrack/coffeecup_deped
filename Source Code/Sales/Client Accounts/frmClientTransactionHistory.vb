Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid

Public Class frmClientTransactionHistory
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
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

        txtdateFrom.EditValue = Now
        txtDateTo.EditValue = Now
        LoadGridviewAppearance(gridview1)
  
        FilterTransaction()
    End Sub

    Public Sub FilterTransaction()
        Try
            dst = Nothing
            If accountno.Text = "" Then Exit Sub
            Dim dateQuery As String = ""
            If ckViewCash.Checked = True Then
                If ckViewAllTransaction.Checked = True Then
                    dateQuery = ""
                Else
                    dateQuery = "  datetrn between '" & ConvertDate(txtdateFrom.Text) & "' and '" & ConvertDate(txtDateTo.Text) & "' and "
                End If

                LoadXgrid("select date_format(datetrn, '%Y-%m-%d') as 'Date',  productname as 'Product',Quantity,originalsellprice as 'Original Selling Price', sellprice as 'Selling Price', chargetotal as 'Charges', distotal as 'Discount', Total  " _
                                      + " from tblsalestransaction  where cifid='" & accountno.Text & "'  and " & dateQuery & " cancelled=0 order by datetrn asc", "tblsalestransaction", Em, gridview1, Me)
                XgridColCurrency({"Selling Price", "Quantity", "Original Selling Price", "Charges", "Discount", "Total"}, gridview1)
                gridview1.BestFitColumns()
                XgridColWidth({"Total"}, gridview1, 120)
                XgridColAlign({"Date", "Quantity"}, gridview1, DevExpress.Utils.HorzAlignment.Center)

                XgridGroupSummaryCurrency({"Total"}, gridview1)
                XgridGeneralSummaryCurrency({"Total"}, gridview1)
            Else
                If ckViewAllTransaction.Checked = True Then
                    dateQuery = ""
                Else
                    dateQuery = "  tblsalesclientchargesitem.datetrn between '" & ConvertDate(txtdateFrom.Text) & "' and '" & ConvertDate(txtDateTo.Text) & "' and "
                End If

                LoadXgrid("select date_format(tblsalesclientchargesitem.datetrn, '%Y-%m-%d') as 'Date', tblsalesclientcharges.invoiceno as 'Invoice No.', productname as 'Product',Quantity,originalsellprice as 'Original Selling Price', sellprice as 'Selling Price', chargetotal as 'Charges', distotal as 'Discount', tblsalesclientchargesitem.Total, tblsalesclientcharges.Verified,tblsalesclientcharges.Cancelled,paymentupdated as Paid " _
                                       + " from tblsalesclientchargesitem inner join tblsalesbatch on tblsalesclientchargesitem.batchcode = tblsalesbatch.batchcode  inner join tblsalesclientcharges on tblsalesclientchargesitem.batchcode = tblsalesclientcharges.batchcode where tblsalesclientchargesitem.cifid='" & accountno.Text & "'  and " & dateQuery & " tblsalesclientchargesitem.cancelled=0 order by tblsalesclientchargesitem.datetrn asc", "tblsalesclientchargesitem", Em, gridview1, Me)
                XgridColCurrency({"Selling Price", "Original Selling Price", "Quantity", "Charges", "Discount", "Total"}, gridview1)
                gridview1.BestFitColumns()
                XgridColWidth({"Total"}, gridview1, 120)
                XgridColAlign({"Date", "Invoice No.", "Quantity"}, gridview1, DevExpress.Utils.HorzAlignment.Center)

                XgridGroupSummaryCurrency({"Total"}, gridview1)
                XgridGeneralSummaryCurrency({"Total"}, gridview1)
            End If
           
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