Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmAdjustmentSales
    Private ttlquan As Double
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmAdjustmentSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadCompOffice()
        LoadGridviewAppearance(gridcompoffice)
        LoadGridviewAppearance(gridProduct)
    End Sub
    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Inventory' from tblcompoffice order by officename", "tblcompoffice", txtoffice, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False
        Me.txtoffice.Properties.DisplayMember = "Inventory"
        Me.txtoffice.Properties.ValueMember = "Inventory"
    End Sub
    Private Sub txtcompoffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtoffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
        txtoffice.Text = txtoffice.Properties.View.GetFocusedRowCellValue("Inventory").ToString
        If officeid.Text <> "" Then
            loadProduct()
        End If
    End Sub

    Public Sub loadProduct()
        LoadXgridLookupSearch("select trnid,productid, (select itemname from tblglobalproducts where productid=tblinventory.productid and actived=1)  as 'Product Name',sellingprice as 'Selling Price' from tblinventory where officeid = '" & officeid.Text & "' order by (select itemname from tblglobalproducts where productid=tblinventory.productid and actived=1)", "tblinventory", txtProduct, gridProduct, Me)
        gridProduct.Columns("trnid").Visible = False
        gridProduct.Columns("productid").Visible = False
        Me.txtProduct.Properties.DisplayMember = "Product Name"
        Me.txtProduct.Properties.ValueMember = "Product Name"
        XgridColCurrency({"Selling Price"}, gridProduct)
    End Sub
    Private Sub txtProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProduct.Properties.View.FocusedRowHandle.ToString)
        productid.Text = txtProduct.Properties.View.GetFocusedRowCellValue("productid").ToString
        trnid.Text = txtProduct.Properties.View.GetFocusedRowCellValue("trnid").ToString
        txtProduct.Text = txtProduct.Properties.View.GetFocusedRowCellValue("Product Name").ToString
        txtCurrentCost.Text = txtProduct.Properties.View.GetFocusedRowCellValue("Selling Price").ToString
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If XtraMessageBox.Show("Continue confirm Price Adjustment inventory?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If radAdjType.SelectedIndex = 0 Then
                com.CommandText = "update tblinventory set sellingprice=sellingprice+" & Val(CC(txtAmountAdj.Text)) & " where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblglobalproducts set sellingprice=sellingprice+" & Val(CC(txtAmountAdj.Text)) & " where productid='" & productid.Text & "' and actived=1" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblinventory set sellingprice=sellingprice-" & Val(CC(txtAmountAdj.Text)) & " where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblglobalproducts set sellingprice=sellingprice-" & Val(CC(txtAmountAdj.Text)) & " where productid='" & productid.Text & "' and actived=1" : com.ExecuteNonQuery()
            End If
            com.CommandText = "insert into tblinventoryamountadj set officeid='" & officeid.Text & "', productid='" & productid.Text & "', adjtype='" & radAdjType.EditValue & "', amount='" & Val(CC(txtAmountAdj.Text)) & "', remarks='" & rchar(txtRemarks.Text) & "', dateadj=current_timestamp, trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            XtraMessageBox.Show("Inventory successfully adjusted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class