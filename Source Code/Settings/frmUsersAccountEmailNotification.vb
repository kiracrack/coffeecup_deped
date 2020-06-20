Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmUsersAccountEmailNotification
    Private cost
    Private total
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmUserAccountEmailNotification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        com.CommandText = "select * from tblaccounts where accountid='" & accountid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            ck_sales.Checked = rst("notifysales")
            ck_checkdue.Checked = rst("notifycheckdue")
            ck_attendance.Checked = rst("notifyattendancelog")
            ck_postockreceived.Checked = rst("notifyreceivedpostock")
            ck_AutoServices.Checked = rst("notifyautoservices")
            ck_banksLedger.Checked = rst("notifybanksledger")
            ck_monthlysummary.Checked = rst("notifymonthlysummary")
        End While
        rst.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        com.CommandText = "update tblaccounts set notifysales=" & ck_sales.CheckState & ", notifycheckdue=" & ck_checkdue.CheckState & ", notifyattendancelog=" & ck_attendance.CheckState & ", notifyreceivedpostock=" & ck_postockreceived.CheckState & ",notifyautoservices='" & ck_AutoServices.CheckState & "',notifybanksledger=" & ck_banksLedger.CheckState & ",notifymonthlysummary=" & ck_monthlysummary.CheckState & " where accountid='" & accountid.Text & "'" : com.ExecuteNonQuery()
        XtraMessageBox.Show("Notification Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class