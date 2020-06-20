Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmHotelSetVipGuest
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGridviewAppearance(Gridview1)
        LoadCardType()
        showGuestInfo()
    End Sub

    Public Sub showGuestInfo()
        com.CommandText = "select *,(select picture from filedir.tblhotelguestimage where guestid=tblhotelguest.guestid) as pic,(select countryname from tblcountries where countrycode=tblhotelguest.countrycode) as country,(select description from tblhotelviptype where vipcode=tblhotelguest.viptype) as 'vip' from tblhotelguest where guestid='" & guestid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtGuest.Text = rst("fullname").ToString
            ckVipGuest.Checked = rst("vipguest")
            vipcode.Text = rst("viptype").ToString
            txtviptype.Text = rst("vip").ToString
            txtCardNumber.Text = rst("vipcardno").ToString
            txtcreditlimit.Text = FormatNumber(rst("vipcreditlimit").ToString, 2)
        End While
        rst.Close()
    End Sub
    Public Sub LoadCardType()
        LoadXgridLookupEdit("select vipcode, Description, CreditLimit from tblhotelviptype", "tblhotelviptype", txtviptype, Gridview1, Me)
        Gridview1.Columns("vipcode").Visible = False
        XgridColCurrency({"CreditLimit"}, Gridview1)
    End Sub
    Private Sub txtProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtviptype.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtviptype.Properties.View.FocusedRowHandle.ToString)
        vipcode.Text = txtviptype.Properties.View.GetFocusedRowCellValue("vipcode").ToString()
        txtcreditlimit.Text = txtviptype.Properties.View.GetFocusedRowCellValue("CreditLimit").ToString()
    End Sub
    
    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtviptype.Text = "" Then
                MessageBox.Show("Please select vip card type", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtviptype.Focus()
                Exit Sub
            ElseIf txtCardNumber.Text = "" Then
                MessageBox.Show("Please enter vip card number", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtviptype.Focus()
                Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "UPDATE tblhotelguest set vipguest=" & ckVipGuest.CheckState & ", viptype='" & vipcode.Text & "', vipcardno='" & txtCardNumber.Text & "', vipcreditlimit='" & Val(CC(txtcreditlimit.Text)) & "' where guestid='" & guestid.Text & "'" : com.ExecuteNonQuery()
                XtraMessageBox.Show("Vip Successfully Saved", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmHotelGuestManagement.filter()
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

   
    Private Sub ckVipGuest_CheckedChanged(sender As Object, e As EventArgs) Handles ckVipGuest.CheckedChanged
        If ckVipGuest.Checked = True Then
            txtviptype.Enabled = True
            txtcreditlimit.Enabled = True
            txtCardNumber.Enabled = True
        Else
            txtviptype.Enabled = False
            txtcreditlimit.Enabled = False
            txtCardNumber.Enabled = False
        End If
    End Sub
End Class