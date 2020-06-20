Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmLockInventoryCutoff

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    
    Private Sub frmLockInventoryCutoff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttodate.EditValue = CDate(Now)
        CheckInventoryLockedStatus()
        loadInventoryValue()
    End Sub
    Public Sub CheckInventoryLockedStatus()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice where officeid not in (select officeid from tblinventorylocked where date_format(cutoff,'%Y-%m')=date_format('" & ConvertDate(txttodate.EditValue) & "','%Y-%m'))  order by officename asc", "tblcompoffice", txtOffice, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Public Sub loadInventoryValue()
        txtOnhand.Text = "0.00" : txtPrepaid.Text = "0.00"
        If ck_all.Checked = True Then
            txtOffice.Enabled = False
            txtOnhand.Text = FormatNumber(Val(qrysingledata("total", "sum(quantity*purchasedprice) as total", "tblinventory where prepaid=0 and purchasedprice>0")), 2)
            txtPrepaid.Text = FormatNumber(Val(qrysingledata("total", "sum(quantity*purchasedprice) as total", "tblinventory where prepaid=1 and purchasedprice>0")), 2)
        Else
            txtOffice.Enabled = True
            txtOnhand.Text = FormatNumber(Val(qrysingledata("total", "sum(quantity*purchasedprice) as total", "tblinventory where prepaid=0  and purchasedprice>0 and officeid='" & officeid.Text & "'")), 2)
            txtPrepaid.Text = FormatNumber(Val(qrysingledata("total", "sum(quantity*purchasedprice) as total", "tblinventory where prepaid=1  and purchasedprice>0 and officeid='" & officeid.Text & "'")), 2)
        End If
    End Sub

    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        loadInventoryValue()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If ck_all.Checked = False And txtOffice.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOffice.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to lock current inventory?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "INSERT INTO tblinventorylocked (cutoff,officeid,stockhouseid,catid,categoryname,productid,productname,prepaid,quantity,unit,purchasedprice,calcsellrate,sellingprice,lastupdate,lasttrnby,dateinventory) " _
                               + " SELECT '" & ConvertDate(txttodate.EditValue) & "',officeid,stockhouseid,catid,categoryname,productid,productname,prepaid,quantity,unit,purchasedprice,calcsellrate,sellingprice,lastupdate,lasttrnby,dateinventory FROM tblinventory " & If(ck_all.Checked = True, "", "where officeid='" & officeid.Text & "'") & "" : com.ExecuteNonQuery()
            XtraMessageBox.Show("Inventory successfully locked!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub ck_all_CheckedChanged(sender As Object, e As EventArgs) Handles ck_all.CheckedChanged
        loadInventoryValue()
    End Sub

    Private Sub txttodate_EditValueChanged(sender As Object, e As EventArgs) Handles txttodate.EditValueChanged
        CheckInventoryLockedStatus()
    End Sub
End Class