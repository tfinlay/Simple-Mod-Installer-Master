Imports System.IO
Public Class CollectionView
    Public ModInt As Integer
    Public ModInt2 As Integer
    Public pathToMod
    Public Path As String = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(My.Settings.websiteurl)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Hide()
        'Form2.Show()
        Close()
    End Sub

    Private Sub CollectionView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Load_Manager()
    End Sub

    Public Sub CollectionView_Refresh(sender As Object, e As EventArgs) Handles CollectionView_RefreshButton.Click
        Call Load_Manager()
    End Sub

    Sub Load_Manager()
        'Disable Changes While Loading:
        Enabled = False
        EntryMenu.Enabled = False
        ModInt = 0
        'Start Calling:

        'Check that necessary Folders still exist: If not then create them again - Only if "Safer Collections" is active.
        If My.Settings.compareTitles = True Then
            Call FolderCheck(Path)
        End If
        Call Collection_LoadMods(Me, Path, True)
        Call Collection_ReadInfo(Me, Path)
        'CompareTitles can be toggled on and off in settings: listed as "Safer Collections"
        Call Collection_CompareTitles(Me, My.Settings.compareTitles)
        'Gets Number of Mods in listbox:
        'Found At: http://stackoverflow.com/questions/12755701/vb-net-getting-each-item-in-a-listbox-and-finding-its-text-index
        For l_index As Integer = 0 To ModList.Items.Count - 1
            Dim l_text As String = CStr(ModList.Items(l_index))
            ModInt = ModInt + 1
        Next
        ModCount.Text = "Mod Count: " + ModInt.ToString

        'Enable Changes once Loading Finished:
        Text = "Edit Collection - " + Title.Text
        Button4.Text = "View Disabled Mods"
        Button2.Text = "Disable Selected"

        ModList.Sorted = My.Settings.sortLists

        Enabled = True
    End Sub

    Private Sub AddMod_Click(sender As Object, e As EventArgs) Handles AddMod.Click
        My.Settings.AddFiles_BasePath = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection + "\mods\"
        My.Settings.Save()
        Enabled = False
        AddMods.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Process.Start(Path + "\config")
    End Sub

    Private Sub DelMod_Click(sender As Object, e As EventArgs) Handles DelMod.Click
        ModInt2 = 0

        For l_index As Integer = 0 To ModList.CheckedItems.Count - 1
            Dim l_text As String = CStr(ModList.CheckedItems(l_index))

            Dim CurrentLocation As String
            Dim CurrentLocation2 As String

            If Button4.Text = "View Disabled Mods" Then
                CurrentLocation = Path + "\mods\" + l_text
                CurrentLocation2 = Path + "\mods\" + My.Settings.SelectedCollection_MCversion + "\" + l_text

            Else
                CurrentLocation = Path + "\DisabledMods\" + l_text
                CurrentLocation2 = Path + "\DisabledMods\" + My.Settings.SelectedCollection_MCversion + "\" + l_text

            End If

            If My.Computer.FileSystem.FileExists(currentLocation) Then
                    Try
                        My.Computer.FileSystem.DeleteFile(currentLocation)
                        ModInt2 = ModInt2 + 1
                    Catch
                        MsgBox("Failed to delete file: " + l_text + " maybe it doesn't exist anymore?")
                    End Try
                ElseIf File.Exists(CurrentLocation2) Then
                    Try
                        My.Computer.FileSystem.DeleteFile(CurrentLocation2)
                        ModInt2 = ModInt2 + 1
                    Catch
                        MsgBox("Failed to delete file: " + l_text + " maybe it doesn't exist anymore?")
                    End Try
                Else
                    MsgBox("Failed to find file: " + l_text + " maybe it doesn't exist anymore?")
                End If
            Next
            MsgBox("Successfully Removed " + ModInt2.ToString + " mods from collection")

            Call Load_Manager()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Enabled = False
        FolderView.Show()
    End Sub

    Private Sub CollectionView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        EntryMenu.Enabled = True
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Dim checked As Boolean = True   ' Set to True or False, as required.
        For i As Integer = 0 To ModList.Items.Count - 1
            ModList.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub RemoveAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllToolStripMenuItem.Click
        Dim checked As Boolean = True   ' Set to True or False, as required.
        For i As Integer = 0 To ModList.Items.Count - 1
            ModList.SetItemChecked(i, checked)
        Next
        DelMod.PerformClick()
    End Sub

    Private Sub DeselectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeselectAllToolStripMenuItem.Click
        Dim checked As Boolean = False   ' Set to True or False, as required.
        For i As Integer = 0 To ModList.Items.Count - 1
            ModList.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "View Disabled Mods" Then
            'Disable Changes While Loading:
            Enabled = False
            EntryMenu.Enabled = False
            'Start Calling:
            Call Collection_LoadMods(Me, Path + "\DisabledMods", False)
            'Finish Up:
            AddMod.Enabled = False
            'DelMod.Enabled = False
            Button4.Text = "View Enabled Mods"
            'Enable Changes once Loading Finished:
            Button2.Text = "Enable Selected"
            Enabled = True
        Else
            AddMod.Enabled = True
            'DelMod.Enabled = True
            Button4.Text = "View Disabled Mods"
            Call Load_Manager()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Disable Selected" Then
            ModInt2 = 0
            For l_index As Integer = 0 To ModList.CheckedItems.Count - 1
                Dim l_text As String = CStr(ModList.CheckedItems(l_index))

                Dim currentLocation As String = Path + "\mods\" + l_text
                Dim CurrentLocation2 As String = Path + "\mods\" + My.Settings.SelectedCollection_MCversion + "\" + l_text
                Dim EndLocation As String = Path + "\DisabledMods\" + l_text
                Dim EndLocation2 As String = Path + "\DisabledMods\" + My.Settings.SelectedCollection_MCversion + "\" + l_text

                If My.Computer.FileSystem.FileExists(currentLocation) Then
                    Try
                        My.Computer.FileSystem.MoveFile(currentLocation, EndLocation)
                        ModInt2 = ModInt2 + 1
                    Catch
                        MsgBox("Failed to delete file: " + l_text + " maybe it doesn't exist anymore?")
                    End Try
                ElseIf File.Exists(CurrentLocation2) Then
                    Try
                        My.Computer.FileSystem.MoveFile(CurrentLocation2, EndLocation2)
                        ModInt2 = ModInt2 + 1
                    Catch
                        MsgBox("Failed to Move file: " + l_text + " maybe it doesn't exist anymore?")
                    End Try
                Else
                    MsgBox("Failed to find file: " + l_text + " maybe it doesn't exist anymore?")
                End If
            Next
            MsgBox("Successfully Disabled " + ModInt2.ToString + " mods from collection")
            Call Load_Manager()
        Else
            'If it says Enable Selected
            ModInt2 = 0
            For l_index As Integer = 0 To ModList.CheckedItems.Count - 1
                Dim l_text As String = CStr(ModList.CheckedItems(l_index))

                Dim currentLocation As String = Path + "\DisabledMods\" + l_text
                Dim CurrentLocation2 As String = Path + "\DisabledMods\" + My.Settings.SelectedCollection_MCversion + "\" + l_text
                Dim EndLocation As String = Path + "\Mods\" + l_text
                Dim EndLocation2 As String = Path + "\Mods\" + My.Settings.SelectedCollection_MCversion + "\" + l_text

                If My.Computer.FileSystem.FileExists(currentLocation) Then
                    Try
                        My.Computer.FileSystem.MoveFile(currentLocation, EndLocation)
                        ModInt2 = ModInt2 + 1
                    Catch
                        MsgBox("Failed to delete file: " + l_text + " maybe it doesn't exist anymore?")
                    End Try
                ElseIf File.Exists(CurrentLocation2) Then
                    Try
                        My.Computer.FileSystem.MoveFile(CurrentLocation2, EndLocation2)
                        ModInt2 = ModInt2 + 1
                    Catch
                        MsgBox("Failed to Move file: " + l_text + " maybe it doesn't exist anymore?")
                    End Try
                Else
                    MsgBox("Failed to find file: " + l_text + " maybe it doesn't exist anymore?")
                End If
            Next
            MsgBox("Successfully Enabled " + ModInt2.ToString + " mods from collection")
            Call Load_Manager()
        End If

    End Sub

    Private Sub ActivateCollection_Click(sender As Object, e As EventArgs) Handles Activate.Click
        '!!!!!!!!!!!!!!!!!!!!!!!!!!
        '!ACTIVATES THE COLLECTION!
        '!!!!!!!!!!!!!!!!!!!!!!!!!!
        Enabled = False
        Activation.Show()

        Call ActivateCollection(Activation)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("This has not been added yet - sorry!")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Enabled = False
        ExportToModpack.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete this collection? The process is irreversible", "Are you sure?", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            'messageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            MessageBox.Show("The Mod Installer may restart.")
            Try
                My.Computer.FileSystem.DeleteDirectory(Path, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
                MsgBox("An Error Ocurred when deleting Collection. Maybe Something is wrong?")
            End Try

            Try
                My.Computer.FileSystem.DeleteFile("C:\Tfff1\Simple_MC\Mod_Collections\collections.txt")
            Catch ex As Exception
                MsgBox("Failed to delete File: collections.txt, please navigate to C:\Tfff1\Simple_MC\Mod_Collections and delete collections.txt to resolve this error")
            End Try

            Application.Restart()

        End If
    End Sub

    Private Sub DisplayModInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayModInfoToolStripMenuItem.Click
        If Not ModList.SelectedItems.Count > 1 Then

        Else
            MsgBox("ERROR: You can only select one Mod at a time for Information Viewing.")
        End If
    End Sub
End Class