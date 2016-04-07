Imports System.IO
Imports System.IO.Compression
Public Class ExportToModpack
    Public TrimmedFileName As String
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://files.minecraftforge.net/")
    End Sub

    Private Sub ExportToModpack_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CollectionView.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()


        fd.Title = "Please Select a mod file to add to your collection"
        fd.InitialDirectory = "C:\"
        If My.Settings.AddFiles_BasePath = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection + "\mods\" Then
            fd.Filter = "Mod Files (*.jar,*.zip,*.litemod)|*.jar;*.zip;*.litemod"
        Else
            'fd.Filter = "All Files (*.*)|*.*"
            fd.Filter = "Forge Universal Files|*.jar"
        End If

        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            JarPath.Text = fd.FileName

            Call pathTrimmer(Me, fd.FileName)
            'Returns TrimmedFileName

        End If
    End Sub

    ''' <summary>
    ''' Load Manager - Loads the Export to Modpack Page - resets folder sorting columns
    ''' </summary>
    Public Sub LoadManager()
        Call FolderScan(CollectionView.Path)
    End Sub

    Public Sub FolderScan(basedirectory)

        Dim subDir = ""

        For Each drvs In Directory.GetDirectories(basedirectory)

            Dim filePath As String = drvs
            Dim directory As String = Path.GetDirectoryName(filePath)

            Dim split As String() = filePath.Split("\")
            subDir = split(split.Length - 1)

            'SubDirectoriesList.Items.Add(subDir)

            If subDir = "saves" Or subDir = "DisabledMods" Then
                ExcludedFoldersList.Items.Add(subDir)
                'testmsg("Excluding Folder:" + subDir)
            Else
                IncludedFoldersList.Items.Add(subDir)
                'testmsg("Including Folder:" + subDir)
            End If
        Next
    End Sub
    '!!!!!!!!!!!!!!!!!!!!!!!!!!!
    '!!EXPORT BUTTON CODE HERE!!
    '!!!!!!!!!!!!!!!!!!!!!!!!!!!
    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        Enabled = False
        Call ExportCollection(1)
    End Sub

    Public Sub ExportCollection(stage As Integer)
        If Not stage = 1 Then
            If stage = 2 Then
                GoTo Stage2
            Else
                MsgBox("ERROR: Stage is:" + stage.ToString + " when only 1 or 2 are accepted - Something Is Wrong! - Export Cancelled")
                Enabled = True
                Close()
            End If
        End If

        If Not JarPath.Text.ToString = "" Then

            'Set up the Temporary Environment:
            If Not My.Computer.FileSystem.DirectoryExists("C:\Tfff1\Simple_MC\Mod_Collections_Export") Then
                My.Computer.FileSystem.CreateDirectory("C:\Tfff1\Simple_MC\Mod_Collections_Export")
            Else
                My.Computer.FileSystem.DeleteDirectory("C:\Tfff1\Simple_MC\Mod_Collections_Export", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory("C:\Tfff1\Simple_MC\Mod_Collections_Export")
            End If

            My.Computer.FileSystem.CreateDirectory("C:\Tfff1\Simple_MC\Mod_Collection_export\bin")

            Try
                My.Computer.FileSystem.CopyFile(JarPath.Text.ToString, "C:\Tfff1\Simple_MC\Mod_Collection_export\bin\modpack.jar", True)
            Catch ex As Exception
                MsgBox("Failed to copy Universal Forge Jar. Something is horribly wrong, try again later")
                'GoTo finish
            End Try

            For l_index As Integer = 0 To IncludedFoldersList.Items.Count - 1
                Dim l_text As String = CStr(IncludedFoldersList.Items(l_index))
                Try
                    My.Computer.FileSystem.CopyDirectory(CollectionView.Path.ToString + "\" + l_text, "C:\Tfff1\Simple_MC\Mod_Collections_Export\" + l_text)
                Catch ex As Exception
                    Enabled = True
                    MsgBox("An Error Occurred when copying Folder: " + CollectionView.Path.ToString + "\" + l_text + "to: " + "C:\Tfff1\Simple_MC\Mod_Collections_Export\" + l_text + ". Export has been Cancelled, please try again later.")
                    Close()
                End Try
            Next
            'Show Save File Dialog, Code Skips down to FileOK - BELOW
            SaveFileDialog1.ShowDialog()
            GoTo finish
        Else
            MsgBox("Please Select a Universal Forge Jar before continuing!")
        End If
Stage2: 'Cleans up the Directory after the Collection has been exported:
            Try
                My.Computer.FileSystem.DeleteDirectory("C:\Tfff1\Simple_MC\Mod_Collections_Export", FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
            MsgBox("WARNING: Cleanup Failed - This may cause problems later")
        End Try
finish:
        Enabled = True
        MsgBox("Done!")
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim outpath As String = SaveFileDialog1.FileName
        testmsg("Outpath = " + outpath)
Check:
        If Not My.Computer.FileSystem.FileExists("C:\Tfff1\Simple_MC\Mod_Collection_export\bin\modpack.jar") Then
            GoTo Check
        End If

        ZipFile.CreateFromDirectory("C:\Tfff1\Simple_MC\Mod_Collections_Export", outpath)
        Call ExportCollection(2)

    End Sub

    Private Sub ExportToModpack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadManager()
    End Sub

    Private Sub IncludeButton_Click(sender As Object, e As EventArgs) Handles IncludeButton.Click
        'From: http://stackoverflow.com/questions/12755701/vb-net-getting-each-item-in-a-listbox-and-finding-its-text-index
        For l_index As Integer = 0 To ExcludedFoldersList.CheckedItems.Count - 1
            Dim l_text As String = CStr(ExcludedFoldersList.CheckedItems(l_index))

            IncludedFoldersList.Items.Add(l_text.ToString)
            HiddenListBox.Items.Add(l_text.ToString)
        Next

        For l_index As Integer = 0 To HiddenListBox.Items.Count - 1
            Dim l_text As String = CStr(HiddenListBox.Items(l_index))
            ExcludedFoldersList.Items.Remove(l_text.ToString)
        Next
        HiddenListBox.Items.Clear()
    End Sub

    Private Sub ExcludeButton_Click(sender As Object, e As EventArgs) Handles ExcludeButton.Click
        'From: http://stackoverflow.com/questions/12755701/vb-net-getting-each-item-in-a-listbox-and-finding-its-text-index
        For l_index As Integer = 0 To IncludedFoldersList.CheckedItems.Count - 1
            Dim l_text As String = CStr(IncludedFoldersList.CheckedItems(l_index))

            ExcludedFoldersList.Items.Add(l_text.ToString)
            HiddenListBox.Items.Add(l_text.ToString)
        Next

        For l_index As Integer = 0 To HiddenListBox.Items.Count - 1
            Dim l_text As String = CStr(HiddenListBox.Items(l_index))
            IncludedFoldersList.Items.Remove(l_text.ToString)
        Next
        HiddenListBox.Items.Clear()
    End Sub
End Class