Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmHotelUpdateRoomStatus
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
    End Sub

    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtRoomNumber.Text = "" Then
                XtraMessageBox.Show("Please enter Room Number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRoomNumber.Focus()
                Exit Sub
            ElseIf countqry("tblhotelrooms", "roomnumber='" & txtRoomNumber.Text & "' and roomid<>'" & rid.Text & "'") > 0 Then
                XtraMessageBox.Show("Room Number already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRoomNumber.Focus()
                Exit Sub
            ElseIf txtDescription.Text = "" Then
                XtraMessageBox.Show("Please enter room description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDescription.Focus()
                Exit Sub

            End If
            If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                com.CommandText = "UPDATE tblhotelrooms set occupied=" & ckOccupied.CheckState & ",maintainance=" & ckMaintainance.CheckState & ",remarks='" & rchar(txtMaintainanceRemarks.Text) & "' where roomid='" & rid.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblhotelhousekeepingreports set hotel='" & hotelcif.Text & "', roomid='" & rid.Text & "',roomno='" & txtRoomNumber.Text & "',description='" & rchar(txtDescription.Text) & "', maintainancemode=1, roomstatus='MAINTAINANCE', remarks='" & rchar(txtMaintainanceRemarks.Text) & "', housekeeper='" & globaluserid & "', dateupdate=current_timestamp,postedby='" & globalfullname & "'" : com.ExecuteNonQuery()

                XtraMessageBox.Show("Room Successfully Saved", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            frmHotelRoomManagement.filter()
            Me.Close()
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub rid_EditValueChanged(sender As Object, e As EventArgs) Handles rid.EditValueChanged
        Try
            com.CommandText = "select *,(select companyname from tblclientaccounts where cifid =tblhotelrooms.hotelcifid) as 'hotel' from tblhotelrooms where roomid='" & rid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                txtRoomNumber.Text = rst("roomnumber").ToString
                txtDescription.Text = rst("description").ToString
                hotelcif.Text = rst("hotelcifid").ToString
                ckOccupied.Checked = rst("occupied")
                ckMaintainance.Checked = rst("maintainance")
            End While
            rst.Close()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class