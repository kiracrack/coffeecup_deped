<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemOwnerConfirmation
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
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        CType(Me.uid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 16)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl2.TabIndex = 507
        Me.LabelControl2.Text = "Owner Password"
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
        'txtpassword
        '
        Me.txtpassword.EditValue = "password"
        Me.txtpassword.Location = New System.Drawing.Point(109, 12)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtpassword.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtpassword.Properties.AutoHeight = False
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(205, 24)
        Me.txtpassword.TabIndex = 0
        '
        'frmSystemOwnerConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 49)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.uid)
        Me.Controls.Add(Me.LabelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSystemOwnerConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Owner Confirmation"
        CType(Me.uid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
End Class
