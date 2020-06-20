<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlockedAccounts
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
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdetails = New DevExpress.XtraEditors.MemoEdit()
        Me.cmdMove = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(16, 15)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl8.TabIndex = 577
        Me.LabelControl8.Text = "Reason"
        '
        'txtdetails
        '
        Me.txtdetails.Location = New System.Drawing.Point(61, 12)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetails.Properties.Appearance.Options.UseFont = True
        Me.txtdetails.Properties.MaxLength = 500
        Me.txtdetails.Size = New System.Drawing.Size(382, 51)
        Me.txtdetails.TabIndex = 0
        '
        'cmdMove
        '
        Me.cmdMove.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdMove.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdMove.Appearance.Options.UseBackColor = True
        Me.cmdMove.Appearance.Options.UseFont = True
        Me.cmdMove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdMove.Location = New System.Drawing.Point(61, 67)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(196, 30)
        Me.cmdMove.TabIndex = 592
        Me.cmdMove.Text = "&Confirm Blocked"
        '
        'frmBlockedAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 111)
        Me.Controls.Add(Me.cmdMove)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtdetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBlockedAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blocked Accounts Confirmation"
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdMove As DevExpress.XtraEditors.SimpleButton
End Class
