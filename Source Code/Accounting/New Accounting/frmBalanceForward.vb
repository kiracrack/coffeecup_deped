Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmBalanceForward
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmBudgetManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
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
        LoadOffice()
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice where companyid='" & companyid.Text & "' and deleted=0 order by officename asc", "tblcompoffice", txtOffice, gv_Office, Me)
        gv_Office.Columns("officeid").Visible = False
    End Sub
    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        LoadStructure()
    End Sub
    Public Sub LoadStructure()
        If companyid.Text = "" Or officeid.Text = "" Then Exit Sub
        LoadXgrid("SELECT a.itemcode, " & GlobalGLitemname & " as 'Particulars',a.itemname,  if(b.debit=1, b.debitamount, b.creditamount) as Total, if(a.glgroup=1,1,0) as glgroup, if(a.gl=1,1,0) as gl, if(a.sl=1,1,0) as sl, a.level, if(a.debit=1,1,0) as debitnormal, a.parent FROM `tblglitem` as a left join tblglticket as b on a.itemcode=b.itemcode and b.companyid='" & companyid.Text & "' and b.officeid='" & officeid.Text & "' and b.balforward=1 where a.groupcode in (select groupcode from tblglgrouptag where (assets=1 or liabilities=1 or equity=1) and deleted=0) and a.companyid='" & companyid.Text & "' order by a.groupcode,a.itemcode;", "tblglitem", Em, Gridview1, Me)
        XgridHideColumn({"itemcode", "itemname", "sl", "glgroup", "parent", "gl", "level", "debitnormal"}, Gridview1)
        XgridColCurrency({"Total"}, Gridview1)
        XgridColWidth({"Total"}, Gridview1, 130)
        XgridColWidth({"Particulars"}, Gridview1, 730)
        XgridGeneralSummaryCurrency({"Total"}, Gridview1)
        XgridDisableColumn({"Particulars", "itemcode", "sl", "Remarks"}, Gridview1, False)
        For Each col In Gridview1.Columns
            col.OptionsColumn.AllowSort = DefaultBoolean.False
        Next
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles Gridview1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colParticulars" Then
            e.Appearance.ForeColor = Color.Black
            e.Appearance.BackColor = Color.LightYellow
        End If
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.Khaki
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
            If e.Column.Name <> "colParticulars" Then
                ' e.Appearance.ForeColor = Color.Khaki
            End If
        End If
    End Sub

    Private Sub Gridview1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Gridview1.CellValueChanged
        If CBool(Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("sl")).ToString()) = True Then
            Dim totalVallue As Double = 0 : Dim parent As String = Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("parent")).ToString()
            For I = 0 To Gridview1.RowCount - 1
                If Gridview1.GetRowCellDisplayText(I, Gridview1.Columns("parent")) = parent Then
                    totalVallue += Val(CC(Gridview1.GetRowCellValue(I, Gridview1.Columns("Total")).ToString()))
                End If
            Next
            For I = 0 To Gridview1.RowCount - 1
                If Gridview1.GetRowCellDisplayText(I, Gridview1.Columns("parent")) = parent Or Gridview1.GetRowCellDisplayText(I, Gridview1.Columns("itemcode")) = parent Then
                    Gridview1.SetRowCellValue(I, Gridview1.Columns("Total"), totalVallue)
                    Exit For
                End If
            Next


            Dim str_parent As String = "" : Dim totalsum As Double = 0
            com.CommandText = "SELECT distinct parent FROM `tblglitem` where companyid='" & companyid.Text & "' order by level desc" : rst = com.ExecuteReader
            While rst.Read
                totalsum = 0
                For I = 0 To Gridview1.RowCount - 1
                    If Gridview1.GetRowCellValue(I, Gridview1.Columns("parent")).ToString() = rst("parent").ToString Then
                        totalsum += Val(CC(Gridview1.GetRowCellValue(I, Gridview1.Columns("Total")).ToString()))
                    End If
                Next
                For I = 0 To Gridview1.RowCount - 1
                    If CBool(Gridview1.GetRowCellDisplayText(I, Gridview1.Columns("glgroup"))) = True Or CBool(Gridview1.GetRowCellDisplayText(I, Gridview1.Columns("sl"))) = False Then
                        If Gridview1.GetRowCellDisplayText(I, Gridview1.Columns("itemcode")).ToString = rst("parent").ToString Then
                            'MsgBox(Gridview1.GetRowCellValue(I, Gridview1.Columns("itemcode")).ToString())
                            Gridview1.SetRowCellValue(I, Gridview1.Columns("Total"), totalsum)
                        End If
                    End If
                Next
            End While
            rst.Close()
        End If


    End Sub

    Private Sub gridView1_ShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Gridview1.ShowingEditor
        If CBool(Gridview1.GetRowCellValue(Gridview1.FocusedRowHandle, Gridview1.Columns("sl"))) = False Then
            e.Cancel = True
        End If
    End Sub



    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub


    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        'If Val(CC(Gridview1.Columns("Debit").SummaryText)) <> Val(CC(Gridview1.Columns("Credit").SummaryText)) Then
        '    XtraMessageBox.Show("Budget revision of Original and Final are not equal!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        If XtraMessageBox.Show("Are you sure you want to continue? " & todelete, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SaveBudgetSetup()
            MessageBox.Show("Balance forward Successfuly Confirm", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub SaveBudgetSetup()
        com.CommandText = "delete from tblglticket where companyid='" & companyid.Text & "' and officeid='" & officeid.Text & "' and balforward=1" : com.ExecuteNonQuery()
        ProgressBarControl1.Properties.Maximum = Gridview1.RowCount - 1
        For I = 0 To Gridview1.RowCount - 1
            If Val(CC(Gridview1.GetRowCellValue(I, "Total").ToString)) > 0 And CBool(Gridview1.GetRowCellValue(I, "sl").ToString) = True Then
                If CBool(Gridview1.GetRowCellValue(I, "debitnormal").ToString) = True Then
                    com.CommandText = "insert into tblglticket set companyid='" & companyid.Text & "', officeid='" & officeid.Text & "',itemcode='" & Gridview1.GetRowCellValue(I, "itemcode").ToString & "',itemname='" & rchar(Gridview1.GetRowCellValue(I, "itemname").ToString) & "', debitamount='" & Val(CC(Gridview1.GetRowCellValue(I, "Total").ToString)) & "', creditamount=0, referenceno='', remarks='balance forwarded',debit=" & CBool(Gridview1.GetRowCellValue(I, "debitnormal").ToString) & ", datetrn='" & ConvertDate(txtReportDate.EditValue) & "', trnby='" & globaluserid & "',trnname='" & rchar(globalfullname) & "', balforward=1 " : com.ExecuteNonQuery()
                Else
                    com.CommandText = "insert into tblglticket set companyid='" & companyid.Text & "', officeid='" & officeid.Text & "',itemcode='" & Gridview1.GetRowCellValue(I, "itemcode").ToString & "',itemname='" & rchar(Gridview1.GetRowCellValue(I, "itemname").ToString) & "', debitamount=0, creditamount='" & Val(CC(Gridview1.GetRowCellValue(I, "Total").ToString)) & "', referenceno='', remarks='balance forwarded',debit=" & CBool(Gridview1.GetRowCellValue(I, "debitnormal").ToString) & ", datetrn='" & ConvertDate(txtReportDate.EditValue) & "', trnby='" & globaluserid & "',trnname='" & rchar(globalfullname) & "', balforward=1 " : com.ExecuteNonQuery()
                End If

            End If
            ProgressBarControl1.EditValue = I
            ProgressBarControl1.Update()
        Next
    End Sub
End Class