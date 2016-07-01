Imports System.IO
Imports System.IO.Compression
Module module1
    Public zipdirec = My.Settings.zipdirec
    Public outdirec = My.Settings.outdirec
    Public Sub unzip()
        ZipFile.ExtractToDirectory(zipdirec, outdirec)
        MsgBox("Done!")
    End Sub
    Public Sub zip()
        ZipFile.CreateFromDirectory(outdirec, zipdirec)
        MsgBox("Done!")
    End Sub

    Public Sub StringWriter(FileLoc As String, toWrite As String, appendq As Boolean)
        Using sw As StreamWriter = New StreamWriter(FileLoc, appendq)
            sw.WriteLine(toWrite)
        End Using
        Return
    End Sub

    ''' <summary>
    ''' NewLoc must include new file name e.g. NewLoc = "C:\tfff1\mod.jar"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="File"></param>
    ''' <param name="NewLoc"></param>
    Public Sub MoveFile(sender As Object, File As String, NewLoc As String)
        Try
            My.Computer.FileSystem.MoveFile(File, NewLoc)
        Catch
            MsgBox("Moving File Failed for an unknown reason. Maybe the file got deleted or the destination couln't be found?")
        End Try
    End Sub

    Public Sub pathTrimmer(sender As Object, fileName As String)
        'Dim fileName As String = "C:\mydir\myfile.ext"
        Dim result As String
        result = Path.GetFileName(fileName)
        sender.TrimmedFileName = result
        Return
    End Sub

    Public Function testmsg(message As String)
        If My.Settings.TestEnvironment = True Then
            MsgBox(message)
        End If
    End Function
End Module