<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssetsDepreciation
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.ls = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ckpooption = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtvalunit = New DevExpress.XtraEditors.LabelControl()
        Me.lbl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtValue = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.appStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdremove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtprocat = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.combogrid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.catid = New DevExpress.XtraEditors.ButtonEdit()
        CType(Me.ls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckpooption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.appStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprocat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(267, 457)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(181, 30)
        Me.cmdUpdate.TabIndex = 510
        Me.cmdUpdate.Text = "Confirm Save"
        '
        'ls
        '
        Me.ls.CheckOnClick = True
        Me.ls.HorizontalScrollbar = True
        Me.ls.HotTrackItems = True
        Me.ls.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.ls.Location = New System.Drawing.Point(12, 38)
        Me.ls.MultiColumn = True
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(436, 317)
        Me.ls.TabIndex = 618
        '
        'ckpooption
        '
        Me.ckpooption.EditValue = CType(0, Short)
        Me.ckpooption.Location = New System.Drawing.Point(12, 382)
        Me.ckpooption.Name = "ckpooption"
        Me.ckpooption.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckpooption.Properties.Appearance.Options.UseFont = True
        Me.ckpooption.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ckpooption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Reducing Balance Depreciation"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Straight Line Depreciation")})
        Me.ckpooption.Size = New System.Drawing.Size(436, 27)
        Me.ckpooption.TabIndex = 619
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 364)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl1.TabIndex = 620
        Me.LabelControl1.Text = "Depreciation Type"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtvalunit)
        Me.PanelControl1.Controls.Add(Me.lbl2)
        Me.PanelControl1.Controls.Add(Me.txtValue)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 415)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(436, 36)
        Me.PanelControl1.TabIndex = 621
        '
        'txtvalunit
        '
        Me.txtvalunit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalunit.Location = New System.Drawing.Point(351, 12)
        Me.txtvalunit.Name = "txtvalunit"
        Me.txtvalunit.Size = New System.Drawing.Size(0, 13)
        Me.txtvalunit.TabIndex = 411
        '
        'lbl2
        '
        Me.lbl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(9, 12)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(180, 13)
        Me.lbl2.TabIndex = 410
        Me.lbl2.Text = "Number of years to depreciate over"
        '
        'txtValue
        '
        Me.txtValue.EditValue = "0"
        Me.txtValue.EnterMoveNextControl = True
        Me.txtValue.Location = New System.Drawing.Point(274, 8)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Properties.Appearance.Options.UseFont = True
        Me.txtValue.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtValue.Properties.Mask.EditMask = "n"
        Me.txtValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValue.Size = New System.Drawing.Size(70, 20)
        Me.txtValue.TabIndex = 8
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(355, 360)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Select All Item"
        Me.CheckEdit1.Size = New System.Drawing.Size(93, 19)
        Me.CheckEdit1.TabIndex = 682
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.appStrip
        Me.Em.Location = New System.Drawing.Point(456, 8)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(469, 480)
        Me.Em.TabIndex = 684
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'appStrip
        '
        Me.appStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdremove, Me.ToolStripSeparator2, Me.ToolStripMenuItem3})
        Me.appStrip.Name = "gridmenustrip"
        Me.appStrip.Size = New System.Drawing.Size(145, 54)
        '
        'cmdremove
        '
        Me.cmdremove.Image = Global.Coffeecup.My.Resources.Resources.window_suppressed
        Me.cmdremove.Name = "cmdremove"
        Me.cmdremove.Size = New System.Drawing.Size(144, 22)
        Me.cmdremove.Text = "Remove Item"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(141, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtprocat
        '
        Me.txtprocat.EditValue = ""
        Me.txtprocat.EnterMoveNextControl = True
        Me.txtprocat.Location = New System.Drawing.Point(100, 12)
        Me.txtprocat.Name = "txtprocat"
        Me.txtprocat.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprocat.Properties.Appearance.Options.UseFont = True
        Me.txtprocat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtprocat.Properties.DisplayMember = "Select Category"
        Me.txtprocat.Properties.ImmediatePopup = True
        Me.txtprocat.Properties.NullText = ""
        Me.txtprocat.Properties.ValueMember = "Select Category"
        Me.txtprocat.Properties.View = Me.combogrid
        Me.txtprocat.Size = New System.Drawing.Size(348, 20)
        Me.txtprocat.TabIndex = 685
        '
        'combogrid
        '
        Me.combogrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.combogrid.Name = "combogrid"
        Me.combogrid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.combogrid.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(15, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl2.TabIndex = 686
        Me.LabelControl2.Text = "Select Category"
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.Location = New System.Drawing.Point(484, 37)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.Appearance.Options.UseTextOptions = True
        Me.catid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.catid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.catid.Properties.Mask.BeepOnError = True
        Me.catid.Properties.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(33, 22)
        Me.catid.TabIndex = 687
        Me.catid.Visible = False
        '
        'frmAssetsDepreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 500)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.txtprocat)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ckpooption)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.cmdUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAssetsDepreciation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assets and Depreciation Settings"
        CType(Me.ls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckpooption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.appStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprocat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ls As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ckpooption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtvalunit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents appStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdremove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtprocat As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents combogrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents catid As DevExpress.XtraEditors.ButtonEdit
End Class
