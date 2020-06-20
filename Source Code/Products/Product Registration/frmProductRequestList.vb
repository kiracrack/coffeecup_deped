Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmProductRequestList

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me) 
        LoadGridviewAppearance(GridView1)
        filterRequestList()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdREceive.Visible = True
        Else
            cmdREceive.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdCancel.Visible = True
        Else
            cmdCancel.Visible = False
        End If

        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
    End Sub
 
    Public Sub filterRequestList()
        On Error Resume Next
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " where date_format(daterequest,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " where date_format(daterequest,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        LoadXgrid("Select id,officeid, " _
                + " (select officename from tblcompoffice where officeid = tblproductrequest.officeid) as '" & GlobalOfficeCaption & "', " _
                + " itemname as 'Item Name', " _
                + " Unit, " _
                + " Message,  date_format(daterequest,'%Y-%m-%d %r')  as 'Date Request', isread, " _
                + " (select fullname from tblaccounts where accountid = tblproductrequest.requestid) as 'Request By' " _
                + If(ckPending.Checked = False, ",Confirmed, Cancelled ", "") _
                + " from tblproductrequest " & If(ckPending.Checked = True, "where confirmed=0 and cancelled=0", filterasof) _
                + " order by daterequest desc", "tblproductrequest", Em, GridView1, Me)

        XgridHideColumn({"id", "isread", "officeid"}, GridView1)
        GridView1.BestFitColumns()

    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        filterRequestList()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    
    Private Sub ViewRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdREceive.Click
        frmProductRequestInformation.id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        frmProductRequestInformation.Show(Me)
    End Sub

    Private Sub menu_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If CheckSelectedRow("Item Name", GridView1) = True Then
            frmCancelProductRegistration.Show(Me)
        End If
    End Sub

    Public Sub CancelledRequest(ByVal remarks As String)
        Dim I As Integer = 0
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblproductrequest set cancelled=1, datecancelled=current_timestamp, cancelledremarks='" & rchar(remarks) & "', cancelledby='" & globaluserid & "' where id ='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
        Next
        XtraMessageBox.Show("Request Successfuly Cancelled!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        filterRequestList()
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub ckPending_CheckedChanged(sender As Object, e As EventArgs) Handles ckPending.CheckedChanged
        If ckPending.Checked = True Then
            txttodate.Enabled = False
            txtfrmdate.Enabled = False
            ckasof.Enabled = False
            cmdCancel.Visible = True
            cmdREceive.Visible = True
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
            ckasof.Enabled = True
            cmdCancel.Visible = False
            cmdREceive.Visible = False
        End If
        filterRequestList()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        PrintGeneralReport(Me.Text, "", gridview1, Me)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub
End Class