Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmAPAccountPayableManagement
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = (Keys.Control) + Keys.P Then

        End If
        Return ProcessCmdKey
    End Function
    Private Sub Vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        filter()
     
    End Sub
    
    Public Sub filter()
        LoadXgrid("SELECT vendorid, companyname as 'Vendor',compadd as 'Address',telephone as 'Contact Number', ifnull((select sum(debit)-sum(credit) from tblglaccountledger where  accountno=tblglobalvendor.vendorid and cleared=1 and cancelled=0),0) as 'Balance Due', (select count(*) from tblpurchaseorder where vendorid = tblglobalvendor.vendorid and paymentupdated=0 and cancelled=0 and verified=1) as 'Pending Invoice',(select date_format(datetrn,'%Y-%m-%d') from tblglaccountledger where accountno=tblglobalvendor.vendorid order by datetrn limit 1) as 'Last Transaction'  from tblglobalvendor where (vendorid in (select distinct accountno from tblglaccountledger where  journalmode='payable-accounts' and cleared=1 and cancelled=0) or ifnull((select sum(debit)-sum(credit) from tblglaccountledger where  accountno=tblglobalvendor.vendorid and cleared=1 and cancelled=0),0) > 0) order by companyname asc", "tblglobalvendor", Em, GridView1, Me)
        GridView1.Columns("vendorid").Visible = False
        GridView1.Columns("Vendor").Width = 350
        XgridColAlign({"Last Transaction", "Pending Invoice"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Balance Due"}, GridView1)
        XgridGeneralSummaryCurrency({"Balance Due"}, GridView1)
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        Dim status As Double = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Balance Due"))
        If status < 0 And e.Column.FieldName = "Balance Due" Then
            e.Appearance.ForeColor = Color.Red
        Else
            e.Appearance.ForeColor = DefaultForeColor
        End If

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub


    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmClientModification.Visible = True Then
            frmClientModification.Focus()
        Else
            frmClientModification.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub StatementOfAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatementOfAccountToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("vendorid") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmAPAccountsPayableStatement.officeid.Text = officeid.Text
        frmAPAccountsPayableStatement.accountno.Text = GridView1.GetFocusedRowCellValue("vendorid").ToString
        frmAPAccountsPayableStatement.txtsuppliername.Text = GridView1.GetFocusedRowCellValue("Vendor").ToString
        frmAPAccountsPayableStatement.Show(Me)
    End Sub

    Private Sub cmdPrintReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintReport.ItemClick
        PrintDatagridview(Me.Text, Me.Text, "", GridView1, Me)
    End Sub

    Private Sub cmdExportToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub ViewHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHistoryToolStripMenuItem.Click
        frmAPPaymentHistory.accountno.Text = GridView1.GetFocusedRowCellValue("vendorid").ToString
        frmAPPaymentHistory.txtsuppliername.Text = GridView1.GetFocusedRowCellValue("Vendor").ToString
        If frmAPPaymentHistory.Visible = False Then
            frmAPPaymentHistory.Show(Me)
        End If
    End Sub
 
    
End Class