Module Payroll
    '####################### PAYROLL VARIABLES #####################
    Public GlobalTaxCode As String = ""
    Public GlobalSSSCode As String = ""
    Public GlobalPagibigCode As String = ""
    Public GlobalPhilhealthCode As String = ""
    Public GlobalSavingsCode As String = ""
    Public GlobalTaxPercent As Double = 0
    Public GlobalTotalWorkingDays As Double = 0
    Public GlobalTotalWorkingHours As Double = 0
    Public GLobalEmployeeSequence As Boolean
    Public GlobalBimetricModel As String = ""
    Public GlobalBimetricTemplate As String = ""

    Public Sub loadGeneralPayrollSettings()
        com.CommandText = "select *,(select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaulttax) as 'tax', " _
                        + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultsss) as 'sss', " _
                        + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultpagibig) as 'pagibig', " _
                        + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultphilhealth) as 'philhealth', " _
                        + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultsavings) as 'savings' " _
                        + " from tblpayrollsettings" : rst = com.ExecuteReader
        While rst.Read
            GlobalTaxCode = rst("defaulttax").ToString
            GlobalSSSCode = rst("defaultsss").ToString
            GlobalPagibigCode = rst("defaultpagibig").ToString
            GlobalPhilhealthCode = rst("defaultphilhealth").ToString
            GlobalSavingsCode = rst("defaultsavings").ToString
            GlobalTaxPercent = rst("taxpercent").ToString
            GlobalTotalWorkingDays = rst("totalworkingdays").ToString
            GlobalTotalWorkingHours = rst("totalworkinghours").ToString
            If rst("employeeidsequence").ToString = "" Then
                GLobalEmployeeSequence = False
            Else
                GLobalEmployeeSequence = True
            End If
            GlobalBimetricModel = rst("biometricmodel").ToString
            GlobalBimetricTemplate = rst("biometrictemplate").ToString
        End While
        rst.Close()
    End Sub

    Public Function getEmployeeIDSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select employeeidsequence from tblpayrollsettings where companycode='" & GlobalOrganizationCode & "'" : rst = com.ExecuteReader()
            While rst.Read
                NumberLen = rst("employeeidsequence").ToString.Length
                strng = Val(rst("employeeidsequence").ToString) + 1
            End While
            rst.Close()
            If NumberLen > strng.ToString.Length Then
                Dim a As Integer = NumberLen - strng.ToString.Length
                If a = 10 Then
                    newNumber = "0000000000" & strng
                ElseIf a = 9 Then
                    newNumber = "000000000" & strng
                ElseIf a = 8 Then
                    newNumber = "00000000" & strng
                ElseIf a = 7 Then
                    newNumber = "0000000" & strng
                ElseIf a = 6 Then
                    newNumber = "000000" & strng
                ElseIf a = 5 Then
                    newNumber = "00000" & strng
                ElseIf a = 4 Then
                    newNumber = "0000" & strng
                ElseIf a = 3 Then
                    newNumber = "000" & strng
                ElseIf a = 2 Then
                    newNumber = "00" & strng
                ElseIf a = 1 Then
                    newNumber = "0" & strng
                Else
                    newNumber = strng
                End If
            Else
                newNumber = strng
            End If
        Return newNumber
    End Function

    Public Sub ExitPayrollVariables()
        GlobalTaxCode = ""
        GlobalSSSCode = ""
        GlobalPagibigCode = ""
        GlobalPhilhealthCode = ""
        GlobalTaxPercent = 0
        GlobalTotalWorkingDays = 0
        GlobalTotalWorkingHours = 0
        GLobalEmployeeSequence = False
    End Sub
End Module
