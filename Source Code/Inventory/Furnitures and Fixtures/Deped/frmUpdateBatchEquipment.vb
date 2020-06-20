Imports DevExpress.XtraEditors

Public Class frmUpdateBatchEquipment
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChangeLeader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadProducts()
    End Sub

    Public Sub loadProducts()
        LoadXgridLookupSearch("SELECT distinct(productid),tblglobalproducts.catid,tblglobalproducts.subcatid,codename, if(partnumber='' or partnumber is null,itemname,concat(itemname,'-',partnumber)) as 'Select Product' , Unit, purchasedprice from tblglobalproducts inner join tblprocategory on  tblprocategory.catid = tblglobalproducts.catid where deleted=0 and ffe=1 order by itemname asc ", "tblglobalproducts", txtProductItemName, g_product, Me)
        g_product.BestFitColumns()
        XgridHideColumn({"productid", "catid", "purchasedprice", "subcatid", "codename"}, g_product)
        g_product.Columns("Select Product").Width = 350
    End Sub

    Private Sub txtProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductItemName.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProductItemName.Properties.View.FocusedRowHandle.ToString)
        productid.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtUnit.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("Unit").ToString()
        catid.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("catid").ToString()
        subcatid.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("subcatid").ToString()
        codename.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("codename").ToString()
        LoadModel()

    End Sub

    Public Sub LoadModel()
        If productid.Text = "" Then Exit Sub
        LoadXgridLookupSearch("select code, Description as 'Model' from tblofficeequipmentmodel where productid='" & productid.Text & "' order by description asc", "tblofficeequipmentmodel", txtModel, gridModel, Me)
        gridModel.Columns("code").Visible = False
    End Sub

    Private Sub txtModel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModel.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtModel.Properties.View.FocusedRowHandle.ToString)
        modelcode.Text = txtModel.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        frmDepedFFESummary.UpdateProduct(productid.Text, txtProductItemName.Text, codename.Text, txtUnit.Text, catid.Text, subcatid.Text, modelcode.Text, txtModel.Text)
        Me.Close()
    End Sub

    Private Sub cmdAddItem_Click(sender As Object, e As EventArgs) Handles cmdAddItem.Click
        If frmProductTemplate1.Visible = True Then
            frmProductTemplate1.Focus()
        Else
            frmProductTemplate1.ShowDialog(Me)
            loadProducts()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If productid.Text = "" Then
            XtraMessageBox.Show("Please select product!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        frmEquipmentModel.productid.Text = productid.Text
        frmEquipmentModel.ShowDialog(Me)
        LoadModel()
    End Sub
End Class