Imports MySql.Data.MySqlClient

Module EmailNotifyForNextApprover
    'send email notification for next approver branch level requisition
    Public Function NextEmailBranchLevelRequisitionApprover(ByVal pid As String, ByVal requesttype As String, ByVal CommandQuery As String)
        Dim approver As String = ""
        dst = New DataSet
        If countqry("tblrequisitions inner join tblcompoffice on tblrequisitions.officeid=tblcompoffice.officeid", "pid='" & pid & "' and custombranchapproval=1") > 0 Then
            msda = New MySqlDataAdapter("select a.authcode,b.officeid,(select authdescription from tbluserauthority where authcode=a.authcode) as authorized, (select approveanyoffices from tbluserauthority where authcode=a.authcode) as approvedanyoffice from tblapproverclientprocess as a inner join tblrequisitions as b on a.requestcode = b.potypeid and apptype='requisition-approving-process' and a.officeid = b.officeid where left(a.applevel,1) = ifnull((select cast(count(*)+1 as UNSIGNED) from tblapprovalhistory where referenceno=b.pid and `status`='approved'  and applevel<>'-' order by dateconfirm desc limit 1),1) and b.hold=0 and b.approvedbranch=0 and b.cancelled=0 and b.disapproved=0 and b.pid='" & pid & "';", conn)
        Else
            msda = New MySqlDataAdapter("select a.authcode,b.officeid,(select authdescription from tbluserauthority where authcode=a.authcode) as authorized, (select approveanyoffices from tbluserauthority where authcode=a.authcode) as approvedanyoffice from tblapproverclientprocess as a inner join tblrequisitions as b on a.requestcode = b.potypeid and apptype='requisition-approving-process' and a.customized=0 and left(a.applevel,1) = ifnull((select cast(count(*)+1 as UNSIGNED) from tblapprovalhistory where referenceno=b.pid and `status`='approved'  and applevel<>'-' order by dateconfirm desc limit 1),1) and b.hold=0 and b.approvedbranch=0 and b.cancelled=0 and b.disapproved=0 and b.pid='" & pid & "';", conn)
        End If
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                com.CommandText = "select * from tblaccounts where coffeecupposition='" & .Rows(cnt)("authcode").ToString() & "' " & If(CBool(.Rows(cnt)("approvedanyoffice").ToString()) = True, "", " and officeid='" & .Rows(cnt)("officeid").ToString() & "'") & " and emailaddress<>''" : rst = com.ExecuteReader
                While rst.Read
                    approver += rst("emailaddress").ToString & ","
                End While
                rst.Close()
            End With
        Next
        If approver.Length > 0 Then
            approver = approver.Remove(approver.Length - 1, 1)
            InsertEmailNotification("requisition", approver, "FOR APPROVAL " & UCase(requesttype) & " (" & pid & ") ", FormatingEmailRequisition(pid, UCase(requesttype)), CommandQuery)
        End If
        Return approver
    End Function

    'send email notification for next approver corporate level requisition
    Public Function NextEmailCorporateLevelRequisitionApprover(ByVal pid As String, ByVal requesttype As String, ByVal CommandQuery As String) As String
        Dim approver As String = ""
        dst = New DataSet
        If countqry("tblrequisitions inner join tblcompoffice on tblrequisitions.officeid=tblcompoffice.officeid", "pid='" & pid & "' and customcorporateapproval=1") > 0 Then
            msda = New MySqlDataAdapter("select a.authorizedid from tblapprovermainprocess as a inner join tblrequisitions as b on a.requestcode = b.potypeid and apptype='requisition-approving-process' and a.customized=1 and a.officeid = b.officeid where left(a.applevel,1) = ifnull((select cast(count(*)+1 as UNSIGNED) from tblapprovalhistory where referenceno=b.pid and `status`='approved'  and applevel<>'-' and corporateapproval=1 order by dateconfirm desc limit 1),1) and b.corporatelevel=1 and b.approvedbranch=1 and b.approvedcorporate=0 and b.received=1 and b.cancelled=0 and b.disapproved=0 and b.hold=0 and b.pid='" & pid & "';", conn)
        Else
            msda = New MySqlDataAdapter("select a.authorizedid from tblapprovermainprocess as a inner join tblrequisitions as b on a.requestcode = b.potypeid and apptype='requisition-approving-process' and a.customized=0 and left(a.applevel,1) = ifnull((select cast(count(*)+1 as UNSIGNED) from tblapprovalhistory where referenceno=b.pid and `status`='approved'  and applevel<>'-' and corporateapproval=1 order by dateconfirm desc limit 1),1) and b.corporatelevel=1 and b.approvedbranch=1 and b.approvedcorporate=0 and b.received=1 and b.cancelled=0 and b.disapproved=0 and b.hold=0 and b.pid='" & pid & "';", conn)
        End If
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                com.CommandText = "select * from tblaccounts where accountid='" & .Rows(cnt)("authorizedid").ToString() & "' and emailaddress<>''" : rst = com.ExecuteReader
                While rst.Read
                    approver += rst("emailaddress").ToString & ","
                End While
                rst.Close()
            End With
        Next
        If approver.Length > 0 Then
            approver = approver.Remove(approver.Length - 1, 1)
            InsertEmailNotification("requisition", approver, "FOR APPROVAL " & UCase(requesttype) & " (" & pid & ") ", FormatingEmailRequisition(pid, UCase(requesttype)), CommandQuery)
        End If
        Return approver
    End Function

    Public Function NextEmailPurchaseOrderApprover(ByVal ponumber As String, ByVal corporatelevel As Boolean, ByVal message As String) As String
        Dim approver As String = ""
        dst = New DataSet
        'msda = New MySqlDataAdapter("select " & If(corporatelevel = True, "c.authorizedid", "c.authcode, a.officeid ") & " from tblpurchaseorder as a inner join tblrequisitions as b on a.requestref = b.pid inner join " & If(corporatelevel = True, "tblapprovermainprocess", "tblapproverclientprocess") & " as c on b.potypeid = c.requestcode " _
        '           + " where a.verified=0 and a.forpo=1 and a.corporatelevel=" & corporatelevel & " and a.cancelled=0 and a.ponumber ='" & ponumber & "' and " _
        '           + " (select concat(count(*)+1) from tblapprovalhistory where referenceno=a.ponumber and status='approved'  and applevel<>'-' and approvaltype='purchase-order') = left(applevel,1) and apptype='purchase-order-signatories' ", conn)
        msda = New MySqlDataAdapter("select " & If(corporatelevel = True, "authorizedid", "authcode") & " from " & If(corporatelevel = True, "tblapprovermainprocess", "tblapproverclientprocess") & " where apptype='purchase-order-signatories' and left(applevel,1) = " _
                              + " (select concat(count(*)+1) from tblapprovalhistory as a inner join tblpurchaseorder as b on b.ponumber=a.referenceno and a.status='approved' and a.applevel<>'-' and a.approvaltype='purchase-order'  where b.cancelled=0 and b.corporatelevel=" & If(corporatelevel = True, "1", "0") & " and b.verified=0 and b.ponumber='" & ponumber & "')", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                com.CommandText = "select * from tblaccounts where " & If(corporatelevel = True, "accountid='" & .Rows(cnt)("authorizedid").ToString() & "'", "coffeecupposition='" & .Rows(cnt)("authcode").ToString() & "' and officeid='" & .Rows(cnt)("officeid").ToString() & "'") & " and emailaddress<>''" : rst = com.ExecuteReader
                While rst.Read
                    approver += rst("emailaddress").ToString & ","
                End While
                rst.Close()
            End With
        Next
        If approver.Length > 0 Then
            approver = approver.Remove(approver.Length - 1, 1)
            InsertEmailNotification("puchase-order", approver, "PURCHASE ORDER FOR APPROVAL (" & ponumber & ") ", FormatingEmailPurchaseOrder(ponumber), message)
        End If
        Return approver
    End Function

    'send email notification for next approver branch level requisition
    Public Function NextEmailAccountPayableApprover(ByVal voucherno As String, ByVal officeid As String, ByVal disbursementtype As String, ByVal corporatelevel As Boolean, ByVal CommandQuery As String) As String
        Dim approver As String = ""
        dst = New DataSet
        msda = New MySqlDataAdapter("select " & If(corporatelevel = True, "authorizedid", "authcode") & " from " & If(corporatelevel = True, "tblapprovermainprocess", "tblapproverclientprocess") & " where apptype='voucher-signatories' and left(applevel,1) = " _
                                + " (select concat(count(*)+1) from tblapprovalhistory as a inner join tbldisbursementvoucher as b on b.voucherno=a.referenceno and (a.status='approved' or a.status='disbursed')  and a.applevel<>'-' and a.approvaltype='voucher'  where b.cancelled=0 and b.corporatelevel=" & If(corporatelevel = True, "1", "0") & " and b.verified=0 and b.voucherno='" & voucherno & "')", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                com.CommandText = "select * from tblaccounts where " & If(corporatelevel = True, "accountid='" & .Rows(cnt)("authorizedid").ToString() & "'", "coffeecupposition='" & .Rows(cnt)("authcode").ToString() & "' and officeid='" & officeid & "'") & " and emailaddress<>''" : rst = com.ExecuteReader
                While rst.Read
                    approver += rst("emailaddress").ToString & ","
                End While
                rst.Close()
            End With
        Next
        If approver.Length > 0 Then
            approver = approver.Remove(approver.Length - 1, 1)
            InsertEmailNotification("voucher", approver, UCase(disbursementtype) & " FOR APPROVAL (" & voucherno & ")", FormatingEmailAccountsPayable(voucherno), CommandQuery)
        End If
        Return True
    End Function

    
End Module
