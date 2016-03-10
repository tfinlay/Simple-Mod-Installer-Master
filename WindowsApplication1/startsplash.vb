Imports System.IO
Imports System.Net
Public NotInheritable Class startsplash
    Private Async Sub startsplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bar1.Visible = False
        Label2.Visible = False

        If Not Directory.Exists("c:\Tfff1") Then
            Directory.CreateDirectory("c:\Tfff1")
        End If

        If Not Directory.Exists("c:\Tfff1\Simple_MC") Then
            Directory.CreateDirectory("c:\Tfff1\Simple_MC")
        End If

        If Not File.Exists("C:\Tfff1\Simple_MC\Backup_path.txt") Then
            File.Create("C:\Tfff1\Simple_MC\Backup_path.txt")
        End If

        If Not Directory.Exists("C:\Tfff1\Simple_MC\Mod_Collections") Then
            Directory.CreateDirectory("C:\Tfff1\Simple_MC\Mod_Collections")
        End If

        If File.Exists("C:\Tfff1\Simple_MC\Mod_Collections\collections.txt") Then
            File.Delete("C:\Tfff1\Simple_MC\Mod_Collections\collections.txt")
        End If

        'Scans Mod_Collections for folders - Overwrites collections.txt with the results.
        Call Collection_FolderScan(Me, "C:\Tfff1\Simple_MC\Mod_Collections", False, "C:\Tfff1\Simple_MC\Mod_Collections\collections.txt", True)


        '    If (Not System.IO.File.Exists("c:\Tfff1\Simple_MC\WorldBackup.exe")) Then
        '        My.Computer.Network.DownloadFile(
        '"http//drive.google.com / uc?export=download&id=0BzZlcNkakawtem5xZGdZRzlfR0E",
        '"C:\Tfff1\Simple_MC\WorldBackup.exe")
        '    Else

        'End If

        My.Settings.appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        My.Settings.Save()

        If (Not System.IO.File.Exists("c:\Tfff1\Simple_MC\WorldBackup.exe")) And My.Computer.Network.IsAvailable Then
            Bar1.Visible = True
            Label2.Visible = True
            Dim client As WebClient = New WebClient
            'AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            client.DownloadFileAsync(New Uri("http://drive.google.com/uc?export=download&id=0BzZlcNkakawtem5xZGdZRzlfR0E"), "C:\Tfff1\Simple_MC\WorldBackup.exe")
        End If
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        Bar1.Value = Integer.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Bar1.Value = 100
        MessageBox.Show("Additional Features Downloaded & Installed Successfully!")
    End Sub

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).




End Class
