<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptVoucher
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
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCompanyNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyName = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgReportHeader = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.imgReportFooter = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtCopyright = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.txtDetails = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDatePayment = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtVoucherType = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtVoucherNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtVendorSuplier = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTotalAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtVoucherDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPreparedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.lineChecked = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtPreparedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtpreparedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.lineApproved = New DevExpress.XtraReports.UI.XRLine()
        Me.txtApprovedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtApprovedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtAmountInWords = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
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
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCompanyNumber, Me.txtCompanyAddress, Me.txtCompanyName, Me.imgReportHeader})
        Me.TopMargin.HeightF = 122.9167!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyNumber
        '
        Me.txtCompanyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyNumber.LocationFloat = New DevExpress.Utils.PointFloat(5.499939!, 93.39585!)
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
        Me.txtCompanyAddress.LocationFloat = New DevExpress.Utils.PointFloat(5.499939!, 71.52085!)
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
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(5.499939!, 49.64585!)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyName.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyName.StylePriority.UseFont = False
        Me.txtCompanyName.StylePriority.UseTextAlignment = False
        Me.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'imgReportHeader
        '
        Me.imgReportHeader.BorderWidth = 0.0!
        Me.imgReportHeader.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.imgReportHeader.KeepTogether = False
        Me.imgReportHeader.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.imgReportHeader.Name = "imgReportHeader"
        Me.imgReportHeader.SizeF = New System.Drawing.SizeF(727.0833!, 122.9167!)
        Me.imgReportHeader.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        Me.imgReportHeader.StylePriority.UseBorderWidth = False
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.imgReportFooter})
        Me.BottomMargin.HeightF = 118.5!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'imgReportFooter
        '
        Me.imgReportFooter.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.imgReportFooter.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.imgReportFooter.Name = "imgReportFooter"
        Me.imgReportFooter.SizeF = New System.Drawing.SizeF(730.0!, 118.5!)
        Me.imgReportFooter.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'txtCopyright
        '
        Me.txtCopyright.Font = New System.Drawing.Font("Arial Narrow", 7.75!, System.Drawing.FontStyle.Italic)
        Me.txtCopyright.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCopyright.LocationFloat = New DevExpress.Utils.PointFloat(22.25019!, 350.6666!)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCopyright.SizeF = New System.Drawing.SizeF(707.7499!, 15.625!)
        Me.txtCopyright.StylePriority.UseFont = False
        Me.txtCopyright.StylePriority.UseForeColor = False
        Me.txtCopyright.StylePriority.UseTextAlignment = False
        Me.txtCopyright.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.txtCopyright.Visible = False
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtDetails, Me.XrLabel3, Me.lblDatePayment, Me.txtVoucherType, Me.txtVoucherNo, Me.XrLabel8, Me.txtVendorSuplier, Me.XrLabel9, Me.XrLabel5, Me.txtTotalAmount, Me.txtVoucherDate})
        Me.ReportHeader.HeightF = 125.75!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'txtDetails
        '
        Me.txtDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.LocationFloat = New DevExpress.Utils.PointFloat(128.1667!, 100.125!)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDetails.SizeF = New System.Drawing.SizeF(573.3752!, 15.62502!)
        Me.txtDetails.StylePriority.UseFont = False
        Me.txtDetails.StylePriority.UseTextAlignment = False
        Me.txtDetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(38.2499!, 100.125!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(86.87488!, 15.62502!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "PURPOSE:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblDatePayment
        '
        Me.lblDatePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.lblDatePayment.LocationFloat = New DevExpress.Utils.PointFloat(38.24994!, 82.41666!)
        Me.lblDatePayment.Name = "lblDatePayment"
        Me.lblDatePayment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDatePayment.SizeF = New System.Drawing.SizeF(86.87488!, 15.62502!)
        Me.lblDatePayment.StylePriority.UseFont = False
        Me.lblDatePayment.StylePriority.UseTextAlignment = False
        Me.lblDatePayment.Text = "DATE VOUCHER:"
        Me.lblDatePayment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtVoucherType
        '
        Me.txtVoucherType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherType.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 7.000001!)
        Me.txtVoucherType.Name = "txtVoucherType"
        Me.txtVoucherType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVoucherType.SizeF = New System.Drawing.SizeF(728.0!, 22.58333!)
        Me.txtVoucherType.StylePriority.UseFont = False
        Me.txtVoucherType.StylePriority.UseTextAlignment = False
        Me.txtVoucherType.Text = "CASH VOUCHER"
        Me.txtVoucherType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtVoucherNo.LocationFloat = New DevExpress.Utils.PointFloat(128.1667!, 30.87501!)
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVoucherNo.SizeF = New System.Drawing.SizeF(368.0831!, 15.625!)
        Me.txtVoucherNo.StylePriority.UseFont = False
        Me.txtVoucherNo.StylePriority.UseTextAlignment = False
        Me.txtVoucherNo.Text = "SAMPLE TEXT"
        Me.txtVoucherNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 30.875!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(125.7917!, 15.625!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "VOUCHER NO.:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtVendorSuplier
        '
        Me.txtVendorSuplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtVendorSuplier.LocationFloat = New DevExpress.Utils.PointFloat(128.1667!, 47.875!)
        Me.txtVendorSuplier.Name = "txtVendorSuplier"
        Me.txtVendorSuplier.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVendorSuplier.SizeF = New System.Drawing.SizeF(368.0831!, 15.625!)
        Me.txtVendorSuplier.StylePriority.UseFont = False
        Me.txtVendorSuplier.StylePriority.UseTextAlignment = False
        Me.txtVendorSuplier.Text = "SAMPLE TEXT"
        Me.txtVendorSuplier.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 47.87499!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(125.7917!, 15.625!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "PAYEE'S NAME:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(38.24994!, 65.79157!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(86.87488!, 15.62501!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "AMOUNT:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.LocationFloat = New DevExpress.Utils.PointFloat(128.1667!, 65.79167!)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTotalAmount.SizeF = New System.Drawing.SizeF(232.7502!, 15.62501!)
        Me.txtTotalAmount.StylePriority.UseFont = False
        Me.txtTotalAmount.StylePriority.UseTextAlignment = False
        Me.txtTotalAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtVoucherDate
        '
        Me.txtVoucherDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherDate.LocationFloat = New DevExpress.Utils.PointFloat(128.1667!, 82.41666!)
        Me.txtVoucherDate.Name = "txtVoucherDate"
        Me.txtVoucherDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVoucherDate.SizeF = New System.Drawing.SizeF(232.7502!, 15.62502!)
        Me.txtVoucherDate.StylePriority.UseFont = False
        Me.txtVoucherDate.StylePriority.UseTextAlignment = False
        Me.txtVoucherDate.Text = "December 31, 2013"
        Me.txtVoucherDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel6, Me.XrLine1, Me.XrLabel2, Me.txtPreparedTitle, Me.txtCheckedTitle, Me.txtCheckedName, Me.lineChecked, Me.XrLine3, Me.txtPreparedPosition, Me.txtpreparedName, Me.lineApproved, Me.txtApprovedName, Me.txtApprovedTitle, Me.txtAmountInWords, Me.XrShape1, Me.txtCopyright})
        Me.ReportFooter.HeightF = 366.2916!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 3.000005!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(195.5833!, 15.62501!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Amount in words:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtPreparedTitle
        '
        Me.txtPreparedTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPreparedTitle.LocationFloat = New DevExpress.Utils.PointFloat(2.645897!, 78.08329!)
        Me.txtPreparedTitle.Name = "txtPreparedTitle"
        Me.txtPreparedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPreparedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 17.70832!)
        Me.txtPreparedTitle.StylePriority.UseFont = False
        Me.txtPreparedTitle.StylePriority.UseTextAlignment = False
        Me.txtPreparedTitle.Text = "PREPARED BY:"
        Me.txtPreparedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCheckedTitle
        '
        Me.txtCheckedTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtCheckedTitle.LocationFloat = New DevExpress.Utils.PointFloat(186.3123!, 78.08329!)
        Me.txtCheckedTitle.Name = "txtCheckedTitle"
        Me.txtCheckedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 17.70832!)
        Me.txtCheckedTitle.StylePriority.UseFont = False
        Me.txtCheckedTitle.StylePriority.UseTextAlignment = False
        Me.txtCheckedTitle.Text = "CHECKED BY:"
        Me.txtCheckedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCheckedName
        '
        Me.txtCheckedName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtCheckedName.LocationFloat = New DevExpress.Utils.PointFloat(186.3123!, 130.0833!)
        Me.txtCheckedName.Name = "txtCheckedName"
        Me.txtCheckedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedName.SizeF = New System.Drawing.SizeF(157.7083!, 15.625!)
        Me.txtCheckedName.StylePriority.UseFont = False
        Me.txtCheckedName.StylePriority.UseTextAlignment = False
        Me.txtCheckedName.Text = "Signature Over Printed Name"
        Me.txtCheckedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lineChecked
        '
        Me.lineChecked.ForeColor = System.Drawing.Color.Gray
        Me.lineChecked.LocationFloat = New DevExpress.Utils.PointFloat(186.3123!, 121.5833!)
        Me.lineChecked.Name = "lineChecked"
        Me.lineChecked.SizeF = New System.Drawing.SizeF(157.7083!, 7.291649!)
        Me.lineChecked.StylePriority.UseForeColor = False
        '
        'XrLine3
        '
        Me.XrLine3.ForeColor = System.Drawing.Color.Gray
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(2.645906!, 121.5833!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(157.7082!, 7.291649!)
        Me.XrLine3.StylePriority.UseForeColor = False
        '
        'txtPreparedPosition
        '
        Me.txtPreparedPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPreparedPosition.LocationFloat = New DevExpress.Utils.PointFloat(2.645906!, 146.5833!)
        Me.txtPreparedPosition.Name = "txtPreparedPosition"
        Me.txtPreparedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPreparedPosition.SizeF = New System.Drawing.SizeF(157.7082!, 15.625!)
        Me.txtPreparedPosition.StylePriority.UseFont = False
        Me.txtPreparedPosition.StylePriority.UseTextAlignment = False
        Me.txtPreparedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtpreparedName
        '
        Me.txtpreparedName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtpreparedName.LocationFloat = New DevExpress.Utils.PointFloat(2.645906!, 130.0833!)
        Me.txtpreparedName.Name = "txtpreparedName"
        Me.txtpreparedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtpreparedName.SizeF = New System.Drawing.SizeF(157.7082!, 15.625!)
        Me.txtpreparedName.StylePriority.UseFont = False
        Me.txtpreparedName.StylePriority.UseTextAlignment = False
        Me.txtpreparedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lineApproved
        '
        Me.lineApproved.ForeColor = System.Drawing.Color.Gray
        Me.lineApproved.LocationFloat = New DevExpress.Utils.PointFloat(375.2292!, 121.5833!)
        Me.lineApproved.Name = "lineApproved"
        Me.lineApproved.SizeF = New System.Drawing.SizeF(157.7081!, 7.291695!)
        Me.lineApproved.StylePriority.UseForeColor = False
        '
        'txtApprovedName
        '
        Me.txtApprovedName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtApprovedName.LocationFloat = New DevExpress.Utils.PointFloat(375.2292!, 130.0833!)
        Me.txtApprovedName.Name = "txtApprovedName"
        Me.txtApprovedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedName.SizeF = New System.Drawing.SizeF(157.7081!, 15.625!)
        Me.txtApprovedName.StylePriority.UseFont = False
        Me.txtApprovedName.StylePriority.UseTextAlignment = False
        Me.txtApprovedName.Text = "Signature Over Printed Name"
        Me.txtApprovedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtApprovedTitle
        '
        Me.txtApprovedTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtApprovedTitle.LocationFloat = New DevExpress.Utils.PointFloat(375.2292!, 78.08329!)
        Me.txtApprovedTitle.Name = "txtApprovedTitle"
        Me.txtApprovedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedTitle.SizeF = New System.Drawing.SizeF(147.1252!, 17.70832!)
        Me.txtApprovedTitle.StylePriority.UseFont = False
        Me.txtApprovedTitle.StylePriority.UseTextAlignment = False
        Me.txtApprovedTitle.Text = "APPROVED BY:"
        Me.txtApprovedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtAmountInWords
        '
        Me.txtAmountInWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountInWords.LocationFloat = New DevExpress.Utils.PointFloat(14.25009!, 22.62496!)
        Me.txtAmountInWords.Name = "txtAmountInWords"
        Me.txtAmountInWords.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtAmountInWords.SizeF = New System.Drawing.SizeF(705.52!, 35.08!)
        Me.txtAmountInWords.StylePriority.UseFont = False
        Me.txtAmountInWords.StylePriority.UseTextAlignment = False
        Me.txtAmountInWords.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrShape1
        '
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 0.0!)
        Me.XrShape1.Name = "XrShape1"
        Me.XrShape1.Shape = ShapeRectangle1
        Me.XrShape1.SizeF = New System.Drawing.SizeF(729.0001!, 59.70496!)
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(563.4167!, 78.08329!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(147.1252!, 17.70832!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "RECEIVED BY:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(563.4167!, 130.0833!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(157.7081!, 15.625!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Signature Over Printed Name"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.ForeColor = System.Drawing.Color.Gray
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(563.4167!, 121.5833!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(157.7081!, 7.291695!)
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'rptVoucher
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(63, 57, 123, 118)
        Me.Version = "15.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents txtVoucherNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtVendorSuplier As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents txtVoucherType As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtAmountInWords As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTotalAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtVoucherDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDatePayment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgReportHeader As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents imgReportFooter As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtCompanyNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPreparedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lineChecked As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtPreparedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtpreparedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lineApproved As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtApprovedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtApprovedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDetails As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
End Class
