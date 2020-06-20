Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO

Public Class frmAPAccountsPayableStatement
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
 
        txtdateFrom.EditValue = Format(Now.AddDays(-(Val(qrysingledata("countdt", "DATEDIFF(current_date,datetrn) as countdt", "where accountno='" & accountno.Text & "' order by datetrn desc limit 1", "tblglaccountledger")) + 1)))
        txtDateTo.Properties.MinValue = txtdateFrom.EditValue
        FilterAccountLedger()
       
    End Sub

    Public Sub FilterAccountLedger()
        Try
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            LoadXgrid("select a.trnid, " _
                        + " date_format(a.datetrn, '%Y-%m-%d %r') as 'Date Transaction', " _
                        + " (select itemname from tbltransactioncode where itemcode = a.itemcode) as 'Description', " _
                        + " if(referenceno='', '', concat(' #',referenceno)) as 'Reference No.', " _
                        + " Remarks, " _
                        + " a.debit as 'Charges', " _
                        + " a.credit as 'Payment', " _
                        + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tblglaccountledger as b " _
                        + " WHERE b.datetrn <= a.datetrn and b.accountno='" & accountno.Text & "' and b.cleared=1 and b.cancelled=0 and b.officeid like '%" & officeid.Text & "%' order by datetrn desc) AS 'Balance' " _
                        + " FROM `tblglaccountledger` as a where a.officeid like '%" & officeid.Text & "%' and accountno='" & accountno.Text & "' and a.cleared=1 and a.cancelled=0 and date_format(a.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' order by a.datetrn asc", "tblglaccountledger", Em, GridView1, Me)

            GridView1.Focus()
            GridView1.Columns("Description").ColumnEdit = MemoEdit
            XgridHideColumn({"trnid"}, GridView1)
            GridView1.BestFitColumns()
            XgridColAlign({"Date Transaction", "Reference No."}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Charges", "Payment", "Balance"}, GridView1)
            GridView1.BestFitColumns()
            'XgridColWidth({"Description"}, GridView1, 300)
            XgridColWidth({"Charges", "Payment", "Balance"}, GridView1, 120)
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
        com.CommandText = "select sum(debit) as ttldebit, sum(credit) as ttlcredit, sum(debit)- sum(credit)  as 'balance' from tblglaccountledger where officeid like '%" & officeid.Text & "%' and accountno='" & accountno.Text & "' and cleared=1 and cancelled=0" : rst = com.ExecuteReader
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
        PrintDatagridview(txtsuppliername.Text, Me.Text, "Date " & txtdateFrom.Text + " - " + txtDateTo.Text, GridView1, Me)
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


    Private Sub RefreshLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshLedgerToolStripMenuItem.Click
        FilterAccountLedger()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("There's no item to export!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = Me.Text & " (" & ConvertDate(txtdateFrom.Text) & " to " & ConvertDate(txtDateTo.Text) & ").xlsx"
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

 
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles cmdSetAdvanceTime.Click
        If XtraMessageBox.Show("Are you sure you want to update selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblglaccountledger set datetrn=ADDTIME(datetrn,1) where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterAccountLedger()
            XtraMessageBox.Show("Transaction successfully updated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class