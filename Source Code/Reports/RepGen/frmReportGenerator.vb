Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class frmReportGenerator
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        
        End If
        Return ProcessCmdKey
    End Function
    Public Sub LoadTemplate()
        LoadXgridLookupSearch("SELECT rptid,rptname as 'Report Template',datequery from tblreporttemplate where reporttype='" & reportype.Text & "' and status=1 order by rptname asc", "tblreporttemplate", txtReportTemplate, GridOffice, Me)
        GridOffice.Columns("rptid").Visible = False
        GridOffice.Columns("datequery").Visible = False
    End Sub
    Private Sub txtReportTemplate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReportTemplate.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtReportTemplate.Properties.View.FocusedRowHandle.ToString)
        id.Text = txtReportTemplate.Properties.View.GetFocusedRowCellValue("rptid").ToString()
        txtReportTemplate.Text = txtReportTemplate.Properties.View.GetFocusedRowCellValue("Report Template").ToString()
        If txtReportTemplate.Properties.View.GetFocusedRowCellValue("datequery") = True Then
            date_from.Enabled = True
            date_to.Enabled = True
        Else
            date_from.Enabled = False
            date_to.Enabled = False
        End If
    End Sub
    ' DATE FORMAT {datefull},{month},{day},{year}
    Public Function rDateSelect(ByVal str As String, ByVal sFromdate As Date, ByVal sTodate As Date)
        Dim from_dateSel As Date = sFromdate
        Dim to_dateSel As Date = sTodate

        ' CONVERTION FROM DATE SELECT
        Dim from_RFullDate As String = ConvertDate(date_from.Text)
        Dim from_RMonthDate As String = from_dateSel.ToString("MM")
        Dim from_RDayDate As String = from_dateSel.ToString("dd")
        Dim from_RYearDate As String = from_dateSel.Year
        str = str.Replace("{from_fulldate}", from_RFullDate)
        str = str.Replace("{from_year}", from_RYearDate)
        str = str.Replace("{from_month}", from_RMonthDate)
        str = str.Replace("{from_day}", from_RDayDate)

        ' CONVERTION TO DATE SELECT
        Dim to_RFullDate As String = ConvertDate(date_to.Text)
        Dim to_RMonthDate As String = to_dateSel.ToString("MM")
        Dim to_RDayDate As String = to_dateSel.ToString("dd")
        Dim to_RYearDate As String = to_dateSel.Year
        str = str.Replace("{to_fulldate}", to_RFullDate)
        str = str.Replace("{to_year}", to_RYearDate)
        str = str.Replace("{to_month}", to_RMonthDate)
        str = str.Replace("{to_day}", to_RDayDate)
        Return str
    End Function

    Public Sub filter()
        Dim strquery As String = ""
        Try
            dst.Clear()
            com.CommandText = "select * from tblreporttemplate where rptid='" & id.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                strquery = DecryptTripleDES(rst("rptquery").ToString)
                If rst("datequery") = True Then
                    strquery = rDateSelect(strquery, date_from.Text, date_to.Text)
                End If
            End While
            rst.Close()

            LoadXgrid(strquery, 0, Em, gridview1, Me)

            com.CommandText = "select * from tblreportconfig where rptid='" & id.Text & "' order by sortorder asc"
            rst = com.ExecuteReader
            While rst.Read

                If rst("colgroup") = True Then
                    gridview1.Columns(rst("colname").ToString).Group()
                    gridview1.ExpandAllGroups()
                End If

                If Val(rst("coltype").ToString) = 0 Then
                    gridview1.Columns(rst("colname").ToString).ColumnEdit = MemoEdit

                    If rst("alignment").ToString = "L" Then
                        XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Default)
                    ElseIf rst("alignment").ToString = "C" Then
                        XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Center)
                    ElseIf rst("alignment").ToString = "R" Then
                        XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Far)
                    End If

                ElseIf Val(rst("coltype").ToString) = 1 Then
                    gridview1.Columns(rst("colname").ToString).Width = 120
                    XgridColCurrency({rst("colname").ToString}, gridview1)
                    XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Far)

                ElseIf Val(rst("coltype").ToString) = 2 Then
                    gridview1.Columns(rst("colname").ToString).Width = 120
                    XgridColNumber(rst("colname").ToString, gridview1)

                    If rst("alignment").ToString = "C" Then
                        XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Center)
                    Else
                        XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Far)
                    End If

                End If

                If rst("colgrpsum") = True Then
                    Dim splitother As String() = rst("colgrpsumtext").ToString.Split(New Char() {","c})
                    For Each idword In splitother
                        Dim item1 As New GridGroupSummaryItem()
                        item1.FieldName = idword
                        If rst("colgrpsumtype").ToString = "SUM" Then
                            item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            item1.DisplayFormat = "{0:n}"
                        Else
                            item1.SummaryType = DevExpress.Data.SummaryItemType.Count
                            item1.DisplayFormat = "{0:N0}"
                        End If
                        item1.ShowInGroupColumnFooter = gridview1.Columns(idword)
                        gridview1.GroupSummary.Add(item1)
                    Next
                End If

                If rst("colgensum") = True Then
                    If rst("colgensumtype").ToString = "SUM" Then
                        gridview1.Columns(rst("colname").ToString).SummaryItem.SummaryType = SummaryItemType.Sum
                        gridview1.Columns(rst("colname").ToString).SummaryItem.DisplayFormat = rst("colgensumtext").ToString & " {0:n}"
                    Else
                        gridview1.Columns(rst("colname").ToString).SummaryItem.SummaryType = SummaryItemType.Count
                        gridview1.Columns(rst("colname").ToString).SummaryItem.DisplayFormat = rst("colgensumtext").ToString & " {0:N0}"
                    End If
                    gridview1.Columns(rst("colname").ToString).SummaryItem.Tag = 1
                    CType(gridview1.Columns(rst("colname").ToString).View, GridView).OptionsView.ShowFooter = True
                End If
            End While
            rst.Close()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Query:" & strquery & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
        Catch errMS As Exception
            XtraMessageBox.Show("Query:" & strquery & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
        End Try
    End Sub
    
    Private Sub frmGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        date_from.EditValue = Format(Now, "MMMM 1, yyyy")
        date_to.EditValue = Format(Now, "MMMM dd, yyyy")
        LoadGridviewAppearance(gridview1)
        LoadTemplateType()

    End Sub

    Public Sub LoadTemplateType()
        LoadXgridLookupSearch("SELECT code, Description from tblreporttemplatetype", "tblreporttemplatetype", txtReportType, gvReportType, Me)
        gvReportType.Columns("code").Visible = False
    End Sub
    Private Sub txtReportType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReportType.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtReportType.Properties.View.FocusedRowHandle.ToString)
        reportype.Text = txtReportType.Properties.View.GetFocusedRowCellValue("code").ToString()
        LoadTemplate()
    End Sub
   
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If txtReportTemplate.Text = "" Then
            XtraMessageBox.Show("Please Select Report Template!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReportTemplate.Focus()
            Exit Sub
        End If
        filter()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = txtReportTemplate.Text & If(txtReportTemplate.Properties.View.GetFocusedRowCellValue("datequery") = True, " " & date_from.Text & " - " & date_to.Text, "") & ".xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            gridview1.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class