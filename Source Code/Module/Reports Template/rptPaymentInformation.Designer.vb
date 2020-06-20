<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptPaymentInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPaymentInformation))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCompanyNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyName = New DevExpress.XtraReports.UI.XRLabel()
        Me.logo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.txtCopyright = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.txtOpenBalance = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtRequestCode = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTotalPaid = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtvendor = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDateReport = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtGrandTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.txtApprovedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtApprovedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtApprovedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.lineApproved = New DevExpress.XtraReports.UI.XRLine()
        Me.txtpreparedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPreparedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.lineChecked = New DevExpress.XtraReports.UI.XRLine()
        Me.txtCheckedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPreparedTitle = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCompanyNumber, Me.txtCompanyAddress, Me.txtCompanyName, Me.logo})
        Me.TopMargin.HeightF = 134.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyNumber
        '
        Me.txtCompanyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyNumber.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 101.25!)
        Me.txtCompanyNumber.Name = "txtCompanyNumber"
        Me.txtCompanyNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyNumber.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyNumber.StylePriority.UseFont = False
        Me.txtCompanyNumber.StylePriority.UseTextAlignment = False
        Me.txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyAddress
        '
        Me.txtCompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyAddress.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 79.375!)
        Me.txtCompanyAddress.Name = "txtCompanyAddress"
        Me.txtCompanyAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyAddress.SizeF = New System.Drawing.SizeF(719.0001!, 21.875!)
        Me.txtCompanyAddress.StylePriority.UseFont = False
        Me.txtCompanyAddress.StylePriority.UseTextAlignment = False
        Me.txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 57.5!)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyName.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyName.StylePriority.UseFont = False
        Me.txtCompanyName.StylePriority.UseTextAlignment = False
        Me.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.logo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 7.000007!)
        Me.logo.Name = "logo"
        Me.logo.SizeF = New System.Drawing.SizeF(730.0!, 118.5!)
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.txtCopyright})
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.ForeColor = System.Drawing.Color.DimGray
        Me.XrPageInfo1.Format = "Page {0}/{1}  of Total Pages"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(20.70837!, 6.999969!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(147.6657!, 15.625!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseForeColor = False
        '
        'txtCopyright
        '
        Me.txtCopyright.Font = New System.Drawing.Font("Arial Narrow", 7.75!, System.Drawing.FontStyle.Italic)
        Me.txtCopyright.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCopyright.LocationFloat = New DevExpress.Utils.PointFloat(168.374!, 6.999969!)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCopyright.SizeF = New System.Drawing.SizeF(561.6259!, 15.625!)
        Me.txtCopyright.StylePriority.UseFont = False
        Me.txtCopyright.StylePriority.UseForeColor = False
        Me.txtCopyright.StylePriority.UseTextAlignment = False
        Me.txtCopyright.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtOpenBalance, Me.XrLabel2, Me.txtRequestCode, Me.XrLabel4, Me.txtTotalPaid, Me.XrLabel3, Me.txtReportTitle, Me.XrLabel7, Me.txtvendor, Me.txtDateReport, Me.XrLabel1, Me.txtGrandTotal})
        Me.ReportHeader.HeightF = 154.5416!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'txtOpenBalance
        '
        Me.txtOpenBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpenBalance.LocationFloat = New DevExpress.Utils.PointFloat(151.0!, 134.2916!)
        Me.txtOpenBalance.Name = "txtOpenBalance"
        Me.txtOpenBalance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtOpenBalance.SizeF = New System.Drawing.SizeF(157.0425!, 15.625!)
        Me.txtOpenBalance.StylePriority.UseFont = False
        Me.txtOpenBalance.StylePriority.UseTextAlignment = False
        Me.txtOpenBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 134.2916!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(147.6657!, 15.625!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "OPEN BALANCE:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtRequestCode
        '
        Me.txtRequestCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestCode.LocationFloat = New DevExpress.Utils.PointFloat(150.7085!, 57.87498!)
        Me.txtRequestCode.Name = "txtRequestCode"
        Me.txtRequestCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtRequestCode.SizeF = New System.Drawing.SizeF(572.3333!, 15.62502!)
        Me.txtRequestCode.StylePriority.UseFont = False
        Me.txtRequestCode.StylePriority.UseTextAlignment = False
        Me.txtRequestCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 57.87498!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(147.6657!, 15.625!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "REQUEST CODE:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtTotalPaid
        '
        Me.txtTotalPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPaid.LocationFloat = New DevExpress.Utils.PointFloat(151.0!, 116.2916!)
        Me.txtTotalPaid.Name = "txtTotalPaid"
        Me.txtTotalPaid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTotalPaid.SizeF = New System.Drawing.SizeF(157.0424!, 15.62502!)
        Me.txtTotalPaid.StylePriority.UseFont = False
        Me.txtTotalPaid.StylePriority.UseTextAlignment = False
        Me.txtTotalPaid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 116.2916!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(147.6657!, 15.625!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "TOTAL PAID:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 25.00001!)
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtReportTitle.SizeF = New System.Drawing.SizeF(584.8333!, 22.58333!)
        Me.txtReportTitle.StylePriority.UseFont = False
        Me.txtReportTitle.StylePriority.UseTextAlignment = False
        Me.txtReportTitle.Text = "SUMMARY REPORT"
        Me.txtReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 75.49997!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(147.6657!, 15.625!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "SUPPLIER/VENDOR:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtvendor
        '
        Me.txtvendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendor.LocationFloat = New DevExpress.Utils.PointFloat(150.6657!, 75.49998!)
        Me.txtvendor.Name = "txtvendor"
        Me.txtvendor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtvendor.SizeF = New System.Drawing.SizeF(572.3333!, 15.62501!)
        Me.txtvendor.StylePriority.UseFont = False
        Me.txtvendor.StylePriority.UseTextAlignment = False
        Me.txtvendor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtDateReport
        '
        Me.txtDateReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateReport.LocationFloat = New DevExpress.Utils.PointFloat(515.3322!, 134.2916!)
        Me.txtDateReport.Name = "txtDateReport"
        Me.txtDateReport.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDateReport.SizeF = New System.Drawing.SizeF(204.6677!, 15.625!)
        Me.txtDateReport.StylePriority.UseFont = False
        Me.txtDateReport.StylePriority.UseTextAlignment = False
        Me.txtDateReport.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 97.2083!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(147.6657!, 15.625!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "PRINCIPAL TOTAL:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.LocationFloat = New DevExpress.Utils.PointFloat(150.6657!, 97.2083!)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtGrandTotal.SizeF = New System.Drawing.SizeF(157.0425!, 15.62502!)
        Me.txtGrandTotal.StylePriority.UseFont = False
        Me.txtGrandTotal.StylePriority.UseTextAlignment = False
        Me.txtGrandTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtApprovedPosition, Me.txtApprovedTitle, Me.txtApprovedName, Me.lineApproved, Me.txtpreparedName, Me.txtPreparedPosition, Me.XrLine3, Me.lineChecked, Me.txtCheckedPosition, Me.txtCheckedName, Me.txtCheckedTitle, Me.txtPreparedTitle})
        Me.GroupFooter1.HeightF = 252.125!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txtApprovedPosition
        '
        Me.txtApprovedPosition.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtApprovedPosition.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 236.5!)
        Me.txtApprovedPosition.Name = "txtApprovedPosition"
        Me.txtApprovedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedPosition.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtApprovedPosition.StylePriority.UseFont = False
        Me.txtApprovedPosition.StylePriority.UseTextAlignment = False
        Me.txtApprovedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtApprovedTitle
        '
        Me.txtApprovedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedTitle.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 149.0!)
        Me.txtApprovedTitle.Name = "txtApprovedTitle"
        Me.txtApprovedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 22.91666!)
        Me.txtApprovedTitle.StylePriority.UseFont = False
        Me.txtApprovedTitle.StylePriority.UseTextAlignment = False
        Me.txtApprovedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtApprovedName
        '
        Me.txtApprovedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedName.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 220.0!)
        Me.txtApprovedName.Name = "txtApprovedName"
        Me.txtApprovedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedName.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtApprovedName.StylePriority.UseFont = False
        Me.txtApprovedName.StylePriority.UseTextAlignment = False
        Me.txtApprovedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lineApproved
        '
        Me.lineApproved.ForeColor = System.Drawing.Color.Gray
        Me.lineApproved.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 211.5!)
        Me.lineApproved.Name = "lineApproved"
        Me.lineApproved.SizeF = New System.Drawing.SizeF(282.7082!, 7.291672!)
        Me.lineApproved.StylePriority.UseForeColor = False
        '
        'txtpreparedName
        '
        Me.txtpreparedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreparedName.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 95.0!)
        Me.txtpreparedName.Name = "txtpreparedName"
        Me.txtpreparedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtpreparedName.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtpreparedName.StylePriority.UseFont = False
        Me.txtpreparedName.StylePriority.UseTextAlignment = False
        Me.txtpreparedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtPreparedPosition
        '
        Me.txtPreparedPosition.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtPreparedPosition.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 111.5!)
        Me.txtPreparedPosition.Name = "txtPreparedPosition"
        Me.txtPreparedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPreparedPosition.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtPreparedPosition.StylePriority.UseFont = False
        Me.txtPreparedPosition.StylePriority.UseTextAlignment = False
        Me.txtPreparedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.ForeColor = System.Drawing.Color.Gray
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 86.5!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(282.7082!, 7.291672!)
        Me.XrLine3.StylePriority.UseForeColor = False
        '
        'lineChecked
        '
        Me.lineChecked.ForeColor = System.Drawing.Color.Gray
        Me.lineChecked.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 86.5!)
        Me.lineChecked.Name = "lineChecked"
        Me.lineChecked.SizeF = New System.Drawing.SizeF(282.7082!, 7.291672!)
        Me.lineChecked.StylePriority.UseForeColor = False
        '
        'txtCheckedPosition
        '
        Me.txtCheckedPosition.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtCheckedPosition.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 111.5!)
        Me.txtCheckedPosition.Name = "txtCheckedPosition"
        Me.txtCheckedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedPosition.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtCheckedPosition.StylePriority.UseFont = False
        Me.txtCheckedPosition.StylePriority.UseTextAlignment = False
        Me.txtCheckedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtCheckedName
        '
        Me.txtCheckedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckedName.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 95.0!)
        Me.txtCheckedName.Name = "txtCheckedName"
        Me.txtCheckedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedName.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtCheckedName.StylePriority.UseFont = False
        Me.txtCheckedName.StylePriority.UseTextAlignment = False
        Me.txtCheckedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtCheckedTitle
        '
        Me.txtCheckedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckedTitle.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 24.0!)
        Me.txtCheckedTitle.Name = "txtCheckedTitle"
        Me.txtCheckedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 22.91666!)
        Me.txtCheckedTitle.StylePriority.UseFont = False
        Me.txtCheckedTitle.StylePriority.UseTextAlignment = False
        Me.txtCheckedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtPreparedTitle
        '
        Me.txtPreparedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreparedTitle.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 24.0!)
        Me.txtPreparedTitle.Name = "txtPreparedTitle"
        Me.txtPreparedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPreparedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 22.91666!)
        Me.txtPreparedTitle.StylePriority.UseFont = False
        Me.txtPreparedTitle.StylePriority.UseTextAlignment = False
        Me.txtPreparedTitle.Text = "Prepared by:"
        Me.txtPreparedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptPaymentInformation
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupFooter1})
        Me.Margins = New System.Drawing.Printing.Margins(63, 57, 134, 50)
        Me.Version = "15.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents txtDateReport As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtGrandTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtvendor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents txtTotalPaid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtApprovedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtApprovedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtApprovedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lineApproved As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtpreparedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPreparedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lineChecked As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtCheckedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPreparedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtRequestCode As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtOpenBalance As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
