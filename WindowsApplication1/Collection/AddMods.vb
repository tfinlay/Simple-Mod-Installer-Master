Public Class AddMods
    Public TrimmedFileName As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SingleAdd.Checked = True Then
            'Enable Singleadd
            SingleBrowse.Enabled = True
            SinglePath.Enabled = True

            FolderBrowse.Enabled = False
            FolderPath.Enabled = False
            ModList.Enabled = False
        ElseIf FolderAdd.Checked = True Then
            'Enable Folderadd
            FolderBrowse.Enabled = True
            FolderPath.Enabled = True
            ModList.Enabled = True

            SingleBrowse.Enabled = False
            SinglePath.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Dim BasePath As String = My.Settings.AddFiles_BasePath

        Enabled = False
        Dim modcount = 0
        If SingleAdd.Checked = True Then

            If Not SinglePath.Text = "" Then
                If Not My.Computer.FileSystem.FileExists(BasePath + TrimmedFileName) Then
                    My.Computer.FileSystem.CopyFile(SinglePath.Text, BasePath + TrimmedFileName)
                    modcount = modcount + 1

                    'Done
                    MsgBox("Successfully added " + modcount.ToString + " file to your collection")
                    Close()
                Else
                    MsgBox("The selected file already exists in your collection.")
                End If
            Else
                MsgBox("Please select a file to add before continuing.")
            End If

        ElseIf FolderAdd.Checked = True Then
            If Not FolderPath.Text = "" Then

                For l_index As Integer = 0 To ModList.Items.Count - 1
                    Dim l_text As String = CStr(ModList.Items(l_index))
                    Dim FinishedPath
                    Dim CurrentPath

                    CurrentPath = FolderPath.Text + "\" + l_text

                    If My.Computer.FileSystem.FileExists(CurrentPath) Then
                        FinishedPath = BasePath + l_text

                        If Not My.Computer.FileSystem.FileExists(FinishedPath) Then
                            My.Computer.FileSystem.CopyFile(CurrentPath, FinishedPath)
                            modcount = modcount + 1
                        Else
                            MsgBox("File: " + l_text + " could not be added because it already exists in your collection.")
                        End If

                    Else
                        CurrentPath = FolderPath.Text + "\" + My.Settings.SelectedCollection_MCversion + "\" + l_text
                        FinishedPath = BasePath + My.Settings.SelectedCollection_MCversion + "\" + l_text
                        Try
                            My.Computer.FileSystem.CopyFile(CurrentPath, FinishedPath)
                            modcount = modcount + 1
                        Catch
                            MsgBox("Failed to copy file:" + CurrentPath + "to new location as: " + FinishedPath)
                        End Try
                    End If


                Next

                MsgBox("Successfully added " + modcount.ToString + " file(s) to your collection")
                Close()


            Else
                MsgBox("Please select a folder to get files from")
            End If
        Else
            MsgBox("Please select either a folder of files or a file to add to your collection before continuing.")
        End If

        Enabled = True
    End Sub

    Private Sub SingleBrowse_Click(sender As Object, e As EventArgs) Handles SingleBrowse.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()


        fd.Title = "Please Select a mod file to add to your collection"
        fd.InitialDirectory = "C:\"
        If My.Settings.AddFiles_BasePath = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection + "\mods\" Then
            fd.Filter = "Mod Files (*.jar,*.zip,*.litemod)|*.jar;*.zip;*.litemod"
        Else
            'fd.Filter = "All Files (*.*)|*.*"
            fd.Filter = "All Files (*.*)|*.*|Mod Files (*.jar,*.zip,*.litemod)|*.jar;*.zip;*.litemod|Config Files (*.cfg)|*.cfg|Image Files (*.png,*.jpg,*.gif)|*.png;*.jpg;*.gif|Minecraft Sound Files (*.ogg)|*.ogg|Schematic Files (*.schematic)|*.schematic|iChun's Hats mod Files (*.tc2,*.md5)|*.tc2;*.md5"
        End If

        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            SinglePath.Text = fd.FileName

            Call pathTrimmer(Me, fd.FileName)


        End If
    End Sub

    Private Sub AddMods_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Not My.Settings.AddFiles_BasePath = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection + "\mods\" Then
            'FolderView is sender:
            FolderView.Enabled = True
            Hide()
            My.Settings.AddFiles_BasePath = ""
            My.Settings.Save()
            Call FolderView.Collection_FolderView_LoadManager()
            FolderView.Show()
            FolderView.Enabled = True
        Else
            'Collection View is sender:
            CollectionView.Enabled = True
            Hide()
            My.Settings.AddFiles_BasePath = ""
            My.Settings.Save()
            Call CollectionView.Load_Manager()
            CollectionView.Show()
            CollectionView.Enabled = True
        End If

    End Sub

    Private Sub FolderBrowse_Click(sender As Object, e As EventArgs) Handles FolderBrowse.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            FolderPath.Text = FolderBrowserDialog1.SelectedPath

            'If System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath).Length > 0 Then
            '    MsgBox("It appears that the selected folder contains " + System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath).Length.ToString + " other folders, please remove these folders from the directory, then select it again.")
            '    FolderPath.Text = ""
            'Else
            Call Collection_LoadMods(Me, FolderBrowserDialog1.SelectedPath, False)
            'End If


        End If
    End Sub
End Class