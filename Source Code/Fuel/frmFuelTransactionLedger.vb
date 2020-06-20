Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmFuelTransactionLedger
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
        LoadXgrid("select datetrn as dt, date_format(datetrn,'%Y-%m-%d') as 'Transaction Date', Remarks, quantity as 'Stock In', 0 as 'Stock Out',0.00 as Balance,'Manual Inventory' as 'Transaction Type',(select fullname from tblaccounts where accountid =tblinventorylogs.trnby) as 'Transaction By' from  tblinventorylogs where productid='" & productid.Text & "' and confirmed=1 and date_format(datetrn,'%Y-%m-%d') <='" & ConvertDate(txtdate.Text) & "' union " _
                        + " select datetrn as dt,  date_format(datetrn,'%Y-%m-%d'), concat('Purchase Order #',ponumber),quantity,0,0,'Purchase Order', (select fullname from tblaccounts where accountid = tblpurchaseorderitem.trnby) from tblpurchaseorderitem where productid='" & productid.Text & "' and purchased=1 union " _
                        + " select dateclose as dt, date_format(dateclose,'%Y-%m-%d'),  concat('Transaction #',trncode),0,sum(tblsalesfuelsold.quantity), 0,'Pump Reading',(select fullname from tblaccounts where accountid = tblsalessummary.userid) from tblsalessummary inner join tblsalesfuelsold on tblsalesfuelsold.trnsumcode = tblsalessummary.trncode where productid='" & productid.Text & "' and date_format(tblsalessummary.dateclose,'%Y-%m-%d') <='" & ConvertDate(txtdate.Text) & "' union " _
                        + " select datetrn as dt, date_format(datetrn,'%Y-%m-%d'), remarks,0,quantity,0,'Stock Out',(select fullname from tblaccounts where accountid = tblstockoutitem.trnby) from tblstockoutitem where productid='" & productid.Text & "' and status=0 and date_format(datetrn,'%Y-%m-%d') <='" & ConvertDate(txtdate.Text) & "' order by dt asc;", "tblinventorylogs", pivotGridControl1, GridView1, Me)

        Dim cnt As Integer = 0 : Dim currentbalance As Double = 0 : Dim soldquantity As Double = 0
        For I = 0 To GridView1.RowCount - 1
            If cnt = 0 Then
                currentbalance = GridView1.GetRowCellValue(I, "Stock In").ToString
                GridView1.SetRowCellValue(I, "Balance", currentbalance)
            Else
                currentbalance = (currentbalance + Val(CC(GridView1.GetRowCellValue(I, "Stock In").ToString))) - Val(CC(GridView1.GetRowCellValue(I, "Stock Out").ToString))
                'currentbalance = GridView1.GetRowCellValue(I, "Stock In").ToString
                GridView1.SetRowCellValue(I, "Balance", currentbalance)
            End If
            cnt = cnt + 1
        Next
        XgridColCurrency({"Stock In", "Stock Out", "Balance"}, GridView1)
        XgridColWidth({"Stock In", "Stock Out", "Balance"}, GridView1, 80)

        XgridColAlign({"Transaction Date"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridHideColumn({"dt"}, GridView1)
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        If pumpName = "" Then Exit Sub
        Dim View As GridView = sender
        If gen_filterappearance = True Then
            For Each word In pumpName.Split(New Char() {":"c})
                If e.Column.FieldName = word Then
                    e.Appearance.BackColor = Color.Gold
                    e.Appearance.ForeColor = Color.Black
                End If
            Next
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