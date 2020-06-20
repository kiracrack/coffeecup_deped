﻿Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmHotelRoomType
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelRoomType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadData()
        LoadGridviewAppearance(GridView1)
        If mode.Text <> "edit" Then
            code.Text = getcodeid("code", "tblhotelroomtype", "100")
        End If
    End Sub

    Public Sub LoadData()
        LoadXgrid("select code as 'Code', SortOrder, shortcode as 'Short Name', Description, if(chargepernight=1,'Per Night','Per Pax') as 'Charge Mode', MaxPax  from tblhotelroomtype where hotelcif='" & hotelcif.Text & "' order by SortOrder asc", "tblhotelroomtype", Em, GridView1, Me)

        GridView1.Columns("Code").Width = 80
        XgridColAlign({"Code", "SortOrder", "Short Name", "MaxPax"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        ' GridView1.SelectRow(1)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please Enter Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf txtShortname.Text = "" Then
            XtraMessageBox.Show("Please Enter short name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtShortname.Focus()
            Exit Sub

        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        ElseIf countqry("tblhotelroomtype", "code='" & code.Text & "' ") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Clinic Code already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf countqry("tblhotelroomtype", "Description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Description already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        ElseIf Val(txtMaxPax.Text) <= 0 Then
            XtraMessageBox.Show("Please enter valid maximum pax!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMaxPax.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblhotelroomtype set hotelcif='" & hotelcif.Text & "',SortOrder='" & txtSort.Text & "', shortcode='" & txtShortname.Text & "', Description='" & rchar(UCase(txtDescription.Text)) & "',chargepernight=" & radChargeMode.EditValue & ", maxpax='" & Val(txtMaxPax.Text) & "' where code='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblhotelroomtype set hotelcif='" & hotelcif.Text & "',SortOrder='" & txtSort.Text & "', shortcode='" & txtShortname.Text & "', code='" & code.Text & "', Description='" & rchar(UCase(txtDescription.Text)) & "',chargepernight=" & radChargeMode.EditValue & ", maxpax='" & Val(txtMaxPax.Text) & "'" : com.ExecuteNonQuery()
            End If

            LoadData()
            mode.Text = ""
            code.Text = getcodeid("code", "tblhotelroomtype", "100")
            'XtraMessageBox.Show("Room Type successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select * from tblhotelroomtype where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtShortname.Text = rst("shortcode").ToString
            txtDescription.Text = rst("Description").ToString
            radChargeMode.EditValue = CBool(rst("chargepernight"))
            txtMaxPax.Text = rst("maxpax").ToString
        End While
        rst.Close()
        mode.Text = "edit"

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tblhotelroomtype where code='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadData() : code.Text = getcodeid("code", "tblhotelroomtype", "100")
                XtraMessageBox.Show("Item successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

End Class