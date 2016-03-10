Imports System.IO
Public Class CollectionView
    Public pathToMod
    Public Path As String = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(My.Settings.websiteurl)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form2.Show()
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

        'Start Calling:
        Call Collection_LoadMods(Me, Path)
        Call Collection_ReadInfo(Me, Path)
        'CompareTitles can be toggled on and off in settings: listed as "Safer Collections"
        Call Collection_CompareTitles(Me, My.Settings.compareTitles)

        'Enable Changes once Loading Finished:
        Enabled = True
    End Sub

    Private Sub AddMod_Click(sender As Object, e As EventArgs) Handles AddMod.Click
        Enabled = False
        AddMods.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(Path + "\config")
    End Sub
End Class