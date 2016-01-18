Public Class Form1
    Public customerModPath
    Public filename
    Public copytopath
    Public tomodsfolder
    Public appdata
    Public gotosite



    Public Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream

        Dim tomodsfolder As String = "\.minecraft\mods\"



        strm = OpenFileDialog1.OpenFile()
        TextBox1.Text = OpenFileDialog1.FileName.ToString()
        customerModPath = TextBox1.Text
        '    Dim filename As String = OpenFileDialog1.FileName
        If Not (strm Is Nothing) Then
            'insert code to read the file data
            strm.Close()
            '  MessageBox.Show("mod file selected")
        End If



        ' MessageBox.Show(FileInfo.Name)




    End Sub

    Private Sub BrowseButton1_Click(ByVal sender As System.Object, e As System.EventArgs) Handles BrowseButton1.Click
        OpenFileDialog1.Title = "Please Select a File"

        OpenFileDialog1.InitialDirectory = "C:"


        '   MessageBox.Show(OpenFileDialog1.ShowDialog)





        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub BrowseButton1_Paint(sender As Object, e As PaintEventArgs) Handles BrowseButton1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://minecraft-mod-installer.weebly.com")
        Dim gotosite As Object = System.Diagnostics.Process.Start("http://minecraft-mod-installer.weebly.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Console.WriteLine("ApplicationData := " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))

        Dim AppData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        '    MessageBox.Show(AppData)
    End Sub
    Class Sample
        '   Public Shared Sub Main()


    End Class




    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim appdata As Object
        Console.WriteLine()
        'Console.WriteLine("GetFolderPath: {0}",
        appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        '   MessageBox.Show(appdata)

        'My.Computer.FileSystem.CopyFile("C:\Users\Finlays\Desktop\does it work\well hi.jar", myfolder & "\.minecraft\mods\well hi.jar",


        'this gets the filename and extension e.g. readme.txt

        Dim FileInfo As New IO.FileInfo(customerModPath)        'Dim minecraftModName As String
        ' minecraftModName = tomodsfolder + FileInfo

        Dim copytopath As String
        '    MessageBox.Show(appdata)
        '  MessageBox.Show(tomodsfolder)
        '    MessageBox.Show(FileInfo.Name)
        copytopath = appdata & "\.minecraft\mods\"
        copytopath = copytopath & FileInfo.Name



        'below is the copy to command, which should find the path to the users selected file; then "copytopath" adds appdata, .minecraft\mods & then adds the files name on the end of the path so that the file is not renamed.

        My.Computer.FileSystem.CopyFile(customerModPath, copytopath, 'file name missing
             FileIO.UIOption.AllDialogs,
             FileIO.UICancelOption.ThrowException)

        MessageBox.Show("Done!")

        Close()


    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'MessageBox.Show("Come Back Soon!")
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'MessageBox.Show("text entered here will do nothing...")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class