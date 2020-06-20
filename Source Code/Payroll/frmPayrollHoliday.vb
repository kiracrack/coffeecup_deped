Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPayrollHoliday
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPayrollHoliday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        ClearField()
        LoadData()
        LoadOffice()
        LoadToComboBoxQuery("years", "distinct(date_format(dateholiday,'%Y')) as 'years'", "tblpayrollholiday", txtYear)
        If Not txtYear.Properties.Items.Contains(Now.ToString("yyyy")) = True Then
            txtYear.Properties.Items.Add(Now.ToString("yyyy"))
        End If
        txtYear.Text = Now.ToString("yyyy")
        LoadGridviewAppearance(Gridview1)
    End Sub
    Public Sub LoadOffice()
        LoadToComboBox("officename", "tblcompoffice", txtOfficeName, True)
    End Sub

    Private Sub txtOfficeName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtOfficeName.SelectedValueChanged
        officeid.Text = qrysingledata("officeid", "officeid", "where officename='" & txtOfficeName.Text & "'", "tblcompoffice")
    End Sub
    Public Sub LoadData()
        LoadXgrid("select id, if(alloffice=1,'All',(select officename from tblcompoffice where officeid = tblpayrollholiday.officeid)) as 'Office', date_format(dateholiday,'%Y-%m-%d') as 'Date Holiday', Description from tblpayrollholiday where date_format(dateholiday,'%Y')='" & txtYear.Text & "' order by dateholiday asc", "tblpayrollholiday", Em, Gridview1, Me)
        Gridview1.Columns("id").Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If CheckSelectedRow("Description", Gridview1) = True Then
            mode.Text = "edit" : code.Text = Gridview1.GetFocusedRowCellValue("id").ToString
            LoadDetails(code.Text)
        End If
    End Sub
    Public Sub LoadDetails(ByVal id As String)
        If code.Text = "" Then Exit Sub
        Dim alloffice As Boolean : Dim office As String = ""
        com.CommandText = "select *,(select officename from tblcompoffice where officeid = tblpayrollholiday.officeid) as 'office' from tblpayrollholiday where id='" & id & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            alloffice = rst("alloffice")
            If CBool(rst("alloffice")) = False Then
                office = rst("office").ToString
            End If
        End While
        rst.Close()
        ckAllOffice.Checked = alloffice
        If alloffice = False Then
            txtOfficeName.Text = office
            txtOfficeName.Enabled = True
        Else
            txtOfficeName.SelectedIndex = -1
            txtOfficeName.Enabled = False
        End If
        txtDescription.Focus()
    End Sub
    Public Sub ClearField()
        mode.Text = "" : code.Text = ""
        txtDescription.Text = "Enter holiday description.."
    End Sub

    Private Sub submitData()
        If ckAllOffice.Checked = False And txtOfficeName.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOfficeName.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblpayrollholiday set officeid='" & officeid.Text & "', alloffice='" & ckAllOffice.CheckState & "',dateholiday='" & ConvertDate(txtDateHoliday.EditValue) & "', description='" & rchar(txtDescription.Text) & "' where id='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblpayrollholiday set officeid='" & officeid.Text & "', alloffice='" & ckAllOffice.CheckState & "',dateholiday='" & ConvertDate(txtDateHoliday.EditValue) & "', description='" & rchar(txtDescription.Text) & "'" : com.ExecuteNonQuery()
        End If

        ClearField() : LoadData()
        XtraMessageBox.Show("Holiday successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadData()
    End Sub

   
    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If e.KeyChar() = Chr(13) Then
            submitData()
        End If
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE FROM tblpayrollholiday where id='" & Gridview1.GetFocusedRowCellValue("Code").ToString & "'" : com.ExecuteNonQuery()
            LoadData()
        End If
    End Sub

    Private Sub ckComputeAttendance_CheckedChanged(sender As Object, e As EventArgs) Handles ckAllOffice.CheckedChanged
        If ckAllOffice.Checked = True Then
            txtOfficeName.SelectedIndex = -1
            txtOfficeName.Enabled = False
        Else
            txtOfficeName.Enabled = True
        End If
    End Sub

    Private Sub txtDescription_GotFocus(sender As Object, e As EventArgs) Handles txtDescription.GotFocus
        If txtDescription.Text = "Enter holiday description.." Then
            txtDescription.Text = ""
        End If
    End Sub

    Private Sub txtDescription_LostFocus(sender As Object, e As EventArgs) Handles txtDescription.LostFocus
        If txtDescription.Text = "" Then
            txtDescription.Text = "Enter holiday description.."
        End If
    End Sub
 
    Private Sub txtYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtYear.SelectedValueChanged
        LoadData()
    End Sub
End Class