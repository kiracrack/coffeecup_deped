Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient

Public Class frmResetDatabase

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmResetDatabase_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        CheckedListBox1.Items.Clear()
        msda = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("show tables in " & sqldatabase, conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblactivationlog" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblbarangay" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tbldatabaseupdatelogs" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblgeneralsettings" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblmunicipal" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblprovince" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblregion" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblreporthtmltemplate" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblshortcodetagging" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblformstemplateinfo" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblformstemplatesettings" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblformstemplatetype" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblformstemplatetype" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblformtable" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblglgroup" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblglitem" And _
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tbluseraccounts" Then
                    CheckedListBox1.Items.Add(sqldatabase & "." & .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString())
                End If
            End With
        Next
        CheckedListBox1.Items.Add("filedir.tblactionquerylogs")
        CheckedListBox1.Items.Add("filedir.tblactionuploadedlogs")
        CheckedListBox1.Items.Add("filedir.tblbrgyissue")
        CheckedListBox1.Items.Add("filedir.tblresidentsimage")
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For I = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemCheckState(I, CheckState.Checked)
            Next
        Else
            For I = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemCheckState(I, CheckState.Unchecked)
            Next
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If XtraMessageBox.Show("WARNING: You are about to delete all containing data on checked items above! " & Environment.NewLine & Environment.NewLine & "NOTE: If you continue this action, there will be no undo function to retrive all deleted data." & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue?  " & todelete, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For I = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemChecked(I) = True Then
                    com.CommandText = "delete from " & CheckedListBox1.Items(I).ToString : com.ExecuteNonQuery()
                End If
            Next
            com.CommandText = "UPDATE tblgeneralsettings set transactiontoken='', licensetoken='', dateexpired=null, membersequence='000', barangayclearancesequence='000', barangaycontrolno='000', businessidsequence='000', businessclearancesequence='000', businesscontrolno='000', blottersequence='000', cedulasequenceno='000', indigencysequence='000', templatesequence='000', transactionsecquence='000',idcardsequence='000', othersequence='000',budgettrncode='00'" : com.ExecuteNonQuery()
            XtraMessageBox.Show("Database successfully resetted!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class