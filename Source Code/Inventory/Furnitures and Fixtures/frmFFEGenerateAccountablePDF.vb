Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI

Public Class frmFFEGenerateAccountablePDF
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmFFEGenerateAccountablePDF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        Dim firstDayofMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)

        ListView1.View = View.Details

        ListView1.Columns.Add("FFE Code", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Item Name", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("FFE Category", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Office", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Accountable Person", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Date Issued", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("id", -2, HorizontalAlignment.Center)

        ListView1.Columns(0).Width = 90
        ListView1.Columns(1).Width = 140
        ListView1.Columns(2).Width = 150
        ListView1.Columns(3).Width = 150
        ListView1.Columns(4).Width = 150
        ListView1.Columns(5).Width = 100
        ListView1.Columns(6).Width = 0
        LoadDetails()

    End Sub


    Public Sub LoadDetails()
        ListView1.Items.Clear()
        com.CommandText = "SELECT b.*, date_format(b.dateissued,'%Y-%m-%d') as dtissued, a.productname, a.ffecode,(select description from tblinventoryffetype where code=a.ffetype) as ffetypes,(select officename from tblcompoffice where officeid=a.officeid) as office FROM `tblinventoryffe` as a inner join tblinventoryffeaccountable as b on a.ffecode=b.ffecode where b.iscurrent=1 and b.generatedffedoc=0;" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("ffecode").ToString, 0)
            item1.SubItems.Add(rst("productname").ToString)
            item1.SubItems.Add(rst("ffetypes").ToString)
            item1.SubItems.Add(rst("office").ToString)
            item1.SubItems.Add(rst("accountname").ToString)
            item1.SubItems.Add(rst("dtissued").ToString)
            item1.SubItems.Add(rst("id").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If GlobalPOPaymentGLItemCode = "" Then
            XtraMessageBox.Show("Global Payment GL Item for Purchase Order not set!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each itm As ListViewItem In ListView1.CheckedItems
                Dim ffeAccountableLocation = Application.StartupPath.ToString & "\Transaction\Memorandum of Receipt\" & Format(CDate(itm.SubItems(5).Text), "yyyy-MM-dd")
                If (Not System.IO.Directory.Exists(ffeAccountableLocation)) Then
                    System.IO.Directory.CreateDirectory(ffeAccountableLocation)
                End If
                Dim report As New rptMemorandumOfReceipt()
                report.txtIssueCode.Text = itm.SubItems(6).Text

                LoadXgrid("select DESCRIPTION as PARTICULAR, VALUE as DESCRIPTION from tblinventoryffedetails where ffecode='" & itm.SubItems(0).Text & "' order by sortorder asc", "tblinventoryffedetails", Em, GridView1, Me)
                XgridColAlign({"DESCRIPTION"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

                report.PaperKind = System.Drawing.Printing.PaperKind.Legal
                report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Em))

                Dim filename As String = itm.SubItems(0).Text & " - " & rchar(itm.SubItems(6).Text.Replace("/", "")) & " " & rchar(itm.SubItems(4).Text.Replace("/", "")) & ".pdf"

                If Not (System.IO.File.Exists(ffeAccountableLocation & "\" & filename)) Then
                    System.IO.File.Delete(ffeAccountableLocation & "\" & filename)
                End If
                report.ExportToPdf(ffeAccountableLocation & "\" & filename)
                AddAttachmentPackage(itm.SubItems(0).Text, "memorandum-of-receipt", {ffeAccountableLocation & "\" & filename})
                com.CommandText = "Update tblinventoryffeaccountable set generatedffedoc=1 where id='" & itm.SubItems(6).Text & "'" : com.ExecuteNonQuery()
            Next
            
            LoadDetails()
            XtraMessageBox.Show("Selected item successfully generated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            LoadDetails()
        End If
    End Sub
End Class