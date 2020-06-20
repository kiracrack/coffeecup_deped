<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLAccountsFilter
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
        Me.Em_unfiltered = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em_filtered = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdMoveRight = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdMoveLeft = New DevExpress.XtraEditors.SimpleButton()
        Me.permissioncode = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtPermission = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvpermission = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCompany = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView_company = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.compid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.Em_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.permissioncode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPermission.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvpermission, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_company, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlRight.Location = New System.Drawing.Point(618, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 412)
        '
        'Em_unfiltered
        '
        Me.Em_unfiltered.Location = New System.Drawing.Point(11, 69)
        Me.Em_unfiltered.MainView = Me.GridView1
        Me.Em_unfiltered.Name = "Em_unfiltered"
        Me.Em_unfiltered.Size = New System.Drawing.Size(272, 331)
        Me.Em_unfiltered.TabIndex = 699
        Me.Em_unfiltered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.GridControl = Me.Em_unfiltered
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Em_filtered
        '
        Me.Em_filtered.Location = New System.Drawing.Point(337, 49)
        Me.Em_filtered.MainView = Me.GridView2
        Me.Em_filtered.Name = "Em_filtered"
        Me.Em_filtered.Size = New System.Drawing.Size(272, 351)
        Me.Em_filtered.TabIndex = 700
        Me.Em_filtered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.GridControl = Me.Em_filtered
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'cmdMoveRight
        '
        Me.cmdMoveRight.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveRight.Appearance.Options.UseFont = True
        Me.cmdMoveRight.Location = New System.Drawing.Point(287, 158)
        Me.cmdMoveRight.Name = "cmdMoveRight"
        Me.cmdMoveRight.Size = New System.Drawing.Size(46, 46)
        Me.cmdMoveRight.TabIndex = 701
        Me.cmdMoveRight.Text = ">"
        '
        'cmdMoveLeft
        '
        Me.cmdMoveLeft.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveLeft.Appearance.Options.UseFont = True
        Me.cmdMoveLeft.Location = New System.Drawing.Point(287, 210)
        Me.cmdMoveLeft.Name = "cmdMoveLeft"
        Me.cmdMoveLeft.Size = New System.Drawing.Size(46, 46)
        Me.cmdMoveLeft.TabIndex = 702
        Me.cmdMoveLeft.Text = "<"
        '
        'permissioncode
        '
        Me.permissioncode.EditValue = ""
        Me.permissioncode.Location = New System.Drawing.Point(287, 46)
        Me.permissioncode.Name = "permissioncode"
        Me.permissioncode.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.permissioncode.Properties.Appearance.Options.UseFont = True
        Me.permissioncode.Properties.Appearance.Options.UseTextOptions = True
        Me.permissioncode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.permissioncode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.permissioncode.Properties.Mask.BeepOnError = True
        Me.permissioncode.Properties.ReadOnly = True
        Me.permissioncode.Size = New System.Drawing.Size(33, 22)
        Me.permissioncode.TabIndex = 703
        Me.permissioncode.Visible = False
        '
        'txtPermission
        '
        Me.txtPermission.EditValue = ""
        Me.txtPermission.Location = New System.Drawing.Point(11, 46)
        Me.txtPermission.Name = "txtPermission"
        Me.txtPermission.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPermission.Properties.DisplayMember = "Select Permission"
        Me.txtPermission.Properties.NullText = ""
        Me.txtPermission.Properties.ValueMember = "authCode"
        Me.txtPermission.Properties.View = Me.gvpermission
        Me.txtPermission.Size = New System.Drawing.Size(272, 20)
        Me.txtPermission.TabIndex = 697
        '
        'gvpermission
        '
        Me.gvpermission.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvpermission.Name = "gvpermission"
        Me.gvpermission.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvpermission.OptionsView.ShowGroupPanel = False
        '
        'txtCompany
        '
        Me.txtCompany.EditValue = ""
        Me.txtCompany.Location = New System.Drawing.Point(11, 23)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompany.Properties.Appearance.Options.UseFont = True
        Me.txtCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCompany.Properties.DisplayMember = "Select Company"
        Me.txtCompany.Properties.NullText = ""
        Me.txtCompany.Properties.ValueMember = "compid"
        Me.txtCompany.Properties.View = Me.GridView_company
        Me.txtCompany.Size = New System.Drawing.Size(272, 20)
        Me.txtCompany.TabIndex = 745
        '
        'GridView_company
        '
        Me.GridView_company.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView_company.Name = "GridView_company"
        Me.GridView_company.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView_company.OptionsView.ShowGroupPanel = False
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.Location = New System.Drawing.Point(14, 6)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(81, 13)
        Me.lblOffice.TabIndex = 744
        Me.lblOffice.Text = "Select Company"
        '
        'compid
        '
        Me.compid.EnterMoveNextControl = True
        Me.compid.Location = New System.Drawing.Point(356, 21)
        Me.compid.Name = "compid"
        Me.compid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.compid.Properties.Appearance.Options.UseFont = True
        Me.compid.Size = New System.Drawing.Size(50, 20)
        Me.compid.TabIndex = 747
        Me.compid.Visible = False
        '
        'frmGLAccountsFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 412)
        Me.Controls.Add(Me.compid)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.lblOffice)
        Me.Controls.Add(Me.permissioncode)
        Me.Controls.Add(Me.cmdMoveLeft)
        Me.Controls.Add(Me.cmdMoveRight)
        Me.Controls.Add(Me.Em_unfiltered)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.Em_filtered)
        Me.Controls.Add(Me.txtPermission)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(368, 374)
        Me.Name = "frmGLAccountsFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GL Filter (Note: Move item to the right to give access of a user)"
        CType(Me.Em_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.permissioncode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPermission.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvpermission, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_company, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents cmdMoveLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMoveRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em_filtered As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_unfiltered As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents permissioncode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtPermission As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvpermission As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCompany As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView_company As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents compid As DevExpress.XtraEditors.TextEdit
End Class
