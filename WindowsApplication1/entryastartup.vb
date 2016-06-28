Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class EntryMenu
    Public appdata

    Private Sub EntryMenu_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        testmsg("Test Environment is set to true!")
        appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim minecraftfolder As String
        minecraftfolder = appdata & "\.minecraft"

        'Creates a txt doc in c: \temp with the path to appdata\roaming in it
        Dim myfile As System.IO.StreamWriter

        If (Not System.IO.Directory.Exists(appdata & "\SimpleModInstaller")) Then
            System.IO.Directory.CreateDirectory(appdata & "\SimpleModInstaller")
        End If

        File.Create(appdata & "\SimpleModInstaller\appdatapath.txt").Dispose()
        myfile = My.Computer.FileSystem.OpenTextFileWriter(appdata & "\SimpleModInstaller\appdatapath.txt", True)
        myfile.WriteLine(minecraftfolder)
        myfile.Close()

        If My.Settings.checkForUpdates = True Then
            Call UpdateCheck(Me)
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MessageBox.Show("The Feature is not complete. Check back later!")
        'Technicaddmodpage_selectmodpack.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "So soon? :("
        MessageBox.Show("Come Back Soon!")
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://minecraft-mod-installer.weebly.com")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Dim appdata As Object
        Dim mcdirectory As String

        Console.WriteLine()
        'Console.WriteLine("GetFolderPath: {0}",
        appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

        mcdirectory = appdata & "\.minecraft"

        Process.Start("explorer.exe", mcdirectory)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'MessageBox.Show("This feature is W.I.P. Check Back Later!")
        world_installerOrBackup.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        settings.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        helphome.Show()
    End Sub

    Public Function UpdateCheck(sender As Object)
        My.Settings.lastupdatecheck = Date.Now
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://minecraft-mod-installer.weebly.com/uploads/2/0/2/4/20242643/simpleversion.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadLine()
        Dim currentversion As String = My.Application.Info.Version.ToString
        If newestversion.Contains(currentversion) Then
            My.Settings.updateurl = ""
            If sender Is settings Then
                sender.button4.text = "No Updates Found"
            End If
        Else
            Dim result As Integer = MessageBox.Show("There is an update available for the Simple Mod Installer. Would you like to install it?", "Update Available!", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Dim TheBrowser As Object = CreateObject("InternetExplorer.Application")
                TheBrowser.Visible = True
                TheBrowser.Navigate(sr.ReadLine)
                MsgBox("Close the Simple Mod Installer and run the newly Downloaded Version.")
            End If
        End If
    End Function

    Private Sub EntryMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Call PictureBox4_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Call PictureBox5_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Call PictureBox3_Click(Me, EventArgs.Empty)
    End Sub
End Class