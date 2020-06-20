Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmPumpSettings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmGLPump_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGLPump()
        LoadProduct()
        LoadGridviewAppearance(GridView1)
        If mode.Text <> "edit" Then
            code.Text = getcodeid("pumpcode", "tblsalesfuelpump", "100")
        End If
    End Sub

    Public Sub LoadGLPump()
        LoadXgrid("select pumpcode as 'Code',(select itemname from tblglobalproducts where productid = tblsalesfuelpump.productid and actived=1) as 'Product', description as 'Pump Name' from tblsalesfuelpump", "tblsalesfuelpump", Em, GridView1, Me)
        GridView1.Columns("Product").Group()
        GridView1.ExpandAllGroups()
        GridView1.Columns("Code").Width = 80
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.SelectRow(1)
    End Sub

    Public Sub LoadProduct()
        LoadXgridLookupSearch("select productid, itemname as 'Product Name' from tblglobalproducts where enablesell = 1 and actived = 1", "tblglobalproducts", txtProduct, gridProduct, Me)
        gridProduct.Columns("productid").Visible = False
    End Sub
    Private Sub txtItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtProduct.Properties.View.FocusedRowHandle.ToString)
        productid.Text = txtProduct.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtProduct.Text = txtProduct.Properties.View.GetFocusedRowCellValue("Product Name").ToString()
    End Sub
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please Enter Pump Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf txtProduct.Text = "" Then
            XtraMessageBox.Show("Please Select Product!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProduct.Focus()
            Exit Sub
        ElseIf txtdescription.Text = "" Then
            XtraMessageBox.Show("Please Enter Pump Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdescription.Focus()
            Exit Sub
        ElseIf countqry("tblsalesfuelpump", "pumpcode='" & code.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Pump Code already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf countqry("tblsalesfuelpump", "description='" & rchar(txtdescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Pump Name already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblsalesfuelpump set productid ='" & productid.Text & "', description='" & rchar(UCase(txtDescription.Text)) & "' where pumpcode='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblsalesfuelpump set pumpcode='" & code.Text & "', productid ='" & productid.Text & "',  " _
                              + " description='" & rchar(UCase(txtDescription.Text)) & "'" : com.ExecuteNonQuery()
            End If

            LoadGLPump()
            mode.Text = ""
            code.Text = getcodeid("pumpcode", "tblsalesfuelpump", "100")
            code.Properties.ReadOnly = False
            XtraMessageBox.Show("Pump successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = "" : Dim itemname As String = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select *, (select itemname from tblglobalproducts where productid = tblsalesfuelpump.productid and actived=1) as 'product' from tblsalesfuelpump where pumpcode='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            productid.Text = rst("productid").ToString
            itemname = rst("product").ToString
        End While
        rst.Close()
        txtProduct.Text = itemname
        mode.Text = "edit"
        code.Properties.ReadOnly = True
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tblsalesfuelpump where pumpcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadGLPump()
                XtraMessageBox.Show("Pump successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class