Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports System.IO

Public Class frmBlotterVerification
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        loadCashTo()
        LoadGridviewAppearance(gridCashTo)
        LoadSystemCashEnd()
        LoadBlottersTransaction()
    End Sub

    Public Sub LoadSystemCashEnd()
        com.CommandText = "call sp_salesremittance('CONSOLIDATED','" & trncode.Text & "','')" : com.ExecuteNonQuery()
        com.CommandText = "select * from tmpconsolidateddetails where trntype='cash'" : rst = com.ExecuteReader
        While rst.Read
            txtCashEnd.Text = FormatNumber(rst("amount").ToString, 2)
        End While
        rst.Close()
    End Sub

    Public Sub LoadBlottersTransaction()
        com.CommandText = "select *, (select fullname from tblaccounts where accountid=tblsalessummary.userid) as 'Cashier' from tblsalessummary where trncode='" & trncode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtCashier.Text = rst("Cashier").ToString
            cashfrom.Text = rst("cashfrom").ToString
            officeid.Text = rst("officeid").ToString
            txtdateTransaction.Text = rst("dateclose").ToString
            txtCashOnHand.Text = FormatNumber(rst("cashonhand").ToString, 2)


            txtAmountDeposit.Text = FormatNumber(Val(rst("cashremitted").ToString), 2)
            txtRemarks.Text = ConvertDate(rst("dateopen").ToString) & " - " & rst("Cashier").ToString
        End While
        rst.Close()
        ComputeVariance()
    End Sub

    Public Sub ComputeVariance()
        Dim Variance As Double = 0
        Variance = Val(CC(txtCashOnHand.Text)) - Val(CC(txtCashEnd.Text))
        If Variance > 0 Then
            txtOverages.Text = FormatNumber(Variance, 2)
        ElseIf Variance < 0 Then
            txtShortages.Text = FormatNumber(-Variance, 2)
        Else
            txtShortages.Text = "0.00"
            txtOverages.Text = "0.00"
        End If
    End Sub

    Public Sub loadCashTo()
        LoadXgridLookupEdit("select bankcode, accountname as 'Account Name' from tblbankaccounts where (bankaccounts=1 or cashaccount=1)", "tblbankaccounts", txtCashTo, gridCashTo, Me)

        gridCashTo.Columns("bankcode").Visible = False
        gridCashTo.SelectRow(1)
    End Sub

    Private Sub txtCashTo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashTo.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCashTo.Properties.View.FocusedRowHandle.ToString)
        cashTo.Text = txtCashTo.Properties.View.GetFocusedRowCellValue("bankcode").ToString()
        txtCashTo.Text = txtCashTo.Properties.View.GetFocusedRowCellValue("Account Name").ToString()
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtCashTo.Text = "" And ckDeposit.Checked = True Then
            XtraMessageBox.Show("Please select Cash to!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCashTo.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim gltoken As String = CreateGLTicketToken(trncode.Text, globaluserid)
            If ckDeposit.Checked = True Then
                If GlobalGLOverages = "" Or GlobalGLShortages = "" Then
                    XtraMessageBox.Show("Default shortages and overages settings not configured! Please contact your system administrator", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                com.CommandText = "update tblsalessummary set gltoken='" & gltoken & "', verified=1,dateverified=current_timestamp, " _
                               + " verifiedby='" & globaluserid & "', " _
                               + " cashend='" & Val(CC(txtCashEnd.Text)) & "', " _
                               + " cashonhand='" & Val(CC(txtCashOnHand.Text)) & "', " _
                               + " amountdeposited='" & Val(CC(txtAmountDeposit.Text)) & "', " _
                               + " overages='" & Val(CC(txtOverages.Text)) & "', " _
                               + " shortages='" & Val(CC(txtShortages.Text)) & "', " _
                               + " bankdeposited='" & cashTo.Text & "' " _
                               + " where trncode='" & trncode.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblsalesdeposittransaction set itemcode='" & GlobalGLSalesCode & "',referenceno='" & trncode.Text & "', totalcash='" & Val(CC(txtAmountDeposit.Text)) & "', amountdeposited='" & Val(CC(txtAmountDeposit.Text)) & "',bankdeposited='" & cashTo.Text & "',remarks='" & rchar(txtRemarks.Text) & "',trnby='" & globaluserid & "',datetrn=current_timestamp" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblsalessummary set gltoken='" & gltoken & "', verified=1,dateverified=current_timestamp, " _
                             + " verifiedby='" & globaluserid & "', " _
                               + " cashend='" & Val(CC(txtCashEnd.Text)) & "', " _
                               + " cashonhand='" & Val(CC(txtCashOnHand.Text)) & "', " _
                               + " amountdeposited='0', " _
                               + " overages='" & Val(CC(txtOverages.Text)) & "', " _
                               + " shortages='" & Val(CC(txtShortages.Text)) & "', " _
                               + " bankdeposited='0' " _
                             + " where trncode='" & trncode.Text & "'" : com.ExecuteNonQuery()
            End If
            If Val(CC(txtOverages.Text)) > 0 Then
                glticket(gltoken, officeid.Text, GetGLTransactionCode(GlobalGLOverages, True), Val(CC(txtOverages.Text)), 0, "cashier overages " & LCase(txtCashier.Text) & " - " & ConvertDate(txtdateTransaction.Text), txtdateTransaction.Text, txtCashier.Text)
                glticket(gltoken, officeid.Text, GetGLTransactionCode(GlobalGLOverages, False), 0, Val(CC(txtOverages.Text)), "cashier overages " & LCase(txtCashier.Text) & " - " & ConvertDate(txtdateTransaction.Text), txtdateTransaction.Text, txtCashier.Text)
            End If
            If Val(CC(txtShortages.Text)) > 0 Then
                glticket(gltoken, officeid.Text, GetGLTransactionCode(GlobalGLShortages, True), Val(CC(txtShortages.Text)), 0, "cashier shortages " & LCase(txtCashier.Text) & " - " & ConvertDate(txtdateTransaction.Text), txtdateTransaction.Text, txtCashier.Text)
                glticket(gltoken, officeid.Text, GetGLTransactionCode(GlobalGLShortages, False), 0, Val(CC(txtShortages.Text)), "cashier shortages " & LCase(txtCashier.Text) & " - " & ConvertDate(txtdateTransaction.Text), txtdateTransaction.Text, txtCashier.Text)
            End If
            frmCashiersBlotter.LoadCurrentBlotter()
            XtraMessageBox.Show("Cashier's blotter successfuly verified!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles ckDeposit.CheckedChanged
        If ckDeposit.Checked = True Then
            PanelControl1.Enabled = True
        Else
            PanelControl1.Enabled = False
        End If
    End Sub

   
End Class