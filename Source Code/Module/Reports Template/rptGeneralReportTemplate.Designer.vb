<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptGeneralReportTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptGeneralReportTemplate))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCompanyNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyName = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.txtCopyright = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.txtReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtdate = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.txtNote = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.txtApprovedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtApprovedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtApprovedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.lineApproved = New DevExpress.XtraReports.UI.XRLine()
        Me.txtpreparedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPreparedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.lineChecked = New DevExpress.XtraReports.UI.XRLine()
        Me.txtPreparedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckedName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckedTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckedPosition = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupReportAsOf = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.txtReportDescription = New DevExpress.XtraReports.UI.XRLabel()
        Me.logo = New DevExpress.XtraReports.UI.XRPictureBox()
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
        Me.TopMargin.HeightF = 128.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyNumber
        '
        Me.txtCompanyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyNumber.LocationFloat = New DevExpress.Utils.PointFloat(4.958185!, 98.87501!)
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
        Me.txtCompanyAddress.LocationFloat = New DevExpress.Utils.PointFloat(4.958199!, 77.0!)
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
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(4.958185!, 55.00001!)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyName.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyName.StylePriority.UseFont = False
        Me.txtCompanyName.StylePriority.UseTextAlignment = False
        Me.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.txtCopyright})
        Me.BottomMargin.HeightF = 49.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.ForeColor = System.Drawing.Color.DimGray
        Me.XrPageInfo1.Format = "Page {0} of Total Pages"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 9.999974!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(147.6657!, 15.625!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseForeColor = False
        '
        'txtCopyright
        '
        Me.txtCopyright.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
        Me.txtCopyright.Font = New System.Drawing.Font("Arial Narrow", 7.75!, System.Drawing.FontStyle.Italic)
        Me.txtCopyright.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCopyright.KeepTogether = True
        Me.txtCopyright.LocationFloat = New DevExpress.Utils.PointFloat(168.499!, 9.999974!)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCopyright.SizeF = New System.Drawing.SizeF(561.501!, 15.625!)
        Me.txtCopyright.StylePriority.UseFont = False
        Me.txtCopyright.StylePriority.UseForeColor = False
        Me.txtCopyright.StylePriority.UseTextAlignment = False
        Me.txtCopyright.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtReportTitle, Me.txtdate})
        Me.ReportHeader.HeightF = 30.58333!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 7.999992!)
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtReportTitle.SizeF = New System.Drawing.SizeF(486.5417!, 22.58333!)
        Me.txtReportTitle.StylePriority.UseFont = False
        Me.txtReportTitle.StylePriority.UseTextAlignment = False
        Me.txtReportTitle.Text = "SUMMARY REPORT"
        Me.txtReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.LocationFloat = New DevExpress.Utils.PointFloat(488.5417!, 8.624999!)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtdate.SizeF = New System.Drawing.SizeF(227.3335!, 21.875!)
        Me.txtdate.StylePriority.UseFont = False
        Me.txtdate.StylePriority.UseTextAlignment = False
        Me.txtdate.Text = "Date"
        Me.txtdate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtNote})
        Me.GroupFooter1.HeightF = 35.41667!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Arial", 8.75!, System.Drawing.FontStyle.Italic)
        Me.txtNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNote.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 4.999974!)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtNote.SizeF = New System.Drawing.SizeF(719.0001!, 21.875!)
        Me.txtNote.StylePriority.UseFont = False
        Me.txtNote.StylePriority.UseForeColor = False
        Me.txtNote.StylePriority.UseTextAlignment = False
        Me.txtNote.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtApprovedPosition, Me.txtApprovedTitle, Me.txtApprovedName, Me.lineApproved, Me.txtpreparedName, Me.txtPreparedPosition, Me.XrLine3, Me.lineChecked, Me.txtPreparedTitle, Me.txtCheckedName, Me.txtCheckedTitle, Me.txtCheckedPosition})
        Me.GroupFooter2.HeightF = 255.2083!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'txtApprovedPosition
        '
        Me.txtApprovedPosition.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.txtApprovedPosition.LocationFloat = New DevExpress.Utils.PointFloat(505.2083!, 112.5!)
        Me.txtApprovedPosition.Name = "txtApprovedPosition"
        Me.txtApprovedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedPosition.SizeF = New System.Drawing.SizeF(212.92!, 15.62!)
        Me.txtApprovedPosition.StylePriority.UseFont = False
        Me.txtApprovedPosition.StylePriority.UseTextAlignment = False
        Me.txtApprovedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtApprovedTitle
        '
        Me.txtApprovedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedTitle.LocationFloat = New DevExpress.Utils.PointFloat(505.2083!, 25.0!)
        Me.txtApprovedTitle.Name = "txtApprovedTitle"
        Me.txtApprovedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 22.91666!)
        Me.txtApprovedTitle.StylePriority.UseFont = False
        Me.txtApprovedTitle.StylePriority.UseTextAlignment = False
        Me.txtApprovedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtApprovedName
        '
        Me.txtApprovedName.Font = New System.Drawing.Font("Arial", 8.75!, System.Drawing.FontStyle.Bold)
        Me.txtApprovedName.LocationFloat = New DevExpress.Utils.PointFloat(505.2083!, 96.00004!)
        Me.txtApprovedName.Name = "txtApprovedName"
        Me.txtApprovedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedName.SizeF = New System.Drawing.SizeF(212.92!, 15.62!)
        Me.txtApprovedName.StylePriority.UseFont = False
        Me.txtApprovedName.StylePriority.UseTextAlignment = False
        Me.txtApprovedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lineApproved
        '
        Me.lineApproved.ForeColor = System.Drawing.Color.Gray
        Me.lineApproved.LocationFloat = New DevExpress.Utils.PointFloat(505.2083!, 87.5!)
        Me.lineApproved.Name = "lineApproved"
        Me.lineApproved.SizeF = New System.Drawing.SizeF(212.92!, 7.29!)
        Me.lineApproved.StylePriority.UseForeColor = False
        '
        'txtpreparedName
        '
        Me.txtpreparedName.Font = New System.Drawing.Font("Arial", 8.75!, System.Drawing.FontStyle.Bold)
        Me.txtpreparedName.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 96.00004!)
        Me.txtpreparedName.Name = "txtpreparedName"
        Me.txtpreparedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtpreparedName.SizeF = New System.Drawing.SizeF(212.9165!, 15.625!)
        Me.txtpreparedName.StylePriority.UseFont = False
        Me.txtpreparedName.StylePriority.UseTextAlignment = False
        Me.txtpreparedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtPreparedPosition
        '
        Me.txtPreparedPosition.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.txtPreparedPosition.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 112.5!)
        Me.txtPreparedPosition.Name = "txtPreparedPosition"
        Me.txtPreparedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPreparedPosition.SizeF = New System.Drawing.SizeF(212.9165!, 15.625!)
        Me.txtPreparedPosition.StylePriority.UseFont = False
        Me.txtPreparedPosition.StylePriority.UseTextAlignment = False
        Me.txtPreparedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.ForeColor = System.Drawing.Color.Gray
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 87.5!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(212.9165!, 7.291672!)
        Me.XrLine3.StylePriority.UseForeColor = False
        '
        'lineChecked
        '
        Me.lineChecked.ForeColor = System.Drawing.Color.Gray
        Me.lineChecked.LocationFloat = New DevExpress.Utils.PointFloat(267.0!, 87.5!)
        Me.lineChecked.Name = "lineChecked"
        Me.lineChecked.SizeF = New System.Drawing.SizeF(212.92!, 7.29!)
        Me.lineChecked.StylePriority.UseForeColor = False
        '
        'txtPreparedTitle
        '
        Me.txtPreparedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreparedTitle.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 25.0!)
        Me.txtPreparedTitle.Name = "txtPreparedTitle"
        Me.txtPreparedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPreparedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 22.91666!)
        Me.txtPreparedTitle.StylePriority.UseFont = False
        Me.txtPreparedTitle.StylePriority.UseTextAlignment = False
        Me.txtPreparedTitle.Text = "Prepared by:"
        Me.txtPreparedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCheckedName
        '
        Me.txtCheckedName.Font = New System.Drawing.Font("Arial", 8.75!, System.Drawing.FontStyle.Bold)
        Me.txtCheckedName.LocationFloat = New DevExpress.Utils.PointFloat(267.0!, 96.00002!)
        Me.txtCheckedName.Name = "txtCheckedName"
        Me.txtCheckedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedName.SizeF = New System.Drawing.SizeF(212.92!, 15.62!)
        Me.txtCheckedName.StylePriority.UseFont = False
        Me.txtCheckedName.StylePriority.UseTextAlignment = False
        Me.txtCheckedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtCheckedTitle
        '
        Me.txtCheckedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckedTitle.LocationFloat = New DevExpress.Utils.PointFloat(267.0!, 25.0!)
        Me.txtCheckedTitle.Name = "txtCheckedTitle"
        Me.txtCheckedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 22.91666!)
        Me.txtCheckedTitle.StylePriority.UseFont = False
        Me.txtCheckedTitle.StylePriority.UseTextAlignment = False
        Me.txtCheckedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCheckedPosition
        '
        Me.txtCheckedPosition.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.txtCheckedPosition.LocationFloat = New DevExpress.Utils.PointFloat(267.0!, 112.4999!)
        Me.txtCheckedPosition.Name = "txtCheckedPosition"
        Me.txtCheckedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedPosition.SizeF = New System.Drawing.SizeF(212.92!, 15.62!)
        Me.txtCheckedPosition.StylePriority.UseFont = False
        Me.txtCheckedPosition.StylePriority.UseTextAlignment = False
        Me.txtCheckedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'groupReportAsOf
        '
        Me.groupReportAsOf.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtReportDescription})
        Me.groupReportAsOf.HeightF = 22.91667!
        Me.groupReportAsOf.Level = 1
        Me.groupReportAsOf.Name = "groupReportAsOf"
        '
        'txtReportDescription
        '
        Me.txtReportDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtReportDescription.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.txtReportDescription.Name = "txtReportDescription"
        Me.txtReportDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtReportDescription.SizeF = New System.Drawing.SizeF(711.7499!, 22.91667!)
        Me.txtReportDescription.StylePriority.UseFont = False
        Me.txtReportDescription.StylePriority.UseTextAlignment = False
        Me.txtReportDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.logo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 5.000008!)
        Me.logo.Name = "logo"
        Me.logo.SizeF = New System.Drawing.SizeF(730.0!, 118.5!)
        '
        'rptGeneralReportTemplate
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupFooter1, Me.GroupFooter2, Me.groupReportAsOf})
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 128, 49)
        Me.Version = "15.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents txtdate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents txtNote As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents txtpreparedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPreparedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lineChecked As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtPreparedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents txtApprovedPosition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtApprovedTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtApprovedName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lineApproved As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents groupReportAsOf As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents txtReportDescription As DevExpress.XtraReports.UI.XRLabel
End Class
