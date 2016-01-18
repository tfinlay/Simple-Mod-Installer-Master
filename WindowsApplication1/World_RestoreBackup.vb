Imports System
Imports System.IO
Public Class World_RestoreBackup
    Private Sub World_RestoreBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Backup_path = "" Then
            MsgBox("You have not set a backups directory. Set one in settings.")
            Close()
        End If

        For Each Dir As String In Directory.GetDirectories(My.Settings.Backup_path)
            CheckedListBox1.Items.Add(Dir.ToString)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("This will permanently delete your current saves folder. It is Highly recommended that you have backed it up before continuing. Are you sure you want to continue?", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Dim folderpath As String = CheckedListBox1.SelectedItem.ToString
            MsgBox(folderpath)
            Dim savespath = My.Settings.appdata + "\.minecraft\saves"
            Directory.Delete(savespath, True)
            My.Computer.FileSystem.CopyDirectory(folderpath + "\saves", savespath, True)
            MsgBox("Backup Restoration Successful!")
        End If

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemCheckState(i, CheckState.Unchecked)
        Next
        CheckedListBox1.SetItemCheckState(CheckedListBox1.SelectedIndex, CheckState.Checked)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        world_installerOrBackup.Show()
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.minecraft-mod-installer.weebly.com")
    End Sub
End Class