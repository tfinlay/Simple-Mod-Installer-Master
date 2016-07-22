Public Class FolderView
    Public closeform As Boolean
    Public Path As String = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection

    Public Sub Collection_FolderView_LoadManager()
        Enabled = False
        closeform = False
        Dim Selected As String
        Try
            Selected = SubDirectoriesList.SelectedItem.ToString
        Catch
        End Try
        Call Collection_SubDir_Lister(Me, Path, True)

        Try
            SubDirectoriesList.SelectedItem = Selected
        Catch ex As Exception
        End Try

        ModList.Sorted = My.Settings.sortLists
        SubDirectoriesList.Sorted = My.Settings.sortLists
        Enabled = True
    End Sub

    Private Sub FolderView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CollectionView.Enabled = True
        CollectionView.CollectionView_RefreshButton.PerformClick()
        'If closeform = False Then
        '    e.Cancel = True
        '    MsgBox("Please use the Back button to close this window safely")
        'ElseIf closeform = True Then

        'End If
    End Sub

    Private Sub FolderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Collection_FolderView_LoadManager()
    End Sub

    Private Sub Refresh_Button_Click(sender As Object, e As EventArgs) Handles Refresh_Button.Click
        Call Collection_FolderView_LoadManager()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Close()
    End Sub

    Public Sub SubDirectoriesList_SelectedIndexChanged() Handles SubDirectoriesList.SelectedIndexChanged
        Try
            If My.Computer.FileSystem.DirectoryExists(Path + "\" + SubDirectoriesList.SelectedItem.ToString) Then
                If My.Settings.showUnreachables = False Then
                    Call FolderView_LoadFiles(Me, Path + "\" + SubDirectoriesList.SelectedItem.ToString)
                Else
                    Call Collection_LoadMods(Me, Path + "\" + SubDirectoriesList.SelectedItem.ToString, False)
                End If
            Else
                    Call Collection_FolderView_LoadManager()
            End If
        Catch
        End Try
    End Sub

    Private Sub AddFile_Click(sender As Object, e As EventArgs) Handles AddFile.Click
        If Not SubDirectoriesList.SelectedItem.ToString = "" Then
            Enabled = False
            AddMods.Show()
            AddMods.AddFile_Title.Text = "Please either select a file or a folder full of files you wish to add to your collection:"
            AddMods.SingleAdd.Text = "Add a Single File:"
            AddMods.FolderAdd.Text = "Add a Folder Full of Files:"
            AddMods.AddButton.Text = "Add File(s)"
            My.Settings.AddFiles_BasePath = Path + "\" + SubDirectoriesList.SelectedItem.ToString + "\"
            My.Settings.Save()
        Else
            MsgBox("Please select a Folder to add a file to it.")
        End If
    End Sub

    Private Sub DelFile_Click(sender As Object, e As EventArgs) Handles DelFile.Click
        If My.Settings.showUnreachables = True Then
            'UNSTABLE - Use with caution:
            For l_index As Integer = 0 To ModList.CheckedItems.Count - 1
                Dim l_text As String = CStr(ModList.CheckedItems(l_index))
                Try
                    My.Computer.FileSystem.DeleteFile(Path + "\" + SubDirectoriesList.SelectedItem.ToString + "\" + l_text)
                Catch ex As Exception
                    For Each Dir As String In IO.Directory.GetDirectories(Path + "\" + SubDirectoriesList.SelectedItem.ToString)
                        Try
                            testmsg("Attempting to Delete: " + Dir.ToString + "\" + l_text)
                            My.Computer.FileSystem.DeleteFile(Dir.ToString + "\" + l_text)
                            GoTo DeleteSuccess
                        Catch
                            testmsg("Couldn't find the file: " + Dir.ToString + "\" + l_text)
                        End Try
                    Next
                    MsgBox("Failed to find the File: " + l_text + " - Maybe it's in a sub-subfolder that we can't see?")
                    'ERROR NOW HANDLED: MsgBox("Couldn't find file: " + Path + "\" + SubDirectoriesList.SelectedItem.ToString + "\" + l_text)
DeleteSuccess:
                End Try
            Next
            Call Collection_FolderView_LoadManager()
        Else
            'Only Files Directly inside the Directory are Shown - Very Easy
            For l_index2 As Integer = 0 To ModList.CheckedItems.Count - 1
                Dim l_text2 As String = CStr(ModList.CheckedItems(l_index2))
                Try
                    My.Computer.FileSystem.DeleteFile(Path + "\" + SubDirectoriesList.SelectedItem.ToString + "\" + l_text2)
                Catch ex As Exception
                    MsgBox("Failed to delete file: " + Path + "\" + SubDirectoriesList.SelectedItem.ToString + "\" + l_text2)
                End Try
            Next
            Call Collection_FolderView_LoadManager()
        End If
    End Sub

    Private Sub EditFile_Click(sender As Object, e As EventArgs) Handles EditFile.Click

        If My.Settings.showUnreachables = False Then
            For l_index As Integer = 0 To ModList.CheckedItems.Count - 1
                Dim l_text As String = CStr(ModList.CheckedItems(l_index))
                Try
                    Dim SelectedFile As String = Path + "\" + SubDirectoriesList.SelectedItem + "\" + l_text
                    Process.Start(SelectedFile)
                Catch ex As Exception
                    MsgBox("Failed to open editor for file: " + Path + "\" + SubDirectoriesList.SelectedItem + "\" + l_text)
                End Try
            Next
        Else
            MsgBox("You have Show Potentially Unreachable Files activated. Editing is not supported when this is on. You must disable it in Options to use this feature.")
        End If
    End Sub

    Private Sub AddFolder_Click(sender As Object, e As EventArgs) Handles AddFolder.Click
        Enabled = False
        Visible = False
        NameFolder.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles delfolder.Click
        If Not SubDirectoriesList.SelectedItem.ToString = "mods" Or Not SubDirectoriesList.SelectedItem.ToString = "config" Or Not SubDirectoriesList.SelectedItem.ToString = My.Settings.SelectedCollection_MCversion Then
            If My.Computer.FileSystem.DirectoryExists(Path + "\" + SubDirectoriesList.SelectedItem.ToString) Then
                Try
                    My.Computer.FileSystem.DeleteDirectory(Path + "\" + SubDirectoriesList.SelectedItem.ToString, FileIO.DeleteDirectoryOption.DeleteAllContents)
                Catch ex As Exception
                    MsgBox("Failed to delete folder: " + SubDirectoriesList.SelectedItem.ToString + "Maybe it's already been deleted? Try Clicking the refresh button.")
                End Try
            Else
                MsgBox("It appears that the directory has already been deleted")
            End If

        Else
            MsgBox("You cannot delete this directory!")
        End If
        Call Collection_FolderView_LoadManager()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SubDirectoriesList.SelectedItems.Count < 1 Then
            AddFile.Enabled = False
            EditFile.Enabled = False
            DelFile.Enabled = False
            delfolder.Enabled = False
            openFolder.Enabled = False
        Else
            AddFile.Enabled = True
            EditFile.Enabled = True
            DelFile.Enabled = True
            delfolder.Enabled = True
            openFolder.Enabled = True
        End If

        If SubDirectoriesList.Items.Count < 1 Then
            EmptySubs.Visible = True
        Else
            EmptySubs.Visible = False
        End If

        If Not CollectionView.Enabled = False Then
            CollectionView.Enabled = False
        End If

        If ModList.Items.Count = 0 And SubDirectoriesList.SelectedItems.Count = 0 Then
            SelectSubDirLabel.Visible = True
        Else
            SelectSubDirLabel.Visible = False
        End If

        If ModList.Items.Count = 0 And Not SelectSubDirLabel.Visible = True Then
            NothingHereLabel.Visible = True
        Else
            NothingHereLabel.Visible = False
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles openFolder.Click
        Try
            If My.Computer.FileSystem.DirectoryExists(Path + "\" + SubDirectoriesList.SelectedItem.ToString) Then
                Process.Start(Path + "\" + SubDirectoriesList.SelectedItem.ToString)
            Else
                MsgBox("Couldn't find folder")
                Call Collection_FolderView_LoadManager()
            End If
        Catch
            MsgBox("An error ocurred")
        End Try
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Enabled = False
        ImportFolder.Show()
    End Sub

    Private Sub ModList_MouseHover(sender As Object, e As EventArgs) Handles ModList.MouseHover
        ModList.Focus()
    End Sub

    Private Sub SubDirectoriesList_MouseHover(sender As Object, e As EventArgs) Handles SubDirectoriesList.MouseHover
        SubDirectoriesList.Focus()
    End Sub

    Private Sub SubDirectoriesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubDirectoriesList.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Call Collection_FolderView_LoadManager()

        For l_index As Integer = 0 To ModList.Items.Count - 1
            Dim l_text As String = CStr(ModList.Items(l_index))
            If Not l_text.ToString.ToLower.Contains(SearchText.Text.ToLower) Then
                InvisibleListBox.Items.Add(l_text)
            End If
        Next

        For l_index2 As Integer = 0 To InvisibleListBox.Items.Count - 1
            Dim l_text2 As String = CStr(InvisibleListBox.Items(l_index2))
            ModList.Items.Remove(l_text2)
        Next
        InvisibleListBox.Items.Clear()
    End Sub

    Private Sub drag_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop, ModList.DragDrop
        Dim theFiles() As String = CType(e.Data.GetData("FileDrop", True), String())

        If Not SubDirectoriesList.SelectedItem.ToString = "" Then
            My.Settings.AddFiles_BasePath = Path + "\" + SubDirectoriesList.SelectedItem.ToString + "\"
            My.Settings.Save()

            For Each currentFile As String In theFiles
                'Copy that
                Dim BasePath As String = My.Settings.AddFiles_BasePath
                Dim trimmedFileName As String = functionalPathTrimmer(currentFile)

                If Not currentFile = "" Then
                    If isPathFile(currentFile) = True Then
                        If Not My.Computer.FileSystem.FileExists(BasePath + trimmedFileName) Then
                            My.Computer.FileSystem.CopyFile(currentFile, BasePath + trimmedFileName)
                        Else
                            MsgBox("The selected file already exists in your collection.")
                        End If
                    ElseIf isPathFile(currentFile) = False Then
                        Try
                            My.Computer.FileSystem.CopyDirectory(currentFile, BasePath + trimmedFileName)
                        Catch ex As Exception
                            MsgBox("An error occured when copying this directory: " + currentFile.ToString() + " The error was: " + ex.ToString())
                        End Try
                    End If
                Else
                    MsgBox("Please select a file to add before continuing.")

                End If
            Next
            Call Collection_FolderView_LoadManager()
        Else
            MsgBox("Please select a Folder to add a file to it.")
        End If
    End Sub

    Private Sub drag_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter, ModList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        checkAll(ModList)
    End Sub

    Private Sub DeselectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeselectAllToolStripMenuItem.Click
        uncheckAll(ModList)
    End Sub

    Private Sub RemoveAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllToolStripMenuItem.Click
        checkAll(ModList)
        DelFile.PerformClick()
    End Sub
End Class