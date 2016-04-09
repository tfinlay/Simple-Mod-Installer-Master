Imports System.IO

Public Class World_InstallerFormZip
    Public customerModPath
    Public filename
    Public copytopath
    Public tomodsfolder
    Public appdata = My.Settings.appdata
    Public gotosite
    Public unzipprocess
    Public foldername
    Public importedworldpath
    Public worldzip As String
    Public tosaves As String


    Private Sub World_InstallerFormZip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tosaves = "\.minecraft\saves"
        Dim savesfolder = appdata + tosaves
        If Not My.Computer.FileSystem.DirectoryExists(savesfolder) Then
            My.Computer.FileSystem.CreateDirectory(savesfolder)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        world_installerOrBackup.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://minecraft-mod-installer.weebly.com")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'MessageBox.Show("text entered here will do nothing...")
    End Sub


    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs)

    End Sub
    'What happens when the browse button is clicked:
    Private Sub BrowseButton1_Click(sender As Object, e As EventArgs) Handles BrowseButton1.Click
        'Dim foldername As String
        OpenFileDialog1.Title = "Please Select a World Zip File"
        OpenFileDialog1.Filter = "Zip Files (*.zip)|*.zip|All Files (*.*)|*.*"
        'OpenFileDialog1.InitialDirectory = "c:\"

        OpenFileDialog1.ShowDialog()
    End Sub

    'What happens when the Install button is click (where the magic happens):
    Private Sub Install_Click(sender As Object, e As EventArgs) Handles Install.Click
        If Not TextBox1.Text = "" Then
            tosaves = "\.minecraft\saves\"

            My.Settings.outdirec = appdata + tosaves
            My.Settings.zipdirec = TextBox1.Text
            My.Settings.Save()
            Call unzip()
        Else
            MsgBox("Please Select a File to import.")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        MessageBox.Show(foldername)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream

        strm = OpenFileDialog1.OpenFile()
        TextBox1.Text = OpenFileDialog1.FileName.ToString()
        worldzip = TextBox1.Text
        '    Dim filename As String = OpenFileDialog1.FileName
        If Not (strm Is Nothing) Then
            'insert code to read the file data
            strm.Close()
            '  MessageBox.Show("mod file selected")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tosaves = "\.minecraft\saves"
        Dim savesfolder = appdata + tosaves
        Process.Start("explorer.exe", savesfolder)
    End Sub
End Class