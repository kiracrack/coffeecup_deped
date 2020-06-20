<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.cmdlogin = New DevExpress.XtraEditors.SimpleButton()
        Me.panelbg = New DevExpress.XtraEditors.PanelControl()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtDownloadLocation = New System.Windows.Forms.TextBox()
        Me.txtversion = New System.Windows.Forms.TextBox()
        Me.txtUpdateUrl = New System.Windows.Forms.TextBox()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtusername = New DevExpress.XtraEditors.TextEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.panelbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelbg.SuspendLayout()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdlogin
        '
        Me.cmdlogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdlogin.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdlogin.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdlogin.Appearance.BorderColor = System.Drawing.Color.Black
        Me.cmdlogin.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdlogin.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdlogin.Appearance.Options.UseBackColor = True
        Me.cmdlogin.Appearance.Options.UseBorderColor = True
        Me.cmdlogin.Appearance.Options.UseForeColor = True
        Me.cmdlogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdlogin.Location = New System.Drawing.Point(75, 235)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(123, 26)
        Me.cmdlogin.TabIndex = 622
        Me.cmdlogin.Text = "Enter"
        '
        'panelbg
        '
        Me.panelbg.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.panelbg.Controls.Add(Me.ProgressBar1)
        Me.panelbg.Controls.Add(Me.txtDownloadLocation)
        Me.panelbg.Controls.Add(Me.txtversion)
        Me.panelbg.Controls.Add(Me.txtUpdateUrl)
        Me.panelbg.Controls.Add(Me.Label1)
        Me.panelbg.Controls.Add(Me.mode)
        Me.panelbg.Controls.Add(Me.cmdlogin)
        Me.panelbg.Controls.Add(Me.txtpassword)
        Me.panelbg.Controls.Add(Me.txtusername)
        Me.panelbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelbg.Location = New System.Drawing.Point(0, 0)
        Me.panelbg.Name = "panelbg"
        Me.panelbg.Size = New System.Drawing.Size(267, 282)
        Me.panelbg.TabIndex = 376
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(70, 147)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(130, 10)
        Me.ProgressBar1.TabIndex = 624
        Me.ProgressBar1.Visible = False
        '
        'txtDownloadLocation
        '
        Me.txtDownloadLocation.Location = New System.Drawing.Point(311, 97)
        Me.txtDownloadLocation.Name = "txtDownloadLocation"
        Me.txtDownloadLocation.Size = New System.Drawing.Size(66, 21)
        Me.txtDownloadLocation.TabIndex = 627
        Me.txtDownloadLocation.Visible = False
        '
        'txtversion
        '
        Me.txtversion.Location = New System.Drawing.Point(312, 88)
        Me.txtversion.Name = "txtversion"
        Me.txtversion.Size = New System.Drawing.Size(66, 21)
        Me.txtversion.TabIndex = 626
        Me.txtversion.Visible = False
        '
        'txtUpdateUrl
        '
        Me.txtUpdateUrl.Location = New System.Drawing.Point(317, 61)
        Me.txtUpdateUrl.Name = "txtUpdateUrl"
        Me.txtUpdateUrl.Size = New System.Drawing.Size(66, 21)
        Me.txtUpdateUrl.TabIndex = 625
        Me.txtUpdateUrl.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label1.Location = New System.Drawing.Point(41, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 13)
        Me.Label1.TabIndex = 377
        Me.Label1.Text = "Enter Login Credential"
        '
        'mode
        '
        Me.mode.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.mode.EditValue = ""
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(14, 288)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Size = New System.Drawing.Size(57, 20)
        Me.mode.TabIndex = 623
        Me.mode.Visible = False
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpassword.EditValue = "password"
        Me.txtpassword.Location = New System.Drawing.Point(41, 205)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtpassword.Properties.Appearance.Options.UseTextOptions = True
        Me.txtpassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtpassword.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtpassword.Properties.AutoHeight = False
        Me.txtpassword.Properties.UseSystemPasswordChar = True
        Me.txtpassword.Size = New System.Drawing.Size(191, 22)
        Me.txtpassword.TabIndex = 374
        '
        'txtusername
        '
        Me.txtusername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtusername.EditValue = "Username"
        Me.txtusername.EnterMoveNextControl = True
        Me.txtusername.Location = New System.Drawing.Point(41, 180)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.txtusername.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtusername.Properties.Appearance.Options.UseFont = True
        Me.txtusername.Properties.Appearance.Options.UseForeColor = True
        Me.txtusername.Properties.Appearance.Options.UseTextOptions = True
        Me.txtusername.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtusername.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtusername.Size = New System.Drawing.Size(191, 22)
        Me.txtusername.TabIndex = 373
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'frmLogin
        '
        Me.AcceptButton = Me.cmdlogin
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(267, 282)
        Me.Controls.Add(Me.panelbg)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(283, 321)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coffeecup"
        CType(Me.panelbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelbg.ResumeLayout(False)
        Me.panelbg.PerformLayout()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtusername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents panelbg As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdlogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtversion As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateUrl As System.Windows.Forms.TextBox
    Friend WithEvents txtDownloadLocation As System.Windows.Forms.TextBox
End Class
