<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsersAccountEmailNotification
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
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.accountid = New DevExpress.XtraEditors.TextEdit()
        Me.ck_attendance = New DevExpress.XtraEditors.CheckEdit()
        Me.ck_checkdue = New DevExpress.XtraEditors.CheckEdit()
        Me.ck_sales = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFullname = New DevExpress.XtraEditors.TextEdit()
        Me.ck_postockreceived = New DevExpress.XtraEditors.CheckEdit()
        Me.ck_AutoServices = New DevExpress.XtraEditors.CheckEdit()
        Me.ck_banksLedger = New DevExpress.XtraEditors.CheckEdit()
        Me.ck_monthlysummary = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.accountid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_attendance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_checkdue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_sales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_postockreceived.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_AutoServices.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_banksLedger.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_monthlysummary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdSave.Location = New System.Drawing.Point(10, 184)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(165, 27)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "Save"
        '
        'accountid
        '
        Me.accountid.EnterMoveNextControl = True
        Me.accountid.Location = New System.Drawing.Point(40, 294)
        Me.accountid.Name = "accountid"
        Me.accountid.Size = New System.Drawing.Size(73, 20)
        Me.accountid.TabIndex = 609
        Me.accountid.Visible = False
        '
        'ck_attendance
        '
        Me.ck_attendance.Location = New System.Drawing.Point(12, 78)
        Me.ck_attendance.Name = "ck_attendance"
        Me.ck_attendance.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_attendance.Properties.Appearance.Options.UseFont = True
        Me.ck_attendance.Properties.Caption = "Notify email employee attendance"
        Me.ck_attendance.Size = New System.Drawing.Size(280, 19)
        Me.ck_attendance.TabIndex = 689
        '
        'ck_checkdue
        '
        Me.ck_checkdue.Location = New System.Drawing.Point(12, 58)
        Me.ck_checkdue.Name = "ck_checkdue"
        Me.ck_checkdue.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_checkdue.Properties.Appearance.Options.UseFont = True
        Me.ck_checkdue.Properties.Caption = "Notify email client check due date"
        Me.ck_checkdue.Size = New System.Drawing.Size(211, 19)
        Me.ck_checkdue.TabIndex = 691
        '
        'ck_sales
        '
        Me.ck_sales.Location = New System.Drawing.Point(12, 38)
        Me.ck_sales.Name = "ck_sales"
        Me.ck_sales.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_sales.Properties.Appearance.Options.UseFont = True
        Me.ck_sales.Properties.Caption = "Notify email cashier's sales"
        Me.ck_sales.Size = New System.Drawing.Size(179, 19)
        Me.ck_sales.TabIndex = 684
        '
        'txtFullname
        '
        Me.txtFullname.EditValue = ""
        Me.txtFullname.Location = New System.Drawing.Point(10, 12)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Properties.Appearance.Options.UseFont = True
        Me.txtFullname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFullname.Properties.ReadOnly = True
        Me.txtFullname.Size = New System.Drawing.Size(315, 20)
        Me.txtFullname.TabIndex = 1
        '
        'ck_postockreceived
        '
        Me.ck_postockreceived.Location = New System.Drawing.Point(12, 98)
        Me.ck_postockreceived.Name = "ck_postockreceived"
        Me.ck_postockreceived.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_postockreceived.Properties.Appearance.Options.UseFont = True
        Me.ck_postockreceived.Properties.Caption = "Notify email purchase order stock received"
        Me.ck_postockreceived.Size = New System.Drawing.Size(280, 19)
        Me.ck_postockreceived.TabIndex = 692
        '
        'ck_AutoServices
        '
        Me.ck_AutoServices.Location = New System.Drawing.Point(12, 118)
        Me.ck_AutoServices.Name = "ck_AutoServices"
        Me.ck_AutoServices.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_AutoServices.Properties.Appearance.Options.UseFont = True
        Me.ck_AutoServices.Properties.Caption = "Notify email auto services"
        Me.ck_AutoServices.Size = New System.Drawing.Size(280, 19)
        Me.ck_AutoServices.TabIndex = 693
        '
        'ck_banksLedger
        '
        Me.ck_banksLedger.Location = New System.Drawing.Point(12, 138)
        Me.ck_banksLedger.Name = "ck_banksLedger"
        Me.ck_banksLedger.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_banksLedger.Properties.Appearance.Options.UseFont = True
        Me.ck_banksLedger.Properties.Caption = "Notify email bank account ledger"
        Me.ck_banksLedger.Size = New System.Drawing.Size(280, 19)
        Me.ck_banksLedger.TabIndex = 694
        '
        'ck_monthlysummary
        '
        Me.ck_monthlysummary.Location = New System.Drawing.Point(12, 158)
        Me.ck_monthlysummary.Name = "ck_monthlysummary"
        Me.ck_monthlysummary.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_monthlysummary.Properties.Appearance.Options.UseFont = True
        Me.ck_monthlysummary.Properties.Caption = "Notify email monthly summary"
        Me.ck_monthlysummary.Size = New System.Drawing.Size(280, 19)
        Me.ck_monthlysummary.TabIndex = 695
        '
        'frmUsersAccountEmailNotification
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 219)
        Me.Controls.Add(Me.ck_monthlysummary)
        Me.Controls.Add(Me.ck_banksLedger)
        Me.Controls.Add(Me.ck_AutoServices)
        Me.Controls.Add(Me.ck_postockreceived)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.ck_checkdue)
        Me.Controls.Add(Me.ck_attendance)
        Me.Controls.Add(Me.ck_sales)
        Me.Controls.Add(Me.accountid)
        Me.Controls.Add(Me.txtFullname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsersAccountEmailNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email notification settings"
        CType(Me.accountid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_attendance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_checkdue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_sales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_postockreceived.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_AutoServices.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_banksLedger.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_monthlysummary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents accountid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ck_checkdue As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ck_attendance As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ck_sales As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ck_postockreceived As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ck_AutoServices As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ck_banksLedger As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ck_monthlysummary As DevExpress.XtraEditors.CheckEdit
End Class
