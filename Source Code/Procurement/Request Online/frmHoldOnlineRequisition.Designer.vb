<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoldOnlineRequisition
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdMove = New DevExpress.XtraEditors.SimpleButton()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtpotype = New DevExpress.XtraEditors.TextEdit()
        Me.reqid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtrequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpotype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reqid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtrequestby
        '
        Me.txtrequestby.Location = New System.Drawing.Point(97, 35)
        Me.txtrequestby.Name = "txtrequestby"
        Me.txtrequestby.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrequestby.Properties.Appearance.Options.UseFont = True
        Me.txtrequestby.Properties.Appearance.Options.UseTextOptions = True
        Me.txtrequestby.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtrequestby.Properties.ReadOnly = True
        Me.txtrequestby.Size = New System.Drawing.Size(326, 20)
        Me.txtrequestby.TabIndex = 580
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(33, 38)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 579
        Me.LabelControl3.Text = "Request By"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(52, 61)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl8.TabIndex = 577
        Me.LabelControl8.Text = "Reason"
        '
        'txtdetails
        '
        Me.txtdetails.Location = New System.Drawing.Point(97, 58)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetails.Properties.Appearance.Options.UseFont = True
        Me.txtdetails.Size = New System.Drawing.Size(326, 51)
        Me.txtdetails.TabIndex = 0
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(97, 12)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Properties.Appearance.Options.UseBackColor = True
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(178, 20)
        Me.pid.TabIndex = 582
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(18, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 591
        Me.LabelControl1.Text = "Request Code"
        '
        'cmdMove
        '
        Me.cmdMove.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdMove.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdMove.Appearance.Options.UseBackColor = True
        Me.cmdMove.Appearance.Options.UseFont = True
        Me.cmdMove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdMove.Location = New System.Drawing.Point(97, 113)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(196, 30)
        Me.cmdMove.TabIndex = 592
        Me.cmdMove.Text = "&Confirm Hold Request"
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(19, 123)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(53, 20)
        Me.officeid.TabIndex = 593
        Me.officeid.Visible = False
        '
        'txtpotype
        '
        Me.txtpotype.Location = New System.Drawing.Point(312, 118)
        Me.txtpotype.Name = "txtpotype"
        Me.txtpotype.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpotype.Properties.Appearance.Options.UseFont = True
        Me.txtpotype.Properties.Appearance.Options.UseTextOptions = True
        Me.txtpotype.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtpotype.Properties.ReadOnly = True
        Me.txtpotype.Size = New System.Drawing.Size(53, 20)
        Me.txtpotype.TabIndex = 594
        Me.txtpotype.Visible = False
        '
        'reqid
        '
        Me.reqid.Location = New System.Drawing.Point(370, 118)
        Me.reqid.Name = "reqid"
        Me.reqid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reqid.Properties.Appearance.Options.UseFont = True
        Me.reqid.Properties.Appearance.Options.UseTextOptions = True
        Me.reqid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.reqid.Properties.ReadOnly = True
        Me.reqid.Size = New System.Drawing.Size(53, 20)
        Me.reqid.TabIndex = 595
        Me.reqid.Visible = False
        '
        'frmHoldOnlineRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 158)
        Me.Controls.Add(Me.reqid)
        Me.Controls.Add(Me.txtpotype)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.cmdMove)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.txtrequestby)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtdetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHoldOnlineRequisition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hold Request"
        CType(Me.txtrequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpotype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reqid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtrequestby As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdMove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpotype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents reqid As DevExpress.XtraEditors.TextEdit
End Class
