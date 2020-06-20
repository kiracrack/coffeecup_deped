<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportGenerator
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lblstatus = New DevExpress.XtraBars.BarButtonItem()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtReportType = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvReportType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.date_to = New DevExpress.XtraEditors.DateEdit()
        Me.date_from = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtReportTemplate = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridOffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.reportype = New DevExpress.XtraEditors.TextEdit()
        Me.txtquery = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtReportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReportType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_to.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_to.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_from.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_from.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtquery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose, Me.lblstatus})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClose)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'cmdClose
        '
        Me.cmdClose.Caption = "Close Window"
        Me.cmdClose.Id = 0
        Me.cmdClose.Name = "cmdClose"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(895, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 544)
        Me.barDockControlBottom.Size = New System.Drawing.Size(895, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 522)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(895, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 522)
        '
        'lblstatus
        '
        Me.lblstatus.Caption = "Ready"
        Me.lblstatus.Id = 5
        Me.lblstatus.Name = "lblstatus"
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(895, 420)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview1})
        '
        'gridview1
        '
        Me.gridview1.GridControl = Me.Em
        Me.gridview1.Name = "gridview1"
        Me.gridview1.OptionsBehavior.Editable = False
        Me.gridview1.OptionsView.ColumnAutoWidth = False
        Me.gridview1.OptionsView.RowAutoHeight = True
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 22)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtReportType)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SimpleButton2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.date_to)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.date_from)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl50)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl51)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SimpleButton1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtReportTemplate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl21)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.reportype)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtquery)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.id)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(895, 522)
        Me.SplitContainerControl1.SplitterPosition = 97
        Me.SplitContainerControl1.TabIndex = 9
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'txtReportType
        '
        Me.txtReportType.EditValue = ""
        Me.txtReportType.EnterMoveNextControl = True
        Me.txtReportType.Location = New System.Drawing.Point(158, 12)
        Me.txtReportType.Name = "txtReportType"
        Me.txtReportType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtReportType.Properties.DisplayMember = "Description"
        Me.txtReportType.Properties.NullText = ""
        Me.txtReportType.Properties.ValueMember = "Description"
        Me.txtReportType.Properties.View = Me.gvReportType
        Me.txtReportType.Size = New System.Drawing.Size(213, 20)
        Me.txtReportType.TabIndex = 632
        '
        'gvReportType
        '
        Me.gvReportType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvReportType.Name = "gvReportType"
        Me.gvReportType.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvReportType.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(83, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.TabIndex = 633
        Me.LabelControl1.Text = "Report Type"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(584, 33)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(105, 46)
        Me.SimpleButton2.TabIndex = 631
        Me.SimpleButton2.Text = "Export to Excel"
        '
        'date_to
        '
        Me.date_to.EditValue = ""
        Me.date_to.Enabled = False
        Me.date_to.Location = New System.Drawing.Point(342, 58)
        Me.date_to.Name = "date_to"
        Me.date_to.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.date_to.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.date_to.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.date_to.Properties.DisplayFormat.FormatString = "MMMM d, yyyy"
        Me.date_to.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.date_to.Properties.EditFormat.FormatString = "MMMM d, yyyy"
        Me.date_to.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.date_to.Properties.Mask.EditMask = "MMMM d, yyyy"
        Me.date_to.Size = New System.Drawing.Size(148, 20)
        Me.date_to.TabIndex = 628
        '
        'date_from
        '
        Me.date_from.EditValue = ""
        Me.date_from.Enabled = False
        Me.date_from.Location = New System.Drawing.Point(158, 58)
        Me.date_from.Name = "date_from"
        Me.date_from.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.date_from.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.date_from.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.date_from.Properties.DisplayFormat.FormatString = "MMMM d, yyyy"
        Me.date_from.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.date_from.Properties.EditFormat.FormatString = "MMMM d, yyyy"
        Me.date_from.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.date_from.Properties.Mask.EditMask = "MMMM d, yyyy"
        Me.date_from.Size = New System.Drawing.Size(148, 20)
        Me.date_from.TabIndex = 627
        '
        'LabelControl50
        '
        Me.LabelControl50.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl50.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl50.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl50.Location = New System.Drawing.Point(37, 61)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(115, 13)
        Me.LabelControl50.TabIndex = 630
        Me.LabelControl50.Text = "Select Date Query From"
        '
        'LabelControl51
        '
        Me.LabelControl51.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl51.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl51.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl51.Location = New System.Drawing.Point(318, 61)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl51.TabIndex = 629
        Me.LabelControl51.Text = "To"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(496, 33)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(84, 46)
        Me.SimpleButton1.TabIndex = 626
        Me.SimpleButton1.Text = "Generate"
        '
        'txtReportTemplate
        '
        Me.txtReportTemplate.EditValue = ""
        Me.txtReportTemplate.EnterMoveNextControl = True
        Me.txtReportTemplate.Location = New System.Drawing.Point(158, 35)
        Me.txtReportTemplate.Name = "txtReportTemplate"
        Me.txtReportTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtReportTemplate.Properties.DisplayMember = "Report Template"
        Me.txtReportTemplate.Properties.NullText = ""
        Me.txtReportTemplate.Properties.ValueMember = "Report Template"
        Me.txtReportTemplate.Properties.View = Me.GridOffice
        Me.txtReportTemplate.Size = New System.Drawing.Size(332, 20)
        Me.txtReportTemplate.TabIndex = 624
        '
        'GridOffice
        '
        Me.GridOffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridOffice.Name = "GridOffice"
        Me.GridOffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridOffice.OptionsView.ShowGroupPanel = False
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Location = New System.Drawing.Point(18, 38)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl21.TabIndex = 625
        Me.LabelControl21.Text = "Select Report Template"
        '
        'reportype
        '
        Me.reportype.EnterMoveNextControl = True
        Me.reportype.Location = New System.Drawing.Point(471, 14)
        Me.reportype.Name = "reportype"
        Me.reportype.Size = New System.Drawing.Size(51, 20)
        Me.reportype.TabIndex = 612
        Me.reportype.Visible = False
        '
        'txtquery
        '
        Me.txtquery.EnterMoveNextControl = True
        Me.txtquery.Location = New System.Drawing.Point(528, 14)
        Me.txtquery.Name = "txtquery"
        Me.txtquery.Size = New System.Drawing.Size(51, 20)
        Me.txtquery.TabIndex = 611
        Me.txtquery.Visible = False
        '
        'id
        '
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(585, 14)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(51, 20)
        Me.id.TabIndex = 610
        Me.id.Visible = False
        '
        'frmReportGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 544)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReportGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Generator"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtReportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReportType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_to.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_to.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_from.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_from.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtquery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents lblstatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtReportTemplate As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridOffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtquery As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents date_to As DevExpress.XtraEditors.DateEdit
    Friend WithEvents date_from As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtReportType As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvReportType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents reportype As DevExpress.XtraEditors.TextEdit
End Class
