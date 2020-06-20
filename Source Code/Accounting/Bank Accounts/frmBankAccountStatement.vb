Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO

Public Class frmBankAccountStatement
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

        LoadGridviewAppearance(gridview1)
        txtdateFrom.EditValue = Format(Now)
        txtDateTo.EditValue = Format(Now)
        LoadClientInfo()
       
    End Sub
    Public Sub LoadClientInfo()
        Dim showZeroAccount As String = ""
        If CheckEdit1.Checked = True Then
            showZeroAccount = " "
        Else
            showZeroAccount = "and bankcode in (select accountno from tblglaccountledger where journalmode='bank-accounts'  and cleared=1 and cancelled=0  group by accountno having (sum(credit)-sum(debit)) > 0)  "
        End If
        LoadXgridLookupSearch("SELECT bankcode, accountname as 'Bank Account' from tblbankaccounts where (bankaccounts=1 or cashaccount=1) " & showZeroAccount & " order by accountname asc", "tblbankaccounts", txtBankAccountName, gridClient, Me)
        gridClient.Columns("bankcode").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBankAccountName.EditValueChanged
        On Error Resume Next
        accountno.Text = txtBankAccountName.Properties.View.GetFocusedRowCellValue("bankcode").ToString()
        If accountno.Text <> "" Then
            txtdateFrom.EditValue = CDate(Now.AddDays(-(Val(qrysingledata("countdt", "DATEDIFF(current_date,datetrn) as countdt", "where accountno='" & accountno.Text & "' order by datetrn desc limit 1", "tblglaccountledger")) + 1)))
            txtDateTo.Properties.MinValue = txtdateFrom.EditValue
            FilterAccountLedger()
        End If
    End Sub

    Public Sub FilterAccountLedger()
        Try
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            LoadXgrid("select a.trnid, " _
                        + " date_format(a.datetrn, '%Y-%m-%d %r') as 'Date Transaction', " _
                        + " lcase(ifnull((select itemname from tbltransactioncode where itemcode = a.itemcode),(select itemname from tblglitem where itemcode = a.itemcode))) as 'Description', " _
                        + " referenceno as 'Reference No.', " _
                        + " Remarks, " _
                        + " a.credit as 'Credit', " _
                        + " a.debit as 'Debit', " _
                        + " (SELECT COALESCE(credit,0)-SUM(COALESCE(debit,0)) FROM tblglaccountledger as b " _
                        + " WHERE b.datetrn <= a.datetrn and b.accountno='" & accountno.Text & "' and b.cleared=1 and b.cancelled=0) AS 'Balance' " _
                        + " FROM `tblglaccountledger` as a where accountno='" & accountno.Text & "' and a.cleared=1 and a.cancelled=0 and date_format(a.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' order by a.datetrn asc", "tblglaccountledger", Em, GridView1, Me)

            GridView1.Focus()
            GridView1.Columns("Remarks").AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            ' GridView1.Columns("Description").ColumnEdit = MemoEdit
            GridView1.Columns("Remarks").ColumnEdit = MemoEdit

            XgridHideColumn({"trnid"}, GridView1)
            GridView1.BestFitColumns()
            XgridColAlign({"Reference No.", "Date Transaction"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Debit", "Credit", "Balance"}, GridView1)
            GridView1.BestFitColumns()
            GridView1.Columns("Remarks").Width = 500
            'XgridColWidth({"Description"}, GridView1, 300)
            XgridColWidth({"Debit", "Credit", "Balance"}, GridView1, 120)
            ShowDetails()
            Em.Refresh() : GridView1.RefreshData()
            SplashScreenManager.CloseForm()
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

    Public Sub ShowDetails()
        com.CommandText = "select sum(debit) as ttldebit, sum(credit) as ttlcredit, sum(credit)-sum(debit)  as 'balance' from tblglaccountledger where accountno='" & accountno.Text & "' and cleared=1  and cancelled=0" : rst = com.ExecuteReader
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
        gridview1.ShowFindPanel()
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

    Public Function ReadFile(ByVal path As String)
        Me.Cursor = Cursors.WaitCursor
        Dim oReader As StreamReader
        oReader = New StreamReader(path, True)
        Me.Cursor = Cursors.Default
        Return oReader.ReadToEnd
    End Function

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        LoadClientInfo()
    End Sub

    Private Sub RefreshLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshLedgerToolStripMenuItem.Click
        FilterAccountLedger()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs)
        If XtraMessageBox.Show("Are you sure you want to cancel selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblglaccountledger set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterAccountLedger()
            XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If txtBankAccountName.Text = "" And GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Please select account!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = txtBankAccountName.Text & " (" & ConvertDate(txtdateFrom.Text) & " to " & ConvertDate(txtDateTo.Text) & ").xlsx"
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
End Class