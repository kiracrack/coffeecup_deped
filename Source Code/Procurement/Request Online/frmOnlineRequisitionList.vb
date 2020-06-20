Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Data

Public Class frmOnlineRequisitionList
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = (Keys.Control) + Keys.P Then

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        FilterOption()
        LoadGridviewAppearance(GridView1)
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles POTabControl.SelectedPageChanged
        FilterOption()
    End Sub

    Public Sub FilterOption()
        Dim datefilter As String = ""
        If POTabControl.SelectedTabPage Is tabPending Then
            Em.Parent = POTabControl.SelectedTabPage
            filterRequestList("corporatelevel=1 and approvedbranch=0 and cancelled=0 and disapproved=0", "", "daterequest")
            cmdCancel.Visible = False
            ckasof.Enabled = False : txtfrmdate.Enabled = False : txttodate.Enabled = False
        ElseIf POTabControl.SelectedTabPage Is tabForReceiving Then
            Em.Parent = POTabControl.SelectedTabPage
            filterRequestList("corporatelevel=1 and approvedbranch=1 and received=0 and cancelled=0 and disapproved=0", "", "daterequest")
            cmdCancel.Visible = True
            ckasof.Enabled = False : txtfrmdate.Enabled = False : txttodate.Enabled = False
        ElseIf POTabControl.SelectedTabPage Is tabReceived Then
            Em.Parent = POTabControl.SelectedTabPage
            filterRequestList("corporatelevel=1 and approvedbranch=1 and received=1 and cancelled=0 and disapproved=0", "", "daterequest")
            cmdCancel.Visible = False
            ckasof.Enabled = True : txtfrmdate.Enabled = True : txttodate.Enabled = True
        ElseIf POTabControl.SelectedTabPage Is tabDisapproved Then
            Em.Parent = POTabControl.SelectedTabPage
            filterRequestList("corporatelevel=1 and disapproved=1 and cancelled=0", ", date_format(datedisapproved,'%Y-%m-%d %r') as 'Date Disappproved'", "datedisapproved")
            cmdCancel.Visible = False
            ckasof.Enabled = True : txtfrmdate.Enabled = True : txttodate.Enabled = True
        ElseIf POTabControl.SelectedTabPage Is tabCancelled Then
            Em.Parent = POTabControl.SelectedTabPage
            filterRequestList("corporatelevel=1 and disapproved=0  and cancelled=1", ", date_format(datecancelled,'%Y-%m-%d %r') as 'Date Cancelled'", "datecancelled")
            cmdCancel.Visible = False
            ckasof.Enabled = True : txtfrmdate.Enabled = True : txttodate.Enabled = True
        End If
    End Sub
    Public Sub filterRequestList(ByVal status As String, ByVal otherquery As String, ByVal datefilterby As String)
        Dim datefilter As String = ""
        If ckasof.Checked = True Then
            datefilter = " and date_format(" & datefilterby & ",'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            datefilter = " and date_format(" & datefilterby & ",'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        LoadXgrid("Select pid as 'Request No',officeid,trnby,requestby, " _
                    + " (select officename from tblcompoffice where officeid = tblrequisitions.officeid) as '" & GlobalOfficeCaption & "', " _
                    + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'Request By' , " _
                    + " (select description from tblrequesttype where POTYPEID=tblrequisitions.POTYPEID) as 'Request Type', " _
                    + " date_format(daterequest,'%Y-%m-%d %r') as 'Date Request', " _
                    + " ifnull((select sum(total) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'Total Amount', " _
                    + " Priority, " _
                    + GlobalStrAttachment _
                    + " details as 'Justification', " _
                    + " (select fullname from tblaccounts where accountid = tblrequisitions.trnby) as 'Transaction By' " _
                    + otherquery _
                    + " from tblrequisitions where trnrefno<>'manual-requisition' and " & status _
                    + If(POTabControl.SelectedTabPage Is tabForReceiving Or POTabControl.SelectedTabPage Is tabPending, "", datefilter) & " order by " & datefilterby & " desc", "tblrequisitions", Em, GridView1, Me)

        GridView1.Columns("Justification").ColumnEdit = MemoEdit
        GridView1.Columns("officeid").Visible = False
        GridView1.Columns("trnby").Visible = False
        GridView1.Columns("requestby").Visible = False
        XgridColAlign({"Request No", "Priority", "Attachment"}, GridView1, HorzAlignment.Center)

        XgridColCurrency({"Total Amount"}, GridView1)
        GridView1.BestFitColumns()
        GridView1.Columns("Justification").Width = 300
        Dim item1 As New GridGroupSummaryItem()
        item1.FieldName = "Total Amount"
        item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item1.DisplayFormat = "{0:n} Php"
        item1.ShowInGroupColumnFooter = GridView1.Columns("Total Amount")
        GridView1.GroupSummary.Add(item1)

        GridView1.Columns("Total Amount").SummaryItem.SummaryType = SummaryItemType.Sum
        GridView1.Columns("Total Amount").SummaryItem.DisplayFormat = "{0:n} Php"
        GridView1.Columns("Total Amount").SummaryItem.Tag = 1
        CType(GridView1.Columns("Total Amount").View, GridView).OptionsView.ShowFooter = True
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If gen_filterappearance = True Then
            If e.Column.Name = "colPriority" Then
                Dim priority As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Priority"))
                If priority = "High" Then
                    e.Appearance.ForeColor = Color.Red
                    'e.Appearance.ForeColor = Color.White
                    ' e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                ElseIf priority = "Normal" Then
                    e.Appearance.ForeColor = Color.Green
                    ' e.Appearance.ForeColor = Color.Black
                ElseIf priority = "Low" Then
                    e.Appearance.ForeColor = Color.Blue
                    ' e.Appearance.ForeColor = Color.White
                    '  e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                End If
            End If
        End If
    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        ParticularToolStripMenuItem.PerformClick()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterOption()
    End Sub


    Private Sub menu_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If CheckSelectedRow("Request No", GridView1) = True Then
            frmHoldOnlineRequisition.pid.Text = GridView1.GetFocusedRowCellValue("Request No").ToString
            frmHoldOnlineRequisition.reqid.Text = GridView1.GetFocusedRowCellValue("requestby").ToString
            frmHoldOnlineRequisition.txtrequestby.Text = GridView1.GetFocusedRowCellValue("Request By").ToString
            frmHoldOnlineRequisition.txtpotype.Text = GridView1.GetFocusedRowCellValue("Request Type").ToString
            frmHoldOnlineRequisition.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
            frmHoldOnlineRequisition.Show(Me)
        End If
    End Sub

  
    Private Sub ParticularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParticularToolStripMenuItem.Click
        frmRequisitionsItems.pid.Text = GridView1.GetFocusedRowCellValue("Request No").ToString
        If frmRequisitionsItems.Visible = True Then
            frmRequisitionsItems.WindowState = FormWindowState.Normal
            frmRequisitionsItems.Focus()
        Else
            frmRequisitionsItems.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        PrintGeneralReport(Me.Text, POTabControl.SelectedTabPage.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        FilterOption()
    End Sub

    Private Sub SetAttachmentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SetAttachmentToolStripMenuItem1.Click
        If CheckSelectedRow("Request No", GridView1) = True Then
            frmDBFileUploader.trncode.Text = GridView1.GetFocusedRowCellValue("Request No").ToString()
            frmDBFileUploader.Show(Me)
        End If
    End Sub

    Private Sub cmdViewAttachment_Click(sender As Object, e As EventArgs) Handles cmdViewAttachment.Click
        frmDBFileViewer.trncode.Text = GridView1.GetFocusedRowCellValue("Request No").ToString()
        frmDBFileViewer.Show(Me)
    End Sub

    Private Sub ExtractAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractAttachmentToolStripMenuItem.Click
        If CheckSelectedRow("Request No", GridView1) = True Then
            ViewAttachmentPackage_Database({GridView1.GetFocusedRowCellValue("Request No").ToString()}, "")
        End If
    End Sub
End Class