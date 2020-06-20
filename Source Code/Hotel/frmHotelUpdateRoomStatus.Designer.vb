<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelUpdateRoomStatus
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
        Me.rid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRoomNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.hotelcif = New DevExpress.XtraEditors.TextEdit()
        Me.ckMaintainance = New System.Windows.Forms.CheckBox()
        Me.ckOccupied = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaintainanceRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHotel = New DevExpress.XtraEditors.TextEdit()
        CType(Me.rid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hotelcif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtMaintainanceRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHotel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rid
        '
        Me.rid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rid.EnterMoveNextControl = True
        Me.rid.Location = New System.Drawing.Point(138, 22)
        Me.rid.Name = "rid"
        Me.rid.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.rid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.rid.Properties.Appearance.Options.UseBackColor = True
        Me.rid.Properties.Appearance.Options.UseFont = True
        Me.rid.Properties.Appearance.Options.UseForeColor = True
        Me.rid.Properties.Appearance.Options.UseTextOptions = True
        Me.rid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rid.Properties.ReadOnly = True
        Me.rid.Size = New System.Drawing.Size(131, 22)
        Me.rid.TabIndex = 100
        '
        'LabelControl26
        '
        Me.LabelControl26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl26.Location = New System.Drawing.Point(67, 25)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(63, 15)
        Me.LabelControl26.TabIndex = 399
        Me.LabelControl26.Text = "Room Code"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRoomNumber.EnterMoveNextControl = True
        Me.txtRoomNumber.Location = New System.Drawing.Point(138, 47)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomNumber.Properties.Appearance.Options.UseFont = True
        Me.txtRoomNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRoomNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtRoomNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoomNumber.Properties.ReadOnly = True
        Me.txtRoomNumber.Size = New System.Drawing.Size(131, 22)
        Me.txtRoomNumber.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(70, 75)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 15)
        Me.LabelControl4.TabIndex = 392
        Me.LabelControl4.Text = "Description"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(51, 51)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(79, 15)
        Me.LabelControl3.TabIndex = 393
        Me.LabelControl3.Text = "Room Number"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Location = New System.Drawing.Point(245, 258)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(99, 30)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
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
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(135, 258)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(104, 30)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescription.Location = New System.Drawing.Point(138, 72)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(310, 22)
        Me.txtDescription.TabIndex = 1
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(469, 18)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Size = New System.Drawing.Size(48, 22)
        Me.mode.TabIndex = 400
        Me.mode.Visible = False
        '
        'hotelcif
        '
        Me.hotelcif.EnterMoveNextControl = True
        Me.hotelcif.Location = New System.Drawing.Point(469, 46)
        Me.hotelcif.Name = "hotelcif"
        Me.hotelcif.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hotelcif.Properties.Appearance.Options.UseFont = True
        Me.hotelcif.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.hotelcif.Size = New System.Drawing.Size(48, 22)
        Me.hotelcif.TabIndex = 689
        Me.hotelcif.Visible = False
        '
        'ckMaintainance
        '
        Me.ckMaintainance.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ckMaintainance.AutoSize = True
        Me.ckMaintainance.Location = New System.Drawing.Point(65, 44)
        Me.ckMaintainance.Name = "ckMaintainance"
        Me.ckMaintainance.Size = New System.Drawing.Size(132, 19)
        Me.ckMaintainance.TabIndex = 697
        Me.ckMaintainance.Text = "Maintainance Mode"
        Me.ckMaintainance.UseVisualStyleBackColor = False
        '
        'ckOccupied
        '
        Me.ckOccupied.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ckOccupied.AutoSize = True
        Me.ckOccupied.Location = New System.Drawing.Point(65, 19)
        Me.ckOccupied.Name = "ckOccupied"
        Me.ckOccupied.Size = New System.Drawing.Size(77, 19)
        Me.ckOccupied.TabIndex = 695
        Me.ckOccupied.Text = "Occupied"
        Me.ckOccupied.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.txtMaintainanceRemarks)
        Me.GroupBox1.Controls.Add(Me.ckOccupied)
        Me.GroupBox1.Controls.Add(Me.ckMaintainance)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 126)
        Me.GroupBox1.TabIndex = 698
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(65, 69)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(120, 15)
        Me.LabelControl5.TabIndex = 699
        Me.LabelControl5.Text = "Maintainance Remarks"
        '
        'txtMaintainanceRemarks
        '
        Me.txtMaintainanceRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMaintainanceRemarks.Location = New System.Drawing.Point(65, 87)
        Me.txtMaintainanceRemarks.Name = "txtMaintainanceRemarks"
        Me.txtMaintainanceRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMaintainanceRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtMaintainanceRemarks.Size = New System.Drawing.Size(236, 22)
        Me.txtMaintainanceRemarks.TabIndex = 698
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(101, 100)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 15)
        Me.LabelControl1.TabIndex = 700
        Me.LabelControl1.Text = "Hotel"
        '
        'txtHotel
        '
        Me.txtHotel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtHotel.Location = New System.Drawing.Point(138, 97)
        Me.txtHotel.Name = "txtHotel"
        Me.txtHotel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHotel.Properties.Appearance.Options.UseFont = True
        Me.txtHotel.Properties.ReadOnly = True
        Me.txtHotel.Size = New System.Drawing.Size(310, 22)
        Me.txtHotel.TabIndex = 699
        '
        'frmHotelUpdateRoomStatus
        '
        Me.AcceptButton = Me.cmdSave
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 309)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtHotel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.hotelcif)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.LabelControl26)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.rid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtDescription)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelUpdateRoomStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Status Update"
        CType(Me.rid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hotelcif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtMaintainanceRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHotel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRoomNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents hotelcif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckMaintainance As System.Windows.Forms.CheckBox
    Friend WithEvents ckOccupied As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaintainanceRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHotel As DevExpress.XtraEditors.TextEdit
End Class
