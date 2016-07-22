Imports System.IO.Compression
Public Class ModInfo
    Public ModInfo
    Public Workspace = "C:\Tfff1\Simple_MC\Mod_Info_Finder\Mod_Data\"
    Public screenshots As Array

    Private Sub ModInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory(Workspace)

        'Extract Mod File
        My.Settings.zipdirec = My.Settings.ModFile
        My.Settings.outdirec = Workspace
        My.Settings.Save()
        ZipFile.ExtractToDirectory(My.Settings.ModFile, Workspace)


        IO.File.AppendAllText(Workspace + "\installerInfo.json", "{""collectionMCVersion"": """ + My.Settings.SelectedCollection_MCversion + """}")

        'Get the Info:
        If My.Computer.FileSystem.FileExists(Workspace + "mcmod.info") Then
            ' Ensure that ScriptErrorsSuppressed is set to false.
            WebBrowser1.ScriptErrorsSuppressed = True

            WebBrowser1.Navigate("file:///C:/Tfff1/Simple_MC/Mod_Info_Finder/modInfo.html")
        Else
            MsgBox("Sorry, couldn't find a Mod Information File for this mod.")
            Close()
        End If


    End Sub

    Private Sub ModInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        WebBrowser1.Dispose()
        CollectionView.Enabled = True
    End Sub

    Private Sub modURL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 
        Process.Start(ModInfo(7))
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub browser_DocumentCompleted(ByVal sender As Object,
ByVal e As WebBrowserDocumentCompletedEventArgs)

        AddHandler CType(sender, WebBrowser).Document.Window.Error,
            AddressOf Window_Error

    End Sub

    Private Sub Window_Error(ByVal sender As Object,
    ByVal e As HtmlElementErrorEventArgs)

        ' Ignore the error and suppress the error dialog box. 
        e.Handled = True

    End Sub
End Class