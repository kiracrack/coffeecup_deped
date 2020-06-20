<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptPayrollPayslip
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCompanyNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyName = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtAbsent = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtHalfDay = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtEmployeeStatus = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtColor = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtSalaryRate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtGross = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtLate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtUndertime = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtAdditional = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtOvertime = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtNetGross = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtTotalDeduction = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtNetPay = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtOffice = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtPosition = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtEmployeeName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtPayrollCode = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtPayrollPeriod = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCompanyNumber, Me.txtCompanyAddress, Me.txtCompanyName})
        Me.TopMargin.HeightF = 91.62504!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyNumber
        '
        Me.txtCompanyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyNumber.LocationFloat = New DevExpress.Utils.PointFloat(4.124691!, 63.33334!)
        Me.txtCompanyNumber.Name = "txtCompanyNumber"
        Me.txtCompanyNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyNumber.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyNumber.StylePriority.UseFont = False
        Me.txtCompanyNumber.StylePriority.UseTextAlignment = False
        Me.txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtCompanyNumber.Visible = False
        '
        'txtCompanyAddress
        '
        Me.txtCompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyAddress.LocationFloat = New DevExpress.Utils.PointFloat(4.124691!, 41.45833!)
        Me.txtCompanyAddress.Name = "txtCompanyAddress"
        Me.txtCompanyAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyAddress.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyAddress.StylePriority.UseFont = False
        Me.txtCompanyAddress.StylePriority.UseTextAlignment = False
        Me.txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(4.124691!, 19.58333!)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyName.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyName.StylePriority.UseFont = False
        Me.txtCompanyName.StylePriority.UseTextAlignment = False
        Me.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtCompanyName.Visible = False
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.XrTable2, Me.XrLabel18})
        Me.ReportHeader.HeightF = 254.3748!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(421.3148!, 34.50004!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2, Me.XrTableRow7, Me.XrTableRow8, Me.XrTableRow10, Me.XrTableRow9, Me.XrTableRow11, Me.XrTableRow12, Me.XrTableRow13})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(306.8101!, 206.25!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UsePadding = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.txtAbsent})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "ABSENT"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 1.4919349220179352R
        '
        'txtAbsent
        '
        Me.txtAbsent.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtAbsent.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtAbsent.Name = "txtAbsent"
        Me.txtAbsent.StylePriority.UseBorders = False
        Me.txtAbsent.StylePriority.UseFont = False
        Me.txtAbsent.StylePriority.UseTextAlignment = False
        Me.txtAbsent.Text = "0.00"
        Me.txtAbsent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtAbsent.Weight = 1.5080650779820648R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.txtHalfDay})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.Text = "HALFDAY"
        Me.XrTableCell4.Weight = 1.4919338869154464R
        '
        'txtHalfDay
        '
        Me.txtHalfDay.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtHalfDay.Name = "txtHalfDay"
        Me.txtHalfDay.StylePriority.UseFont = False
        Me.txtHalfDay.StylePriority.UseTextAlignment = False
        Me.txtHalfDay.Text = "0.00"
        Me.txtHalfDay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtHalfDay.Weight = 1.5080661130845536R
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.004967054!, 34.49998!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5, Me.XrTableRow6, Me.XrTableRow16, Me.XrTableRow19, Me.XrTableRow15, Me.XrTableRow14, Me.XrTableRow4, Me.XrTableRow18, Me.XrTableRow3})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(407.7681!, 206.25!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UsePadding = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell32, Me.txtEmployeeStatus})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.Text = "EMPLOYEE STATUS"
        Me.XrTableCell32.Weight = 1.0581009891892068R
        '
        'txtEmployeeStatus
        '
        Me.txtEmployeeStatus.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtEmployeeStatus.Name = "txtEmployeeStatus"
        Me.txtEmployeeStatus.StylePriority.UseFont = False
        Me.txtEmployeeStatus.StylePriority.UseTextAlignment = False
        Me.txtEmployeeStatus.Text = "REGULAR"
        Me.txtEmployeeStatus.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtEmployeeStatus.Weight = 1.9418990108107936R
        '
        'XrTableRow18
        '
        Me.XrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtColor, Me.txtSalaryRate})
        Me.XrTableRow18.Name = "XrTableRow18"
        Me.XrTableRow18.Weight = 1.0R
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Name = "txtColor"
        Me.txtColor.StylePriority.UseFont = False
        Me.txtColor.StylePriority.UseTextAlignment = False
        Me.txtColor.Text = "SALARY RATE"
        Me.txtColor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtColor.Weight = 1.0581009263850778R
        '
        'txtSalaryRate
        '
        Me.txtSalaryRate.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtSalaryRate.Name = "txtSalaryRate"
        Me.txtSalaryRate.StylePriority.UseFont = False
        Me.txtSalaryRate.StylePriority.UseTextAlignment = False
        Me.txtSalaryRate.Text = "MONTHLY"
        Me.txtSalaryRate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtSalaryRate.Weight = 1.9418990736149226R
        '
        'XrLabel18
        '
        Me.XrLabel18.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 13.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.ForeColor = System.Drawing.Color.Black
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(2.124691!, 6.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(726.1201!, 24.08333!)
        Me.XrLabel18.StylePriority.UseBackColor = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "P A Y S L I P"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'FormattingRule1
        '
        '
        '
        '
        Me.FormattingRule1.Formatting.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.txtGross})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "GROSS"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell2.Weight = 1.0581009263850778R
        '
        'txtGross
        '
        Me.txtGross.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.StylePriority.UseFont = False
        Me.txtGross.StylePriority.UseTextAlignment = False
        Me.txtGross.Text = "4,000.00"
        Me.txtGross.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtGross.Weight = 1.9418990736149226R
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.txtLate})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.Text = "LATE"
        Me.XrTableCell5.Weight = 1.4919338869154464R
        '
        'txtLate
        '
        Me.txtLate.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtLate.Name = "txtLate"
        Me.txtLate.StylePriority.UseFont = False
        Me.txtLate.StylePriority.UseTextAlignment = False
        Me.txtLate.Text = "0.00"
        Me.txtLate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtLate.Weight = 1.5080661130845536R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15, Me.txtUndertime})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.Text = "UNDERTIME"
        Me.XrTableCell15.Weight = 1.4919338869154464R
        '
        'txtUndertime
        '
        Me.txtUndertime.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtUndertime.Name = "txtUndertime"
        Me.txtUndertime.StylePriority.UseFont = False
        Me.txtUndertime.StylePriority.UseTextAlignment = False
        Me.txtUndertime.Text = "0.00"
        Me.txtUndertime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtUndertime.Weight = 1.5080661130845536R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell17, Me.txtAdditional})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.0R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.Text = "ADDITIONAL"
        Me.XrTableCell17.Weight = 1.4919338869154464R
        '
        'txtAdditional
        '
        Me.txtAdditional.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtAdditional.Name = "txtAdditional"
        Me.txtAdditional.StylePriority.UseFont = False
        Me.txtAdditional.StylePriority.UseTextAlignment = False
        Me.txtAdditional.Text = "0.00"
        Me.txtAdditional.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtAdditional.Weight = 1.5080661130845536R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell19, Me.txtOvertime})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseFont = False
        Me.XrTableCell19.Text = "OVERTIME"
        Me.XrTableCell19.Weight = 1.4919338869154464R
        '
        'txtOvertime
        '
        Me.txtOvertime.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtOvertime.Name = "txtOvertime"
        Me.txtOvertime.StylePriority.UseFont = False
        Me.txtOvertime.StylePriority.UseTextAlignment = False
        Me.txtOvertime.Text = "0.00"
        Me.txtOvertime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtOvertime.Weight = 1.5080661130845536R
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.txtNetGross})
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Weight = 1.0R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.Text = "NET GROSS"
        Me.XrTableCell21.Weight = 1.4919338869154464R
        '
        'txtNetGross
        '
        Me.txtNetGross.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtNetGross.Name = "txtNetGross"
        Me.txtNetGross.StylePriority.UseFont = False
        Me.txtNetGross.StylePriority.UseTextAlignment = False
        Me.txtNetGross.Text = "0.00"
        Me.txtNetGross.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtNetGross.Weight = 1.5080661130845536R
        '
        'XrTableRow12
        '
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell24, Me.txtTotalDeduction})
        Me.XrTableRow12.Name = "XrTableRow12"
        Me.XrTableRow12.Weight = 1.0R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.Text = "TOTAL DEDUCTION"
        Me.XrTableCell24.Weight = 1.4919338869154464R
        '
        'txtTotalDeduction
        '
        Me.txtTotalDeduction.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtTotalDeduction.Name = "txtTotalDeduction"
        Me.txtTotalDeduction.StylePriority.UseFont = False
        Me.txtTotalDeduction.StylePriority.UseTextAlignment = False
        Me.txtTotalDeduction.Text = "0.00"
        Me.txtTotalDeduction.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtTotalDeduction.Weight = 1.5080661130845536R
        '
        'XrTableRow13
        '
        Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell28, Me.txtNetPay})
        Me.XrTableRow13.Name = "XrTableRow13"
        Me.XrTableRow13.Weight = 1.0R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.BackColor = System.Drawing.Color.Yellow
        Me.XrTableCell28.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseBackColor = False
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.Text = "NET PAY"
        Me.XrTableCell28.Weight = 1.4919338869154464R
        '
        'txtNetPay
        '
        Me.txtNetPay.BackColor = System.Drawing.Color.Yellow
        Me.txtNetPay.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.StylePriority.UseBackColor = False
        Me.txtNetPay.StylePriority.UseFont = False
        Me.txtNetPay.StylePriority.UseTextAlignment = False
        Me.txtNetPay.Text = "0.00"
        Me.txtNetPay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtNetPay.Weight = 1.5080661130845536R
        '
        'XrTableRow14
        '
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell30, Me.txtOffice})
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.Weight = 1.0R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseFont = False
        Me.XrTableCell30.Text = "OFFICE"
        Me.XrTableCell30.Weight = 1.0581009891892068R
        '
        'txtOffice
        '
        Me.txtOffice.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.StylePriority.UseFont = False
        Me.txtOffice.StylePriority.UseTextAlignment = False
        Me.txtOffice.Text = "IT DEPARTMENT"
        Me.txtOffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtOffice.Weight = 1.9418990108107936R
        '
        'XrTableRow15
        '
        Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell34, Me.txtPosition})
        Me.XrTableRow15.Name = "XrTableRow15"
        Me.XrTableRow15.Weight = 1.0R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StylePriority.UseFont = False
        Me.XrTableCell34.Text = "POSITION"
        Me.XrTableCell34.Weight = 1.0581009891892068R
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.StylePriority.UseFont = False
        Me.txtPosition.StylePriority.UseTextAlignment = False
        Me.txtPosition.Text = "SOFTWARE ENGINEER"
        Me.txtPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtPosition.Weight = 1.9418990108107936R
        '
        'XrTableRow19
        '
        Me.XrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell36, Me.txtEmployeeName})
        Me.XrTableRow19.Name = "XrTableRow19"
        Me.XrTableRow19.Weight = 1.0R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StylePriority.UseFont = False
        Me.XrTableCell36.Text = "EMPLOYEE NAME"
        Me.XrTableCell36.Weight = 1.0581009891892068R
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.StylePriority.UseFont = False
        Me.txtEmployeeName.StylePriority.UseTextAlignment = False
        Me.txtEmployeeName.Text = "WINTER S. BUGAHOD"
        Me.txtEmployeeName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtEmployeeName.Weight = 1.9418990108107936R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.txtPayrollCode})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.Text = "PAYROLL CODE"
        Me.XrTableCell6.Weight = 1.0581009891892068R
        '
        'txtPayrollCode
        '
        Me.txtPayrollCode.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtPayrollCode.Name = "txtPayrollCode"
        Me.txtPayrollCode.StylePriority.UseFont = False
        Me.txtPayrollCode.StylePriority.UseTextAlignment = False
        Me.txtPayrollCode.Text = "10P2016-0712-0920"
        Me.txtPayrollCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtPayrollCode.Weight = 1.9418990108107936R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.txtPayrollPeriod})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.Text = "PERIOD COVERVED"
        Me.XrTableCell8.Weight = 1.0581009891892068R
        '
        'txtPayrollPeriod
        '
        Me.txtPayrollPeriod.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtPayrollPeriod.Name = "txtPayrollPeriod"
        Me.txtPayrollPeriod.StylePriority.UseFont = False
        Me.txtPayrollPeriod.StylePriority.UseTextAlignment = False
        Me.txtPayrollPeriod.Text = "JULY 26, 2016 - AUGUST 10, 2016"
        Me.txtPayrollPeriod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtPayrollPeriod.Weight = 1.9418990108107936R
        '
        'XrTableRow16
        '
        Me.XrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.XrTableCell11})
        Me.XrTableRow16.Name = "XrTableRow16"
        Me.XrTableRow16.Weight = 1.0R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.Weight = 1.0581009891892068R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell11.Weight = 1.9418990108107936R
        '
        'rptPayrollPayslip
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(56, 65, 92, 0)
        Me.Version = "15.1"
        Me.Watermark.Font = New System.Drawing.Font("Arial", 44.0!)
        Me.Watermark.ShowBehind = False
        Me.Watermark.Text = "CONFIDENTIAL"
        Me.Watermark.TextTransparency = 153
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtCompanyNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtEmployeeStatus As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow18 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtColor As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtSalaryRate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtAbsent As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtHalfDay As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtGross As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtLate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtUndertime As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtOvertime As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtAdditional As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtNetGross As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtTotalDeduction As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtNetPay As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow19 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtEmployeeName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow15 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtPosition As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtOffice As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtPayrollCode As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtPayrollPeriod As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow16 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
End Class
