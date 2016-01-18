Public Class Form1
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream









        strm = OpenFileDialog1.OpenFile()

        TextBox1.Text = OpenFileDialog1.FileName.ToString()

        If Not (strm Is Nothing) Then

            'insert code to read the file data

            strm.Close()

            MessageBox.Show("mod file selected")

        End If
    End Sub

    Private Sub BrowseButton1_Click(ByVal sender As System.Object, e As System.EventArgs) Handles BrowseButton1.Click
        OpenFileDialog1.Title = "Please Select a File"

        OpenFileDialog1.InitialDirectory = "C:"








        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub BrowseButton1_Paint(sender As Object, e As PaintEventArgs) Handles BrowseButton1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://tfff1spacks.weebly.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Console.WriteLine("ApplicationData := " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))

        Dim AppData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        MessageBox.Show(AppData)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Environ("USERPROFILE")
        My.Computer.FileSystem.MoveFile("C:\Users\Finlays\Desktop\does it work\well hi!.jar",
   "Environment.SpecialFolder.ApplicationData\roaming\.minecraft\mods\well hi!.jar",
    FileIO.UIOption.AllDialogs,
    FileIO.UICancelOption.ThrowException)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class
