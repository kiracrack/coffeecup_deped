Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmHotelRoomInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        If mode.Text = "" Then
            rid.Text = getRoomid()
        End If
        LoadHotel()
        LoadRoomType()

    End Sub
    Public Sub LoadHotel()
        LoadXgridLookupEdit("select cifid, companyname as 'Select Hotel' from tblclientaccounts where hotelclient=1", "tblclientaccounts", txtHotel, Gridview1, Me)
        Gridview1.Columns("cifid").Visible = False
    End Sub
    Private Sub txtHotel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHotel.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtHotel.Properties.View.FocusedRowHandle.ToString)
        hotelcif.Text = txtHotel.Properties.View.GetFocusedRowCellValue("cifid").ToString()
        LoadRoomType()
    End Sub

    Public Sub LoadRoomType()
        If hotelcif.Text = "" Then Exit Sub
        LoadXgridLookupEdit("select code, Description from tblhotelroomtype where hotelcif='" & hotelcif.Text & "'", "tblhotelroomtype", txtRoomType, gridRoomType, Me)
        gridRoomType.Columns("code").Visible = False
    End Sub

    Private Sub txtRoomType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomType.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtRoomType.Properties.View.FocusedRowHandle.ToString)
        typecode.Text = txtRoomType.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

  
    Public Sub clearfields()
        rid.Text = getRoomid()
        txtRoomNumber.Text = ""
        'txtDescription.Text = ""
        txtRoomNumber.Focus()
    End Sub
    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtRoomNumber.Text = "" Then
                XtraMessageBox.Show("Please enter Room Number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRoomNumber.Focus()
                Exit Sub
            ElseIf txtRoomType.Text = "" Then
                XtraMessageBox.Show("Please select room type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRoomType.Focus()
                Exit Sub
            ElseIf countqry("tblhotelrooms", "roomnumber='" & txtRoomNumber.Text & "' and roomid<>'" & rid.Text & "' and hotelcifid='" & hotelcif.Text & "'") > 0 Then
                XtraMessageBox.Show("Room Number already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRoomNumber.Focus()
                Exit Sub
            ElseIf txtDescription.Text = "" Then
                XtraMessageBox.Show("Please enter room description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDescription.Focus()
                Exit Sub
           
            End If
            If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If mode.Text <> "edit" Then
                    com.CommandText = "insert into tblhotelrooms set roomid='" & rid.Text & "', hotelcifid='" & hotelcif.Text & "', roomtype='" & typecode.Text & "',cluster='" & txtCluster.Text & "', roomnumber='" & txtRoomNumber.Text & "', description='" & rchar(txtDescription.Text) & "',roomstatus='" & UCase(txtStatus.Text) & "', remarks='" & rchar(txtRemarks.Text) & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "UPDATE tblhotelrooms set hotelcifid='" & hotelcif.Text & "', roomtype='" & typecode.Text & "',cluster='" & txtCluster.Text & "', roomnumber='" & txtRoomNumber.Text & "', description='" & rchar(txtDescription.Text) & "',roomstatus='" & UCase(txtStatus.Text) & "', remarks='" & rchar(txtRemarks.Text) & "' where roomid='" & rid.Text & "'" : com.ExecuteNonQuery()
                End If
                XtraMessageBox.Show("Room Successfully Saved", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            clearfields()
            frmHotelRoomManagement.filter()
            If mode.Text = "edit" Then
                Me.Close()
            End If
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

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        Try
            com.CommandText = "select *,(select companyname from tblclientaccounts where cifid =tblhotelrooms.hotelcifid) as 'hotel', (select description from tblhotelroomtype where code=tblhotelrooms.roomtype) as 'rtype' from tblhotelrooms where roomid='" & rid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                txtRoomNumber.Text = rst("roomnumber").ToString
                txtDescription.Text = rst("description").ToString
                txtHotel.Text = rst("hotel").ToString
                hotelcif.Text = rst("hotelcifid").ToString
                txtRoomType.Text = rst("rtype").ToString
                typecode.Text = rst("roomtype").ToString
                txtStatus.Text = rst("roomstatus").ToString
                txtRemarks.Text = rst("remarks").ToString
                txtCluster.Text = rst("cluster").ToString
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