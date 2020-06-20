<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelGuestInformation
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
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.txtCountry = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtGuest = New DevExpress.XtraEditors.TextEdit()
        Me.txtBirthdate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContactNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.ProfilePic = New DevExpress.XtraEditors.PictureEdit()
        Me.countrycode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtGender = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtNationality = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.guestid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGuest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBirthdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBirthdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilePic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.countrycode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNationality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'guestid
        '
        Me.guestid.EnterMoveNextControl = True
        Me.guestid.Location = New System.Drawing.Point(667, 149)
        Me.guestid.Name = "guestid"
        Me.guestid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guestid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.guestid.Properties.Appearance.Options.UseFont = True
        Me.guestid.Properties.Appearance.Options.UseForeColor = True
        Me.guestid.Properties.Appearance.Options.UseTextOptions = True
        Me.guestid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.guestid.Properties.ReadOnly = True
        Me.guestid.Size = New System.Drawing.Size(55, 22)
        Me.guestid.TabIndex = 100
        Me.guestid.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(76, 152)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(42, 15)
        Me.LabelControl4.TabIndex = 392
        Me.LabelControl4.Text = "Address"
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
        Me.cmdSave.Location = New System.Drawing.Point(126, 276)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(198, 30)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Save"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(126, 149)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Size = New System.Drawing.Size(198, 22)
        Me.txtAddress.TabIndex = 3
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(667, 121)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Size = New System.Drawing.Size(55, 22)
        Me.mode.TabIndex = 400
        Me.mode.Visible = False
        '
        'txtCountry
        '
        Me.txtCountry.EditValue = ""
        Me.txtCountry.EnterMoveNextControl = True
        Me.txtCountry.Location = New System.Drawing.Point(126, 99)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCountry.Properties.Appearance.Options.UseFont = True
        Me.txtCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCountry.Properties.DisplayMember = "Country"
        Me.txtCountry.Properties.ImmediatePopup = True
        Me.txtCountry.Properties.NullText = ""
        Me.txtCountry.Properties.ValueMember = "Country"
        Me.txtCountry.Properties.View = Me.Gridview1
        Me.txtCountry.Size = New System.Drawing.Size(198, 22)
        Me.txtCountry.TabIndex = 1
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
        Me.LabelControl1.Location = New System.Drawing.Point(75, 102)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 15)
        Me.LabelControl1.TabIndex = 688
        Me.LabelControl1.Text = "Country"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(53, 77)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(65, 15)
        Me.LabelControl5.TabIndex = 695
        Me.LabelControl5.Text = "Guest Name"
        '
        'txtGuest
        '
        Me.txtGuest.Location = New System.Drawing.Point(126, 74)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGuest.Properties.Appearance.Options.UseFont = True
        Me.txtGuest.Size = New System.Drawing.Size(198, 22)
        Me.txtGuest.TabIndex = 0
        '
        'txtBirthdate
        '
        Me.txtBirthdate.EditValue = New Date(CType(0, Long))
        Me.txtBirthdate.EnterMoveNextControl = True
        Me.txtBirthdate.Location = New System.Drawing.Point(126, 124)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtBirthdate.Properties.Appearance.Options.UseFont = True
        Me.txtBirthdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBirthdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBirthdate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtBirthdate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtBirthdate.Size = New System.Drawing.Size(137, 22)
        Me.txtBirthdate.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(66, 128)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 15)
        Me.LabelControl3.TabIndex = 697
        Me.LabelControl3.Text = "Birth Date"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl6.Location = New System.Drawing.Point(80, 177)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(38, 15)
        Me.LabelControl6.TabIndex = 699
        Me.LabelControl6.Text = "Gender"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl8.Location = New System.Drawing.Point(60, 204)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(58, 15)
        Me.LabelControl8.TabIndex = 701
        Me.LabelControl8.Text = "Nationality"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(29, 229)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(89, 15)
        Me.LabelControl2.TabIndex = 703
        Me.LabelControl2.Text = "Contact Number"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(126, 225)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContactNumber.Properties.Appearance.Options.UseFont = True
        Me.txtContactNumber.Size = New System.Drawing.Size(198, 22)
        Me.txtContactNumber.TabIndex = 6
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl7.Location = New System.Drawing.Point(44, 253)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(74, 15)
        Me.LabelControl7.TabIndex = 705
        Me.LabelControl7.Text = "Email Address"
        '
        'txtEmail
        '
        Me.txtEmail.EditValue = ""
        Me.txtEmail.Location = New System.Drawing.Point(126, 250)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Properties.Mask.EditMask = ".+@.+\..+"
        Me.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtEmail.Size = New System.Drawing.Size(198, 22)
        Me.txtEmail.TabIndex = 7
        '
        'ProfilePic
        '
        Me.ProfilePic.Location = New System.Drawing.Point(339, 74)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.ProfilePic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.ProfilePic.Size = New System.Drawing.Size(221, 232)
        Me.ProfilePic.TabIndex = 706
        '
        'countrycode
        '
        Me.countrycode.EnterMoveNextControl = True
        Me.countrycode.Location = New System.Drawing.Point(667, 177)
        Me.countrycode.Name = "countrycode"
        Me.countrycode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.countrycode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.countrycode.Properties.Appearance.Options.UseFont = True
        Me.countrycode.Properties.Appearance.Options.UseForeColor = True
        Me.countrycode.Properties.Appearance.Options.UseTextOptions = True
        Me.countrycode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.countrycode.Properties.ReadOnly = True
        Me.countrycode.Size = New System.Drawing.Size(55, 22)
        Me.countrycode.TabIndex = 707
        Me.countrycode.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(126, 46)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(338, 13)
        Me.LabelControl9.TabIndex = 710
        Me.LabelControl9.Text = "This form is allow user to update hotel guest account Information"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(126, 24)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(171, 19)
        Me.LabelControl10.TabIndex = 709
        Me.LabelControl10.Text = "Hotel Guest Information"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(124, 52)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(413, 13)
        Me.LabelControl11.TabIndex = 708
        Me.LabelControl11.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Coffeecup.My.Resources.Resources.NewItem_32x32
        Me.PictureBox1.Location = New System.Drawing.Point(66, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 711
        Me.PictureBox1.TabStop = False
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(126, 174)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGender.Properties.Appearance.Options.UseFont = True
        Me.txtGender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGender.Properties.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtGender.Size = New System.Drawing.Size(137, 22)
        Me.txtGender.TabIndex = 4
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(126, 199)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNationality.Properties.Appearance.Options.UseFont = True
        Me.txtNationality.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNationality.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtNationality.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNationality.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtNationality.Properties.AppearanceFocused.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNationality.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtNationality.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNationality.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNationality.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNationality.Properties.ImmediatePopup = True
        Me.txtNationality.Size = New System.Drawing.Size(198, 22)
        Me.txtNationality.TabIndex = 5
        '
        'frmHotelGuestInformation
        '
        Me.AcceptButton = Me.cmdSave
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(643, 361)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.countrycode)
        Me.Controls.Add(Me.ProfilePic)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtBirthdate)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtAddress)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelGuestInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Information"
        CType(Me.guestid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGuest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBirthdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBirthdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilePic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.countrycode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNationality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents guestid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCountry As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGuest As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBirthdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContactNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProfilePic As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents countrycode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtGender As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtNationality As DevExpress.XtraEditors.ComboBoxEdit
End Class
