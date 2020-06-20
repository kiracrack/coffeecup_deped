Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmDailyTransactionReports
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        txtReportDate.EditValue = CDate(Now)
        LoadCompany()
      
    End Sub
    Public Sub LoadCompany()
        LoadXgridLookupSearch("select code, Companyname as 'Select Company' from tblcompany", "tblcompany", txtCompany, gvCompany, Me)
        gvCompany.Columns("code").Visible = False
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub
 
    Private Sub cmdaction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        ShowReport()
        SplashScreenManager.CloseForm()
    End Sub

    Public Sub ShowReport()
        LoadXgrid("CALL sp_dailysalessummary('" & companyid.Text & "','" & ConvertDate(txtReportDate.EditValue) & "')", "CALL sp_dailysalessummary('" & companyid.Text & "','" & ConvertDate(txtReportDate.EditValue) & "')", Em, GridView1, Me)

        XgridColCurrency({"PurchasePrice", "UnitPrice", "Discount", "Charge", "TotalAmount", "MTD", "Amount", "Today", "Income", "VAT", "SVC", "Total"}, GridView1)
        XgridColAlign({"ItemCode", "ProductID", "DiscountRate", "DateTransaction", "Unit", "Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        ' XgridGroupSummaryCurrency({"PurchasePrice", "UnitPrice", "Discount", "Charge", "TotalAmount", "MTD", "Amount", "Today", "Income", "VAT", "SVC", "Total"}, GridView1)
        ' XgridGeneralSummaryCurrency({"PurchasePrice", "UnitPrice", "Discount", "Charge", "TotalAmount", "MTD", "Amount", "Today", "Income", "VAT", "SVC", "Total"}, GridView1)
        XgridColWidth({"Description"}, GridView1, 350)
        XgridColWidth({"PurchasePrice", "UnitPrice", "Discount", "Charge", "TotalAmount", "MTD", "Amount", "Today", "Income", "VAT", "SVC", "Total"}, GridView1, 150)
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub


    Private Sub cmdExportToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel(txtCompany.Text + "-" + txtReportDate.Text, GridView1)
    End Sub

End Class