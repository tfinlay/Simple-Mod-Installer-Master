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
                    If Not File.Name.ToString() = "folders.txt" Then
                        sender.ModList.Items.Add(File.Name)
                        Application.DoEvents()
                    End If
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


    Public Sub FolderView_LoadFiles(sender As Object, path As String)
        'sender.Title.text = My.Settings.SelectedCollection
        sender.ModList.ClearSelected()
        sender.ModList.Items.Clear()
        'Getting 
        Dim Folder As New IO.DirectoryInfo(path)
        Try
            For Each File As IO.FileInfo In Folder.GetFiles("*.*", IO.SearchOption.TopDirectoryOnly)
                If Not File.Name.ToString.Contains(".CollectionInfo") Then
                    sender.ModList.Items.Add(File.Name)
                    Application.DoEvents()
                End If
            Next
        Catch
            MsgBox("An error occured when looking for mods. Maybe the mods folder has been deleted? We're going to try and create a new one now...")
            Try
                My.Computer.FileSystem.CreateDirectory(path)
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
        Try
            sender.ModList.items.clear
        Catch
            'Sender Doesn't contain ModList
        End Try
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
        Return
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
        Using sw As StreamWriter = New StreamWriter(CollectionPath + "\mods\folders.txt", True)

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
                    testmsg(File.Name.ToString)
                    sender.successList.items.add("Found CollectionInfo File of activated Collection: " + File.Name.ToString)
                    CurrentlyEnabledFile = File.Name.ToString
                    Application.DoEvents()
                    'GoTo CheckDone
                    Exit For
                End If
            Next
CheckDone:
            testmsg("Arrived at CheckDone")
            'Now get the Collection's Name out of the CollectionInfo File
            Try
                Dim currentLine As String
                Dim Readlines As Integer = 0
                Using sr As StreamReader = New StreamReader(appdata + "\.minecraft\mods\" + CurrentlyEnabledFile)
Scan:
                    If Not Readlines = 1 Then

                        currentLine = sr.ReadLine.ToString
                        If Readlines = 0 Then
                            CurrentlyEnabledCollectionName = currentLine
                            sender.CurrentlyActivated.text = CurrentlyEnabledCollectionName
                            Readlines = Readlines + 1
                            GoTo Scan
                        End If
                    End If
                End Using
            Catch ex As Exception
                Dim result As Integer = MessageBox.Show("An Error ocurred when reading information from currently enabled Collection's .CollectionInfo File. Will now proceed to delete everything in our way.", "Warning", MessageBoxButtons.OKCancel)
                If result = DialogResult.Cancel Then
                    MsgBox("Collection: " + My.Settings.CurrentlyActivated + " Activation failed! The Reason: You we encountered an error when reading the currently enabled collection's .CollectionInfo File and asked you for permission to overwrite the activated mods folder with the new one. This error occurred because you denied this permission. Try again later.")
                    Activation.PermittedClose = True
                    Activation.Close()
                ElseIf result = DialogResult.OK Then
                    My.Computer.FileSystem.DeleteDirectory(appdata + "\.minecraft\mods", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    Call ActivateCollection(sender)
                Exit Sub
                End If
            End Try

            'Check if names match each other - if they don't something is wrong!
            If Not My.Settings.CurrentlyActivated = CurrentlyEnabledCollectionName Then
                'MsgBox("Something may be wrong! - CompareNames has failed - two different collections appear to be activated? Maybe try deleteing C:\Tfff1\Simple_MC\Mod_Collections NOTE: Deleting this folder will delete all of your collections.")
                'Activation.PermittedClose = True
                'Activation.Close()
                'CollectionView.Close()
                'Return
                My.Settings.CurrentlyActivated = CurrentlyEnabledCollectionName
                My.Settings.Save()
            End If

            'Now Deactivate The Collection
            If CurrentlyEnabledCollectionName = My.Settings.SelectedCollection Then
                MsgBox("New Changes will be synced - Please Note: Changes to all folders except Saves and config in the .minecraft version of this Collection will be lost")
                sender.successList.items.add("Starting Sync")
            Else
                testmsg("The Collection: " + My.Settings.CurrentlyActivated.ToString + " will be deactivated")
                sender.successList.items.add("Deactivating Collection: " + My.Settings.CurrentlyActivated.ToString)
            End If
            '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            'Deactivate Current Collection
            '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            'Deactivate Collection - saving changes to 'saves' and 'config' folders
            Dim linecount As Integer
            linecount = File.ReadAllLines(appdata + "\.minecraft\mods\folders.txt").Length
            Using sr As StreamReader = New StreamReader(appdata + "\.minecraft\mods\folders.txt")
readfolders:
                If linecount > 0 Then
                    sender.FolderList.Items.Add(sr.ReadLine().ToString)
                    linecount = linecount - 1
                    GoTo readfolders
                End If
            End Using

            'Delete all folders except Saves & Config:
            For l_index As Integer = 0 To sender.FolderList.Items.Count - 1
                Dim l_text As String = CStr(sender.FolderList.Items(l_index))
                If Not l_text.ToString.Contains("saves") Or Not l_text.ToString.Contains("config") Then
                    My.Computer.FileSystem.DeleteDirectory(appdata + "\.minecraft\" + l_text, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    'Add to the Special Directories List - to be removed from this list later:
                    sender.SpecialDirectoriesList.items.add(l_text)
                End If
            Next
            'Read the Special Directories List and remove all the items in it from the Main List - FolderList
            For l_index As Integer = 0 To sender.SpecialDirectoriesList.Items.Count - 1
                Dim l_text As String = CStr(sender.SpecialDirectoriesList.Items(l_index))
                sender.FolderList.items.remove(l_text)
            Next
            'Clear the SpecialDirectoriesList for next time
            sender.SpecialDirectoriesList.items.clear

            'Sync Saves & Config:
            'Will copy items to their parent folder in the non-enabled copy of the Collection, overwriting the one that's already there if the name clashes. Then will remove the saves folder from .minecraft

            'Found at: http://stackoverflow.com/questions/12755701/vb-net-getting-each-item-in-a-listbox-and-finding-its-text-index
            For l_index As Integer = 0 To sender.FolderList.Items.Count - 1
                'Get the subDirectories
                Dim l_text As String = CStr(sender.FolderList.Items(l_index))
                'Add them to the listbox in Activation:
                Call Collection_SubDir_Lister(Activation, appdata + "\.minecraft\" + l_text, True)
                'From the listbox in Activation, sync the subDirectories, then move on:
                For l_index2 As Integer = 0 To sender.SubDirectoriesList.Items.Count - 1
                    Dim l_text2 As String = CStr(sender.SubDirectoriesList.Items(l_index2))
                    My.Computer.FileSystem.CopyDirectory(appdata + "\.minecraft\" + l_text + "\" + l_text2, "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.CurrentlyActivated + "\" + l_text + "\" + l_text2, True)
                    sender.SuccessList.items.add("Synced: " + l_text2 + "from in " + l_text)
                Next
                'Clear the SubDirectories List and Add Success messsage to Successlist
                sender.SubDirectoriesList.items.clear
                sender.SuccessList.items.add("Finished Syncing Folder: " + l_text)

            Next
            sender.SuccessList.items.add("Finished Syncing Config and Saves Folders")
            'Delete Config & Saves from .minecraft
            For l_index As Integer = 0 To sender.FolderList.Items.Count - 1
                Dim l_text As String = CStr(sender.FolderList.Items(l_index))
                My.Computer.FileSystem.DeleteDirectory(appdata + "\.minecraft\" + l_text, FileIO.DeleteDirectoryOption.DeleteAllContents)
                sender.SuccessList.items.add("Deleted Folder: " + l_text + " from .minecraft folder")
            Next
            sender.SuccessList.items.add("Finished Syncing Activated Folders from .minecraft")
            sender.FolderList.items.clear
            sender.SubDirectoriesList.items.clear
            sender.SpecialDirectoriesList.items.clear
            sender.successList.items.add("Finished Clean up after De-Activation of Collection: " + My.Settings.CurrentlyActivated)
            '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            'BEGIN ACTIVATION OF NEW COLLECTION
            '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Call FirstCollectionPush(sender)
            'End If
        Else
            Call FirstCollectionPush(sender)
        End If
        '

        Return
    End Sub

    Public Sub SyncCollections()
        'Called if a collection is activated and changes have been made to the non .minecraft version. Will Overwrite everything in .minecraft except saves and config, saves and config will be synced properly.
        '
        'UNNEEDED - The combination of ActivateCollection (deletes the collection) & FirstCollectionPush (Activates a new collection) do the same job as this would
        '
    End Sub

    Public Sub FirstCollectionPush(sender As Object)
        Dim appdata = My.Settings.appdata
        Dim CollectionPath = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection

        'Creates Filesystem if necessary and overwrites everything in it's path
        Dim linecount As Integer
        linecount = File.ReadAllLines(CollectionPath + "\mods\folders.txt").Length
        Using sr As StreamReader = New StreamReader(CollectionPath + "\mods\folders.txt")
readfolders:
            If linecount > 0 Then
                sender.FolderList.Items.Add(sr.ReadLine().ToString)
                linecount = linecount - 1
                GoTo readfolders
            End If
        End Using
        'Copy Folders:
        For l_index As Integer = 0 To Activation.FolderList.Items.Count - 1
            Dim l_text As String = CStr(Activation.FolderList.Items(l_index))
            Try
                My.Computer.FileSystem.CopyDirectory(CollectionPath + "\" + l_text, appdata + "\.minecraft\" + l_text, True)
            Catch ex As Exception
                MsgBox("Failed to Copy Folder: " + l_text)
            End Try
        Next

        If My.Computer.FileSystem.FileExists("C:\Tfff1\Simple_MC\Mod_Collections\ActiveCollection.txt") Then
            My.Computer.FileSystem.DeleteFile("C:\Tfff1\Simple_MC\Mod_Collections\ActiveCollection.txt")
        End If
        Using sw As StreamWriter = New StreamWriter("C:\Tfff1\Simple_MC\Mod_Collections\ActiveCollection.txt", True)
            sw.WriteLine(My.Settings.SelectedCollection)
        End Using

        My.Settings.CurrentlyActivated = My.Settings.SelectedCollection
        My.Settings.Save()

        MsgBox("Collection: " + My.Settings.CurrentlyActivated + " Active! Remember to Launch Minecraft with your modloader for Minecraft: " + My.Settings.SelectedCollection_MCversion)
        Activation.PermittedClose = True
        Activation.Close()
    End Sub
End Module
