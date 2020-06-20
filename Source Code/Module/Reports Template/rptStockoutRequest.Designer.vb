<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptStockoutRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptStockoutRequest))
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
        Me.txtDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtBatchno = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblOffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtoffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.officeid = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtdesignation = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtOfficer = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
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
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtRemarks = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.logo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 7.000007!)
        Me.logo.Name = "logo"
        Me.logo.SizeF = New System.Drawing.SizeF(730.0!, 118.5!)
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.txtCopyright})
        Me.BottomMargin.HeightF = 50.25005!
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtRemarks, Me.XrLabel1, Me.txtDate, Me.txtBatchno, Me.txtReportTitle, Me.lblOffice, Me.txtoffice, Me.officeid, Me.txtdesignation, Me.XrLabel9, Me.txtOfficer})
        Me.ReportHeader.HeightF = 133.9583!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.LocationFloat = New DevExpress.Utils.PointFloat(529.7918!, 32.58333!)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDate.SizeF = New System.Drawing.SizeF(194.2083!, 15.625!)
        Me.txtDate.StylePriority.UseFont = False
        Me.txtDate.StylePriority.UseTextAlignment = False
        Me.txtDate.Text = "Date: December 12, 1987"
        Me.txtDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtBatchno
        '
        Me.txtBatchno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatchno.LocationFloat = New DevExpress.Utils.PointFloat(547.9157!, 10.00001!)
        Me.txtBatchno.Name = "txtBatchno"
        Me.txtBatchno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtBatchno.SizeF = New System.Drawing.SizeF(175.0833!, 22.58332!)
        Me.txtBatchno.StylePriority.UseFont = False
        Me.txtBatchno.StylePriority.UseTextAlignment = False
        Me.txtBatchno.Text = "BATCH NO: 009281"
        Me.txtBatchno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtBatchno.Visible = False
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 25.0!)
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtReportTitle.SizeF = New System.Drawing.SizeF(502.5416!, 22.58333!)
        Me.txtReportTitle.StylePriority.UseFont = False
        Me.txtReportTitle.StylePriority.UseTextAlignment = False
        Me.txtReportTitle.Text = "SUMMARY REPORT"
        Me.txtReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblOffice
        '
        Me.lblOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffice.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 56.49997!)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblOffice.SizeF = New System.Drawing.SizeF(147.6657!, 15.625!)
        Me.lblOffice.StylePriority.UseFont = False
        Me.lblOffice.StylePriority.UseTextAlignment = False
        Me.lblOffice.Text = "DEPARTMENT / OFFICE:"
        Me.lblOffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtoffice
        '
        Me.txtoffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoffice.LocationFloat = New DevExpress.Utils.PointFloat(150.6657!, 56.49999!)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtoffice.SizeF = New System.Drawing.SizeF(572.3333!, 15.62501!)
        Me.txtoffice.StylePriority.UseFont = False
        Me.txtoffice.StylePriority.UseTextAlignment = False
        Me.txtoffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.LocationFloat = New DevExpress.Utils.PointFloat(5.000003!, 0.0!)
        Me.officeid.Name = "officeid"
        Me.officeid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.officeid.SizeF = New System.Drawing.SizeF(121.9583!, 22.58332!)
        Me.officeid.StylePriority.UseFont = False
        Me.officeid.StylePriority.UseTextAlignment = False
        Me.officeid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.officeid.Visible = False
        '
        'txtdesignation
        '
        Me.txtdesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesignation.LocationFloat = New DevExpress.Utils.PointFloat(150.6657!, 90.625!)
        Me.txtdesignation.Name = "txtdesignation"
        Me.txtdesignation.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtdesignation.SizeF = New System.Drawing.SizeF(572.3333!, 15.625!)
        Me.txtdesignation.StylePriority.UseFont = False
        Me.txtdesignation.StylePriority.UseTextAlignment = False
        Me.txtdesignation.Text = "Sample Text"
        Me.txtdesignation.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 74.12502!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(147.6657!, 15.625!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "OFFICER INCHARGE:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtOfficer
        '
        Me.txtOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficer.LocationFloat = New DevExpress.Utils.PointFloat(150.6657!, 74.12501!)
        Me.txtOfficer.Name = "txtOfficer"
        Me.txtOfficer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtOfficer.SizeF = New System.Drawing.SizeF(572.3333!, 15.625!)
        Me.txtOfficer.StylePriority.UseFont = False
        Me.txtOfficer.StylePriority.UseTextAlignment = False
        Me.txtOfficer.Text = "SAMPLE TEXT"
        Me.txtOfficer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtApprovedTitle, Me.txtApprovedName, Me.lineApproved, Me.txtpreparedName, Me.txtPreparedPosition, Me.XrLine3, Me.lineChecked, Me.txtCheckedPosition, Me.txtCheckedName, Me.txtCheckedTitle, Me.txtPreparedTitle})
        Me.GroupFooter1.HeightF = 252.125!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txtApprovedTitle
        '
        Me.txtApprovedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedTitle.LocationFloat = New DevExpress.Utils.PointFloat(487.6667!, 23.99998!)
        Me.txtApprovedTitle.Name = "txtApprovedTitle"
        Me.txtApprovedTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedTitle.SizeF = New System.Drawing.SizeF(147.1251!, 22.91666!)
        Me.txtApprovedTitle.StylePriority.UseFont = False
        Me.txtApprovedTitle.StylePriority.UseTextAlignment = False
        Me.txtApprovedTitle.Text = "Received By"
        Me.txtApprovedTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtApprovedName
        '
        Me.txtApprovedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedName.LocationFloat = New DevExpress.Utils.PointFloat(487.6667!, 95.00002!)
        Me.txtApprovedName.Name = "txtApprovedName"
        Me.txtApprovedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtApprovedName.SizeF = New System.Drawing.SizeF(201.4582!, 15.625!)
        Me.txtApprovedName.StylePriority.UseFont = False
        Me.txtApprovedName.StylePriority.UseTextAlignment = False
        Me.txtApprovedName.Text = "Signature Over Printed Name"
        Me.txtApprovedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lineApproved
        '
        Me.lineApproved.ForeColor = System.Drawing.Color.Gray
        Me.lineApproved.LocationFloat = New DevExpress.Utils.PointFloat(487.6667!, 86.49998!)
        Me.lineApproved.Name = "lineApproved"
        Me.lineApproved.SizeF = New System.Drawing.SizeF(201.4582!, 7.291672!)
        Me.lineApproved.StylePriority.UseForeColor = False
        '
        'txtpreparedName
        '
        Me.txtpreparedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreparedName.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 95.00002!)
        Me.txtpreparedName.Name = "txtpreparedName"
        Me.txtpreparedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtpreparedName.SizeF = New System.Drawing.SizeF(201.4582!, 15.625!)
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
        Me.txtPreparedPosition.SizeF = New System.Drawing.SizeF(201.4582!, 15.625!)
        Me.txtPreparedPosition.StylePriority.UseFont = False
        Me.txtPreparedPosition.StylePriority.UseTextAlignment = False
        Me.txtPreparedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.ForeColor = System.Drawing.Color.Gray
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 86.50004!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(201.4582!, 7.291679!)
        Me.XrLine3.StylePriority.UseForeColor = False
        '
        'lineChecked
        '
        Me.lineChecked.ForeColor = System.Drawing.Color.Gray
        Me.lineChecked.LocationFloat = New DevExpress.Utils.PointFloat(253.125!, 86.49998!)
        Me.lineChecked.Name = "lineChecked"
        Me.lineChecked.SizeF = New System.Drawing.SizeF(201.4582!, 7.291679!)
        Me.lineChecked.StylePriority.UseForeColor = False
        '
        'txtCheckedPosition
        '
        Me.txtCheckedPosition.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtCheckedPosition.LocationFloat = New DevExpress.Utils.PointFloat(253.125!, 111.5!)
        Me.txtCheckedPosition.Name = "txtCheckedPosition"
        Me.txtCheckedPosition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedPosition.SizeF = New System.Drawing.SizeF(201.4582!, 15.625!)
        Me.txtCheckedPosition.StylePriority.UseFont = False
        Me.txtCheckedPosition.StylePriority.UseTextAlignment = False
        Me.txtCheckedPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtCheckedName
        '
        Me.txtCheckedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckedName.LocationFloat = New DevExpress.Utils.PointFloat(253.125!, 94.99995!)
        Me.txtCheckedName.Name = "txtCheckedName"
        Me.txtCheckedName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckedName.SizeF = New System.Drawing.SizeF(201.4582!, 15.625!)
        Me.txtCheckedName.StylePriority.UseFont = False
        Me.txtCheckedName.StylePriority.UseTextAlignment = False
        Me.txtCheckedName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtCheckedTitle
        '
        Me.txtCheckedTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckedTitle.LocationFloat = New DevExpress.Utils.PointFloat(253.125!, 23.99998!)
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
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 110.4167!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(147.6657!, 15.625!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "REMARKS:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.LocationFloat = New DevExpress.Utils.PointFloat(151.6668!, 110.4167!)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtRemarks.SizeF = New System.Drawing.SizeF(572.3333!, 15.62501!)
        Me.txtRemarks.StylePriority.UseFont = False
        Me.txtRemarks.StylePriority.UseTextAlignment = False
        Me.txtRemarks.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptStockoutRequest
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
    Friend WithEvents officeid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblOffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtoffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtdesignation As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtOfficer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
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
    Friend WithEvents txtBatchno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtRemarks As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
