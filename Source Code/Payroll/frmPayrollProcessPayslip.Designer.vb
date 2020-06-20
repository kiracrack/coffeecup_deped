<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollProcessPayslip
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
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.payrollcode = New DevExpress.XtraEditors.TextEdit()
        Me.schedulecode = New DevExpress.XtraEditors.TextEdit()
        Me.employeeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtPayrolldate = New DevExpress.XtraEditors.TextEdit()
        Me.ProfilePic = New DevExpress.XtraEditors.PictureEdit()
        Me.txtfullname = New DevExpress.XtraEditors.TextEdit()
        Me.txtStatus = New DevExpress.XtraEditors.TextEdit()
        Me.txtOffice = New DevExpress.XtraEditors.TextEdit()
        Me.txtPosition = New DevExpress.XtraEditors.TextEdit()
        Me.txtSalaryRate = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.txtGross = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.txtOvertime = New DevExpress.XtraEditors.TextEdit()
        Me.txtNetPay = New DevExpress.XtraEditors.TextEdit()
        Me.txtNetGross = New DevExpress.XtraEditors.TextEdit()
        Me.txtDeduction = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdditional = New DevExpress.XtraEditors.TextEdit()
        Me.txtUndertime = New DevExpress.XtraEditors.TextEdit()
        Me.txtLate = New DevExpress.XtraEditors.TextEdit()
        Me.txtHalfDay = New DevExpress.XtraEditors.TextEdit()
        Me.txtAbsent = New DevExpress.XtraEditors.TextEdit()
        Me.cmdLoadData = New DevExpress.XtraEditors.SimpleButton()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.ckCurrent = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayrolldate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilePic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalaryRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGross.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOvertime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetGross.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeduction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdditional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUndertime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHalfDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbsent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckCurrent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.Location = New System.Drawing.Point(471, 10)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(340, 320)
        Me.Em.TabIndex = 645
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'Gridview1
        '
        Me.Gridview1.GridControl = Me.Em
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.Editable = False
        Me.Gridview1.OptionsCustomization.AllowGroup = False
        Me.Gridview1.OptionsView.RowAutoHeight = True
        Me.Gridview1.OptionsView.ShowGroupPanel = False
        Me.Gridview1.PaintStyleName = "Web"
        '
        'payrollcode
        '
        Me.payrollcode.Location = New System.Drawing.Point(582, 171)
        Me.payrollcode.Name = "payrollcode"
        Me.payrollcode.Size = New System.Drawing.Size(58, 20)
        Me.payrollcode.TabIndex = 661
        Me.payrollcode.Visible = False
        '
        'schedulecode
        '
        Me.schedulecode.Location = New System.Drawing.Point(582, 249)
        Me.schedulecode.Name = "schedulecode"
        Me.schedulecode.Size = New System.Drawing.Size(58, 20)
        Me.schedulecode.TabIndex = 663
        Me.schedulecode.Visible = False
        '
        'employeeid
        '
        Me.employeeid.Location = New System.Drawing.Point(582, 223)
        Me.employeeid.Name = "employeeid"
        Me.employeeid.Size = New System.Drawing.Size(58, 20)
        Me.employeeid.TabIndex = 664
        Me.employeeid.Visible = False
        '
        'txtPayrolldate
        '
        Me.txtPayrolldate.Location = New System.Drawing.Point(582, 197)
        Me.txtPayrolldate.Name = "txtPayrolldate"
        Me.txtPayrolldate.Size = New System.Drawing.Size(58, 20)
        Me.txtPayrolldate.TabIndex = 669
        Me.txtPayrolldate.Visible = False
        '
        'ProfilePic
        '
        Me.ProfilePic.Location = New System.Drawing.Point(12, 10)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.ProfilePic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.ProfilePic.Size = New System.Drawing.Size(154, 144)
        Me.ProfilePic.TabIndex = 675
        '
        'txtfullname
        '
        Me.txtfullname.EditValue = "NAME: WINTER BUGAHOD"
        Me.txtfullname.Location = New System.Drawing.Point(172, 10)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.Properties.Appearance.Options.UseFont = True
        Me.txtfullname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtfullname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfullname.Properties.ReadOnly = True
        Me.txtfullname.Size = New System.Drawing.Size(289, 18)
        Me.txtfullname.TabIndex = 674
        '
        'txtStatus
        '
        Me.txtStatus.EditValue = "EMPLOYEE STATUS: REGULAR"
        Me.txtStatus.EnterMoveNextControl = True
        Me.txtStatus.Location = New System.Drawing.Point(172, 73)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Properties.Appearance.Options.UseFont = True
        Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtStatus.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatus.Properties.MaxLength = 50
        Me.txtStatus.Properties.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(289, 18)
        Me.txtStatus.TabIndex = 678
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = "OFFICE: MANDARIN MAIN"
        Me.txtOffice.EnterMoveNextControl = True
        Me.txtOffice.Location = New System.Drawing.Point(172, 52)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtOffice.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOffice.Properties.MaxLength = 50
        Me.txtOffice.Properties.ReadOnly = True
        Me.txtOffice.Size = New System.Drawing.Size(289, 18)
        Me.txtOffice.TabIndex = 677
        '
        'txtPosition
        '
        Me.txtPosition.EditValue = "POSITION: SOFTWARE ENGINEER"
        Me.txtPosition.EnterMoveNextControl = True
        Me.txtPosition.Location = New System.Drawing.Point(172, 31)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Properties.Appearance.Options.UseFont = True
        Me.txtPosition.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPosition.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPosition.Properties.MaxLength = 50
        Me.txtPosition.Properties.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(289, 18)
        Me.txtPosition.TabIndex = 676
        '
        'txtSalaryRate
        '
        Me.txtSalaryRate.EditValue = "SALARY RATE: MONTHLY"
        Me.txtSalaryRate.EnterMoveNextControl = True
        Me.txtSalaryRate.Location = New System.Drawing.Point(172, 94)
        Me.txtSalaryRate.Name = "txtSalaryRate"
        Me.txtSalaryRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalaryRate.Properties.Appearance.Options.UseFont = True
        Me.txtSalaryRate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSalaryRate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalaryRate.Properties.MaxLength = 50
        Me.txtSalaryRate.Properties.ReadOnly = True
        Me.txtSalaryRate.Size = New System.Drawing.Size(289, 18)
        Me.txtSalaryRate.TabIndex = 679
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = "ADDITIONAL"
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(172, 241)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit2.Properties.MaxLength = 50
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(136, 18)
        Me.TextEdit2.TabIndex = 684
        '
        'TextEdit3
        '
        Me.TextEdit3.EditValue = "UNDERTIME"
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(172, 199)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit3.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit3.Properties.MaxLength = 50
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(136, 18)
        Me.TextEdit3.TabIndex = 683
        '
        'TextEdit4
        '
        Me.TextEdit4.EditValue = "LATE"
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(172, 178)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit4.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit4.Properties.MaxLength = 50
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(136, 18)
        Me.TextEdit4.TabIndex = 682
        '
        'TextEdit5
        '
        Me.TextEdit5.EditValue = "HALFDAY"
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(172, 157)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit5.Properties.Appearance.Options.UseFont = True
        Me.TextEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit5.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit5.Properties.MaxLength = 50
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(136, 18)
        Me.TextEdit5.TabIndex = 681
        '
        'TextEdit6
        '
        Me.TextEdit6.EditValue = "ABSENT"
        Me.TextEdit6.Location = New System.Drawing.Point(172, 136)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit6.Properties.Appearance.Options.UseFont = True
        Me.TextEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit6.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Size = New System.Drawing.Size(136, 18)
        Me.TextEdit6.TabIndex = 680
        '
        'txtGross
        '
        Me.txtGross.EditValue = "GROSS: 4,500.00"
        Me.txtGross.EnterMoveNextControl = True
        Me.txtGross.Location = New System.Drawing.Point(172, 115)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.Properties.Appearance.Options.UseFont = True
        Me.txtGross.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtGross.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGross.Properties.MaxLength = 50
        Me.txtGross.Properties.ReadOnly = True
        Me.txtGross.Size = New System.Drawing.Size(289, 18)
        Me.txtGross.TabIndex = 685
        '
        'TextEdit8
        '
        Me.TextEdit8.EditValue = "TOTAL DEDUCTION"
        Me.TextEdit8.EnterMoveNextControl = True
        Me.TextEdit8.Location = New System.Drawing.Point(172, 283)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit8.Properties.Appearance.Options.UseFont = True
        Me.TextEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit8.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit8.Properties.MaxLength = 50
        Me.TextEdit8.Properties.ReadOnly = True
        Me.TextEdit8.Size = New System.Drawing.Size(136, 18)
        Me.TextEdit8.TabIndex = 686
        '
        'TextEdit9
        '
        Me.TextEdit9.EditValue = "NET GROSS"
        Me.TextEdit9.EnterMoveNextControl = True
        Me.TextEdit9.Location = New System.Drawing.Point(172, 262)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit9.Properties.Appearance.Options.UseFont = True
        Me.TextEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit9.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit9.Properties.MaxLength = 50
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.Size = New System.Drawing.Size(136, 18)
        Me.TextEdit9.TabIndex = 687
        '
        'TextEdit10
        '
        Me.TextEdit10.EditValue = "NET PAY"
        Me.TextEdit10.EnterMoveNextControl = True
        Me.TextEdit10.Location = New System.Drawing.Point(172, 304)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.TextEdit10.Properties.Appearance.Options.UseFont = True
        Me.TextEdit10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit10.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit10.Properties.MaxLength = 50
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.Size = New System.Drawing.Size(136, 26)
        Me.TextEdit10.TabIndex = 688
        '
        'TextEdit11
        '
        Me.TextEdit11.EditValue = "OVERTIME"
        Me.TextEdit11.EnterMoveNextControl = True
        Me.TextEdit11.Location = New System.Drawing.Point(172, 220)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit11.Properties.Appearance.Options.UseFont = True
        Me.TextEdit11.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit11.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit11.Properties.MaxLength = 50
        Me.TextEdit11.Properties.ReadOnly = True
        Me.TextEdit11.Size = New System.Drawing.Size(136, 18)
        Me.TextEdit11.TabIndex = 689
        '
        'txtOvertime
        '
        Me.txtOvertime.EditValue = "0.00"
        Me.txtOvertime.EnterMoveNextControl = True
        Me.txtOvertime.Location = New System.Drawing.Point(314, 220)
        Me.txtOvertime.Name = "txtOvertime"
        Me.txtOvertime.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOvertime.Properties.Appearance.Options.UseFont = True
        Me.txtOvertime.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOvertime.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOvertime.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtOvertime.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOvertime.Properties.Mask.EditMask = "n"
        Me.txtOvertime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOvertime.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtOvertime.Properties.MaxLength = 50
        Me.txtOvertime.Properties.ReadOnly = True
        Me.txtOvertime.Size = New System.Drawing.Size(147, 18)
        Me.txtOvertime.TabIndex = 698
        '
        'txtNetPay
        '
        Me.txtNetPay.EditValue = "0.00"
        Me.txtNetPay.EnterMoveNextControl = True
        Me.txtNetPay.Location = New System.Drawing.Point(314, 304)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtNetPay.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.txtNetPay.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNetPay.Properties.Appearance.Options.UseBackColor = True
        Me.txtNetPay.Properties.Appearance.Options.UseFont = True
        Me.txtNetPay.Properties.Appearance.Options.UseForeColor = True
        Me.txtNetPay.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNetPay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNetPay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtNetPay.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNetPay.Properties.Mask.EditMask = "n"
        Me.txtNetPay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNetPay.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNetPay.Properties.MaxLength = 50
        Me.txtNetPay.Properties.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(147, 26)
        Me.txtNetPay.TabIndex = 697
        '
        'txtNetGross
        '
        Me.txtNetGross.EditValue = "0.00"
        Me.txtNetGross.EnterMoveNextControl = True
        Me.txtNetGross.Location = New System.Drawing.Point(314, 262)
        Me.txtNetGross.Name = "txtNetGross"
        Me.txtNetGross.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetGross.Properties.Appearance.Options.UseFont = True
        Me.txtNetGross.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNetGross.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNetGross.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtNetGross.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNetGross.Properties.Mask.EditMask = "n"
        Me.txtNetGross.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNetGross.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNetGross.Properties.MaxLength = 50
        Me.txtNetGross.Properties.ReadOnly = True
        Me.txtNetGross.Size = New System.Drawing.Size(147, 18)
        Me.txtNetGross.TabIndex = 696
        '
        'txtDeduction
        '
        Me.txtDeduction.EditValue = "0.00"
        Me.txtDeduction.EnterMoveNextControl = True
        Me.txtDeduction.Location = New System.Drawing.Point(314, 283)
        Me.txtDeduction.Name = "txtDeduction"
        Me.txtDeduction.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeduction.Properties.Appearance.Options.UseFont = True
        Me.txtDeduction.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeduction.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDeduction.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDeduction.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeduction.Properties.Mask.EditMask = "n"
        Me.txtDeduction.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDeduction.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDeduction.Properties.MaxLength = 50
        Me.txtDeduction.Properties.ReadOnly = True
        Me.txtDeduction.Size = New System.Drawing.Size(147, 18)
        Me.txtDeduction.TabIndex = 695
        '
        'txtAdditional
        '
        Me.txtAdditional.EditValue = "0.00"
        Me.txtAdditional.EnterMoveNextControl = True
        Me.txtAdditional.Location = New System.Drawing.Point(314, 241)
        Me.txtAdditional.Name = "txtAdditional"
        Me.txtAdditional.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdditional.Properties.Appearance.Options.UseFont = True
        Me.txtAdditional.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAdditional.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAdditional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtAdditional.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdditional.Properties.Mask.EditMask = "n"
        Me.txtAdditional.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdditional.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAdditional.Properties.MaxLength = 50
        Me.txtAdditional.Properties.ReadOnly = True
        Me.txtAdditional.Size = New System.Drawing.Size(147, 18)
        Me.txtAdditional.TabIndex = 694
        '
        'txtUndertime
        '
        Me.txtUndertime.EditValue = "0.00"
        Me.txtUndertime.EnterMoveNextControl = True
        Me.txtUndertime.Location = New System.Drawing.Point(314, 199)
        Me.txtUndertime.Name = "txtUndertime"
        Me.txtUndertime.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUndertime.Properties.Appearance.Options.UseFont = True
        Me.txtUndertime.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUndertime.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUndertime.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtUndertime.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUndertime.Properties.Mask.EditMask = "n"
        Me.txtUndertime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUndertime.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUndertime.Properties.MaxLength = 50
        Me.txtUndertime.Properties.ReadOnly = True
        Me.txtUndertime.Size = New System.Drawing.Size(147, 18)
        Me.txtUndertime.TabIndex = 693
        '
        'txtLate
        '
        Me.txtLate.EditValue = "0.00"
        Me.txtLate.EnterMoveNextControl = True
        Me.txtLate.Location = New System.Drawing.Point(314, 178)
        Me.txtLate.Name = "txtLate"
        Me.txtLate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLate.Properties.Appearance.Options.UseFont = True
        Me.txtLate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtLate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLate.Properties.Mask.EditMask = "n"
        Me.txtLate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtLate.Properties.MaxLength = 50
        Me.txtLate.Properties.ReadOnly = True
        Me.txtLate.Size = New System.Drawing.Size(147, 18)
        Me.txtLate.TabIndex = 692
        '
        'txtHalfDay
        '
        Me.txtHalfDay.EditValue = "0.00"
        Me.txtHalfDay.EnterMoveNextControl = True
        Me.txtHalfDay.Location = New System.Drawing.Point(314, 157)
        Me.txtHalfDay.Name = "txtHalfDay"
        Me.txtHalfDay.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHalfDay.Properties.Appearance.Options.UseFont = True
        Me.txtHalfDay.Properties.Appearance.Options.UseTextOptions = True
        Me.txtHalfDay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtHalfDay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtHalfDay.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHalfDay.Properties.Mask.EditMask = "n"
        Me.txtHalfDay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtHalfDay.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtHalfDay.Properties.MaxLength = 50
        Me.txtHalfDay.Properties.ReadOnly = True
        Me.txtHalfDay.Size = New System.Drawing.Size(147, 18)
        Me.txtHalfDay.TabIndex = 691
        '
        'txtAbsent
        '
        Me.txtAbsent.EditValue = "0.00"
        Me.txtAbsent.Location = New System.Drawing.Point(314, 136)
        Me.txtAbsent.Name = "txtAbsent"
        Me.txtAbsent.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbsent.Properties.Appearance.Options.UseFont = True
        Me.txtAbsent.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAbsent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAbsent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtAbsent.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbsent.Properties.Mask.EditMask = "n"
        Me.txtAbsent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAbsent.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAbsent.Properties.ReadOnly = True
        Me.txtAbsent.Size = New System.Drawing.Size(147, 18)
        Me.txtAbsent.TabIndex = 690
        '
        'cmdLoadData
        '
        Me.cmdLoadData.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdLoadData.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdLoadData.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdLoadData.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdLoadData.Appearance.Options.UseBackColor = True
        Me.cmdLoadData.Appearance.Options.UseFont = True
        Me.cmdLoadData.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdLoadData.Location = New System.Drawing.Point(12, 159)
        Me.cmdLoadData.Name = "cmdLoadData"
        Me.cmdLoadData.Size = New System.Drawing.Size(154, 26)
        Me.cmdLoadData.TabIndex = 727
        Me.cmdLoadData.Text = "Print Payslip"
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(30, 220)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.mode.Properties.MaxLength = 50
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(61, 18)
        Me.mode.TabIndex = 728
        Me.mode.Visible = False
        '
        'ckCurrent
        '
        Me.ckCurrent.Location = New System.Drawing.Point(30, 191)
        Me.ckCurrent.Name = "ckCurrent"
        Me.ckCurrent.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckCurrent.Properties.Appearance.Options.UseFont = True
        Me.ckCurrent.Properties.Caption = "Current Payroll"
        Me.ckCurrent.Properties.ReadOnly = True
        Me.ckCurrent.Size = New System.Drawing.Size(128, 19)
        Me.ckCurrent.TabIndex = 799
        Me.ckCurrent.Visible = False
        '
        'frmPayrollProcessPayslip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 345)
        Me.Controls.Add(Me.ckCurrent)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cmdLoadData)
        Me.Controls.Add(Me.txtOvertime)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtNetGross)
        Me.Controls.Add(Me.txtAdditional)
        Me.Controls.Add(Me.txtUndertime)
        Me.Controls.Add(Me.txtLate)
        Me.Controls.Add(Me.txtHalfDay)
        Me.Controls.Add(Me.txtAbsent)
        Me.Controls.Add(Me.TextEdit11)
        Me.Controls.Add(Me.TextEdit10)
        Me.Controls.Add(Me.TextEdit9)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.TextEdit3)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.TextEdit5)
        Me.Controls.Add(Me.TextEdit6)
        Me.Controls.Add(Me.txtSalaryRate)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.ProfilePic)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.txtPayrolldate)
        Me.Controls.Add(Me.employeeid)
        Me.Controls.Add(Me.schedulecode)
        Me.Controls.Add(Me.payrollcode)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtDeduction)
        Me.Controls.Add(Me.TextEdit8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayrollProcessPayslip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Payslip"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayrolldate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilePic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalaryRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGross.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOvertime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetGross.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeduction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdditional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUndertime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHalfDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbsent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckCurrent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents payrollcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents schedulecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents employeeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPayrolldate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProfilePic As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtfullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSalaryRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOffice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPosition As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOvertime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNetPay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNetGross As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeduction As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdditional As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUndertime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHalfDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAbsent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGross As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdLoadData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckCurrent As DevExpress.XtraEditors.CheckEdit
End Class
