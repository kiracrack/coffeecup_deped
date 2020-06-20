Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports System.IO

Public Class AdminModule
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub AdminModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadModuleInfo()

    End Sub
   
    Public Sub LoadModuleInfo()
        ClearModule()
        Dim InfoFile As String = ""
        If qrysingledata("systemmodule", "systemmodule", "tblcompanysettings where companycode='" & GlobalOrganizationCode & "'") <> "" Then
            InfoFile = DecryptTripleDES(qrysingledata("systemmodule", "systemmodule", "tblcompanysettings where companycode='" & GlobalOrganizationCode & "'"))
            If InfoFile.Length > 0 Then
                For Each strLine As String In InfoFile.Split(vbCrLf)
                    Dim word As String() = strLine.Split("=")
                    If word(0) = "procurement" Then
                        txtProcurement.Text = word(1)
                    End If
                    If word(0) = "inventory" Then
                        txtInventory.Text = word(1)
                    End If
                    If word(0) = "sales" Then
                        txtSales.Text = word(1)
                    End If
                    If word(0) = "fuel" Then
                        txtFuel.Text = word(1)
                    End If
                    If word(0) = "accounting" Then
                        txtInternalAccounting.Text = word(1)
                    End If
                    If word(0) = "hr" Then
                        txtHR.Text = word(1)
                    End If
                    If word(0) = "payroll" Then
                        txtPayroll.Text = word(1)
                    End If
                    If word(0) = "reportgen" Then
                        txtReportGenerator.Text = word(1)
                    End If
                    If word(0) = "pos" Then
                        txtNumberOfPOS.Text = word(1)
                    End If
                    If word(0) = "division" Then
                        txtNumberofDivision.Text = word(1)
                    End If
                    If word(0) = "hotel" Then
                        txtHotel.Text = word(1)
                    End If
                    If word(0) = "retainersmode" Then
                        ckEnableMonthly.CheckState = word(1)
                        If word(1).ToString = "1" Then
                            txtExpiryDate.EditValue = DecryptTripleDES(qrysingledata("expirydate", "expirydate", "tblcompanysettings  where companycode='" & GlobalOrganizationCode & "'"))
                        Else
                            txtExpiryDate.EditValue = CDate(Now)
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        com.CommandText = "update tblcompanysettings set systemmodule='" & GetSystemModule() & "' " & If(ckEnableMonthly.Checked = True, ",expirydate='" & EncryptTripleDES(ConvertDate(txtExpiryDate.EditValue)) & "'", ",expirydate=''") & " where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
        XtraMessageBox.Show("Module Successfully Configured! Please re-open the system", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
    Public Function GetSystemModule()
        Dim ValueFile As String = ""
        ValueFile += "procurement=" & txtProcurement.Text & Chr(13)
        ValueFile += "inventory=" & txtInventory.Text & Chr(13)
        ValueFile += "sales=" & txtSales.Text & Chr(13)
        ValueFile += "fuel=" & txtFuel.Text & Chr(13)
        ValueFile += "accounting=" & txtInternalAccounting.Text & Chr(13)
        ValueFile += "hr=" & txtHR.Text & Chr(13)
        ValueFile += "payroll=" & txtPayroll.Text & Chr(13)
        ValueFile += "hotel=" & txtHotel.Text & Chr(13)
        ValueFile += "reportgen=" & txtReportGenerator.Text & Chr(13)
        ValueFile += "pos=" & txtNumberOfPOS.Text & Chr(13)
        ValueFile += "division=" & txtNumberofDivision.Text & Chr(13)
        ValueFile += "retainersmode=" & ckEnableMonthly.CheckState & Chr(13)
        Return EncryptTripleDES(ValueFile)
    End Function


#Region "Activation Control"
    Private Sub txtProcurement_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProcurement.KeyDown
        If e.KeyCode = 112 Then
            If txtProcurement.Text = "DISABLED" Then
                txtProcurement.Text = "ACTIVATED"
            Else
                txtProcurement.Text = "DISABLED"
            End If
        End If
    End Sub
    Private Sub txtInventory_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInventory.KeyDown
        If e.KeyCode = 112 Then
            If txtInventory.Text = "DISABLED" Then
                txtInventory.Text = "ACTIVATED"
            Else
                txtInventory.Text = "DISABLED"
            End If
        End If
    End Sub
    Private Sub txtsales_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSales.KeyDown
        If e.KeyCode = 112 Then
            If txtSales.Text = "DISABLED" Then
                txtSales.Text = "ACTIVATED"
            Else
                txtSales.Text = "DISABLED"
            End If
        End If
    End Sub
    Private Sub txtfuel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFuel.KeyDown
        If e.KeyCode = 112 Then
            If txtFuel.Text = "DISABLED" Then
                txtFuel.Text = "ACTIVATED"
            Else
                txtFuel.Text = "DISABLED"
            End If
        End If
    End Sub
    Private Sub txtInternalAccounting_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInternalAccounting.KeyDown
        If e.KeyCode = 112 Then
            If txtInternalAccounting.Text = "DISABLED" Then
                txtInternalAccounting.Text = "ACTIVATED"
            Else
                txtInternalAccounting.Text = "DISABLED"
            End If
        End If
    End Sub
    Private Sub txtHotel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHotel.KeyDown
        If e.KeyCode = 112 Then
            If txtHotel.Text = "DISABLED" Then
                txtHotel.Text = "ACTIVATED"
            Else
                txtHotel.Text = "DISABLED"
            End If
        End If
    End Sub
    Private Sub txtHR_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHR.KeyDown
        If e.KeyCode = 112 Then
            If txtHR.Text = "DISABLED" Then
                txtHR.Text = "ACTIVATED"
            Else
                txtHR.Text = "DISABLED"
            End If
        End If
    End Sub
    Private Sub txtPayroll_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPayroll.KeyDown
        If e.KeyCode = 112 Then
            If txtPayroll.Text = "DISABLED" Then
                txtPayroll.Text = "ACTIVATED"
            Else
                txtPayroll.Text = "DISABLED"
            End If
        End If
    End Sub


    Private Sub txtReportGenerator_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReportGenerator.KeyDown
        If e.KeyCode = 112 Then
            If txtReportGenerator.Text = "DISABLED" Then
                txtReportGenerator.Text = "ACTIVATED"
            Else
                txtReportGenerator.Text = "DISABLED"
            End If
        End If
    End Sub
#End Region

#Region "Status Control"
    Private Sub txtProcurement_TextChanged(sender As Object, e As EventArgs) Handles txtProcurement.TextChanged
        If txtProcurement.Text = "ACTIVATED" Then
            txtProcurement.BackColor = Color.Lime
            txtProcurement.ForeColor = Color.Black
        Else
            txtProcurement.BackColor = DefaultBackColor
            txtProcurement.ForeColor = DefaultForeColor
        End If
    End Sub
    Private Sub txtInventory_TextChanged(sender As Object, e As EventArgs) Handles txtInventory.TextChanged
        If txtInventory.Text = "ACTIVATED" Then
            txtInventory.BackColor = Color.Lime
            txtInventory.ForeColor = Color.Black
        Else
            txtInventory.BackColor = DefaultBackColor
            txtInventory.ForeColor = DefaultForeColor
        End If

    End Sub
    Private Sub txtsales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        If txtSales.Text = "ACTIVATED" Then
            txtSales.BackColor = Color.Lime
            txtSales.ForeColor = Color.Black
        Else
            txtSales.BackColor = DefaultBackColor
            txtSales.ForeColor = DefaultForeColor
        End If
    End Sub
    Private Sub txtfuel_TextChanged(sender As Object, e As EventArgs) Handles txtFuel.TextChanged
        If txtFuel.Text = "ACTIVATED" Then
            txtFuel.BackColor = Color.Lime
            txtFuel.ForeColor = Color.Black
        Else
            txtFuel.BackColor = DefaultBackColor
            txtFuel.ForeColor = DefaultForeColor
        End If
    End Sub
    Private Sub txtInternalAccounting_TextChanged(sender As Object, e As EventArgs) Handles txtInternalAccounting.TextChanged
        If txtInternalAccounting.Text = "ACTIVATED" Then
            txtInternalAccounting.BackColor = Color.Lime
            txtInternalAccounting.ForeColor = Color.Black
        Else
            txtInternalAccounting.BackColor = DefaultBackColor
            txtInternalAccounting.ForeColor = DefaultForeColor
        End If
    End Sub

    Private Sub txtHR_TextChanged(sender As Object, e As EventArgs) Handles txtHR.TextChanged
        If txtHR.Text = "ACTIVATED" Then
            txtHR.BackColor = Color.Lime
            txtHR.ForeColor = Color.Black
        Else
            txtHR.BackColor = DefaultBackColor
            txtHR.ForeColor = DefaultForeColor
        End If
    End Sub
    Private Sub txtPayroll_TextChanged(sender As Object, e As EventArgs) Handles txtPayroll.TextChanged
        If txtPayroll.Text = "ACTIVATED" Then
            txtPayroll.BackColor = Color.Lime
            txtPayroll.ForeColor = Color.Black
        Else
            txtPayroll.BackColor = DefaultBackColor
            txtPayroll.ForeColor = DefaultForeColor
        End If
    End Sub
    Private Sub txtReportGenerator_TextChanged(sender As Object, e As EventArgs) Handles txtReportGenerator.TextChanged
        If txtReportGenerator.Text = "ACTIVATED" Then
            txtReportGenerator.BackColor = Color.Lime
            txtReportGenerator.ForeColor = Color.Black
        Else
            txtReportGenerator.BackColor = DefaultBackColor
            txtReportGenerator.ForeColor = DefaultForeColor
        End If
    End Sub
    Private Sub txtHotel_TextChanged(sender As Object, e As EventArgs) Handles txtHotel.TextChanged
        If txtHotel.Text = "ACTIVATED" Then
            txtHotel.BackColor = Color.Lime
            txtHotel.ForeColor = Color.Black
        Else
            txtHotel.BackColor = DefaultBackColor
            txtHotel.ForeColor = DefaultForeColor
        End If
    End Sub
#End Region

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmCompanySettings.mode.Text = "new"
        frmCompanySettings.txtModule.Text = GetSystemModule()
        frmCompanySettings.Show(Me)
    End Sub


    Public Sub ClearModule()
        txtProcurement.Text = "DISABLED"
        txtInventory.Text = "DISABLED"
        txtSales.Text = "DISABLED"
        txtFuel.Text = "DISABLED"
        txtInternalAccounting.Text = "DISABLED"
        txtHR.Text = "DISABLED"
        txtPayroll.Text = "DISABLED"
        txtReportGenerator.Text = "DISABLED"
        txtHotel.Text = "DISABLED"
    End Sub
   
     
    Private Sub ckEnableMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableMonthly.CheckedChanged
        If ckEnableMonthly.Checked = True Then
            txtExpiryDate.Enabled = True
        Else
            txtExpiryDate.Enabled = False
        End If
    End Sub
End Class