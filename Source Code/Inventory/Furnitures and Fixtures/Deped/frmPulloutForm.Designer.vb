<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPulloutForm
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
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PulloutItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtBorrowersname = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.s_grid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtBorrowedDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReturnedDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.borrowerid = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.trncode = New DevExpress.XtraEditors.TextEdit()
        Me.seriesno = New DevExpress.XtraEditors.TextEdit()
        Me.yeartrn = New DevExpress.XtraEditors.TextEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtOffice = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBorrowersname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBorrowedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBorrowedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReturnedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReturnedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.borrowerid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trncode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seriesno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.Appearance.Options.UseForeColor = True
        Me.cmdOk.Location = New System.Drawing.Point(187, 153)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(127, 30)
        Me.cmdOk.TabIndex = 10
        Me.cmdOk.Text = "Confirm Save"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(372, 1)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(630, 433)
        Me.Em.TabIndex = 868
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.PulloutItemToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(167, 76)
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__plus
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'PulloutItemToolStripMenuItem
        '
        Me.PulloutItemToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus1
        Me.PulloutItemToolStripMenuItem.Name = "PulloutItemToolStripMenuItem"
        Me.PulloutItemToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PulloutItemToolStripMenuItem.Text = "Remove Seleted"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Inventory"
        '
        'Gridview1
        '
        Me.Gridview1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Gridview1.Appearance.HeaderPanel.Options.UseFont = True
        Me.Gridview1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gridview1.Appearance.Row.Options.UseFont = True
        Me.Gridview1.GridControl = Me.Em
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsSelection.MultiSelect = True
        Me.Gridview1.OptionsView.ColumnAutoWidth = False
        Me.Gridview1.OptionsView.RowAutoHeight = True
        Me.Gridview1.OptionsView.ShowGroupPanel = False
        Me.Gridview1.PaintStyleName = "Web"
        '
        'txtBorrowersname
        '
        Me.txtBorrowersname.EditValue = ""
        Me.txtBorrowersname.Location = New System.Drawing.Point(135, 102)
        Me.txtBorrowersname.Name = "txtBorrowersname"
        Me.txtBorrowersname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBorrowersname.Properties.Appearance.Options.UseFont = True
        Me.txtBorrowersname.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBorrowersname.Properties.DisplayMember = "Fullname"
        Me.txtBorrowersname.Properties.NullText = ""
        Me.txtBorrowersname.Properties.PopupView = Me.s_grid
        Me.txtBorrowersname.Properties.ValueMember = "accountid"
        Me.txtBorrowersname.Size = New System.Drawing.Size(222, 20)
        Me.txtBorrowersname.TabIndex = 869
        '
        's_grid
        '
        Me.s_grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.s_grid.Name = "s_grid"
        Me.s_grid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.s_grid.OptionsView.ShowGroupPanel = False
        '
        'txtBorrowedDate
        '
        Me.txtBorrowedDate.EditValue = New Date(CType(0, Long))
        Me.txtBorrowedDate.Location = New System.Drawing.Point(135, 53)
        Me.txtBorrowedDate.Name = "txtBorrowedDate"
        Me.txtBorrowedDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowedDate.Properties.Appearance.Options.UseFont = True
        Me.txtBorrowedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBorrowedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBorrowedDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtBorrowedDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtBorrowedDate.Size = New System.Drawing.Size(132, 22)
        Me.txtBorrowedDate.TabIndex = 870
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(50, 56)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(78, 15)
        Me.LabelControl12.TabIndex = 872
        Me.LabelControl12.Text = "Borrowed Date"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(40, 105)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl5.TabIndex = 871
        Me.LabelControl5.Text = "Borrower's Name"
        '
        'txtReturnedDate
        '
        Me.txtReturnedDate.EditValue = New Date(CType(0, Long))
        Me.txtReturnedDate.Location = New System.Drawing.Point(135, 77)
        Me.txtReturnedDate.Name = "txtReturnedDate"
        Me.txtReturnedDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnedDate.Properties.Appearance.Options.UseFont = True
        Me.txtReturnedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtReturnedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtReturnedDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtReturnedDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtReturnedDate.Size = New System.Drawing.Size(132, 22)
        Me.txtReturnedDate.TabIndex = 873
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(53, 80)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl1.TabIndex = 874
        Me.LabelControl1.Text = "Returned Date"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(54, 153)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(127, 30)
        Me.SimpleButton1.TabIndex = 875
        Me.SimpleButton1.Text = "Print Pullout Slip"
        '
        'borrowerid
        '
        Me.borrowerid.Location = New System.Drawing.Point(479, 207)
        Me.borrowerid.Name = "borrowerid"
        Me.borrowerid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowerid.Properties.Appearance.Options.UseFont = True
        Me.borrowerid.Properties.ReadOnly = True
        Me.borrowerid.Size = New System.Drawing.Size(44, 20)
        Me.borrowerid.TabIndex = 876
        Me.borrowerid.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(295, 207)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(44, 20)
        Me.mode.TabIndex = 877
        Me.mode.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(54, 31)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(74, 15)
        Me.LabelControl11.TabIndex = 879
        Me.LabelControl11.Text = "Reference No."
        '
        'trncode
        '
        Me.trncode.EditValue = "SYSTEM GENERATED"
        Me.trncode.EnterMoveNextControl = True
        Me.trncode.Location = New System.Drawing.Point(134, 28)
        Me.trncode.Name = "trncode"
        Me.trncode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trncode.Properties.Appearance.Options.UseFont = True
        Me.trncode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trncode.Properties.ReadOnly = True
        Me.trncode.Size = New System.Drawing.Size(204, 22)
        Me.trncode.TabIndex = 878
        '
        'seriesno
        '
        Me.seriesno.Location = New System.Drawing.Point(295, 253)
        Me.seriesno.Name = "seriesno"
        Me.seriesno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seriesno.Properties.Appearance.Options.UseFont = True
        Me.seriesno.Properties.ReadOnly = True
        Me.seriesno.Size = New System.Drawing.Size(44, 20)
        Me.seriesno.TabIndex = 880
        Me.seriesno.Visible = False
        '
        'yeartrn
        '
        Me.yeartrn.Location = New System.Drawing.Point(245, 253)
        Me.yeartrn.Name = "yeartrn"
        Me.yeartrn.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yeartrn.Properties.Appearance.Options.UseFont = True
        Me.yeartrn.Properties.ReadOnly = True
        Me.yeartrn.Size = New System.Drawing.Size(44, 20)
        Me.yeartrn.TabIndex = 881
        Me.yeartrn.Visible = False
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(245, 207)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(44, 20)
        Me.officeid.TabIndex = 882
        Me.officeid.Visible = False
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = ""
        Me.txtOffice.EnterMoveNextControl = True
        Me.txtOffice.Location = New System.Drawing.Point(135, 125)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOffice.Properties.ReadOnly = True
        Me.txtOffice.Size = New System.Drawing.Size(222, 22)
        Me.txtOffice.TabIndex = 883
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(97, 128)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 884
        Me.LabelControl2.Text = "Office"
        '
        'frmPulloutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 434)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.yeartrn)
        Me.Controls.Add(Me.seriesno)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.trncode)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.borrowerid)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtReturnedDate)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtBorrowersname)
        Me.Controls.Add(Me.txtBorrowedDate)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.cmdOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPulloutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pullout Form"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBorrowersname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBorrowedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBorrowedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReturnedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReturnedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.borrowerid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trncode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seriesno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PulloutItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtBorrowersname As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents s_grid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtBorrowedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReturnedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents borrowerid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents trncode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents seriesno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents yeartrn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOffice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
