Imports System.IO
Imports System.IO.Packaging
Imports ICSharpCode.SharpZipLib.Zip
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Module FileManagementModule
    Private Const BUFFER_SIZE As Long = 4096
    Public GlobalStrAttachment As String = " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from filedir.tblattachmentlogs where refnumber = tblrequisitions.pid),'-') as 'Attachment', "

    Public Function ViewAttachmentPackage_Database(ByVal refno As Array, ByVal trntype As String)
        Dim extract_location As String = System.IO.Path.GetTempPath() & "Dockeeper\" & globaluser & "\"
        Dim myData As MySqlDataReader
        Dim rawData() As Byte
        Dim FileSize As UInt32
        Dim fs As FileStream
        Try
            Dim totalFiles As Integer = 0
            For Each refnumber As String In refno
                totalFiles += countqry("filedir.tblattachmentlogs", "refnumber='" & refnumber & "'")
            Next
            If totalFiles = 0 Then
                XtraMessageBox.Show("There's no file to extract!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            If (System.IO.Directory.Exists(extract_location)) Then
                My.Computer.FileSystem.DeleteDirectory(extract_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If (Not System.IO.Directory.Exists(extract_location)) Then
                System.IO.Directory.CreateDirectory(extract_location)
            End If

            Dim strtrntype As String = ""
            If trntype.Length > 0 Then
                strtrntype = " and trntype='" & trntype & "'"
            End If

            For Each refnumber As String In refno
                Dim filetoView As String = ""
                com.CommandText = "select * from filedir.tblattachmentlogs where refnumber='" & refnumber & "'" & strtrntype : rst = com.ExecuteReader
                While rst.Read
                    filetoView = filetoView + rst("databasename").ToString & ","
                End While
                rst.Close()

                For Each word In filetoView.Split(New Char() {","c})
                    If word <> "" Then
                        com.CommandText = "SELECT * FROM filedir.`" & word & "` where refnumber = '" & refnumber & "'" & strtrntype
                        myData = com.ExecuteReader
                        While myData.Read
                            FileSize = myData.GetUInt32(myData.GetOrdinal("filesize"))
                            rawData = New Byte(FileSize) {}

                            myData.GetBytes(myData.GetOrdinal("attachment"), 0, rawData, 0, FileSize)

                            fs = New FileStream(extract_location & myData("filename").ToString, FileMode.OpenOrCreate, FileAccess.Write)
                            fs.Write(rawData, 0, FileSize)
                            fs.Close()
                        End While
                        myData.Close()
                    End If
                Next
            Next
            Process.Start("explorer.exe", extract_location)

        Catch ex As Exception
            myData.Close()
            MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function
    Public Function ViewAttachmentPackage_ZipDirectory(ByVal refno As String)
        Dim extract_location As String = System.IO.Path.GetTempPath() & "Dockeeper\" & globaluser & "\"
        Try
            If (System.IO.Directory.Exists(extract_location)) Then
                My.Computer.FileSystem.DeleteDirectory(extract_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If

            com.CommandText = "select * from `filedir`.`tblattachmentlogs` where refnumber='" & refno & "'" : rst = com.ExecuteReader()
            While rst.Read
                Dim fileStreamIn As FileStream = New FileStream(ZIPFILE_LOCATION & rst("databasename").ToString.Replace("tbl", "") & ".zip", FileMode.Open, FileAccess.Read)
                Dim fileStreamOut As FileStream
                Dim zf As ZipFile = New ZipFile(fileStreamIn)
                Dim Size As Integer
                Dim buffer(409600) As Byte
                Dim Zentry As ZipEntry = zf.GetEntry(rst("archievedname").ToString)
                If (Zentry Is Nothing) Then
                    MessageBox.Show(rst("filename").ToString & " not found in Archived", _
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    rst.Close()
                    Return False
                    Exit Function
                End If

                Dim fstr As ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream
                fstr = zf.GetInputStream(Zentry)

                'Dim strFullPath As String = Path.GetDirectoryName(Zentry.Name)
                'Directory.CreateDirectory(strFullPath)
                'fileStreamOut = New FileStream(strFullPath & "\" & Path.GetFileName(Zentry.Name), FileMode.Create, FileAccess.Write)
                If Not System.IO.Directory.Exists(extract_location) = True Then
                    System.IO.Directory.CreateDirectory(extract_location)
                End If
                fileStreamOut = New FileStream(extract_location + Path.GetFileName(rst("filename").ToString), FileMode.Create, FileAccess.Write)

                Do
                    Size = fstr.Read(buffer, 0, buffer.Length)
                    fileStreamOut.Write(buffer, 0, Size)
                Loop While (Size > 0)

                fstr.Close()
                fileStreamOut.Close()
                fileStreamIn.Close()
            End While
            rst.Close()

            Process.Start("explorer.exe", extract_location)

        Catch ex As Exception
            MessageBox.Show("Message:" & ex.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
            Return False
        End Try
    End Function

    Public Function GetAttachmentDate() As String
        com.CommandText = "select date_format(current_timestamp,'%Y%m%d') as trackdate" : rst = com.ExecuteReader
        While rst.Read
            GetAttachmentDate = rst("trackdate").ToString
        End While
        rst.Close()
        Return GetAttachmentDate
    End Function

    Public Function AddAttachmentPackage(ByVal refno As String, ByVal trntype As String, ByVal fileLocation As Array) As Boolean
        Dim FileSize As UInt32
        Dim rawData() As Byte
        Dim fs As FileStream

        Try
            For Each flocation As String In fileLocation
                com = Nothing : rawData = Nothing : FileSize = Nothing
                com = New MySqlCommand : com.Connection = conn
                If countqry("information_schema.tables", "table_schema='filedir' and table_name='tbl" & GetAttachmentDate() & "'") = 0 Then
                    com.CommandText = "CREATE TABLE  `filedir`.`tbl" & GetAttachmentDate() & "` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `refnumber` varchar(105) CHARACTER SET latin1 NOT NULL,  `trntype` varchar(45) NOT NULL,  `filename` varchar(500) CHARACTER SET latin1 NOT NULL,  `archievedname` text NOT NULL,  `extension` varchar(45) NOT NULL,  `attachment` longblob,  `filesize` bigint(20) unsigned NOT NULL,  `datesaved` datetime NOT NULL,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=60 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery()
                End If
                fs = New FileStream(flocation, FileMode.Open, FileAccess.Read)
                FileSize = fs.Length

                rawData = New Byte(FileSize) {}
                fs.Read(rawData, 0, FileSize)
                fs.Close()
                Dim ArchievedName As String = NewMd5FileName(flocation) & Path.GetExtension(flocation)
                com.CommandText = "insert into filedir.tblattachmentlogs set refnumber='" & refno & "', trntype='" & trntype & "', databasename='tbl" & GetAttachmentDate() & "',filename='" & rchar(Path.GetFileName(flocation)) & "',archievedname='" & ArchievedName & "', filesize='" & FileSize & "'" : com.ExecuteNonQuery()
                com.CommandText = "INSERT INTO filedir.`tbl" & GetAttachmentDate() & "` (refnumber,trntype,filename,archievedname,extension,attachment,filesize,datesaved) " _
                    + " VALUES('" & refno & "','" & trntype & "','" & rchar(Path.GetFileName(flocation)) & "','" & ArchievedName & "','" & Path.GetExtension(flocation) & "',?File,?FileSize,current_timestamp)"
                com.Parameters.Add("?File", rawData)
                com.Parameters.Add("?FileSize", FileSize)
                com.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, "Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function NewMd5FileName(ByVal str As String) As String
        com.CommandText = "select md5(concat('" & str & "',date_format(current_timestamp,'%Y%m%d%h%i%s'))) as trackdate" : rst = com.ExecuteReader
        While rst.Read
            NewMd5FileName = rst("trackdate").ToString
        End While
        rst.Close()
        Return NewMd5FileName
    End Function

#Region "ZipFILE Module"
    Public Sub AddFileToZip(ByVal zipFilename As String, ByVal fileToAdd As String, ByVal referenceid As String, ByVal filename As String)
        If ZIPFILE_LOCATION = "" Then
            MessageBox.Show("Archived location not available!", "Error Uploading", _
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Using zip As Package = System.IO.Packaging.Package.Open(ZIPFILE_LOCATION & zipFilename & ".zip", FileMode.OpenOrCreate)
            Dim destFilename As String = ".\" & filename
            Dim uri As Uri = PackUriHelper.CreatePartUri(New Uri(destFilename, UriKind.Relative))
            If zip.PartExists(uri) Then
                zip.DeletePart(uri)
            End If
            Dim part As PackagePart = zip.CreatePart(uri, "", CompressionOption.Normal)
            Using fileStream As New FileStream(fileToAdd, FileMode.Open, FileAccess.Read)
                Using dest As Stream = part.GetStream()
                    CopyStream(fileStream, dest)
                End Using
            End Using
        End Using
    End Sub
    Public Sub DelFileFromZip(ByVal zipFilename As String, ByVal ArchievedFileName As String)
        If ZIPFILE_LOCATION = "" Then
            MessageBox.Show("Archived location not available!", "Error Uploading", _
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Using zip As Package = System.IO.Packaging.Package.Open(ZIPFILE_LOCATION & zipFilename & ".zip", FileMode.OpenOrCreate)
            Dim uri As Uri = PackUriHelper.CreatePartUri(New Uri(ArchievedFileName, UriKind.Relative))
            If zip.PartExists(uri) Then
                zip.DeletePart(uri)
            End If
        End Using
    End Sub

    Public Sub CopyStream(ByVal inputStream As System.IO.FileStream, ByVal outputStream As System.IO.Stream)
        Dim bufferSize As Long = If(inputStream.Length < BUFFER_SIZE, inputStream.Length, BUFFER_SIZE)
        Dim buffer As Byte() = New Byte(bufferSize - 1) {}
        Dim bytesRead As Integer = 0
        Dim bytesWritten As Long = 0
        While (InlineAssignHelper(bytesRead, inputStream.Read(buffer, 0, buffer.Length))) <> 0
            outputStream.Write(buffer, 0, bytesRead)
            bytesWritten += bufferSize
        End While
    End Sub
    Public Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

    Public Function GetAttachmentName() As String
        com.CommandText = "select date_format(current_timestamp,'%Y%m%d') as trackdate" : rst = com.ExecuteReader
        While rst.Read
            GetAttachmentName = rst("trackdate").ToString
        End While
        rst.Close()
        Return GetAttachmentName
    End Function

#End Region

































End Module
