Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraSplashScreen

Public Class frmInventoryAdjustment
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then
           

        ElseIf keyData = (Keys.Control) + Keys.P Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmDamage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       SkinManager.EnableMdiFormSkins() : SetIcon(Me) 

       txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)

        filter()
        LoadGridviewAppearance(GridView1)
    End Sub

    Public Sub filter()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " where date_format(dateadj,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " where date_format(dateadj,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        LoadXgrid("SELECT (select officename from tblcompoffice where officeid=tblinvetoryadj.officeid) as 'Adjustment From', " _
                      + " (select ITEMNAME from tblglobalproducts where PRODUCTID = tblinvetoryadj.PRODUCTID) as 'Particular', " _
                      + " (select description from tblprocategory where catid=tblinvetoryadj.catid) as 'Category'," _
                      + " QUANTITY as Quantity, " _
                      + " (select unit from tblglobalproducts where PRODUCTID = tblinvetoryadj.PRODUCTID) as 'Unit', " _
                      + " REMARKS as 'Remarks', date_format(dateadj, '%Y-%m-%d %r') as 'Date Adjustment',(select fullname from tblaccounts where accountid=tblinvetoryadj.trnby) as 'Adjustment By' from tblinvetoryadj " & filterasof & " order by dateadj desc", "tblinvetoryadj", Em, GridView1, Me)

        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        GridView1.Columns("Quantity").Width = 60
        XgridColAlign({"Quantity"}, GridView1, HorzAlignment.Center)
        XgridColCurrency({"Quantity"}, GridView1)
        GridView1.BestFitColumns()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

#Region "REPORT SETTINGS"
    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintReport.Click

    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filter()
        SplashScreenManager.CloseForm()
    End Sub
#End Region

End Class