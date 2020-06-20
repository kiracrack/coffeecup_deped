<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeOwnPassword
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.uid = New DevExpress.XtraEditors.TextEdit()
        Me.txtVerifyPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtNewPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.userid = New DevExpress.XtraEditors.TextEdit()
        Me.txtCurrentPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.uid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVerifyPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(59, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl2.TabIndex = 507
        Me.LabelControl2.Text = "Verify Password"
        '
        'uid
        '
        Me.uid.Location = New System.Drawing.Point(447, 49)
        Me.uid.Name = "uid"
        Me.uid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uid.Properties.Appearance.Options.UseFont = True
        Me.uid.Properties.Appearance.Options.UseTextOptions = True
        Me.uid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.uid.Properties.ReadOnly = True
        Me.uid.Size = New System.Drawing.Size(77, 20)
        Me.uid.TabIndex = 508
        Me.uid.Visible = False
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.EditValue = "password"
        Me.txtVerifyPassword.Location = New System.Drawing.Point(147, 77)
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtVerifyPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtVerifyPassword.Properties.Appearance.Options.UseFont = True
        Me.txtVerifyPassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtVerifyPassword.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtVerifyPassword.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtVerifyPassword.Properties.AutoHeight = False
        Me.txtVerifyPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtVerifyPassword.Size = New System.Drawing.Size(205, 24)
        Me.txtVerifyPassword.TabIndex = 2
        '
        'txtNewPassword
        '
        Me.txtNewPassword.EditValue = "password"
        Me.txtNewPassword.Location = New System.Drawing.Point(147, 50)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtNewPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtNewPassword.Properties.Appearance.Options.UseFont = True
        Me.txtNewPassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtNewPassword.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNewPassword.Properties.AutoHeight = False
        Me.txtNewPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtNewPassword.Size = New System.Drawing.Size(205, 24)
        Me.txtNewPassword.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(65, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl1.TabIndex = 510
        Me.LabelControl1.Text = "New Password"
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSaveButton.Location = New System.Drawing.Point(212, 107)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(139, 26)
        Me.cmdSaveButton.TabIndex = 3
        Me.cmdSaveButton.Text = "Confirm Change"
        '
        'userid
        '
        Me.userid.EditValue = ""
        Me.userid.EnterMoveNextControl = True
        Me.userid.Location = New System.Drawing.Point(64, 177)
        Me.userid.Name = "userid"
        Me.userid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.Properties.Appearance.Options.UseFont = True
        Me.userid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.userid.Properties.ReadOnly = True
        Me.userid.Size = New System.Drawing.Size(67, 20)
        Me.userid.TabIndex = 626
        Me.userid.Visible = False
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.EditValue = "password"
        Me.txtCurrentPassword.Location = New System.Drawing.Point(147, 23)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtCurrentPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtCurrentPassword.Properties.Appearance.Options.UseFont = True
        Me.txtCurrentPassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtCurrentPassword.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentPassword.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtCurrentPassword.Properties.AutoHeight = False
        Me.txtCurrentPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(205, 24)
        Me.txtCurrentPassword.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(49, 28)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl4.TabIndex = 628
        Me.LabelControl4.Text = "Current Password"
        '
        'frmChangeOwnPassword
        '
        Me.AcceptButton = Me.cmdSaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 150)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtVerifyPassword)
        Me.Controls.Add(Me.uid)
        Me.Controls.Add(Me.LabelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmChangeOwnPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Own Password"
        CType(Me.uid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVerifyPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVerifyPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNewPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents userid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCurrentPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
