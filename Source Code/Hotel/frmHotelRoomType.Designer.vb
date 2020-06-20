<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomType
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
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.hotelcif = New DevExpress.XtraEditors.TextEdit()
        Me.lblTotalPurchase = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaxPax = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.radChargeMode = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtShortname = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSort = New DevExpress.XtraEditors.TextEdit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hotelcif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaxPax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radChargeMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShortname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(29, 81)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl6.TabIndex = 571
        Me.LabelControl6.Text = "Description"
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(339, 120)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(132, 30)
        Me.cmdOk.TabIndex = 584
        Me.cmdOk.Text = "Save"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        GridLevelNode1.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em.Location = New System.Drawing.Point(0, 158)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(480, 319)
        Me.Em.TabIndex = 636
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(165, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(164, 22)
        Me.cmdEdit.Text = "Edit Selected"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(164, 22)
        Me.cmdDelete.Text = "Remove Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(95, 78)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Size = New System.Drawing.Size(283, 20)
        Me.txtDescription.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(61, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 638
        Me.LabelControl1.Text = "Code"
        '
        'code
        '
        Me.code.EditValue = ""
        Me.code.Location = New System.Drawing.Point(95, 9)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Properties.Appearance.Options.UseFont = True
        Me.code.Properties.Appearance.Options.UseTextOptions = True
        Me.code.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.code.Properties.ReadOnly = True
        Me.code.Size = New System.Drawing.Size(84, 20)
        Me.code.TabIndex = 0
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(126, 224)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Size = New System.Drawing.Size(53, 20)
        Me.mode.TabIndex = 640
        Me.mode.Visible = False
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.Location = New System.Drawing.Point(126, 198)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Size = New System.Drawing.Size(53, 20)
        Me.productid.TabIndex = 649
        Me.productid.Visible = False
        '
        'hotelcif
        '
        Me.hotelcif.EditValue = ""
        Me.hotelcif.Location = New System.Drawing.Point(126, 172)
        Me.hotelcif.Name = "hotelcif"
        Me.hotelcif.Properties.Appearance.Options.UseTextOptions = True
        Me.hotelcif.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.hotelcif.Size = New System.Drawing.Size(53, 20)
        Me.hotelcif.TabIndex = 650
        Me.hotelcif.Visible = False
        '
        'lblTotalPurchase
        '
        Me.lblTotalPurchase.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblTotalPurchase.Location = New System.Drawing.Point(21, 133)
        Me.lblTotalPurchase.Name = "lblTotalPurchase"
        Me.lblTotalPurchase.Size = New System.Drawing.Size(67, 13)
        Me.lblTotalPurchase.TabIndex = 729
        Me.lblTotalPurchase.Text = "Maximun Pax"
        '
        'txtMaxPax
        '
        Me.txtMaxPax.EditValue = ""
        Me.txtMaxPax.Location = New System.Drawing.Point(95, 130)
        Me.txtMaxPax.Name = "txtMaxPax"
        Me.txtMaxPax.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMaxPax.Properties.Appearance.Options.UseFont = True
        Me.txtMaxPax.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaxPax.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaxPax.Properties.Mask.EditMask = "N0"
        Me.txtMaxPax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMaxPax.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMaxPax.Size = New System.Drawing.Size(84, 22)
        Me.txtMaxPax.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(18, 107)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl2.TabIndex = 730
        Me.LabelControl2.Text = "Charge Mode"
        '
        'radChargeMode
        '
        Me.radChargeMode.EditValue = True
        Me.radChargeMode.Location = New System.Drawing.Point(95, 101)
        Me.radChargeMode.Name = "radChargeMode"
        Me.radChargeMode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.radChargeMode.Properties.Appearance.Options.UseFont = True
        Me.radChargeMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Per Night"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Per Pax")})
        Me.radChargeMode.Size = New System.Drawing.Size(169, 26)
        Me.radChargeMode.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(28, 58)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 733
        Me.LabelControl3.Text = "Short Name"
        '
        'txtShortname
        '
        Me.txtShortname.EditValue = ""
        Me.txtShortname.Location = New System.Drawing.Point(95, 55)
        Me.txtShortname.Name = "txtShortname"
        Me.txtShortname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShortname.Properties.Appearance.Options.UseFont = True
        Me.txtShortname.Properties.Appearance.Options.UseTextOptions = True
        Me.txtShortname.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtShortname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtShortname.Size = New System.Drawing.Size(84, 20)
        Me.txtShortname.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(34, 35)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 735
        Me.LabelControl4.Text = "Sort Order"
        '
        'txtSort
        '
        Me.txtSort.EditValue = ""
        Me.txtSort.Location = New System.Drawing.Point(95, 32)
        Me.txtSort.Name = "txtSort"
        Me.txtSort.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSort.Properties.Appearance.Options.UseFont = True
        Me.txtSort.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSort.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSort.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSort.Size = New System.Drawing.Size(84, 20)
        Me.txtSort.TabIndex = 0
        '
        'frmHotelRoomType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 478)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtSort)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtShortname)
        Me.Controls.Add(Me.radChargeMode)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lblTotalPurchase)
        Me.Controls.Add(Me.txtMaxPax)
        Me.Controls.Add(Me.hotelcif)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHotelRoomType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Type"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hotelcif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaxPax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radChargeMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShortname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents hotelcif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalPurchase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaxPax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents radChargeMode As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtShortname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSort As DevExpress.XtraEditors.TextEdit
End Class
