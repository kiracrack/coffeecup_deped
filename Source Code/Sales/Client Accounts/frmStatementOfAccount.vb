Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frmStatementOfAccount
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
        LoadGridviewAppearance(GridView1)
        txtdateFrom.EditValue = Now
        txtDateTo.EditValue = Now
        If accountno.Text <> "" Then
            FilterAccountLedger()
        End If
      
        If mode.Text = "view" Then
            txtFilterName.Visible = False
            If countqry("tblglaccountledger", "accountno='" & accountno.Text & "'") > 0 Then
                txtdateFrom.EditValue = CDate(Now.AddDays(-(Val(qrysingledata("countdt", "DATEDIFF(current_date,datetrn) as countdt", "where accountno='" & accountno.Text & "' order by datetrn desc limit 1", "tblglaccountledger")) + 1)))
                txtDateTo.Properties.MinValue = txtdateFrom.EditValue

            End If
        Else
            txtFilterName.Visible = True
        End If

        If LCase(globaluser) = "root" Then
            CancelTransactionToolStripMenuItem.Visible = True
            cmdSetAdvanceTime.Visible = True
        Else
            CancelTransactionToolStripMenuItem.Visible = False
            cmdSetAdvanceTime.Visible = False
        End If
    End Sub


    Public Sub FilterAccountLedger()
        Try
            LoadXgrid("select a.trnid, " _
                        + " date_format(a.datetrn, '%Y-%m-%d %r') as 'Date Transaction', " _
                        + " (select itemname from tbltransactioncode where itemcode = a.itemcode) as 'Description', " _
                        + " a.referenceno as 'Reference No.', " _
                        + " a.remarks as 'Remarks', " _
                        + " a.debit as 'Debit (Charges)', " _
                        + " a.credit as 'Credit (Payments)', " _
                        + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tblglaccountledger as b " _
                        + " WHERE b.datetrn <= a.datetrn and b.accountno='" & accountno.Text & "' and b.journalmode='client-accounts' and b.cleared=1 and b.cancelled=0) AS 'Balance' " _
                        + " FROM `tblglaccountledger` as a where accountno='" & accountno.Text & "' and a.journalmode='client-accounts' and a.cleared=1 and a.cancelled=0 and date_format(a.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' order by a.datetrn asc", "tblglaccountledger", Em, GridView1, Me)

            GridView1.Focus()
            GridView1.BestFitColumns()
            GridView1.Columns("Description").ColumnEdit = MemoEdit
            XgridHideColumn({"trnid"}, GridView1)
            GridView1.Columns("Description").Width = 300
            XgridColAlign({"Date Transaction", "Reference No."}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Debit (Charges)", "Credit (Payments)", "Balance"}, GridView1)
            GridView1.BestFitColumns()
            XgridColWidth({"Debit (Charges)", "Credit (Payments)"}, GridView1, 120)
            XgridColWidth({"Balance"}, GridView1, 180)
            ShowDetails()
            Em.Refresh() : GridView1.RefreshData()

            GridView1.Columns("Balance").Summary.Clear()
            GridView1.Columns("Balance").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Balance", "Total Due " & txtCurrentBalance.Text)
            CType(GridView1.Columns("Balance").View, GridView).OptionsView.ShowFooter = True


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

    Public Sub ShowDetails()
        com.CommandText = "select sum(debit) as ttldebit, sum(credit) as ttlcredit, sum(debit)- sum(credit)  as 'balance' from tblglaccountledger where accountno='" & accountno.Text & "'  and cleared=1 and cancelled=0 " : rst = com.ExecuteReader
        While rst.Read
            txtTotalDebit.Text = Format(Val(rst("ttldebit").ToString), "n")
            txtTotalCredit.Text = Format(Val(rst("ttlcredit").ToString), "n")
            txtCurrentBalance.Text = Format(Val(rst("balance").ToString), "n")
        End While
        rst.Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        GridView1.ShowFindPanel()
    End Sub

    Private Sub txtdatetrn_EditValueChanged(sender As Object, e As EventArgs) Handles txtdateFrom.EditValueChanged
        If accountno.Text <> "" Then
            FilterAccountLedger()
            txtDateTo.Properties.MinValue = txtdateFrom.EditValue
        End If
    End Sub

    Private Sub txtDateTo_EditValueChanged(sender As Object, e As EventArgs) Handles txtDateTo.EditValueChanged
        If accountno.Text <> "" Then
            FilterAccountLedger()

        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintLedgerType()
        'Dim report As New rptStatementOfAccount()
        'Dim duedate As String = ""

        'report.txtStatementHeader.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptStatementHeader.txt").ToString.Replace(vbCrLf, Environment.NewLine)
        'report.txtStatementFooter.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptStatementFooter.txt").ToString.Replace(vbCrLf, Environment.NewLine)
        'report.txtStatementFooter1.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptStatementFooter1.txt").ToString.Replace(vbCrLf, Environment.NewLine)

        'Dim lasdatetrn As String = qrysingledata("dt", "date_format(datetrn,'%Y-%m-%d') as 'dt'", "where accountno='" & accountno.Text & "' and verified=1 and cancelled=0 and paymentupdated=0 and date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txtDateTo.Text) & "' order by datetrn asc limit 1;", "tblsalesclientcharges")
        'com.CommandText = "select *,date_format(cast(case when duetype='DAYS' then date_format('" & lasdatetrn & "' + interval duevalue day,'%Y-%m-%d') " _
        '                                  + " when duetype='WEEK' then DATE_ADD('" & lasdatetrn & "', INTERVAL ((7+duevalue) - DAYOFWEEK('" & lasdatetrn & "')) DAY) " _
        '                                  + " when duetype='MONTH' then concat(date_format('" & lasdatetrn & "' + interval 1 month,'%Y-%m'),'-',duevalue) " _
        '                                  + " end as date),'%M %d, %Y') as 'Due' from tblclientaccounts where cifid='" & accountno.Text & "'" : rst = com.ExecuteReader
        'While rst.Read
        '    report.txtClientName.Text = rst("companyname").ToString
        '    report.txtAddress.Text = rst("compadd").ToString
        '    report.txtContactNumber.Text = rst("telephone").ToString

        '    If rst("Due").ToString = "" Then
        '        report.txtDueDate.Visible = False
        '        report.lblDuedate.Visible = False
        '    Else
        '        report.txtDueDate.Visible = True
        '        report.lblDuedate.Visible = True
        '        report.txtDueDate.Text = rst("Due").ToString
        '    End If

        'End While
        'rst.Close()

        'report.txtDate.Text = Format(Now.ToString("MMMM dd, yyyy"))
        'report.txtStatementDatePeriod.Text = "Date Period from " & CDate(txtdateFrom.EditValue).ToString("MM/dd/yyyy") & " to " & CDate(txtDateTo.EditValue).ToString("MM/dd/yyyy")
        'report.txtPreviousBalance.Text = FormatNumber(qrysingledata("prevbalance", "(select ifnull(sum(debit)-sum(credit),0) from tblglaccountledger as b where b.trnid  <  a.trnid and b.accountno = a.accountno order by trnid desc limit 1 ) as 'prevbalance'", "where date_format(a.datetrn,'%Y-%m-%d') <= '" & ConvertDate(txtDateTo.Text) & "' and a.accountno='" & accountno.Text & "'  and a.cleared=1 and a.cancelled=0 order by a.datetrn asc limit 1;", "`tblglaccountledger` as a "), 2)
        'report.txtBalanceDue.Text = FormatNumber(qrysingledata("currbalance", "sum(a.debit)-sum(a.credit) as 'currbalance'", "where date_format(a.datetrn,'%Y-%m-%d') <= '" & ConvertDate(txtDateTo.Text) & "' and a.accountno='" & accountno.Text & "' and a.cleared=1 and a.cancelled=0 order by a.trnid asc limit 1;", "`tblglaccountledger` as a "), 2)
        'report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))

        'Me.WindowState = FormWindowState.Minimized
        'report.ShowRibbonPreviewDialog()
        'Me.WindowState = FormWindowState.Normal
    End Sub
    Public Sub PrintLedgerType()
        Dim Template As String = Application.StartupPath.ToString & "\Templates\InvoiceLedgerTemplate.xlsx"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Invoice\" & accountno.Text & "-" & globaluserid & ".xlsx"
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

        com.CommandText = "select * from tblclientaccounts where cifid='" & accountno.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            xlSheet.Cells(7, 3).value = rst("companyname").ToString
            xlSheet.Cells(8, 3).value = rst("compadd").ToString
            xlSheet.Cells(9, 3).value = rst("telephone").ToString
        End While
        rst.Close()

        Dim StartRow As Integer = 12
        If countqry("tblglaccountledger", "accountno='" & accountno.Text & "' and cancelled=0 and date_format(datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "'") > 0 Then
            com.CommandText = "select a.trnid, " _
                       + " date_format(a.datetrn, '%M %d, %Y') as 'Date Transaction', " _
                       + " (select itemname from tbltransactioncode where itemcode = a.itemcode) as 'Description', " _
                       + " a.referenceno as 'Reference No.', " _
                       + " a.remarks as 'Remarks', " _
                       + " a.debit as 'Debit (Charges)', " _
                       + " a.credit as 'Credit (Payments)', " _
                       + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tblglaccountledger as b " _
                       + " WHERE b.datetrn <= a.datetrn and b.accountno='" & accountno.Text & "' and b.journalmode='client-accounts' and b.cleared=1 and b.cancelled=0) AS 'Balance' " _
                       + " FROM `tblglaccountledger` as a where accountno='" & accountno.Text & "' and a.journalmode='client-accounts' and a.cleared=1 and a.cancelled=0 and " _
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
            com.CommandText = "select a.*, " _
                     + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tblglaccountledger as b " _
                     + " WHERE b.datetrn <= a.datetrn and b.accountno='" & accountno.Text & "' and b.journalmode='client-accounts' and b.cleared=1 and b.cancelled=0) AS 'Balance' " _
                     + " FROM `tblglaccountledger` as a where accountno='" & accountno.Text & "' and a.journalmode='client-accounts' and a.cleared=1 and a.cancelled=0 and " _
                     + " date_format(a.datetrn, '%Y-%m-%d') = '" & ConvertDate(qrysingledata("datetrn", "datetrn", "tblglaccountledger where accountno='" & accountno.Text & "' and cancelled=0 order by datetrn desc limit 1")) & "' order by a.datetrn asc" : rst = com.ExecuteReader
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
    Public Function ReadFile(ByVal path As String)
        Me.Cursor = Cursors.WaitCursor
        Dim oReader As StreamReader
        oReader = New StreamReader(path, True)
        Me.Cursor = Cursors.Default
        Return oReader.ReadToEnd
    End Function



    Private Sub RefreshLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshLedgerToolStripMenuItem.Click
        FilterAccountLedger()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If txtClient.Text = "" And GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Please select account!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = txtClient.Text & " (" & ConvertDate(txtdateFrom.Text) & " to " & ConvertDate(txtDateTo.Text) & ").xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            GridView1.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub CancelTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelTransactionToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to cancel selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblglaccountledger set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterAccountLedger()
            XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles cmdSetAdvanceTime.Click
        If XtraMessageBox.Show("Are you sure you want to update selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblglaccountledger set datetrn=ADDTIME(datetrn,1) where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterAccountLedger()
            XtraMessageBox.Show("Transaction successfully updated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub txtFilterName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFilterName.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtFilterName.Text = "" Or txtFilterName.Text = "%" Then Exit Sub
            If countqry("tblclientaccounts", "companyname='" & rchar(txtFilterName.Text) & "'") = 0 Then
                ComboBoxFilter(txtFilterName.Text, True)
                txtFilterName.ShowPopup()
                Exit Sub
            Else
                accountno.Text = qrysingledata("cifid", "cifid", "tblclientaccounts where companyname='" & rchar(txtFilterName.Text) & "'")
                If countqry("tblglaccountledger", "accountno='" & accountno.Text & "'") > 0 Then
                    txtdateFrom.EditValue = CDate(Now.AddDays(-(Val(qrysingledata("countdt", "DATEDIFF(current_date,datetrn) as countdt", "where accountno='" & accountno.Text & "' order by datetrn desc limit 1", "tblglaccountledger")) + 1)))
                    txtDateTo.Properties.MinValue = txtdateFrom.EditValue

                End If
                FilterAccountLedger()
            End If
        End If
    End Sub
    Public Function ComboBoxFilter(ByVal filter As String, ByVal mode As Boolean)
        Dim Coll As ComboBoxItemCollection = txtFilterName.Properties.Items
        If mode = True Then
            Coll.Clear()
            com.CommandText = "Select companyname from tblclientaccounts where companyname like '%" & rchar(txtFilterName.Text) & "%' order by companyname asc limit 100"
            rst = com.ExecuteReader
            Coll.BeginUpdate()
            Try
                While rst.Read
                    Coll.Add(rst("companyname"))
                End While
                rst.Close()
            Finally
                Coll.EndUpdate()
            End Try
        End If
        Return Coll
    End Function
End Class