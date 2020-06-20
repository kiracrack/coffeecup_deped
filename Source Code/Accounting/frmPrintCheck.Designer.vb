<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintCheck
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
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTransactiontype = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCheckTemplate = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCheckDate = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumberInWords = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtCheckPayee = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtCheckTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtCheckDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumberInWords.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckPayee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdConfirm.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdConfirm.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdConfirm.Appearance.Options.UseBackColor = True
        Me.cmdConfirm.Appearance.Options.UseFont = True
        Me.cmdConfirm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdConfirm.Location = New System.Drawing.Point(795, 285)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(113, 30)
        Me.cmdConfirm.TabIndex = 590
        Me.cmdConfirm.Text = "&Done Print"
        '
        'lblTransactiontype
        '
        Me.lblTransactiontype.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactiontype.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTransactiontype.Location = New System.Drawing.Point(242, 291)
        Me.lblTransactiontype.Name = "lblTransactiontype"
        Me.lblTransactiontype.Size = New System.Drawing.Size(150, 20)
        Me.lblTransactiontype.TabIndex = 605
        Me.lblTransactiontype.Text = "Select Check Template"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(676, 285)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(113, 30)
        Me.SimpleButton1.TabIndex = 606
        Me.SimpleButton1.Text = "Print Check"
        '
        'txtCheckTemplate
        '
        Me.txtCheckTemplate.EditValue = "Standard Check"
        Me.txtCheckTemplate.Location = New System.Drawing.Point(413, 288)
        Me.txtCheckTemplate.Name = "txtCheckTemplate"
        Me.txtCheckTemplate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckTemplate.Properties.Appearance.Options.UseFont = True
        Me.txtCheckTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCheckTemplate.Properties.Items.AddRange(New Object() {"SECURITY BANK", "EASTWEST BANK"})
        Me.txtCheckTemplate.Properties.PopupSizeable = True
        Me.txtCheckTemplate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCheckTemplate.Size = New System.Drawing.Size(257, 26)
        Me.txtCheckTemplate.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.check
        Me.GroupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.GroupControl1.Controls.Add(Me.txtCheckDate)
        Me.GroupControl1.Controls.Add(Me.txtNumberInWords)
        Me.GroupControl1.Controls.Add(Me.txtAmount)
        Me.GroupControl1.Controls.Add(Me.txtCheckPayee)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(920, 279)
        Me.GroupControl1.TabIndex = 612
        '
        'txtCheckDate
        '
        Me.txtCheckDate.EditValue = "***November 1, 2013 ***"
        Me.txtCheckDate.Location = New System.Drawing.Point(687, 73)
        Me.txtCheckDate.Name = "txtCheckDate"
        Me.txtCheckDate.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtCheckDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtCheckDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCheckDate.Properties.Appearance.Options.UseBackColor = True
        Me.txtCheckDate.Properties.Appearance.Options.UseFont = True
        Me.txtCheckDate.Properties.Appearance.Options.UseForeColor = True
        Me.txtCheckDate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCheckDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCheckDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCheckDate.Properties.ReadOnly = True
        Me.txtCheckDate.Size = New System.Drawing.Size(197, 24)
        Me.txtCheckDate.TabIndex = 615
        '
        'txtNumberInWords
        '
        Me.txtNumberInWords.EditValue = "***TWENTY FIVE THOUSAND PESOS ONLY***"
        Me.txtNumberInWords.Location = New System.Drawing.Point(118, 146)
        Me.txtNumberInWords.Name = "txtNumberInWords"
        Me.txtNumberInWords.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtNumberInWords.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtNumberInWords.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumberInWords.Properties.Appearance.Options.UseFont = True
        Me.txtNumberInWords.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtNumberInWords.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumberInWords.Properties.ReadOnly = True
        Me.txtNumberInWords.Size = New System.Drawing.Size(765, 24)
        Me.txtNumberInWords.TabIndex = 614
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = "***25,000.00***"
        Me.txtAmount.Location = New System.Drawing.Point(686, 107)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAmount.Properties.Appearance.Options.UseBackColor = True
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseForeColor = True
        Me.txtAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtAmount.Properties.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(197, 24)
        Me.txtAmount.TabIndex = 612
        '
        'txtCheckPayee
        '
        Me.txtCheckPayee.EditValue = "***WINTER BUGAHOD***"
        Me.txtCheckPayee.Location = New System.Drawing.Point(118, 107)
        Me.txtCheckPayee.Name = "txtCheckPayee"
        Me.txtCheckPayee.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtCheckPayee.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtCheckPayee.Properties.Appearance.Options.UseBackColor = True
        Me.txtCheckPayee.Properties.Appearance.Options.UseFont = True
        Me.txtCheckPayee.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCheckPayee.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheckPayee.Properties.ReadOnly = True
        Me.txtCheckPayee.Size = New System.Drawing.Size(547, 24)
        Me.txtCheckPayee.TabIndex = 611
        '
        'frmPrintCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 322)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.lblTransactiontype)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.txtCheckTemplate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrintCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Check Template"
        CType(Me.txtCheckTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtCheckDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumberInWords.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckPayee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTransactiontype As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCheckDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumberInWords As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCheckPayee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCheckTemplate As DevExpress.XtraEditors.ComboBoxEdit
End Class
