Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.Data
Imports DevExpress.XtraSplashScreen

Public Class frmUserLogs
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        End If
        Return ProcessCmdKey
    End Function

    Public Sub filter()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " where date_format(intime,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " where date_format(intime,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        If ckGroup.Checked = True Then
            LoadXgrid("Select (select fullname from tblaccounts where accountid=tbllogin.userid) as 'User Account', " _
                         + " date_format(intime, '%M %d, %Y') as 'Transaction Date', " _
                         + " (select count(*) from tblrequisitions where purchaser=tbllogin.userid and date_format(daterequest, '%M %d, %Y') = date_format(intime, '%M %d, %Y')) as 'Requisitions', " _
                         + " (select count(*) from tblrequisitions where recievedby=tbllogin.userid and date_format(daterecieved, '%M %d, %Y') = date_format(intime, '%M %d, %Y')) as 'Received', " _
                         + " (select count(*) from tblvouchers where userid=tbllogin.userid and date_format(transdate, '%M %d, %Y') = date_format(intime, '%M %d, %Y')) as 'Vouchers', " _
                         + " (select count(*) from tblglobalproducts where entryby=tbllogin.userid and date_format(dateentered, '%M %d, %Y') = date_format(intime, '%M %d, %Y')) as 'Items', " _
                         + " (select count(*) from tblglobalvendor where entryby=tbllogin.userid and date_format(dateentered, '%M %d, %Y') = date_format(intime, '%M %d, %Y')) as 'Suppliers', " _
                         + " (select count(*) from tblinventorylogs where trnby=tbllogin.userid and date_format(datetrn, '%M %d, %Y') = date_format(intime, '%M %d, %Y')) as 'Inventory', " _
                         + " (select count(*) from tblstockoutitem where trnby=tbllogin.userid and date_format(datetrn, '%M %d, %Y') = date_format(intime, '%M %d, %Y')) as 'Stockouts', " _
                         + " (select count(*) from tbltransferitem where trnby=tbllogin.userid and date_format(datetrn, '%M %d, %Y') = date_format(intime, '%M %d, %Y')) as 'Transfer Items' " _
                         + " from tbllogin " _
                         + filterasof _
                         + " group by userid,date_format(intime, '%M %d, %Y') order by intime desc", "tbllogin", Em, GridView1, Me)
            XgridColAlign({"Transaction Date"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            GridView1.Columns("User Account").Group()
            Dim strColumn() As String = {"Requisitions", "Received", "Vouchers", "Items", "Suppliers", "Inventory", "Stockouts", "Transfer Items"}
            For Each word In strColumn
                Dim item1 As New GridGroupSummaryItem()
                item1.FieldName = word
                item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
                item1.DisplayFormat = "{0}"
                item1.ShowInGroupColumnFooter = GridView1.Columns(word)
                GridView1.GroupSummary.Add(item1)

                GridView1.Columns(word).SummaryItem.SummaryType = SummaryItemType.Sum
                GridView1.Columns(word).SummaryItem.DisplayFormat = "{0}"
                GridView1.Columns(word).SummaryItem.Tag = 1
                CType(GridView1.Columns(word).View, GridView).OptionsView.ShowFooter = True
                XgridColAlign({word}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            Next

            GridView1.Columns("Transaction Date").SummaryItem.SummaryType = SummaryItemType.Sum
            GridView1.Columns("Transaction Date").SummaryItem.DisplayFormat = "Total Posted Transactions"
            GridView1.Columns("Transaction Date").SummaryItem.Tag = 1
            CType(GridView1.Columns("Transaction Date").View, GridView).OptionsView.ShowFooter = True

        Else
            LoadXgrid("Select (select fullname from tblaccounts where accountid=tbllogin.userid) as 'User Account', " _
                                      + " date_format(intime, '%M %d, %Y') as 'Login Date', " _
                                      + " date_format(intime, '%r') as 'Login Time', " _
                                      + " case when outtime is null then 'Currently Log' else date_format(outtime, '%M %d, %Y') end  as 'Logout Date', " _
                                      + " case when outtime is null then '-' else date_format(outtime, '%r') end  as 'Logout Time', " _
                                      + " case when outtime is null then timediff(current_timestamp,intime) else timediff(outtime,intime) end  as 'Duration' " _
                                      + " from tbllogin " _
                                      + filterasof _
                                      + " order by intime desc", "tbllogin", Em, GridView1, Me)

            XgridColAlign({"Duration", "Login Date", "Login Time", "Logout Date", "Logout Time"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        End If
    End Sub
    Private Sub frmStockHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

        LoadGridviewAppearance(GridView1)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        filter()
    End Sub


    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

    End Sub

    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

   
    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filter()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarCheckItem1_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        If BarCheckItem1.Checked = True Then
            SplitContainerControl1.Collapsed = False
        Else
            SplitContainerControl1.Collapsed = True
        End If
    End Sub
End Class