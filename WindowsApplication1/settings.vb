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

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write(TextBox1.Text & "\Simple MC World Backups")
            objWriter.Close()
            'MessageBox.Show("Backup Directory saved!")

        Else
            File.Create(FILE_NAME)
            GoTo savebackuppath
            'MessageBox.Show("!!!Failed to save to file at: C:\Tfff1\Simple_MC\Backup_path.txt - Maybe it doesn't exist?")
        End If

    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\Tfff1\Simple_MC\Backup_path.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        TextBox1.Text = stringReader
        fileReader.Close()

        CheckBox1.Checked = My.Settings.checkForUpdates

    End Sub
End Class