Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmProductFilter
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
        LoadCategory()
        ShowUnfilteredProducts()
        ShowfilteredProducts()
        CheckEdit1.Checked = GlobalenableProductFilter
    End Sub
     
    Public Sub LoadCategory()
        LoadXgridLookupSearch("select catid,DESCRIPTION 'Select Category' from tblprocategory order by DESCRIPTION asc", "tblprocategory", txtprocat, combogrid, Me)
        combogrid.Columns("catid").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocat.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("catid").ToString()
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Public Sub ShowUnfilteredProducts()
        Dim productquery As String = ""
        com.CommandText = "select permissioncode from tblproductfilter where categorycode='" & catid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            productquery = productquery + "'" & rst("permissioncode").ToString & "',"
        End While
        rst.Close()
        If productquery.Length > 0 Then
            productquery = productquery.Remove(productquery.Length - 1, 1)
            productquery = " where authCode not in (" & productquery & ")"
        End If
        If catid.Text <> "" Then
            LoadXgrid("select authCode, authDescription as 'User Permission' from tbluserauthority " & productquery & " order by authDescription asc", "tbluserauthority", Em_unfiltered, GridView1, Me)
            GridView1.Columns("authCode").Visible = False
        End If
    End Sub

    Public Sub ShowfilteredProducts()
        If catid.Text <> "" Then
            LoadXgrid("select permissioncode, (select authDescription from tbluserauthority where authCode= tblproductfilter.permissioncode) as 'User Permission' from tblproductfilter where categorycode='" & catid.Text & "' order by (select authDescription from tbluserauthority where authCode= tblproductfilter.permissioncode)  asc", "tblproductfilter", Em_filtered, GridView2, Me)
            GridView2.Columns("permissioncode").Visible = False
        End If
    End Sub
 
    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub
 
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "insert into tblproductfilter set categorycode='" & catid.Text & "', permissioncode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "authCode").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To GridView2.SelectedRowsCount - 1
            com.CommandText = "delete from tblproductfilter where permissioncode='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "permissioncode").ToString & "' and categorycode='" & catid.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtprocat.Enabled = True
            cmdMoveLeft.Enabled = True
            cmdMoveRight.Enabled = True
        Else
            txtprocat.Enabled = False
            cmdMoveLeft.Enabled = False
            cmdMoveRight.Enabled = False
        End If
        com.CommandText = "update tblgeneralsettings set enableproductfilter=" & CheckEdit1.CheckState & " where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
        GlobalenableProductFilter = CheckEdit1.CheckState
    End Sub
End Class

