Imports System.IO
Public Class Form3
    Public collectionstext As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CollectionName.TextChanged
        If CollectionName.Text.Contains("'") Or CollectionName.Text.Contains("&") Or CollectionName.Text.Contains("%") Or CollectionName.Text.Contains("$") Or CollectionName.Text.Contains("#") Or CollectionName.Text.Contains("@") Or CollectionName.Text.Contains("!") Or CollectionName.Text.Contains("*") Or CollectionName.Text.Contains("~") Or CollectionName.Text.Contains("`") Or CollectionName.Text.Contains(".") Or CollectionName.Text.Contains(",") Then
            MsgBox("You can not enter the following characters into this box: ', &, %, $, #, @, !, *, ~, `, . or ,")
            CollectionName.SelectAll()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CollectionName.Text = "Please Enter a Name for your new collection"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("The entered information has not been saved")
        Form2.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CollectionName.Text = "Please Enter a Name for your new collection" Then
            MsgBox("Please Set a unique name for your new Collection")
        Else
            'Checking if collection already exists:
            Using sr As StreamReader = New StreamReader("C:\Tfff1\Simple_MC\Mod_Collections\collections.txt")
                collectionstext = sr.ReadToEnd()
            End Using
            If collectionstext.Contains(CollectionName.Text) Then
                MsgBox("This collection already exists!")
            Else
                'Add Collection
                Enabled = False
                Using sw As StreamWriter = New StreamWriter("C:\Tfff1\Simple_MC\Mod_Collections\collections.txt", True)
                    sw.WriteLine(CollectionName.Text)
                End Using
                Dim CollectionLocation As String = "C:\Tfff1\Simple_MC\Mod_Collections\" + CollectionName.Text
                Directory.CreateDirectory(CollectionLocation)
                Directory.CreateDirectory(CollectionLocation + "\mods")
                Directory.CreateDirectory(CollectionLocation + "\config")
                Directory.CreateDirectory(CollectionLocation + "\saves")
                Directory.CreateDirectory(CollectionLocation + "\mods\" + MCversion.Text)
                'Mod Content Folders: /flan = flans mod; \customnps = Custom NPC's mod; \hats = iChun's Hats mod; \resources = ResourceLoader Mod; \mods-resourcepacks = Audio Death Mod
                Directory.CreateDirectory(CollectionLocation + "\flan")
                Directory.CreateDirectory(CollectionLocation + "\customnps")
                Directory.CreateDirectory(CollectionLocation + "\hats")
                Directory.CreateDirectory(CollectionLocation + "\mod-config")
                Directory.CreateDirectory(CollectionLocation + "\resources")
                Directory.CreateDirectory(CollectionLocation + "\mods-resourcepacks")
                Using sw As StreamWriter = New StreamWriter(CollectionLocation + "\mods\" + CollectionName.Text + ".CollectionInfo")
                    sw.WriteLine(CollectionName.Text)
                    sw.WriteLine(MCversion.Text)
                End Using
                MsgBox("Collection Created! You will now be redirected to the Collection Edit Window.")
                Hide()
                Enabled = True
                My.Settings.SelectedCollection = CollectionName.Text
                My.Settings.Save()
                CollectionView.Show()
            End If
        End If
        Close()
    End Sub
End Class