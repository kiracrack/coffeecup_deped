<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepEdUpdateRequestStatus
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
        Me.lblcaption = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtremarks = New DevExpress.XtraEditors.MemoEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.txtoffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcompoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcaption
        '
        Me.lblcaption.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaption.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lblcaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblcaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblcaption.Location = New System.Drawing.Point(12, 84)
        Me.lblcaption.Name = "lblcaption"
        Me.lblcaption.Size = New System.Drawing.Size(457, 20)
        Me.lblcaption.TabIndex = 584
        Me.lblcaption.Text = "Please enter message for recording purposes."
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleButton1.Location = New System.Drawing.Point(338, 158)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(131, 29)
        Me.SimpleButton1.TabIndex = 585
        Me.SimpleButton1.Text = "Cancel Action"
        Me.SimpleButton1.ToolTip = "Shortcut Key (Enter)"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCancel.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCancel.Appearance.Options.UseBackColor = True
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Appearance.Options.UseForeColor = True
        Me.cmdCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdCancel.Location = New System.Drawing.Point(178, 157)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(154, 30)
        Me.cmdCancel.TabIndex = 588
        Me.cmdCancel.Text = "Confirm"
        '
        'txtremarks
        '
        Me.txtremarks.EditValue = ""
        Me.txtremarks.Location = New System.Drawing.Point(12, 103)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.Properties.Appearance.Options.UseFont = True
        Me.txtremarks.Size = New System.Drawing.Size(457, 49)
        Me.txtremarks.TabIndex = 589
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(425, 41)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(44, 20)
        Me.pid.TabIndex = 590
        Me.pid.Visible = False
        '
        'txtoffice
        '
        Me.txtoffice.EditValue = ""
        Me.txtoffice.Location = New System.Drawing.Point(12, 59)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtoffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtoffice.Properties.Appearance.Options.UseFont = True
        Me.txtoffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtoffice.Properties.NullText = ""
        Me.txtoffice.Properties.View = Me.gridcompoffice
        Me.txtoffice.Size = New System.Drawing.Size(234, 20)
        Me.txtoffice.TabIndex = 591
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
        Me.lblOffice.Location = New System.Drawing.Point(12, 42)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(73, 13)
        Me.lblOffice.TabIndex = 592
        Me.lblOffice.Text = "Current Office"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 9)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Tag as Approved Request"
        Me.CheckEdit1.Size = New System.Drawing.Size(234, 25)
        Me.CheckEdit1.TabIndex = 593
        '
        'frmDepEdUpdateRequestStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 199)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.lblOffice)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.txtremarks)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.lblcaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepEdUpdateRequestStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Request Processing"
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcaption As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtremarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtoffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridcompoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
