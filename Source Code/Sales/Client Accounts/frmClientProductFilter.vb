Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmClientProductFilter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmClientProductFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView3)
        LoadClientInfo()
        LoadProduct()
        LoadSpecialProduct()
        If globalAllowAdd = True Then
            cmdSpecial.Visible = True
            CheckEdit1.Enabled = True
        Else
            cmdSpecial.Visible = False
            CheckEdit1.Enabled = False
        End If
     
    End Sub
     
    Public Sub LoadClientInfo()
        Dim enablespecial As Boolean = False
        com.CommandText = "select * from tblclientaccounts where cifid='" & cifid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            enablespecial = rst("enablespecialprice")
        End While
        rst.Close()
        CheckEdit1.Checked = enablespecial
    End Sub

    Public Sub LoadProduct()
        LoadXgridLookupSearch("select productid, itemname as 'Product Name' from tblglobalproducts where enablesell = 1 and actived = 1 order by itemname asc", "tblglobalproducts", txtProduct_Special, gridProduct_special, Me)
        gridProduct_special.Columns("productid").Visible = False
    End Sub
  
    Private Sub txtProduct_Special_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct_Special.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProduct_Special.Properties.View.FocusedRowHandle.ToString)
        productid_special.Text = txtProduct_Special.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtProduct_Special.Text = txtProduct_Special.Properties.View.GetFocusedRowCellValue("Product Name").ToString()
    End Sub
    
 
    Public Sub LoadSpecialProduct()
        LoadXgrid("select id, (select itemname from tblglobalproducts where productid=tblclientspecialprice.productid and actived=1) as 'Product', Amount  from tblclientspecialprice where cifid='" & cifid.Text & "' order by (select itemname from tblglobalproducts where productid=tblclientspecialprice.productid and actived=1) asc", "tblclientspecialprice", em_special, GridView3, Me)
        GridView3.Columns("id").Visible = False
        GridView3.Columns("Amount").Width = 80
        XgridColAlign({"Amount"}, GridView3, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView3)
    End Sub
     
    Private Sub cmdSpecial_Click(sender As Object, e As EventArgs) Handles cmdSpecial.Click
        If txtProduct_Special.Text = "" Then
            XtraMessageBox.Show("Please Select Product!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProduct_Special.Focus()
            Exit Sub
        ElseIf txtAmount_Special.Text = "0.00" Then
            XtraMessageBox.Show("Please Enter special amount!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAmount_Special.Focus()
            Exit Sub
        ElseIf countqry("tblclientspecialprice", "productid='" & productid_special.Text & "' and cifid='" & cifid.Text & "'") > 0 And mode_Special.Text <> "edit" Then
            XtraMessageBox.Show("Product is already added!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProduct_Special.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to save special product?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode_Special.Text = "edit" Then
                com.CommandText = "update tblclientspecialprice set productid='" & productid_special.Text & "', amount='" & Val(CC(txtAmount_Special.Text)) & "' where id='" & trnid_special.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblclientspecialprice set cifid='" & cifid.Text & "', productid='" & productid_special.Text & "', amount='" & Val(CC(txtAmount_Special.Text)) & "'" : com.ExecuteNonQuery()
            End If
            txtProduct_Special.Properties.DataSource = Nothing
            txtProduct_Special.Text = "" : productid_special.Text = "" : txtAmount_Special.Text = "0"
            LoadProduct() : LoadSpecialProduct()
            XtraMessageBox.Show("Charges rate successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
     
    Private Sub cmdEdit_Special_Click(sender As Object, e As EventArgs) Handles cmdEdit_special.Click
        If XtraMessageBox.Show("Are you sure you want to edit selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            trnid_special.Text = GridView3.GetFocusedRowCellValue("id").ToString
            Dim strproduct As String = ""
            com.CommandText = "select *, (select itemname from tblglobalproducts where productid=tblclientspecialprice.productid and actived=1) as 'Product' from tblclientspecialprice where id='" & trnid_special.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                strproduct = rst("Product").ToString
                productid_special.Text = rst("productid").ToString
                txtAmount_Special.Text = rst("amount").ToString
            End While
            rst.Close()
            txtProduct_Special.Text = strproduct
            mode_Special.Text = "edit"
        End If
    End Sub
     
    Private Sub cmdRemove_special_Click(sender As Object, e As EventArgs) Handles cmdRemove_special.Click
        If XtraMessageBox.Show("Are you sure you want to delete selected item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblclientspecialprice where id='" & GridView3.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            LoadSpecialProduct()
        End If
    End Sub
   
End Class