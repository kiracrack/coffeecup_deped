Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPayrollShiftSettings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub frmShiftSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        ClearField()
        LoadData()
        LoadGridviewAppearance(Gridview1)
    End Sub
    Public Sub LoadData()
        LoadXgrid("select shiftcode as 'Shift Code', Description, " _
                    + " date_format(def_1st_in,'%h:%i %p') as 'First Time In', " _
                    + " date_format(def_1st_out,'%h:%i %p') as 'First Time Out', " _
                    + " date_format(def_2nd_in,'%h:%i %p') as 'Second Time In', " _
                    + " date_format(def_2nd_out,'%h:%i %p') as 'Second Time Out', totalhours as 'Total Hours', onetimeinout as 'Onetime In and Out' " _
                    + " from tblpayrollshiftsettings order by shiftcode asc", "tblpayrollshiftsettings", Em, Gridview1, Me)

        XgridColAlign({"Shift Code", "First Time In", "First Time Out", "Second Time In", "Second Time Out", "Total Hours"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If CheckSelectedRow("Description", Gridview1) = True Then
            If XtraMessageBox.Show("Are you sure you want to edit selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                mode.Text = "edit" : code.Text = Gridview1.GetFocusedRowCellValue("Shift Code").ToString
                LoadDetails(code.Text)
            End If
        End If
    End Sub
    Public Sub LoadDetails(ByVal id As String)
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblpayrollshiftsettings where shiftcode='" & id & "'" : rst = com.ExecuteReader
        While rst.Read
            txtshifttype.Text = rst("description").ToString
            txt_first_in.EditValue = rst("def_1st_in")
            txt_first_out.EditValue = rst("def_1st_out")
            ckFlexiBreakTime.Checked = rst("flexibreaktime")
            txt_second_in.EditValue = rst("def_2nd_in")
            txt_second_out.EditValue = rst("def_2nd_out")
            txttotalhours.Text = rst("totalhours").ToString
            ckFlexiAllTime.Checked = rst("flexiregtime")
            ckOnetimeInout.Checked = rst("onetimeinout")
        End While
        rst.Close()
    End Sub
    Public Sub ClearField()
        mode.Text = "" : code.Text = ""
        txtshifttype.Text = ""
        txt_first_in.EditValue = "08:00"
        txt_first_out.EditValue = "12:00"
        ckFlexiBreakTime.Checked = False
        txt_second_in.EditValue = "13:00"
        txt_second_out.EditValue = "17:00"
        txttotalhours.Text = "8"
        ckFlexiAllTime.Checked = False
    End Sub

    Private Sub cmdAttendanceSettings_Click(sender As Object, e As EventArgs) Handles cmdAttendanceSettings.Click
        If txtshifttype.Text = "" Then
            XtraMessageBox.Show("Please enter shift description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtshifttype.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblpayrollshiftsettings set description='" & rchar(txtshifttype.Text) & "', " _
                                + " def_1st_in='" & ConvertServerTime(txt_first_in.Text) & "', " _
                                + " def_1st_out='" & ConvertServerTime(txt_first_out.Text) & "', " _
                                + " flexibreaktime=" & ckFlexiBreakTime.CheckState & ", " _
                                + " def_2nd_in='" & ConvertServerTime(txt_second_in.Text) & "', " _
                                + " def_2nd_out='" & ConvertServerTime(txt_second_out.Text) & "', " _
                                + " totalhours='" & txttotalhours.Text & "', " _
                                + " flexiregtime=" & ckFlexiAllTime.CheckState & ", " _
                                + " onetimeinout=" & ckOnetimeInout.CheckState & " " _
                                + " where shiftcode='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblpayrollshiftsettings set description='" & rchar(txtshifttype.Text) & "', " _
                                + " def_1st_in='" & ConvertServerTime(txt_first_in.Text) & "', " _
                                + " def_1st_out='" & ConvertServerTime(txt_first_out.Text) & "', " _
                                + " flexibreaktime=" & ckFlexiBreakTime.CheckState & ", " _
                                + " def_2nd_in='" & ConvertServerTime(txt_second_in.Text) & "', " _
                                + " def_2nd_out='" & ConvertServerTime(txt_second_out.Text) & "', " _
                                + " flexiregtime=" & ckFlexiAllTime.CheckState & ", " _
                                + " onetimeinout=" & ckOnetimeInout.CheckState & ", " _
                                + " totalhours='" & txttotalhours.Text & "'" : com.ExecuteNonQuery()
        End If

        ClearField() : LoadData()
        XtraMessageBox.Show("Shift type successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txt_first_in_EditValueChanged(sender As Object, e As EventArgs) Handles txt_first_in.EditValueChanged, _
        txt_first_out.EditValueChanged, _
        txt_second_in.EditValueChanged, _
        txt_second_out.EditValueChanged
        computeHours()
    End Sub
    Public Sub computeHours()
        Dim d_in As Date
        Dim d_out As Date
        Dim l_in As Date
        Dim l_out As Date
        Dim total_d As Double = 0
        Dim total_l As Double = 0
        d_in = txt_first_in.Text : d_out = txt_first_out.Text
        l_in = txt_second_in.Text : l_out = txt_second_out.Text
        If d_out < d_in Then
            total_d = Val(DateDiff("H", d_in, d_out.AddDays(1)))
        Else
            total_d = Val(DateDiff("H", d_in, d_out))
        End If
        If l_out < l_in Then
            total_l = Val(DateDiff("H", l_in, l_out.AddDays(1)))
        Else
            total_l = Val(DateDiff("H", l_in, l_out))
        End If
        txttotalhours.Text = FormatNumber(total_d + total_l, 2)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadData()
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE FROM tblpayrollshiftsettings where shiftcode='" & Gridview1.GetFocusedRowCellValue("Shift Code").ToString & "'" : com.ExecuteNonQuery()
            LoadData()
        End If
    End Sub
End Class