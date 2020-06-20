Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmProductServiceMenuMaker
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmProductServiceMenuMaker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gridMenuProduct)
        LoadGridviewAppearance(gridItemMenu)
        LoadSourceProduct()
        LoadDetailsProduct()
        filter()

        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Visible = True
        Else
            cmdRemove.Visible = False
        End If
    End Sub

    Public Sub filter()
        LoadXgrid("Select id, (select itemname from tblglobalproducts where productid=tblproductserviceitem.productid) as 'Product Name', Amount  from tblproductserviceitem where source_productid = '" & productid_source.Text & "'", "tblproductserviceitem", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        XgridColCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub LoadSourceProduct()
        LoadXgridLookupSearch("SELECT productid, itemname as 'Menu Product' from tblglobalproducts where allownegativeinputs=0 and deleted=0 and (servicemenuproduct=1 or customproductorder=1) and catid in (select catid from tblprocategory where noninventory=1) order by itemname asc", "tblglobalproducts", txtSourceProduct, gridMenuProduct, Me)
        gridMenuProduct.Columns("productid").Visible = False
    End Sub

    Private Sub txtSourceProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSourceProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtSourceProduct.Properties.View.FocusedRowHandle.ToString)
        productid_source.Text = txtSourceProduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        filter()
    End Sub

    Public Sub LoadDetailsProduct()
        LoadXgridLookupSearch("SELECT productid, itemname as 'Services', sellingprice as 'Amount' from tblglobalproducts where allownegativeinputs=0 and deleted=0 and servicemenuproduct=0 and customproductorder=0 and catid not in (select catid from tblprocategory where ffe=1) order by itemname asc", "tblglobalproducts", txtItemMenu, gridItemMenu, Me)
        gridItemMenu.Columns("productid").Visible = False
        XgridColCurrency({"Amount"}, gridItemMenu)
    End Sub

    Private Sub txtItemMenu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemMenu.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtItemMenu.Properties.View.FocusedRowHandle.ToString)
        productid_item.Text = txtItemMenu.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtAmount.Text = txtItemMenu.Properties.View.GetFocusedRowCellValue("Amount").ToString()
        txtAmount.Focus()
    End Sub
 
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtSourceProduct.Text = "" Then
            XtraMessageBox.Show("Please select main menu", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSourceProduct.Focus()
            Exit Sub
        ElseIf txtItemMenu.Text = "" Then
            XtraMessageBox.Show("Please select item menu", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtItemMenu.Focus()
            Exit Sub
            'ElseIf txtAmount.EditValue = 0 Then
            '    XtraMessageBox.Show("Please enter valid amount", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    txtAmount.Focus()
            '    Exit Sub
        ElseIf countqry("tblproductserviceitem", "source_productid='" & productid_source.Text & "' and productid='" & productid_item.Text & "'") > 0 Then
            XtraMessageBox.Show("Sub item already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItemMenu.Focus()
            Exit Sub
        End If
        com.CommandText = "insert into tblproductserviceitem set source_productid='" & productid_source.Text & "', productid='" & productid_item.Text & "', amount='" & Val(CC(txtAmount.Text)) & "'" : com.ExecuteNonQuery()
        filter()
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("id", "id", "tblproductserviceitem", GridView1, Me)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

 
End Class