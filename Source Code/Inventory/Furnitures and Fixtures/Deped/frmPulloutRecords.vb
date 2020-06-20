Imports MySql.Data.MySqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmPulloutRecords
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmAccountPayables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        FilterStockoutSummary()
    End Sub

    Public Function FilterStockoutSummary()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = "where date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = "where date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select trncode as 'TRN Code', (select fullname from tblaccounts where accountid=tblofficeequipmentpullout.Borrower) as 'Borrower',date_format(dateborrowed,'%Y-%m-%d') as 'Date Borrowed',date_format(timeborrowed,'%r') as 'Time Borrowed',(select fullname from tblaccounts where accountid=tblofficeequipmentpullout.trnby) as 'Processed By', date_format(datetrn,'%Y-%m-%d %r') as 'Date Processed', Returned, date_format(datereturned,'%Y-%m-%d') as 'Date Returned',date_format(timereturned,'%r') as 'Time Returned', (select fullname from tblaccounts where accountid=tblofficeequipmentpullout.receivedby) as 'Received By'  from tblofficeequipmentpullout  " & If(ckPendingRequest.Checked = True, " where returned=0 ", filterasof) & " order by datetrn desc", "tblofficeequipmentpullout", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblofficeequipmentpullout")

        XgridColAlign({"TRN Code", "Date Borrowed", "Time Borrowed", "Date Processed", "Date Returned", "Time Returned"}, GridView1, HorzAlignment.Center)
        GridView1.BestFitColumns()
        XgridColWidth({"TRN Code"}, GridView1, 100)

        'XgridGeneralSummaryCurrency({"Total Amount"}, GridView1)

        msda = New MySqlDataAdapter("select  trncode as 'TRN Code',itemname as 'Particular', Reason, Remarks, Returned, date_format(datereturned,'%Y-%m-%d %r') as 'Date Returned',(select fullname from tblaccounts where accountid=tblofficeequipmentpulloutitem.receivedby) as 'Received By' from tblofficeequipmentpulloutitem where trncode in (select trncode from tblofficeequipmentpullout  " & If(ckPendingRequest.Checked = True, " where returned=0 ", filterasof) & ")", conn)
        msda.Fill(dst, "tblofficeequipmentpulloutitem")

        BandgridView = New GridView(Em)
        Dim keyColumn As DataColumn = dst.Tables("tblofficeequipmentpullout").Columns("TRN Code")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblofficeequipmentpulloutitem").Columns("TRN Code")

        dst.Relations.Add("PulloutDetails", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("PulloutDetails", BandgridView)

        Em.DataSource = dst.Tables("tblofficeequipmentpullout")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblofficeequipmentpulloutitem"))
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"TRN Code"}, BandgridView)
        XgridColAlign({"Date Returned", "Unit"}, BandgridView, HorzAlignment.Center)
        XgridColWidth({"Particular"}, BandgridView, 300)
        BandgridView.BestFitColumns(True)
        SaveFilterColumn(GridView1, Me.Text)
        Return True
    End Function

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterStockoutSummary()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub


    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        FilterStockoutSummary()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport(Me.Text, Me.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ReadFilterColumn(GridView1, Me.Text)
    End Sub

    Private Sub ckPending_CheckedChanged(sender As Object, e As EventArgs) Handles ckPendingRequest.CheckedChanged
        If ckPendingRequest.Checked = True Then
            txtfrmdate.Enabled = False
            txttodate.Enabled = False
            ckasof.Enabled = False
            ckasof.Checked = False
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
            ckasof.Enabled = True
        End If
        FilterStockoutSummary()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        frmVouchersInformation.Show(Me)
    End Sub

    Private Sub EditVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditVoucherToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Returned") = True Then
            XtraMessageBox.Show("Selected record is already returned", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmPulloutForm.mode.Text = "edit"
        frmPulloutForm.trncode.Text = GridView1.GetFocusedRowCellValue("TRN Code").ToString()
        If frmStockoutDepedRequest.Visible = True Then
            frmPulloutForm.Focus()
        Else
            frmPulloutForm.Show(Me)
        End If

    End Sub

    Private Sub CancelVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelVoucherToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Returned") = True Then
            XtraMessageBox.Show("Selected record is already returned", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently Cancel this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "DELETE FROM tblofficeequipmentpullout where trncode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "TRN Code").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "DELETE FROM tblofficeequipmentpulloutitem where trncode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "TRN Code").ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterStockoutSummary()
            XtraMessageBox.Show("Transaction successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

   
    Private Sub ViewDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        GeneratePulloutSlip(GridView1.GetFocusedRowCellValue("TRN Code").ToString(), Me)
    End Sub
  
    Private Sub cmdReturnItem_Click(sender As Object, e As EventArgs) Handles cmdReturnItem.Click
        If GridView1.GetFocusedRowCellValue("Returned") = True Then
            XtraMessageBox.Show("Selected record is already returned", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmPulloutReturnItem.trncode.Text = GridView1.GetFocusedRowCellValue("TRN Code").ToString()
        If frmPulloutReturnItem.Visible = True Then
            frmPulloutReturnItem.Focus()
        Else
            frmPulloutReturnItem.Show(Me)
        End If
    End Sub
End Class