<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomInformation
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
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.txtHotel = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.hotelcif = New DevExpress.XtraEditors.TextEdit()
        Me.txtRoomType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridRoomType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.typecode = New DevExpress.XtraEditors.TextEdit()
        Me.txtStatus = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCluster = New DevExpress.XtraEditors.TextEdit()
        CType(Me.rid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHotel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hotelcif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRoomType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.typecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCluster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.rid.Size = New System.Drawing.Size(75, 22)
        Me.rid.TabIndex = 100
        '
        'LabelControl26
        '
        Me.LabelControl26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl26.Location = New System.Drawing.Point(66, 25)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(63, 15)
        Me.LabelControl26.TabIndex = 399
        Me.LabelControl26.Text = "Room Code"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRoomNumber.EnterMoveNextControl = True
        Me.txtRoomNumber.Location = New System.Drawing.Point(138, 122)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomNumber.Properties.Appearance.Options.UseFont = True
        Me.txtRoomNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRoomNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtRoomNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoomNumber.Size = New System.Drawing.Size(75, 22)
        Me.txtRoomNumber.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(50, 125)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(79, 15)
        Me.LabelControl3.TabIndex = 393
        Me.LabelControl3.Text = "Room Number"
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
        Me.cmdSave.Location = New System.Drawing.Point(138, 174)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(152, 30)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Save"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(215, 122)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.NullText = "Room Description"
        Me.txtDescription.Size = New System.Drawing.Size(223, 22)
        Me.txtDescription.TabIndex = 4
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(537, 18)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Size = New System.Drawing.Size(48, 22)
        Me.mode.TabIndex = 400
        Me.mode.Visible = False
        '
        'txtHotel
        '
        Me.txtHotel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtHotel.EditValue = ""
        Me.txtHotel.EnterMoveNextControl = True
        Me.txtHotel.Location = New System.Drawing.Point(138, 47)
        Me.txtHotel.Name = "txtHotel"
        Me.txtHotel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHotel.Properties.Appearance.Options.UseFont = True
        Me.txtHotel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHotel.Properties.DisplayMember = "Select Hotel"
        Me.txtHotel.Properties.ImmediatePopup = True
        Me.txtHotel.Properties.NullText = ""
        Me.txtHotel.Properties.ValueMember = "Select Hotel"
        Me.txtHotel.Properties.View = Me.Gridview1
        Me.txtHotel.Size = New System.Drawing.Size(198, 22)
        Me.txtHotel.TabIndex = 0
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
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(66, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 15)
        Me.LabelControl1.TabIndex = 688
        Me.LabelControl1.Text = "Select Hotel"
        '
        'hotelcif
        '
        Me.hotelcif.EnterMoveNextControl = True
        Me.hotelcif.Location = New System.Drawing.Point(537, 46)
        Me.hotelcif.Name = "hotelcif"
        Me.hotelcif.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hotelcif.Properties.Appearance.Options.UseFont = True
        Me.hotelcif.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.hotelcif.Size = New System.Drawing.Size(48, 22)
        Me.hotelcif.TabIndex = 689
        Me.hotelcif.Visible = False
        '
        'txtRoomType
        '
        Me.txtRoomType.EditValue = ""
        Me.txtRoomType.EnterMoveNextControl = True
        Me.txtRoomType.Location = New System.Drawing.Point(138, 72)
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomType.Properties.Appearance.Options.UseFont = True
        Me.txtRoomType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRoomType.Properties.DisplayMember = "Description"
        Me.txtRoomType.Properties.ImmediatePopup = True
        Me.txtRoomType.Properties.NullText = ""
        Me.txtRoomType.Properties.ValueMember = "Description"
        Me.txtRoomType.Properties.View = Me.gridRoomType
        Me.txtRoomType.Size = New System.Drawing.Size(300, 22)
        Me.txtRoomType.TabIndex = 1
        '
        'gridRoomType
        '
        Me.gridRoomType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridRoomType.Name = "gridRoomType"
        Me.gridRoomType.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridRoomType.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(68, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 15)
        Me.LabelControl2.TabIndex = 691
        Me.LabelControl2.Text = "Room Type"
        '
        'typecode
        '
        Me.typecode.EnterMoveNextControl = True
        Me.typecode.Location = New System.Drawing.Point(537, 72)
        Me.typecode.Name = "typecode"
        Me.typecode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.typecode.Properties.Appearance.Options.UseFont = True
        Me.typecode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.typecode.Size = New System.Drawing.Size(48, 22)
        Me.typecode.TabIndex = 692
        Me.typecode.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStatus.EnterMoveNextControl = True
        Me.txtStatus.Location = New System.Drawing.Point(138, 146)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStatus.Properties.Appearance.Options.UseFont = True
        Me.txtStatus.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStatus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtStatus.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatus.Size = New System.Drawing.Size(75, 22)
        Me.txtStatus.TabIndex = 5
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(215, 146)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Properties.NullText = "Room Description"
        Me.txtRemarks.Size = New System.Drawing.Size(223, 22)
        Me.txtRemarks.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(62, 149)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(67, 15)
        Me.LabelControl4.TabIndex = 695
        Me.LabelControl4.Text = "Room Status"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(92, 100)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 15)
        Me.LabelControl5.TabIndex = 696
        Me.LabelControl5.Text = "Cluster"
        '
        'txtCluster
        '
        Me.txtCluster.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCluster.EditValue = ""
        Me.txtCluster.Location = New System.Drawing.Point(138, 97)
        Me.txtCluster.Name = "txtCluster"
        Me.txtCluster.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCluster.Properties.Appearance.Options.UseFont = True
        Me.txtCluster.Properties.NullText = "Room Description"
        Me.txtCluster.Size = New System.Drawing.Size(198, 22)
        Me.txtCluster.TabIndex = 2
        '
        'frmHotelRoomInformation
        '
        Me.AcceptButton = Me.cmdSave
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(520, 223)
        Me.Controls.Add(Me.txtCluster)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.typecode)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.hotelcif)
        Me.Controls.Add(Me.txtHotel)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.LabelControl26)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.rid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtDescription)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelRoomInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Information"
        CType(Me.rid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHotel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hotelcif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRoomType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.typecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCluster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRoomNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHotel As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents hotelcif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRoomType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gridRoomType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents typecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCluster As DevExpress.XtraEditors.TextEdit
End Class
