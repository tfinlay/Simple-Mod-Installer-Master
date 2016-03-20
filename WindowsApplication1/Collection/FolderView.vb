﻿Public Class FolderView
    Public closeform As Boolean
    Public Path As String = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection

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

    Public Sub Collection_FolderView_LoadManager()
        Enabled = False
        closeform = False

        Call Collection_SubDir_Lister(Me, Path, True)
        Enabled = True
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Close()
    End Sub

    Public Sub SubDirectoriesList_SelectedIndexChanged() Handles SubDirectoriesList.SelectedIndexChanged
        Try
            If My.Computer.FileSystem.DirectoryExists(Path + "\" + SubDirectoriesList.SelectedItem.ToString) Then
                Call Collection_LoadMods(Me, Path + "\" + SubDirectoriesList.SelectedItem.ToString, False)
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
        If Not ModList.SelectedItem.ToString = "" Then
            Dim selectedFile = Path + "\" + SubDirectoriesList.SelectedItem + "\" + ModList.SelectedItem.ToString
            If My.Computer.FileSystem.FileExists(selectedFile) Then
                Try
                    My.Computer.FileSystem.DeleteFile(selectedFile)
                    Call Collection_FolderView_LoadManager()
                Catch ex As Exception
                    MsgBox("Failed to delete file: " + ModList.SelectedItem.ToString + "Maybe it's already been deleted? Try Clicking the refresh button.")
                End Try
            End If
        Else
            MsgBox("Please select an item to delete.")
        End If
    End Sub

    Private Sub EditFile_Click(sender As Object, e As EventArgs) Handles EditFile.Click
        If Not ModList.SelectedItem.ToString = "" Then
            Dim SelectedFile As String = Path + "\" + SubDirectoriesList.SelectedItem + "\" + ModList.SelectedItem.ToString
            Process.Start(SelectedFile)
        Else
            MsgBox("Please select an item to edit it.")
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
        If Not CollectionView.Enabled = False Then
            CollectionView.Enabled = False
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
End Class