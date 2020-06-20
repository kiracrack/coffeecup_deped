Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmDepEdUpdateRequestStatus
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmDepEdUpdateRequestStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        loadCompOffice()
    End Sub
    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Office' from tblcompoffice order by officename", "tblcompoffice", txtoffice, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False
        Me.txtoffice.Properties.DisplayMember = "Office"
        Me.txtoffice.Properties.ValueMember = "Office"
    End Sub

    Private Sub txtcompoffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
       
    End Sub
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If CheckEdit1.Checked = False And txtoffice.Text = "" Then
            XtraMessageBox.Show("Please select current office", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If CheckEdit1.Checked = True Then
                com.CommandText = "UPDATE tblrequisitions set approvedcorporate=1,dateapproved=current_timestamp where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                RecordApprovingHistory("requisition", pid.Text, pid.Text, "approved", "Request Approved " & txtremarks.Text)
            Else
                RecordApprovingHistory("requisition", pid.Text, pid.Text, "processed", txtoffice.Text & " " & txtremarks.Text)
            End If
            pid.Text = ""
            frmRequisitionsManagement.FilterOption()
            XtraMessageBox.Show("Request status successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
 

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtoffice.Enabled = False
        Else
            txtoffice.Enabled = True
        End If
    End Sub
End Class