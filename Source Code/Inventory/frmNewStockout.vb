Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Public Class frmNewStockout

    Private Sub frmNewStockout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtbatchcode.Text = getBatchCode()
        loadProduct()
        loadServer()
        loadCurrProduct()
        LoadAgent()
    End Sub
    Public Sub LoadAgent()
        LoadXgridLookupSearch("select accountid, Fullname from tblaccounts where permission=4", "tblaccounts", txtagent, g_client, Me)
        g_client.Columns("accountid").Visible = False
    End Sub

    Private Sub txtclient_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtagent.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtagent.Properties.View.FocusedRowHandle.ToString)
        agentid.Text = txtagent.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtagent.Text = txtagent.Properties.View.GetFocusedRowCellValue("Fullname").ToString()
    End Sub
    Public Sub loadProduct()
        LoadXgridLookupSearch("SELECT  stockid,productid, " _
                              + " (select description from tblstockcategory where stockid=tblinventory.stockid) as 'Inventory of', " _
                              + " (select details from tblsalescategory inner join tblproductsales on tblproductsales.catid = tblsalescategory.catid where productid=tblinventory.productid) as 'Product Category', " _
                              + " (select itemname from tblproductsales where productid = tblinventory.productid) as 'Item Name',  " _
                              + " Quantity, " _
                              + " (select unit from tblproductsales where productid = tblinventory.productid) as 'Unit' " _
                              + " from tblinventory order by lastupdate desc", "tblinventory", txtproduct, g_product, Me)

        XgridColCurrency("Quantity", g_product)
        g_product.Columns("stockid").Visible = False
        g_product.Columns("productid").Visible = False
    End Sub
    Private Sub txtproduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtproduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtproduct.Properties.View.FocusedRowHandle.ToString)
        stockid.Text = txtproduct.Properties.View.GetFocusedRowCellValue("stockid").ToString()
        productid.Text = txtproduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtproduct.Text = txtproduct.Properties.View.GetFocusedRowCellValue("Item Name").ToString()
        txtunit.Text = txtproduct.Properties.View.GetFocusedRowCellValue("Unit").ToString()
        txtquan.Text = Format(txtproduct.Properties.View.GetFocusedRowCellValue("Quantity"), "n")
        ttlquan.Text = txtproduct.Properties.View.GetFocusedRowCellValue("Quantity").ToString
        txtquan.Focus()
    End Sub

    Public Sub loadServer()
        LoadXgridLookupSearch("select id, servername as 'Server Name', ipserver as 'IP Server' from tblclientserver", "tblclientserver", txtServer, g_server, Me)
        g_server.Columns("id").Visible = False
    End Sub
    Private Sub txtServer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServer.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtServer.Properties.View.FocusedRowHandle.ToString)
        serverid.Text = txtServer.Properties.View.GetFocusedRowCellValue("id").ToString
        txtServer.Text = txtServer.Properties.View.GetFocusedRowCellValue("Server Name").ToString
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If txtproduct.Text = "" Then
            XtraMessageBox.Show("Please select product item!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtproduct.Focus()
            Exit Sub
        ElseIf Val(CC(txtquan.Text)) > Val(ttlquan.Text) Then
            XtraMessageBox.Show("Maximum quantity stock only " & Format(Val(ttlquan.Text), "n").ToString & "!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquan.Focus()
            Exit Sub
        End If
        Dim cnt = 0
        For l = 0 To GridView1.RowCount - 1
            If GridView1.GetRowCellValue(l, "productid").ToString = productid.Text Then
                cnt = cnt + 1
            End If
        Next l
        If cnt = 0 Then
            AddRowXgrid(GridView1)
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "stockid", stockid.Text)
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "productid", productid.Text)
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Product Name", txtproduct.Text)
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Quantity", txtquan.Text)
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Unit", txtunit.Text)
        Else
            XtraMessageBox.Show(txtproduct.Text + " already add to batch!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtproduct.Focus()
        End If
        GridView1.BestFitColumns()
        GridView1.Focus()
    End Sub
    Public Sub loadCurrProduct()
        LoadXgrid("select ' '  as stockid, productid, ' ' as 'Product Name', Quantity, '' as 'Unit' from tblstockout where batchcode='" & txtbatchcode.Text & "'", "tblstockout", Em, GridView1, Me)
        GridView1.Columns("stockid").Visible = False
        GridView1.Columns("productid").Visible = False
        XgridColCurrency("Quantity", GridView1)
    End Sub

    Private Sub HiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HiToolStripMenuItem.Click
        GridView1.DeleteSelectedRows()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("No Product to stock out!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtproduct.Focus()
            Exit Sub
        ElseIf txtServer.Text = "" Then
            XtraMessageBox.Show("Please select server", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtServer.Focus()
            Exit Sub
        ElseIf txtagent.Text = "" Then
            XtraMessageBox.Show("Please select Agent", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtagent.Focus()
            Exit Sub
        End If
        pandata.Enabled = False
        panloading.Visible = True
        timerbegin.Enabled = True
    End Sub

    Private Sub timertransfer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timertransfer.Tick
        timertransfer.Enabled = False
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = (GridView1.RowCount - 1) + 3
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0


        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        lblcap.Text = "Connecting server of " + txtServer.Text + "..."
        connectServer(serverid.Text)

        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        lblcap.Text = "Connecting inventory..."
        connectInvetory()
    End Sub
    Public Sub connectInvetory()
        For i = 0 To GridView1.RowCount - 1
            Try
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()

                comclient.CommandText = "delete from tblrecieving where batchcode='" & txtbatchcode.Text & "' and productid='" & GridView1.GetRowCellValue(i, "productid").ToString() & "' and status = 1" : comclient.ExecuteNonQuery()

                lblcap.Text = "tranfer item " + GridView1.GetRowCellValue(i, "Product Name").ToString() + "..."
                comclient.CommandText = "insert into tblrecieving set batchcode='" & txtbatchcode.Text & "', " _
                                                        + " productid='" & GridView1.GetRowCellValue(i, "productid").ToString() & "', " _
                                                         + " quantity='" & GridView1.GetRowCellValue(i, "Quantity").ToString() & "', " _
                                                        + " lastupdate='" & globaldatetime() & "', " _
                                                        + " lasttrnby='" & globaluserid & "',remarks='Delivery', deliverby='" & agentid.Text & "'" : comclient.ExecuteNonQuery()

                com.CommandText = "insert into tblstockout set batchcode='" & txtbatchcode.Text & "', " _
                                                        + " productid='" & GridView1.GetRowCellValue(i, "productid").ToString() & "', " _
                                                        + " quantity='" & GridView1.GetRowCellValue(i, "Quantity").ToString() & "', " _
                                                        + " lastupdate='" & globaldatetime() & "', " _
                                                        + " lasttrnby='" & globaluserid & "',remarks='Delivery', deliverby='" & agentid.Text & "', sendto='" & serverid.Text & "'" : com.ExecuteNonQuery()

                lblcap.Text = "update inventory " + GridView1.GetRowCellValue(i, "Product Name").ToString() + "..."
                com.CommandText = "update tblinventory set quantity = quantity - " & GridView1.GetRowCellValue(i, "Quantity").ToString() & " " _
                                            + " where stockid='" & GridView1.GetRowCellValue(i, "stockid").ToString() & "' and productid = '" & GridView1.GetRowCellValue(i, "productid").ToString() & "' " : com.ExecuteNonQuery()
            Catch errMYSQL As MySqlException
                XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
 _
                                 & "Message:" & errMYSQL.Message & vbCrLf _
                                 & "Details:" & errMYSQL.StackTrace, _
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                pandata.Enabled = True
                panloading.Visible = False
                Exit Sub
            Catch errMS As Exception
                XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
 _
                                 & "Message:" & errMS.Message & vbCrLf _
                                 & "Details:" & errMS.StackTrace, _
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                pandata.Enabled = True
                panloading.Visible = False
                Exit Sub
            End Try
        Next i

        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        lblcap.Text = "Batch successfult sent to " + txtServer.Text + "!"
        XtraMessageBox.Show("Batch product item successfully sent to " & txtServer.Text & "!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearFields()
        pandata.Enabled = True
        panloading.Visible = False
    End Sub
    Public Sub ClearFields()
        GridView1.SelectAll()
        GridView1.DeleteSelectedRows()
        txtbatchcode.Text = getBatchCode()
        txtproduct.Properties.DataSource = Nothing
        stockid.Text = ""
        productid.Text = ""
        txtproduct.Text = ""
        txtquan.Text = "0.00"
        ttlquan.Text = ""
        loadProduct()
        loadCurrProduct()
        txtServer.Properties.DataSource = Nothing
        txtServer.Text = ""
        serverid.Text = ""
        loadServer()
    End Sub
    Private Sub timerbegin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerbegin.Tick
        timertransfer.Enabled = True
        timerbegin.Enabled = False
    End Sub

End Class