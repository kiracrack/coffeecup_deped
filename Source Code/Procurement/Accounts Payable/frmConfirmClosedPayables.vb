Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI

Public Class frmConfirmClosedPayables
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

        ListView1.View = View.Details

        ListView1.Columns.Add("Reference No", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Office", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Supplier", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Total", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("Date Approved", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("ref", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("vendorid", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Note", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("officeid", -2, HorizontalAlignment.Left)

        ListView1.Columns(0).Width = 80
        ListView1.Columns(1).Width = 140
        ListView1.Columns(2).Width = 150
        ListView1.Columns(3).Width = 90
        ListView1.Columns(4).Width = 150
        ListView1.Columns(5).Width = 0
        ListView1.Columns(6).Width = 0
        ListView1.Columns(7).Width = 0
        ListView1.Columns(8).Width = 0
        LoadPurchaseOrder()

    End Sub


    Public Sub LoadPurchaseOrder()
        ListView1.Items.Clear()
        com.CommandText = "Select *, requestref, ponumber as 'PO Number', " _
                   + " (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) as 'Office', " _
                   + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', " _
                   + " ifnull((select sum(total) from tblpurchaseorderitem where ponumber =  tblpurchaseorder.ponumber),0) as 'Total', " _
                   + " date_format(dateverified,'%Y-%m-%d %r') as 'Date Approved',vendorid " _
                   + " from tblpurchaseorder " _
                   + " where verified=1 and delivered=1 and paymentrequested=1 and paymentupdated=1 and closed=0 and cancelled=0 " _
                   + " and (ponumber like '%" & txtSearch.Text & "%' or " _
                   + " (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) like '%" & txtSearch.Text & "%' or " _
                   + " date_format(tblpurchaseorder.datetrn,'%Y-%m-%d') like '%" & txtSearch.Text & "%' or " _
                   + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) like '%" & txtSearch.Text & "%' or " _
                   + " date_format(datetrn,'%Y-%m-%d') like '%" & txtSearch.Text & "%') order by datetrn desc" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("PO Number").ToString, 0)
            item1.SubItems.Add(rst("Office").ToString)
            item1.SubItems.Add(rst("Supplier").ToString)
            item1.SubItems.Add(FormatNumber(rst("Total").ToString, 2))
            item1.SubItems.Add(rst("Date Approved").ToString)
            item1.SubItems.Add(rst("requestref").ToString)
            item1.SubItems.Add(rst("vendorid").ToString)
            item1.SubItems.Add(rst("note").ToString)
            item1.SubItems.Add(rst("officeid").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Dim poLocation As String = "'"
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each itm As ListViewItem In ListView1.CheckedItems
                RecordApprovingHistory("AP Account", itm.SubItems(5).Text, itm.SubItems(0).Text, "Closed", "Ref#" & itm.SubItems(0).Text & " closed account")
                com.CommandText = "update tblpurchaseorder set closed=1, dateclosed=current_timestamp where ponumber='" & itm.SubItems(0).Text & "'" : com.ExecuteNonQuery()
            Next
            LoadPurchaseOrder()
            XtraMessageBox.Show("Selected accounts payable completely closed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = True
            Next
        Else
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = False
            Next
        End If
    End Sub


    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtSearch.Text = "" Then Exit Sub
            LoadPurchaseOrder()
        End If
    End Sub
End Class