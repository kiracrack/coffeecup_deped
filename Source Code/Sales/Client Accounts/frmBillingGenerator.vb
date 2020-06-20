Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frmBillingGenerator
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = Keys.F1 Then


        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        txtdateFrom.EditValue = Now
        txtDateTo.EditValue = Now
        LoadGridviewAppearance(GridView2)
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
        '  ExportBillings("pdf")
    End Sub

    'Public Function ExportBillings(ByVal mode As String)
    '    Dim dir As String = ""
    '    Dim fbd As New System.Windows.Forms.FolderBrowserDialog
    '    If fbd.ShowDialog() = DialogResult.OK Then
    '        dir = fbd.SelectedPath
    '        SplitContainerControl2.PanelVisibility = SplitPanelVisibility.Both
    '        Dim detailsFile As StreamWriter = Nothing
    '        ProgressBarControl1.Properties.Step = 1
    '        ProgressBarControl1.Properties.PercentView = True
    '        ProgressBarControl1.Properties.Maximum = GridView2.RowCount
    '        ProgressBarControl1.Properties.Minimum = 0
    '        ProgressBarControl1.Position = 0

    '        For I = 0 To GridView2.RowCount - 1
    '            If ckFilter.Checked = True Then
    '                dst = Nothing
    '                LoadXgrid("select  date_format(tblsalestransaction.datetrn, '%M %d, %Y') as 'Date', invoiceno as 'TRA Number', sum(Total)  as 'Total' from tblsalestransaction inner join tblsalesclientcharges on tblsalestransaction.batchcode = tblsalesclientcharges.batchcode and tblsalesclientcharges.cancelled=0 where tblsalestransaction.cifid='" & GridView2.GetRowCellValue(I, "accountno").ToString() & "' and date_format(tblsalestransaction.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' and tblsalestransaction.cancelled=0 and tblsalestransaction.void=0 and tblsalesclientcharges.verified=1 and tblsalesclientcharges.paymentupdated=0 group by invoiceno order by tblsalestransaction.datetrn asc", "tblsalestransaction", Em, GridView1, Me)
    '                XgridColCurrency({"Total"}, GridView1)
    '                GridView1.BestFitColumns()
    '                XgridColWidth({"Total"}, GridView1, 120)
    '                XgridColAlign({"Date", "TRA Number"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

    '                XgridGroupSummaryCurrency({"Total"}, GridView1)
    '                XgridGeneralSummaryCurrency({"Total"}, GridView1)
    '            Else
    '                dst = Nothing
    '                LoadXgrid("select  date_format(tblsalestransaction.datetrn, '%M %d, %Y') as 'Date', invoiceno as 'TRA Number', productname as 'Product',Quantity,sellprice as 'Unit Cost', chargetotal as 'Charges', distotal as 'Discount', Total from tblsalestransaction inner join tblsalesclientcharges on tblsalestransaction.batchcode = tblsalesclientcharges.batchcode and tblsalesclientcharges.cancelled=0 where tblsalestransaction.cifid='" & GridView2.GetRowCellValue(I, "accountno").ToString() & "' and date_format(tblsalestransaction.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' and tblsalestransaction.cancelled=0 and tblsalestransaction.void=0 and tblsalesclientcharges.verified=1 and tblsalesclientcharges.paymentupdated=0 order by tblsalestransaction.datetrn asc", "tblsalestransaction", Em, GridView1, Me)
    '                XgridColCurrency({"Unit Cost", "Quantity", "Charges", "Discount", "Total"}, GridView1)
    '                GridView1.BestFitColumns()
    '                XgridColWidth({"Total"}, GridView1, 120)
    '                XgridColAlign({"Date", "TRA Number", "Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

    '                XgridGroupSummaryCurrency({"Total"}, GridView1)
    '                XgridGeneralSummaryCurrency({"Total"}, GridView1)
    '            End If


    '            Dim report As New rptBillingStatement()
    '            com.CommandText = "select * from tblclientaccounts where cifid='" & GridView2.GetRowCellValue(I, "accountno").ToString() & "'" : rst = com.ExecuteReader
    '            While rst.Read
    '                report.txtClientName.Text = rst("companyname").ToString
    '                report.txtAddress.Text = rst("compadd").ToString
    '                report.txtContactNumber.Text = rst("telephone").ToString
    '            End While
    '            rst.Close()

    '            report.txtDate.Text = UCase(Format(Now.ToString("MMMM dd, yyyy")))
    '            report.txtStatementDatePeriod.Text = UCase("Period covered from " & txtdateFrom.Text & " To " & txtDateTo.Text)
    '            report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
    '            report.txtStatementHeader.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptBillingHeader.txt").ToString.Replace(vbCrLf, Environment.NewLine)
    '            report.txtStatementFooter.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptBillingFooter.txt").ToString.Replace(vbCrLf, Environment.NewLine)
    '            report.txtStatementFooter1.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptBillingFooter1.txt").ToString.Replace(vbCrLf, Chr(13))
    '            If mode = "pdf" Then
    '                GridView1.ExportToPdf(dir & "\" & RemoveSpecialCharacter(GridView2.GetRowCellValue(I, "Client").ToString()) & ".pdf")
    '            Else
    '                GridView1.ExportToXlsx(dir & "\" & RemoveSpecialCharacter(GridView2.GetRowCellValue(I, "Client").ToString()) & ".xlsx")
    '            End If
    '            ProgressBarControl1.PerformStep()
    '            ProgressBarControl1.Update()
    '        Next


    '        SplitContainerControl2.PanelVisibility = SplitPanelVisibility.Panel1
    '        XtraMessageBox.Show("Billings successfully generated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Function
    Private Sub cmdPrintStatement_Click(sender As Object, e As EventArgs) Handles cmdPrintStatement.Click
        If Globalprintstatementledgertype = True Then
            PrintLedgerType()
        Else
            PrintInvoiceType()
        End If

    End Sub

    Public Sub PrintLedgerType()
        Dim Template As String = Application.StartupPath.ToString & "\Templates\InvoiceLedgerTemplate.xlsx"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Invoice\" & GridView2.GetFocusedRowCellValue("accountno").ToString & "-" & globaluserid & ".xlsx"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        Dim xlApp As Excel._Application
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        xlApp = New Excel.Application
        xlApp.Visible = True
        xlBook = xlApp.Workbooks.Open(SaveLocation)
        xlSheet = xlBook.Sheets(1)

        xlSheet.Cells(2, 1).value = UCase(compname)
        xlSheet.Cells(3, 1).value = compadd
        xlSheet.Cells(4, 1).value = compnumber

        xlSheet.Cells(19, 1).value = globalfullname
        xlSheet.Cells(20, 1).value = StrConv(globaldesignation, VbStrConv.ProperCase)

        xlSheet.Cells(14, 1).value = xlSheet.Cells(14, 1).value.ToString.Replace("[companyname]", UCase(compname))

        xlSheet.Cells(19, 4).value = UCase(CompAproveName)
        xlSheet.Cells(20, 4).value = StrConv(compApproveDesig, VbStrConv.ProperCase)

        com.CommandText = "select * from tblclientaccounts where cifid='" & GridView2.GetFocusedRowCellValue("accountno").ToString & "'" : rst = com.ExecuteReader
        While rst.Read
            xlSheet.Cells(7, 3).value = rst("companyname").ToString
            xlSheet.Cells(8, 3).value = rst("compadd").ToString
            xlSheet.Cells(9, 3).value = rst("telephone").ToString
        End While
        rst.Close()

        Dim StartRow As Integer = 12
        If countqry("tblglaccountledger", "accountno='" & GridView2.GetFocusedRowCellValue("accountno").ToString & "' and cancelled=0 and date_format(datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "'") > 0 Then
            com.CommandText = "select a.trnid, " _
                       + " date_format(a.datetrn, '%M %d, %Y') as 'Date Transaction', " _
                       + " (select itemname from tbltransactioncode where itemcode = a.itemcode) as 'Description', " _
                       + " a.referenceno as 'Reference No.', " _
                       + " a.remarks as 'Remarks', " _
                       + " a.debit as 'Debit (Charges)', " _
                       + " a.credit as 'Credit (Payments)', " _
                       + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tblglaccountledger as b " _
                       + " WHERE b.datetrn <= a.datetrn and b.accountno='" & GridView2.GetFocusedRowCellValue("accountno").ToString & "' and b.journalmode='client-accounts' and b.cleared=1 and b.cancelled=0) AS 'Balance' " _
                       + " FROM `tblglaccountledger` as a where accountno='" & GridView2.GetFocusedRowCellValue("accountno").ToString & "' and a.journalmode='client-accounts' and a.cleared=1 and a.cancelled=0 and " _
                       + " date_format(a.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' order by a.datetrn asc" : rst = com.ExecuteReader
            While rst.Read
                xlSheet.Rows(StartRow).Insert()
                xlSheet.Cells(StartRow, 1).value = rst("Date Transaction").ToString
                xlSheet.Cells(StartRow, 2).value = If(rst("Debit (Charges)").ToString = "0", "", rst("Reference No.").ToString)
                xlSheet.Cells(StartRow, 3).value = rst("Remarks").ToString
                xlSheet.Cells(StartRow, 4).value = If(rst("Debit (Charges)").ToString = "0", "", rst("Debit (Charges)").ToString)
                xlSheet.Cells(StartRow, 5).value = If(rst("Credit (Payments)").ToString = "0", "", rst("Credit (Payments)").ToString)
                xlSheet.Cells(StartRow, 6).value = If(rst("Balance").ToString = "0", "", rst("Balance").ToString)
                StartRow = StartRow + 1
            End While
            rst.Close()
            xlBook.Save()
        Else
            Dim getlasttrndate As String = "" : Dim getBalance As Double = 0
            com.CommandText = "select a.trnid, " _
                     + " date_format(a.datetrn, '%M %d, %Y') as 'Date Transaction', " _
                     + " (select itemname from tbltransactioncode where itemcode = a.itemcode) as 'Description', " _
                     + " a.referenceno as 'Reference No.', " _
                     + " a.remarks as 'Remarks', " _
                     + " a.debit as 'Debit (Charges)', " _
                     + " a.credit as 'Credit (Payments)', " _
                     + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tblglaccountledger as b " _
                     + " WHERE b.datetrn <= a.datetrn and b.accountno='" & GridView2.GetFocusedRowCellValue("accountno").ToString & "' and b.journalmode='client-accounts' and b.cleared=1 and b.cancelled=0) AS 'Balance' " _
                     + " FROM `tblglaccountledger` as a where accountno='" & GridView2.GetFocusedRowCellValue("accountno").ToString & "' and a.journalmode='client-accounts' and a.cleared=1 and a.cancelled=0 and " _
                     + " date_format(a.datetrn, '%Y-%m-%d') = '" & ConvertDate(qrysingledata("datetrn", "datetrn", "tblglaccountledger where accountno='" & GridView2.GetFocusedRowCellValue("accountno").ToString & "' and cancelled=0 order by datetrn desc limit 1")) & "' order by a.datetrn asc" : rst = com.ExecuteReader
            While rst.Read
                getlasttrndate = rst("Date Transaction").ToString
                getBalance = If(rst("Balance").ToString = "0", "", rst("Balance").ToString)
            End While
            rst.Close()

            xlSheet.Rows(StartRow).Insert()
            xlSheet.Cells(StartRow, 1).value = getlasttrndate
            xlSheet.Cells(StartRow, 2).value = ""
            xlSheet.Cells(StartRow, 3).value = "PREVIOUS BALANCE AS OF " & getlasttrndate
            xlSheet.Cells(StartRow, 4).value = ""
            xlSheet.Cells(StartRow, 5).value = ""
            xlSheet.Cells(StartRow, 6).value = getBalance
            StartRow = StartRow + 1
            xlBook.Save()
        End If

    End Sub
    Public Sub PrintInvoiceType()
        Dim Template As String = Application.StartupPath.ToString & "\Templates\InvoiceTemplate.xlsx"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Invoice\" & GridView2.GetFocusedRowCellValue("accountno").ToString & "-" & globaluserid & ".xlsx"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        Dim xlApp As Excel._Application
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        xlApp = New Excel.Application
        xlApp.Visible = True
        xlBook = xlApp.Workbooks.Open(SaveLocation)
        xlSheet = xlBook.Sheets(1)

        xlSheet.Cells(2, 1).value = UCase(compname)
        xlSheet.Cells(3, 1).value = compadd
        xlSheet.Cells(4, 1).value = compnumber

        xlSheet.Cells(18, 1).value = xlSheet.Cells(18, 1).value.ToString.Replace("[companyname]", UCase(compname))

        xlSheet.Cells(23, 1).value = globalfullname
        xlSheet.Cells(24, 1).value = StrConv(globaldesignation, VbStrConv.ProperCase)

        xlSheet.Cells(23, 2).value = UCase(CompAproveName)
        xlSheet.Cells(24, 2).value = StrConv(compApproveDesig, VbStrConv.ProperCase)

        com.CommandText = "select * from tblclientaccounts where cifid='" & GridView2.GetFocusedRowCellValue("accountno").ToString & "'" : rst = com.ExecuteReader
        While rst.Read
            xlSheet.Cells(7, 1).value = "CLIENT NAME: " & rst("companyname").ToString
            xlSheet.Cells(8, 1).value = "ADDRESS: " & rst("compadd").ToString
            xlSheet.Cells(9, 1).value = "CONTACT NUMBER: " & rst("telephone").ToString
        End While
        rst.Close()
        xlSheet.Cells(10, 1).value = "STATEMENT OF ACCOUNTS FOR THE MO. OF " & UCase(Format(txtDateTo.EditValue, "MMMM")) & " " & CDate(txtDateTo.EditValue).Year

        Dim StartRow As Integer = 12
        ' com.CommandText = "select date_format(tblsalestransaction.datetrn, '%M %d, %Y') as 'Date', invoiceno as 'TRA Number', sum(Total)  as 'Total' from tblsalestransaction inner join tblsalesclientcharges on tblsalestransaction.batchcode = tblsalesclientcharges.batchcode and tblsalesclientcharges.cancelled=0 where tblsalestransaction.cifid='" & GridView2.GetFocusedRowCellValue("accountno").ToString & "' and date_format(tblsalestransaction.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' and tblsalestransaction.cancelled=0 and tblsalestransaction.void=0 and tblsalesclientcharges.verified=1 and tblsalesclientcharges.paymentupdated=0 group by invoiceno order by tblsalestransaction.datetrn asc" : rst = com.ExecuteReader
        com.CommandText = "select date_format(datetrn, '%M %d, %Y') as 'Date', invoiceno as 'TRA Number', amount as 'Total'," _
                                    + " paymentrefnumber,(select paymentamount from tblpaymenttransactions where tblpaymenttransactions.trnid=tblsalesclientcharges.paymentrefnumber and cancelled=0 and tblsalesclientcharges.amount>paymentamount) as 'Paymentamount', " _
                                    + " amount-(select paymentamount from tblpaymenttransactions where tblpaymenttransactions.trnid=tblsalesclientcharges.paymentrefnumber and cancelled=0 and tblsalesclientcharges.amount>paymentamount) as 'balance' from  tblsalesclientcharges where accountno='" & GridView2.GetFocusedRowCellValue("accountno").ToString & "' and date_format(datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' and cancelled=0 and verified=1 " _
                                    + " and (paymentupdated=0 or (select paymentamount from tblpaymenttransactions where tblpaymenttransactions.trnid=tblsalesclientcharges.paymentrefnumber and cancelled=0 and tblsalesclientcharges.amount>paymentamount)>0) order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            xlSheet.Rows(StartRow).Insert()
            xlSheet.Cells(StartRow, 1).value = rst("Date").ToString
            xlSheet.Cells(StartRow, 2).value = rst("TRA Number").ToString & If(Val(rst("balance").ToString) > 0, " - Partial " & FormatNumber(Val(rst("Paymentamount").ToString), 2), "")
            xlSheet.Cells(StartRow, 3).value = If(Val(rst("balance").ToString) > 0, Val(rst("balance").ToString), rst("Total").ToString)
            StartRow = StartRow + 1
        End While
        rst.Close()
        xlBook.Save()
    End Sub
    Private Sub cmdShowBilling_Click(sender As Object, e As EventArgs) Handles cmdShowBilling.Click
        Try
            dst = Nothing
            LoadXgrid("select accountno, (select companyname from tblclientaccounts where cifid=tblsalesclientcharges.accountno) as 'Client', sum(amount) as 'Total' from  tblsalesclientcharges where  date_format(datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' and cancelled=0 and verified=1 " _
                                    + " and (paymentupdated=0 or if(paymentrefnumber<>'',(amount-(select paymentamount from tblpaymenttransactions where tblpaymenttransactions.trnid=tblsalesclientcharges.paymentrefnumber and cancelled=0)),amount) > 0 ) group by client order by datetrn asc", "tblsalesclientcharges", Em2, GridView2, Me)
            'LoadXgrid("Select cifid as accountno, COMPANYNAME as 'Client', ifnull((select sum(debit)-sum(credit) from tblglaccountledger where accountno=cifid and cleared=1 and cancelled=0),0) as 'Balance' from tblclientaccounts where ifnull((select sum(debit)-sum(credit) from tblglaccountledger where accountno=cifid and cleared=1 and cancelled=0),0) > 0 order by COMPANYNAME asc ", "tblsalestransaction", Em2, GridView2, Me)
            XgridColCurrency({"Total"}, GridView2)
            GridView2.BestFitColumns()
            XgridColWidth({"Total"}, GridView2, 120)
            XgridHideColumn({"accountno"}, GridView2)
            XgridGroupSummaryCurrency({"Total"}, GridView2)
            XgridGeneralSummaryCurrency({"Total"}, GridView2)

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMS.Message & vbCrLf _
                            & "Details:" & errMS.StackTrace,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ' ExportBillings("xlsx")
    End Sub

    Private Sub StatementOfAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatementOfAccountToolStripMenuItem.Click
        frmStatementOfAccount.mode.Text = "view"
        frmStatementOfAccount.accountno.Text = GridView2.GetFocusedRowCellValue("accountno").ToString
        frmStatementOfAccount.txtClient.Text = GridView2.GetFocusedRowCellValue("Client").ToString
        frmStatementOfAccount.txtClient.Properties.ReadOnly = True
        frmStatementOfAccount.txtdateFrom.EditValue = CDate(txtdateFrom.EditValue).AddDays(-1)
        frmStatementOfAccount.txtDateTo.EditValue = txtDateTo.EditValue
        frmStatementOfAccount.Show(Me)
    End Sub

    Private Sub ViewInformationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewInformationToolStripMenuItem1.Click
        frmBillingStatement.accountno.Text = GridView2.GetFocusedRowCellValue("accountno").ToString
        frmBillingStatement.txtClient.Text = GridView2.GetFocusedRowCellValue("Client").ToString
        frmBillingStatement.txtClient.Properties.ReadOnly = True
        frmBillingStatement.txtdateFrom.EditValue = CDate(txtdateFrom.EditValue).AddDays(-1)
        frmBillingStatement.txtDateTo.EditValue = txtDateTo.EditValue
        frmBillingStatement.Show(Me)
    End Sub

End Class