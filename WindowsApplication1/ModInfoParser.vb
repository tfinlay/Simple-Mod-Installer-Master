Imports Newtonsoft.Json
Imports System.IO

Module ModInfoParser
    Public Function parseModInfo(locationOfInfo As String)

        Using reader As New JsonTextReader(New StringReader(File.ReadAllText(locationOfInfo)))
            Dim line = File.ReadAllLines(locationOfInfo).Count
            Dim previousValue As String
            While line > 0

                reader.Read()

                If line > 16 Then

                ElseIf checkEven(line) = True Then
                    testmsg(previousValue + " : " + reader.Value)
                Else

                End If
                line = line - 1
                previousValue = reader.Value
            End While

        End Using

        'Dim jsonData As String = File.ReadAllText(locationOfInfo)
        'Dim Data = JsonConvert.DeserializeObject(jsonData)
        'Dim ArrayReturn = Data.Parse().selectToken("name")
        'testmsg(ArrayReturn)
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
