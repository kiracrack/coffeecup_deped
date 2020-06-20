<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeAttendancePassword
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
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmployeeID = New DevExpress.XtraEditors.TextEdit()
        Me.userid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.uid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVerifyPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmployeeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(40, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 507
        Me.LabelControl2.Text = "Verify Password"
        '
        'uid
        '
        Me.uid.Location = New System.Drawing.Point(447, 49)
        Me.uid.Name = "uid"
        Me.uid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtVerifyPassword.Location = New System.Drawing.Point(123, 62)
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
        Me.txtVerifyPassword.TabIndex = 1
        '
        'txtNewPassword
        '
        Me.txtNewPassword.EditValue = "password"
        Me.txtNewPassword.Location = New System.Drawing.Point(123, 35)
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
        Me.txtNewPassword.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(47, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.TabIndex = 510
        Me.LabelControl1.Text = "New Password"
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSaveButton.Location = New System.Drawing.Point(188, 90)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(139, 26)
        Me.cmdSaveButton.TabIndex = 623
        Me.cmdSaveButton.Text = "Confirm Change"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(57, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 624
        Me.LabelControl3.Text = "Employee ID"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.EditValue = "KIRACRACK"
        Me.txtEmployeeID.EnterMoveNextControl = True
        Me.txtEmployeeID.Location = New System.Drawing.Point(123, 12)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeID.Properties.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(205, 20)
        Me.txtEmployeeID.TabIndex = 625
        '
        'userid
        '
        Me.userid.EditValue = ""
        Me.userid.EnterMoveNextControl = True
        Me.userid.Location = New System.Drawing.Point(69, 96)
        Me.userid.Name = "userid"
        Me.userid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.userid.Properties.ReadOnly = True
        Me.userid.Size = New System.Drawing.Size(67, 20)
        Me.userid.TabIndex = 626
        Me.userid.Visible = False
        '
        'frmChangeAttendancePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 124)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtVerifyPassword)
        Me.Controls.Add(Me.uid)
        Me.Controls.Add(Me.LabelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmChangeAttendancePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Attendance Password"
        CType(Me.uid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVerifyPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmployeeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVerifyPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNewPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmployeeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents userid As DevExpress.XtraEditors.TextEdit
End Class
