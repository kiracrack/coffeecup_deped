<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetDatabase
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
        Me.CheckedListBox1 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.txtColumn = New DevExpress.XtraEditors.TextEdit()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.CheckedListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtColumn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.CheckedListBox1.Appearance.Options.UseFont = True
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.HorizontalScrollbar = True
        Me.CheckedListBox1.HotTrackItems = True
        Me.CheckedListBox1.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.CheckedListBox1.Location = New System.Drawing.Point(2, 0)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(409, 456)
        Me.CheckedListBox1.TabIndex = 617
        '
        'txtColumn
        '
        Me.txtColumn.EnterMoveNextControl = True
        Me.txtColumn.Location = New System.Drawing.Point(162, 169)
        Me.txtColumn.Name = "txtColumn"
        Me.txtColumn.Properties.Appearance.Options.UseTextOptions = True
        Me.txtColumn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtColumn.Size = New System.Drawing.Size(71, 20)
        Me.txtColumn.TabIndex = 619
        Me.txtColumn.Visible = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(229, 461)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(181, 30)
        Me.cmdUpdate.TabIndex = 620
        Me.cmdUpdate.Text = "Confirm Reset"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(2, 460)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Check All"
        Me.CheckEdit1.Size = New System.Drawing.Size(138, 19)
        Me.CheckEdit1.TabIndex = 621
        '
        'frmResetDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 499)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtColumn)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResetDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Database"
        CType(Me.CheckedListBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtColumn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckedListBox1 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents txtColumn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
