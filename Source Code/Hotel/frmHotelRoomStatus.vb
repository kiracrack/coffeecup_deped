Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHotelRoomStatus
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
    End Sub

    Public Sub LoadData()
        LoadXgrid("select statuscode as 'Code', Description,updateroomstatus as 'Update Room Status', vacantcleared as 'Allow Guest to Occupy',Maintainance,Color  from tblhotelroomstatus", "tblhotelroomstatus", Em, GridView1, Me)

        GridView1.Columns("Code").Width = 80
        GridView1.Columns("Color").Width = 40
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colColor" Then
            Dim colorRgb As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Color"))
            e.Appearance.BackColor = RGBColorConverter(colorRgb)
            e.Appearance.ForeColor = RGBColorConverter(colorRgb)
        End If
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please Enter Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        ElseIf countqry("tblhotelroomstatus", "statuscode='" & code.Text & "' ") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Code already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub
        ElseIf countqry("tblhotelroomstatus", "Description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Description already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblhotelroomstatus set Description='" & rchar(UCase(txtDescription.Text)) & "',updateroomstatus='" & ckUpdateRoomStatus.CheckState & "' " & If(ckUpdateRoomStatus.Checked = True, If(radgroup.EditValue = "VC", ",vacantcleared=1,maintainance=0", ",vacantcleared=0,maintainance=1"), "") & ",color='" & txtBgColor.Text & "' where statuscode='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblhotelroomstatus set statuscode='" & code.Text & "', Description='" & rchar(UCase(txtDescription.Text)) & "',updateroomstatus=" & ckUpdateRoomStatus.CheckState & " " & If(ckUpdateRoomStatus.Checked = True, If(radgroup.EditValue = "VC", ",vacantcleared=1,maintainance=0", ",vacantcleared=0,maintainance=1"), "") & ",color='" & txtBgColor.Text & "'" : com.ExecuteNonQuery()
            End If
            LoadData()
            mode.Text = "" : code.Text = "" : txtDescription.Text = "" : txtBgColor.Text = "" : txtBgColor.BackColor = DefaultBackColor : txtBgColor.ForeColor = DefaultForeColor
            XtraMessageBox.Show("Room status successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select * from tblhotelroomstatus where statuscode='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("Description").ToString
            ckUpdateRoomStatus.Checked = rst("updateroomstatus")
            txtBgColor.Text = rst("color").ToString
            ChangeColor(rst("color").ToString)
            If CBool(rst("updateroomstatus")) = True Then
                If CBool(rst("vacantcleared")) = True Then
                    radgroup.SelectedIndex = 0
                Else
                    radgroup.SelectedIndex = 1
                End If
            End If
        End While
        rst.Close()
        mode.Text = "edit"

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow("Code", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from tblhotelroomstatus where statuscode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
                Next
                LoadData()
                XtraMessageBox.Show("Item successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub ckUpdateRoomStatus_CheckedChanged(sender As Object, e As EventArgs) Handles ckUpdateRoomStatus.CheckedChanged
        If ckUpdateRoomStatus.Checked = True Then
            radgroup.Enabled = True
        Else
            radgroup.Enabled = False
            radgroup.SelectedIndex = -1
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            txtBgColor.Text = ColorDialog1.Color.R.ToString & "," & ColorDialog1.Color.G.ToString & "," & ColorDialog1.Color.B.ToString
            ChangeColor(txtBgColor.Text)
        End If
    End Sub

    Public Sub ChangeColor(ByVal RGBString As String)
        Dim RGB As String() = RGBString.Split(",")
        If RGBString.Length > 0 Then
            txtBgColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
            txtBgColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
        Else
            txtBgColor.BackColor = DefaultBackColor : txtBgColor.ForeColor = DefaultForeColor
        End If
       
    End Sub

    Public Function RGBColorConverter(ByVal RGBString As String) As Color
        Dim RGB As String() = RGBString.Split(",")
        If RGBString.Length > 0 Then
            RGBColorConverter = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
        Else
            RGBColorConverter = Color.Black
        End If

    End Function

End Class