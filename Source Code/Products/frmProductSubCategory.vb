Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmProductSubCategory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelRoomType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadData()
        LoadCategory()
        LoadGridviewAppearance(GridView1)
        If mode.Text <> "edit" Then
            code.Text = getcodeid("subcatid", "tblprosubcategory", "100")
        End If
    End Sub
    Public Sub LoadCategory()
        LoadXgridLookupSearch("SELECT catid, Description from tblprocategory", "tblprocategory", txtCategory, gridcategory, Me)
        gridcategory.Columns("catid").Visible = False
    End Sub
    Private Sub txtCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategory.EditValueChanged
        On Error Resume Next
        catid.Text = txtCategory.Properties.View.GetFocusedRowCellValue("catid").ToString()
        LoadData()
    End Sub

    Public Sub LoadData()
        If txtCategory.Text = "" Then Exit Sub
        LoadXgrid("select subcatid as 'Code', Description  from tblprosubcategory where catid='" & catid.Text & "' order by Description asc ", "tblprosubcategory", Em, GridView1, Me)

        GridView1.Columns("Code").Width = 80
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        ' GridView1.SelectRow(1)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please Enter Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf txtCategory.Text = "" Then
            XtraMessageBox.Show("Please select category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCategory.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        ElseIf countqry("tblprosubcategory", "subcatid='" & code.Text & "' ") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("code already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf countqry("tblprosubcategory", "Description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Description already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblprosubcategory set catid='" & catid.Text & "', Description='" & rchar(UCase(txtDescription.Text)) & "' where subcatid='" & code.Text & "'" : com.ExecuteNonQuery()
                UpdateImage2("referenceno='" & code.Text & "' and tablename='tblprosubcategory'", ",referenceno='" & code.Text & "',tablename='tblprocategory'", "imgdata", "filedir.tblimagerepository", PictureEdit1, Me)
            Else
                com.CommandText = "insert into tblprosubcategory set catid='" & catid.Text & "', subcatid='" & code.Text & "', Description='" & rchar(UCase(txtDescription.Text)) & "'" : com.ExecuteNonQuery()
                UpdateImage2("referenceno='" & code.Text & "' and tablename='tblprosubcategory'", ",referenceno='" & code.Text & "',tablename='tblprocategory'", "imgdata", "filedir.tblimagerepository", PictureEdit1, Me)
            End If

            LoadData()
            mode.Text = ""
            code.Text = getcodeid("subcatid", "tblprosubcategory", "100")
            'XtraMessageBox.Show("Item successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select *,ifnull((select imgdata from filedir.tblimagerepository where referenceno=tblprosubcategory.subcatid and tablename='tblprocategory'),null) as img from tblprosubcategory where subcatid='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            catid.Text = rst("catid").ToString
            txtDescription.Text = rst("Description").ToString
            ShowImage("img", PictureEdit1, Me)
        End While
        rst.Close()
        mode.Text = "edit"

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim cnt As Integer = 0
                For I = 0 To GridView1.SelectedRowsCount - 1
                    If countqry("tblglobalproducts", "subcatid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'") = 0 Then
                        com.CommandText = "delete from tblprosubcategory where subcatid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                        cnt = cnt + 1
                    Else
                        XtraMessageBox.Show("Cannot remove " & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Description").ToString & "! Category currently in use", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Next
                If cnt > 0 Then
                    LoadData() : code.Text = getcodeid("subcatid", "tblprosubcategory", "100")
                    XtraMessageBox.Show("Some item are successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub signature_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PictureEdit1.Validating
        ResizeImage(PictureEdit1, 600)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

End Class