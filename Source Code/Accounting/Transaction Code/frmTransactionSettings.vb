Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmTransactionSettings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmGLGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

        com.CommandText = "select * from tblglsettings" : rst = com.ExecuteReader
        While rst.Read
            If rst("gltype").ToString = "expenses" Then
                txtExpenses.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "income" Then
                txtIncome.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "sales" Then
                txtSales.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "accounts-receivable" Then
                txtAR.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "point-of-sale" Then
                txtGLPOS.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "cashier-begcash-amount" Then
                txtBeginningCashierCash.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "cashier-begcash-from" Then
                txtCashFromCode.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "client-payment" Then
                txtClientPayments.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "treasury-account" Then
                txtTreasuryAccount.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "credit-card" Then
                txtCreditCard.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "purchase-order-payable" Then
                txtGLItemPurchaseOrder.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "payment-discount" Then
                txtPaymentDiscount.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "purchase-order-payment" Then
                txtPOPayments.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "purchase-order-payment-discount" Then
                txtPOPaymentDiscount.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "tax-rate" Then
                txtTaxRate.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "bank-beg" Then
                txtBankBeg.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "overages" Then
                txtoverages.Text = rst("value").ToString
            ElseIf rst("gltype").ToString = "shortages" Then
                txtshortages.Text = rst("value").ToString
            End If
        End While
        rst.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        com.CommandText = "delete from tblglsettings" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='expenses', value='" & txtExpenses.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='income', value='" & txtIncome.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='sales', value='" & txtSales.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='accounts-receivable', value='" & txtAR.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='point-of-sale', value='" & txtGLPOS.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='cashier-begcash-amount', value='" & Val(CC(txtBeginningCashierCash.Text)) & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='cashier-begcash-from', value='" & txtCashFromCode.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='client-payment', value='" & txtClientPayments.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='treasury-account', value='" & txtTreasuryAccount.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='credit-card', value='" & txtCreditCard.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='purchase-order-payable', value='" & txtGLItemPurchaseOrder.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='payment-discount', value='" & txtPaymentDiscount.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='purchase-order-payment', value='" & txtPOPayments.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='purchase-order-payment-discount', value='" & txtPOPaymentDiscount.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='tax-rate', value='" & txtTaxRate.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='bank-beg', value='" & txtBankBeg.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='overages', value='" & txtoverages.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglsettings set gltype='shortages', value='" & txtshortages.Text & "'" : com.ExecuteNonQuery()
        LoadGeneralSettings()
        XtraMessageBox.Show("Setting successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class