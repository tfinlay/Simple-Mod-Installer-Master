Public Class Technicaddmodpage_selectmodpack
    Private Sub Technicaddmodpage_selectmodpack_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("Come Back Soon!")
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://minecraft-mod-installer.weebly.com")
    End Sub
End Class