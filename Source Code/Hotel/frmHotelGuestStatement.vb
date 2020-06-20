Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHotelGuestStatement
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelGuestStatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)

    End Sub
    Private Sub folioid_TextChanged(sender As Object, e As EventArgs) Handles folioid.TextChanged
        If folioid.Text = "" Then Exit Sub
        filter()
    End Sub
    Public Sub filter()
        LoadXgrid("SELECT a.trnid, " _
                        + " date_format(a.datetrn, '%Y-%m-%d %r') as 'Date Transaction', " _
                        + " (select officename from tblcompoffice where officeid = a.officeid) as 'Charge From', " _
                        + " if(appliedcoupon=1,concat(remarks,' (Covered by Coupon)'),remarks) as 'Description', " _
                        + " a.referenceno  as 'Reference No.', " _
                        + " if(appliedcoupon=1,0,a.debit) as 'Debit (Charges)', " _
                        + " a.credit as 'Credit (Payments)', " _
                        + " (SELECT SUM(COALESCE(if(appliedcoupon=1,0,debit),0) - COALESCE(credit,0)) FROM tblhoteltransaction as b WHERE b.trnid <= a.trnid and b.folioid='" & folioid.Text & "' and b.cancelled=0) AS 'Running Balance', " _
                        + " (select fullname from tblaccounts where accountid=a.trnby) as 'Transaction by' " _
                        + " FROM `tblhoteltransaction` as a where folioid='" & folioid.Text & "' and (debit>0 or credit>0) and a.cancelled=0 order by a.trnid asc", "tblhoteltransaction", Em, GridView1, Me)

        GridView1.Columns("trnid").Visible = False
        XgridColAlign({"Reference No."}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Debit (Charges)", "Credit (Payments)", "Running Balance"}, GridView1)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GenerateLXGuestStatement(folioid.Text, Me)
    End Sub


End Class