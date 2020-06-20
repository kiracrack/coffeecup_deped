Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCashiersBlotter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadCurrentBlotter()
        If globalApproverPermission = True Or LCase(globaluser) = "root" Then
            ReopenTransactionToolStripMenuItem.Visible = True
        Else
            ReopenTransactionToolStripMenuItem.Visible = False
        End If
    End Sub

    Public Sub LoadCurrentBlotter()
        LoadXgrid("select officeid,userid, trncode as 'Transaction Code', date_format(dateopen,'%Y-%m-%d') as 'Transaction Date',(select officename from tblcompoffice where officeid=tblsalessummary.officeid) as 'Office', (select fullname from tblaccounts where accountid=tblsalessummary.userid) as 'Cashier', cashend as 'System Cash End',cashonhand as 'Actual Cash',if(overages=0,shortages,overages) as 'Variance', if(openfortrn=0,'CLOSED','OPEN') as 'Status'  from tblsalessummary where verified=0  and cancelled=0", "tblsalessummary", Em, GridView1, Me)
        GridView1.Columns("Office").Group()
        GridView1.ExpandAllGroups()
        XgridHideColumn({"officeid", "userid"}, GridView1)
        XgridColWidth({"Cashier"}, GridView1, 220)
        XgridColWidth({"System Cash End", "Actual Cash", "Variance"}, GridView1, 120)
        XgridColAlign({"Transaction Date", "Clearing Status", "Transaction Code", "Status"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"System Cash End", "Actual Cash", "Variance"}, GridView1)
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Status").ToString = "OPEN" Then
            XtraMessageBox.Show("Current cashier status currently open!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckSelectedRow("Transaction Code", GridView1) = True Then
           frmBlotterVerification.trncode.Text = GridView1.GetFocusedRowCellValue("Transaction Code").ToString
            frmBlotterVerification.Show(Me)
        End If
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If gen_filterappearance = True Then
            If globalApproverPermission = True Or LCase(globaluser) = "root" Then
                Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Variance"))
                If e.Column.FieldName = "Variance" Then
                    If Val(CC(status)) < 0 Then
                        e.Appearance.ForeColor = Color.Red
                    End If
                End If
            End If
            
            Dim cashierstatus As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If e.Column.FieldName = "Status" Then
                If cashierstatus = "OPEN" Then
                    e.Appearance.BackColor = Color.Lime
                    e.Appearance.ForeColor = Color.Black
               
                End If
            End If
        End If
    End Sub

    Private Sub ReopenTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReopenTransactionToolStripMenuItem.Click
        'If GridView1.GetFocusedRowCellValue("Status").ToString = "OPEN" Then
        '    XtraMessageBox.Show("Current cashier status currently open!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If countqry("tblsalessummary", "openfortrn=1 and userid='" & GridView1.GetFocusedRowCellValue("userid").ToString & "'") > 0 Then
        '    XtraMessageBox.Show("Selected cashier currently active and cannot be proceed! Please close previous transaction first", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        If CheckSelectedRow("Transaction Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to re-open selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tblsalessummary set openfortrn=1 where trncode='" & GridView1.GetFocusedRowCellValue("Transaction Code").ToString & "'" : com.ExecuteNonQuery()
                LoadCurrentBlotter()
                XtraMessageBox.Show("Transaction successfully opened", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub CashiersTransactionClearingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashiersTransactionClearingToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Status").ToString = "OPEN" Then
            XtraMessageBox.Show("Current cashier status currently open!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckSelectedRow("Transaction Code", GridView1) = True Then
            frmCashiersTransactionClearing.Text = "Cashier's Transaction Clearing (" & GridView1.GetFocusedRowCellValue("Transaction Code").ToString & ")"
            frmCashiersTransactionClearing.trnsumcode.Text = GridView1.GetFocusedRowCellValue("Transaction Code").ToString
            frmCashiersTransactionClearing.ShowDialog(Me)
            LoadCurrentBlotter()
        End If
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        LoadCurrentBlotter()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
 
    Private Sub ViewTransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionHistoryToolStripMenuItem.Click
        If CheckSelectedRow("Transaction Code", GridView1) = True Then
            frmPOSTransactionHistory.globalSalesTrnCOde.Text = GridView1.GetFocusedRowCellValue("Transaction Code").ToString
            frmPOSTransactionHistory.Text = "TRN# (" & GridView1.GetFocusedRowCellValue("Transaction Code").ToString & ") " & StrConv(GridView1.GetFocusedRowCellValue("Cashier").ToString, vbProperCase)
            If frmPOSTransactionHistory.Visible = False Then
                frmPOSTransactionHistory.Show(Me)
            End If
        End If
    End Sub
End Class