Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetPumpReading
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmGLPump_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCashier()
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gridProduct)
        txtdate.Text = Format(Now)
        'If countqry("tblsalesfuelpump", "productid not in (select distinct productid from tblsalesfuelreading where trnsumcode='beginning')") = 0 Then

        'End If
    End Sub
    Public Sub LoadCashier()
        LoadXgridLookupEdit("select trncode,officeid, (select fullname from tblaccounts where accountid=tblsalessummary.userid) as 'Cashier', date_format(dateopen,'%Y-%m-%d %r') as 'Date Open' from tblsalessummary where verified=0", "tblsalessummary", txtCashier, gridUser, Me)
        gridUser.Columns("trncode").Visible = False
        gridUser.Columns("officeid").Visible = False
    End Sub

    Private Sub txtUser_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashier.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCashier.Properties.View.FocusedRowHandle.ToString)
        sumtrncode.Text = txtCashier.Properties.View.GetFocusedRowCellValue("trncode").ToString()
        officeid.Text = txtCashier.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        txtdate.Text = txtCashier.Properties.View.GetFocusedRowCellValue("Date Open").ToString()
        LoadProduct()
    End Sub
    Public Sub LoadProduct()
        LoadXgridLookupSearch("select distinct productid,(select itemname from tblglobalproducts  where actived = 1 and productid = tblsalesfuelpump.productid ) as 'Product Name' from tblsalesfuelpump", "tblsalesfuelpump", txtProduct, gridProduct, Me)
        gridProduct.Columns("productid").Visible = False
    End Sub
    Private Sub txtItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProduct.Properties.View.FocusedRowHandle.ToString)
        productid.Text = txtProduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtProduct.Text = txtProduct.Properties.View.GetFocusedRowCellValue("Product Name").ToString()
        LoadPump()
    End Sub
    Public Sub LoadPump()
        If countqry("tblsalesfuelreading", "trnsumcode='" & sumtrncode.Text & "' and productid='" & productid.Text & "'") = 0 Then
            LoadXgrid("select pumpcode, description as 'Pump Name', '' as Quantity from tblsalesfuelpump where productid='" & productid.Text & "'", "tblsalesfuelpump", Em, GridView1, Me)
            GridView1.Columns("pumpcode").Visible = False
            GridView1.Columns("Quantity").Width = 80
            GridView1.SelectRow(1)
            XgridColCurrency({"Quantity"}, GridView1)
            SpinEdit.Mask.UseMaskAsDisplayFormat = True
            GridView1.Columns("Quantity").ColumnEdit = SpinEdit
            XgridColAlign({"Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Far)
            XgridAllowColumnEdit({"pumpcode", "Pump Name"}, GridView1, False)
        Else
            LoadXgrid("select pumpcode, (select description from tblsalesfuelpump where pumpcode = tblsalesfuelreading.pumpcode) as 'Pump Name', Quantity from tblsalesfuelreading where productid='" & productid.Text & "' and trnsumcode='" & sumtrncode.Text & "'", "tblsalesfuelreading", Em, GridView1, Me)
            GridView1.Columns("pumpcode").Visible = False
            GridView1.Columns("Quantity").Width = 80
            GridView1.SelectRow(1)
            XgridColCurrency({"Quantity"}, GridView1)
            SpinEdit.Mask.UseMaskAsDisplayFormat = True
            GridView1.Columns("Quantity").ColumnEdit = SpinEdit
            XgridColAlign({"Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Far)
            XgridAllowColumnEdit({"pumpcode", "Pump Name"}, GridView1, False)
        End If
      
    End Sub
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtdate.Text = "" Then
            XtraMessageBox.Show("Please Enter Date!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdate.Focus()
            Exit Sub
        ElseIf txtProduct.Text = "" Then
            XtraMessageBox.Show("Please Select Product!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProduct.Focus()
            Exit Sub
        End If

        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sellingprice As Double = Val(qrysingledata("sellingprice", "sellingprice", "where productid='" & productid.Text & "' and actived=1", "tblglobalproducts"))
            com.CommandText = "delete from tblsalesfuelreading where trnsumcode='" & sumtrncode.Text & "' and productid='" & productid.Text & "'" : com.ExecuteNonQuery()
            For I = 0 To GridView1.RowCount - 1
                com.CommandText = "insert into tblsalesfuelreading set trnsumcode='" & sumtrncode.Text & "', productid='" & productid.Text & "', pumpcode='" & GridView1.GetRowCellValue(I, "pumpcode").ToString & "', quantity='" & Val(CC(GridView1.GetRowCellValue(I, "Quantity").ToString)) & "',unitprice='" & sellingprice & "',  dateentry=concat('" & ConvertDate(txtdate.Text) & "',' ',current_time), entryby='" & globaluserid & "'" : com.ExecuteNonQuery()
            Next
            DeductFuelInventory()

            productid.Text = "" : LoadProduct() : LoadPump()
            XtraMessageBox.Show("Pump reading successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Public Function DeductFuelInventory() As String
        Dim ResetInventory As String = ""
        com.CommandText = "select * from tblsalesfuelsold where trnsumcode='" & sumtrncode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            ResetInventory = ResetInventory + "update tblinventory set quantity=quantity+" & rst("quantity").ToString & " where productid='" & rst("productid").ToString & "' and officeid='" & rst("officeid").ToString & "';" & Chr(13)
        End While
        rst.Close()
        If ResetInventory <> "" Then
            com.CommandText = ResetInventory : com.ExecuteNonQuery()
        End If

        Dim DeductInventory As String = "" : Dim RecordInventory As String = ""
        '#load fuel Sale Reading
        Dim productid As String = ""
        com.CommandText = "select productid, itemname from tblglobalproducts where productid in (select distinct productid from tblsalesfuelpump) and actived=1" : rst = com.ExecuteReader
        While rst.Read
            productid = productid + rst("productid").ToString + ":"
        End While
        rst.Close()
        '#end fuel products

        If productid <> "" Then
            productid = productid.Remove(productid.Length - 1, 1)
        End If

        'Calculate Total Sales Reading
        For Each word In productid.Split(New Char() {":"c})
            com.CommandText = "select *, ifnull(sum(quantity-(select quantity from tblsalesfuelreading as b where b.dateentry  <  a.dateentry and b.pumpcode = a.pumpcode order by dateentry desc limit 1 )),0) as 'netquantity'  from tblsalesfuelreading  as a where a.trnsumcode='" & sumtrncode.Text & "' and a.productid='" & word & "'" : rst = com.ExecuteReader
            While rst.Read
                DeductInventory = DeductInventory + "update tblinventory set quantity=quantity-" & rst("netquantity").ToString & " where productid='" & rst("productid").ToString & "' and officeid='" & officeid.Text & "'; " & Chr(13)
                RecordInventory = RecordInventory + "insert into tblsalesfuelsold set trnsumcode='" & sumtrncode.Text & "', officeid='" & officeid.Text & "', productid='" & rst("productid").ToString & "',quantity='" & rst("netquantity").ToString & "';" & Chr(13)
            End While
            rst.Close()
        Next
        If DeductInventory <> "" Then
            com.CommandText = DeductInventory : com.ExecuteNonQuery()
            com.CommandText = "delete from tblsalesfuelsold where trnsumcode='" & sumtrncode.Text & "';" : com.ExecuteNonQuery()
            com.CommandText = RecordInventory : com.ExecuteNonQuery()
        End If
        Return 0
    End Function

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtCashier.Enabled = False
            txtCashier.Properties.DataSource = Nothing
            txtCashier.Text = ""
            sumtrncode.Text = "beginning"
            LoadCashier()
            txtdate.Enabled = True
        Else
            txtCashier.Enabled = True
            txtdate.Enabled = False
            sumtrncode.Text = ""
        End If
    End Sub

    Private Sub sumtrncode_EditValueChanged(sender As Object, e As EventArgs) Handles sumtrncode.EditValueChanged
        LoadProduct()
        LoadPump()
    End Sub
End Class