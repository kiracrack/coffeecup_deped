Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmHoldOnlineRequisition
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCancelRequest_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        txtrequestby.Text = ""
        txtdetails.Text = ""
        pid.Text = ""
    End Sub

    Private Sub frmCancelRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMove.Click
        If txtdetails.Text = "" Then
            XtraMessageBox.Show("Please enter reason/remarks!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdetails.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblrequisitions set approvedbranch=0, hold=1 where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblapprovalhistory set applevel='-',finalapprover=0 where referenceno='" & pid.Text & "' and finalapprover=1 and corporateapproval=0" : com.ExecuteNonQuery()
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                 + " SELECT potypeid,'requisition', pid,pid,'Hold','" & rchar(txtdetails.Text) & "', 'Procurement','-','" & globaluserid & "','" & globalfullname & "','" & globaldesignation & "',current_timestamp,0 FROM tblrequisitions where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            InsertEmailNotification("requisition", getEmailAccount(reqid.Text), "HOLD REQUEST (" & pid.Text & ") ", FormatingEmailRequisition(pid.Text, UCase(txtpotype.Text)) & "<br/><br/>" & txtdetails.Text, "")
            frmOnlineRequisitionList.FilterOption()
            XtraMessageBox.Show("Request Successfuly put on hold!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class