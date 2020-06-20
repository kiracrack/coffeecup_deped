﻿Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO
Imports DevExpress.Utils

Public Class frmIncomeStatement
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        ElseIf keyData = (Keys.Control) + Keys.P Then
            ' printreport()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtReportDate.EditValue = CDate(Now)
        LoadCompany()
    End Sub

    Public Sub LoadCompany()
        LoadXgridLookupSearch("select code, Companyname as 'Select Company' from tblcompany", "tblcompany", txtCompany, gvCompany, Me)
        gvCompany.Columns("code").Visible = False
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Public Sub LoadStructure()
        If companyid.Text = "" Then Exit Sub
        Dim OfficeCaption As String = "" : Dim OfficeColumn As String = "" : Dim Officefilter As String = ""

        If ckConsolidated.Checked = False Then
            com.CommandText = "select * from tblcompoffice where companyid='" & companyid.Text & "' and deleted=0 order by officename asc" : rst = com.ExecuteReader
            While rst.Read
                OfficeCaption = OfficeCaption + "'' as '" & rst("shortname").ToString + "', "
                OfficeColumn = OfficeColumn + rst("shortname").ToString + ":"
                Officefilter = Officefilter + StrConv(rst("officeid").ToString, vbProperCase) + ":"
            End While
            rst.Close()

            If OfficeCaption <> "" Then
                OfficeColumn = OfficeColumn.Remove(OfficeColumn.Length - 1, 1)
                Officefilter = Officefilter.Remove(Officefilter.Length - 1, 1)
            End If
        End If
      

        com.CommandText = "call sp_acct_incomestatement('" & companyid.Text & "', '" & CDate(txtReportDate.EditValue).ToString("yyyy") & "', '" & ConvertDate(txtReportDate.EditValue) & "')" : com.ExecuteNonQuery()

        LoadXgrid("SELECT a.groupcode,a.itemcode, " & GlobalGLitemname & " as 'PARTICULARS', " & OfficeCaption & " TOTAL, if(a.glgroup=1,1,0) as glgroup, if(a.gl=1,1,0) as gl, if(a.sl=1,1,0) as sl, a.level, a.parent,if(a.summary=1,1,0) as summary   FROM `tmpIncomeStatement` as a where a.companyid='" & companyid.Text & "' order by a.groupcode, a.itemcode;", "tmpIncomeStatement", Em, GridView1, Me)
        XgridHideColumn({"groupcode", "itemcode", "itemname", "sl", "glgroup", "parent", "gl", "level", "summary"}, GridView1)
        XgridColCurrency({"TOTAL"}, GridView1)

        If ckConsolidated.Checked = False Then
            For I = 0 To GridView1.RowCount - 1
                For Each word In Officefilter.Split(New Char() {":"c})
                    Dim columnCaption As String = qrysingledata("shortname", "shortname", "where officeid='" & word & "'", "tblcompoffice")
                    dst = Nothing : dst = New DataSet
                    msda = New MySqlDataAdapter("select *,ifnull(amount,0) as 'Total' from tmpofficebalance where companyid='" & companyid.Text & "' and officeid='" & word & "' and itemcode='" & GridView1.GetRowCellValue(I, "itemcode").ToString & "'", conn)
                    msda.Fill(dst, 0)
                    For cnt = 0 To dst.Tables(0).Rows.Count - 1
                        With (dst.Tables(0))
                            GridView1.SetRowCellValue(I, columnCaption, FormatNumber(Val(.Rows(cnt)("Total").ToString()), 2))
                        End With
                    Next
                Next
                If CBool(GridView1.GetRowCellValue(I, "summary").ToString) = True Then
                    If GridView1.GetRowCellValue(I, "groupcode").ToString = "999" Then
                        For Each word In Officefilter.Split(New Char() {":"c})
                            Dim columnCaption As String = qrysingledata("shortname", "shortname", "where officeid='" & word & "'", "tblcompoffice")
                            dst = Nothing : dst = New DataSet
                            msda = New MySqlDataAdapter("select * from tmpOfficeGrandTotal where officeid='" & word & "'", conn)
                            msda.Fill(dst, 0)
                            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                                With (dst.Tables(0))
                                    GridView1.SetRowCellValue(I, columnCaption, FormatNumber(Val(.Rows(cnt)("Total").ToString()), 2))
                                End With
                            Next
                        Next
                    Else
                        For Each word In Officefilter.Split(New Char() {":"c})
                            Dim columnCaption As String = qrysingledata("shortname", "shortname", "where officeid='" & word & "'", "tblcompoffice")
                            dst = Nothing : dst = New DataSet
                            msda = New MySqlDataAdapter("select *,ifnull(amount,0) as 'Total' from tmpRunningBalance where companyid='" & companyid.Text & "' and officeid='" & word & "' and itemcode='" & GridView1.GetRowCellValue(I, "parent").ToString & "'", conn)
                            msda.Fill(dst, 0)
                            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                                With (dst.Tables(0))
                                    GridView1.SetRowCellValue(I, columnCaption, FormatNumber(Val(.Rows(cnt)("Total").ToString()), 2))
                                End With
                            Next
                        Next
                    End If
                End If
            Next
        End If

        For Each word In OfficeColumn.Split(New Char() {":"c})
            XgridColCurrency({word}, GridView1)
        Next

        For Each col In GridView1.Columns
            col.OptionsColumn.AllowSort = DefaultBoolean.False
        Next
        GridView1.BestFitColumns()
        XgridColWidth({"TOTAL"}, GridView1, 130)
        If ckConsolidated.Checked = True Then
            XgridColWidth({"PARTICULARS"}, GridView1, 430)
        End If
        For Each col In GridView1.Columns
            col.OptionsColumn.AllowSort = DefaultBoolean.False
        Next
        ' LoadParentTotal()
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
       
        If View.GetRowCellDisplayText(e.RowHandle, View.Columns("PARTICULARS").ToString) = "  " Then
            e.Appearance.BackColor = Color.White
            e.Appearance.ForeColor = Color.White
        Else
            Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
            If sl = False Then
                If CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("gl"))) = True Then
                    e.Appearance.BackColor = Color.White
                    If e.Column.Name <> "colPARTICULARS" Then
                        e.Appearance.ForeColor = Color.White
                    End If
                    e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
                Else
                    e.Appearance.BackColor = Color.LightYellow
                    e.Appearance.ForeColor = Color.Black
                    e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
                End If
            End If
            If e.Column.Name = "colPARTICULARS" Then
                If e.RowHandle = View.FocusedRowHandle Then
                    e.Appearance.BackColor = Color.Green
                    e.Appearance.ForeColor = Color.White
                End If
            End If
        End If
    End Sub

    Public Sub LoadParentTotal()
        'Dim totalVallue As Double = 0 : Dim parent As String = ""
        'For x = 0 To GridView1.RowCount - 1
        '    If CBool(GridView1.GetRowCellValue(x, GridView1.Columns("summary")).ToString()) = False And CBool(GridView1.GetRowCellDisplayText(x, GridView1.Columns("sl"))) = True Then
        '        parent = GridView1.GetRowCellDisplayText(x, GridView1.Columns("parent"))

        '        For I = 0 To GridView1.RowCount - 1
        '            If CBool(GridView1.GetRowCellDisplayText(I, GridView1.Columns("summary"))) = False And GridView1.GetRowCellDisplayText(I, GridView1.Columns("parent")) = parent Then
        '                totalVallue += Val(CC(GridView1.GetRowCellValue(I, GridView1.Columns("TOTAL")).ToString()))
        '            End If
        '        Next
        '        For I = 0 To GridView1.RowCount - 1
        '            If (CBool(GridView1.GetRowCellDisplayText(I, GridView1.Columns("summary"))) = True And GridView1.GetRowCellDisplayText(I, GridView1.Columns("parent")) = parent) Or GridView1.GetRowCellDisplayText(I, GridView1.Columns("itemcode")) = parent Then
        '                GridView1.SetRowCellValue(I, GridView1.Columns("TOTAL"), totalVallue)
        '                Exit For
        '            End If
        '        Next

        '        Dim str_parent As String = "" : Dim totalsum As Double = 0
        '        com.CommandText = "SELECT distinct parent FROM `tblglitem` where companyid='" & companyid.Text & "' and groupcode in (select groupcode from tblglgrouptag where (revenue=1 or expenses=1) and deleted=0) order by level desc" : rst = com.ExecuteReader
        '        While rst.Read
        '            totalsum = 0
        '            For I = 0 To GridView1.RowCount - 1
        '                If CBool(GridView1.GetRowCellDisplayText(I, GridView1.Columns("summary"))) = False And GridView1.GetRowCellValue(I, GridView1.Columns("parent")).ToString() = rst("parent").ToString Then
        '                    totalsum += Val(CC(GridView1.GetRowCellValue(I, GridView1.Columns("TOTAL")).ToString()))
        '                End If
        '            Next
        '            For I = 0 To GridView1.RowCount - 1
        '                If CBool(GridView1.GetRowCellDisplayText(I, GridView1.Columns("summary"))) = True Or CBool(GridView1.GetRowCellDisplayText(I, GridView1.Columns("sl"))) = False Then
        '                    If GridView1.GetRowCellValue(I, GridView1.Columns("itemcode")).ToString() = rst("parent").ToString & "-999" Or GridView1.GetRowCellDisplayText(I, GridView1.Columns("itemcode")).ToString = rst("parent").ToString Then
        '                        'MsgBox(Gridview1.GetRowCellValue(I, Gridview1.Columns("itemcode")).ToString())
        '                        'GridView1.SetRowCellValue(I, GridView1.Columns("TOTAL"), totalsum)
        '                    End If
        '                End If
        '            Next
        '        End While
        '        rst.Close()

        '    End If
        'Next

    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        LoadStructure()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintDatagridviewGL(txtCompany.Text & "<h4 align='center'>" & UCase(Me.Text) & "<br/>(Profit and Loss Statement) <br/> Balances as of " & txtReportDate.Text & "</h4>", Me.Text, "", GridView1, Me)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(Me.Text & " - " & txtCompany.Text & "(" & txtReportDate.Text & ")", GridView1)
    End Sub

    
End Class