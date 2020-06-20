Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmProductRequestInformation
    Private vendor As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmItemRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadItemDetails()
        LoadCategory()
        LoadToComboBox("unit", "tblglobalproducts", txtUnit, True)
        LoadGridviewAppearance(combogrid)
    End Sub
    Public Sub LoadCategory()
        LoadXgridLookupEdit("select CATID,DESCRIPTION 'Select Category' from tblprocategory order by id asc", "tblprocategory", txtprocat, combogrid, Me)
        combogrid.Columns("CATID").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocat.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("CATID").ToString()
        txtprocat.Text = txtprocat.Properties.View.GetFocusedRowCellValue("Select Category").ToString()
    End Sub
    Public Sub LoadItemDetails()
        com.CommandText = "select * from  tblproductrequest where id = '" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtProductname.Text = rst("itemname").ToString
            txtUnit.Text = rst("unit").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        If txtProductname.Text = "" Then
            XtraMessageBox.Show("Please enter item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProductname.Focus()
            Exit Sub
 
        ElseIf txtprocat.Text = "" Then
            XtraMessageBox.Show("Please select category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprocat.Focus()
            Exit Sub

        ElseIf txtUnit.Text = "" Then
            XtraMessageBox.Show("Please select unit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnit.Focus()
            Exit Sub

        ElseIf countqry("tblglobalproducts", "itemname='" & rchar(txtProductname.Text) & "' and unit='" & txtUnit.Text & "' and deleted=0") > 0 Then
            XtraMessageBox.Show("Duplicate particular item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProductname.SelectAll()
            txtProductname.Focus()
            Exit Sub
        End If

        If XtraMessageBox.Show("Are you sure you want to continue this action?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblglobalproducts set productid='" & getproid() & "',catid='" & catid.Text & "',itemname='" & rchar(txtProductname.Text) & "', unit='" & txtUnit.Text & "', entryby='" & globaluserid & "', dateentered=current_timestamp,actived=1" : com.ExecuteNonQuery()
            com.CommandText = "update tblproductrequest set confirmed=1,confirmedby='" & globaluserid & "',dateconfirmed=current_timestamp, isread=1 where id='" & id.Text & "'" : com.ExecuteNonQuery()
            frmProductRequestList.filterRequestList()
            XtraMessageBox.Show("Request item Successfully confirmed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub ckUnit_CheckedChanged(sender As Object, e As EventArgs) Handles ckUnit.CheckedChanged
        If ckUnit.Checked = True Then
            txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Else
            txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        End If
    End Sub
End Class
