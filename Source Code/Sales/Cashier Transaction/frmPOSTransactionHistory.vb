Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.Utils

Public Class frmPOSTransactionHistory
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(GridView2)

        FilterOption()
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterOption()
    End Sub

    Public Sub FilterOption()
        If XtraTabControl1.SelectedTabPage Is tabSalesSummary Then
            LoadSalesBlotterSummary

        ElseIf XtraTabControl1.SelectedTabPage Is tabKeyAccounts Then
            Em.Parent = tabKeyAccounts
            LoadKeyAccounts()

        ElseIf XtraTabControl1.SelectedTabPage Is tabKeyAccounts Then
            Em.Parent = tabKeyAccounts
            LoadKeyAccounts()

        ElseIf XtraTabControl1.SelectedTabPage Is tabInterOffice Then
            Em.Parent = tabInterOffice
            LoadInterOffice()

        ElseIf XtraTabControl1.SelectedTabPage Is tabCouponCharge Then
            Em.Parent = tabCouponCharge
            LoadCoupon()

        ElseIf XtraTabControl1.SelectedTabPage Is tabBatch Then
            Em.Parent = tabBatch
            LoadBatchTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabDetailed Then
            Em.Parent = tabDetailed
            ShowDetailTransactions()

        ElseIf XtraTabControl1.SelectedTabPage Is tabSoldProduct Then
            Em.Parent = tabSoldProduct
            ShowTotalTransactions()

        ElseIf XtraTabControl1.SelectedTabPage Is tabVoid Then
            Em.Parent = tabVoid
            ShowVoidandCancelledTransactions()

        ElseIf XtraTabControl1.SelectedTabPage Is tabExpenses Then
            Em.Parent = tabExpenses
            ShowExpenses()

        ElseIf XtraTabControl1.SelectedTabPage Is tabChargetoHotel Then
            Em.Parent = tabChargetoHotel
            ShowChargeToHotelTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabHotelTrn Then
            Em.Parent = tabHotelTrn
            ShowHotelTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabHotelPayment Then
            Em.Parent = tabHotelPayment
            ShowHotelPaymentTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabCheck Then
            Em.Parent = tabCheck
            ShowCheck()

        ElseIf XtraTabControl1.SelectedTabPage Is tabCard Then
            Em.Parent = tabCard
            ShowCard()

        ElseIf XtraTabControl1.SelectedTabPage Is tabOnline Then
            Em.Parent = tabOnline
            ShowOnline()

        ElseIf XtraTabControl1.SelectedTabPage Is tabVoucher Then
            Em.Parent = tabVoucher
            ShowVoucher()

        ElseIf XtraTabControl1.SelectedTabPage Is tabAccountingTicket Then
            Em.Parent = tabAccountingTicket
            ShowAccountingTicket()


        End If
    End Sub

    Public Sub LoadSalesBlotterSummary()
        com.CommandText = "CALL sp_salesremittance('CONSOLIDATED','" & globalSalesTrnCOde.Text & "','')" : com.ExecuteNonQuery()
        LoadXgrid("select title as 'Transaction Type', details as 'Details',amount as Total from tmpconsolidateddetails where amount>0", "tmpconsolidateddetails", GridControl1, GridView2, Me)
        GridView2.Columns("Transaction Type").Group()
        XgridColCurrency({"Total"}, GridView2)
        XgridColWidth({"Details"}, GridView2, 350)
        XgridColWidth({"Total"}, GridView2, 120)
        XgridGroupSummaryCurrency({"Total"}, GridView2)
        GridView2.ExpandAllGroups()
    End Sub

    Public Sub LoadKeyAccounts()
        LoadXgrid("CALL sp_salestransaction('INVOICE','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('INVOICE','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Total Amount"}, GridView1)
        XgridColAlign({"Batch Code", "Invoice No."}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Amount"}, GridView1)
    End Sub

    Public Sub LoadInterOffice()
        LoadXgrid("CALL sp_salestransaction('INTEROFFICE','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('INTEROFFICE','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount Due", "Covered Amount", "Excess Amount"}, GridView1)
        XgridColAlign({"Batch Code", "Transaction No.", "Excess Cash Payment"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount Due", "Covered Amount", "Excess Amount"}, GridView1)
    End Sub

    Public Sub LoadCoupon()
        LoadXgrid("CALL sp_salestransaction('COUPON','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('COUPON','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Unit Price", "Total"}, GridView1)
        XgridColAlign({"Reference", "Quantity", "Unit", "Coupon Date", "Date Verified"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, GridView1)
    End Sub

    Public Sub LoadBatchTransaction()
        LoadXgrid("CALL sp_salestransaction('BATCH','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('BATCH','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", Em, GridView1, Me)
        XgridColCurrency({"Sub Total", "Total Amount", "Total Discount", "Total Charges", "Total Tax", "Amount Tendered", "Change", If(Globalenablechittransaction = True, "Chit Total", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Folio No.", "Room No.", "Total Item", "Item Cancelled", "Payment Type", "Invoice No", If(Globalenablechittransaction = True, "Chit Transaction", Nothing)}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Sub Total", "Total Amount", "Total Discount", "Total Charges", "Total Tax", If(Globalenablechittransaction = True, "Chit Total", Nothing)}, GridView1)
    End Sub

    Public Sub ShowDetailTransactions()
        LoadXgrid("CALL sp_salestransaction('DETAILED','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('DETAILED','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", Em, GridView1, Me)
        XgridColCurrency({"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "Chit Price", Nothing), If(Globalenablechittransaction = True, "Total Chit", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Folio No.", "Room No.", "Quantity", "Unit", "Unit Price"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "Chit Price", Nothing), If(Globalenablechittransaction = True, "Total Chit", Nothing)}, GridView1)
    End Sub

    Public Sub ShowTotalTransactions()
        LoadXgrid("CALL sp_salestransaction('TOTAL','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('TOTAL','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", Em, GridView1, Me)
        XgridColCurrency({"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "Chit Price", Nothing), If(Globalenablechittransaction = True, "Total Chit", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Quantity", "Unit", "Unit Price"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "Chit Price", Nothing), If(Globalenablechittransaction = True, "Total Chit", Nothing)}, GridView1)
    End Sub


    Public Sub ShowVoidandCancelledTransactions()
        LoadXgrid("CALL sp_salestransaction('VOID','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('VOID','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", Em, GridView1, Me)

        XgridColCurrency({"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "Chit Price", Nothing), If(Globalenablechittransaction = True, "Total Chit", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Quantity", "Unit", "Unit Price"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "Chit Price", Nothing), If(Globalenablechittransaction = True, "Total Chit", Nothing)}, GridView1)
    End Sub

    Public Sub ShowExpenses()
        LoadXgrid("CALL sp_salestransaction('EXPENSES','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('EXPENSES','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Date Post"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowChargeToHotelTransaction()
        LoadXgrid("CALL sp_salestransaction('CHRGETOHOTEL','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('CHRGETOHOTEL','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)

        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Room Number", "Folio No.", "Room No.", "Folio Number"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowHotelTransaction()
        LoadXgrid("CALL sp_salestransaction('HOTELTRN','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('HOTELTRN','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)

        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Room Number", "Folio Number"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowHotelPaymentTransaction()
        LoadXgrid("CALL sp_salestransaction('HOTELPMT','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('HOTELPMT','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)

        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Room Number", "Folio Number", "Reference No."}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowCheck()
        LoadXgrid("CALL sp_salestransaction('CHECK','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('CHECK','" & globalSalesTrnCOde.Text & "'," & Globalenablechittransaction & ")", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Reference", "Check No.", "Issuer Bank", "Date Transaction"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowCard()
        LoadXgrid("CALL sp_salestransaction('CARD','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('CARD','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Reference", "Card No.", "Trace Number", "Date Transaction"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowOnline()
        LoadXgrid("CALL sp_salestransaction('ONLINE','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('ONLINE','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Reference", "Date Transaction"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowVoucher()
        LoadXgrid("CALL sp_salestransaction('VOUCHER','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('VOUCHER','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Reference", "Voucher No.", "Date Transaction"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub ShowAccountingTicket()
        LoadXgrid("CALL sp_salestransaction('ACCOUNTING','" & globalSalesTrnCOde.Text & "',0)", "CALL sp_salestransaction('ACCOUNTING','" & globalSalesTrnCOde.Text & "',0)", Em, GridView1, Me)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Reference", "Date Transaction"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        FilterOption()
    End Sub


    Private Sub globalSalesTrnCOde_EditValueChanged(sender As Object, e As EventArgs) Handles globalSalesTrnCOde.EditValueChanged
        FilterOption()
    End Sub

    Private Sub cmdSalesBlotterSummary_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSalesBlotterSummary.LinkClicked
        XtraTabControl1.SelectedTabPage = tabSalesSummary
    End Sub

    Private Sub cmdClientAccounts_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdClientAccounts.LinkClicked
        XtraTabControl1.SelectedTabPage = tabKeyAccounts
    End Sub

    Private Sub cmdInterOffice_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdInterOffice.LinkClicked
        XtraTabControl1.SelectedTabPage = tabInterOffice
    End Sub

    Private Sub cmdCouponCharge_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdCouponCharge.LinkClicked
        XtraTabControl1.SelectedTabPage = tabCouponCharge
    End Sub

    Private Sub cmdBatchTransaction_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdBatchTransaction.LinkClicked
        XtraTabControl1.SelectedTabPage = tabBatch
    End Sub

    Private Sub cmdDetailedTransaction_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdDetailedTransaction.LinkClicked
        XtraTabControl1.SelectedTabPage = tabDetailed
    End Sub

    Private Sub cmdSoldProduct_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSoldProduct.LinkClicked
        XtraTabControl1.SelectedTabPage = tabSoldProduct
    End Sub

    Private Sub cmdVoidCancelled_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdVoidCancelled.LinkClicked
        XtraTabControl1.SelectedTabPage = tabVoid
    End Sub

    Private Sub cmdExpenses_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdExpenses.LinkClicked
        XtraTabControl1.SelectedTabPage = tabExpenses
    End Sub

    Private Sub cmdChargeToHotel_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdChargeToHotel.LinkClicked
        XtraTabControl1.SelectedTabPage = tabChargetoHotel
    End Sub

    Private Sub cmdHotelCharges_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdHotelCharges.LinkClicked
        XtraTabControl1.SelectedTabPage = tabHotelTrn
    End Sub

    Private Sub cmdHotelPayments_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdHotelPayments.LinkClicked
        XtraTabControl1.SelectedTabPage = tabHotelPayment
    End Sub

    Private Sub cmdCheck_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdCheck.LinkClicked
        XtraTabControl1.SelectedTabPage = tabCheck
    End Sub

    Private Sub cmdCard_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdCard.LinkClicked
        XtraTabControl1.SelectedTabPage = tabCard
    End Sub

    Private Sub cmdOnline_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdOnline.LinkClicked
        XtraTabControl1.SelectedTabPage = tabOnline
    End Sub

    Private Sub cmdVoucherPayment_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdVoucherPayment.LinkClicked
        XtraTabControl1.SelectedTabPage = tabVoucher
    End Sub

    Private Sub cmdAccountingTicket_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAccountingTicket.LinkClicked
        XtraTabControl1.SelectedTabPage = tabAccountingTicket
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(XtraTabControl1.SelectedTabPage.Text + "-" + Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        GenerateLXCashiersBlotter(globalSalesTrnCOde.Text, Me)

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        GenerateLXCashiersRemittance(globalSalesTrnCOde.Text, Me)
    End Sub
End Class