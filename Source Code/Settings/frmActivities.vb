Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.GridColumnSummaryItem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.Skins

Public Class frmActivities

    Public Sub filteractivities()
        dst.Clear()
        Try
            msda = New MySqlDataAdapter("select  " _
            + " tblsystemlogs.DESCRIPTION as 'Description', " _
            + " tblsystemlogs.UPDATEBY as 'Action By', " _
            + " tblsystemlogs.DATELOGS as 'Date Time Action' " _
            + " from tblsystemlogs " _
            + " order by tblsystemlogs.DATELOGS desc", conn)

            msda.Fill(dst, "tblsystemlogs")
            Em.DataSource = dst.Tables("tblsystemlogs")
            GridView1.PopulateColumns(dst.Tables("tblsystemlogs"))
            Em.ForceInitialize()

            GridView1.Columns(0).Width = 400
            GridView1.Columns(1).Width = 300
            GridView1.Columns(2).Width = 170
            'GridView1.Columns(2).Width = 40
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        End Try

    End Sub

    Public Sub filterlogin()
        dst.Clear()
        Try
            msda = New MySqlDataAdapter("select  " _
            + " tbllogin.EMPID as 'User ID', " _
            + " CONCAT(tblemployees.FNAME, ', ', tblemployees.LNAME, ' ',tblemployees.MNAME, ' .') as 'Fullname', " _
            + " tbllogin.INTIME as 'Datetime IN', " _
            + " tbllogin.OUTTIME as 'Datetime OUT' " _
            + " from tbllogin INNER JOIN tblemployees on tbllogin.EMPID = tblemployees.ID " _
            + " order by tbllogin.INTIME desc", conn)

            msda.Fill(dst, "tbllogin")
            Em.DataSource = dst.Tables("tbllogin")
            GridView1.PopulateColumns(dst.Tables("tbllogin"))
            Em.ForceInitialize()

            GridView1.Columns(0).Width = 100
            GridView1.Columns(1).Width = 350
            GridView1.Columns(2).Width = 170
            GridView1.Columns(3).Width = 170

            'GridView1.Columns(2).Width = 40
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        End Try

    End Sub

    Private Sub frmActivities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        filter()
    End Sub
    Public Sub filter()
        If txtfilter.Text = "LOGIN" Then
            filterlogin()
        Else
            filteractivities()
        End If
    End Sub
    Private Sub txtfilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfilter.TextChanged
        filter()
    End Sub
End Class