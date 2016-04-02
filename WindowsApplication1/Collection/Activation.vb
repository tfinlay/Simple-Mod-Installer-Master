Public Class Activation
    Public PermittedClose As Boolean
    Public closeAttempts As Integer = 0
    Private Sub Activation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not PermittedClose = True Then
            e.Cancel = True

            If Not closeAttempts = 2 Then
                closeAttempts = closeAttempts + 1
            Else
                Label3.Show()
            End If
        Else
            CollectionView.Enabled = True
        End If
    End Sub

    Private Sub Activation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class