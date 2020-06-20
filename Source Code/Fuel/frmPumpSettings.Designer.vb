<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPumpSettings
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.userid = New DevExpress.XtraEditors.TextEdit()
        Me.dueid = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormatGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProduct = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dueid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(292, 78)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(86, 29)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(38, 56)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl6.TabIndex = 571
        Me.LabelControl6.Text = "Description"
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(95, 77)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(191, 30)
        Me.cmdOk.TabIndex = 584
        Me.cmdOk.Text = "Save"
        '
        'userid
        '
        Me.userid.Location = New System.Drawing.Point(390, 12)
        Me.userid.Name = "userid"
        Me.userid.Properties.Appearance.Options.UseTextOptions = True
        Me.userid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.userid.Properties.ReadOnly = True
        Me.userid.Size = New System.Drawing.Size(53, 20)
        Me.userid.TabIndex = 580
        '
        'dueid
        '
        Me.dueid.Location = New System.Drawing.Point(390, 63)
        Me.dueid.Name = "dueid"
        Me.dueid.Properties.Appearance.Options.UseTextOptions = True
        Me.dueid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dueid.Properties.ReadOnly = True
        Me.dueid.Size = New System.Drawing.Size(53, 20)
        Me.dueid.TabIndex = 581
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        GridLevelNode1.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em.Location = New System.Drawing.Point(0, 113)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(385, 312)
        Me.Em.TabIndex = 636
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.FormatGridToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(166, 98)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(165, 22)
        Me.cmdEdit.Text = "Edit"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(165, 22)
        Me.cmdDelete.Text = "Remove"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'FormatGridToolStripMenuItem
        '
        Me.FormatGridToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.FormatGridToolStripMenuItem.Name = "FormatGridToolStripMenuItem"
        Me.FormatGridToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.FormatGridToolStripMenuItem.Text = "View Appearance"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(95, 53)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Size = New System.Drawing.Size(283, 20)
        Me.txtDescription.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(37, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 638
        Me.LabelControl1.Text = "Pump Code"
        '
        'code
        '
        Me.code.EditValue = ""
        Me.code.Location = New System.Drawing.Point(95, 7)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Options.UseTextOptions = True
        Me.code.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.code.Size = New System.Drawing.Size(132, 20)
        Me.code.TabIndex = 0
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(126, 201)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Size = New System.Drawing.Size(53, 20)
        Me.mode.TabIndex = 640
        Me.mode.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(54, 33)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 648
        Me.LabelControl3.Text = "Product"
        '
        'txtProduct
        '
        Me.txtProduct.EditValue = ""
        Me.txtProduct.Location = New System.Drawing.Point(95, 30)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProduct.Properties.DisplayMember = "Product Name"
        Me.txtProduct.Properties.NullText = ""
        Me.txtProduct.Properties.ValueMember = "Product Name"
        Me.txtProduct.Properties.View = Me.gridProduct
        Me.txtProduct.Size = New System.Drawing.Size(283, 20)
        Me.txtProduct.TabIndex = 647
        '
        'gridProduct
        '
        Me.gridProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridProduct.Name = "gridProduct"
        Me.gridProduct.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridProduct.OptionsView.ShowGroupPanel = False
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.Location = New System.Drawing.Point(126, 175)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Size = New System.Drawing.Size(53, 20)
        Me.productid.TabIndex = 649
        Me.productid.Visible = False
        '
        'frmPumpSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 423)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.dueid)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPumpSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pump Settings"
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dueid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents userid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dueid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormatGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProduct As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
End Class
