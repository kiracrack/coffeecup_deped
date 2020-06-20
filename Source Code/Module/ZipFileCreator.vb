Imports System.IO
Imports System.IO.Packaging
Imports ICSharpCode.SharpZipLib.Zip
Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen

Module ZipFileCreator
    Private Const BUFFER_SIZE As Long = 4096

    Public Function AddFileToDatabase(ByVal refno As String, ByVal trntype As String, ByVal fileList() As String) As Boolean
        Dim FileSize As UInt32
        Dim rawData() As Byte
        Dim fs As FileStream

        Try
            For Each strfile As String In fileList
                If Not strfile = "" Then
                    com = Nothing : rawData = Nothing : FileSize = Nothing
                    fs = New FileStream(strfile, FileMode.Open, FileAccess.Read)
                    FileSize = fs.Length

                    rawData = New Byte(FileSize) {}
                    fs.Read(rawData, 0, FileSize)
                    fs.Close()

                    com = New MySqlCommand : com.Connection = conn
                    com.CommandText = "DELETE FROM filedir.tblblobattachment where refnumber='" & refno & "' and filename='" & rchar(Path.GetFileName(strfile)) & "' and filesize=" & FileSize & ";" : com.ExecuteNonQuery()
                    com.CommandText = "INSERT INTO filedir.tblblobattachment (refnumber,trntype,filename,extension,attachment,filesize,datesaved) " _
                        + " VALUES('" & refno & "','" & trntype & "','" & rchar(Path.GetFileName(strfile)) & "', '" & Path.GetExtension(strfile) & "',?File,?FileSize,current_timestamp)"
                    com.Parameters.Add("?File", rawData)
                    com.Parameters.Add("?FileSize", FileSize)
                    com.ExecuteNonQuery()
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Connection error during uploading attachment. click ok to retry upload." & Environment.NewLine & "Message: " & ex.Message, "Error Uploading", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Sub AddFileToZip(ByVal zipFilename As String, ByVal fileToAdd As String, ByVal referenceid As String, ByVal filename As String)
        If ZIPFILE_LOCATION = "" Then
            MessageBox.Show("Archived localtion not available!", "Error Uploading", _
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If (Not System.IO.Directory.Exists(ZIPFILE_LOCATION)) Then
            System.IO.Directory.CreateDirectory(ZIPFILE_LOCATION)
        End If

        Using zip As Package = System.IO.Packaging.Package.Open(ZIPFILE_LOCATION & "\" & zipFilename & ".zip", FileMode.OpenOrCreate)
            Dim destFilename As String = ".\" & filename & Path.GetExtension(fileToAdd)
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

   
    Public Function ExtractBlobFiles(ByVal refno As String)
        Dim extract_location As String = System.IO.Path.GetTempPath() & "Extracted\"
        MdiCoffeeCup.timernotification.Stop()
        Dim myData As MySqlDataReader
        Dim rawData() As Byte
        Dim FileSize As UInt32
        Dim fs As FileStream
        Try
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            If (System.IO.Directory.Exists(extract_location)) Then
                My.Computer.FileSystem.DeleteDirectory(extract_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If (Not System.IO.Directory.Exists(extract_location)) Then
                System.IO.Directory.CreateDirectory(extract_location)
            End If

            For Each word In refno.Split(New Char() {","c})
                com.CommandText = "SELECT * FROM filedir.tblblobattachment where refnumber = '" & word & "'"
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

            Next

            Process.Start("explorer.exe", extract_location)
            MdiCoffeeCup.timernotification.Start()
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            MdiCoffeeCup.timernotification.Start()
            SplashScreenManager.CloseForm()
            myData.Close()
            MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function

    Public Function SetAttachmentFile(ByVal refno As String, ByVal trntype As String, ByVal fileList() As String) As Boolean
        Dim FileSize As UInt32
        Dim rawData() As Byte
        Dim fs As FileStream

        Try
            For Each strfile As String In fileList
                If Not strfile = "" Then
                    com = Nothing : rawData = Nothing : FileSize = Nothing
                    fs = New FileStream(strfile, FileMode.Open, FileAccess.Read)
                    FileSize = fs.Length

                    rawData = New Byte(FileSize) {}
                    fs.Read(rawData, 0, FileSize)
                    fs.Close()
                    com = New MySqlCommand : com.Connection = conn
                    com.CommandText = "INSERT INTO filedir.tblblobattachment (refnumber,trntype,filename,extension,attachment,filesize,datesaved) " _
                        + " VALUES('" & refno & "','" & trntype & "','" & rchar(Path.GetFileName(strfile)) & "','" & Path.GetExtension(strfile) & "',?File,?FileSize,current_timestamp)"
                    com.Parameters.Add("?File", rawData)
                    com.Parameters.Add("?FileSize", FileSize)
                    com.ExecuteNonQuery()

                    'add copy to archived
                    AddFileToZip(Format(Now.ToString("yyyy-MM-dd")), strfile, refno, GetAttachmentName)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, "Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function
End Module
