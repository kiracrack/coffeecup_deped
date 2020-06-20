<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFFEGenerateAccountablePDF
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
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit()
        Me.banknumber = New DevExpress.XtraEditors.TextEdit()
        Me.depositID = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banknumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depositID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(496, 355)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(257, 30)
        Me.cmdOk.TabIndex = 7
        Me.cmdOk.Text = "Generate Accountable Document"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.CheckBoxes = True
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 30)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(741, 320)
        Me.ListView1.TabIndex = 696
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Properties.NullValuePrompt = "Enter keyword to search.."
        Me.txtSearch.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtSearch.Size = New System.Drawing.Size(385, 20)
        Me.txtSearch.TabIndex = 0
        '
        'banknumber
        '
        Me.banknumber.EnterMoveNextControl = True
        Me.banknumber.Location = New System.Drawing.Point(336, 151)
        Me.banknumber.Name = "banknumber"
        Me.banknumber.Size = New System.Drawing.Size(82, 20)
        Me.banknumber.TabIndex = 707
        Me.banknumber.Visible = False
        '
        'depositID
        '
        Me.depositID.EnterMoveNextControl = True
        Me.depositID.Location = New System.Drawing.Point(336, 174)
        Me.depositID.Name = "depositID"
        Me.depositID.Size = New System.Drawing.Size(82, 20)
        Me.depositID.TabIndex = 714
        Me.depositID.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 356)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Check All"
        Me.CheckEdit1.Size = New System.Drawing.Size(70, 19)
        Me.CheckEdit1.TabIndex = 723
        '
        'Em
        '
        Me.Em.Location = New System.Drawing.Point(139, 74)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(540, 218)
        Me.Em.TabIndex = 724
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.Em.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.FixedLine.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FixedLine.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupPanel.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HorzLine.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.Preview.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Preview.Options.UseBorderColor = True
        Me.GridView1.Appearance.Row.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView1.Appearance.Row.Options.UseBorderColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.RowSeparator.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.RowSeparator.Options.UseBorderColor = True
        Me.GridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.TopNewRow.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.TopNewRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.VertLine.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.VertLine.Options.UseBorderColor = True
        Me.GridView1.Appearance.ViewCaption.BorderColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ViewCaption.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridView1.AppearancePrint.Lines.BorderColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Lines.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.OddRow.BorderColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.OddRow.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.Preview.BorderColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Preview.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.Row.BorderColor = System.Drawing.Color.Black
        Me.GridView1.AppearancePrint.Row.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.GridView1.AppearancePrint.Row.Options.UseBorderColor = True
        Me.GridView1.AppearancePrint.Row.Options.UseFont = True
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsPrint.UsePrintStyles = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "UltraFlat"
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
        'frmFFEGenerateAccountablePDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 391)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.depositID)
        Me.Controls.Add(Me.banknumber)
        Me.Controls.Add(Me.ListView1)
        Me.MinimumSize = New System.Drawing.Size(680, 413)
        Me.Name = "frmFFEGenerateAccountablePDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Request Approved"
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banknumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depositID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents banknumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents depositID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
