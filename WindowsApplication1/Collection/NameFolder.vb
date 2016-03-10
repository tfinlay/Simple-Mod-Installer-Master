Public Class NameFolder
    Public Path As String = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection
    Private Sub NameFolder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FolderView.Enabled = True
        FolderView.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Contains("'") Or TextBox1.Text.Contains("&") Or TextBox1.Text.Contains("%") Or TextBox1.Text.Contains("$") Or TextBox1.Text.Contains("#") Or TextBox1.Text.Contains("@") Or TextBox1.Text.Contains("!") Or TextBox1.Text.Contains("*") Or TextBox1.Text.Contains("~") Or TextBox1.Text.Contains("`") Or TextBox1.Text.Contains(".") Or TextBox1.Text.Contains(",") Or TextBox1.Text.Contains("/") Or TextBox1.Text.Contains("\") Or TextBox1.Text.Contains("|") Then
            MsgBox("The name of a folder can not contain any of the following characters: ', &, %, $, #, @, !, *, ~, `, . , \, /, | or ,")
        ElseIf My.Computer.FileSystem.DirectoryExists(Path + "\" + TextBox1.text) Then
            MsgBox("A folder by this name already exists, please choose another name")
        Else
            Try
                My.Computer.FileSystem.CreateDirectory(Path + "\" + TextBox1.Text)
                Call FolderView.Collection_FolderView_LoadManager()
                Close()
            Catch ex As Exception
                MsgBox("An error occured and the folder may not have been created.")
            End Try
        End If
    End Sub
End Class