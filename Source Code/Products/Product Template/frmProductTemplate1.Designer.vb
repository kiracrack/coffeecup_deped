<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductTemplate1
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
        Me.productid = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtprocat = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.combogrid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.catid = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtitem = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ckUnit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSaveParticular = New DevExpress.XtraEditors.SimpleButton()
        Me.selfrom = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtProductArticle = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridarticle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.subcatid = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodeName = New DevExpress.XtraEditors.TextEdit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprocat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtitem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.selfrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductArticle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridarticle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subcatid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.Location = New System.Drawing.Point(144, 65)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.productid.Properties.Appearance.Options.UseBackColor = True
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseForeColor = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.productid.Properties.Mask.BeepOnError = True
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(184, 20)
        Me.productid.TabIndex = 0
        '
        'txtprocat
        '
        Me.txtprocat.EditValue = ""
        Me.txtprocat.EnterMoveNextControl = True
        Me.txtprocat.Location = New System.Drawing.Point(144, 88)
        Me.txtprocat.Name = "txtprocat"
        Me.txtprocat.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprocat.Properties.Appearance.Options.UseFont = True
        Me.txtprocat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtprocat.Properties.DisplayMember = "Select Category"
        Me.txtprocat.Properties.ImmediatePopup = True
        Me.txtprocat.Properties.NullText = ""
        Me.txtprocat.Properties.PopupView = Me.combogrid
        Me.txtprocat.Properties.ValueMember = "CATID"
        Me.txtprocat.Size = New System.Drawing.Size(289, 20)
        Me.txtprocat.TabIndex = 1
        '
        'combogrid
        '
        Me.combogrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.combogrid.Name = "combogrid"
        Me.combogrid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.combogrid.OptionsView.ShowGroupPanel = False
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(34, 138)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl17.TabIndex = 524
        Me.LabelControl17.Text = "Product Description"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(60, 91)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 526
        Me.LabelControl1.Text = "Item Category*"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(79, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl2.TabIndex = 527
        Me.LabelControl2.Text = "Item Code*"
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(8, 466)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(38, 20)
        Me.mode.TabIndex = 528
        Me.mode.Visible = False
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.Location = New System.Drawing.Point(12, 230)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.Appearance.Options.UseTextOptions = True
        Me.catid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.catid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.catid.Properties.Mask.BeepOnError = True
        Me.catid.Properties.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(33, 22)
        Me.catid.TabIndex = 529
        Me.catid.Visible = False
        '
        'txtitem
        '
        Me.txtitem.EnterMoveNextControl = True
        Me.txtitem.Location = New System.Drawing.Point(144, 135)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitem.Properties.Appearance.Options.UseFont = True
        Me.txtitem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtitem.Size = New System.Drawing.Size(288, 20)
        Me.txtitem.TabIndex = 2
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(148, 36)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(260, 13)
        Me.LabelControl7.TabIndex = 556
        Me.LabelControl7.Text = "This form is allow user add and edit particular item"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(148, 14)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(181, 19)
        Me.LabelControl5.TabIndex = 555
        Me.LabelControl5.Text = "Product Item Information"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(146, 39)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(287, 16)
        Me.LabelControl8.TabIndex = 554
        Me.LabelControl8.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(86, 209)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 558
        Me.LabelControl3.Text = "Item Unit*"
        '
        'txtUnit
        '
        Me.txtUnit.EditValue = ""
        Me.txtUnit.Location = New System.Drawing.Point(144, 206)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtUnit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtUnit.Size = New System.Drawing.Size(102, 20)
        Me.txtUnit.TabIndex = 5
        Me.txtUnit.ToolTip = "Shortcut Key (F11)"
        '
        'ckUnit
        '
        Me.ckUnit.EditValue = True
        Me.ckUnit.Location = New System.Drawing.Point(144, 184)
        Me.ckUnit.Name = "ckUnit"
        Me.ckUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckUnit.Properties.Appearance.Options.UseFont = True
        Me.ckUnit.Properties.Caption = "Use existing unit"
        Me.ckUnit.Size = New System.Drawing.Size(106, 19)
        Me.ckUnit.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(255, 183)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(179, 43)
        Me.LabelControl4.TabIndex = 561
        Me.LabelControl4.Text = "Note: Please use proper Particular name and unit to get proper inventory summary"
        '
        'cmdSaveParticular
        '
        Me.cmdSaveParticular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSaveParticular.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveParticular.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveParticular.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveParticular.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSaveParticular.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveParticular.Appearance.Options.UseBackColor = True
        Me.cmdSaveParticular.Appearance.Options.UseFont = True
        Me.cmdSaveParticular.Appearance.Options.UseForeColor = True
        Me.cmdSaveParticular.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSaveParticular.Location = New System.Drawing.Point(172, 252)
        Me.cmdSaveParticular.Name = "cmdSaveParticular"
        Me.cmdSaveParticular.Size = New System.Drawing.Size(185, 29)
        Me.cmdSaveParticular.TabIndex = 6
        Me.cmdSaveParticular.Text = "Save Product Information"
        '
        'selfrom
        '
        Me.selfrom.EditValue = ""
        Me.selfrom.Location = New System.Drawing.Point(13, 429)
        Me.selfrom.Name = "selfrom"
        Me.selfrom.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.selfrom.Properties.Appearance.Options.UseFont = True
        Me.selfrom.Properties.Appearance.Options.UseTextOptions = True
        Me.selfrom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.selfrom.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.selfrom.Properties.Mask.BeepOnError = True
        Me.selfrom.Properties.ReadOnly = True
        Me.selfrom.Size = New System.Drawing.Size(33, 22)
        Me.selfrom.TabIndex = 628
        Me.selfrom.Visible = False
        '
        'txtProductArticle
        '
        Me.txtProductArticle.EditValue = ""
        Me.txtProductArticle.EnterMoveNextControl = True
        Me.txtProductArticle.Location = New System.Drawing.Point(144, 111)
        Me.txtProductArticle.Name = "txtProductArticle"
        Me.txtProductArticle.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductArticle.Properties.Appearance.Options.UseFont = True
        Me.txtProductArticle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProductArticle.Properties.DisplayMember = "Select Article"
        Me.txtProductArticle.Properties.ImmediatePopup = True
        Me.txtProductArticle.Properties.NullText = ""
        Me.txtProductArticle.Properties.PopupView = Me.gridarticle
        Me.txtProductArticle.Properties.ValueMember = "subcatid"
        Me.txtProductArticle.Size = New System.Drawing.Size(289, 20)
        Me.txtProductArticle.TabIndex = 629
        '
        'gridarticle
        '
        Me.gridarticle.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridarticle.Name = "gridarticle"
        Me.gridarticle.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridarticle.OptionsView.ShowGroupPanel = False
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(66, 114)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.HyperlinkLabelControl1.TabIndex = 631
        Me.HyperlinkLabelControl1.Text = "Product Article"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.product_icon1
        Me.PanelControl1.Location = New System.Drawing.Point(76, 5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl1.TabIndex = 553
        '
        'subcatid
        '
        Me.subcatid.EditValue = ""
        Me.subcatid.Location = New System.Drawing.Point(51, 230)
        Me.subcatid.Name = "subcatid"
        Me.subcatid.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.subcatid.Properties.Appearance.Options.UseFont = True
        Me.subcatid.Properties.Appearance.Options.UseTextOptions = True
        Me.subcatid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.subcatid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.subcatid.Properties.Mask.BeepOnError = True
        Me.subcatid.Properties.ReadOnly = True
        Me.subcatid.Size = New System.Drawing.Size(33, 22)
        Me.subcatid.TabIndex = 632
        Me.subcatid.Visible = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(77, 161)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl6.TabIndex = 634
        Me.LabelControl6.Text = "Code Name"
        '
        'txtCodeName
        '
        Me.txtCodeName.EnterMoveNextControl = True
        Me.txtCodeName.Location = New System.Drawing.Point(144, 158)
        Me.txtCodeName.Name = "txtCodeName"
        Me.txtCodeName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeName.Properties.Appearance.Options.UseFont = True
        Me.txtCodeName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodeName.Size = New System.Drawing.Size(106, 20)
        Me.txtCodeName.TabIndex = 3
        '
        'frmProductTemplate1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 295)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtCodeName)
        Me.Controls.Add(Me.subcatid)
        Me.Controls.Add(Me.HyperlinkLabelControl1)
        Me.Controls.Add(Me.txtProductArticle)
        Me.Controls.Add(Me.selfrom)
        Me.Controls.Add(Me.cmdSaveParticular)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.ckUnit)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.txtprocat)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.txtUnit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductTemplate1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Item Information"
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprocat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtitem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.selfrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductArticle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridarticle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subcatid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents productid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtprocat As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents combogrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents catid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtitem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ckUnit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSaveParticular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents selfrom As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtProductArticle As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gridarticle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents subcatid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodeName As DevExpress.XtraEditors.TextEdit
End Class
