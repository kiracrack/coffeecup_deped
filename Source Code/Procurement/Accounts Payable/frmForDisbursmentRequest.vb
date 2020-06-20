Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI

Public Class frmForDisbursmentRequest
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmApproverFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadApprovedRequest()
    End Sub

    Public Sub LoadApprovedRequest()
        LoadXgrid("Select  requestref,officeid,vendorid, ponumber as 'Reference No', " _
                   + " if(forpo=1,'PURCHASE ORDER','PAYMENT ORDER') as 'Transaction Type', " _
                   + " (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) as 'Office', " _
                   + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', " _
                   + " totalamount as 'Total', " _
                   + " if(delivered=1,'Delivered','Not Yet Delivered') as 'Status', " _
                   + " date_format(datedelivered,'%Y-%m-%d %r') as 'Date Delivered' " _
                   + " from tblpurchaseorder " _
                   + " where verified=1 and delivered=1 and corporatelevel=1 and tblpurchaseorder.cancelled=0 and forwarded=1 and paymentrequested=0 order by datetrn desc", "tblpurchaseorder", Em, GridView1, Me)
        XgridHideColumn({"requestref", "officeid", "vendorid"}, GridView1)
        XgridColCurrency({"Total"}, GridView1)
        XgridColAlign({"Reference No", "Transaction Type", "Status", "Date Delivered"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub


    Private Sub cmdViewItem_Click(sender As Object, e As EventArgs) Handles cmdViewItem.Click
        frmRequestProfile.pid.Text = GridView1.GetFocusedRowCellValue("requestref").ToString
        frmRequestProfile.Show(Me)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadApprovedRequest()
    End Sub

 

    Public Function ConfirmPO(ByVal voucherno As String, ByVal ponumber As String)
        com.CommandText = "update tblpurchaseorder set paymentrequested=1, paymentrequestedby='" & globaluserid & "', paymentupdated=1, paymentrefnumber='" & voucherno & "' where ponumber='" & ponumber & "'" : com.ExecuteNonQuery()
        LoadApprovedRequest()
        Return True
    End Function

End Class