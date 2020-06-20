Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetClientGroup
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmGLPump_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadClientGroup()
    End Sub
    Public Sub LoadClientGroup()
        LoadToComboBox("groupname", "tblclientgroup", txtClientGroup, True)
    End Sub
 
    Private Sub txtClientGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtClientGroup.SelectedValueChanged
        groupcode.Text = qrysingledata("groupcode", "groupcode", "where groupname='" & txtClientGroup.Text & "'", "tblclientgroup")
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        If txtClientGroup.Text = "" Then
            XtraMessageBox.Show("Please select client group", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClientGroup.Focus()
            Exit Sub
        End If
        frmClientManagement.SetClientGroup(groupcode.Text)
    End Sub
End Class