<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetQueueGroup
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
        Me.txtDescription = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.combogrid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.groupcode = New DevExpress.XtraEditors.TextEdit()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.EnterMoveNextControl = True
        Me.txtDescription.Location = New System.Drawing.Point(95, 16)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDescription.Properties.DisplayMember = "Select"
        Me.txtDescription.Properties.ImmediatePopup = True
        Me.txtDescription.Properties.NullText = ""
        Me.txtDescription.Properties.ValueMember = "Select"
        Me.txtDescription.Properties.View = Me.combogrid
        Me.txtDescription.Size = New System.Drawing.Size(274, 22)
        Me.txtDescription.TabIndex = 0
        '
        'combogrid
        '
        Me.combogrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.combogrid.Name = "combogrid"
        Me.combogrid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.combogrid.OptionsView.ShowGroupPanel = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl9.Location = New System.Drawing.Point(18, 19)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(71, 15)
        Me.LabelControl9.TabIndex = 579
        Me.LabelControl9.Text = "Queue Group"
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdConfirm.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdConfirm.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdConfirm.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdConfirm.Appearance.Options.UseBackColor = True
        Me.cmdConfirm.Appearance.Options.UseFont = True
        Me.cmdConfirm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdConfirm.Location = New System.Drawing.Point(95, 42)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(141, 30)
        Me.cmdConfirm.TabIndex = 589
        Me.cmdConfirm.Text = "&Confirm"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 89)
        Me.BarDockControl1.Size = New System.Drawing.Size(408, 0)
        '
        'groupcode
        '
        Me.groupcode.EnterMoveNextControl = True
        Me.groupcode.Location = New System.Drawing.Point(330, 51)
        Me.groupcode.Name = "groupcode"
        Me.groupcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.groupcode.Properties.Appearance.Options.UseFont = True
        Me.groupcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.groupcode.Size = New System.Drawing.Size(39, 22)
        Me.groupcode.TabIndex = 597
        Me.groupcode.Visible = False
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 89)
        Me.BarDockControl2.Size = New System.Drawing.Size(408, 0)
        '
        'frmSetQueueGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 89)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSetQueueGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Queue Group"
        Me.TopMost = True
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescription As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents combogrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents groupcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
End Class
