<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSudgestionBox
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtFilePath = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSystemName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVersion = New DevExpress.XtraEditors.TextEdit()
        Me.txtvalunit = New DevExpress.XtraEditors.LabelControl()
        Me.txtFeatures = New DevExpress.XtraEditors.MemoEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdResolvedIssue = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAttachmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtFilePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSystemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVersion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeatures.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.txtFilePath)
        Me.PanelControl1.Controls.Add(Me.LabelControl34)
        Me.PanelControl1.Controls.Add(Me.cmdUpdate)
        Me.PanelControl1.Controls.Add(Me.lbl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtSystemName)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtVersion)
        Me.PanelControl1.Controls.Add(Me.txtvalunit)
        Me.PanelControl1.Controls.Add(Me.txtFeatures)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(384, 467)
        Me.PanelControl1.TabIndex = 622
        '
        'txtFilePath
        '
        Me.txtFilePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFilePath.EditValue = ""
        Me.txtFilePath.Location = New System.Drawing.Point(101, 403)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFilePath.Properties.ReadOnly = True
        Me.txtFilePath.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtFilePath.Size = New System.Drawing.Size(266, 20)
        Me.txtFilePath.TabIndex = 634
        Me.txtFilePath.ToolTip = "Shortcut Key (F11)"
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(15, 406)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl34.TabIndex = 633
        Me.LabelControl34.Text = "Please attach file"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(218, 426)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(149, 30)
        Me.cmdUpdate.TabIndex = 421
        Me.cmdUpdate.Text = "Submit"
        '
        'lbl1
        '
        Me.lbl1.Appearance.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lbl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl1.Location = New System.Drawing.Point(15, 11)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(218, 13)
        Me.lbl1.TabIndex = 420
        Me.lbl1.Text = "Error Report or Suggestion Details"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(15, 83)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl3.TabIndex = 417
        Me.LabelControl3.Text = "Complete Details"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(33, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl2.TabIndex = 415
        Me.LabelControl2.Text = "System Type"
        '
        'txtSystemName
        '
        Me.txtSystemName.EditValue = "SERVER"
        Me.txtSystemName.EnterMoveNextControl = True
        Me.txtSystemName.Location = New System.Drawing.Point(100, 58)
        Me.txtSystemName.Name = "txtSystemName"
        Me.txtSystemName.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSystemName.Properties.ReadOnly = True
        Me.txtSystemName.Size = New System.Drawing.Size(267, 20)
        Me.txtSystemName.TabIndex = 414
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(60, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 413
        Me.LabelControl1.Text = "Version"
        '
        'txtVersion
        '
        Me.txtVersion.EditValue = ""
        Me.txtVersion.EnterMoveNextControl = True
        Me.txtVersion.Location = New System.Drawing.Point(100, 35)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVersion.Properties.ReadOnly = True
        Me.txtVersion.Size = New System.Drawing.Size(133, 20)
        Me.txtVersion.TabIndex = 412
        '
        'txtvalunit
        '
        Me.txtvalunit.Location = New System.Drawing.Point(349, 11)
        Me.txtvalunit.Name = "txtvalunit"
        Me.txtvalunit.Size = New System.Drawing.Size(0, 13)
        Me.txtvalunit.TabIndex = 411
        '
        'txtFeatures
        '
        Me.txtFeatures.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFeatures.EditValue = ""
        Me.txtFeatures.Location = New System.Drawing.Point(100, 81)
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFeatures.Size = New System.Drawing.Size(267, 318)
        Me.txtFeatures.TabIndex = 0
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.cms
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(402, 12)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(547, 471)
        Me.Em.TabIndex = 623
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdResolvedIssue, Me.ViewAttachmentToolStripMenuItem, Me.ToolStripSeparator1, Me.menu_Refresh})
        Me.cms.Name = "ContextMenuStrip1"
        Me.cms.Size = New System.Drawing.Size(166, 76)
        '
        'cmdResolvedIssue
        '
        Me.cmdResolvedIssue.Image = Global.Coffeecup.My.Resources.Resources.dialog_ok_3
        Me.cmdResolvedIssue.Name = "cmdResolvedIssue"
        Me.cmdResolvedIssue.Size = New System.Drawing.Size(165, 22)
        Me.cmdResolvedIssue.Text = "Resolved Issue"
        '
        'ViewAttachmentToolStripMenuItem
        '
        Me.ViewAttachmentToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.inbox__arrow1
        Me.ViewAttachmentToolStripMenuItem.Name = "ViewAttachmentToolStripMenuItem"
        Me.ViewAttachmentToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewAttachmentToolStripMenuItem.Text = "View Attachment"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'menu_Refresh
        '
        Me.menu_Refresh.ForeColor = System.Drawing.Color.Black
        Me.menu_Refresh.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.menu_Refresh.Name = "menu_Refresh"
        Me.menu_Refresh.Size = New System.Drawing.Size(165, 22)
        Me.menu_Refresh.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsPrint.PrintDetails = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'frmSudgestionBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 491)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmSudgestionBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coffeecup Suggestion and Error Report Box"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtFilePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSystemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVersion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeatures.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSystemName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtvalunit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFeatures As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lbl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menu_Refresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdResolvedIssue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtFilePath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ViewAttachmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
