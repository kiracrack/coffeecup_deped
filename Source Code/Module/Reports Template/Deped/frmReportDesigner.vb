Public Class frmReportDesigner

    Private Sub frm_show_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        If int_report = 1 Then
            'chạy report đơn
            Dim rpt As New rptDepedDesigner
            DocumentViewer1.PrintingSystem = rpt.PrintingSystem
            rpt.BindData()
            rpt.CreateDocument()
        ElseIf int_report = 2 Then
            'chạy Subreport
            Dim rpt As New rptDepedPanelView
            DocumentViewer1.PrintingSystem = rpt.PrintingSystem
            rpt.DataSource = dsreport
            rpt.BindData()
            rpt.CreateDocument()
        End If

    End Sub

End Class