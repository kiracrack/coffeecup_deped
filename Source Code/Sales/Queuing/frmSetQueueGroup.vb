Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetQueueGroup
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmSetQueueGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadQueueGroup()
        LoadGridviewAppearance(combogrid)
    End Sub

    Public Sub LoadQueueGroup()
        LoadXgridLookupEdit("select groupcode, description 'Select' from tblsalesqueuinggroup order by groupcode asc", "tblsalesqueuinggroup", txtDescription, combogrid, Me)
        combogrid.Columns("groupcode").Visible = False
    End Sub

    Private Sub txtDescription_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.EditValueChanged
        On Error Resume Next
        groupcode.Text = txtDescription.Properties.View.GetFocusedRowCellValue("groupcode").ToString()
        txtDescription.Text = txtDescription.Properties.View.GetFocusedRowCellValue("Select").ToString()
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        If txtDescription.Text = "" Then
            XtraMessageBox.Show("Please select Group!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        End If
        frmQueueingSettings.SetGroup(groupcode.Text, txtDescription.Text)
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub


End Class
