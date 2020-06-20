Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Public Class frmVendorsManagement
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
    End Sub

    Public Sub filter()
        LoadXgrid("Select vendorid as 'Vendor ID', " _
                  + " COMPANYNAME as 'Company Name', " _
                  + " compadd as 'Address', " _
                  + " TELEPHONE as 'Telephone',EMAIL as 'Email Address',WEBSITE as 'Website', " _
                  + " CONTPERSON as 'Contact Person',DESIGNATION as 'Designation',pmtinterval as 'Pmt. Interval', rebaterate as 'Rebate Rate' from tblglobalvendor order by COMPANYNAME asc ", "tblglobalvendor", Em, GridView1, Me)

        XgridColAlign({"Vendor ID", "Pmt. Interval", "Rebate Rate"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("Address").ColumnEdit = MemoEdit
        GridView1.Columns("Email Address").ColumnEdit = MemoEdit

    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Vendor ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        frmVendorInformation.mode.Text = ""
        frmVendorInformation.id.Text = GridView1.GetFocusedRowCellValue("Vendor ID").ToString
        frmVendorInformation.mode.Text = "edit"
        If frmVendorInformation.Visible = True Then
            frmVendorInformation.Focus()
        Else
            frmVendorInformation.Show(Me)
        End If
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If GridView1.GetFocusedRowCellValue("Vendor ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("Vendor ID", "vendorid", "tblglobalvendor", GridView1, Me)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub NewVendorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewVendor.Click
        If frmVendorInformation.Visible = True Then
            frmVendorInformation.Focus()
        Else
            frmVendorInformation.Show(Me)
        End If
    End Sub


    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBarAdd.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmVendorInformation.Visible = True Then
            frmVendorInformation.Focus()
        Else
            frmVendorInformation.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
 
    Private Sub FormatGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatGridToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub
 
    Private Sub cmdPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
        PrintGeneralReport(Me.Text, "", GridView1, Me)
    End Sub

    Private Sub cmdExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExport.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub
End Class