Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Skins

Public Class frmAdvanceSearch
    Private Sub frmSelectPOItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        XtraTabPage1.Focus()
        txtfilter.Focus()
        filterItem()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.F3) Then
            txtfilter.SelectAll()
            txtfilter.Focus()

        ElseIf keyData = (Keys.F5) Then
            filterItem()

        ElseIf keyData = (Keys.Control + Keys.N) Then
            AddProduct("", Me)
        End If

        Return ProcessCmdKey
    End Function


    Public Sub filterItem()
        If txtfilter.Text = "" Then Exit Sub
        LoadXgrid("Select tblrequisitions.pid as 'Request No.', " _
                          + " (select officename from tblcompoffice where officeid=tblrequisitions.officeid) as '" & GlobalOfficeCaption & "' , " _
                          + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tblrequisitionsitem.PRODUCTID) as 'Particular', " _
                          + " (select description from tblprocategory where catid=tblrequisitionsitem.catid) as 'Category', " _
                          + " QUANTITY as 'Quantity', " _
                          + " UNIT as 'Unit', " _
                          + " COST as 'Unit Price', Total," _
                          + " daterequest as 'Date Request', " _
                          + " (select companyname from tblglobalvendor where vendorid=tblrequisitionsitem.vendorid) as 'Vendor', " _
                          + " Details  " _
                          + " from tblrequisitionsitem inner join tblrequisitions on  tblrequisitionsitem.pid = tblrequisitions.pid where " _
                          + " (tblrequisitions.pid like '%" & rchar(txtfilter.Text) & "%' or " _
                          + " (select officename from tblcompoffice where officeid=tblrequisitions.officeid) like '%" & rchar(txtfilter.Text) & "%' or " _
                          + " productid like '%" & rchar(txtfilter.Text) & "%' or  " _
                          + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tblrequisitionsitem.PRODUCTID) like '%" & rchar(txtfilter.Text) & "%' or " _
                          + " (select description from tblprocategory where catid=tblrequisitionsitem.catid) like '%" & rchar(txtfilter.Text) & "%' or  " _
                          + " QUANTITY like '%" & rchar(txtfilter.Text) & "%' or  " _
                          + " COST like '%" & rchar(txtfilter.Text) & "%' or  " _
                          + " daterequest like '%" & rchar(txtfilter.Text) & "%' or  " _
                          + " (select companyname from tblglobalvendor where vendorid=tblrequisitionsitem.vendorid) like '%" & rchar(txtfilter.Text) & "%' or  " _
                          + " tblrequisitionsitem.REMARKS like '%" & rchar(txtfilter.Text) & "%' or " _
                          + " tblrequisitions.details like '%" & rchar(txtfilter.Text) & "%' or " _
                          + " total like '%" & rchar(txtfilter.Text) & "%')  " _
                          + " order by daterequest asc", "tblrequisitionsitem", Em, GridView1, Me)
        Dim item As New GridGroupSummaryItem()
        item.FieldName = GlobalOfficeCaption
        item.SummaryType = DevExpress.Data.SummaryItemType.Count

        Dim item1 As New GridGroupSummaryItem()
        item1.FieldName = "Total"
        item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item1.DisplayFormat = "{0:n}"
        item1.ShowInGroupColumnFooter = GridView1.Columns("Total")
        GridView1.GroupSummary.Add(item1)


        GridView1.Columns("Details").ColumnEdit = MemoEdit
        XgridColAlign({"Request No.", "Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()

        'GridView1.Columns("potrnid").Visible = False
        'GridView1.Columns("officeid").Visible = False

        XgridColCurrency({"Unit Price"}, GridView1)
        XgridColCurrency({"Total"}, GridView1)

        GridView1.Columns("Unit Price").Width = 100
        GridView1.Columns("Details").Width = 350
        GridView1.Columns("Total").Width = 180
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        filterItem()
    End Sub

    Private Sub SelectItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectItemToolStripMenuItem.Click
        If CheckSelectedRow("Request No.", GridView1) = True Then
            frmRequestProfile.pid.Text = GridView1.GetFocusedRowCellValue("Request No.").ToString()
            frmRequestProfile.Show(Me)
        End If

    End Sub

    Private Sub txtfilter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar = Chr(13) Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            filterItem()
            SplashScreenManager.CloseForm()
        End If
    End Sub

    
End Class