Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils
Imports Excel = Microsoft.Office.Interop.Excel
Imports DevExpress.XtraSplashScreen

Public Class frmGLCaptureChartofAccount
    Public DataBook As Excel.Workbook
    Public DS_ChartOfAccount As Excel.Worksheet
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGLCaptureChartofAccount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmGLCaptureChartofAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCompany()
    End Sub

    Public Sub LoadCompany()
        LoadXgridLookupSearch("SELECT Code,companyname as 'Company' from tblcompany order by Code asc", "tblcompany", txtCompany, GridView_company, Me)
        GridView_company.Columns("Code").Width = 70
        XgridColAlign({"Code"}, GridView_company, HorzAlignment.Center)
    End Sub
    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("Code").ToString()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtCompany.Text = "" Then
            XtraMessageBox.Show("Please select company!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompany.Focus()
            Exit Sub
        End If

        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Try
                SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
                Dim CompleteQuery As String = ""
                Dim Cell As Excel.Range
                Dim ExcelApp As New Excel.Application
                DataBook = ExcelApp.Workbooks.Open(txtChartofAccounts.Text)
                DS_ChartOfAccount = DataBook.Worksheets("Sheet")
                'START ITEM CAPTURE
                Dim arrayItem() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}
                com.CommandText = "delete from tblglgroup where companyid='" & companyid.Text & "';" : com.ExecuteNonQuery() : com.CommandText = "delete from tblglitem where companyid='" & companyid.Text & "';" : com.ExecuteNonQuery()
                For R = 2 To GetLastItemRow(txtChartofAccounts.Text)
                    Dim g_companyid As String = "" : Dim g_group As String = "" : Dim g_code As String = "" : Dim g_desc As String = "" : Dim g_parent As String = "" : Dim g_glgroup As Boolean : Dim g_gl As Boolean : Dim g_sl As Boolean : Dim g_level As Integer : Dim g_debit As Boolean : Dim coulumnCount As Integer = 0
                    For Each valueArr As String In arrayItem
                        For Each Cell In DS_ChartOfAccount.Range(valueArr & R)
                            Dim value_x As String = ""
                            value_x = System.Convert.ToString(Cell.Cells.Value2)
                            If coulumnCount = 0 Then
                                g_companyid = value_x
                            ElseIf coulumnCount = 1 Then
                                g_group = value_x
                            ElseIf coulumnCount = 2 Then
                                g_code = value_x
                            ElseIf coulumnCount = 3 Then
                                g_desc = value_x
                            ElseIf coulumnCount = 4 Then
                                g_parent = value_x
                            ElseIf coulumnCount = 5 Then
                                g_glgroup = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 6 Then
                                g_gl = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 7 Then
                                g_sl = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 8 Then
                                g_level = If(value_x = "", 0, value_x)
                            ElseIf coulumnCount = 9 Then
                                g_debit = If(value_x = "", 0, CBool(value_x))
                            End If
                            coulumnCount = coulumnCount + 1
                        Next
                    Next
                    CompleteQuery += "insert into tblglitem set companyid='" & g_companyid & "', groupcode='" & g_group & "', itemcode='" & g_code & "', itemname='" & rchar(g_desc) & "', parent='" & g_parent & "',glgroup=" & g_glgroup & ",gl=" & g_gl & ",sl=" & g_sl & ", level=" & g_level & ", debit=" & g_debit & ";" & Environment.NewLine
                Next
                For Each strLineItem As String In CompleteQuery.Split(vbLf)
                    If strLineItem <> "" Then
                        com.CommandText = strLineItem : com.ExecuteNonQuery()
                    End If
                Next
                com.CommandText = "insert into tblglgroup (companyid,groupcode,groupname,normalbalance) SELECT companyid,itemcode,itemname,if(debit=1,'DEBIT','CREDIT') FROM `tblglitem` where companyid='" & companyid.Text & "' and glgroup=1;" : com.ExecuteNonQuery()
                DataBook.Close(False)
                ExcelApp.Quit()
                SplashScreenManager.CloseForm()
                XtraMessageBox.Show("Chart of account successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch fileException As Exception
                SplashScreenManager.CloseForm()
                Throw fileException
            End Try
        End If

    End Sub

    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtChartofAccounts.ButtonClick
        Dim objOpenFileDialog As New OpenFileDialog
        With objOpenFileDialog
            .Filter = "Excell files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtChartofAccounts.Text = objOpenFileDialog.FileName
        End If
        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub

    Public Function GetLastGroupRow(ByVal location As String) As Long
        Dim xlApp As New Excel.Application
        Dim xlWb As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        GetLastGroupRow = 0
        With xlApp
            .Visible = False
            xlWb = .Workbooks.Open(location)
            xlsheet = xlWb.Sheets("Sheet")
            With xlsheet
                GetLastGroupRow = .Range("A" & .Rows.Count).End(Excel.XlDirection.xlUp).Row
            End With
            xlWb.Close(False)
            xlApp.Quit()
        End With
        Return GetLastGroupRow
    End Function

    Public Function GetLastItemRow(ByVal location As String) As Long
        Dim xlApp As New Excel.Application
        Dim xlWb As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        GetLastItemRow = 0
        With xlApp
            .Visible = False
            xlWb = .Workbooks.Open(location)
            xlsheet = xlWb.Sheets("Sheet")
            With xlsheet
                GetLastItemRow = .Range("A" & .Rows.Count).End(Excel.XlDirection.xlUp).Row
            End With
            xlWb.Close(False)
            xlApp.Quit()
        End With
        Return GetLastItemRow
    End Function
End Class