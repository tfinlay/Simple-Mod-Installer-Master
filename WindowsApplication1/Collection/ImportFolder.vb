Imports System.IO

Public Class ImportFolder
    Public path As String = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            FolderPath.Text = FolderBrowserDialog1.SelectedPath

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If FolderPath.Text = "" Then
            MsgBox("Please Select a folder to import before trying to import it!")
            GoTo finish
        End If

        Enabled = False
        Try
            If Not My.Computer.FileSystem.DirectoryExists(path + "\" + IO.Path.GetDirectoryName(FolderPath.Text.ToString).ToString) Then

                Dim dirName = New DirectoryInfo(FolderPath.Text.ToString).Name

                My.Computer.FileSystem.CopyDirectory(FolderPath.Text.ToString, path + "\" + dirName)
                Enabled = True
                MsgBox("Successfully imported folder!")
                Close()
            Else
                MsgBox("A Directory by the name of the selected directory already exists. Try renaming it then importing it again.")
                Close()
            End If
        Catch
            MsgBox("An error occurred. NOT GOOD! Try again later")
        Close()
        End Try
finish:
        Close()
    End Sub


    Private Sub ImportFolder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FolderView.Enabled = True
        FolderView.Refresh_Button.PerformClick()
    End Sub

    Private Sub ImportFolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class