<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoffeecupServerPermissionInfo
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
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.percode = New DevExpress.XtraEditors.TextEdit()
        Me.txtPermission = New DevExpress.XtraEditors.TextEdit()
        Me.ck_allowEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ck_allowDelete = New DevExpress.XtraEditors.CheckEdit()
        Me.ck_allowAdd = New DevExpress.XtraEditors.CheckEdit()
        Me.ck_special = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.percode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPermission.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_allowEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_allowDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_allowAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_special.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(12, 8)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl5.TabIndex = 593
        Me.LabelControl5.Text = "Permission template name"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdSave.Location = New System.Drawing.Point(95, 77)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(165, 27)
        Me.cmdSave.TabIndex = 604
        Me.cmdSave.Text = "Save"
        '
        'percode
        '
        Me.percode.EnterMoveNextControl = True
        Me.percode.Location = New System.Drawing.Point(40, 294)
        Me.percode.Name = "percode"
        Me.percode.Size = New System.Drawing.Size(73, 20)
        Me.percode.TabIndex = 609
        Me.percode.Visible = False
        '
        'txtPermission
        '
        Me.txtPermission.EditValue = ""
        Me.txtPermission.Location = New System.Drawing.Point(10, 27)
        Me.txtPermission.Name = "txtPermission"
        Me.txtPermission.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermission.Properties.Appearance.Options.UseFont = True
        Me.txtPermission.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPermission.Size = New System.Drawing.Size(335, 20)
        Me.txtPermission.TabIndex = 1
        '
        'ck_allowEdit
        '
        Me.ck_allowEdit.Location = New System.Drawing.Point(170, 51)
        Me.ck_allowEdit.Name = "ck_allowEdit"
        Me.ck_allowEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_allowEdit.Properties.Appearance.Options.UseFont = True
        Me.ck_allowEdit.Properties.Caption = "Allow Edit"
        Me.ck_allowEdit.Size = New System.Drawing.Size(77, 19)
        Me.ck_allowEdit.TabIndex = 689
        '
        'ck_allowDelete
        '
        Me.ck_allowDelete.Location = New System.Drawing.Point(255, 51)
        Me.ck_allowDelete.Name = "ck_allowDelete"
        Me.ck_allowDelete.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_allowDelete.Properties.Appearance.Options.UseFont = True
        Me.ck_allowDelete.Properties.Caption = "Allow Delete"
        Me.ck_allowDelete.Size = New System.Drawing.Size(92, 19)
        Me.ck_allowDelete.TabIndex = 690
        '
        'ck_allowAdd
        '
        Me.ck_allowAdd.Location = New System.Drawing.Point(90, 51)
        Me.ck_allowAdd.Name = "ck_allowAdd"
        Me.ck_allowAdd.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_allowAdd.Properties.Appearance.Options.UseFont = True
        Me.ck_allowAdd.Properties.Caption = "Allow Add"
        Me.ck_allowAdd.Size = New System.Drawing.Size(72, 19)
        Me.ck_allowAdd.TabIndex = 691
        '
        'ck_special
        '
        Me.ck_special.Location = New System.Drawing.Point(10, 51)
        Me.ck_special.Name = "ck_special"
        Me.ck_special.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_special.Properties.Appearance.Options.UseFont = True
        Me.ck_special.Properties.Caption = "Approver"
        Me.ck_special.Size = New System.Drawing.Size(71, 19)
        Me.ck_special.TabIndex = 684
        '
        'frmCoffeecupServerPermissionInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 115)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.ck_allowAdd)
        Me.Controls.Add(Me.ck_allowDelete)
        Me.Controls.Add(Me.ck_allowEdit)
        Me.Controls.Add(Me.ck_special)
        Me.Controls.Add(Me.percode)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtPermission)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCoffeecupServerPermissionInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coffeecup Server Permission"
        CType(Me.percode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPermission.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_allowEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_allowDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_allowAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_special.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents percode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPermission As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ck_allowAdd As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ck_allowDelete As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ck_allowEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ck_special As DevExpress.XtraEditors.CheckEdit
End Class
