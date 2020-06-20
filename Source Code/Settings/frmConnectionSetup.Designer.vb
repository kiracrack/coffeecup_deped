<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectionSetup
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
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtusername = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtServerhost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDatabase = New DevExpress.XtraEditors.TextEdit()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtJoinbase = New DevExpress.XtraEditors.TextEdit()
        Me.txtPort = New DevExpress.XtraEditors.TextEdit()
        Me.ckDefault = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConnectionName = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServerhost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJoinbase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDefault.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConnectionName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.EditValue = "Password"
        Me.txtpassword.Location = New System.Drawing.Point(176, 92)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtpassword.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtpassword.Properties.AutoHeight = False
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(150, 24)
        Me.txtpassword.TabIndex = 4
        '
        'txtusername
        '
        Me.txtusername.EditValue = "Username"
        Me.txtusername.EnterMoveNextControl = True
        Me.txtusername.Location = New System.Drawing.Point(176, 69)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtusername.Properties.Appearance.Options.UseFont = True
        Me.txtusername.Properties.Appearance.Options.UseForeColor = True
        Me.txtusername.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtusername.Size = New System.Drawing.Size(234, 20)
        Me.txtusername.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(117, 97)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 458
        Me.LabelControl1.Text = "Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(115, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 459
        Me.LabelControl2.Text = "Username"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(91, 49)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl4.TabIndex = 460
        Me.LabelControl4.Text = "Database Host"
        '
        'txtServerhost
        '
        Me.txtServerhost.EditValue = "localhost"
        Me.txtServerhost.EnterMoveNextControl = True
        Me.txtServerhost.Location = New System.Drawing.Point(176, 46)
        Me.txtServerhost.Name = "txtServerhost"
        Me.txtServerhost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerhost.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtServerhost.Properties.Appearance.Options.UseFont = True
        Me.txtServerhost.Properties.Appearance.Options.UseForeColor = True
        Me.txtServerhost.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtServerhost.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtServerhost.Size = New System.Drawing.Size(173, 20)
        Me.txtServerhost.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(118, 122)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl3.TabIndex = 466
        Me.LabelControl3.Text = "Database"
        '
        'txtDatabase
        '
        Me.txtDatabase.EditValue = "Database"
        Me.txtDatabase.EnterMoveNextControl = True
        Me.txtDatabase.Location = New System.Drawing.Point(176, 119)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatabase.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtDatabase.Properties.Appearance.Options.UseFont = True
        Me.txtDatabase.Properties.Appearance.Options.UseForeColor = True
        Me.txtDatabase.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtDatabase.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtDatabase.Size = New System.Drawing.Size(150, 20)
        Me.txtDatabase.TabIndex = 5
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(176, 193)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(150, 32)
        Me.cmdUpdate.TabIndex = 8
        Me.cmdUpdate.Text = "Connect and Activate"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(94, 145)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl5.TabIndex = 629
        Me.LabelControl5.Text = "Join Database"
        '
        'txtJoinbase
        '
        Me.txtJoinbase.EditValue = "Database"
        Me.txtJoinbase.EnterMoveNextControl = True
        Me.txtJoinbase.Location = New System.Drawing.Point(176, 142)
        Me.txtJoinbase.Name = "txtJoinbase"
        Me.txtJoinbase.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJoinbase.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtJoinbase.Properties.Appearance.Options.UseFont = True
        Me.txtJoinbase.Properties.Appearance.Options.UseForeColor = True
        Me.txtJoinbase.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtJoinbase.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtJoinbase.Size = New System.Drawing.Size(150, 20)
        Me.txtJoinbase.TabIndex = 6
        '
        'txtPort
        '
        Me.txtPort.EditValue = "Port"
        Me.txtPort.EnterMoveNextControl = True
        Me.txtPort.Location = New System.Drawing.Point(351, 46)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtPort.Properties.Appearance.Options.UseFont = True
        Me.txtPort.Properties.Appearance.Options.UseForeColor = True
        Me.txtPort.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPort.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPort.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtPort.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtPort.Size = New System.Drawing.Size(59, 20)
        Me.txtPort.TabIndex = 2
        '
        'ckDefault
        '
        Me.ckDefault.Location = New System.Drawing.Point(176, 168)
        Me.ckDefault.Name = "ckDefault"
        Me.ckDefault.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckDefault.Properties.Appearance.Options.UseFont = True
        Me.ckDefault.Properties.Caption = "Make Default Connection"
        Me.ckDefault.Size = New System.Drawing.Size(173, 19)
        Me.ckDefault.TabIndex = 7
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(74, 26)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl6.TabIndex = 632
        Me.LabelControl6.Text = "Connection Name"
        '
        'txtConnectionName
        '
        Me.txtConnectionName.EditValue = "CONNECTION NAME"
        Me.txtConnectionName.EnterMoveNextControl = True
        Me.txtConnectionName.Location = New System.Drawing.Point(176, 23)
        Me.txtConnectionName.Name = "txtConnectionName"
        Me.txtConnectionName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConnectionName.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtConnectionName.Properties.Appearance.Options.UseFont = True
        Me.txtConnectionName.Properties.Appearance.Options.UseForeColor = True
        Me.txtConnectionName.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtConnectionName.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtConnectionName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConnectionName.Size = New System.Drawing.Size(234, 20)
        Me.txtConnectionName.TabIndex = 0
        '
        'frmConnectionSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 256)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtConnectionName)
        Me.Controls.Add(Me.ckDefault)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtJoinbase)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtServerhost)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConnectionSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection Setup"
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServerhost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJoinbase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDefault.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConnectionName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtusername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtServerhost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDatabase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtJoinbase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPort As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckDefault As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConnectionName As DevExpress.XtraEditors.TextEdit
End Class
