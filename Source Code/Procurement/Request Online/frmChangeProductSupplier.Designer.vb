<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeProductSupplier
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
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.txtVendor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridVendor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.vendorid = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdaction.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseBackColor = True
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdaction.Location = New System.Drawing.Point(209, 64)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(135, 30)
        Me.cmdaction.TabIndex = 558
        Me.cmdaction.Text = "Confirm Save"
        '
        'txtVendor
        '
        Me.txtVendor.EditValue = ""
        Me.txtVendor.Location = New System.Drawing.Point(68, 34)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtVendor.Properties.Appearance.Options.UseFont = True
        Me.txtVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVendor.Properties.DisplayMember = "Vendor"
        Me.txtVendor.Properties.NullText = ""
        Me.txtVendor.Properties.ValueMember = "Vendor"
        Me.txtVendor.Properties.View = Me.gridVendor
        Me.txtVendor.Size = New System.Drawing.Size(277, 26)
        Me.txtVendor.TabIndex = 639
        '
        'gridVendor
        '
        Me.gridVendor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridVendor.Name = "gridVendor"
        Me.gridVendor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridVendor.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl2.Location = New System.Drawing.Point(68, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl2.TabIndex = 640
        Me.LabelControl2.Text = "Please select vendor"
        '
        'vendorid
        '
        Me.vendorid.Location = New System.Drawing.Point(101, 86)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendorid.Properties.Appearance.Options.UseFont = True
        Me.vendorid.Properties.Appearance.Options.UseTextOptions = True
        Me.vendorid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vendorid.Properties.ReadOnly = True
        Me.vendorid.Size = New System.Drawing.Size(56, 20)
        Me.vendorid.TabIndex = 641
        Me.vendorid.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(39, 86)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(56, 20)
        Me.mode.TabIndex = 642
        Me.mode.Visible = False
        '
        'frmChangeProductSupplier
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 118)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.txtVendor)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangeProductSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Product Supplier"
        Me.TopMost = True
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridVendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtVendor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridVendor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents vendorid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
End Class
