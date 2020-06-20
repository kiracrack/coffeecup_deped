Module Clinic
    Public Function CreateClinicsclientID()
        Dim strng = ""
        If CInt(countrecord("tblclinicsclients")) = 0 Then
            strng = "C100000001"
        Else
            com.CommandText = "select guestid from tblclinicsclients order by right(clientid,9) desc limit 1" : rst = com.ExecuteReader()
            Dim removechar As Char() = "C".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            While rst.Read
                Dim str As String = rst("clientid").ToString
                For Each ch As Char In str
                    If Array.IndexOf(removechar, ch) = -1 Then
                        sb.Append(ch)
                    End If
                Next
            End While
            rst.Close()
            strng = "C" & Val(sb.ToString) + 1
        End If
        Return strng.ToString
    End Function

End Module
