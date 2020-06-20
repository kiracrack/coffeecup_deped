Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmTransferedRequestList
    Dim query As String = "DATEDIFF(current_date,datetransfer) as 'Day(s) Count'   from tbltransferbatch where confirmed=0"
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then
           

        ElseIf keyData = (Keys.Control) + Keys.P Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmTransferedItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me) 
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)

        Filteroption()
        LoadGridviewAppearance(GridView1)
    End Sub

    Private Sub TabTransferControl_TabIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TabTransferControl.SelectedPageChanged
        Filteroption()
    End Sub
    Public Sub Filteroption()
        If TabTransferControl.SelectedTabPage Is tabpending Then
            Em.Parent = TabTransferControl.SelectedTabPage
            query = " DATEDIFF(current_date,datetransfer) as 'Day(s) Count'   from tbltransferbatch where confirmed=0 and cancelled=0 "
            cmdCancel.Visible = True
        ElseIf TabTransferControl.SelectedTabPage Is tabConfirmed Then
            Em.Parent = TabTransferControl.SelectedTabPage
            query = " DATEDIFF(current_date,datetransfer) as 'Day(s) Confirmed',(select fullname from tblaccounts where accountid = tbltransferbatch.confirmedby) as 'Confirmed By', date_format(dateconfirmed, '%Y-%m-%d %r') as 'Date Confirmed'   from tbltransferbatch where confirmed=1 and cancelled=0"
            cmdCancel.Visible = False
        ElseIf TabTransferControl.SelectedTabPage Is tabCancelled Then
            Em.Parent = TabTransferControl.SelectedTabPage
            query = " DATEDIFF(current_date,datecancelled) as 'Day(s) Cancelled',(select fullname from tblaccounts where accountid = tbltransferbatch.cancelledby) as 'Cancelled By', date_format(datecancelled, '%Y-%m-%d %r') as 'Date Cancelled'  from tbltransferbatch where cancelled=1 "
            cmdCancel.Visible = False
        End If
        filter()
    End Sub
    Public Sub filter()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(datetransfer,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(datetransfer,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        LoadXgrid("Select batchcode as 'Batch Code', inventory_from, (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_from) as 'From', " _
                      + " (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_to) as 'To', " _
                      + " (select sum(quantity) from tbltransferitem where batchcode=tbltransferbatch.batchcode) as 'Total Item', " _
                      + " Note, " _
                      + " (select fullname from tblaccounts where accountid = tbltransferbatch.requestby) as 'Request By' , " _
                      + " date_format(datetransfer,'%Y-%m-%d %r')  as 'Date Request', " _
                      + " (select fullname from tblaccounts where accountid = tbltransferbatch.trnby) as 'Created' , " _
                      + " if(cancelled=1,'Cancelled', case when confirmed=0 then 'Not yet Confirm' when confirmed=1 then 'Confirmed' end ) as 'Status', " & query _
                      + " " & filterasof _
                      + "  order by datetransfer desc", "tbltransferbatch", Em, GridView1, Me)

        GridView1.Columns("inventory_from").Visible = False
        GridView1.Columns("Note").ColumnEdit = MemoEdit
        XgridColAlign({"Total Item", "Status", "Date Request"}, GridView1, HorzAlignment.Center)
        If TabTransferControl.SelectedTabPage Is tabpending Then
            GridView1.Columns("Day(s) Count").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        ElseIf TabTransferControl.SelectedTabPage Is tabConfirmed Then
            GridView1.Columns("Day(s) Confirmed").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        ElseIf TabTransferControl.SelectedTabPage Is tabCancelled Then
            GridView1.Columns("Day(s) Cancelled").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        End If
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If gen_filterappearance = True Then
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If status = "Not yet Confirm" Then
                GridView1.Columns("Status").AppearanceCell.BackColor = Color.LightYellow
                GridView1.Columns("Status").AppearanceCell.ForeColor = Color.Red
                'GridView1.Columns("Due Day(s) Remaining").AppearanceCell.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If
        End If

    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
       
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub ViewTransactionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCancel.Click
        If CheckSelectedRow("From", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to continue cancel this request?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                'dst = New DataSet
                'msda = New MySqlDataAdapter("Select * from tbltransferitem where batchcode='" & GridView1.GetFocusedRowCellValue("Batch Code").ToString & "'", conn)
                'msda.Fill(dst, 0)
                'For cnt = 0 To dst.Tables(0).Rows.Count - 1
                '    With (dst.Tables(0))
                '        If qrysingledata("uses", "uses", "where catid='" & .Rows(cnt)("catid").ToString() & "'", "tblprocategory") = "1" Then
                '            com.CommandText = "update tblinventory set quantity= quantity+" & Val(CC(.Rows(cnt)("quantity").ToString())) & " where trnid='" & .Rows(cnt)("refcode").ToString() & "'" : com.ExecuteNonQuery()
                '        ElseIf qrysingledata("uses", "uses", "where catid='" & .Rows(cnt)("catid").ToString() & "'", "tblprocategory") = "2" Then
                '            com.CommandText = "update tblinventoryffe set status = 0 where refcode='" & .Rows(cnt)("refcode").ToString() & "'" : com.ExecuteNonQuery()
                '        End If
                '    End With
                'Next
                com.CommandText = "update tbltransferbatch set cancelled=1, datecancelled=current_timestamp, cancelledby='" & globaluserid & "' where batchcode='" & GridView1.GetFocusedRowCellValue("Batch Code").ToString & "'" : com.ExecuteNonQuery()
                filter()
                XtraMessageBox.Show("Request successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ViewRequestInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRequestInfoToolStripMenuItem.Click
        If CheckSelectedRow("From", GridView1) = True Then
            frmTransferedInfo.Batchcode.Text = GridView1.GetFocusedRowCellValue("Batch Code").ToString
            frmTransferedInfo.Show(Me)
        End If
    End Sub

#Region "REPORT SETTINGS"
    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintReport.Click
       
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filter()
        SplashScreenManager.CloseForm()
    End Sub
#End Region

End Class