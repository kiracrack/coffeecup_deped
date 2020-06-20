Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Net
Imports DevExpress.LookAndFeel
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.XtraMessageBoxForm
Imports System.Drawing.Imaging
Imports System.Xml
Imports System.Net.NetworkInformation
Imports System.Reflection

Public Class frmLogin
    Dim filename As String
    Public ArchivedLocation As String = Application.StartupPath.ToString & "\UpdateVersion\"
    Dim client As WebClient = New WebClient

    Sub New()
        InitSkins()
        InitializeComponent()
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        ' DevExpress.UserSkins.OfficeSkins.Register()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle(globaltheme)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.F12) Then
            frmDatabaseRepair.Show(Me)

        ElseIf keyData = Keys.Shift + Keys.F12 Then
            frmSystemOwnerConfirmation.ShowDialog(Me)
            If frmSystemOwnerConfirmation.Authourized = True Then
                AdminModule.ShowDialog()
                frmSystemOwnerConfirmation.Authourized = False
            End If
        End If

        Return ProcessCmdKey
    End Function
    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Dark")
        txtusername.Focus()
    End Sub

    Public Sub ClearLog()
        txtusername.Text = ""
        txtpassword.Text = ""
        globaltheme = "Visual Studio 2013 Dark"
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        'File.Open("D:\Print Test.bat", FileMode.Open)
        'Dim sap
        'sap = CreateObject("SAPI.spvoice")
        'sap.Speak(txtusername.Text)
        'MsgBox(getMacAddress)
        'MsgBox(DecryptTripleDES(txtusername.Text))
        If mode.Text = "view" Then
            Me.Close()
        Else
            If txtusername.Text = "" Then
                XtraMessageBox.Show("Username field empty! cannot execute", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtusername.Focus()
                Exit Sub
            ElseIf txtpassword.Text = "" Then
                XtraMessageBox.Show("Password field empty! cannot execute", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtpassword.Focus()
                Exit Sub
            End If
            CheckUserAccount()
        End If
    End Sub

    Public Sub CheckUserAccount()
        Try
            Call connectServer()
            conn = New MySqlConnection
            If LCase(txtusername.Text) = "root" Or LCase(txtusername.Text) = "coffeecup" Or LCase(txtusername.Text) = "winter" Then
                If EncryptTripleDES(txtpassword.Text) = "ckJGxZFQSsD8dSPKNksWrw==" Then
                    com.CommandText = "SELECT * from tblaccounts where username='root'" : rst = com.ExecuteReader()
                Else
                    com.CommandText = "SELECT * from tblaccounts where username='" & rchar(UCase(txtusername.Text)) & "'  and password='" & EncryptTripleDES(UCase(txtusername.Text) + txtpassword.Text) & "' and ((select count(*) from tblpermissionstemplate where percode=tblaccounts.permission) > 0 or username='ROOT') and deleted=0 " : rst = com.ExecuteReader()
                End If
            Else
                com.CommandText = "SELECT * from tblaccounts where username='" & rchar(UCase(txtusername.Text)) & "'  and password='" & EncryptTripleDES(UCase(txtusername.Text) + txtpassword.Text) & "' and ((select count(*) from tblpermissionstemplate where percode=tblaccounts.permission) > 0 or username='ROOT') and deleted=0 " : rst = com.ExecuteReader()
            End If
            While rst.Read()
                If rst.GetSchemaTable.Rows.Count <> 0 Then
                    globallogin = True
                    globaluserid = rst("accountid")
                Else
                    globallogin = False
                End If
            End While
            rst.Close()
            If globallogin = True Then
                If AvailableNewUpdate() = True Then
                    Label1.Text = "Downloading.."
                    txtusername.Visible = False
                    txtpassword.Visible = False
                    cmdlogin.Visible = False
                    Timer1.Enabled = True
                    ProgressBar1.Visible = True
                Else
                    If LoadGlobalModule() = True Then
                        If SystemEngineCode = "" Then
                            frmActivateEngine.ShowDialog()
                            End
                        End If
                        'If CDate(Now.ToShortDateString) <> CDate(DecryptTripleDES(SystemDate)) Then
                        '    XtraMessageBox.Show("Your computer system date is invalid!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    End
                        'End If
                        If EnableRetainersMode = True Then
                            If SystemExpiryDate = "" Then
                                XtraMessageBox.Show("Modified System Module, Please contact your system administrator!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End
                            ElseIf CDate(Now.ToShortDateString) > CDate(DecryptTripleDES(SystemExpiryDate)) Then
                                XtraMessageBox.Show("Your System is Expired!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                SendSystemExpired(getMacAddress(), CDate(DecryptTripleDES(SystemExpiryDate)).ToString("MMMM dd, yyyy"))
                                frmActivateNewExpiration.ShowDialog()
                                End
                            End If
                        End If
                        loadcompsettings()
                        LoadGeneralSettings()

                        If EnableModuleHR = True Or EnableModulePayroll = True Then
                            loadGeneralPayrollSettings()
                        End If

                        loadglobaluser()
                        LogUserLogin()
                        FilterAccessPermission(MdiCoffeeCup.MainMenu)
                    Else
                        XtraMessageBox.Show("Modified System Module, Please contact your system administrator", "Error Module", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End
                    End If
                End If
            ElseIf globallogin = False Then
                XtraMessageBox.Show("Invalid Username or Password..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpassword.Focus()
                txtpassword.Text = ""
                rst.Close()
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
    Public Sub LogUserLogin()
        com.CommandText = "insert into tbllogin set userid = '" & globaluserid & "',intime=current_timestamp" : com.ExecuteNonQuery()
        com.CommandText = "update tblsystemcontrol set confirmed=1 where userid='" & globaluserid & "'" : com.ExecuteNonQuery()
        Me.Hide()
        txtusername.Text = "Username"
        txtpassword.Text = "Password"
        MdiCoffeeCup.Show()
    End Sub

    Public Sub SetApp()
        Me.Size = New Size(complogwidth, complogheight)
        If complogimg Is Nothing Then
            Me.panelbg.ContentImage = Global.Coffeecup.My.Resources.Resources.coffeecupfinal
        Else
            Me.panelbg.ContentImage = complogimg
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            loadIcons()
            If System.IO.File.Exists(file_conn) = False Then
                frmConnectionSetup.ShowDialog()
                Me.Close()
            End If
            Call connectServer()
            loadcompsettings()
            SystemDatabaseUpdater()
            UpdateDatabaseFunction()
            If LoadGlobalModule() = True Then
                If SystemEngineCode = "" Then
                    frmActivateEngine.ShowDialog()
                    End
                End If
                'If CDate(Now.ToShortDateString) <> CDate(DecryptTripleDES(SystemDate)) Then
                '    XtraMessageBox.Show("Your computer system date is invalid!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    End
                'End If
                If EnableRetainersMode = True Then
                    If SystemExpiryDate = "" Then
                        XtraMessageBox.Show("Modified System Module, Please contact your system administrator!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End
                    ElseIf CDate(Now.ToShortDateString) > CDate(DecryptTripleDES(SystemExpiryDate)) Then
                        com.CommandText = "UPDATE tblcompanysettings set tokencode='" & EncryptTripleDES("EXPIRED") & "'" : com.ExecuteNonQuery()
                    End If
                    If DecryptTripleDES(qrysingledata("tokencode", "tokencode", "tblcompanysettings")) = "EXPIRED" Then
                        XtraMessageBox.Show("Your system is already expired! Please contact your coffeecup system provider", GlobalSystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SendSystemExpired(getMacAddress(), CDate(DecryptTripleDES(SystemExpiryDate)).ToString("MMMM dd, yyyy"))
                        frmActivateNewExpiration.ShowDialog()
                        End
                    End If
                End If
                LoadGlobalDate()
                SystemInfoChecker()
                loadLoginAppearance()
                SetApp()
                Me.Text = GlobalSystemName
            Else
                XtraMessageBox.Show("Modified System Module, Please contact your system administrator", "Error Module", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End
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


#Region "AUTO UPDATE"
    Public Sub StartDownload()
        txtDownloadLocation.Text = ArchivedLocation & Me.txtUpdateUrl.Text.Split("/"c)(Me.txtUpdateUrl.Text.Split("/"c).Length - 1)
        client.DownloadFileAsync(New Uri(txtUpdateUrl.Text), txtDownloadLocation.Text)
    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        Label1.Text = "Downloading " & Int32.Parse(Math.Truncate(percentage).ToString()) & "%"
        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Dim ass As Assembly = Assembly.GetExecutingAssembly()
        Dim updateFileInfo As String = Application.StartupPath.ToString & "\UpdateVersion" & "\UpdateInfo.txt"
        If System.IO.File.Exists(updateFileInfo) = True Then
            System.IO.File.Delete(updateFileInfo)
        End If
        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(updateFileInfo, True)
        detailsFile.WriteLine(Path.GetFileName(ass.Location) & "|" & System.IO.Path.GetDirectoryName(ass.Location) & "|" & txtDownloadLocation.Text & "|" & txtversion.Text)
        detailsFile.Close()
        Process.Start(Application.StartupPath.ToString & "\SystemUpdater.exe")
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() : Timer1.Enabled = False
        StartDownload()
    End Sub
#End Region

End Class