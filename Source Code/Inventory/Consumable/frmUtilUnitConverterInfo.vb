Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Utils

Public Class frmUtilUnitConverterInfo
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


    Private Sub frmUtilUnitConverterInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gridMenuProduct)
        LoadGridviewAppearance(gridItemMenu)
        LoadSourceProduct()
        LoadDetailsProduct()
        filterConvertion()

        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Visible = True
        Else
            cmdRemove.Visible = False
        End If
    End Sub
    Public Sub ShowConvertionInfo()
        com.CommandText = "select *, (select itemname from tblglobalproducts where productid =tblunitconverter.productid_source) as 'SourceProduct', " _
                  + " (select unit from tblglobalproducts where productid =tblunitconverter.productid_source) as 'SourceUnit', " _
                  + " (select itemname from tblglobalproducts where productid =tblunitconverter.productid_target) as 'ConvertionProduct', " _
                  + " (select unit from tblglobalproducts where productid =tblunitconverter.productid_target) as 'ConvertionUnit' " _
                  + " from tblunitconverter where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            productid_source.Text = rst("productid_source").ToString
            txtSourceProduct.Text = rst("SourceProduct").ToString
            txtSourceUnitType.Text = rst("SourceUnit").ToString
            txtSourceQuantity.Text = rst("quantity_source").ToString

            productid_item.Text = rst("productid_target").ToString
            txtConvertionProduct.Text = rst("ConvertionProduct").ToString
            txtTargetUnitType.Text = rst("ConvertionUnit").ToString
            txtTargetQuantity.Text = rst("quantity_target").ToString
            ckAutoCorvert.Checked = rst("autoconvert")
        End While
        rst.Close()
    End Sub
    Public Sub filterConvertion()
        LoadXgrid("Select id, (select itemname from tblglobalproducts where productid =tblunitconverter.productid_source) as 'Source Product ', " _
                  + " quantity_source as 'Source Quantity', " _
                  + " (select unit from tblglobalproducts where productid =tblunitconverter.productid_source) as 'Source Unit', " _
                  + " (select itemname from tblglobalproducts where productid =tblunitconverter.productid_target) as 'Convertion Product', " _
                  + " quantity_target as 'Total Quantity Convertion', " _
                  + " (select unit from tblglobalproducts where productid =tblunitconverter.productid_target) as 'Convertion Unit', " _
                  + " autoconvert as 'Execute Auto Convert' " _
                  + " from tblunitconverter", "Total Quantity Convertion", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"Source Quantity", "Total Quantity Convertion", "Source Unit", "Convertion Unit"}, GridView1, HorzAlignment.Center)
    End Sub

    Public Sub LoadSourceProduct()
        LoadXgridLookupSearch("SELECT productid, itemname as 'Source Product', Unit from tblglobalproducts where deleted=0 and catid in (select catid from tblprocategory where consumable=1) order by itemname asc", "tblglobalproducts", txtSourceProduct, gridMenuProduct, Me)
        gridMenuProduct.Columns("productid").Visible = False
    End Sub

    Private Sub txtSourceProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSourceProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtSourceProduct.Properties.View.FocusedRowHandle.ToString)
        productid_source.Text = txtSourceProduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtSourceUnitType.Text = txtSourceProduct.Properties.View.GetFocusedRowCellValue("Unit").ToString()
        'filterConvertion()
    End Sub

    Public Sub LoadDetailsProduct()
        LoadXgridLookupSearch("SELECT productid, itemname as 'Target Product',Unit from tblglobalproducts where deleted=0 and productid <> '" & productid_source.Text & "' and catid in (select catid from tblprocategory where consumable=1)  order by itemname asc", "tblglobalproducts", txtConvertionProduct, gridItemMenu, Me)
        gridItemMenu.Columns("productid").Visible = False
    End Sub

    Private Sub txtItemMenu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConvertionProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtConvertionProduct.Properties.View.FocusedRowHandle.ToString)
        productid_item.Text = txtConvertionProduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtTargetUnitType.Text = txtConvertionProduct.Properties.View.GetFocusedRowCellValue("Unit").ToString()
        txtTargetQuantity.Focus()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtSourceProduct.Text = "" Then
            XtraMessageBox.Show("Please Select Source Product", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSourceProduct.Focus()
            Exit Sub
        ElseIf txtSourceQuantity.EditValue <= 0 Then
            XtraMessageBox.Show("Please enter valid quantity from source product", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSourceQuantity.Focus()
            Exit Sub
        ElseIf txtConvertionProduct.Text = "" Then
            XtraMessageBox.Show("Please select target product item", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtConvertionProduct.Focus()
            Exit Sub
        ElseIf txtTargetQuantity.EditValue <= 0 Then
            XtraMessageBox.Show("Please enter valid quantity from target product", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTargetQuantity.Focus()
            Exit Sub
        End If
        If id.Text <> "" Then
            com.CommandText = "UPDATE tblunitconverter set productid_source='" & productid_source.Text & "', quantity_source='" & Val(CC(txtSourceQuantity.Text)) & "', productid_target='" & productid_item.Text & "', quantity_target='" & Val(CC(txtTargetQuantity.Text)) & "', autoconvert='" & ckAutoCorvert.CheckState & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblunitconverter set productid_source='" & productid_source.Text & "', quantity_source='" & Val(CC(txtSourceQuantity.Text)) & "', productid_target='" & productid_item.Text & "', quantity_target='" & Val(CC(txtTargetQuantity.Text)) & "', autoconvert='" & ckAutoCorvert.CheckState & "'" : com.ExecuteNonQuery()
        End If

        filterConvertion() : clearInfo()
        XtraMessageBox.Show("Convertion successfully saved", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
       
    End Sub

    Public Sub clearInfo()
        id.Text = ""
        txtSourceProduct.Properties.DataSource = Nothing
        txtSourceProduct.Text = ""
        productid_source.Text = ""
        txtSourceQuantity.Text = "1"
        LoadSourceProduct()

        txtConvertionProduct.Properties.DataSource = Nothing
        txtConvertionProduct.Text = ""
        productid_item.Text = ""
        txtTargetQuantity.Text = "0"
        ckAutoCorvert.Checked = False
        LoadDetailsProduct()
        txtSourceProduct.Focus()
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("id", "id", "tblunitconverter", GridView1, Me)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterConvertion()
    End Sub

    Private Sub EditConvetionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditConvetionToolStripMenuItem.Click
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        ShowConvertionInfo()
    End Sub
End Class