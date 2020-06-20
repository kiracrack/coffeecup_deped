<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFFEAccountabilityLog
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
        Me.g_Stocks = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ffecode = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdReturned = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintMemoradumOfReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gAccountable = New DevExpress.XtraGrid.GridControl()
        Me.gvAccountable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.g_Stocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ffecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gAccountable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAccountable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'g_Stocks
        '
        Me.g_Stocks.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_Stocks.Name = "g_Stocks"
        Me.g_Stocks.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_Stocks.OptionsView.ShowGroupPanel = False
        '
        'ffecode
        '
        Me.ffecode.EditValue = ""
        Me.ffecode.EnterMoveNextControl = True
        Me.ffecode.Location = New System.Drawing.Point(116, 80)
        Me.ffecode.Name = "ffecode"
        Me.ffecode.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.ffecode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ffecode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ffecode.Properties.Appearance.Options.UseBackColor = True
        Me.ffecode.Properties.Appearance.Options.UseFont = True
        Me.ffecode.Properties.Appearance.Options.UseForeColor = True
        Me.ffecode.Properties.Appearance.Options.UseTextOptions = True
        Me.ffecode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ffecode.Properties.ReadOnly = True
        Me.ffecode.Properties.ValidateOnEnterKey = True
        Me.ffecode.Size = New System.Drawing.Size(112, 20)
        Me.ffecode.TabIndex = 635
        Me.ffecode.Visible = False
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(844, 461)
        Me.Em.TabIndex = 655
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdReturned, Me.PrintMemoradumOfReceiptToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.DisplayFormatToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(229, 98)
        '
        'cmdReturned
        '
        Me.cmdReturned.Image = Global.Coffeecup.My.Resources.Resources.door_open_in
        Me.cmdReturned.Name = "cmdReturned"
        Me.cmdReturned.Size = New System.Drawing.Size(228, 22)
        Me.cmdReturned.Text = "Return Accountable Unit"
        '
        'PrintMemoradumOfReceiptToolStripMenuItem
        '
        Me.PrintMemoradumOfReceiptToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.Printer__2_
        Me.PrintMemoradumOfReceiptToolStripMenuItem.Name = "PrintMemoradumOfReceiptToolStripMenuItem"
        Me.PrintMemoradumOfReceiptToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.PrintMemoradumOfReceiptToolStripMenuItem.Text = "Print Memoradum of Receipt"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Inventory"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(225, 6)
        '
        'DisplayFormatToolStripMenuItem
        '
        Me.DisplayFormatToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.DisplayFormatToolStripMenuItem.Name = "DisplayFormatToolStripMenuItem"
        Me.DisplayFormatToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.DisplayFormatToolStripMenuItem.Text = "View Appearance"
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "Total", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'gAccountable
        '
        Me.gAccountable.Location = New System.Drawing.Point(152, 121)
        Me.gAccountable.MainView = Me.gvAccountable
        Me.gAccountable.Name = "gAccountable"
        Me.gAccountable.Size = New System.Drawing.Size(540, 218)
        Me.gAccountable.TabIndex = 725
        Me.gAccountable.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAccountable})
        Me.gAccountable.Visible = False
        '
        'gvAccountable
        '
        Me.gvAccountable.Appearance.EvenRow.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.FixedLine.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.FixedLine.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.GroupPanel.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.GroupPanel.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.GroupRow.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvAccountable.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvAccountable.Appearance.HorzLine.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.HorzLine.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.OddRow.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.Preview.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.Preview.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.Row.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gvAccountable.Appearance.Row.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.Row.Options.UseFont = True
        Me.gvAccountable.Appearance.RowSeparator.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.RowSeparator.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.TopNewRow.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.TopNewRow.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.VertLine.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.VertLine.Options.UseBorderColor = True
        Me.gvAccountable.Appearance.ViewCaption.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.Appearance.ViewCaption.Options.UseBorderColor = True
        Me.gvAccountable.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.gvAccountable.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.gvAccountable.AppearancePrint.Lines.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.AppearancePrint.Lines.Options.UseBorderColor = True
        Me.gvAccountable.AppearancePrint.OddRow.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.AppearancePrint.OddRow.Options.UseBorderColor = True
        Me.gvAccountable.AppearancePrint.Preview.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.AppearancePrint.Preview.Options.UseBorderColor = True
        Me.gvAccountable.AppearancePrint.Row.BorderColor = System.Drawing.Color.Black
        Me.gvAccountable.AppearancePrint.Row.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.gvAccountable.AppearancePrint.Row.Options.UseBorderColor = True
        Me.gvAccountable.AppearancePrint.Row.Options.UseFont = True
        Me.gvAccountable.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gvAccountable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.gvAccountable.GridControl = Me.gAccountable
        Me.gvAccountable.Name = "gvAccountable"
        Me.gvAccountable.OptionsBehavior.Editable = False
        Me.gvAccountable.OptionsCustomization.AllowColumnMoving = False
        Me.gvAccountable.OptionsCustomization.AllowColumnResizing = False
        Me.gvAccountable.OptionsCustomization.AllowGroup = False
        Me.gvAccountable.OptionsMenu.EnableColumnMenu = False
        Me.gvAccountable.OptionsPrint.UsePrintStyles = False
        Me.gvAccountable.OptionsView.ShowGroupPanel = False
        Me.gvAccountable.PaintStyleName = "UltraFlat"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceCell.Options.UseBorderColor = True
        Me.GridColumn1.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseBorderColor = True
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceCell.Options.UseBorderColor = True
        Me.GridColumn2.AppearanceHeader.BorderColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceHeader.Options.UseBorderColor = True
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'frmFFEAccountabilityLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 461)
        Me.Controls.Add(Me.gAccountable)
        Me.Controls.Add(Me.ffecode)
        Me.Controls.Add(Me.Em)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFFEAccountabilityLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unit Information and Accountable Person"
        CType(Me.g_Stocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ffecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gAccountable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAccountable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents g_Stocks As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ffecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdReturned As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DisplayFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintMemoradumOfReceiptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gAccountable As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAccountable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
