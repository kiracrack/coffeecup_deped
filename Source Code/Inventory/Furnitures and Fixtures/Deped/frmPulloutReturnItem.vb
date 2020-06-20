Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient

Public Class frmPulloutReturnItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPulloutReturnItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        PopulateGridViewControls("Select", 20, "CHECKBOX", dgv, True, False)
        PopulateGridViewControls("QTY", 50, "", dgv, True, True)
        PopulateGridViewControls("UOM", 50, "", dgv, True, True)
        PopulateGridViewControls("ITEM(S)", 50, "", dgv, True, True)
        PopulateGridViewControls("REASON", 50, "", dgv, True, True)
        PopulateGridViewControls("REMARKS", 50, "", dgv, True, True)
        PopulateGridViewControls("id", 50, "", dgv, False, True)
        PopulateGridViewControls("originoffice", 50, "", dgv, False, True)
        LoadReturnItem()
        loadInventoryTo()
    End Sub

    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        
    End Sub
    Public Sub LoadReturnItem()
        dgv.Rows.Clear()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select *,b.id as iid from tblofficeequipment as a inner join tblofficeequipmentpulloutitem as b on a.id=b.trnid where trncode='" & trncode.Text & "' and returned=0 order by itemname asc", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                dgv.Rows.Add(False, .Rows(cnt)("qty").ToString(), _
                                                 .Rows(cnt)("unit").ToString(), _
                                                 .Rows(cnt)("itemname").ToString(), _
                                                 .Rows(cnt)("reason").ToString(), _
                                                 .Rows(cnt)("remarks").ToString(), _
                                                 .Rows(cnt)("iid").ToString(), _
                                                 .Rows(cnt)("originoffice").ToString())
            End With
        Next

      
        GridColumnAlignment(dgv, {"QTY", "UOM"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumAutoWidth(dgv, {"Select", "ITEM(S)", "REASON", "REMARKS"})
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For x = 0 To dgv.RowCount - 1
                DirectCast(dgv.Rows(x).Cells("Select"), DataGridViewCheckBoxCell).Value = 1
            Next
        Else
            For x = 0 To dgv.RowCount - 1
                DirectCast(dgv.Rows(x).Cells("Select"), DataGridViewCheckBoxCell).Value = 0
            Next
        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim Selected As Boolean = False
        For I = 0 To dgv.RowCount - 1
            If DirectCast(dgv.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                Selected = True
            End If
        Next
        If Selected = False Then
            MessageBox.Show("No item selected", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim checkitem As String = ""
            For I = 0 To dgv.RowCount - 1
                If DirectCast(dgv.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                    checkitem += "a.id='" & dgv.Item("id", I).Value & "' or "
                End If
            Next
            checkitem = checkitem.Remove(checkitem.Length - 3, 3)
            GenerateReturedItem(trncode.Text, checkitem, Me)
        End If
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        Dim Selected As Boolean = False
        For I = 0 To dgv.RowCount - 1
            If DirectCast(dgv.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                Selected = True
            End If
        Next
        If Selected = False Then
            MessageBox.Show("No item selected", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf txtInventory.Text = "" Then
            MessageBox.Show("Please select return office", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim checkitem As String = ""
            For I = 0 To dgv.RowCount - 1
                If DirectCast(dgv.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                    com.CommandText = "update tblofficeequipmentpulloutitem set returned=1, datereturned=current_timestamp,receivedby='" & globaluserid & "' where id='" & dgv.Item("id", I).Value & "'" : com.ExecuteNonQuery()
                    com.CommandText = "UPDATE tblofficeequipment as a inner join tblofficeequipmentpulloutitem as b on a.id=b.trnid set a.officeid='" & officeid.Text & "' where b.id='" & dgv.Item("id", I).Value & "'" : com.ExecuteNonQuery()
                End If
            Next
            If countqry("tblofficeequipmentpulloutitem", " returned=0 and trncode='" & trncode.Text & "'") = 0 Then
                com.CommandText = "update tblofficeequipmentpullout set returned=1, receivedby='" & globaluserid & "', datereturned=current_date,timereturned=current_time where trncode='" & trncode.Text & "'" : com.ExecuteNonQuery()

            End If
            frmPulloutRecords.FilterStockoutSummary()
            XtraMessageBox.Show("Borrowed item successfully returned", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class