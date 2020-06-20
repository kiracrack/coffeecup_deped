Module Hotel
    Public Function getRoomid()
        Dim compid = ""

        If CInt(countrecord("tblhotelrooms")) = 0 Then
            compid = "R1001"
        Else
            com.CommandText = "select roomid from tblhotelrooms order by right(roomid,4) desc limit 1" : rst = com.ExecuteReader()
            Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ- ".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            While rst.Read
                Dim str As String = rst("roomid").ToString
                For Each ch As Char In str
                    If Array.IndexOf(removechar, ch) = -1 Then
                        sb.Append(ch)
                    End If
                Next
            End While
            rst.Close()
            compid = "R" & Val(sb.ToString) + 1
        End If
        Return compid.ToString
    End Function

    Public Function CreateGuestID()
        Dim strng = ""
        If CInt(countrecord("tblhotelguest")) = 0 Then
            strng = "G100000001"
        Else
            com.CommandText = "select guestid from tblhotelguest order by right(guestid,9) desc limit 1" : rst = com.ExecuteReader()
            Dim removechar As Char() = "G".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            While rst.Read
                Dim str As String = rst("guestid").ToString
                For Each ch As Char In str
                    If Array.IndexOf(removechar, ch) = -1 Then
                        sb.Append(ch)
                    End If
                Next
            End While
            rst.Close()
            strng = "G" & Val(sb.ToString) + 1
        End If
        Return strng.ToString
    End Function

End Module
