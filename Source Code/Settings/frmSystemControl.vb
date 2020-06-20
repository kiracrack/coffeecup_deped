Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSystemControl

    Private Sub frmChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(s_grid)
        loadLoginAccount()

    End Sub

    Public Sub loadLoginAccount()
        LoadXgridLookupSearch("select distinct(accountid) as ID,fullname as 'Account Name', Designation  from tblaccounts inner join tbllogin on tblaccounts.accountid = tbllogin.userid where userid<>'" & globaluserid & "' and outtime is null ", "tblaccounts", txtrequestby, s_grid, Me)
        s_grid.Columns("ID").Visible = False
    End Sub

    Private Sub txtrequestby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrequestby.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtrequestby.Properties.View.FocusedRowHandle.ToString)
        uid.Text = txtrequestby.Properties.View.GetFocusedRowCellValue("ID").ToString()
        txtrequestby.Text = txtrequestby.Properties.View.GetFocusedRowCellValue("Account Name").ToString()
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If txtrequestby.Text = "" And ck_all.Checked = False Then
            XtraMessageBox.Show("Please select user!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtrequestby.Focus()
            Exit Sub
        ElseIf txtMessage.Text = "" And ckpooption.SelectedIndex <> 2 Then
            XtraMessageBox.Show("Please enter message!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMessage.Focus()
            Exit Sub
        ElseIf txtCountdown.Text = "" And ckpooption.SelectedIndex <> 2 Then
            XtraMessageBox.Show("Please enter countdown timer!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCountdown.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to confirm your action?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If ck_all.Checked = True Then
                If ckpooption.SelectedIndex = 2 Then
                    For Each word In uid.Text.Split(New Char() {","c})
                        If globaluserid <> word Then
                            com.CommandText = "update tbllogin set outtime=current_timestamp  where userid='" & word & "' and outtime is null" : com.ExecuteNonQuery()
                        End If
                    Next
                Else
                    com.CommandText = "insert tblsystemcontrol set userid='ALL', controltype='" & ckpooption.SelectedIndex & "', message='" & rchar(txtMessage.Text) & "', countdown='" & txtCountdown.Text & "', actionby='" & globaluserid & "',datesent=current_timestamp" : com.ExecuteNonQuery()
                End If
            Else
                If ckpooption.SelectedIndex = 2 Then
                    com.CommandText = "update tbllogin set outtime=current_timestamp  where userid='" & uid.Text & "' and outtime is null" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "insert tblsystemcontrol set userid='" & uid.Text & "', controltype='" & ckpooption.SelectedIndex & "', message='" & rchar(txtMessage.Text) & "', countdown='" & txtCountdown.Text & "', actionby='" & globaluserid & "',datesent=current_timestamp" : com.ExecuteNonQuery()
                End If
            End If
            XtraMessageBox.Show("Your action successfully sent!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub ck_all_CheckedChanged(sender As Object, e As EventArgs) Handles ck_all.CheckedChanged
        If ck_all.Checked = True Then
            txtrequestby.Properties.ReadOnly = True
            txtrequestby.Properties.DataSource = Nothing
            txtrequestby.Text = ""
            uid.Text = qrysingledata("uid", "group_concat(distinct(userid)) as uid", "where outtime is null", "tblaccounts inner join tbllogin on tblaccounts.accountid = tbllogin.userid ")
        Else
            txtrequestby.Properties.ReadOnly = False
            loadLoginAccount()
            uid.Text = ""
        End If
    End Sub
End Class