<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherPOSelect
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit()
        Me.vendorid = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.lblSupplier = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.ckAp = New System.Windows.Forms.CheckBox()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.ViewPurchaseOrderProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(395, 509)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(240, 30)
        Me.cmdOk.TabIndex = 7
        Me.cmdOk.Text = "Confirm add checked item to voucher"
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPurchaseOrderProfileToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(221, 26)
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 38)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Properties.NullValuePrompt = "Enter keyword to search.."
        Me.txtSearch.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtSearch.Size = New System.Drawing.Size(385, 20)
        Me.txtSearch.TabIndex = 0
        '
        'vendorid
        '
        Me.vendorid.EnterMoveNextControl = True
        Me.vendorid.Location = New System.Drawing.Point(336, 151)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendorid.Properties.Appearance.Options.UseFont = True
        Me.vendorid.Size = New System.Drawing.Size(82, 20)
        Me.vendorid.TabIndex = 707
        Me.vendorid.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 507)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Check All"
        Me.CheckEdit1.Size = New System.Drawing.Size(70, 19)
        Me.CheckEdit1.TabIndex = 723
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.ContextMenuStrip = Me.gridmenustrip
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(12, 63)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv.Size = New System.Drawing.Size(1005, 438)
        Me.dgv.TabIndex = 761
        '
        'voucherno
        '
        Me.voucherno.EnterMoveNextControl = True
        Me.voucherno.Location = New System.Drawing.Point(336, 177)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Size = New System.Drawing.Size(82, 20)
        Me.voucherno.TabIndex = 762
        Me.voucherno.Visible = False
        '
        'lblSupplier
        '
        Me.lblSupplier.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(12, 11)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(0, 21)
        Me.lblSupplier.TabIndex = 763
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(336, 203)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Size = New System.Drawing.Size(82, 20)
        Me.mode.TabIndex = 764
        Me.mode.Visible = False
        '
        'ckAp
        '
        Me.ckAp.AutoSize = True
        Me.ckAp.Location = New System.Drawing.Point(403, 41)
        Me.ckAp.Name = "ckAp"
        Me.ckAp.Size = New System.Drawing.Size(38, 17)
        Me.ckAp.TabIndex = 765
        Me.ckAp.Text = "ap"
        Me.ckAp.UseVisualStyleBackColor = True
        Me.ckAp.Visible = False
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(336, 125)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Size = New System.Drawing.Size(82, 20)
        Me.officeid.TabIndex = 766
        Me.officeid.Visible = False
        '
        'ViewPurchaseOrderProfileToolStripMenuItem
        '
        Me.ViewPurchaseOrderProfileToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__arrow1
        Me.ViewPurchaseOrderProfileToolStripMenuItem.Name = "ViewPurchaseOrderProfileToolStripMenuItem"
        Me.ViewPurchaseOrderProfileToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ViewPurchaseOrderProfileToolStripMenuItem.Text = "View Purchase Order Profile"
        '
        'frmVoucherPOSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 546)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.ckAp)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.dgv)
        Me.MinimumSize = New System.Drawing.Size(680, 413)
        Me.Name = "frmVoucherPOSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add payable to disbursement voucher"
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vendorid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ViewPurchaseOrderProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSupplier As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckAp As System.Windows.Forms.CheckBox
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
End Class
