<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptBillingStatement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBillingStatement))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCompanyNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyName = New DevExpress.XtraReports.UI.XRLabel()
        Me.logo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.txtCopyright = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.txtDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtStatementDatePeriod = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtClientName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblcheckoraccountname = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblReferenceNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtContactNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtStatementHeader = New DevExpress.XtraReports.UI.XRRichText()
        Me.txtTitle1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtPosition1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPosition2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtTitle2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtStatementFooter1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtStatementFooter = New DevExpress.XtraReports.UI.XRRichText()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        CType(Me.txtStatementHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatementFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.KeepTogether = True
        Me.Detail.KeepTogetherWithDetailReports = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCompanyNumber, Me.txtCompanyAddress, Me.txtCompanyName, Me.logo})
        Me.TopMargin.HeightF = 118.5!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyNumber
        '
        Me.txtCompanyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyNumber.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 93.25!)
        Me.txtCompanyNumber.Name = "txtCompanyNumber"
        Me.txtCompanyNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyNumber.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyNumber.StylePriority.UseFont = False
        Me.txtCompanyNumber.StylePriority.UseTextAlignment = False
        Me.txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyAddress
        '
        Me.txtCompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyAddress.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 71.375!)
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
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 49.5!)
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
        Me.logo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.000007152557!)
        Me.logo.Name = "logo"
        Me.logo.SizeF = New System.Drawing.SizeF(730.0!, 118.5!)
        Me.logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.CenterImage
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCopyright})
        Me.BottomMargin.HeightF = 41.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCopyright
        '
        Me.txtCopyright.Font = New System.Drawing.Font("Arial Narrow", 7.75!, System.Drawing.FontStyle.Italic)
        Me.txtCopyright.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCopyright.LocationFloat = New DevExpress.Utils.PointFloat(22.2501!, 0.0!)
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtDate, Me.XrLabel3, Me.txtStatementDatePeriod, Me.txtReportTitle, Me.txtClientName, Me.XrLabel9, Me.lblcheckoraccountname, Me.txtAddress, Me.lblReferenceNo, Me.txtContactNumber, Me.txtStatementHeader})
        Me.ReportHeader.HeightF = 156.9585!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.LocationFloat = New DevExpress.Utils.PointFloat(153.1667!, 39.24996!)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDate.SizeF = New System.Drawing.SizeF(403.3334!, 15.62501!)
        Me.txtDate.StylePriority.UseFont = False
        Me.txtDate.StylePriority.UseTextAlignment = False
        Me.txtDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 39.24996!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(146.1667!, 15.62501!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "DATE:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtStatementDatePeriod
        '
        Me.txtStatementDatePeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatementDatePeriod.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 118.2259!)
        Me.txtStatementDatePeriod.Name = "txtStatementDatePeriod"
        Me.txtStatementDatePeriod.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtStatementDatePeriod.SizeF = New System.Drawing.SizeF(728.0419!, 15.62502!)
        Me.txtStatementDatePeriod.StylePriority.UseFont = False
        Me.txtStatementDatePeriod.StylePriority.UseTextAlignment = False
        Me.txtStatementDatePeriod.Text = "Statement period of 1/1/2014-1/31/2014"
        Me.txtStatementDatePeriod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 7.000001!)
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtReportTitle.SizeF = New System.Drawing.SizeF(494.2498!, 22.58333!)
        Me.txtReportTitle.StylePriority.UseFont = False
        Me.txtReportTitle.StylePriority.UseTextAlignment = False
        Me.txtReportTitle.Text = "STATEMENT OF ACCOUNT"
        Me.txtReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtClientName
        '
        Me.txtClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientName.LocationFloat = New DevExpress.Utils.PointFloat(153.1667!, 56.87497!)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtClientName.SizeF = New System.Drawing.SizeF(403.3334!, 15.625!)
        Me.txtClientName.StylePriority.UseFont = False
        Me.txtClientName.StylePriority.UseTextAlignment = False
        Me.txtClientName.Text = "SAMPLE TEXT"
        Me.txtClientName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 56.87497!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(148.1667!, 15.625!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "CLIENT NAME:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lblcheckoraccountname
        '
        Me.lblcheckoraccountname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcheckoraccountname.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 74.49989!)
        Me.lblcheckoraccountname.Name = "lblcheckoraccountname"
        Me.lblcheckoraccountname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblcheckoraccountname.SizeF = New System.Drawing.SizeF(146.1667!, 15.62501!)
        Me.lblcheckoraccountname.StylePriority.UseFont = False
        Me.lblcheckoraccountname.StylePriority.UseTextAlignment = False
        Me.lblcheckoraccountname.Text = "ADDRESS:"
        Me.lblcheckoraccountname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.LocationFloat = New DevExpress.Utils.PointFloat(153.1667!, 74.49989!)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtAddress.SizeF = New System.Drawing.SizeF(403.3334!, 15.62501!)
        Me.txtAddress.StylePriority.UseFont = False
        Me.txtAddress.StylePriority.UseTextAlignment = False
        Me.txtAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblReferenceNo
        '
        Me.lblReferenceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferenceNo.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 92.12491!)
        Me.lblReferenceNo.Name = "lblReferenceNo"
        Me.lblReferenceNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblReferenceNo.SizeF = New System.Drawing.SizeF(146.1667!, 15.62501!)
        Me.lblReferenceNo.StylePriority.UseFont = False
        Me.lblReferenceNo.StylePriority.UseTextAlignment = False
        Me.lblReferenceNo.Text = "CONTACT NUMBER:"
        Me.lblReferenceNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.LocationFloat = New DevExpress.Utils.PointFloat(153.1667!, 92.12491!)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtContactNumber.SizeF = New System.Drawing.SizeF(403.3334!, 15.62501!)
        Me.txtContactNumber.StylePriority.UseFont = False
        Me.txtContactNumber.StylePriority.UseTextAlignment = False
        Me.txtContactNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtStatementHeader
        '
        Me.txtStatementHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatementHeader.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 137.8509!)
        Me.txtStatementHeader.Name = "txtStatementHeader"
        Me.txtStatementHeader.SerializableRtfString = resources.GetString("txtStatementHeader.SerializableRtfString")
        Me.txtStatementHeader.SizeF = New System.Drawing.SizeF(726.0419!, 15.10745!)
        Me.txtStatementHeader.StylePriority.UseFont = False
        '
        'txtTitle1
        '
        Me.txtTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle1.LocationFloat = New DevExpress.Utils.PointFloat(3.000005!, 84.02579!)
        Me.txtTitle1.Name = "txtTitle1"
        Me.txtTitle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle1.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle1.StylePriority.UseFont = False
        Me.txtTitle1.StylePriority.UseTextAlignment = False
        Me.txtTitle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtLine1
        '
        Me.txtLine1.ForeColor = System.Drawing.Color.Gray
        Me.txtLine1.LocationFloat = New DevExpress.Utils.PointFloat(1.227665!, 135.5258!)
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine1.StylePriority.UseForeColor = False
        '
        'txtPosition1
        '
        Me.txtPosition1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition1.LocationFloat = New DevExpress.Utils.PointFloat(1.227665!, 160.5258!)
        Me.txtPosition1.Name = "txtPosition1"
        Me.txtPosition1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition1.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition1.StylePriority.UseFont = False
        Me.txtPosition1.StylePriority.UseTextAlignment = False
        Me.txtPosition1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtSignatory1
        '
        Me.txtSignatory1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignatory1.LocationFloat = New DevExpress.Utils.PointFloat(1.227665!, 144.0257!)
        Me.txtSignatory1.Name = "txtSignatory1"
        Me.txtSignatory1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory1.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory1.StylePriority.UseFont = False
        Me.txtSignatory1.StylePriority.UseTextAlignment = False
        Me.txtSignatory1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtSignatory2
        '
        Me.txtSignatory2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignatory2.LocationFloat = New DevExpress.Utils.PointFloat(334.665!, 144.0257!)
        Me.txtSignatory2.Name = "txtSignatory2"
        Me.txtSignatory2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory2.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory2.StylePriority.UseFont = False
        Me.txtSignatory2.StylePriority.UseTextAlignment = False
        Me.txtSignatory2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtPosition2
        '
        Me.txtPosition2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition2.LocationFloat = New DevExpress.Utils.PointFloat(334.665!, 160.5258!)
        Me.txtPosition2.Name = "txtPosition2"
        Me.txtPosition2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition2.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition2.StylePriority.UseFont = False
        Me.txtPosition2.StylePriority.UseTextAlignment = False
        Me.txtPosition2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtLine2
        '
        Me.txtLine2.ForeColor = System.Drawing.Color.Gray
        Me.txtLine2.LocationFloat = New DevExpress.Utils.PointFloat(334.665!, 135.5258!)
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine2.StylePriority.UseForeColor = False
        '
        'txtTitle2
        '
        Me.txtTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle2.LocationFloat = New DevExpress.Utils.PointFloat(334.665!, 84.02579!)
        Me.txtTitle2.Name = "txtTitle2"
        Me.txtTitle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle2.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle2.StylePriority.UseFont = False
        Me.txtTitle2.StylePriority.UseTextAlignment = False
        Me.txtTitle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 201.2524!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(641.9168!, 18.74998!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "STATEMENT WITH TRUST RECEIPTS ATTACHMENTS RECEIVED BY: (NO PAYMENTS MADE)"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.ForeColor = System.Drawing.Color.Gray
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 252.7525!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(253.545!, 7.290009!)
        Me.XrLine2.StylePriority.UseForeColor = False
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 261.2524!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(267.0867!, 15.62001!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "SIGNATURE OVER PRINTED NAME "
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(300.8298!, 261.2524!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(173.3367!, 15.62001!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "DATE"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine3
        '
        Me.XrLine3.ForeColor = System.Drawing.Color.Gray
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(300.8298!, 252.7525!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(122.2952!, 7.289993!)
        Me.XrLine3.StylePriority.UseForeColor = False
        '
        'txtStatementFooter1
        '
        Me.txtStatementFooter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatementFooter1.LocationFloat = New DevExpress.Utils.PointFloat(3.0!, 36.27411!)
        Me.txtStatementFooter1.Multiline = True
        Me.txtStatementFooter1.Name = "txtStatementFooter1"
        Me.txtStatementFooter1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtStatementFooter1.SizeF = New System.Drawing.SizeF(722.042!, 15.62501!)
        Me.txtStatementFooter1.StylePriority.UseFont = False
        Me.txtStatementFooter1.StylePriority.UseTextAlignment = False
        Me.txtStatementFooter1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtStatementFooter
        '
        Me.txtStatementFooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatementFooter.ForeColor = System.Drawing.Color.Black
        Me.txtStatementFooter.LocationFloat = New DevExpress.Utils.PointFloat(3.0!, 10.0!)
        Me.txtStatementFooter.Name = "txtStatementFooter"
        Me.txtStatementFooter.SerializableRtfString = resources.GetString("txtStatementFooter.SerializableRtfString")
        Me.txtStatementFooter.SizeF = New System.Drawing.SizeF(722.0001!, 19.27411!)
        Me.txtStatementFooter.StylePriority.UseFont = False
        Me.txtStatementFooter.StylePriority.UseForeColor = False
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtStatementFooter, Me.txtPosition1, Me.txtLine1, Me.txtTitle1, Me.txtSignatory1, Me.txtTitle2, Me.txtLine2, Me.txtPosition2, Me.txtSignatory2, Me.XrLabel7, Me.XrLine2, Me.XrLabel5, Me.XrLabel8, Me.XrLine3, Me.txtStatementFooter1})
        Me.ReportFooter.HeightF = 307.0807!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'rptBillingStatement
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(63, 57, 118, 41)
        Me.Version = "12.1"
        CType(Me.txtStatementHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatementFooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents txtClientName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtContactNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblReferenceNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblcheckoraccountname As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtPosition1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtStatementHeader As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents txtDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtStatementDatePeriod As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPosition2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtTitle2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtStatementFooter1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtStatementFooter As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
End Class
