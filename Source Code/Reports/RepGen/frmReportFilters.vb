Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmReportFilters

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmProductFilter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        rst.Close()
    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(s_type)
        LoadUserFilters()
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub

    Public Sub LoadUserFilters()
        LoadXgridLookupEdit("select code, Description from tblreporttemplatetype", "tblreporttemplatetype", txtCoffeecupUser, s_type, Me)
        s_type.Columns("code").Visible = False
    End Sub

    Private Sub txtPurchaseType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCoffeecupUser.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCoffeecupUser.Properties.View.FocusedRowHandle.ToString)
        code.Text = txtCoffeecupUser.Properties.View.GetFocusedRowCellValue("code").ToString()
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub

    Public Sub ShowUnfilteredClient()
        Dim cifquery As String = ""
        com.CommandText = "select permissioncode from tblreportfilter where filtercode='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            cifquery = cifquery + "'" & rst("permissioncode").ToString & "',"
        End While
        rst.Close()
        If cifquery.Length > 0 Then
            cifquery = cifquery.Remove(cifquery.Length - 1, 1)
            cifquery = " where authCode not in(" & cifquery & ")"
        End If
        If code.Text <> "" Then
            LoadXgrid("select authCode, authDescription as 'User Permission' from tbluserauthority " & cifquery & " order by authDescription asc", "tbluserauthority", Em_unfiltered, GridView1, Me)
            GridView1.Columns("authCode").Visible = False
        End If
    End Sub

    Public Sub ShowfilteredClients()
        If code.Text <> "" Then
            LoadXgrid("select permissioncode, (select authDescription from tbluserauthority where authCode= tblreportfilter.permissioncode) as 'User Permission' from tblreportfilter where filtercode='" & code.Text & "' order by (select authDescription from tbluserauthority where authCode= tblreportfilter.permissioncode)  asc", "tblreportfilter", Em_filtered, GridView2, Me)
            GridView2.Columns("permissioncode").Visible = False
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "insert into tblreportfilter set permissioncode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "authCode").ToString & "', filtercode='" & code.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To GridView2.SelectedRowsCount - 1
            com.CommandText = "delete from tblreportfilter where permissioncode='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "permissioncode").ToString & "' and filtercode='" & code.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub
End Class

