Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmStockoutDepedQuantity
    Private cost
    Private total
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmStockoutQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        officeid.Text = frmStockoutDepedRequest.officeid.Text
        ckAllocated.Checked = frmStockoutDepedRequest.ckAllocatedStockout.CheckState
        alllocatedofficeid.Text = frmStockoutDepedRequest.allocatedofficeid.Text
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
        End If
        com.CommandText = "insert into tblstockoutitem set " _
                              + " batchcode='" & batchcode.Text & "', " _
                              + " officeid='" & officeid.Text & "', " _
                              + " refcode='" & stockid.Text & "', " _
                              + " allocatedstock=" & ckAllocated.CheckState & ", " _
                              + " allocatedofficeid='" & alllocatedofficeid.Text & "', " _
                              + " productid='" & productid.Text & "', " _
                              + " catid='" & catid.Text & "', " _
                              + " quantity='" & Val(CC(txtquantity.Text)) & "', " _
                              + " purchasedprice='" & Val(CC(purchasedprice.Text)) & "', " _
                              + " unit='" & txtunit.Text & "', " _
                              + " stockouttypeid='', " _
                              + " remarks='" & rchar(txtRemarks.Text) & "', " _
                              + " requestby='', " _
                              + " trnby='" & globaluserid & "', " _
                              + " status=1, " _
                              + " datetrn=concat('" & ConvertDate(txtDateStockout.EditValue) & "',' ', current_time)" : com.ExecuteNonQuery()
        StockoutInventory("Inventory Stockout", stockid.Text, officeid.Text, productid.Text, Val(CC(txtquantity.Text)), Val(CC(purchasedprice.Text)), If(txtRemarks.Text = "", "manual stockout", txtRemarks.Text), alllocatedofficeid.Text, CDate(txtDateStockout.EditValue).ToString("yyyy-MM") & "-" & batchcode.Text, "", Now)
        frmStockoutDepedRequest.FilterNew()
        Me.Close()
        'concat(date_format(datestockout,'%Y-%m'),'-',tblstockoutbatch.batchcode)
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

End Class