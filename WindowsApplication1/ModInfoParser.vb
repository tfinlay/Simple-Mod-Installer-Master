Imports Newtonsoft.Json
Imports System.IO

Module ModInfoParser
    Public Function parseModInfo(locationOfInfo As String)
        Dim Modid
        Dim Name
        Dim Desc
        Dim Version

        Using reader As New JsonTextReader(New StringReader(File.ReadAllText(locationOfInfo)))
            Dim line = File.ReadAllLines(locationOfInfo).Count
            Dim previousValue As String
            While line > 0

                reader.Read()

                If previousValue = "modid" Then
                    Modid = reader.Value.ToString
                ElseIf previousValue = "name" Then
                    Name = reader.Value.ToString
                ElseIf previousValue = "description" Then
                    Desc = reader.Value.ToString
                ElseIf previousValue = "version" Then
                    Version = reader.Value.ToString
                End If
                line = line - 1
                previousValue = reader.Value
            End While

        End Using

        Dim toReturnArray = {Modid, Name, Desc, Version}

        testmsg(toReturnArray.ToString())
    End Function

    Function checkEven(a)
        'Dim b As Integer
        Dim ca As Integer
        'b = a.Next(0, 10)
        'Debug.Print(b)

        ca = a Mod 2

        If ca = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
