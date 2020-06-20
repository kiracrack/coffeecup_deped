<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLBrowseSourceTable
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
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tablename = New DevExpress.XtraEditors.ButtonEdit()
        Me.groupid = New DevExpress.XtraEditors.ButtonEdit()
        Me.itemcode = New DevExpress.XtraEditors.TextEdit()
        Me.itemid = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtGroup = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvGroup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.itemdetails = New DevExpress.XtraEditors.TextEdit()
        Me.desccode = New DevExpress.XtraEditors.TextEdit()
        Me.descdetails = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.ButtonEdit()
        Me.parameter = New DevExpress.XtraEditors.TextEdit()
        Me.companyid = New DevExpress.XtraEditors.ButtonEdit()
        Me.ckAccount = New DevExpress.XtraEditors.CheckEdit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.tablename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemdetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desccode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descdetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parameter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(171, 54)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.tick
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(170, 22)
        Me.cmdEdit.Text = "Pick Selected Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'tablename
        '
        Me.tablename.EditValue = ""
        Me.tablename.Location = New System.Drawing.Point(440, 202)
        Me.tablename.Name = "tablename"
        Me.tablename.Properties.Appearance.Options.UseTextOptions = True
        Me.tablename.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tablename.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tablename.Properties.Mask.BeepOnError = True
        Me.tablename.Properties.ReadOnly = True
        Me.tablename.Size = New System.Drawing.Size(73, 20)
        Me.tablename.TabIndex = 646
        Me.tablename.Visible = False
        '
        'groupid
        '
        Me.groupid.EditValue = ""
        Me.groupid.Location = New System.Drawing.Point(466, 31)
        Me.groupid.Name = "groupid"
        Me.groupid.Properties.Appearance.Options.UseTextOptions = True
        Me.groupid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.groupid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.groupid.Properties.Mask.BeepOnError = True
        Me.groupid.Properties.ReadOnly = True
        Me.groupid.Size = New System.Drawing.Size(39, 20)
        Me.groupid.TabIndex = 647
        Me.groupid.Visible = False
        '
        'itemcode
        '
        Me.itemcode.Location = New System.Drawing.Point(440, 228)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemcode.Properties.Appearance.Options.UseFont = True
        Me.itemcode.Properties.ReadOnly = True
        Me.itemcode.Size = New System.Drawing.Size(73, 20)
        Me.itemcode.TabIndex = 652
        Me.itemcode.Visible = False
        '
        'itemid
        '
        Me.itemid.Location = New System.Drawing.Point(511, 31)
        Me.itemid.Name = "itemid"
        Me.itemid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemid.Properties.Appearance.Options.UseFont = True
        Me.itemid.Properties.ReadOnly = True
        Me.itemid.Size = New System.Drawing.Size(48, 20)
        Me.itemid.TabIndex = 653
        Me.itemid.Visible = False
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Location = New System.Drawing.Point(3, 63)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(581, 543)
        Me.Em.TabIndex = 654
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtGroup
        '
        Me.txtGroup.EditValue = ""
        Me.txtGroup.Location = New System.Drawing.Point(12, 31)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtGroup.Properties.Appearance.Options.UseFont = True
        Me.txtGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGroup.Properties.DisplayMember = "Select"
        Me.txtGroup.Properties.NullText = ""
        Me.txtGroup.Properties.ValueMember = "id"
        Me.txtGroup.Properties.View = Me.gvGroup
        Me.txtGroup.Size = New System.Drawing.Size(308, 26)
        Me.txtGroup.TabIndex = 659
        '
        'gvGroup
        '
        Me.gvGroup.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvGroup.Name = "gvGroup"
        Me.gvGroup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvGroup.OptionsView.ShowGroupPanel = False
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.HyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(253, 15)
        Me.HyperlinkLabelControl1.TabIndex = 661
        Me.HyperlinkLabelControl1.Text = "Select Database Source Table (Click here to add)"
        '
        'itemdetails
        '
        Me.itemdetails.Location = New System.Drawing.Point(440, 254)
        Me.itemdetails.Name = "itemdetails"
        Me.itemdetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemdetails.Properties.Appearance.Options.UseFont = True
        Me.itemdetails.Properties.ReadOnly = True
        Me.itemdetails.Size = New System.Drawing.Size(73, 20)
        Me.itemdetails.TabIndex = 662
        Me.itemdetails.Visible = False
        '
        'desccode
        '
        Me.desccode.Location = New System.Drawing.Point(440, 280)
        Me.desccode.Name = "desccode"
        Me.desccode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desccode.Properties.Appearance.Options.UseFont = True
        Me.desccode.Properties.ReadOnly = True
        Me.desccode.Size = New System.Drawing.Size(73, 20)
        Me.desccode.TabIndex = 663
        Me.desccode.Visible = False
        '
        'descdetails
        '
        Me.descdetails.Location = New System.Drawing.Point(440, 306)
        Me.descdetails.Name = "descdetails"
        Me.descdetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descdetails.Properties.Appearance.Options.UseFont = True
        Me.descdetails.Properties.ReadOnly = True
        Me.descdetails.Size = New System.Drawing.Size(73, 20)
        Me.descdetails.TabIndex = 664
        Me.descdetails.Visible = False
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(440, 176)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.id.Properties.Mask.BeepOnError = True
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(73, 20)
        Me.id.TabIndex = 665
        Me.id.Visible = False
        '
        'parameter
        '
        Me.parameter.Location = New System.Drawing.Point(440, 332)
        Me.parameter.Name = "parameter"
        Me.parameter.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parameter.Properties.Appearance.Options.UseFont = True
        Me.parameter.Properties.ReadOnly = True
        Me.parameter.Size = New System.Drawing.Size(73, 20)
        Me.parameter.TabIndex = 666
        Me.parameter.Visible = False
        '
        'companyid
        '
        Me.companyid.EditValue = ""
        Me.companyid.Location = New System.Drawing.Point(440, 150)
        Me.companyid.Name = "companyid"
        Me.companyid.Properties.Appearance.Options.UseTextOptions = True
        Me.companyid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.companyid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.companyid.Properties.Mask.BeepOnError = True
        Me.companyid.Properties.ReadOnly = True
        Me.companyid.Size = New System.Drawing.Size(73, 20)
        Me.companyid.TabIndex = 667
        Me.companyid.Visible = False
        '
        'ckAccount
        '
        Me.ckAccount.Location = New System.Drawing.Point(326, 35)
        Me.ckAccount.Name = "ckAccount"
        Me.ckAccount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAccount.Properties.Appearance.Options.UseFont = True
        Me.ckAccount.Properties.Caption = "Tas as Account"
        Me.ckAccount.Size = New System.Drawing.Size(141, 19)
        Me.ckAccount.TabIndex = 668
        Me.ckAccount.Visible = False
        '
        'frmGLBrowseSourceTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 608)
        Me.Controls.Add(Me.ckAccount)
        Me.Controls.Add(Me.companyid)
        Me.Controls.Add(Me.parameter)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.descdetails)
        Me.Controls.Add(Me.desccode)
        Me.Controls.Add(Me.itemdetails)
        Me.Controls.Add(Me.itemid)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.HyperlinkLabelControl1)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.groupid)
        Me.Controls.Add(Me.tablename)
        Me.Controls.Add(Me.Em)
        Me.Name = "frmGLBrowseSourceTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Item Preference"
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.tablename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemdetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desccode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descdetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parameter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tablename As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents groupid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents itemcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents itemid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtGroup As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents itemdetails As DevExpress.XtraEditors.TextEdit
    Friend WithEvents desccode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents descdetails As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents parameter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents companyid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ckAccount As DevExpress.XtraEditors.CheckEdit
End Class
