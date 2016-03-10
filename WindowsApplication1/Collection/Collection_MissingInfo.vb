Imports System.IO
Public Class Collection_MissingInfo
    Public Path As String = "C:\Tfff1\Simple_MC\Mod_Collections\" + My.Settings.SelectedCollection
    Public InfoLoc = Path + "\mods\" + My.Settings.SelectedCollection + ".CollectionInfo"
    Private Sub Collection_MissingInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CollectionName.Text = My.Settings.SelectedCollection
        If File.Exists(InfoLoc) Then
            File.Delete(InfoLoc)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Call StringWriter(InfoLoc, My.Settings.SelectedCollection, True)
        Call StringWriter(InfoLoc, TextBox1.Text, True)

        Hide()
        CollectionView.Show()
        Call CollectionView.CollectionView_Refresh(Me, Nothing)
        CollectionView.Enabled = True
        Close()
    End Sub
End Class