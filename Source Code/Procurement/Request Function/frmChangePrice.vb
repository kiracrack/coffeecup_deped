Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins

Public Class frmChangePrice
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.Control) + Keys.Enter Then
            cmdaction.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmQuantitySelect_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        trnid.Text = ""
    End Sub
    Private Sub frmQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
      
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        com.CommandText = "update tblrequisitionsitem set quantity='" & Val(CC(txtQuantity.Text)) & "', cost='" & Val(CC(txtUnitCost.Text)) & "', total='" & Val(CC(txtUnitCost.Text)) * Val(CC(txtQuantity.Text)) & "'  where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
        RecordApprovingHistory("requisition", pid.Text, pid.Text, "update item", "update item name " & Me.Text & " " & txtQuantity.Text & "@" & txtUnitCost.Text)
        If frmRequisitionsItems.Visible = True Then
            frmRequisitionsItems.filterActual()
        End If
        XtraMessageBox.Show("Item updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
 
End Class