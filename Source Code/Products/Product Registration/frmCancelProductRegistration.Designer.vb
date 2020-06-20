<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelProductRegistration
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
        Me.txtrequestby = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdetails = New DevExpress.XtraEditors.MemoEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.cmdMove = New DevExpress.XtraEditors.SimpleButton()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtrequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtrequestby
        '
        Me.txtrequestby.Location = New System.Drawing.Point(80, 11)
        Me.txtrequestby.Name = "txtrequestby"
        Me.txtrequestby.Properties.Appearance.Options.UseTextOptions = True
        Me.txtrequestby.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtrequestby.Properties.ReadOnly = True
        Me.txtrequestby.Size = New System.Drawing.Size(330, 20)
        Me.txtrequestby.TabIndex = 580
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(19, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 579
        Me.LabelControl3.Text = "Item Name"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(38, 37)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl8.TabIndex = 577
        Me.LabelControl8.Text = "Reason"
        '
        'txtdetails
        '
        Me.txtdetails.Location = New System.Drawing.Point(80, 34)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Size = New System.Drawing.Size(330, 51)
        Me.txtdetails.TabIndex = 0
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(65, 99)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(71, 20)
        Me.pid.TabIndex = 582
        Me.pid.Visible = False
        '
        'cmdMove
        '
        Me.cmdMove.Appearance.BackColor = System.Drawing.Color.Red
        Me.cmdMove.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdMove.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmdMove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdMove.Appearance.Options.UseBackColor = True
        Me.cmdMove.Appearance.Options.UseForeColor = True
        Me.cmdMove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdMove.Location = New System.Drawing.Point(214, 91)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(196, 30)
        Me.cmdMove.TabIndex = 592
        Me.cmdMove.Text = "&Confirm Cancel Request"
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(6, 99)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(53, 20)
        Me.officeid.TabIndex = 593
        Me.officeid.Visible = False
        '
        'frmCancelProductRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 128)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.cmdMove)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.txtrequestby)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtdetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCancelProductRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancel Request"
        CType(Me.txtrequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtrequestby As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdMove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
End Class
