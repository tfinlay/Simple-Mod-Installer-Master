Imports System.IO

Module CollectionFunctions
    Public subDir
    'Searches for files in the \mods folder
    ''' <summary>
    ''' Path is the Path to the folder you wish to scan, Addmods is a boolean to decide whether to add \mods to the given path.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="path"></param>
    ''' <param name="Addmods"></param>
    Public Sub Collection_LoadMods(sender As Object, path As String, Addmods As Boolean)
        'sender.Title.text = My.Settings.SelectedCollection
        sender.ModList.ClearSelected()
        sender.ModList.Items.Clear()
        'Getting 
        Dim modsq As String

        If Addmods = True Then
            modsq = "\mods"
        Else
            modsq = ""
        End If

        Dim Folder As New IO.DirectoryInfo(path + modsq)
        Try
            For Each File As IO.FileInfo In Folder.GetFiles("*.*", IO.SearchOption.AllDirectories)
                If Not File.Name.ToString.Contains(".CollectionInfo") Then
                    sender.ModList.Items.Add(File.Name)
                    Application.DoEvents()
                End If
            Next
        Catch
            MsgBox("An error occured when looking for mods. Maybe the mods folder has been deleted? We're going to try and create a new one now...")
            Try
                My.Computer.FileSystem.CreateDirectory(path + modsq)
            Catch
                MsgBox("The attempt to create the folder has failed too. try creating a new collection.")
                CollectionView.Close()
                Form3.Show()
            End Try
        End Try
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
                        My.Settings.SelectedCollection_MCversion = currentLine
                        My.Settings.Save()
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

    'Gets Folder Names in Collections Base Folder

    ''' <summary>
    ''' Scans a folder and writes either the names (returnTypePath = false) or the full path (returnTypePath = true) to a specified file (outputFile - if it doesn't exist it's created)
    ''' The Base Directory is the directory that will be scanned - must be path, not just name.
    ''' 
    ''' AppendLineOutq: true appends each line in the output file, false doesn't
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="BaseDirectory"></param>
    ''' <param name="returnTypePath"></param>
    ''' <param name="outputFile"></param>
    ''' <param name="AppendLineOutq"></param>
    Public Sub Collection_FolderScan(sender As Object, BaseDirectory As String, returnTypePath As Boolean, outputFile As String, AppendLineOutq As Boolean)
        Using sw As StreamWriter = New StreamWriter(outputFile, AppendLineOutq)

            For Each folder As String In System.IO.Directory.GetDirectories(BaseDirectory)
                If returnTypePath = True Then
                    sw.WriteLine(folder)
                ElseIf returnTypePath = False Then
                    sw.WriteLine(Path.GetFileName(folder))
                End If
            Next

        End Using
        Return
    End Sub

    ''' <summary>
    ''' Gets all Subdirectories of the specified 'BaseDirectory' (must be full path) and puts them in a listBox on the sender's form named "SubDirectoriesList". Shorten boolean determines whether or not to shorten the path to just the end.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="BaseDirectory"></param>
    Public Sub Collection_SubDir_Lister(sender As Object, BaseDirectory As String, Shorten As Boolean)
        sender.SubDirectoriesList.items.clear
        sender.ModList.items.clear
        For Each drvs In Directory.GetDirectories(BaseDirectory)

            If Shorten = True Then
                Dim filePath As String = drvs
                Dim directory As String = Path.GetDirectoryName(filePath)

                Dim split As String() = filePath.Split("\")
                subDir = split(split.Length - 1)

                sender.SubDirectoriesList.Items.Add(subDir)
            ElseIf Shorten = False Then
                sender.SubDirectoriesList.Items.Add(drvs)
            End If


            If drvs.ToString.Length > 0 Then
                Try
                    For Each di In Directory.GetDirectories(drvs)
                        If Shorten = True Then
                            Dim filePath As String = di
                            Dim directory As String = Path.GetDirectoryName(filePath)

                            Dim split As String() = filePath.Split("\")
                            Dim parentFolder As String = split(split.Length - 1)

                            sender.SubDirectoriesList.Items.Add(subDir + "\" + parentFolder)
                        ElseIf Shorten = False Then
                            sender.SubDirectoriesList.Items.Add(di)
                        End If
                    Next
                Catch ex As Exception
                    MsgBox("An exception occured in Collection_SubDir_Lister. Please add this issue to: https://github.com/tfff1OFFICIAL/Simple-Mod-Installer-Master/issues or email me at: tfff1s.modpacks@gmail.com")
                End Try
            End If

        Next

    End Sub

    Public Sub FolderCheck(path As String)
        If Not My.Computer.FileSystem.DirectoryExists(path + "\config") Then
            My.Computer.FileSystem.CreateDirectory(path + "\config")
        End If

        If Not My.Computer.FileSystem.DirectoryExists(path + "\mods") Then
            My.Computer.FileSystem.CreateDirectory(path + "\mods")
        End If

        If Not My.Computer.FileSystem.DirectoryExists(path + "\DisabledMods") Then
            My.Computer.FileSystem.CreateDirectory(path + "\DisabledMods")
        End If

        If Not My.Computer.FileSystem.DirectoryExists(path + "\mods\" + My.Settings.SelectedCollection_MCversion) Then
            My.Computer.FileSystem.CreateDirectory(path + "\mods\" + My.Settings.SelectedCollection_MCversion)
        End If
    End Sub

    Public Sub ActivateCollection(sender As Object)
        Dim appdata = My.Settings.appdata
        Dim CollectionPath = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection


        'Reset Folder List
        If My.Computer.FileSystem.FileExists(CollectionPath + "\mods\folders.txt") Then
            My.Computer.FileSystem.DeleteFile(CollectionPath + "\mods\folders.txt")
        End If
        'Write to Folder List
        Using sw As StreamWriter = New StreamWriter(CollectionPath + "\mods\folders.txt")

            For Each Dir As String In System.IO.Directory.GetDirectories(CollectionPath)
                Dim dirInfo As New System.IO.DirectoryInfo(Dir)
                sw.WriteLine(dirInfo.Name)
            Next
        End Using

        'Check if a collection is already activated:
        Dim CurrentlyEnabledFile As String
        Dim CurrentlyEnabledCollectionName As String
        If My.Computer.FileSystem.DirectoryExists(appdata + "\.minecraft\mods") Then
            Dim Folder As New IO.DirectoryInfo(appdata + "\.minecraft\mods")

            For Each File As IO.FileInfo In Folder.GetFiles("*.CollectionInfo", IO.SearchOption.AllDirectories)
                If File.Name.ToString.Contains(".CollectionInfo") Then
                    MsgBox(File.Name.ToString)
                    CurrentlyEnabledFile = File.Name.ToString
                    GoTo CheckDone
                    Application.DoEvents()
                End If
            Next
CheckDone:
            MsgBox("Skipped to CheckDone")
            Try
                Dim currentLine As String
                Dim Readlines As Integer = 0
                Using sr As StreamReader = New StreamReader(appdata + "\.minecraft\mods\" + CurrentlyEnabledFile)
Scan:
                    If Not Readlines = 1 Then

                        currentLine = sr.ReadLine.ToString
                        If Readlines = 0 Then
                            CurrentlyEnabledCollectionName = currentLine
                            Readlines = Readlines + 1
                            GoTo Scan
                        End If
                    End If
                End Using
            Catch ex As Exception
                MsgBox("An Error ocurred when reading information from currently enabled Collection's .CollectionInfo File")
                Return
            End Try

        End If
        '

        Return
    End Sub
End Module
