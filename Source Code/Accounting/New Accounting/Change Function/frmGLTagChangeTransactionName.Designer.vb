<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLTagChangeTransactionName
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
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.cmdSaveVoucher = New DevExpress.XtraEditors.SimpleButton()
        Me.itemid = New DevExpress.XtraEditors.TextEdit()
        Me.txtItem = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.groupid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.itemid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(443, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 119)
        '
        'cmdSaveVoucher
        '
        Me.cmdSaveVoucher.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveVoucher.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveVoucher.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveVoucher.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveVoucher.Appearance.Options.UseBackColor = True
        Me.cmdSaveVoucher.Appearance.Options.UseFont = True
        Me.cmdSaveVoucher.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSaveVoucher.Location = New System.Drawing.Point(129, 55)
        Me.cmdSaveVoucher.Name = "cmdSaveVoucher"
        Me.cmdSaveVoucher.Size = New System.Drawing.Size(165, 30)
        Me.cmdSaveVoucher.TabIndex = 745
        Me.cmdSaveVoucher.Text = "Confirm Change"
        '
        'itemid
        '
        Me.itemid.Location = New System.Drawing.Point(461, 29)
        Me.itemid.Name = "itemid"
        Me.itemid.Properties.ReadOnly = True
        Me.itemid.Size = New System.Drawing.Size(73, 20)
        Me.itemid.TabIndex = 749
        Me.itemid.Visible = False
        '
        'txtItem
        '
        Me.txtItem.EditValue = ""
        Me.txtItem.Location = New System.Drawing.Point(129, 23)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItem.Properties.DisplayMember = "Select"
        Me.txtItem.Properties.NullText = ""
        Me.txtItem.Properties.ValueMember = "id"
        Me.txtItem.Properties.View = Me.gridItem
        Me.txtItem.Size = New System.Drawing.Size(270, 26)
        Me.txtItem.TabIndex = 747
        '
        'gridItem
        '
        Me.gridItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridItem.Name = "gridItem"
        Me.gridItem.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridItem.OptionsView.ShowGroupPanel = False
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.Location = New System.Drawing.Point(26, 29)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(97, 15)
        Me.lblOffice.TabIndex = 748
        Me.lblOffice.Text = "Transaction Name"
        '
        'groupid
        '
        Me.groupid.Location = New System.Drawing.Point(461, 55)
        Me.groupid.Name = "groupid"
        Me.groupid.Properties.ReadOnly = True
        Me.groupid.Size = New System.Drawing.Size(73, 20)
        Me.groupid.TabIndex = 750
        Me.groupid.Visible = False
        '
        'frmGLTagChangeTransactionName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 119)
        Me.Controls.Add(Me.groupid)
        Me.Controls.Add(Me.itemid)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lblOffice)
        Me.Controls.Add(Me.cmdSaveVoucher)
        Me.Controls.Add(Me.barDockControlRight)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGLTagChangeTransactionName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Transaction Name"
        CType(Me.itemid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents cmdSaveVoucher As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents itemid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItem As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents groupid As DevExpress.XtraEditors.TextEdit
End Class
