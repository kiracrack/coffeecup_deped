Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI

Public Class frmChangeApproving
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmApproverFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        com.CommandText = "select *,(select sum(total) from tblrequisitionsitem where pid=tblpurchaseorder.requestref and vendorid =  tblpurchaseorder.vendorid) as total, (select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) as office,(select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) as vendor from tblpurchaseorder where ponumber ='" & ponumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            pid.Text = rst("requestref").ToString
            txtBranch.Text = rst("office").ToString
            txtSupplier.Text = rst("vendor").ToString
            txtAmount.Text = FormatNumber(rst("total").ToString, 2)
            txtApprovingLevel.SelectedIndex = rst("corporatelevel")
        End While
        rst.Close()
        If txtApprovingLevel.Text = "" Then
            cmdMove.Enabled = False
        Else
            cmdMove.Enabled = True
        End If
    End Sub

    Private Sub cmdMove_Click(sender As Object, e As EventArgs) Handles cmdMove.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "Update tblpurchaseorder set corporatelevel='" & txtApprovingLevel.SelectedIndex & "' where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()

            If mode.Text = "po" Then
                RecordApprovingHistory("purchase order", pid.Text, ponumber.Text, "processed", "change approving to " & LCase(txtApprovingLevel.Text) & " level")
                frmPurchaseOrder.FilterOption()
            Else
                RecordApprovingHistory("Payment Request", pid.Text, ponumber.Text, "processed", "change approving to " & LCase(txtApprovingLevel.Text) & " level")
                frmPaymentOrder.FilterOption()
            End If
            XtraMessageBox.Show("Approving level successfully changed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    
    Private Sub txtApprovingLevel_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtApprovingLevel.SelectedValueChanged
        If txtApprovingLevel.Text = "" Then
            cmdMove.Enabled = False
        Else
            cmdMove.Enabled = True
        End If
    End Sub
End Class