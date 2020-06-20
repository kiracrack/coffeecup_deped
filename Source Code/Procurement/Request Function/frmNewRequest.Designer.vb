<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewRequest
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.rid = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPriority = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.txtname = New DevExpress.XtraBars.BarStaticItem()
        Me.txtposition = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdtrequest = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtoffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcompoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.potypeid = New DevExpress.XtraEditors.LabelControl()
        Me.txtPurchaseType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.s_type = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdetails = New DevExpress.XtraEditors.MemoEdit()
        Me.txtrequestby = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.s_grid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtrequest.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtrequest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurchaseType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl2.Location = New System.Drawing.Point(68, 119)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl2.TabIndex = 505
        Me.LabelControl2.Text = "Request by"
        '
        'pid
        '
        Me.pid.EditValue = "AUTO GENERATE"
        Me.pid.Location = New System.Drawing.Point(134, 70)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.pid.Properties.Appearance.Options.UseBackColor = True
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseForeColor = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(154, 20)
        Me.pid.TabIndex = 507
        '
        'rid
        '
        Me.rid.Location = New System.Drawing.Point(651, 117)
        Me.rid.Name = "rid"
        Me.rid.Size = New System.Drawing.Size(12, 13)
        Me.rid.TabIndex = 509
        Me.rid.Text = "rid"
        Me.rid.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(89, 267)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 559
        Me.LabelControl3.Text = "Priority"
        '
        'txtPriority
        '
        Me.txtPriority.EditValue = "Normal"
        Me.txtPriority.Location = New System.Drawing.Point(134, 264)
        Me.txtPriority.MenuManager = Me.BarManager1
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPriority.Properties.Appearance.Options.UseFont = True
        Me.txtPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPriority.Properties.Items.AddRange(New Object() {"Low", "Normal", "High"})
        Me.txtPriority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPriority.Size = New System.Drawing.Size(120, 20)
        Me.txtPriority.TabIndex = 558
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem1, Me.txtname, Me.txtposition, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(521, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 336)
        Me.barDockControlBottom.Size = New System.Drawing.Size(521, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 336)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(521, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 336)
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.BarLargeButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'txtname
        '
        Me.txtname.Caption = "Winter Bugahod"
        Me.txtname.Id = 3
        Me.txtname.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtname.ItemAppearance.Normal.Options.UseFont = True
        Me.txtname.Name = "txtname"
        Me.txtname.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'txtposition
        '
        Me.txtposition.Caption = "Position"
        Me.txtposition.Id = 5
        Me.txtposition.Name = "txtposition"
        Me.txtposition.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&Reset Fields"
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdaction.Location = New System.Drawing.Point(134, 290)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(222, 30)
        Me.cmdaction.TabIndex = 557
        Me.cmdaction.Text = "Create Request "
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(65, 73)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl4.TabIndex = 514
        Me.LabelControl4.Text = "Request No"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl8.Location = New System.Drawing.Point(133, 45)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(308, 13)
        Me.LabelControl8.TabIndex = 556
        Me.LabelControl8.Text = "This form is allow purchaser to create new purchase request"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(133, 25)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(134, 19)
        Me.LabelControl9.TabIndex = 555
        Me.LabelControl9.Text = "New Request Form"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.accessories_text_editor_2
        Me.PanelControl1.Location = New System.Drawing.Point(61, 14)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl1.TabIndex = 553
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(131, 51)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(335, 13)
        Me.LabelControl10.TabIndex = 554
        Me.LabelControl10.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'txtdtrequest
        '
        Me.txtdtrequest.EditValue = Nothing
        Me.txtdtrequest.Location = New System.Drawing.Point(134, 240)
        Me.txtdtrequest.Name = "txtdtrequest"
        Me.txtdtrequest.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdtrequest.Properties.Appearance.Options.UseFont = True
        Me.txtdtrequest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtdtrequest.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtdtrequest.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtdtrequest.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtdtrequest.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtdtrequest.Size = New System.Drawing.Size(223, 20)
        Me.txtdtrequest.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(56, 243)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl6.TabIndex = 538
        Me.LabelControl6.Text = "Date Request"
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(652, 91)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(54, 20)
        Me.officeid.TabIndex = 530
        Me.officeid.Visible = False
        '
        'txtoffice
        '
        Me.txtoffice.EditValue = ""
        Me.txtoffice.Location = New System.Drawing.Point(134, 93)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtoffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtoffice.Properties.Appearance.Options.UseFont = True
        Me.txtoffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtoffice.Properties.NullText = ""
        Me.txtoffice.Properties.View = Me.gridcompoffice
        Me.txtoffice.Size = New System.Drawing.Size(223, 20)
        Me.txtoffice.TabIndex = 0
        '
        'gridcompoffice
        '
        Me.gridcompoffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcompoffice.Name = "gridcompoffice"
        Me.gridcompoffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridcompoffice.OptionsView.ShowGroupPanel = False
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblOffice.Location = New System.Drawing.Point(38, 96)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(87, 14)
        Me.lblOffice.TabIndex = 529
        Me.lblOffice.Text = "Select "
        '
        'potypeid
        '
        Me.potypeid.Location = New System.Drawing.Point(652, 163)
        Me.potypeid.Name = "potypeid"
        Me.potypeid.Size = New System.Drawing.Size(42, 13)
        Me.potypeid.TabIndex = 521
        Me.potypeid.Text = "potypeid"
        Me.potypeid.Visible = False
        '
        'txtPurchaseType
        '
        Me.txtPurchaseType.EditValue = ""
        Me.txtPurchaseType.Location = New System.Drawing.Point(134, 139)
        Me.txtPurchaseType.Name = "txtPurchaseType"
        Me.txtPurchaseType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPurchaseType.Properties.Appearance.Options.UseFont = True
        Me.txtPurchaseType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.txtPurchaseType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPurchaseType.Properties.DisplayMember = "Request Type"
        Me.txtPurchaseType.Properties.ImmediatePopup = True
        Me.txtPurchaseType.Properties.NullText = ""
        Me.txtPurchaseType.Properties.ValueMember = "Request Type"
        Me.txtPurchaseType.Properties.View = Me.s_type
        Me.txtPurchaseType.Size = New System.Drawing.Size(222, 20)
        Me.txtPurchaseType.TabIndex = 3
        '
        's_type
        '
        Me.s_type.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.s_type.Name = "s_type"
        Me.s_type.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.s_type.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl5.Location = New System.Drawing.Point(57, 142)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl5.TabIndex = 520
        Me.LabelControl5.Text = "Request Type"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(18, 166)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl1.TabIndex = 516
        Me.LabelControl1.Text = "Request Justification"
        '
        'txtdetails
        '
        Me.txtdetails.EditValue = ""
        Me.txtdetails.Location = New System.Drawing.Point(134, 162)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdetails.Properties.Appearance.Options.UseFont = True
        Me.txtdetails.Size = New System.Drawing.Size(367, 74)
        Me.txtdetails.TabIndex = 4
        '
        'txtrequestby
        '
        Me.txtrequestby.EditValue = ""
        Me.txtrequestby.Location = New System.Drawing.Point(134, 116)
        Me.txtrequestby.Name = "txtrequestby"
        Me.txtrequestby.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtrequestby.Properties.Appearance.Options.UseFont = True
        Me.txtrequestby.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtrequestby.Properties.DisplayMember = "Fullname"
        Me.txtrequestby.Properties.NullText = ""
        Me.txtrequestby.Properties.ValueMember = "Fullname"
        Me.txtrequestby.Properties.View = Me.s_grid
        Me.txtrequestby.Size = New System.Drawing.Size(223, 20)
        Me.txtrequestby.TabIndex = 1
        '
        's_grid
        '
        Me.s_grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.s_grid.Name = "s_grid"
        Me.s_grid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.s_grid.OptionsView.ShowGroupPanel = False
        '
        'Bar1
        '
        Me.Bar1.BarName = "Status bar"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Status bar"
        '
        'frmNewRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 336)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtPriority)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.txtrequestby)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.rid)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtdetails)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtdtrequest)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtPurchaseType)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.potypeid)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.lblOffice)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNewRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Request Form"
        Me.TopMost = True
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtrequest.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtrequest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurchaseType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPurchaseType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents s_type As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents potypeid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtrequestby As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents s_grid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtoffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtname As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txtdtrequest As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtposition As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridcompoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPriority As DevExpress.XtraEditors.ComboBoxEdit
End Class
