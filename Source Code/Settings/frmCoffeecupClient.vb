Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCoffeecupClient

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub Filter()
        LoadXgrid("Select (select officename from tblcompoffice where officeid = tblsystemupdate.officeid) as '" & GlobalOfficeCaption & "', version as 'Current Version', date_format(datecheck,'%Y-%m-%d %r') as 'Last Login', " _
                  + " case when date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') = (select date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') from tblclientsystemupdate where active=1 and server=0) then 'Up to Date'  " _
                  + " when date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') > (select date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') from tblclientsystemupdate where active=1 and server=0) then 'Advanced'  " _
                  + " when date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') < (select date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') from tblclientsystemupdate where active=1 and server=0) then 'Outdated'  " _
                  + " else 'Invalid' end as 'Status' from tblsystemupdate where officeid<>''  order by (select officename from tblcompoffice where officeid = tblsystemupdate.officeid) asc", "tblsystemupdate", Em, GridView1, Me)
        XgridColAlign({"Status", "Current Version", "Last Login"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub frmPrmtEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        com.CommandText = "select * from tblclientsystemupdate where active=1" : rst = com.ExecuteReader
        While rst.Read
            txtDetails.Text = rst("details").ToString
            txtVersion.Text = rst("version").ToString
            txtDownloadUrl.Text = rst("downloadurl").ToString
            txtFeatures.Text = rst("features").ToString
            txtPassword.Text = rst("password").ToString
        End While
        rst.Close()
        Filter()
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If gen_filterappearance = True Then
            If e.Column.Name = "colStatus" Then
                Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
                If status = "Outdated" Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.ForeColor = Color.White
                ElseIf status = "Advanced" Then
                    e.Appearance.BackColor = Color.Blue
                    e.Appearance.ForeColor = Color.White
                ElseIf status = "Invalid" Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.ForeColor = Color.Wheat
                ElseIf status = "Up to Date" Then
                    e.Appearance.BackColor = Color.Gold
                    e.Appearance.ForeColor = Color.Black

                End If
            End If

        End If

    End Sub

    Private Sub menu_Refresh_Click(sender As Object, e As EventArgs) Handles menu_Refresh.Click
        Filter()
    End Sub
End Class