Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPayrollEmplyeePosition
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Control + Keys.W Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub frmShiftSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadData()
        LoadGridviewAppearance(Gridview1)
    End Sub
    Public Sub LoadData()
        LoadXgrid("select Code, Description,(select description from tblpayrollschedule where code=tblpayrollbasicrate.schedulecode)  as 'Payout Schedule', " _
                  + " totalhours as 'Total Hours', " _
                  + " ratepermonth as 'Monthly Rate', " _
                  + " rateperday as 'Daily Rate', " _
                  + " rateperhour as 'Rate per Hour', " _
                  + " rateperminute as 'Rate per Minute', " _
                  + " taxexcempt as 'Tax Excempt', " _
                  + " sss as 'GSIS/SSS', Philhealth, Pagibig, Savings, " _
                  + " enablelate as 'Enable Late', " _
                  + " laterate as 'Late Rate', " _
                  + " latetype as 'Late Type', " _
                  + " enableundertime as 'Enable Undertime', " _
                  + " undertimerate as 'Undertime Rate', " _
                  + " undertimetype as 'Undertime Type', " _
                  + " enableovertime as 'Enable Overtime', " _
                  + " overtimerate as 'Overtime Rate', " _
                  + " overtimetype as 'Overtime Type', " _
                  + " enablensd as 'Enable NSD', " _
                  + " nsdrate as 'NSD Rate', " _
                  + " nsdtype as 'NSD Type', " _
                  + " nsdtimefrom as 'NSD Time From', " _
                  + " nsdtimeto as 'NSD Time To', " _
                  + " enablesaturday as 'Enable Saturday', " _
                  + " saturdayrate as 'Saturday Rate', " _
                  + " enablesunday as 'Enable Sunday', " _
                  + " sundayrate as 'Sunday Rate', " _
                  + " doublepayholiday as 'Double Pay Holliday' from tblpayrollbasicrate order by code asc", "tblpayrollbasicrate", Em, Gridview1, Me)
        XgridColAlign({"Code", "Total Hours", "Late Type", "Undertime Type", "Overtime Type", "NSD Type", "NSD Time From", "NSD Time To"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Monthly Rate", "Daily Rate", "Rate per Hour", "Rate per Minute", "Late Rate", "Undertime Rate", "Overtime Rate", "NSD Rate", "Saturday Rate", "Sunday Rate"}, Gridview1)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        frmPayrollEmplyeePositionInfo.Show(Me)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmPayrollEmplyeePositionInfo.mode.Text = "edit"
        frmPayrollEmplyeePositionInfo.code.Text = Gridview1.GetFocusedRowCellValue("Code").ToString
        If frmPayrollEmplyeePositionInfo.Visible = True Then
            frmPayrollEmplyeePositionInfo.Focus()
        Else
            frmPayrollEmplyeePositionInfo.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE FROM tblpayrollbasicrate where code='" & Gridview1.GetFocusedRowCellValue("Code").ToString & "'" : com.ExecuteNonQuery()
            LoadData()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadData()
    End Sub
End Class