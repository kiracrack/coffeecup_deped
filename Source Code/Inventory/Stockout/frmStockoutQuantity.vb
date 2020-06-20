Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmStockoutQuantity
    Private cost
    Private total
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub me_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        loadInventory()
    End Sub
    Private Sub frmStockoutQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtdatestockout.EditValue = CDate(Now.ToShortDateString)
        loadInventory()
        loadrequestdby()
        LoadGridviewAppearance(g_inventory)
        LoadGridviewAppearance(g_requestor)
        LoadGridviewAppearance(gridcompoffice)
        lbloffice.Text = "Select " & GlobalOfficeCaption
    End Sub

    Private Sub stockid_EditValueChanged(sender As Object, e As EventArgs) Handles stockid.EditValueChanged
        ShowStockInfo()
    End Sub
    Public Sub ShowStockInfo()
        com.CommandText = "select * from tblinventory where trnid='" & stockid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            txtproduct.Text = rst("productname").ToString
            productid.Text = rst("productid").ToString
            catid.Text = rst("catid").ToString
            txtAvailableQuantity.Text = rst("quantity").ToString
            txtquantity.Text = rst("quantity").ToString
            purchasedprice.Text = rst("purchasedprice").ToString
            txtunit.Text = rst("unit").ToString
        End While
        rst.Close()
    End Sub
    Public Sub loadInventory()
        LoadXgridLookupSearch("SELECT Stockouttypeid, DESCRIPTION as 'Select Inventory' from tblStockouttype", "tblStockouttype", txtStockoutType, g_inventory, Me)
        g_inventory.Columns("Stockouttypeid").Visible = False
    End Sub
    Private Sub txtInventory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStockoutType.EditValueChanged
        On Error Resume Next
        Stockouttypeid.Text = txtStockoutType.Properties.View.GetFocusedRowCellValue("Stockouttypeid").ToString()
        txtStockoutType.Text = txtStockoutType.Properties.View.GetFocusedRowCellValue("Select Inventory").ToString()
    End Sub
    Public Sub loadrequestdby()
        LoadXgridLookupSearch("SELECT accountid, Fullname from tblaccounts where username <> 'ROOT' and deleted=0 order by FULLNAME asc", "tblaccounts", txtRequestby, g_requestor, Me)
        g_requestor.Columns("accountid").Visible = False
    End Sub
    Private Sub txtRequestor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRequestby.EditValueChanged
        On Error Resume Next
        requestorid.Text = txtRequestby.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtRequestby.Text = txtRequestby.Properties.View.GetFocusedRowCellValue("Fullname").ToString()
    End Sub

    Private Sub cmdSetQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAction.Click
        Dim tempQry As String = ""
        If txtquantity.Text = "" Or Val(txtquantity.Text) < 1 Then
            XtraMessageBox.Show("Please enter valid quantity!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        ElseIf Val(CC(txtquantity.Text)) > Val(CC(txtAvailableQuantity.Text)) Then
            XtraMessageBox.Show("Maximum quantity is " & txtAvailableQuantity.Text & "!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        ElseIf txtRequestby.Text = "" Then
            XtraMessageBox.Show("Please select request person!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRequestby.Focus()
            Exit Sub
        ElseIf txtStockoutType.Text = "" Then
            XtraMessageBox.Show("Please select stockout type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtStockoutType.Focus()
            Exit Sub
        ElseIf txtoffice.Text = "" And ckAllocatedStockout.Checked = True Then
            XtraMessageBox.Show("Please select allocated office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        End If
        If ckBatch.Checked = True Then
            com.CommandText = "insert into tblstockoutitem set " _
                                  + " batchcode='" & batchcode.Text & "', " _
                                  + " officeid='" & officeid.Text & "', " _
                                  + " refcode='" & stockid.Text & "', " _
                                  + " allocatedstock=" & ckAllocatedStockout.CheckState & ", " _
                                  + " allocatedofficeid='" & officeallocated.Text & "', " _
                                  + " productid='" & productid.Text & "', " _
                                  + " catid='" & catid.Text & "', " _
                                  + " quantity='" & Val(CC(txtquantity.Text)) & "', " _
                                  + " purchasedprice='" & Val(CC(purchasedprice.Text)) & "', " _
                                  + " unit='" & txtunit.Text & "', " _
                                  + " stockouttypeid='" & Stockouttypeid.Text & "', " _
                                  + " remarks='" & rchar(txtRemarks.Text) & "', " _
                                  + " requestby='" & requestorid.Text & "', " _
                                  + " trnby='" & globaluserid & "', " _
                                  + " status=1, " _
                                  + " datetrn=concat('" & ConvertDate(txtdatestockout.Text) & "',' ',current_time) " : com.ExecuteNonQuery()
            StockoutInventory("Inventory Stockout", stockid.Text, officeid.Text, productid.Text, Val(CC(txtquantity.Text)), Val(CC(purchasedprice.Text)), If(txtRemarks.Text = "", "manual stockout", txtRemarks.Text), officeallocated.Text, CDate(txtdatestockout.EditValue).ToString("yyyy-MM") & "-" & batchcode.Text, "", Now)
            If frmStockoutDepedRequest.Visible = True Then
                frmStockoutDepedRequest.FilterNew()
            End If
        Else
            com.CommandText = "insert into tblstockoutitem set " _
                                  + " officeid='" & officeid.Text & "', " _
                                  + " refcode='" & stockid.Text & "', " _
                                  + " allocatedstock=" & ckAllocatedStockout.CheckState & ", " _
                                  + " allocatedofficeid='" & officeallocated.Text & "', " _
                                  + " productid='" & productid.Text & "', " _
                                  + " catid='" & catid.Text & "', " _
                                  + " quantity='" & Val(CC(txtquantity.Text)) & "', " _
                                  + " purchasedprice='" & Val(CC(purchasedprice.Text)) & "', " _
                                  + " unit='" & txtunit.Text & "', " _
                                  + " stockouttypeid='" & Stockouttypeid.Text & "', " _
                                  + " remarks='" & rchar(txtRemarks.Text) & "', " _
                                  + " requestby='" & requestorid.Text & "', " _
                                  + " trnby='" & globaluserid & "', " _
                                  + " status=0, " _
                                  + " datetrn=concat('" & ConvertDate(txtdatestockout.Text) & "',' ',current_time) " : com.ExecuteNonQuery()
            StockoutInventory("Inventory Stockout", stockid.Text, officeid.Text, productid.Text, Val(CC(txtquantity.Text)), Val(CC(purchasedprice.Text)), If(txtRemarks.Text = "", "manual stockout", txtRemarks.Text), officeallocated.Text, CDate(txtdatestockout.EditValue).ToString("yyyy-MM") & "-" & batchcode.Text, "", Now)
            If frmInventoryConsumables.Visible = True Then
                frmInventoryConsumables.FilterInventoryReports()
            End If
            XtraMessageBox.Show("Inventory successfully stockout!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
    End Sub
  
    Private Sub EditValueChanging_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtquantity.EditValueChanged
        If Val(CC(txtquantity.Text)) > Val(CC(txtAvailableQuantity.Text)) Then
            txtquantity.ForeColor = Color.White
            txtquantity.BackColor = Color.Red
        Else
            txtquantity.ForeColor = Color.Black
            txtquantity.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckAllocatedStockout.CheckedChanged
        If ckAllocatedStockout.Checked = True Then
            txtoffice.Properties.DataSource = Nothing
            txtoffice.Text = ""
            officeallocated.Text = ""
            loadCompOffice()
            txtoffice.Properties.ReadOnly = False
        Else
            txtoffice.Properties.DataSource = Nothing
            txtoffice.Text = ""
            officeallocated.Text = ""
            txtoffice.Properties.ReadOnly = True
        End If
    End Sub
    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Select " & GlobalOfficeCaption & "' from tblcompoffice order by officename asc", "tblcompoffice", txtoffice, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False
        Me.txtoffice.Properties.DisplayMember = "Select " & GlobalOfficeCaption
        Me.txtoffice.Properties.ValueMember = "Select " & GlobalOfficeCaption
    End Sub
    Private Sub txtcompoffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        officeallocated.Text = txtoffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
    End Sub

   
End Class