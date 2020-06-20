Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmClinicsClientManagement
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
        filter()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdBarAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdBarAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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

    End Sub

    Public Sub filter()
        LoadXgrid("select clientid, fullname as 'Client Name', Address, date_format(birthdate,'%Y-%m-%d') as 'Birthdate', Gender, contactnumber as 'Contact Number',emailadd as 'Email Address'  from tblclinicsclients where deleted=0 " _
                                    + "  order by fullname asc", "tblclinicsclients", Em, GridView1, Me)

        GridView1.Columns("clientid").Visible = False
        XgridColAlign({"Contact Number", "Country", "Birthdate", "Gender"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Credit Limit"}, GridView1)

        SaveFilterColumn(GridView1, Me.Text)

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("clientid") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        frmClinicsClientInformation.mode.Text = ""
        frmClinicsClientInformation.clientid.Text = GridView1.GetFocusedRowCellValue("clientid").ToString
        frmClinicsClientInformation.mode.Text = "edit"
        If frmClinicsClientInformation.Visible = True Then
            frmClinicsClientInformation.Focus()
        Else
            frmClinicsClientInformation.Show(Me)
        End If
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If GridView1.GetFocusedRowCellValue("clientid") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            RemoveRow("clientid", "clientid", "tblclinicsclients", GridView1, Me)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub


    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBarAdd.ItemClick
        frmClinicsClientInformation.Show(Me)
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

    Private Sub UpdateRoomStatusToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmHotelUpdateRoomStatus.rid.Text = GridView1.GetFocusedRowCellValue("clientid").ToString
        If frmHotelUpdateRoomStatus.Visible = True Then
            frmHotelUpdateRoomStatus.Focus()
        Else
            frmHotelUpdateRoomStatus.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintGeneralReport("Clinics Patient Summary Reports", Me.Text, gridview1, Me)
    End Sub
End Class