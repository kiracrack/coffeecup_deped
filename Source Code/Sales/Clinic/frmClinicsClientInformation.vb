Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmClinicsClientInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        txtBirthdate.EditValue = CDate(Now)
        If mode.Text = "edit" Then
            showclientInfo()
        End If
    End Sub

    Public Sub showclientInfo()
        com.CommandText = "select *, date_format(birthdate,'%Y-%m-%d') as bdate from tblclinicsclients where clientid='" & clientid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtclient.Text = rst("fullname").ToString
            txtAddress.Text = rst("address").ToString
            txtBirthdate.EditValue = rst("bdate").ToString
            txtGender.Text = rst("gender").ToString
            txtContactNumber.Text = rst("contactnumber").ToString
            txtEmail.Text = rst("emailadd").ToString
        End While
        rst.Close()
    End Sub


    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtclient.Text = "" Then
                MessageBox.Show("Please enter client Fullname", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtclient.Focus()
                Exit Sub
            ElseIf txtAddress.Text = "" Then
                MessageBox.Show("Please enter client address", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtAddress.Focus()
                Exit Sub
            ElseIf txtGender.Text = "" Then
                MessageBox.Show("Please enter client gender", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtAddress.Focus()
                Exit Sub
            ElseIf txtContactNumber.Text = "" Then
                MessageBox.Show("Please enter client contact number", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtContactNumber.Focus()
                Exit Sub

            End If
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblclinicsclients set fullname='" & rchar(UCase(txtclient.Text)) & "', address='" & rchar(UCase(txtAddress.Text)) & "', birthdate='" & ConvertDate(txtBirthdate.Text) & "', gender='" & UCase(txtGender.Text) & "', contactnumber='" & rchar(txtContactNumber.Text) & "', emailadd='" & rchar(txtEmail.Text) & "' where clientid='" & clientid.Text & "'" : com.ExecuteNonQuery()
            Else
                Dim newclientid As String = CreateClinicsclientID()
                com.CommandText = "insert into tblclinicsclients set clientid='" & newclientid & "', fullname='" & rchar(UCase(txtclient.Text)) & "', address='" & rchar(UCase(txtAddress.Text)) & "', birthdate='" & ConvertDate(txtBirthdate.Text) & "', gender='" & UCase(txtGender.Text) & "', contactnumber='" & rchar(txtContactNumber.Text) & "', emailadd='" & rchar(txtEmail.Text) & "', datetrn=current_timestamp, trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If

            frmClinicsClientManagement.filter()
            XtraMessageBox.Show("Client info successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
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


End Class