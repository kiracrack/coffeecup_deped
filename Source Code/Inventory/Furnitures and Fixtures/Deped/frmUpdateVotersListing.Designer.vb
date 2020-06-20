<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateVotersListing
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
        Me.txtStartingNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEndingNo = New DevExpress.XtraEditors.TextEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTotalSelected = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtStartingNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndingNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStartingNo
        '
        Me.txtStartingNo.EditValue = ""
        Me.txtStartingNo.Location = New System.Drawing.Point(118, 29)
        Me.txtStartingNo.Name = "txtStartingNo"
        Me.txtStartingNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartingNo.Properties.Appearance.Options.UseFont = True
        Me.txtStartingNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStartingNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtStartingNo.Properties.Mask.EditMask = "n0"
        Me.txtStartingNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStartingNo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtStartingNo.Size = New System.Drawing.Size(91, 24)
        Me.txtStartingNo.TabIndex = 597
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(45, 32)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 17)
        Me.LabelControl3.TabIndex = 628
        Me.LabelControl3.Text = "Starting No"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(50, 59)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 17)
        Me.LabelControl1.TabIndex = 630
        Me.LabelControl1.Text = "Ending No"
        '
        'txtEndingNo
        '
        Me.txtEndingNo.EditValue = ""
        Me.txtEndingNo.Location = New System.Drawing.Point(118, 56)
        Me.txtEndingNo.Name = "txtEndingNo"
        Me.txtEndingNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndingNo.Properties.Appearance.Options.UseFont = True
        Me.txtEndingNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEndingNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEndingNo.Properties.Mask.EditMask = "n0"
        Me.txtEndingNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEndingNo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEndingNo.Properties.ReadOnly = True
        Me.txtEndingNo.Size = New System.Drawing.Size(91, 24)
        Me.txtEndingNo.TabIndex = 629
        '
        'cmdaction
        '
        Me.cmdaction.Location = New System.Drawing.Point(215, 30)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(108, 50)
        Me.cmdaction.TabIndex = 631
        Me.cmdaction.Text = "&Confirm Update"
        '
        'txtTotalSelected
        '
        Me.txtTotalSelected.EditValue = ""
        Me.txtTotalSelected.Location = New System.Drawing.Point(320, 86)
        Me.txtTotalSelected.Name = "txtTotalSelected"
        Me.txtTotalSelected.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSelected.Properties.Appearance.Options.UseFont = True
        Me.txtTotalSelected.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalSelected.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTotalSelected.Properties.Mask.EditMask = "n"
        Me.txtTotalSelected.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalSelected.Properties.ReadOnly = True
        Me.txtTotalSelected.Size = New System.Drawing.Size(46, 24)
        Me.txtTotalSelected.TabIndex = 632
        Me.txtTotalSelected.Visible = False
        '
        'frmUpdateVotersListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 117)
        Me.Controls.Add(Me.txtTotalSelected)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtEndingNo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtStartingNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUpdateVotersListing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Listing Number"
        Me.TopMost = True
        CType(Me.txtStartingNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndingNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStartingNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEndingNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotalSelected As DevExpress.XtraEditors.TextEdit
End Class
