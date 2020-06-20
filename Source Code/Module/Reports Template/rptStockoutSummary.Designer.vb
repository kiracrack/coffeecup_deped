<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptStockoutSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptStockoutSummary))
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
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblOffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtoffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtBatchcode = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPeriod = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.txtPreparedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.lineChecked = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtPreparedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtpreparedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.lineApproved = New DevExpress.XtraReports.UI.XRLine()
        Me.txtApprovedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtApprovedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtApprovedPosition = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCompanyNumber, Me.txtCompanyAddress, Me.txtCompanyName, Me.logo})
        Me.TopMargin.HeightF = 133.7084!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyNumber
        '
        Me.txtCompanyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyNumber.LocationFloat = New DevExpress.Utils.PointFloat(4.958236!, 100.25!)
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
        Me.txtCompanyAddress.LocationFloat = New DevExpress.Utils.PointFloat(4.0!, 78.375!)
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
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(4.0!, 56.5!)
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
        Me.logo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 7.000007!)
        Me.logo.Name = "logo"
        Me.logo.SizeF = New System.Drawing.SizeF(730.0!, 118.5!)
        Me.logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.CenterImage
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.txtCopyright})
        Me.BottomMargin.HeightF = 57.375!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.ForeColor = System.Drawing.Color.DimGray
        Me.XrPageInfo1.Format = "Page {0}/{1}  of Total Pages"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(20.83333!, 6.00001!)
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
        Me.txtCopyright.LocationFloat = New DevExpress.Utils.PointFloat(168.499!, 6.00001!)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCopyright.SizeF = New System.Drawing.SizeF(561.5009!, 15.625!)
        Me.txtCopyright.StylePriority.UseFont = False
        Me.txtCopyright.StylePriority.UseForeColor = False
        Me.txtCopyright.StylePriority.UseTextAlignment = False
        Me.txtCopyright.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.lblOffice, Me.txtoffice, Me.txtBatchcode, Me.XrLabel8, Me.XrLabel1, Me.txtPeriod})
        Me.ReportHeader.HeightF = 108.9583!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 25.00001!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(584.8333!, 22.58333!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "STOCKOUT REPORT"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblOffice
        '
        Me.lblOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffice.LocationFloat = New DevExpress.Utils.PointFloat(7.291651!, 70.5!)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblOffice.SizeF = New System.Drawing.SizeF(118.5!, 15.625!)
        Me.lblOffice.StylePriority.UseFont = False
        Me.lblOffice.StylePriority.UseTextAlignment = False
        Me.lblOffice.Text = "OFFICE:"
        Me.lblOffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtoffice
        '
        Me.txtoffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoffice.LocationFloat = New DevExpress.Utils.PointFloat(128.1667!, 70.5!)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtoffice.SizeF = New System.Drawing.SizeF(584.8333!, 15.62501!)
        Me.txtoffice.StylePriority.UseFont = False
        Me.txtoffice.StylePriority.UseTextAlignment = False
        Me.txtoffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatchcode.LocationFloat = New DevExpress.Utils.PointFloat(128.1667!, 51.875!)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtBatchcode.SizeF = New System.Drawing.SizeF(584.8333!, 15.625!)
        Me.txtBatchcode.StylePriority.UseFont = False
        Me.txtBatchcode.StylePriority.UseTextAlignment = False
        Me.txtBatchcode.Text = "SAMPLE TEXT"
        Me.txtBatchcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(7.291664!, 51.875!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(118.5!, 15.625!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Batch Code:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(7.291667!, 89.12502!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(118.5!, 15.625!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "STOCKOUT PERIOD"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtPeriod
        '
        Me.txtPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriod.LocationFloat = New DevExpress.Utils.PointFloat(128.1667!, 89.12502!)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPeriod.SizeF = New System.Drawing.SizeF(584.8333!, 15.62501!)
        Me.txtPeriod.StylePriority.UseFont = False
        Me.txtPeriod.StylePriority.UseTextAlignment = False
        Me.txtPeriod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtPreparedTitle, Me.txtCheckedTitle, Me.txtCheckedName, Me.txtCheckedPosition, Me.lineChecked, Me.XrLine3, Me.txtPreparedPosition, Me.txtpreparedName, Me.lineApproved, Me.txtApprovedName, Me.txtApprovedTitle, Me.txtApprovedPosition})
        Me.GroupFooter1.HeightF = 249.125!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txtPreparedTitle
        '
        Me.txtPreparedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreparedTitle.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 21.0!)
        Me.txtPreparedTitle.Name = "txtPreparedTitle"
        Me.txtPreparedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPreparedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 22.91666!)
        Me.txtPreparedTitle.StylePriority.UseFont = False
        Me.txtPreparedTitle.StylePriority.UseTextAlignment = False
        Me.txtPreparedTitle.Text = "Prepared by:"
        Me.txtPreparedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCheckedTitle
        '
        Me.txtCheckedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckedTitle.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 21.0!)
        Me.txtCheckedTitle.Name = "txtCheckedTitle"
        Me.txtCheckedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 22.91666!)
        Me.txtCheckedTitle.StylePriority.UseFont = False
        Me.txtCheckedTitle.StylePriority.UseTextAlignment = False
        Me.txtCheckedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCheckedName
        '
        Me.txtCheckedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckedName.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 92.0!)
        Me.txtCheckedName.Name = "txtCheckedName"
        Me.txtCheckedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedName.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtCheckedName.StylePriority.UseFont = False
        Me.txtCheckedName.StylePriority.UseTextAlignment = False
        Me.txtCheckedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtCheckedPosition
        '
        Me.txtCheckedPosition.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtCheckedPosition.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 108.5!)
        Me.txtCheckedPosition.Name = "txtCheckedPosition"
        Me.txtCheckedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedPosition.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtCheckedPosition.StylePriority.UseFont = False
        Me.txtCheckedPosition.StylePriority.UseTextAlignment = False
        Me.txtCheckedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lineChecked
        '
        Me.lineChecked.ForeColor = System.Drawing.Color.Gray
        Me.lineChecked.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 83.5!)
        Me.lineChecked.Name = "lineChecked"
        Me.lineChecked.SizeF = New System.Drawing.SizeF(282.7082!, 7.291672!)
        Me.lineChecked.StylePriority.UseForeColor = False
        '
        'XrLine3
        '
        Me.XrLine3.ForeColor = System.Drawing.Color.Gray
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 83.5!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(282.7082!, 7.291672!)
        Me.XrLine3.StylePriority.UseForeColor = False
        '
        'txtPreparedPosition
        '
        Me.txtPreparedPosition.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtPreparedPosition.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 108.5!)
        Me.txtPreparedPosition.Name = "txtPreparedPosition"
        Me.txtPreparedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPreparedPosition.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtPreparedPosition.StylePriority.UseFont = False
        Me.txtPreparedPosition.StylePriority.UseTextAlignment = False
        Me.txtPreparedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtpreparedName
        '
        Me.txtpreparedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreparedName.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 92.0!)
        Me.txtpreparedName.Name = "txtpreparedName"
        Me.txtpreparedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtpreparedName.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtpreparedName.StylePriority.UseFont = False
        Me.txtpreparedName.StylePriority.UseTextAlignment = False
        Me.txtpreparedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lineApproved
        '
        Me.lineApproved.ForeColor = System.Drawing.Color.Gray
        Me.lineApproved.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 208.5!)
        Me.lineApproved.Name = "lineApproved"
        Me.lineApproved.SizeF = New System.Drawing.SizeF(282.7082!, 7.291672!)
        Me.lineApproved.StylePriority.UseForeColor = False
        '
        'txtApprovedName
        '
        Me.txtApprovedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedName.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 216.5!)
        Me.txtApprovedName.Name = "txtApprovedName"
        Me.txtApprovedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedName.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtApprovedName.StylePriority.UseFont = False
        Me.txtApprovedName.StylePriority.UseTextAlignment = False
        Me.txtApprovedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtApprovedTitle
        '
        Me.txtApprovedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedTitle.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 146.0!)
        Me.txtApprovedTitle.Name = "txtApprovedTitle"
        Me.txtApprovedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 22.91666!)
        Me.txtApprovedTitle.StylePriority.UseFont = False
        Me.txtApprovedTitle.StylePriority.UseTextAlignment = False
        Me.txtApprovedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtApprovedPosition
        '
        Me.txtApprovedPosition.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtApprovedPosition.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 233.5!)
        Me.txtApprovedPosition.Name = "txtApprovedPosition"
        Me.txtApprovedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedPosition.SizeF = New System.Drawing.SizeF(282.7082!, 15.625!)
        Me.txtApprovedPosition.StylePriority.UseFont = False
        Me.txtApprovedPosition.StylePriority.UseTextAlignment = False
        Me.txtApprovedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'rptStockoutSummary
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupFooter1})
        Me.Margins = New System.Drawing.Printing.Margins(63, 57, 134, 57)
        Me.Version = "12.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents txtBatchcode As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPeriod As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblOffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtoffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents txtPreparedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lineChecked As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtPreparedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtpreparedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lineApproved As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtApprovedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtApprovedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtApprovedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
End Class
