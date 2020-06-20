Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmChangeUser

    Private Sub frmChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        loadRequester()
        SetIcon(Me)
    End Sub

    Public Sub loadRequester()
        LoadXgridLookupSearch("select accountid as ID,fullname as FULLNAME, (select officename from tblcompoffice where officeid =  tblaccounts.officeid ) as '" & GlobalOfficeCaption & "' from tblaccounts", "tblaccounts", txtrequestby, s_grid, Me)
        s_grid.Columns("ID").Visible = False
    End Sub

    Private Sub txtrequestby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrequestby.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtrequestby.Properties.View.FocusedRowHandle.ToString)
        uid.Text = txtrequestby.Properties.View.GetFocusedRowCellValue("ID").ToString()
        txtrequestby.Text = txtrequestby.Properties.View.GetFocusedRowCellValue("FULLNAME").ToString()
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If XtraMessageBox.Show("Activate user " & txtrequestby.Text & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            globaluserid = uid.Text
            loadglobaluser()
            loadcompsettings()
            MdiCoffeeCup.Text = compname + " (Login as " & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ")"
            Me.Close()
        End If
    End Sub
End Class