Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI

Public Class frmVoucherPOSelect
    Delegate Sub Execute_Delegate()
    Private Sub Execute_ThreadSafe()
        If Me.InvokeRequired Then
            Dim MyDelegate As New Execute_Delegate(AddressOf Execute_ThreadSafe)
            Me.Invoke(MyDelegate)
        Else
            LoadPurchaseOrder()
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmVoucherPOSelect_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        PopulateGridViewControls("Select", 20, "CHECKBOX", dgv, True, False)
        PopulateGridViewControls("PO Number", 50, "", dgv, True, True)
        PopulateGridViewControls("Supplier", 50, "", dgv, True, True)
        PopulateGridViewControls("Office", 50, "", dgv, False, True)
        PopulateGridViewControls("Invoice No.", 30, "", dgv, True, False)
        PopulateGridViewControls("Current Balance", 30, "", dgv, If(ckAp.Checked = True, True, False), True)
        PopulateGridViewControls("Tax Name", 10, "COMBO", dgv, If(ckAp.Checked = True, True, False), False)
        PopulateGridViewControls("Tax", 20, "", dgv, If(ckAp.Checked = True, True, False), True)
        PopulateGridViewControls("Total", 30, "", dgv, True, True)
        PopulateGridViewControls("Payment", 10, "", dgv, If(ckAp.Checked = True, True, False), False)
        PopulateGridViewControls("New Balance", 10, "", dgv, If(ckAp.Checked = True, True, False), If(ckAp.Checked = True, True, False))
        PopulateGridViewControls("Date Approved", 10, "", dgv, True, True)
        PopulateGridViewControls("Delivered", 0, "CHECKBOX", dgv, True, True)
        PopulateGridViewControls("Date Delivered", 10, "", dgv, True, True)
        PopulateGridViewControls("Note", 50, "", dgv, True, False)
        PopulateGridViewControls("po", 0, "", dgv, False, True)
        PopulateGridViewControls("datetrn", 0, "", dgv, False, True)
        PopulateGridViewControls("vendorid", 0, "", dgv, False, True)
        PopulateGridViewControls("taxrate", 0, "", dgv, False, True)
        PopulateGridViewControls("taxcode", 0, "", dgv, False, True)
        LoadPurchaseOrder()

    End Sub

    Public Sub LoadPurchaseOrder()
        dgv.Rows.Clear()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select *,ifnull((select sum(tax+amount) from tbldisbursementdetails where ponumber=tblpurchaseorder.ponumber),0) as payment, datetrn,note,forpo,(select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) as vendor,(select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) as office, " _
                + " date_format(dateverified,'%Y-%m-%d') as 'DateApproved', invoiceno, subtotal, Vat, TotalAmount, Delivered, date_format(datedelivered,'%Y-%m-%d') as 'DateDelivered' " _
                + " from tblpurchaseorder where verified=1 " & If(mode.Text = "ca", " and delivered=0 ", " and vendorid='" & vendorid.Text & "' and delivered=1 ") & " and paymentrequested=0 and totalamount>0 and cancelled=0 and " _
                + " (ponumber like '%" & txtSearch.Text & "%' or (select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) like  '%" & txtSearch.Text & "%' or (select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) like '%" & txtSearch.Text & "%' or TotalAmount like '%" & txtSearch.Text & "%') order by datetrn desc", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                dgv.Rows.Add(False, .Rows(cnt)("ponumber").ToString(), _
                                                 .Rows(cnt)("vendor").ToString(), _
                                                 .Rows(cnt)("office").ToString(), _
                                                 .Rows(cnt)("invoiceno").ToString(), _
                                                 Val(.Rows(cnt)("TotalAmount").ToString()) - Val(.Rows(cnt)("payment").ToString()), _
                                                 "", _
                                                 0, _
                                                 Val(.Rows(cnt)("TotalAmount").ToString()) - Val(.Rows(cnt)("payment").ToString()), _
                                                 Val(.Rows(cnt)("TotalAmount").ToString()) - Val(.Rows(cnt)("payment").ToString()), _
                                                 0, _
                                                 .Rows(cnt)("DateApproved").ToString(), _
                                                 .Rows(cnt)("Delivered").ToString(), _
                                                 .Rows(cnt)("DateDelivered").ToString(), _
                                                 .Rows(cnt)("note").ToString(), _
                                                 .Rows(cnt)("forpo").ToString(), _
                                                 .Rows(cnt)("datetrn").ToString(), _
                                                 .Rows(cnt)("vendorid").ToString(),
                                                  "0", "")
            End With
        Next

        For rowIndexr As Integer = 0 To dgv.Rows.Count - 1
            LoadToGridComboBoxCell("Tax Name", rowIndexr, "select taxname from tbltaxtable where purchases=1 order by taxname asc", "taxname", False, dgv)
        Next

        GridCurrencyColumn(dgv, {"Sub Total", "Tax", "Current Balance", "Total", "Payment", "New Balance"})
        GridColumnWidth(dgv, {"Sub Total", "Tax", "Current Balance", "Total", "Payment", "New Balance"}, 100)
        GridColumnAlignment(dgv, {"PO Number", "Invoice No.", "Date Approved", "Delivered", "Date Delivered"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumAutoWidth(dgv, {"Select", "Supplier", "PO Number", "Office", "Invoice No.", "Tax Name", "Date Approved", "Delivered", "Date Delivered", "Note"})
    End Sub


    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Dim Selected As Boolean = False
        For I = 0 To dgv.RowCount - 1
            If DirectCast(dgv.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                Selected = True
            End If
        Next
        If Selected = False Then
            MessageBox.Show("No item selected", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To dgv.RowCount - 1
                If DirectCast(dgv.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                    If Val(CC(dgv.Item("New Balance", I).Value)) > 0 Then
                        com.CommandText = "UPDATE tblpurchaseorder set invoiceno='" & dgv.Item("Invoice No.", I).Value & "', paymentrequested=0,paymentrequestedby='" & globaluserid & "', paymentrefnumber='" & voucherno.Text & "',ap=" & ckAp.CheckState & " where ponumber='" & dgv.Item("PO Number", I).Value & "'" : com.ExecuteNonQuery()
                    Else
                        com.CommandText = "UPDATE tblpurchaseorder set invoiceno='" & dgv.Item("Invoice No.", I).Value & "', paymentrequested=1,paymentrequestedby='" & globaluserid & "', paymentrefnumber='" & voucherno.Text & "',ap=" & ckAp.CheckState & " where ponumber='" & dgv.Item("PO Number", I).Value & "'" : com.ExecuteNonQuery()
                    End If
                    com.CommandText = "insert into tbldisbursementdetails set voucherno='" & voucherno.Text & "', vendorid='" & dgv.Item("vendorid", I).Value & "', supplier='" & rchar(dgv.Item("Supplier", I).Value) & "',datetrn='" & ConvertDate(dgv.Item("datetrn", I).Value) & "', ponumber='" & dgv.Item("PO Number", I).Value & "', note='" & rchar(dgv.Item("Note", I).Value) & "', invoiceno='" & dgv.Item("Invoice No.", I).Value & "',taxcode='" & dgv.Item("taxcode", I).Value & "',tax='" & Val(CC(dgv.Item("Tax", I).Value)) & "', amount='" & Val(CC(dgv.Item("Payment", I).Value)) & "',forpo=" & CBool(dgv.Item("po", I).Value) & "" : com.ExecuteNonQuery()
                End If
            Next
            LoadPurchaseOrder()
            frmVouchersInformation.LoadVoucherExpenses()
        End If
    End Sub

    Private Sub dgv_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv.EditingControlShowing
        Try
            If dgv.CurrentCell.ColumnIndex = 6 Then
                Dim combo As Windows.Forms.ComboBox = CType(e.Control, Windows.Forms.ComboBox)
                If (combo IsNot Nothing) Then
                    RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf Tax_SelectionChangeCommitted)
                    AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf Tax_SelectionChangeCommitted)
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Tax_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim combo As Windows.Forms.ComboBox = CType(sender, Windows.Forms.ComboBox)
        com.CommandText = "select * from tbltaxtable where taxname='" & rchar(combo.SelectedItem) & "'" : rst = com.ExecuteReader
        While rst.Read
            dgv.Item("taxcode", dgv.CurrentRow.Index).Value = Val(rst("taxcode").ToString)
            dgv.Item("taxrate", dgv.CurrentRow.Index).Value = Val(rst("taxrate").ToString)
        End While
        rst.Close()
    End Sub

    Private Sub CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgv.CellValueChanged
        Dim gv As DataGridView = DirectCast(sender, DataGridView)
        Dim originalamount As Double = If(gv("Current Balance", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("Current Balance", e.RowIndex).Value)))
        Dim taxrate As Double = If(gv("taxrate", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("taxrate", e.RowIndex).Value)))


        If e.ColumnIndex = 6 Then ' tax rate selected
            Dim vat As Double = 0
            vat = (originalamount * (taxrate / 100))
            gv("Tax", e.RowIndex).Value = vat
            gv("Total", e.RowIndex).Value = originalamount - vat
            gv("Payment", e.RowIndex).Value = originalamount - vat
            gv("New Balance", e.RowIndex).Value = 0
        End If
     
        If e.ColumnIndex = 9 Then ' enter payment amount
            Dim Total As Double = If(gv("Total", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("Total", e.RowIndex).Value)))
            Dim Tenderamount As Double = If(gv("Payment", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("Payment", e.RowIndex).Value)))
            gv("New Balance", e.RowIndex).Value = Total - Tenderamount
        End If

    End Sub

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgv.DataError

    End Sub

    Private Sub MyDataGridView_room_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDown
        On Error Resume Next
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.dgv.CurrentCell = Me.dgv.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtSearch.Text = "" Then Exit Sub
            LoadPurchaseOrder()
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For x = 0 To dgv.RowCount - 1
                DirectCast(dgv.Rows(x).Cells("Select"), DataGridViewCheckBoxCell).Value = 1
            Next
        Else
            For x = 0 To dgv.RowCount - 1
                DirectCast(dgv.Rows(x).Cells("Select"), DataGridViewCheckBoxCell).Value = 0
            Next
        End If
    End Sub

    Private Sub ViewPurchaseOrderProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPurchaseOrderProfileToolStripMenuItem.Click
        frmPurchaseOrderProfile.mode.Text = dgv.Item("po", dgv.CurrentRow.Index).Value().ToString
        frmPurchaseOrderProfile.ponumber.Text = dgv.Item("PO Number", dgv.CurrentRow.Index).Value().ToString
        If frmPurchaseOrderProfile.Visible = True Then
            frmPurchaseOrderProfile.Focus()
        Else
            frmPurchaseOrderProfile.Show(Me)
        End If

    End Sub
End Class