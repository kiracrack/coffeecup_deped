Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetClientFilter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmSetClientFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadClientFilter()
    End Sub
    Public Sub LoadClientFilter()
        LoadToComboBox("description", "tblclientfiltersettings", txtClientGroup, True)
    End Sub

    Private Sub txtClientGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtClientGroup.SelectedValueChanged
        groupcode.Text = qrysingledata("code", "code", "where description='" & txtClientGroup.Text & "'", "tblclientfiltersettings")
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        If txtClientGroup.Text = "" And ckCrditLimit.Checked = False Then
            XtraMessageBox.Show("Please select client filter", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClientGroup.Focus()
            Exit Sub
        End If
        frmClientManagement.SetClientFilter(groupcode.Text)
    End Sub

    Private Sub ckCrditLimit_CheckedChanged(sender As Object, e As EventArgs) Handles ckCrditLimit.CheckedChanged
        If ckCrditLimit.Checked = True Then
            txtClientGroup.Enabled = False
            groupcode.Text = ""
            txtClientGroup.SelectedIndex = -1
        Else
            txtClientGroup.Enabled = True
        End If
    End Sub
End Class