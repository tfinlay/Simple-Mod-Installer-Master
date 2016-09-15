Imports System.IO
Public Class Form2
    Private Sub CollectionNameBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        Me.Enabled = False
        ListBox1.Sorted = My.Settings.sortLists
        Using sr As StreamReader = New StreamReader("C:\Tfff1\Simple_MC\Mod_Collections\collections.txt")
            Dim currentline As String
            Dim totallength = File.ReadAllLines("C:\Tfff1\Simple_MC\Mod_Collections\collections.txt").Length
Scan:
            If totallength > 0 Then
                totallength = totallength - 1

                currentline = sr.ReadLine
                If currentline.Length > 0 Then
                    ListBox1.Items.Add(currentline)
                    GoTo Scan
                End If
            ElseIf totallength <= 0 Then
                Me.Enabled = True
            End If
        End Using
        Me.ResumeLayout()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            My.Settings.SelectedCollection = ListBox1.SelectedItem.ToString
            My.Settings.Save()
            Hide()
            CollectionView.Show()
            Close()
        Catch
            MsgBox("Please select a Collection before continuing")
        End Try

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form3.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Form1.Show()
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(My.Settings.websiteurl)
    End Sub
End Class