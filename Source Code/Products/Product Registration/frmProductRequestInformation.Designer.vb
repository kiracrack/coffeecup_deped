<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductRequestInformation
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
        Me.txtProductname = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtprocat = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.combogrid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.ckUnit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.txtProductname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprocat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProductname
        '
        Me.txtProductname.EnterMoveNextControl = True
        Me.txtProductname.Location = New System.Drawing.Point(98, 12)
        Me.txtProductname.Name = "txtProductname"
        Me.txtProductname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductname.Properties.Appearance.Options.UseFont = True
        Me.txtProductname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductname.Size = New System.Drawing.Size(274, 20)
        Me.txtProductname.TabIndex = 555
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(42, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 562
        Me.LabelControl1.Text = "Particular"
        '
        'txtprocat
        '
        Me.txtprocat.EditValue = ""
        Me.txtprocat.EnterMoveNextControl = True
        Me.txtprocat.Location = New System.Drawing.Point(98, 35)
        Me.txtprocat.Name = "txtprocat"
        Me.txtprocat.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprocat.Properties.Appearance.Options.UseFont = True
        Me.txtprocat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtprocat.Properties.DisplayMember = "Select Category"
        Me.txtprocat.Properties.ImmediatePopup = True
        Me.txtprocat.Properties.NullText = ""
        Me.txtprocat.Properties.ValueMember = "Select Category"
        Me.txtprocat.Properties.View = Me.combogrid
        Me.txtprocat.Size = New System.Drawing.Size(274, 20)
        Me.txtprocat.TabIndex = 0
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
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(44, 38)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl9.TabIndex = 579
        Me.LabelControl9.Text = "Category"
        '
        'ckUnit
        '
        Me.ckUnit.EditValue = True
        Me.ckUnit.Location = New System.Drawing.Point(98, 59)
        Me.ckUnit.Name = "ckUnit"
        Me.ckUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckUnit.Properties.Appearance.Options.UseFont = True
        Me.ckUnit.Properties.Caption = "Use existing unit"
        Me.ckUnit.Size = New System.Drawing.Size(106, 19)
        Me.ckUnit.TabIndex = 588
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(45, 83)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl10.TabIndex = 586
        Me.LabelControl10.Text = "Item Unit"
        '
        'txtUnit
        '
        Me.txtUnit.EditValue = ""
        Me.txtUnit.Location = New System.Drawing.Point(100, 80)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtUnit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtUnit.Size = New System.Drawing.Size(141, 20)
        Me.txtUnit.TabIndex = 587
        Me.txtUnit.ToolTip = "Shortcut Key (F11)"
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
        Me.cmdConfirm.Location = New System.Drawing.Point(100, 104)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(141, 30)
        Me.cmdConfirm.TabIndex = 589
        Me.cmdConfirm.Text = "&Confirm Item"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 151)
        Me.BarDockControl1.Size = New System.Drawing.Size(408, 0)
        '
        'catid
        '
        Me.catid.EnterMoveNextControl = True
        Me.catid.Location = New System.Drawing.Point(357, 168)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.catid.Size = New System.Drawing.Size(39, 20)
        Me.catid.TabIndex = 597
        Me.catid.Visible = False
        '
        'id
        '
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(357, 116)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.id.Size = New System.Drawing.Size(39, 20)
        Me.id.TabIndex = 599
        Me.id.Visible = False
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 151)
        Me.BarDockControl2.Size = New System.Drawing.Size(408, 0)
        '
        'frmProductRequestInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 151)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.ckUnit)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtprocat)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtProductname)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProductRequestInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Item for Registration"
        Me.TopMost = True
        CType(Me.txtProductname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprocat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProductname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtprocat As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents combogrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckUnit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
End Class
