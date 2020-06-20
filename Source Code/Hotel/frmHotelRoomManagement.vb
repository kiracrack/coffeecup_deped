Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmHotelRoomManagement
    Private BandgridView As GridView

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function
    Private Sub Vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(GridView2)
        filter()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdBarAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdNewVendor.Visible = True
        Else
            cmdBarAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdNewVendor.Visible = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
        LoadHotel()
    End Sub
    Public Sub LoadHotel()
        LoadXgridLookupEdit("select cifid, companyname as 'Select Hotel' from tblclientaccounts where hotelclient=1", "tblclientaccounts", txtHotel, GridView2, Me)
        GridView2.Columns("cifid").Visible = False
    End Sub
    Private Sub txtProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHotel.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtHotel.Properties.View.FocusedRowHandle.ToString)
        hotelcif.Text = txtHotel.Properties.View.GetFocusedRowCellValue("cifid").ToString()
        filter()
    End Sub
    Public Sub filter()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("Select roomtype, (select companyname from tblclientaccounts where cifid=tblhotelrooms.hotelcifid) as 'Hotel', roomid as 'Room Code', (select description from tblhotelroomtype where code=tblhotelrooms.roomtype) as 'Room Type',Cluster, roomnumber as 'Room Number',Description, Occupied, Maintainance,RoomStatus,Remarks from tblhotelrooms where hotelcifid='" & hotelcif.Text & "' and deleted=0 order by roomid asc ", "tblhotelrooms", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblhotelrooms")

        XgridHideColumn({"Room Code", "roomtype"}, GridView1)
        XgridColAlign({"Room Number", "Cluster", "RoomStatus"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Hotel"}, GridView1, 200)

        msda = New MySqlDataAdapter("select roomtype,Description, ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='roomrate'),0) as 'Room Rate', " _
                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='child'),0) as 'Child Rate', " _
                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='extra'),0) as 'Extra Person Rate', " _
                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='night'),0) as 'Extra Night Rate', Actived from tblhotelroomrates where temporaryrate=0", conn)
        msda.Fill(dst, "tblhotelroomrates")

        BandgridView = New GridView(Em)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblhotelrooms").Columns("roomtype")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblhotelroomrates").Columns("roomtype")

        dst.Relations.Add("RoomRates", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("RoomRates", BandgridView)

        Em.DataSource = dst.Tables("tblhotelrooms")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblhotelroomrates"))
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"roomtype"}, BandgridView)
        XgridColCurrency({"Room Rate", "Child Rate", "Extra Person Rate", "Extra Night Rate"}, BandgridView)
        XgridColWidth({"Description"}, BandgridView, 200)

        'SaveFilterColumn(GridView1, Me.Text)

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Room Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        frmHotelRoomInformation.mode.Text = ""
        frmHotelRoomInformation.rid.Text = GridView1.GetFocusedRowCellValue("Room Code").ToString
        frmHotelRoomInformation.mode.Text = "edit"
        If frmHotelRoomInformation.Visible = True Then
            frmHotelRoomInformation.Focus()
        Else
            frmHotelRoomInformation.Show(Me)
        End If
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If GridView1.GetFocusedRowCellValue("Room Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblhotelrooms set deleted=1, deletedby='" & globaluserid & "',datedeleted=current_timestamp where roomid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Room Code").ToString & "'" : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub NewVendorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewVendor.Click
        If frmHotelRoomInformation.Visible = True Then
            frmHotelRoomInformation.Focus()
        Else
            frmHotelRoomInformation.Show(Me)
        End If
    End Sub


    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBarAdd.ItemClick
        cmdNewVendor.PerformClick()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub


    Private Sub FormatGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatGridToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub ViewInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInformationToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Room Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmHotelRoomComplementary.rid.Text = GridView1.GetFocusedRowCellValue("Room Code").ToString
        If frmHotelRoomComplementary.Visible = True Then
            frmHotelRoomComplementary.Focus()
        Else
            frmHotelRoomComplementary.Show(Me)
        End If
    End Sub

    Private Sub cmdColumnFilter_Click(sender As Object, e As EventArgs) Handles cmdColumnFilter.Click
        Dim colname As String = ""
        Dim I As Integer = 0
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub UpdateRoomStatusToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmHotelUpdateRoomStatus.txtHotel.Text = GridView1.GetFocusedRowCellValue("Hotel").ToString
        frmHotelUpdateRoomStatus.rid.Text = GridView1.GetFocusedRowCellValue("Room Code").ToString
        If frmHotelUpdateRoomStatus.Visible = True Then
            frmHotelUpdateRoomStatus.Focus()
        Else
            frmHotelUpdateRoomStatus.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintGeneralReport("Room Summary Reports", Me.Text, GridView1, Me)
    End Sub

    Private Sub cmdRoomType_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdRoomType.ItemClick
        If hotelcif.Text = "" Then
            XtraMessageBox.Show("Please select hotel!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            hotelcif.Focus()
            Exit Sub
        End If
        frmHotelRoomType.hotelcif.Text = hotelcif.Text
        If frmHotelRoomType.Visible = True Then
            frmHotelRoomType.Focus()
        Else
            frmHotelRoomType.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If hotelcif.Text = "" Then
            XtraMessageBox.Show("Please select hotel!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            hotelcif.Focus()
            Exit Sub
        End If
        frmHotelRoomRate.hotelcif.Text = hotelcif.Text
        If frmHotelRoomRate.Visible = True Then
            frmHotelRoomRate.Focus()
        Else
            frmHotelRoomRate.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If frmHotelPackageItem.Visible = True Then
            frmHotelPackageItem.Focus()
        Else
            frmHotelPackageItem.Show(Me)
        End If
    End Sub
End Class