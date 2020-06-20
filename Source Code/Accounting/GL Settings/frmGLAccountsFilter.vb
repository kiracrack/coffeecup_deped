Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmGLAccountsFilter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGLAccountsFilter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        rst.Close()
    End Sub

    Private Sub frmGLAccountsFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCompany()
        LoadCategory()
    End Sub

    Public Sub LoadCompany()
        LoadXgridLookupSearch("SELECT code as compid,companyname as 'Select Company' from tblcompany order by companyname asc", "tblcompany", txtCompany, GridView_company, Me)
        GridView_company.Columns("compid").Visible = False
    End Sub
    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        compid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("compid").ToString()
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub


    Public Sub LoadCategory()
        LoadXgridLookupSearch("select authCode,authDescription 'Select Permission' from tbluserauthority order by authDescription asc", "tbluserauthority", txtPermission, gvpermission, Me)
        gvpermission.Columns("authCode").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPermission.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtPermission.Properties.View.FocusedRowHandle.ToString)
        permissioncode.Text = txtPermission.Properties.View.GetFocusedRowCellValue("authCode").ToString()
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Public Sub ShowUnfilteredProducts()
        Dim productquery As String = ""
        com.CommandText = "select itemcode from tblglaccountfilter where companyid='" & compid.Text & "' and permissioncode='" & permissioncode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            productquery = productquery + "'" & rst("itemcode").ToString & "',"
        End While
        rst.Close()
        If productquery.Length > 0 Then
            productquery = productquery.Remove(productquery.Length - 1, 1)
            productquery = " and itemcode not in (" & productquery & ")"
        End If
        If permissioncode.Text <> "" Then
            LoadXgrid("select itemcode, itemname as 'Item Name' from tblglitem where companyid='" & compid.Text & "' and sl=1 " & productquery & " ", "tblglitem", Em_unfiltered, GridView1, Me)
            GridView1.Columns("itemcode").Visible = False
        End If
    End Sub

    Public Sub ShowfilteredProducts()
        If permissioncode.Text <> "" Then
            LoadXgrid("select itemcode, (select itemname from tblglitem where companyid='" & compid.Text & "' and itemcode= tblglaccountfilter.itemcode) as 'Item Name' from tblglaccountfilter where companyid='" & compid.Text & "' and permissioncode='" & permissioncode.Text & "' order by itemcode asc", "tblglaccountfilter", Em_filtered, GridView2, Me)
            GridView2.Columns("itemcode").Visible = False
        End If
    End Sub

    
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        If txtCompany.Text = "" Then
            XtraMessageBox.Show("Please select company!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCompany.Focus()
            Exit Sub
        End If
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "insert into tblglaccountfilter set companyid='" & compid.Text & "', permissioncode='" & permissioncode.Text & "', itemcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "itemcode").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        If txtCompany.Text = "" Then
            XtraMessageBox.Show("Please select company!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCompany.Focus()
            Exit Sub
        End If
        For I = 0 To GridView2.SelectedRowsCount - 1
            com.CommandText = "delete from tblglaccountfilter where companyid='" & compid.Text & "' and itemcode='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "itemcode").ToString & "' and permissioncode='" & permissioncode.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

  
End Class

