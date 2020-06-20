Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPumpReading
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
        LoadXgridLookupSearch("select distinct productid,(select itemname from tblglobalproducts  where actived = 1 and productid = tblsalesfuelpump.productid ) as 'Product Name' from tblsalesfuelpump", "tblsalesfuelpump", txtProduct, gridProduct, Me)
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
        Dim colCaption As String = "" : Dim pumpid As String = "" : Dim space As String = "" : pumpName = ""
        com.CommandText = "select distinct tblsalesfuelpump.pumpcode,description from tblsalesfuelpump inner join tblsalesfuelreading  on tblsalesfuelpump.pumpcode = tblsalesfuelreading.pumpcode where tblsalesfuelreading.productid='" & productid.Text & "' and date_format(dateentry, '%Y-%m-%d') <= '" & ConvertDate(txtdate.Text) & "'" : rst = com.ExecuteReader
        While rst.Read
            colCaption = colCaption + "0.000 as '" & UCase(rst("description").ToString) + "',0.000 as 'Sold Quantity" & space + "',0.00 as 'Unit Price" & space + "',0.00 as 'Balance" & space + "',"
            pumpid = pumpid + rst("pumpcode").ToString + ":"
            pumpName = pumpName + rst("description").ToString + ":"
            space = space + " "
        End While
        rst.Close()
        If colCaption = "" Then
            XtraMessageBox.Show("Query Transaction not found, please check proper date filter", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If colCaption <> "" Then
            colCaption = colCaption.Remove(colCaption.Length - 1, 1)
            pumpid = pumpid.Remove(pumpid.Length - 1, 1)
            pumpName = pumpName.Remove(pumpName.Length - 1, 1)
        End If
        LoadXgrid("Select trnsumcode, CONCAT(UCASE(SUBSTRING(`trnsumcode`, 1, 1)),LOWER(SUBSTRING(`trnsumcode`, 2))) as 'Transaction Code', entryby,date_format(dateentry, '%Y-%m-%d %r') as 'Transaction Date', (select fullname from tblaccounts where accountid = tblsalesfuelreading.entryby) as 'Transaction By' ," & colCaption & ",0.00 as Total from tblsalesfuelreading where productid='" & productid.Text & "' and date_format(dateentry, '%Y-%m-%d') <= '" & ConvertDate(txtdate.Text) & "' group by trnsumcode,entryby order by dateentry asc ", "tblsalesfuelreading", pivotGridControl1, GridView1, Me)
        Dim space_final As String = ""
        For Each word In pumpid.Split(New Char() {":"c})
            Dim cnt As Integer = 0 : Dim currentbalance As Double = 0 : Dim soldquantity As Double = 0
            For I = 0 To GridView1.RowCount - 1
                com.CommandText = "select *,(select description from tblsalesfuelpump where pumpcode = tblsalesfuelreading.pumpcode) as 'pump' from tblsalesfuelreading where pumpcode='" & word & "' and trnsumcode='" & GridView1.GetRowCellValue(I, "trnsumcode").ToString & "'" : rst = com.ExecuteReader
                While rst.Read
                    If cnt = 0 Then
                        currentbalance = rst("quantity")
                        GridView1.SetRowCellValue(I, rst("pump"), rst("quantity"))
                        GridView1.SetRowCellValue(I, "Sold Quantity" & space_final, 0)
                        GridView1.SetRowCellValue(I, "Unit Price" & space_final, rst("unitprice").ToString)
                        GridView1.SetRowCellValue(I, "Balance" & space_final, 0)
                    Else
                        soldquantity = rst("quantity") - currentbalance
                        currentbalance = rst("quantity")
                        GridView1.SetRowCellValue(I, rst("pump"), rst("quantity"))
                        GridView1.SetRowCellValue(I, "Sold Quantity" & space_final, soldquantity)
                        GridView1.SetRowCellValue(I, "Unit Price" & space_final, rst("unitprice").ToString)
                        GridView1.SetRowCellValue(I, "Balance" & space_final, rst("unitprice") * soldquantity)
                    End If
                End While
                rst.Close()
                cnt = cnt + 1
            Next
            space_final = space_final + " "
           
        Next
        space_final = ""
        For I = 0 To GridView1.RowCount - 1
            Dim total As Double = 0
            For Each word In pumpName.Split(New Char() {":"c})
                total = total + Val(CC(GridView1.GetRowCellValue(I, "Balance" + space_final).ToString))
                space_final = space_final + " "
            Next
            GridView1.SetRowCellValue(I, "Total", total)
            space_final = ""
        Next
        space_final = ""
        For Each word In pumpName.Split(New Char() {":"c})
            XgridColCurrency({word, "Sold Quantity" + space_final, "Unit Price" + space_final, "Balance" + space_final}, GridView1)
            XgridColWidth({word, "Balance" + space_final}, GridView1, 80)
            space_final = space_final + " "
        Next

        XgridColCurrency({"Total"}, GridView1)
        XgridColWidth({"Total"}, GridView1, 80)
        XgridColAlign({"Transaction Date", "Transaction Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridHideColumn({"entryby", "trnsumcode"}, GridView1)
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