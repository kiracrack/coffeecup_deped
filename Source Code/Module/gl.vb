Module gl
    Public Function GetGLTransactionCode(ByVal trncode As String, ByVal debit As Boolean) As String
        GetGLTransactionCode = ""
        com.CommandText = "select * from tbltransactioncode where itemcode='" & trncode & "'" : rst = com.ExecuteReader
        While rst.Read
            If debit = True Then
                GetGLTransactionCode = rst("gldebit").ToString
            Else
                GetGLTransactionCode = rst("glcredit").ToString
            End If
        End While
        rst.Close()
        Return GetGLTransactionCode
    End Function
    Public Function CreateGLTicketToken(ByVal referenceno As String, trnby As String) As String
        CreateGLTicketToken = ""
        com.CommandText = "select md5(concat('" & referenceno & "',current_timestamp,'" & trnby & "')) as token" : rst = com.ExecuteReader
        While rst.Read
            CreateGLTicketToken = rst("token").ToString
        End While
        rst.Close()
        Return CreateGLTicketToken
    End Function
    Public Function glticket(ByVal reference As String, ByVal officeid As String, ByVal itemcode As String, ByVal debit As Double, ByVal credit As Double, ByVal remarks As String, ByVal datetrn As String, ByVal trnby As String)
        Dim getGroup As String = qrysingledata("groupcode", "groupcode", "tblglitem where itemcode='" & itemcode & "'")
        Dim getItemname As String = qrysingledata("itemname", "itemname", "tblglitem where itemcode='" & itemcode & "'")
        com.CommandText = "insert into tblglticket set gltoken='" & reference & "', officeid='" & officeid & "', groupcode='" & getGroup & "', itemcode='" & itemcode & "', itemname='" & rchar(getItemname) & "',debit=" & debit & ",credit=" & credit & ", remarks='" & rchar(remarks) & "',datetrn='" & ConvertDateTime(datetrn) & "', trnby='" & trnby & "', cleared=1, datecleared=current_timestamp,clearedby='" & globalfullname & "'" : com.ExecuteNonQuery()
        Return True
    End Function
End Module
