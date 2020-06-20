<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeApproving
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
        Me.cmdMove = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSupplier = New DevExpress.XtraEditors.TextEdit()
        Me.lbldisbursingoffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtApprovingLevel = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtBranch = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.ponumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApprovingLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ponumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdMove
        '
        Me.cmdMove.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdMove.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdMove.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMove.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdMove.Appearance.Options.UseBackColor = True
        Me.cmdMove.Appearance.Options.UseFont = True
        Me.cmdMove.Appearance.Options.UseForeColor = True
        Me.cmdMove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdMove.Location = New System.Drawing.Point(190, 138)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(236, 30)
        Me.cmdMove.TabIndex = 2
        Me.cmdMove.Text = "Confirm Change"
        '
        'txtSupplier
        '
        Me.txtSupplier.EditValue = ""
        Me.txtSupplier.Location = New System.Drawing.Point(190, 60)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.Properties.Appearance.Options.UseFont = True
        Me.txtSupplier.Properties.ReadOnly = True
        Me.txtSupplier.Properties.ValidateOnEnterKey = True
        Me.txtSupplier.Size = New System.Drawing.Size(236, 20)
        Me.txtSupplier.TabIndex = 638
        '
        'lbldisbursingoffice
        '
        Me.lbldisbursingoffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisbursingoffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbldisbursingoffice.Location = New System.Drawing.Point(21, 109)
        Me.lbldisbursingoffice.Name = "lbldisbursingoffice"
        Me.lbldisbursingoffice.Size = New System.Drawing.Size(162, 20)
        Me.lbldisbursingoffice.TabIndex = 728
        Me.lbldisbursingoffice.Text = "Change Approving Level"
        '
        'txtApprovingLevel
        '
        Me.txtApprovingLevel.Location = New System.Drawing.Point(190, 106)
        Me.txtApprovingLevel.Name = "txtApprovingLevel"
        Me.txtApprovingLevel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovingLevel.Properties.Appearance.Options.UseFont = True
        Me.txtApprovingLevel.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtApprovingLevel.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtApprovingLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtApprovingLevel.Properties.Items.AddRange(New Object() {"BRANCH", "CORPORATE"})
        Me.txtApprovingLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtApprovingLevel.Size = New System.Drawing.Size(236, 28)
        Me.txtApprovingLevel.TabIndex = 727
        '
        'txtBranch
        '
        Me.txtBranch.EditValue = ""
        Me.txtBranch.Location = New System.Drawing.Point(190, 37)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranch.Properties.Appearance.Options.UseFont = True
        Me.txtBranch.Properties.ReadOnly = True
        Me.txtBranch.Properties.ValidateOnEnterKey = True
        Me.txtBranch.Size = New System.Drawing.Size(236, 20)
        Me.txtBranch.TabIndex = 636
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(148, 40)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl6.TabIndex = 637
        Me.LabelControl6.Text = "Branch"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(140, 63)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl1.TabIndex = 729
        Me.LabelControl1.Text = "Supplier"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(114, 86)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl2.TabIndex = 731
        Me.LabelControl2.Text = "Total Amount"
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = ""
        Me.txtAmount.Location = New System.Drawing.Point(190, 83)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.txtAmount.Properties.ReadOnly = True
        Me.txtAmount.Properties.ValidateOnEnterKey = True
        Me.txtAmount.Size = New System.Drawing.Size(141, 20)
        Me.txtAmount.TabIndex = 730
        '
        'ponumber
        '
        Me.ponumber.EditValue = ""
        Me.ponumber.Location = New System.Drawing.Point(190, 14)
        Me.ponumber.Name = "ponumber"
        Me.ponumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ponumber.Properties.Appearance.Options.UseFont = True
        Me.ponumber.Properties.ReadOnly = True
        Me.ponumber.Properties.ValidateOnEnterKey = True
        Me.ponumber.Size = New System.Drawing.Size(129, 20)
        Me.ponumber.TabIndex = 732
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(88, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl3.TabIndex = 733
        Me.LabelControl3.Text = "Reference Number"
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(459, 79)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.mode.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.mode.Properties.ReadOnly = True
        Me.mode.Properties.ValidateOnEnterKey = True
        Me.mode.Size = New System.Drawing.Size(38, 20)
        Me.mode.TabIndex = 734
        Me.mode.Visible = False
        '
        'pid
        '
        Me.pid.EditValue = ""
        Me.pid.Location = New System.Drawing.Point(459, 105)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.pid.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.pid.Properties.ReadOnly = True
        Me.pid.Properties.ValidateOnEnterKey = True
        Me.pid.Size = New System.Drawing.Size(38, 20)
        Me.pid.TabIndex = 735
        Me.pid.Visible = False
        '
        'frmChangeApproving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 178)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ponumber)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lbldisbursingoffice)
        Me.Controls.Add(Me.txtApprovingLevel)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.cmdMove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmChangeApproving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Approving Level"
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApprovingLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ponumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdMove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbldisbursingoffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtApprovingLevel As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtBranch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ponumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
End Class
