Imports System.IO

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
                testmsg("Excluding Folder:" + subDir)
            Else
                IncludedFoldersList.Items.Add(subDir)
                testmsg("Including Folder:" + subDir)
            End If
        Next
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click

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
End Class