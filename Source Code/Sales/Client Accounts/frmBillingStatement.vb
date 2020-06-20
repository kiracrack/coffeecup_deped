Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid

Public Class frmBillingStatement
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = (Keys.Control) + Keys.P Then
            GridView1.ShowRibbonPrintPreview()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        If mode.Text = "view" Then
            txtFilterName.Visible = False
            If countqry("tblsalesclientcharges", " accountno='" & accountno.Text & "' and cancelled=0 and verified=1 and paymentupdated=0") > 0 Then
                txtdateFrom.EditValue = CDate(qrysingledata("dt", "date_format(datetrn,'%Y,%m,%d') as dt", "where accountno='" & accountno.Text & "' and cancelled=0 and verified=1 and paymentupdated=0 order by datetrn desc", "tblsalesclientcharges"))
            Else
                txtdateFrom.EditValue = Now
            End If
        Else
            txtFilterName.Visible = True
            txtdateFrom.EditValue = Now
        End If
       
        txtDateTo.EditValue = Now
        FilterInvoices()
        '  LoadGridviewAppearance(GridView1)
    End Sub

    Public Sub FilterInvoices()
        If ckFilter.Checked = True Then
            FilterInvoiceTransaction()
        Else
            FilterDetailTransaction()
        End If
    End Sub
    
    Public Sub FilterDetailTransaction()
        Try
            dst = Nothing
            If accountno.Text = "" Then Exit Sub
            LoadXgrid("select  date_format(tblsalesclientchargesitem.datetrn, '%M %d, %Y') as 'Date', invoiceno as 'TRA Number', productname as 'Product',Quantity,sellprice as 'Unit Cost', chargetotal as 'Charges', distotal as 'Discount', Total from tblsalesclientchargesitem inner join tblsalesclientcharges on tblsalesclientchargesitem.batchcode = tblsalesclientcharges.batchcode and tblsalesclientcharges.cancelled=0 where tblsalesclientchargesitem.cifid='" & accountno.Text & "' and date_format(tblsalesclientchargesitem.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' and tblsalesclientchargesitem.cancelled=0 and  tblsalesclientcharges.verified=1 and tblsalesclientcharges.paymentupdated=0 order by tblsalesclientchargesitem.datetrn asc", "tblsalesclientchargesitem", Em, GridView1, Me)
            XgridColCurrency({"Unit Cost", "Quantity", "Charges", "Discount", "Total"}, GridView1)
            GridView1.BestFitColumns()
            XgridColWidth({"Total"}, GridView1, 120)
            XgridColAlign({"Date", "TRA Number", "Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

            XgridGroupSummaryCurrency({"Total"}, GridView1)
            XgridGeneralSummaryCurrency({"Total"}, GridView1)

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

    Public Sub FilterInvoiceTransaction()
        Try
            dst = Nothing
            If accountno.Text = "" Then Exit Sub
            LoadXgrid("select date_format(datetrn, '%M %d, %Y') as 'Date', batchcode as 'Order Number', invoiceno as 'Invoice No.' ,if(paymentrefnumber<>'',(amount-(select paymentamount from tblpaymenttransactions where tblpaymenttransactions.trnid=tblsalesclientcharges.paymentrefnumber and cancelled=0)),amount) as 'Amount'  from tblsalesclientcharges where accountno='" & accountno.Text & "' and  paymentupdated=0 and cancelled=0 and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' ", "tblsalesclientcharges", Em, GridView1, Me)
            XgridColCurrency({"Amount"}, GridView1)
            GridView1.BestFitColumns()
            XgridColWidth({"Amount"}, GridView1, 120)
            XgridColAlign({"Date", "Invoice No.", "Order Number"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

            XgridGroupSummaryCurrency({"Amount"}, GridView1)
            XgridGeneralSummaryCurrency({"Amount"}, GridView1)

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


    Private Sub txtdatetrn_EditValueChanged(sender As Object, e As EventArgs) Handles txtdateFrom.EditValueChanged
        FilterInvoices()
    End Sub

    Private Sub txtDateTo_EditValueChanged(sender As Object, e As EventArgs) Handles txtDateTo.EditValueChanged
        FilterInvoices()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
        Dim report As New rptBillingStatement()
        com.CommandText = "select * from tblclientaccounts where cifid='" & accountno.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            report.txtClientName.Text = rst("companyname").ToString
            report.txtAddress.Text = rst("compadd").ToString
            report.txtContactNumber.Text = rst("telephone").ToString
        End While
        rst.Close()
        report.txtDate.Text = UCase(Format(Now.ToString("MMMM dd, yyyy")))
        report.txtStatementDatePeriod.Text = UCase("Period covered from " & txtdateFrom.Text & " To " & txtDateTo.Text)
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.txtStatementHeader.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptBillingHeader.txt").ToString.Replace(vbCrLf, Environment.NewLine)
        report.txtStatementFooter.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptBillingFooter.txt").ToString.Replace(vbCrLf, Environment.NewLine)
        report.txtStatementFooter1.Text = ReadFile(Application.StartupPath.ToString & "\Report\rptBillingFooter1.txt").ToString.Replace(vbCrLf, Chr(13))

        Me.WindowState = FormWindowState.Minimized
        report.ShowRibbonPreviewDialog()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub RefreshListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshListToolStripMenuItem.Click
        FilterInvoices()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim I As Integer = 0
        For I = 0 To gridview1.SelectedRowsCount - 1
            gridview1.DeleteRow(gridview1.GetSelectedRows(I))
        Next
    End Sub

    Private Sub txtTimeFrom_EditValueChanged(sender As Object, e As EventArgs)
        FilterInvoices()
    End Sub

    
    Private Sub ckFilter_CheckedChanged(sender As Object, e As EventArgs) Handles ckFilter.CheckedChanged
        FilterInvoices()
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
                If countqry("tblsalesclientcharges", " accountno='" & accountno.Text & "' and cancelled=0 and verified=1 and paymentupdated=0") > 0 Then
                    txtdateFrom.EditValue = CDate(qrysingledata("dt", "date_format(datetrn,'%Y,%m,%d') as dt", "where accountno='" & accountno.Text & "' and cancelled=0 and verified=1 and paymentupdated=0 order by datetrn desc", "tblsalesclientcharges"))
                Else
                    txtdateFrom.EditValue = Now
                End If
                FilterInvoices()
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