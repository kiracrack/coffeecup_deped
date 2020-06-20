<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetAttachment
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
        Me.refno = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdFinish = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFilePath = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.att_type = New DevExpress.XtraEditors.TextEdit()
        CType(Me.refno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.att_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'refno
        '
        Me.refno.EditValue = ""
        Me.refno.EnterMoveNextControl = True
        Me.refno.Location = New System.Drawing.Point(12, 122)
        Me.refno.Name = "refno"
        Me.refno.Properties.ReadOnly = True
        Me.refno.Properties.ValidateOnEnterKey = True
        Me.refno.Size = New System.Drawing.Size(69, 20)
        Me.refno.TabIndex = 543
        Me.refno.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(280, 55)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 27)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Cancel"
        Me.SimpleButton1.ToolTip = "Shortcut Key (Enter)"
        '
        'cmdFinish
        '
        Me.cmdFinish.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdFinish.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdFinish.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdFinish.Appearance.Options.UseBackColor = True
        Me.cmdFinish.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdFinish.Location = New System.Drawing.Point(188, 55)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(88, 27)
        Me.cmdFinish.TabIndex = 3
        Me.cmdFinish.Text = "Save"
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(14, 13)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(242, 13)
        Me.LabelControl34.TabIndex = 551
        Me.LabelControl34.Text = "Browse File - supported documents file and images"
        '
        'txtFilePath
        '
        Me.txtFilePath.EditValue = ""
        Me.txtFilePath.Location = New System.Drawing.Point(11, 30)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFilePath.Properties.ReadOnly = True
        Me.txtFilePath.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtFilePath.Size = New System.Drawing.Size(349, 20)
        Me.txtFilePath.TabIndex = 628
        Me.txtFilePath.ToolTip = "Shortcut Key (F11)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl1.Location = New System.Drawing.Point(11, 53)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(144, 11)
        Me.LabelControl1.TabIndex = 630
        Me.LabelControl1.Text = "Please upload not morethan 10MB"
        '
        'att_type
        '
        Me.att_type.EditValue = ""
        Me.att_type.EnterMoveNextControl = True
        Me.att_type.Location = New System.Drawing.Point(87, 122)
        Me.att_type.Name = "att_type"
        Me.att_type.Properties.ReadOnly = True
        Me.att_type.Properties.ValidateOnEnterKey = True
        Me.att_type.Size = New System.Drawing.Size(69, 20)
        Me.att_type.TabIndex = 631
        Me.att_type.Visible = False
        '
        'frmSetAttachment
        '
        Me.AcceptButton = Me.cmdFinish
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 89)
        Me.Controls.Add(Me.att_type)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.LabelControl34)
        Me.Controls.Add(Me.cmdFinish)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.refno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSetAttachment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Attachment"
        CType(Me.refno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.att_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents refno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdFinish As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFilePath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents att_type As DevExpress.XtraEditors.TextEdit
End Class
