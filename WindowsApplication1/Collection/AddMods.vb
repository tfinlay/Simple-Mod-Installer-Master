Public Class AddMods
    Public TrimmedFileName As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SingleAdd.Checked = True Then
            'Enable Singleadd
            SingleBrowse.Enabled = True
            SinglePath.Enabled = True

            FolderBrowse.Enabled = False
            FolderPath.Enabled = False
            CheckedListBox1.Enabled = False
        ElseIf FolderAdd.Checked = True Then
            'Enable Folderadd
            FolderBrowse.Enabled = True
            FolderPath.Enabled = True
            CheckedListBox1.Enabled = True

            SingleBrowse.Enabled = False
            SinglePath.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SingleAdd.Checked = True Then


        ElseIf FolderAdd.Checked = True Then


        Else
            MsgBox("Please select either a folder of mods or a mod to add to your collection before continuing.")
        End If
    End Sub

    Private Sub SingleBrowse_Click(sender As Object, e As EventArgs) Handles SingleBrowse.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()


        fd.Title = "Please Select a mod file to add to your collection"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Mod Files (*.jar,*.zip,*.litemod)|*.jar;*.zip;*.litemod"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            SinglePath.Text = fd.FileName

            Call pathTrimmer(Me, fd.FileName)


        End If
    End Sub

    Private Sub AddMods_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CollectionView.Enabled = True
    End Sub
End Class