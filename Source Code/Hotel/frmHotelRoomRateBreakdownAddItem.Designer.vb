<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomRateBreakdownAddItem
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
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.breakdowntype = New DevExpress.XtraEditors.TextEdit()
        Me.ratecode = New DevExpress.XtraEditors.TextEdit()
        Me.roomtype = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtitemname = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridPackageItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.itemcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.dayno = New DevExpress.XtraEditors.TextEdit()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.breakdowntype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ratecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roomtype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtitemname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPackageItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dayno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cmdOk.Location = New System.Drawing.Point(150, 75)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(132, 30)
        Me.cmdOk.TabIndex = 584
        Me.cmdOk.Text = "Save"
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(165, 76)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'breakdowntype
        '
        Me.breakdowntype.EditValue = ""
        Me.breakdowntype.Location = New System.Drawing.Point(133, 242)
        Me.breakdowntype.Name = "breakdowntype"
        Me.breakdowntype.Properties.Appearance.Options.UseTextOptions = True
        Me.breakdowntype.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.breakdowntype.Size = New System.Drawing.Size(53, 20)
        Me.breakdowntype.TabIndex = 640
        Me.breakdowntype.Visible = False
        '
        'ratecode
        '
        Me.ratecode.EditValue = ""
        Me.ratecode.Location = New System.Drawing.Point(133, 216)
        Me.ratecode.Name = "ratecode"
        Me.ratecode.Properties.Appearance.Options.UseTextOptions = True
        Me.ratecode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ratecode.Size = New System.Drawing.Size(53, 20)
        Me.ratecode.TabIndex = 649
        Me.ratecode.Visible = False
        '
        'roomtype
        '
        Me.roomtype.EditValue = ""
        Me.roomtype.Location = New System.Drawing.Point(133, 190)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Properties.Appearance.Options.UseTextOptions = True
        Me.roomtype.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.roomtype.Size = New System.Drawing.Size(53, 20)
        Me.roomtype.TabIndex = 650
        Me.roomtype.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(57, 27)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(86, 15)
        Me.LabelControl5.TabIndex = 717
        Me.LabelControl5.Text = "Breakdown Item"
        '
        'txtitemname
        '
        Me.txtitemname.EditValue = ""
        Me.txtitemname.Location = New System.Drawing.Point(150, 24)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtitemname.Properties.Appearance.Options.UseFont = True
        Me.txtitemname.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtitemname.Properties.DisplayMember = "Item Name"
        Me.txtitemname.Properties.NullText = ""
        Me.txtitemname.Properties.ValueMember = "Item Name"
        Me.txtitemname.Properties.View = Me.gridPackageItem
        Me.txtitemname.Size = New System.Drawing.Size(226, 22)
        Me.txtitemname.TabIndex = 0
        '
        'gridPackageItem
        '
        Me.gridPackageItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridPackageItem.Name = "gridPackageItem"
        Me.gridPackageItem.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridPackageItem.OptionsView.ShowGroupPanel = False
        '
        'itemcode
        '
        Me.itemcode.EnterMoveNextControl = True
        Me.itemcode.Location = New System.Drawing.Point(382, 24)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.itemcode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.itemcode.Properties.Appearance.Options.UseFont = True
        Me.itemcode.Properties.Appearance.Options.UseForeColor = True
        Me.itemcode.Properties.Appearance.Options.UseTextOptions = True
        Me.itemcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.itemcode.Properties.ReadOnly = True
        Me.itemcode.Size = New System.Drawing.Size(43, 22)
        Me.itemcode.TabIndex = 714
        Me.itemcode.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(102, 53)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 713
        Me.LabelControl2.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = ""
        Me.txtAmount.Location = New System.Drawing.Point(150, 49)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Size = New System.Drawing.Size(132, 22)
        Me.txtAmount.TabIndex = 1
        '
        'dayno
        '
        Me.dayno.EnterMoveNextControl = True
        Me.dayno.Location = New System.Drawing.Point(382, 49)
        Me.dayno.Name = "dayno"
        Me.dayno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dayno.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.dayno.Properties.Appearance.Options.UseFont = True
        Me.dayno.Properties.Appearance.Options.UseForeColor = True
        Me.dayno.Properties.Appearance.Options.UseTextOptions = True
        Me.dayno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dayno.Properties.ReadOnly = True
        Me.dayno.Size = New System.Drawing.Size(43, 22)
        Me.dayno.TabIndex = 718
        Me.dayno.Visible = False
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
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'frmHotelRoomRateBreakdownAddItem
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 127)
        Me.Controls.Add(Me.dayno)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtitemname)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.ratecode)
        Me.Controls.Add(Me.breakdowntype)
        Me.Controls.Add(Me.cmdOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHotelRoomRateBreakdownAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Package"
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.breakdowntype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ratecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roomtype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtitemname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPackageItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dayno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents breakdowntype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ratecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents roomtype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtitemname As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridPackageItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents itemcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dayno As DevExpress.XtraEditors.TextEdit
End Class
