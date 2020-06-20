Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmReadingComparison
    Dim pumpName As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

             
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadProduct()

         
        LoadGridviewAppearance(GridView1)
        txtdate.Text = Format(Now)
    End Sub

    Public Sub LoadProduct()
        LoadXgridLookupSearch("select distinct productid,(select itemname from tblglobalproducts  where  actived = 1 and productid = tblsalesfuelpump.productid ) as 'Product Name' from tblsalesfuelpump", "tblsalesfuelpump", txtProduct, gridProduct, Me)
        gridProduct.Columns("productid").Visible = False
    End Sub

    Private Sub txtItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProduct.Properties.View.FocusedRowHandle.ToString)
        productid.Text = txtProduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtProduct.Text = txtProduct.Properties.View.GetFocusedRowCellValue("Product Name").ToString()
        If productid.Text = "" Then Exit Sub

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        filter()
    End Sub
    Public Sub filter()
        LoadXgrid("select productid, CONCAT(UCASE(SUBSTRING(`trnsumcode`, 1, 1)),LOWER(SUBSTRING(`trnsumcode`, 2))) as 'Transaction Code', date_format(dateentry, '%Y-%m-%d %r') as 'Transaction Date', (select fullname from tblaccounts where accountid = a.entryby) as 'Transaction By', (select itemname from tblglobalproducts where productid = a.productid and actived=1) as 'Product', " _
                        + " ifnull(sum(quantity-(select quantity from tblsalesfuelreading as b where b.dateentry  <  a.dateentry and b.pumpcode = a.pumpcode order by dateentry desc limit 1 )),0) as 'Total Sold Quantity from Reading', " _
                        + " ifnull((select sum(quantity) from tblsalesfuelsold where productid = a.productid and trnsumcode = a.trnsumcode),0) as 'Total Sold Quantity from Sales', " _
                        + " ifnull((select sum(quantity) from tblsalesfuelsold where productid = a.productid and trnsumcode = a.trnsumcode),0) - sum(quantity-(select quantity from tblsalesfuelreading as b where b.dateentry  <  a.dateentry and b.pumpcode = a.pumpcode order by dateentry desc limit 1 )) as 'Variance' from tblsalesfuelreading as a where a.productid='" & productid.Text & "' and date_format(a.dateentry,'%Y-%m-%d') <= '" & ConvertDate(txtdate.Text) & "' group by productid,dateentry", "tblsalesfuelreading", pivotGridControl1, GridView1, Me)


        XgridColCurrency({"Total Sold Quantity from Reading", "Total Sold Quantity from Sales", "Variance"}, GridView1)
        GridView1.BestFitColumns()

        XgridColAlign({"Transaction Date", "Transaction Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridHideColumn({"productid"}, GridView1)
        XgridGeneralSummaryCurrency({"Total Sold Quantity from Reading", "Total Sold Quantity from Sales", "Variance"}, GridView1)
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        Dim status As Double = Val(CC(View.GetRowCellDisplayText(e.RowHandle, View.Columns("Variance")).ToString))
        If gen_filterappearance = True Then
            If e.Column.FieldName = "Variance" Then
                If status < 0 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        frmClientModification.mode.Text = ""
        frmClientModification.id.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmClientModification.mode.Text = "edit"
        If frmClientModification.Visible = True Then
            frmClientModification.Focus()
        Else
            frmClientModification.Show(Me)
        End If
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("Client ID", "cifid", "tblclientaccounts", GridView1, Me)
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        GridView1.ShowFindPanel()
    End Sub
      
End Class