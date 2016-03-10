Imports System.IO
Module CollectionFunctions

    'Searches for files in the \mods folder
    Public Sub Collection_LoadMods(sender As Object, path As String)
        'sender.Title.text = My.Settings.SelectedCollection

        'Getting Files
        Dim Folder As New IO.DirectoryInfo(path + "\mods")
        For Each File As IO.FileInfo In Folder.GetFiles("*.*", IO.SearchOption.AllDirectories)
            If Not File.Name.ToString.Contains(".CollectionInfo") Then
                sender.ModList.Items.Add(File.Name)
                Application.DoEvents()
            End If
        Next
        Return
    End Sub


    'For Reading The Title and MCversion from A Collection's .collectionInfo which is located in the \mods folder
    Public Sub Collection_ReadInfo(sender As Object, path As String)
        If File.Exists(path + "\mods\" + My.Settings.SelectedCollection + ".CollectionInfo") Then
            Dim currentLine As String
            Dim Readlines As Integer = 0
            Using sr As StreamReader = New StreamReader(path + "\mods\" + My.Settings.SelectedCollection + ".CollectionInfo")
Scan:
                If Not Readlines = 2 Then

                    currentLine = sr.ReadLine.ToString
                    If Readlines = 0 Then
                        My.Settings.titleFromInfo = currentLine
                        Readlines = Readlines + 1
                        GoTo Scan
                    ElseIf Readlines = 1 Then
                        sender.MCversion.text = "Minecraft Version: " + currentLine
                        Readlines = Readlines + 1
                        GoTo Scan
                    End If
                End If
            End Using

        Else
            'If the file doesn't exist:
            MsgBox("This collection is missing it's CollectionInfo file. You will be redirected to a window where you can fix this.")
            Collection_MissingInfo.Show()
            sender.enabled = False
        End If
        'Done
        My.Settings.Save()
        Return
    End Sub

    'Compares my.settings.SelectedCollection with the title found in the Collection's .collectionInfo
    Public Sub Collection_CompareTitles(sender As Object, Compare As Boolean)
        If Compare = True Then

            If My.Settings.SelectedCollection = My.Settings.titleFromInfo Then
                sender.title.text = My.Settings.SelectedCollection
            ElseIf Not My.Settings.SelectedCollection = My.Settings.titleFromInfo Then
                MsgBox("WARNING: Something is wrong! The title from this collection's collectionInfo does not match what is expected. You will be redirected to a window where you can re-enter the information for your Collection")
                Collection_MissingInfo.Show()
            End If
        End If
        Return
    End Sub
End Module
