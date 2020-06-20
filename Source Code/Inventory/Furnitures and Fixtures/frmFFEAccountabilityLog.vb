Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI


Public Class frmFFEAccountabilityLog
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventoryManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        FilterAccountable()
        LoadGridviewAppearance(GridView1)
    End Sub

    Public Sub FilterAccountable()
        LoadXgrid("Select ffecode,id as 'Issue Number',acctableperson, accountname as 'Accountable Person', " _
                            + " date_format(dateissued,'%Y-%m-%d') as 'Date Issue', ifnull(date_format(returndate,'%Y-%m-%d'),'-') as 'Date Returned', Note, " _
                            + " case when iscurrent=0 then 'Returned' else 'Current' end as 'Status' from tblinventoryffeaccountable where ffecode='" & ffecode.Text & "'", "tblinventoryffeaccountable", Em, GridView1, Me)
        GridView1.Columns("ffecode").Visible = False
        GridView1.Columns("acctableperson").Visible = False
        GridView1.Columns("Note").ColumnEdit = MemoEdit
        XgridColAlign({"Issue Number", "Date Issue", "Date Returned", "Status"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub


    Private Sub PrintMemoradumOfReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintMemoradumOfReceiptToolStripMenuItem.Click
        Dim report As New rptMemorandumOfReceipt()
        report.txtIssueCode.Text = GridView1.GetFocusedRowCellValue("Issue Number").ToString()

        LoadXgrid("select DESCRIPTION as PARTICULAR, VALUE as DESCRIPTION from tblinventoryffedetails where ffecode='" & GridView1.GetFocusedRowCellValue("ffecode").ToString() & "' order by sortorder asc", "tblinventoryffedetails", gAccountable, gvAccountable, Me)
        XgridColAlign({"DESCRIPTION"}, gvAccountable, DevExpress.Utils.HorzAlignment.Center)

        report.PaperKind = System.Drawing.Printing.PaperKind.Legal
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(gAccountable))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub ffecode_EditValueChanged(sender As Object, e As EventArgs) Handles ffecode.EditValueChanged
        If ffecode.Text = "" Then Exit Sub
        FilterAccountable()
    End Sub
End Class