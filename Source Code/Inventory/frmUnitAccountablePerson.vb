Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO
Imports DevExpress.Skins

Public Class frmUnitAccountablePerson
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Public Sub LoadAccountable()
        LoadXgridLookupSearch("SELECT accountid, fullname as 'Fullname' from tblaccounts where username <> 'ROOT' order by FULLNAME desc", "tblaccounts", txtAccountablePerson, gv_accountable, Me)
        gv_accountable.Columns("accountid").Visible = False
    End Sub

    Private Sub txtcheckedby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccountablePerson.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtAccountablePerson.Properties.View.FocusedRowHandle.ToString)
        accountableid.Text = txtAccountablePerson.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtAccountablePerson.Text = txtAccountablePerson.Properties.View.GetFocusedRowCellValue("Fullname").ToString()
    End Sub
    Private Sub frmInventoryManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gv_accountable)
        LoadAccountable()
        txtAssignedDate.Text = Format(Now)

    End Sub

    Private Sub cmdUpdateAccountable_Click(sender As Object, e As EventArgs) Handles cmdUpdateAccountable.Click
        If issueid.Text = "" And ckPredefine.Checked = True Then
            XtraMessageBox.Show("Please enter issue number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            issueid.Focus()
            Exit Sub
        ElseIf officeinitialcode.Text = "" And ckPredefine.Checked = False Then
            XtraMessageBox.Show("Please update " & GlobalOfficeCaption & " initialcode info to continue this process!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            officeinitialcode.Focus()
            Exit Sub
        ElseIf txtAccountablePerson.Text = "" Then
            XtraMessageBox.Show("Please select Accountable Person!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAccountablePerson.Focus()
            Exit Sub
        ElseIf txtAssignedDate.Text = "" Then
            XtraMessageBox.Show("Please select date issue!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAssignedDate.Focus()
            Exit Sub
        ElseIf countqry("tblaccountablehistory", "concat('" & compinitialcode & officeinitialcode.Text & "-',date_format(acctabledate,'%Y'),'-',id)") <> 0 And ckPredefine.Checked = True Then
            XtraMessageBox.Show("Duplicate issue number! Please use unique one.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            issueid.Focus()
            Exit Sub
        End If
        Dim newissuecode As String = ""
        If ckPredefine.Checked = True Then
            newissuecode = "'" & rchar(issueid.Text) & "'"
        Else
            newissuecode = " concat('" & compinitialcode & officeinitialcode.Text & "-',date_format('" & ConvertDate(txtAssignedDate.Text) & "','%Y'),'-',(select (MAX(id)+1) from tblaccountablehistory as b)) "
        End If
        If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblaccountablehistory set issuecode=" & newissuecode & ",ffecode='" & ffecode.Text & "', " _
                                       + " acctableperson='" & accountableid.Text & "', " _
                                       + " acctabledate='" & ConvertDate(txtAssignedDate.Text) & "', " _
                                       + " note='" & rchar(txtnote.Text) & "', " _
                                       + " iscurrent=1, " _
                                       + " issueby='" & globaluserid & "'" : com.ExecuteNonQuery()

            frmFFEAccountabilityLog.FilterAccountable()
            If frmInventoryFFESummary.Visible = True Then
                frmInventoryFFESummary.filterInventory()
            End If
            XtraMessageBox.Show("Accountable Successfully Saved", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub ckUpdateInformation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckPredefine.CheckedChanged
        If ckPredefine.Checked = True Then
            issueid.Properties.ReadOnly = False
            issueid.Text = ""
        Else
            issueid.Properties.ReadOnly = True
            issueid.Text = "AUTO GENERATE"
        End If

    End Sub

    Private Sub ffecode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ffecode.EditValueChanged
        If ffecode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblcompoffice inner join tblinventoryffe on tblinventoryffe.officeid = tblcompoffice.officeid where tblinventoryffe.ffecode= '" & ffecode.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            officeinitialcode.Text = rst("initialcode").ToString
        End While
        rst.Close()
    End Sub
End Class