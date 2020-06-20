<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmedVoucherProcessing
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
        Me.lblcaption = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtremarks = New DevExpress.XtraEditors.MemoEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcaption
        '
        Me.lblcaption.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaption.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lblcaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblcaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblcaption.Location = New System.Drawing.Point(15, 9)
        Me.lblcaption.Name = "lblcaption"
        Me.lblcaption.Size = New System.Drawing.Size(457, 20)
        Me.lblcaption.TabIndex = 584
        Me.lblcaption.Text = "Please enter message for recording purposes."
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleButton1.Location = New System.Drawing.Point(341, 83)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(131, 29)
        Me.SimpleButton1.TabIndex = 585
        Me.SimpleButton1.Text = "Cancel Action"
        Me.SimpleButton1.ToolTip = "Shortcut Key (Enter)"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.BackColor = System.Drawing.Color.Green
        Me.cmdCancel.Appearance.BackColor2 = System.Drawing.Color.Green
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmdCancel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCancel.Appearance.Options.UseBackColor = True
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Appearance.Options.UseForeColor = True
        Me.cmdCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdCancel.Location = New System.Drawing.Point(181, 82)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(154, 30)
        Me.cmdCancel.TabIndex = 588
        Me.cmdCancel.Text = "Confirm Request"
        '
        'txtremarks
        '
        Me.txtremarks.EditValue = "Please enter message.."
        Me.txtremarks.Location = New System.Drawing.Point(15, 28)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.Properties.Appearance.Options.UseFont = True
        Me.txtremarks.Size = New System.Drawing.Size(457, 49)
        Me.txtremarks.TabIndex = 589
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(15, 92)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(90, 20)
        Me.pid.TabIndex = 590
        Me.pid.Visible = False
        '
        'frmConfirmedVoucherProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 122)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.txtremarks)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.lblcaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfirmedVoucherProcessing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirm Request Processing"
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblcaption As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtremarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
End Class
