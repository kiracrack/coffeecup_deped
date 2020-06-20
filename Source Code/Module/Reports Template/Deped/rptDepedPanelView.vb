Public Class rptDepedPanelView

    'ham nay de luu lai manv khi sub chay
    Public Sub BindData()
        lbl_manv.DataBindings.Add("Text", DataSource, "id")
    End Sub

    'hàm này chính là hàm gọi report đơn
    Private Sub XrSubreport1_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        strMaNV = lbl_manv.Text
        Dim rpt As New rptDepedDesigner
        rpt.BindData()
        XrSubreport1.ReportSource = rpt
    End Sub

End Class