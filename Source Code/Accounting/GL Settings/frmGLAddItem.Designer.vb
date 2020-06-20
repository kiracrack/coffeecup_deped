<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLAddItem
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtItemName = New DevExpress.XtraEditors.TextEdit()
        Me.itemcode = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtGLGroup = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridGLGroup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLevel = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtParent = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridglparent = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.parentcode = New DevExpress.XtraEditors.ButtonEdit()
        Me.groupcode = New DevExpress.XtraEditors.ButtonEdit()
        Me.gl = New System.Windows.Forms.CheckBox()
        Me.sl = New System.Windows.Forms.CheckBox()
        CType(Me.txtItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGLGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridGLGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridglparent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parentcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(73, 20)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 17)
        Me.LabelControl2.TabIndex = 643
        Me.LabelControl2.Text = "GL Group"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(65, 74)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 17)
        Me.LabelControl1.TabIndex = 642
        Me.LabelControl1.Text = "Item Name"
        '
        'txtItemName
        '
        Me.txtItemName.EditValue = ""
        Me.txtItemName.Location = New System.Drawing.Point(137, 71)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Properties.Appearance.Options.UseFont = True
        Me.txtItemName.Size = New System.Drawing.Size(347, 24)
        Me.txtItemName.TabIndex = 2
        '
        'itemcode
        '
        Me.itemcode.EditValue = ""
        Me.itemcode.Location = New System.Drawing.Point(137, 44)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemcode.Properties.Appearance.Options.UseFont = True
        Me.itemcode.Properties.Appearance.Options.UseTextOptions = True
        Me.itemcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.itemcode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.itemcode.Properties.Mask.BeepOnError = True
        Me.itemcode.Size = New System.Drawing.Size(109, 24)
        Me.itemcode.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(69, 47)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 17)
        Me.LabelControl6.TabIndex = 641
        Me.LabelControl6.Text = "Item Code"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(137, 185)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(181, 32)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Save"
        '
        'txtGLGroup
        '
        Me.txtGLGroup.EditValue = ""
        Me.txtGLGroup.Location = New System.Drawing.Point(137, 17)
        Me.txtGLGroup.Name = "txtGLGroup"
        Me.txtGLGroup.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGLGroup.Properties.Appearance.Options.UseFont = True
        Me.txtGLGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGLGroup.Properties.DisplayMember = "Group Name"
        Me.txtGLGroup.Properties.NullText = ""
        Me.txtGLGroup.Properties.ValueMember = "Group Name"
        Me.txtGLGroup.Properties.View = Me.gridGLGroup
        Me.txtGLGroup.Size = New System.Drawing.Size(181, 24)
        Me.txtGLGroup.TabIndex = 0
        '
        'gridGLGroup
        '
        Me.gridGLGroup.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridGLGroup.Name = "gridGLGroup"
        Me.gridGLGroup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridGLGroup.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(51, 106)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(78, 17)
        Me.LabelControl4.TabIndex = 652
        Me.LabelControl4.Text = "Account Type"
        '
        'txtLevel
        '
        Me.txtLevel.EditValue = "1"
        Me.txtLevel.Location = New System.Drawing.Point(137, 130)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevel.Properties.Appearance.Options.UseFont = True
        Me.txtLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtLevel.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtLevel.Properties.Mask.BeepOnError = True
        Me.txtLevel.Properties.Mask.EditMask = "n"
        Me.txtLevel.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtLevel.Size = New System.Drawing.Size(109, 24)
        Me.txtLevel.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(99, 133)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(29, 17)
        Me.LabelControl3.TabIndex = 654
        Me.LabelControl3.Text = "Level"
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(461, 131)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.mode.Properties.Mask.BeepOnError = True
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(39, 20)
        Me.mode.TabIndex = 655
        Me.mode.Visible = False
        '
        'txtParent
        '
        Me.txtParent.EditValue = ""
        Me.txtParent.Location = New System.Drawing.Point(137, 157)
        Me.txtParent.Name = "txtParent"
        Me.txtParent.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParent.Properties.Appearance.Options.UseFont = True
        Me.txtParent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtParent.Properties.DisplayMember = "Parent"
        Me.txtParent.Properties.NullText = ""
        Me.txtParent.Properties.ValueMember = "Parent"
        Me.txtParent.Properties.View = Me.gridglparent
        Me.txtParent.Size = New System.Drawing.Size(181, 24)
        Me.txtParent.TabIndex = 5
        '
        'gridglparent
        '
        Me.gridglparent.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridglparent.Name = "gridglparent"
        Me.gridglparent.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridglparent.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(91, 160)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 17)
        Me.LabelControl5.TabIndex = 656
        Me.LabelControl5.Text = "Parent"
        '
        'parentcode
        '
        Me.parentcode.EditValue = ""
        Me.parentcode.Location = New System.Drawing.Point(461, 158)
        Me.parentcode.Name = "parentcode"
        Me.parentcode.Properties.Appearance.Options.UseTextOptions = True
        Me.parentcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.parentcode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.parentcode.Properties.Mask.BeepOnError = True
        Me.parentcode.Properties.ReadOnly = True
        Me.parentcode.Size = New System.Drawing.Size(39, 20)
        Me.parentcode.TabIndex = 658
        Me.parentcode.Visible = False
        '
        'groupcode
        '
        Me.groupcode.EditValue = ""
        Me.groupcode.Location = New System.Drawing.Point(461, 184)
        Me.groupcode.Name = "groupcode"
        Me.groupcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.groupcode.Properties.Appearance.Options.UseFont = True
        Me.groupcode.Properties.Appearance.Options.UseTextOptions = True
        Me.groupcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.groupcode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.groupcode.Properties.Mask.BeepOnError = True
        Me.groupcode.Properties.ReadOnly = True
        Me.groupcode.Size = New System.Drawing.Size(39, 24)
        Me.groupcode.TabIndex = 646
        Me.groupcode.Visible = False
        '
        'gl
        '
        Me.gl.AutoSize = True
        Me.gl.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.gl.Location = New System.Drawing.Point(137, 101)
        Me.gl.Name = "gl"
        Me.gl.Size = New System.Drawing.Size(42, 21)
        Me.gl.TabIndex = 659
        Me.gl.Text = "GL"
        Me.gl.UseVisualStyleBackColor = True
        '
        'sl
        '
        Me.sl.AutoSize = True
        Me.sl.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.sl.Location = New System.Drawing.Point(185, 101)
        Me.sl.Name = "sl"
        Me.sl.Size = New System.Drawing.Size(40, 21)
        Me.sl.TabIndex = 660
        Me.sl.Text = "SL"
        Me.sl.UseVisualStyleBackColor = True
        '
        'frmGLAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 239)
        Me.Controls.Add(Me.sl)
        Me.Controls.Add(Me.gl)
        Me.Controls.Add(Me.parentcode)
        Me.Controls.Add(Me.txtParent)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtGLGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGLAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GL Account Item"
        CType(Me.txtItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGLGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridGLGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridglparent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parentcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtItemName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents itemcode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtGLGroup As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridGLGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLevel As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtParent As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridglparent As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents parentcode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents groupcode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents gl As System.Windows.Forms.CheckBox
    Friend WithEvents sl As System.Windows.Forms.CheckBox
End Class
