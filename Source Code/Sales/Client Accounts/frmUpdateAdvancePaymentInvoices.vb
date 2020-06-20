Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmUpdateAdvancePaymentInvoices
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        Dim firstDayofMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)

        Dim advancepayment As Double = qrysingledata("total", "sum(debit)-sum(credit) as 'total'", "where accountno='" & cifid.Text & "' and cleared=1 and cancelled=0", "tblglaccountledger")

        If advancepayment < 0 Then
            txtAdvancePayment.Text = Str(advancepayment).Replace("-", "")
        End If

        ListView1.View = View.Details
        ListView1.Columns.Add("Date", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("trnid", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Order Number", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Invoice No.", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Amount", -2, HorizontalAlignment.Right)
        ListView1.Columns(1).Width = 0
        ListView1.Columns(0).Width = 90
        ListView1.Columns(2).Width = 90
        ListView1.Columns(4).Width = 120
        LoadInvoices()
    End Sub
   
    
    Public Sub LoadInvoices()
        ListView1.Items.Clear()
        com.CommandText = "select trnid,date_format(datetrn,'%Y-%m-%d') as 'Date', batchcode as 'Order Number', invoiceno as 'Invoice No.' , Amount  from tblsalesclientcharges where accountno='" & cifid.Text & "' and paymentupdated=0 and verified=1 and cancelled=0  order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("Date").ToString, 0)
            item1.SubItems.Add(rst("trnid").ToString)
            item1.SubItems.Add(rst("Order Number").ToString)
            item1.SubItems.Add(rst("Invoice No.").ToString)
            item1.SubItems.Add(FormatNumber(rst("Amount").ToString, 2))
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtClientAccount.Text = "" Then
            XtraMessageBox.Show("Please Select client!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClientAccount.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim PaymentTrnID As String = getdateid()
            For Each itm As ListViewItem In ListView1.CheckedItems
                com.CommandText = "update tblsalesclientcharges set paymentupdated=1, paymentrefnumber='" & PaymentTrnID & "' where trnid='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
            Next
            LoadInvoices()
            XtraMessageBox.Show("Invoices successfully mark as paid!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ckDiscount_CheckedChanged_1(sender As Object, e As EventArgs) Handles ckDiscount.CheckedChanged
        If ckDiscount.Checked = True Then
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = True
            Next
        Else
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = False
            Next
        End If
    End Sub

  
End Class