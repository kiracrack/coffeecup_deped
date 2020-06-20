Imports System.IO

Module SystemInfo
    Public GlobalSystemName As String
    Public GlobalCopyrightName As String
    Public GlobalDatabaseVersion As String
    Public GlobalSystemVersion As String

    Public Sub SystemInfoChecker()
        Dim dversion As Date
        GlobalSystemName = "Coffeecup System " & Format(Now.Year)
        com.CommandText = "select * from tblclientsystemupdate where server=1 and active=1" : rst = com.ExecuteReader
        While rst.Read
            GlobalSystemVersion = rst("version").ToString
        End While
        rst.Close()

        com.CommandText = "select * from tbldatabaseupdatelogs order by dateupdate desc limit 1" : rst = com.ExecuteReader
        While rst.Read
            dversion = rst("databaseversion").ToString
            GlobalDatabaseVersion = "Database v" & Format(dversion.ToString("yy.M.d"))
        End While
        rst.Close()
    End Sub

    'If countqry("information_schema.COLUMNS", "TABLE_SCHEMA='" & sqldatabase & "' and  TABLE_NAME = 'tblreporttemplate' AND COLUMN_NAME = 'requestby' ") = 0 Then
    '    com.CommandText = "ALTER TABLE `tblreporttemplate` ADD COLUMN `requestby` TEXT NOT NULL AFTER `datequery`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery()
    'End If
End Module
