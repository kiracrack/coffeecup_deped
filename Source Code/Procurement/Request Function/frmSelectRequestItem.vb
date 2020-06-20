Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmSelectRequestItem
    Private Sub frmSelectPOItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        
        filterItem()
        txtfilter.Focus()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdBaritemAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdBaritemAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Enter) Then
            If CheckSelectedRow("productid", GridView1) = True Then
                If XtraMessageBox.Show("Are you sure you want to add this item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    frmQuantitySelect.pid.Text = pid.Text
                    frmQuantitySelect.officeid.Text = officeid.Text
                    frmQuantitySelect.proid.Text = GridView1.GetFocusedRowCellValue("productid").ToString()
                    frmQuantitySelect.Show(Me)
                End If
            End If
        ElseIf keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.F3) Then
            txtfilter.SelectAll()
            txtfilter.Focus()

        ElseIf keyData = (Keys.F5) Then
            filterItem()

        ElseIf keyData = (Keys.Control + Keys.N) Then
            If globalAllowAdd = True Or LCase(globaluser) = "root" Then
                AddProduct("", Me)
            End If

        End If

        Return ProcessCmdKey
    End Function

    Public Sub filterItem()
        LoadXgrid("Select productid, productid as 'Item Code', " _
                           + " ITEMNAME as 'Product Name', " _
                           + " tblprocategory.DESCRIPTION  as 'Category', Unit " _
                           + " from tblglobalproducts inner join tblprocategory on tblglobalproducts.catid = tblprocategory.catid " _
                           + " where deleted=0 and (ITEMNAME like '%" & rchar(txtfilter.Text) & "%' or PRODUCTID like '%" & rchar(txtfilter.Text) & "%')  and potypeid='" & potypeid.Text & "' " _
                           + " order by ITEMNAME asc", "tblglobalproducts", Em, GridView1, Me)


        GridView1.Columns("Item Code").Width = 70
        XgridColAlign({"Item Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Product Name").ColumnEdit = MemoEdit
        GridView1.Columns("productid").Visible = False
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        filterItem()
    End Sub

    Private Sub SelectItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectItemToolStripMenuItem.Click
        If CheckSelectedRow("productid", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to add this item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                frmQuantitySelect.pid.Text = pid.Text
                frmQuantitySelect.officeid.Text = officeid.Text
                frmQuantitySelect.proid.Text = GridView1.GetFocusedRowCellValue("productid").ToString()
                frmQuantitySelect.Show(Me)
            End If
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If CheckSelectedRow("productid", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to add this item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                frmQuantitySelect.pid.Text = pid.Text
                frmQuantitySelect.officeid.Text = officeid.Text
                frmQuantitySelect.proid.Text = GridView1.GetFocusedRowCellValue("productid").ToString()
                frmQuantitySelect.Show(Me)
            End If
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBaritemAdd.ItemClick
        AddProduct("po", Me)
    End Sub

    Private Sub txtfilter_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfilter.EditValueChanged
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filterItem()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub EditParticularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("productid") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        EditProduct(GridView1.GetFocusedRowCellValue("productid").ToString, Me)
    End Sub


End Class