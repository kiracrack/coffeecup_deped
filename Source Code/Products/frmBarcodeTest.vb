Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmBarcodeTest

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
 

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub itemcode_EditValueChanged(sender As Object, e As EventArgs) Handles itemcode.EditValueChanged
        BarCodeControl1.Text = itemcode.Text
    End Sub

    Private Sub frmBarcodeTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

