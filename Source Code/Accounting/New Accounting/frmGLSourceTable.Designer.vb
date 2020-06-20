<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLSourceTable
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTableDescription = New DevExpress.XtraEditors.TextEdit()
        Me.txtItemDetails = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescDetails = New DevExpress.XtraEditors.TextEdit()
        Me.txtTableName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtitemcode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtdescode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.id = New DevExpress.XtraEditors.ButtonEdit()
        Me.mode = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtparameter = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTableDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTableName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtitemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtparameter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        GridLevelNode2.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.Em.Location = New System.Drawing.Point(0, 130)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(840, 374)
        Me.Em.TabIndex = 636
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(141, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(140, 22)
        Me.cmdEdit.Text = "Edit Table"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus1
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(140, 22)
        Me.cmdDelete.Text = "Delete Table"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(442, 14)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(71, 101)
        Me.cmdSave.TabIndex = 644
        Me.cmdSave.Text = "Save"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Location = New System.Drawing.Point(19, 19)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 15)
        Me.LabelControl2.TabIndex = 651
        Me.LabelControl2.Text = "Select Table"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(27, 45)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 15)
        Me.LabelControl1.TabIndex = 653
        Me.LabelControl1.Text = "Item Code"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Location = New System.Drawing.Point(23, 71)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 15)
        Me.LabelControl3.TabIndex = 654
        Me.LabelControl3.Text = "Item Name"
        '
        'txtTableDescription
        '
        Me.txtTableDescription.Location = New System.Drawing.Point(232, 14)
        Me.txtTableDescription.Name = "txtTableDescription"
        Me.txtTableDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtTableDescription.Properties.Appearance.Options.UseFont = True
        Me.txtTableDescription.Properties.NullValuePrompt = "Table Description"
        Me.txtTableDescription.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTableDescription.Size = New System.Drawing.Size(206, 24)
        Me.txtTableDescription.TabIndex = 656
        '
        'txtItemDetails
        '
        Me.txtItemDetails.Location = New System.Drawing.Point(232, 40)
        Me.txtItemDetails.Name = "txtItemDetails"
        Me.txtItemDetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtItemDetails.Properties.Appearance.Options.UseFont = True
        Me.txtItemDetails.Properties.NullValuePrompt = "Item Code Description"
        Me.txtItemDetails.Size = New System.Drawing.Size(206, 24)
        Me.txtItemDetails.TabIndex = 657
        '
        'txtDescDetails
        '
        Me.txtDescDetails.Location = New System.Drawing.Point(232, 66)
        Me.txtDescDetails.Name = "txtDescDetails"
        Me.txtDescDetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtDescDetails.Properties.Appearance.Options.UseFont = True
        Me.txtDescDetails.Properties.NullValuePrompt = "Item Name Description"
        Me.txtDescDetails.Size = New System.Drawing.Size(206, 24)
        Me.txtDescDetails.TabIndex = 658
        '
        'txtTableName
        '
        Me.txtTableName.EditValue = ""
        Me.txtTableName.Location = New System.Drawing.Point(88, 14)
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtTableName.Properties.Appearance.Options.UseFont = True
        Me.txtTableName.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableName.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtTableName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTableName.Properties.PopupSizeable = True
        Me.txtTableName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtTableName.Size = New System.Drawing.Size(141, 24)
        Me.txtTableName.TabIndex = 650
        '
        'txtitemcode
        '
        Me.txtitemcode.EditValue = ""
        Me.txtitemcode.Location = New System.Drawing.Point(88, 40)
        Me.txtitemcode.Name = "txtitemcode"
        Me.txtitemcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtitemcode.Properties.Appearance.Options.UseFont = True
        Me.txtitemcode.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemcode.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtitemcode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtitemcode.Properties.PopupSizeable = True
        Me.txtitemcode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtitemcode.Size = New System.Drawing.Size(141, 24)
        Me.txtitemcode.TabIndex = 652
        '
        'txtdescode
        '
        Me.txtdescode.EditValue = ""
        Me.txtdescode.Location = New System.Drawing.Point(88, 66)
        Me.txtdescode.Name = "txtdescode"
        Me.txtdescode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtdescode.Properties.Appearance.Options.UseFont = True
        Me.txtdescode.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescode.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtdescode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtdescode.Properties.PopupSizeable = True
        Me.txtdescode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtdescode.Size = New System.Drawing.Size(141, 24)
        Me.txtdescode.TabIndex = 655
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(652, 36)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.id.Properties.Mask.BeepOnError = True
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(39, 20)
        Me.id.TabIndex = 660
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(607, 36)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.mode.Properties.Mask.BeepOnError = True
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(39, 20)
        Me.mode.TabIndex = 659
        Me.mode.Visible = False
        '
        'txtparameter
        '
        Me.txtparameter.Location = New System.Drawing.Point(88, 93)
        Me.txtparameter.Name = "txtparameter"
        Me.txtparameter.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.txtparameter.Properties.Appearance.Options.UseFont = True
        Me.txtparameter.Properties.NullValuePrompt = "SQL Command Parameter"
        Me.txtparameter.Size = New System.Drawing.Size(239, 22)
        Me.txtparameter.TabIndex = 661
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Location = New System.Drawing.Point(28, 97)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 15)
        Me.LabelControl4.TabIndex = 662
        Me.LabelControl4.Text = "Parameter"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(332, 95)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Tas as Account"
        Me.CheckEdit1.Size = New System.Drawing.Size(105, 19)
        Me.CheckEdit1.TabIndex = 663
        '
        'frmGLSourceTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 507)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtparameter)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtDescDetails)
        Me.Controls.Add(Me.txtItemDetails)
        Me.Controls.Add(Me.txtTableDescription)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtTableName)
        Me.Controls.Add(Me.txtitemcode)
        Me.Controls.Add(Me.txtdescode)
        Me.Name = "frmGLSourceTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Source Table Configuration"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTableDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTableName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtitemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtparameter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTableDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItemDetails As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescDetails As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTableName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtitemcode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtdescode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents id As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents mode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtparameter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
