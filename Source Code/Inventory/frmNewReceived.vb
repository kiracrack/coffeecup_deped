Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Public Class frmNewReceived
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmNewReceived_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadProduct()
        loadStockcat()
    End Sub
    Public Sub loadStockcat()
        LoadXgridLookupSearch("SELECT STOCKID,DESCRIPTION as 'Select Stock' from tblstockcategory order by MASTID asc", "tblstockcategory", txtstock, g_stocks, Me)
        g_stocks.Columns("STOCKID").Visible = False
    End Sub
    Private Sub txtstock_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstock.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtstock.Properties.View.FocusedRowHandle.ToString)
        stockid.Text = txtstock.Properties.View.GetFocusedRowCellValue("STOCKID").ToString()
        txtstock.Text = txtstock.Properties.View.GetFocusedRowCellValue("Select Stock").ToString()
    End Sub

    Public Sub LoadProduct()
        LoadXgridLookupSearch("select trnid, batchcode as 'Batch Code',productid, " _
                      + " (select details from tblsalescategory inner join tblproductsales on tblproductsales.catid = tblsalescategory.catid where productid=tblrecieving.productid) as 'Product Category', " _
                      + " (select itemname from tblproductsales where productid = tblrecieving.productid)  as Product, " _
                      + " quantity as 'Quantity' , " _
                      + " (select Unit from tblproductsales where productid = tblrecieving.productid)  as Unit, " _
                      + fhstring _
                      + " lastupdate as 'Date Sent', " _
                      + " (select fullname from tblaccounts where accountid=tblrecieving.deliverby) as 'Delivered By' " _
                      + " from tblrecieving where status = 1 order by lastupdate desc", "tblrecieving", txtproduct, g_product, Me)

        g_product.Columns("trnid").Visible = False
        g_product.Columns("productid").Visible = False
    End Sub

    Private Sub txtproductt_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtproduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtproduct.Properties.View.FocusedRowHandle.ToString)
        trnid.Text = txtproduct.Properties.View.GetFocusedRowCellValue("trnid").ToString()
        txtquan.Text = Format(txtproduct.Properties.View.GetFocusedRowCellValue("Quantity"), "n")
        productid.Text = txtproduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtproduct.Text = txtproduct.Properties.View.GetFocusedRowCellValue("Item Name").ToString()
        txtunit.Text = txtproduct.Properties.View.GetFocusedRowCellValue("Unit").ToString()
        txtbatchcode.Text = txtproduct.Properties.View.GetFocusedRowCellValue("Batch Code").ToString()
        txtquan.Focus()
    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click, BarButtonItem2.ItemClick
        If txtquan.Text = "" Then
            XtraMessageBox.Show("Please enter quantity", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtquan.Focus()
            Exit Sub
        ElseIf countqry("tblrecieving", "status=1") = 0 Then
            XtraMessageBox.Show("There's no new item to receive!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtquan.Focus()
            Exit Sub
        ElseIf txtstock.Text = "" Then
            XtraMessageBox.Show("Please select stock inventory to", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtstock.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to finish this transaction?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If CheckEdit1.Checked = True Then
                dst = New DataSet
                msda = New MySqlDataAdapter("select * from tblrecieving where status=1", conn)
                msda.Fill(dst, 0)
                Dim tempquan As Double = 0
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        If countqry("tblinventory", "stockid='" & stockid.Text & "' and productid='" & .Rows(cnt)("productid").ToString() & "'") = 0 Then
                            com.CommandText = "insert into tblinventory set stockid='" & stockid.Text & "', productid='" & .Rows(cnt)("productid").ToString() & "', quantity='" & Val(.Rows(cnt)("quantity").ToString()) & "', lastupdate='" & globaldatetime() & "', lasttrnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "update tblinventory set quantity = quantity + " & Val(.Rows(cnt)("quantity").ToString()) & ", lastupdate='" & globaldatetime() & "', lasttrnby='" & globaluserid & "' where stockid='" & stockid.Text & "' and productid='" & .Rows(cnt)("productid").ToString() & "'" : com.ExecuteNonQuery()
                        End If
                        com.CommandText = "update tblrecieving set status=0, stockto='" & stockid.Text & "',datereceived='" & globaldatetime() & "', receivedby='" & globaluserid & "' where trnid='" & .Rows(cnt)("trnid").ToString() & "'" : com.ExecuteNonQuery()
                    End With
                Next
                frmReceivingHistory.filter()
                XtraMessageBox.Show("Transaction receiving successfully done!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearfields()
            Else
                If countqry("tblinventory", "stockid='" & stockid.Text & "' and productid='" & productid.Text & "'") = 0 Then
                    com.CommandText = "insert into tblinventory set stockid='" & stockid.Text & "', productid='" & productid.Text & "', quantity='" & Val(CC(txtquan.Text)) & "', lastupdate='" & globaldatetime() & "', lasttrnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update tblinventory set quantity = quantity + " & Val(CC(txtquan.Text)) & ", lastupdate='" & globaldatetime() & "', lasttrnby='" & globaluserid & "' where stockid='" & stockid.Text & "' and productid='" & productid.Text & "'" : com.ExecuteNonQuery()
                End If
                com.CommandText = "update tblrecieving set status=0, stockto='" & stockid.Text & "',datereceived='" & globaldatetime() & "', receivedby='" & globaluserid & "' where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
                frmReceivingHistory.filter()
                XtraMessageBox.Show("Transaction receiving successfully done!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearfields()
            End If
        End If
    End Sub
    Public Sub clearfields()
        txtproduct.Properties.DataSource = Nothing
        txtproduct.Text = ""
        LoadProduct()
        trnid.Text = ""
        txtquan.Text = "0.00"
        productid.Text = ""
        txtunit.Text = ""
        txtbatchcode.Text = ""
        txtproduct.Focus()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        clearfields()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtproduct.Properties.ReadOnly = True
            clearfields()
        Else
            txtproduct.Properties.ReadOnly = False
        End If
    End Sub
End Class