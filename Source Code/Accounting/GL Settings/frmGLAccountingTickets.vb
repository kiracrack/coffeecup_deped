Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO

Public Class frmGLAccountingTickets
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
        txtdateFrom.EditValue = CDate(Now)
        txtDateTo.EditValue = CDate(Now)
        LoadCompany()

    End Sub

    Public Sub LoadCompany()
        LoadXgridLookupSearch("select code, Companyname as 'Select Company' from tblcompany", "tblcompany", txtCompany, gvCompany, Me)
        gvCompany.Columns("code").Visible = False
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("code").ToString()
        LoadOffice()
    End Sub

    Public Sub LoadOffice()
        If companyid.Text = "" Then Exit Sub
        LoadXgridLookupSearch("select officeid, officename as 'Select Office' from tblcompoffice where companyid='" & companyid.Text & "' order by officename", "tblcompoffice", txtOffice, gridOffice, Me)
        gridOffice.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtOffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        FilterAccountLedger()
      
    End Sub

    Public Sub FilterAccountLedger()
        Try
            If companyid.Text = "" Then Exit Sub
            LoadXgrid("select id,(select officename from tblcompoffice where officeid=tblglticket.officeid) as 'Office',ItemCode,ItemName,CreditAmount as 'Credit', DebitAmount as 'Debit',Remarks, date_format(datetrn, '%Y-%m-%d') as 'Date Transaction',trnname as 'Transacted by' from tblglticket where companyid='" & companyid.Text & "' " & If(CheckEdit1.Checked = True, "", " and officeid='" & officeid.Text & "' ") & " and date_format(datetrn, '%Y-%m-%d')  between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' order by datetrn asc", "tblglticket", Em, GridView1, Me)
            GridView1.Columns("Remarks").AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            ' GridView1.Columns("Description").ColumnEdit = MemoEdit
            GridView1.Columns("Remarks").ColumnEdit = MemoEdit

            XgridHideColumn({"id"}, GridView1)
            GridView1.BestFitColumns()
            XgridColAlign({"ItemCode", "Date Transaction"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridGroupSummaryCurrency({"Debit", "Credit"}, GridView1)
            XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)
            XgridColCurrency({"Debit", "Credit"}, GridView1)
            GridView1.BestFitColumns()
            'GridView1.Columns("Remarks").Width = 500
            'XgridColWidth({"Description"}, GridView1, 300)
            XgridColWidth({"Debit", "Credit"}, GridView1, 120)
            Em.Refresh() : GridView1.RefreshData()
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

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        gridview1.ShowFindPanel()
    End Sub

    Private Sub txtdatetrn_EditValueChanged(sender As Object, e As EventArgs) Handles txtdateFrom.EditValueChanged
        If companyid.Text <> "" Then
            FilterAccountLedger()
            txtDateTo.Properties.MinValue = txtdateFrom.EditValue
        End If
    End Sub

    Private Sub txtDateTo_EditValueChanged(sender As Object, e As EventArgs) Handles txtDateTo.EditValueChanged
        If companyid.Text <> "" Then
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
        If txtOffice.Text = "" And GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Please select account!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = txtOffice.Text & " (" & ConvertDate(txtdateFrom.Text) & " to " & ConvertDate(txtDateTo.Text) & ").xlsx"
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

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtOffice.Enabled = False
        Else
            txtOffice.Enabled = True
        End If
        FilterAccountLedger()
    End Sub
End Class