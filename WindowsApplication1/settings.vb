Imports System.IO
Imports System
Imports System.Text
Public Class settings
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://minecraft-mod-installer.weebly.com")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MessageBox.Show(Label2.Text)
        'Label2.Text = "You clicked ME!"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.compareTitles = CompareCollectionTitles.Checked
        My.Settings.showUnreachables = showunreachables.Checked
        My.Settings.sortLists = SortBoxes.Checked
        EntryMenu.Show()
        My.Settings.Backup_path = TextBox1.Text.ToString
        My.Settings.checkForUpdates = CheckBox1.Checked
        My.Settings.Save()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If

savebackuppath:
        Dim FILE_NAME As String = "C:\Tfff1\Simple_MC\Backup_path.txt"

        'If System.IO.File.Exists(FILE_NAME) = True Then

        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            If Not TextBox1.Text.Contains("Simple MC World Backups") Then
                objWriter.Write(TextBox1.Text & "\Simple MC World Backups")
            Else
                objWriter.Write(TextBox1.Text)
            End If
            objWriter.Close()
        'MessageBox.Show("Backup Directory saved!")

        'Else
        'File.Create(FILE_NAME)
        'GoTo savebackuppath
        'MessageBox.Show("!!!Failed to save to file at: C:\Tfff1\Simple_MC\Backup_path.txt - Maybe it doesn't exist?")
        ' End If

    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
Load:
        If File.Exists("C:\Tfff1\Simple_MC\Backup_path.txt") Then
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\Tfff1\Simple_MC\Backup_path.txt")
            Dim stringReader As String
            stringReader = fileReader.ReadLine()
            TextBox1.Text = stringReader
            fileReader.Close()

            CheckBox1.Checked = My.Settings.checkForUpdates
        Else
            File.Create("C:\Tfff1\Simple_MC\Backup_path.txt")
            Me.Hide()
            MsgBox("ERROR: Failed to find file at: C:\Tfff1\Simple_MC\Backup_path.txt. Please restart the program to fix this issue.")
            Me.Close()
            EntryMenu.Show()
        End If
        showunreachables.Checked = My.Settings.showUnreachables
        CompareCollectionTitles.Checked = My.Settings.compareTitles
        SortBoxes.Checked = My.Settings.sortLists
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete these Collections? The process is irreversible", "Are you sure?", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            'messageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            Dim Path = "C:\Tfff1\Simple_MC\Mod_Collections"
            MessageBox.Show("The Mod Installer may restart.")
            Try
                My.Computer.FileSystem.DeleteDirectory(Path, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
                MsgBox("An Error Ocurred when deleting Collection. Maybe Something is wrong?")
            End Try

            Application.Restart()
        End If
    End Sub
End Class