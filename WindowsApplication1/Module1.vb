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
End Module