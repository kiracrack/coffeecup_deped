Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.IO
Imports DevExpress.Skins

Public Class frmHotelTablesAndCottages
    Private Sub frmChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadCategory()
        loadProduct()
        Loadhotelcottages()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdremove.Visible = True
            ToolStripSeparator2.Visible = True
        Else
            cmdremove.Visible = False
            ToolStripSeparator2.Visible = False
        End If
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupEdit("select CATID,DESCRIPTION 'Select Category' from tblprocategory where noninventory=1 order by id asc", "tblprocategory", txtprocat, combogrid, Me)
        combogrid.Columns("CATID").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocat.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("CATID").ToString()
        txtprocat.Text = txtprocat.Properties.View.GetFocusedRowCellValue("Select Category").ToString()
        loadProduct()
    End Sub

    Public Sub loadProduct()
        ls.Items.Clear()
        com.CommandText = "select * from tblglobalproducts where catid='" & catid.Text & "' and productid not in (select productid from tblhotelcottages) order by itemname asc" : rst = com.ExecuteReader
        While rst.Read
            ls.Items.Add(rst("productid"), False)
            ls.Items.Item(rst("productid")).Description = rst("itemname").ToString
            ls.Items.Item(rst("productid")).Value = rst("productid").ToString
        End While
        rst.Close()
    End Sub

    Public Sub Loadhotelcottages()
        LoadXgrid("select id, (select itemname from tblglobalproducts where productid = tblhotelcottages.productid) as 'Item Name',(select (select description from tblprocategory where catid = tblglobalproducts.catid) from tblglobalproducts where productid = tblhotelcottages.productid) as 'Category',case when availability=-1 then 'Reserved' when availability=0 then 'Available' when availability=1 then 'Occupied' end as 'Availability'  from tblhotelcottages order by (select itemname from tblglobalproducts where productid = tblhotelcottages.productid) asc", "tblhotelcottages", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        XgridColAlign({"Availability"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Category").Group()
        GridView1.ExpandAllGroups()
        GridView1.BestFitColumns()
    End Sub
    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If XtraMessageBox.Show("Are you sure you want to continue save?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For n = 0 To ls.CheckedItems.Count - 1
                If countqry("tblhotelcottages", "productid='" & ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString & "'") = 0 Then
                    com.CommandText = "insert into tblhotelcottages set productid='" & ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
                End If
            Next
            loadProduct()
            Loadhotelcottages()
            XtraMessageBox.Show("Tables and Cottages Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For n = 0 To ls.ItemCount - 1
            If CheckEdit1.Checked = True Then
                ls.Items.Item(n).CheckState = CheckState.Checked
            Else
                ls.Items.Item(n).CheckState = CheckState.Unchecked
            End If
        Next
    End Sub

    Private Sub txtfilter_EditValueChanged(sender As Object, e As EventArgs)
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        loadProduct()
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdInactive_Click(sender As Object, e As EventArgs) Handles cmdremove.Click
        If XtraMessageBox.Show("Are you sure you want to continue remove?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("id", "id", "tblhotelcottages", GridView1, Me)
            loadProduct()
            Loadhotelcottages()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        loadProduct()
        Loadhotelcottages()
    End Sub


End Class