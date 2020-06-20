Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmCoffeecupServerPermissionInfo
    Private cost
    Private total
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmStockoutQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        com.CommandText = "select * from tblpermissions where percode='" & percode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtPermission.Text = rst("permission").ToString
            ck_allowAdd.Checked = rst("allowadd")
            ck_allowEdit.Checked = rst("allowedit")
            ck_allowDelete.Checked = rst("allowdelete")
            ck_special.Checked = rst("approver")
        End While
        rst.Close()

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtPermission.Text = "" Then
            XtraMessageBox.Show("Please enter permission!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPermission.Focus()
            Exit Sub
        End If

        If percode.Text = "" Then
            com.CommandText = "insert into tblpermissions set permission='" & txtPermission.Text & "',approver=" & ck_special.CheckState & ", allowadd=" & ck_allowAdd.CheckState & ", allowedit=" & ck_allowEdit.CheckState & ", allowdelete=" & ck_allowDelete.CheckState & "" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblpermissions set permission='" & txtPermission.Text & "',approver=" & ck_special.CheckState & ", allowadd=" & ck_allowAdd.CheckState & ", allowedit=" & ck_allowEdit.CheckState & ", allowdelete=" & ck_allowDelete.CheckState & "  where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
        End If


        loadglobaluser()
        frmCoffeecupServerPermission.LoadPermission()
        XtraMessageBox.Show("Permission Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class