Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmAttendanceFilter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAttendanceFilter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        rst.Close()
    End Sub

    Private Sub frmAttendanceFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCategory()
        ShowUnfilteredEmployee()
        ShowfilteredEmployee()
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupSearch("select accountid,Fullname as 'Select Approver' from tblaccounts where coffeecupposition in (select authcode from tbluserauthority where (officeapprover=1 or corpapprover=1 or approveanyoffices=1)) order by Fullname asc", "tblaccounts", txtprocat, gridApprover, Me)
        gridApprover.Columns("accountid").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocat.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        approverid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtprocat.Text = txtprocat.Properties.View.GetFocusedRowCellValue("Select Approver").ToString()
        ShowUnfilteredEmployee()
        ShowfilteredEmployee()
    End Sub

    Public Sub ShowUnfilteredEmployee()
        If approverid.Text <> "" Then
            LoadXgrid("select employeeid, fullname as 'Employee Name' from tblemployees where employeeid not in (select employeeid from tblpayrollattendancefilter where approverid= '" & approverid.Text & "') order by fullname asc", "tblemployees", Em_unfiltered, GridView1, Me)
            GridView1.Columns("employeeid").Visible = False
        End If
    End Sub

    Public Sub ShowfilteredEmployee()
        If approverid.Text <> "" Then
            LoadXgrid("select employeeid, (select fullname from tblemployees where employeeid= tblpayrollattendancefilter.employeeid) as 'Employee Name' from tblpayrollattendancefilter where approverid='" & approverid.Text & "' order by (select fullname from tblemployees where employeeid= tblpayrollattendancefilter.employeeid) asc", "tblpayrollattendancefilter", Em_filtered, GridView2, Me)
            GridView2.Columns("employeeid").Visible = False
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "insert into tblpayrollattendancefilter set approverid='" & approverid.Text & "', employeeid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "employeeid").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredEmployee()
        ShowfilteredEmployee()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To GridView2.SelectedRowsCount - 1
            com.CommandText = "delete from tblpayrollattendancefilter where employeeid='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "employeeid").ToString & "' and approverid='" & approverid.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredEmployee()
        ShowfilteredEmployee()
    End Sub
End Class

