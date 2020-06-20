Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.Skins
Imports System.IO

Public Class frmTrashItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmForApprovalList_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        pid.Text = ""
    End Sub

    Private Sub frmForApprovalList_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
          SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        filter(pid.Text)
        LoadGridviewAppearance(GridView1)
        lbloffice.Text = GlobalOfficeCaption
    End Sub
    Private Function formatcurrency(ByVal i As Integer)
        GridView1.Columns(i).DisplayFormat.FormatType = FormatType.Numeric
        GridView1.Columns(i).DisplayFormat.FormatString = "n"
        Return 0
    End Function

    Private Sub pid_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pid.EditValueChanged
        If pid.Text = "" Then Exit Sub
        loaddetails(pid.Text)
    End Sub
    Public Function loaddetails(ByVal id As String)
        com.CommandText = "select *, (select officename from tblcompoffice where officeid =tbldelpurchasetitle.officeid ) as '" & GlobalOfficeCaption & "', " _
                                 + " (select fullname from tblaccounts where accountid = tbldelpurchasetitle.REQUESTBY) as 'REQUEST', " _
                                 + " (select DESCRIPTION from tblrequesttype where POTYPEID = tbldelpurchasetitle.POTYPEID) as 'POTYPE', " _
                                 + " (select designation from tblaccounts where accountid = tbldelpurchasetitle.REQUESTBY) as 'DESIGNATION', " _
                                 + " CASE WHEN STATUS='0' THEN 'Received' WHEN STATUS='1' THEN 'For Approval' WHEN STATUS='2' THEN 'Approved' WHEN STATUS='3' THEN 'Disapproved' WHEN STATUS='4' THEN 'Revise' END  as 'STATS'  " _
                                 + " from tbldelpurchasetitle where PID='" & id & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtoffice.Text = rst(GlobalOfficeCaption).ToString
            txtRequestby.Text = rst("REQUEST").ToString
            txtDesignation.Text = rst("DESIGNATION").ToString
            txtdatereq.Text = rst("DATEREQUEST").ToString
            txtdetails.Text = rst("DETAILS").ToString
            txtStatus.Text = rst("STATS").ToString
            txtpotype.Text = rst("POTYPE").ToString
            purchaserid.Text = rst("purchaser").ToString
        End While
        rst.Close()
        Return 0
    End Function
    Public Function filter(ByVal id As String)
        LoadXgrid("Select TRNID,(select ITEMNAME from tblglobalproducts where PRODUCTID = tbldelpurchaseitem.PRODUCTID ) as 'Particular Item', " _
                      + " QUANTITY as 'Quantity'," _
                      + " UNIT as 'Unit', " _
                      + " COST as 'Cost', " _
                      + " TOTAL as 'Total', " _
                      + " Remarks, " _
                      + " (select COMPANYNAME from tblglobalvendor where vendorid = tbldelpurchaseitem.vendorid ) as 'Vendor' " _
                      + " from tbldelpurchaseitem " _
                      + " where PURCHASEID='" & id & "'", "tblrequisitionsitem", Em, GridView1, Me)
        GridView1.BestFitColumns()
        GridView1.Columns("TRNID").Visible = False
        XgridColCurrency({"Cost"}, GridView1)
        XgridColCurrency({"Total"}, GridView1)
        GridView1.Columns("Quantity").Width = 60
        GridView1.Columns("Cost").Width = 120
        GridView1.Columns("Total").Width = 180


        GridView1.Columns("Particular Item").ColumnEdit = MemoEdit
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit

        XgridColAlign({"Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("Total").Summary.Clear()
        GridView1.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "Total {0:n} Php")
        CType(GridView1.Columns("Total").View, GridView).OptionsView.ShowFooter = True

        Return 0
    End Function

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter(pid.Text)
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

End Class