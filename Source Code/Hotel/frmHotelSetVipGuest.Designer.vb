<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelSetVipGuest
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
        Me.guestid = New DevExpress.XtraEditors.TextEdit()
        Me.txtCardNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtcreditlimit = New DevExpress.XtraEditors.TextEdit()
        Me.txtGuest = New DevExpress.XtraEditors.TextEdit()
        Me.txtviptype = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.vipcode = New DevExpress.XtraEditors.TextEdit()
        Me.ckVipGuest = New System.Windows.Forms.CheckBox()
        CType(Me.guestid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCardNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcreditlimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGuest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtviptype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vipcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'guestid
        '
        Me.guestid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guestid.EnterMoveNextControl = True
        Me.guestid.Location = New System.Drawing.Point(380, 164)
        Me.guestid.Name = "guestid"
        Me.guestid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guestid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.guestid.Properties.Appearance.Options.UseFont = True
        Me.guestid.Properties.Appearance.Options.UseForeColor = True
        Me.guestid.Properties.Appearance.Options.UseTextOptions = True
        Me.guestid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.guestid.Properties.ReadOnly = True
        Me.guestid.Size = New System.Drawing.Size(43, 22)
        Me.guestid.TabIndex = 100
        Me.guestid.Visible = False
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Enabled = False
        Me.txtCardNumber.EnterMoveNextControl = True
        Me.txtCardNumber.Location = New System.Drawing.Point(160, 95)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCardNumber.Properties.Appearance.Options.UseFont = True
        Me.txtCardNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCardNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCardNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCardNumber.Size = New System.Drawing.Size(202, 22)
        Me.txtCardNumber.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(88, 25)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 15)
        Me.LabelControl4.TabIndex = 392
        Me.LabelControl4.Text = "Guest Name"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl7.Location = New System.Drawing.Point(91, 124)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(62, 15)
        Me.LabelControl7.TabIndex = 394
        Me.LabelControl7.Text = "Credit Limit"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(86, 98)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 15)
        Me.LabelControl3.TabIndex = 393
        Me.LabelControl3.Text = "Vip Card No."
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
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(160, 147)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(107, 26)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        '
        'txtcreditlimit
        '
        Me.txtcreditlimit.EditValue = ""
        Me.txtcreditlimit.Enabled = False
        Me.txtcreditlimit.Location = New System.Drawing.Point(160, 121)
        Me.txtcreditlimit.Name = "txtcreditlimit"
        Me.txtcreditlimit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcreditlimit.Properties.Appearance.Options.UseFont = True
        Me.txtcreditlimit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtcreditlimit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtcreditlimit.Properties.Mask.EditMask = "n"
        Me.txtcreditlimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtcreditlimit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtcreditlimit.Properties.ReadOnly = True
        Me.txtcreditlimit.Size = New System.Drawing.Size(107, 22)
        Me.txtcreditlimit.TabIndex = 2
        '
        'txtGuest
        '
        Me.txtGuest.Location = New System.Drawing.Point(160, 22)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGuest.Properties.Appearance.Options.UseFont = True
        Me.txtGuest.Properties.ReadOnly = True
        Me.txtGuest.Size = New System.Drawing.Size(278, 22)
        Me.txtGuest.TabIndex = 1
        '
        'txtviptype
        '
        Me.txtviptype.EditValue = ""
        Me.txtviptype.Enabled = False
        Me.txtviptype.EnterMoveNextControl = True
        Me.txtviptype.Location = New System.Drawing.Point(160, 70)
        Me.txtviptype.Name = "txtviptype"
        Me.txtviptype.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtviptype.Properties.Appearance.Options.UseFont = True
        Me.txtviptype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtviptype.Properties.DisplayMember = "Description"
        Me.txtviptype.Properties.ImmediatePopup = True
        Me.txtviptype.Properties.NullText = ""
        Me.txtviptype.Properties.ValueMember = "Description"
        Me.txtviptype.Properties.View = Me.Gridview1
        Me.txtviptype.Size = New System.Drawing.Size(202, 22)
        Me.txtviptype.TabIndex = 0
        '
        'Gridview1
        '
        Me.Gridview1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Gridview1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(99, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 15)
        Me.LabelControl1.TabIndex = 688
        Me.LabelControl1.Text = "Card Type"
        '
        'vipcode
        '
        Me.vipcode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.vipcode.EnterMoveNextControl = True
        Me.vipcode.Location = New System.Drawing.Point(432, 164)
        Me.vipcode.Name = "vipcode"
        Me.vipcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.vipcode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.vipcode.Properties.Appearance.Options.UseFont = True
        Me.vipcode.Properties.Appearance.Options.UseForeColor = True
        Me.vipcode.Properties.Appearance.Options.UseTextOptions = True
        Me.vipcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vipcode.Properties.ReadOnly = True
        Me.vipcode.Size = New System.Drawing.Size(43, 22)
        Me.vipcode.TabIndex = 689
        Me.vipcode.Visible = False
        '
        'ckVipGuest
        '
        Me.ckVipGuest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckVipGuest.Location = New System.Drawing.Point(160, 50)
        Me.ckVipGuest.Name = "ckVipGuest"
        Me.ckVipGuest.Size = New System.Drawing.Size(109, 19)
        Me.ckVipGuest.TabIndex = 696
        Me.ckVipGuest.Text = "Set as VIP Guest"
        Me.ckVipGuest.UseVisualStyleBackColor = False
        '
        'frmHotelSetVipGuest
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(499, 198)
        Me.Controls.Add(Me.ckVipGuest)
        Me.Controls.Add(Me.vipcode)
        Me.Controls.Add(Me.txtviptype)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtcreditlimit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtGuest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelSetVipGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Vip Guest"
        CType(Me.guestid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCardNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcreditlimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGuest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtviptype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vipcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents guestid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCardNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtcreditlimit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGuest As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtviptype As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents vipcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckVipGuest As System.Windows.Forms.CheckBox
End Class
