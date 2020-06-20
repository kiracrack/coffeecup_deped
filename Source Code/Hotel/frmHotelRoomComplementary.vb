Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
 
Public Class frmHotelRoomComplementary
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelRoomComplementary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadProduct()
        LoadSpecialProduct()
    End Sub
    Public Sub LoadProduct()
        LoadXgridLookupSearch("select productid, itemname as 'Product Name',Unit from tblglobalproducts where deleted=0 and catid in (select catid from tblprocategory where consumable=1)", "tblglobalproducts", txtProduct, gridProduct, Me)
        gridProduct.Columns("productid").Visible = False
    End Sub
    Private Sub txtProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProduct.Properties.View.FocusedRowHandle.ToString)
        productid.Text = txtProduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtProduct.Text = txtProduct.Properties.View.GetFocusedRowCellValue("Product Name").ToString()
        txtUnit.Text = txtProduct.Properties.View.GetFocusedRowCellValue("Unit").ToString()
    End Sub
    Public Sub LoadSpecialProduct()
        LoadXgrid("select id, (select itemname from tblglobalproducts where productid=tblhotelroomsamenities.productid and actived=1) as 'Product', Quantity, Unit   from tblhotelroomsamenities where roomid='" & rid.Text & "'", "tblhotelroomsamenities", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        GridView1.Columns("Quantity").Width = 80
        XgridColAlign({"Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Quantity"}, GridView1)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtProduct.Text = "" Then
            XtraMessageBox.Show("Please Select Product!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProduct.Focus()
            Exit Sub
        ElseIf txtQuantity.Text = "0.00" Then
            XtraMessageBox.Show("Please enter quantity!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuantity.Focus()
            Exit Sub
        ElseIf countqry("tblhotelroomsamenities", "productid='" & productid.Text & "' and roomid='" & rid.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Product is already added!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProduct.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to save special product?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblhotelroomsamenities set productid='" & productid.Text & "', quantity='" & Val(CC(txtQuantity.Text)) & "', unit='" & txtUnit.Text & "' where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblhotelroomsamenities set roomid='" & rid.Text & "', productid='" & productid.Text & "', quantity='" & Val(CC(txtQuantity.Text)) & "', unit='" & txtUnit.Text & "'" : com.ExecuteNonQuery()
            End If
            txtProduct.Properties.DataSource = Nothing
            txtProduct.Text = "" : productid.Text = "" : txtQuantity.Text = "0"
            LoadProduct() : LoadSpecialProduct()
            XtraMessageBox.Show("Product successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub cmdEdit_Special_Click(sender As Object, e As EventArgs) Handles cmdEdit_special.Click
        If XtraMessageBox.Show("Are you sure you want to edit selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            trnid.Text = GridView1.GetFocusedRowCellValue("id").ToString
            Dim strproduct As String = ""
            com.CommandText = "select *, (select itemname from tblglobalproducts where productid=tblhotelroomsamenities.productid and actived=1) as 'Product' from tblhotelroomsamenities where id='" & trnid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                strproduct = rst("Product").ToString
                productid.Text = rst("productid").ToString
                txtQuantity.Text = rst("quantity").ToString
                txtUnit.Text = rst("unit").ToString
            End While
            rst.Close()
            txtProduct.Text = strproduct
            mode.Text = "edit"
        End If
    End Sub
    Private Sub cmdRemove_special_Click(sender As Object, e As EventArgs) Handles cmdRemove_special.Click
        If XtraMessageBox.Show("Are you sure you want to delete selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblhotelroomsamenities where id='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            LoadSpecialProduct()
        End If
    End Sub
End Class