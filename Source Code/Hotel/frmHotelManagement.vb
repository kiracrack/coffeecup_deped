Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.GridColumnSummaryItem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.Data
Imports DevExpress.XtraSplashScreen

Public Class frmHotelManagement
    Private rptsettings As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.W Then
            Me.Close()

        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        ElseIf keyData = (Keys.F5) Then
            menu_Refresh.PerformClick()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmViewPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gridHotel)

        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)

        LoadHotel()
    End Sub
    Public Sub LoadHotel()
        LoadXgridLookupSearch("select cifid,companyname as 'Hotel' from tblclientaccounts where hotelclient=1 and deleted=0 order by companyname asc", "tblclientaccounts", txtHotel, gridHotel, Me)
        gridHotel.Columns("cifid").Visible = False
    End Sub
    Private Sub txtHotel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHotel.EditValueChanged
        On Error Resume Next
        hotelcif.Text = txtHotel.Properties.View.GetFocusedRowCellValue("cifid").ToString()
        FilterOption()
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterOption()
    End Sub

    Public Sub FilterOption()
        If XtraTabControl1.SelectedTabPage Is tabInhouseWalkinList Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewInHouseGuest(False)
        ElseIf XtraTabControl1.SelectedTabPage Is tabVipGuestList Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewInHouseGuest(True)

        ElseIf XtraTabControl1.SelectedTabPage Is tabReservationList Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewReservation()

        ElseIf XtraTabControl1.SelectedTabPage Is tabCheckedOutList Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewInCheckOutGuest()

        End If
    End Sub

    Public Sub ViewInHouseGuest(ByVal vip As Boolean)
        LoadXgrid("select roomid,vip,datetrn,hotelcif,folioid, foliono as 'Folio No', " & If(vip = True, "roomcheckin as 'Room Check-in', ", "") & " ifnull((select roomnumber from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid),'-') as 'Room No.', " _
                           + " (select fullname from tblhotelguest where guestid=tblhotelroomtransaction.guestid) as 'Guest Name', " _
                           + " noadults as 'Adult', nochild as 'Child', " _
                           + " date_format(datecheckin, '%Y-%m-%d') as 'Date Check-in', " _
                           + " date_format(timecheckin, '%r') as 'Time Check-in', " _
                           + " date_format(datecheckout, '%Y-%m-%d') as 'Date Check-out', " _
                           + " date_format(timecheckout, '%r') as 'Time Check-out', " _
                           + " if(roomcheckin=0,TIMESTAMPDIFF(day, datecheckin, if(closed=0,CURDATE(),timecheckout)),(select count(*) from tblhoteltransaction where folioid=tblhotelroomtransaction.folioid and roomcharge=1 and cancelled=0))  as 'No. Days', " _
                           + " ifnull(((select sum(debit) from tblhoteltransaction where folioid = tblhotelroomtransaction.folioid and cancelled=0 and appliedcoupon=0) - (select sum(credit) from tblhoteltransaction where folioid = tblhotelroomtransaction.folioid and cancelled=0)),0) as 'Open Balance',  " _
                           + " platenumber as 'Plate Number'," _
                           + " Remarks, " _
                           + " (select fullname from tblaccounts where accountid = tblhotelroomtransaction.trnby) as 'Transaction by' " _
                           + " from tblhotelroomtransaction where hotelcif='" & hotelcif.Text & "' and closed=0 and vip=" & vip & " and cancelled=0 and ((select roomnumber from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid) like '%" & txtsearch.Text & "%' or " _
                           + " (select fullname from tblhotelguest where guestid=tblhotelroomtransaction.guestid) like '%" & txtsearch.Text & "%' or " _
                           + " folioid like '%" & txtsearch.Text & "%') order by folioid asc", "tblhotelroomtransaction", Em, GridView1, Me)

        XgridHideColumn({"datetrn", "roomid", "hotelcif", "vip", "folioid"}, GridView1)
        XgridColAlign({"Folio No", "Room No.", "Adult", "Child", "Date Check-in", "Time Check-in", "Date Check-out", "Time Check-out", "No. Days", "Plate Number"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Open Balance"}, GridView1)
        XgridGeneralSummaryCurrency({"Open Balance"}, GridView1)
        txtfrmdate.Enabled = False
        txttodate.Enabled = False
        ckasof.Enabled = False
        ckasof.Checked = False
    End Sub


    Public Sub ViewReservation()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " (expired=1 and date_format(dateexpiry,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "') "
        Else
            filterasof = " (expired=1 and date_format(dateexpiry,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "') "
        End If
        
        LoadXgrid("select roomid,datetrn,trnid,guestid,paymentreference, ifnull((select roomnumber from tblhotelrooms where roomid  = tblhotelroomreservation.roomid),'-') as 'Room No.', " _
                           + " (select fullname from tblhotelguest where guestid=tblhotelroomreservation.guestid) as 'Guest Name', " _
                           + " noadults as 'Adult', nochild as 'Child', " _
                           + " date_format(datearaival, '%Y-%m-%d') as 'Date Arival', " _
                           + " date_format(timearaival, '%r') as 'Time Arival', " _
                           + " date_format(checkoutdate, '%Y-%m-%d') as 'Date Checkout', " _
                           + " paymentdeposit as 'Payment Deposit',  " _
                           + " date_format(dateexpiry, '%Y-%m-%d') as 'Date Expired', " _
                           + " if(DATEDIFF(dateexpiry,current_date) > 0, if(DATEDIFF(dateexpiry,current_date)=1,'Expired Today',cast(concat(DATEDIFF(dateexpiry,current_date), ' Remaining Days Expiration') as char(200))),'Expired') as 'Status', " _
                           + " (select fullname from tblaccounts where accountid = tblhotelroomreservation.trnby) as 'Transaction by' " _
                           + " from tblhotelroomreservation where hotelcif='" & hotelcif.Text & "' and ((proceedcheckin=0 and cancelled=0 and expired=0 and ((select roomnumber from tblhotelrooms where roomid  = tblhotelroomreservation.roomid) like '%" & txtsearch.Text & "%' or " _
                           + " (select fullname from tblhotelguest where guestid=tblhotelroomreservation.guestid) like '%" & txtsearch.Text & "%' or " _
                           + " date_format(datearaival, '%Y-%m-%d') like '%" & txtsearch.Text & "%')) or (" & filterasof & ")) order by datetrn asc", "tblhotelroomreservation", Em, GridView1, Me)

 

        XgridHideColumn({"trnid", "roomid", "datetrn", "guestid", "paymentreference"}, GridView1)
        XgridColAlign({"Folio No", "Adult", "Child", "Room No.", "Date Arival", "Time Arival", "Date Checkout", "Date Expired", "Status"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Payment Deposit"}, GridView1)
        XgridGeneralSummaryCurrency({"Payment Deposit"}, GridView1)
        txtfrmdate.Enabled = True
        txttodate.Enabled = True
        ckasof.Enabled = True
    End Sub

    Public Sub ViewInCheckOutGuest()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(datecheckout,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(datecheckout,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        LoadXgrid("select roomid,vip,datetrn,folioid, foliono as 'Folio No', roomcheckin as 'Room Check-in', ifnull((select roomnumber from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid),'-') as 'Room No.', " _
                           + " (select fullname from tblhotelguest where guestid=tblhotelroomtransaction.guestid) as 'Guest Name', " _
                           + " noadults as 'Adult', nochild as 'Child', " _
                           + " date_format(datecheckin, '%Y-%m-%d') as 'Date Check-in', " _
                           + " date_format(timecheckin, '%r') as 'Time Check-in', " _
                           + " date_format(datecheckout, '%Y-%m-%d') as 'Date Check-out', " _
                           + " date_format(timecheckout, '%r') as 'Time Check-out', " _
                           + " (select count(trnid) from tblhoteltransaction where folioid=tblhotelroomtransaction.folioid and roomcharge=1 and cancelled=0) as 'No. Days', " _
                           + " totalamount as 'Total Transaction',  " _
                           + " (select fullname from tblaccounts where accountid = tblhotelroomtransaction.trnby) as 'Transaction by' " _
                           + " from tblhotelroomtransaction where hotelcif='" & hotelcif.Text & "' and closed=1 and cancelled=0 and ((select roomnumber from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid) like '%" & txtsearch.Text & "%' or " _
                           + " (select fullname from tblhotelguest where guestid=tblhotelroomtransaction.guestid) like '%" & txtsearch.Text & "%' or " _
                           + " folioid like '%" & txtsearch.Text & "%') " & filterasof & " order by folioid asc", "tblhotelroomtransaction", Em, GridView1, Me)

        XgridHideColumn({"datetrn", "roomid", "vip", "folioid"}, GridView1)
        XgridColAlign({"Folio No", "Room No.", "Adult", "Child", "Date Check-in", "Time Check-in", "Date Check-out", "Time Check-out", "No. Days"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Total Transaction"}, GridView1)
        XgridGeneralSummaryCurrency({"Total Transaction"}, GridView1)

        txtfrmdate.Enabled = True
        txttodate.Enabled = True
        ckasof.Enabled = True

    End Sub

    Private Sub BarCheckItem1_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        Me.Close()
    End Sub

    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub


    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        FilterOption()
    End Sub


    Private Sub menu_Refresh_Click(sender As Object, e As EventArgs) Handles menu_Refresh.Click
        FilterOption()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintGeneralReportWithDate(ckasof.CheckState, txtfrmdate.EditValue, txttodate.EditValue, Me.Text & " - " & XtraTabControl1.SelectedTabPage.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ExportGridToExcel(XtraTabControl1.SelectedTabPage.Text & " Report " & If(ckasof.Checked = True, " as of " & CDate(txttodate.EditValue).ToString("yyyy-MM-dd"), "from " & CDate(txtfrmdate.EditValue).ToString("yyyy-MM-dd") & " to " & CDate(txttodate.EditValue).ToString("yyyy-MM-dd")), GridView1)
    End Sub

    Private Sub ViewProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProfileToolStripMenuItem.Click
        frmHotelGuestStatement.folioid.Text = GridView1.GetFocusedRowCellValue("folioid").ToString()
        frmHotelGuestStatement.Text = StrConv(GridView1.GetFocusedRowCellValue("Guest Name").ToString(), vbProperCase) & " Statement of Account"
        If frmHotelGuestStatement.Visible = True Then
            frmHotelGuestStatement.Focus()
        Else
            frmHotelGuestStatement.Show(Me)
        End If
    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        ViewProfileToolStripMenuItem.PerformClick()
    End Sub


    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

 
    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            FilterOption()
        End If
    End Sub
End Class