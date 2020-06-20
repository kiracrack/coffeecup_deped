Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmPrmtEmployees

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        com.CommandText = "DROP TABLE IF EXISTS `tblkbemployees`;" : com.ExecuteNonQuery()
        com.CommandText = "create table tblkbemployees (Number int(10) unsigned PRIMARY KEY NOT NULL AUTO_INCREMENT) SELECT " _
                       + " employeeinfo.emp_id, " _
                       + " concat(employeeinfo.emp_familyname,', ', " _
                       + " employeeinfo.emp_firstname) as fullname, " _
                       + " company.com_company, " _
                       + " company.com_branch, " _
                       + " company.com_department, " _
                       + " company.com_position " _
                       + " FROM " _
                       + sqljoinbase & ".company " _
                       + " INNER JOIN " & sqljoinbase & ".employeeinfo ON employeeinfo.emp_id = company.emp_id " _
                       + " WHERE " _
                       + " employeeinfo.emp_active = 1; " : com.ExecuteNonQuery()
        Filter()
        com.CommandText = "update tblaccounts set designation=(select company.com_position from " & sqljoinbase & ".company where company.emp_id = tblaccounts.username)" : com.ExecuteNonQuery()
        SplashScreenManager.CloseForm()
        XtraMessageBox.Show("Data Successfully Synchronized! " & GridView1.RowCount - 1 & " Records Found", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub Filter()
        LoadXgrid("Select emp_id as 'Employee ID', Fullname, com_branch as '" & GlobalOfficeCaption & "', com_department as 'Department', com_position as 'Position' from tblkbemployees order by fullname", "tblkbemployees", Em, GridView1, Me)
    End Sub

    Private Sub frmPrmtEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
    End Sub
End Class