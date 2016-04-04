Public Class SelectForgeVersion
    Private Sub SelectForgeVersion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ExportToModpack.Close()
        Catch ex As Exception

        End Try
        Close()
    End Sub
End Class