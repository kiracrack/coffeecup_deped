Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmHotelGuestInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        txtBirthdate.EditValue = CDate(Now)
        LoadGridviewAppearance(Gridview1)
        LoadCountry()
        LoadToComboBox("nationality", "tblhotelguest", txtNationality, True)
        If mode.Text = "edit" Then
            showGuestInfo()
        End If

    End Sub

    Public Sub showGuestInfo()
        com.CommandText = "select *, date_format(birthdate,'%Y-%m-%d') as bdate, (select picture from filedir.tblhotelguestimage where guestid=tblhotelguest.guestid) as pic,(select countryname from tblcountries where countrycode=tblhotelguest.countrycode) as country,(select description from tblhotelviptype where vipcode=tblhotelguest.viptype) as 'vip' from tblhotelguest where guestid='" & guestid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtGuest.Text = rst("fullname").ToString
            countrycode.Text = rst("countrycode").ToString
            txtCountry.Text = rst("country").ToString
            txtAddress.Text = rst("address").ToString
            txtBirthdate.EditValue = rst("bdate").ToString
            txtGender.Text = rst("gender").ToString
            txtNationality.Text = rst("nationality").ToString
            txtContactNumber.Text = rst("contactnumber").ToString
            txtEmail.Text = rst("emailadd").ToString
            If rst("pic").ToString <> "" Then
                ShowImage("pic", ProfilePic, Me)
            End If
        End While
        rst.Close()
    End Sub


    Public Sub LoadCountry()
        LoadXgridLookupEdit("select countrycode, countryname as 'Country' from tblcountries order by countryname asc", "tblcountries", txtCountry, Gridview1, Me)
        Gridview1.Columns("countrycode").Visible = False
    End Sub
    Private Sub txtProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCountry.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCountry.Properties.View.FocusedRowHandle.ToString)
        countrycode.Text = txtCountry.Properties.View.GetFocusedRowCellValue("countrycode").ToString()
        txtCountry.Text = txtCountry.Properties.View.GetFocusedRowCellValue("Country").ToString()
    End Sub
    
    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtGuest.Text = "" Then
                MessageBox.Show("Please enter guest Fullname", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtGuest.Focus()
                Exit Sub
            ElseIf txtAddress.Text = "" Then
                MessageBox.Show("Please enter guest address", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtAddress.Focus()
                Exit Sub
            ElseIf txtGender.Text = "" Then
                MessageBox.Show("Please enter guest gender", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtAddress.Focus()
                Exit Sub
            ElseIf txtContactNumber.Text = "" Then
                MessageBox.Show("Please enter guest contact number", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtContactNumber.Focus()
                Exit Sub
           
            End If
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblhotelguest set fullname='" & rchar(UCase(txtGuest.Text)) & "', address='" & rchar(UCase(txtAddress.Text)) & "', birthdate='" & ConvertDate(txtBirthdate.Text) & "', gender='" & UCase(txtGender.Text) & "', nationality='" & UCase(rchar(txtNationality.Text)) & "', contactnumber='" & rchar(txtContactNumber.Text) & "', emailadd='" & rchar(txtEmail.Text) & "' where guestid='" & guestid.Text & "'" : com.ExecuteNonQuery()
                If countqry("filedir.tblhotelguestimage", "guestid='" & guestid.Text & "'") = 0 Then
                    InsertImage("picture", ",guestid='" & guestid.Text & "'", "filedir.tblhotelguestimage", ProfilePic, Me)
                Else
                    UpdateImage("guestid='" & guestid.Text & "'", "picture", "filedir.tblhotelguestimage", ProfilePic, Me)
                End If
            Else
                Dim newGuestid As String = CreateGuestID()
                com.CommandText = "insert into tblhotelguest set guestid='" & newGuestid & "', fullname='" & rchar(UCase(txtGuest.Text)) & "', address='" & rchar(UCase(txtAddress.Text)) & "', birthdate='" & ConvertDate(txtBirthdate.Text) & "', gender='" & UCase(txtGender.Text) & "', nationality='" & UCase(rchar(txtNationality.Text)) & "', contactnumber='" & rchar(txtContactNumber.Text) & "', emailadd='" & rchar(txtEmail.Text) & "', datetrn=current_timestamp, trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                InsertImage("picture", ",guestid='" & guestid.Text & "'", "filedir.tblhotelguestimage", ProfilePic, Me)
            End If
            frmHotelGuestManagement.filter()
            XtraMessageBox.Show("Guest info successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
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