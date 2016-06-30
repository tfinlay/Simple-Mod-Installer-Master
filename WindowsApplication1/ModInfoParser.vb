Imports Newtonsoft.Json
Imports System.IO
Imports Daishi.Microservices.Components.Serialisation

Module ModInfoParser
    ''' <summary>
    ''' Returns An array with information about an mcMod.info file.
    ''' The Array looks like: {Modid, Name, Desc, Version, Credits, logoFile, MCVersion, URL, UpdateURL, Authors, Parent, Screenshots, Dependencies}
    ''' </summary>
    ''' <param name="locationOfInfo"></param>
    ''' <returns></returns>
    Public Function parseModInfo(locationOfInfo As String)
        Dim Modid
        Dim Name
        Dim Desc
        Dim Version
        Dim Credits
        Dim logoFile
        Dim MCVersion
        Dim URL
        Dim UpdateURL
        Dim Authors
        Dim Parent
        Dim Screenshots
        Dim Dependencies

        Using reader As New JsonTextReader(New StringReader(File.ReadAllText(locationOfInfo)))
            Dim line = File.ReadAllLines(locationOfInfo).Count
            Dim previousValue As String
            While line > 0

                reader.Read()
                If Not reader.Value = Nothing Or Not reader.Value = "}," Or Not reader.Value = vbNullString Then
                    If previousValue = "modid" Then
                        Modid = reader.Value.ToString()
                    ElseIf previousValue = "name" Then
                        Name = reader.Value.ToString()
                    ElseIf previousValue = "description" Then
                        Desc = reader.Value.ToString()
                    ElseIf previousValue = "version" Then
                        Version = reader.Value.ToString()
                    ElseIf previousValue = "credits" Then
                        Credits = reader.Value.ToString()
                    ElseIf previousValue = "logoFile" Then
                        logoFile = reader.Value.ToString()
                    ElseIf previousValue = "mcversion" Then
                        MCVersion = reader.Value.ToString()
                    ElseIf previousValue = "url" Then
                        URL = reader.Value.ToString()
                    ElseIf previousValue = "updateUrl" Then
                        UpdateURL = reader.Value.ToString()
                    ElseIf previousValue = "authors" Then
                        Authors = reader.Value
                    ElseIf previousValue = "parent" Then
                        Parent = reader.Value.ToString()
                    ElseIf previousValue = "screenshots" Then
                        Try
                            Screenshots = reader.Value
                        Catch
                        End Try
                    ElseIf previousValue = "dependencies" Then
                        Try
                            Dependencies = reader.Value
                        Catch
                        End Try

                        GoTo Finish
                    End If
                End If
                line = line - 1
                previousValue = reader.Value
            End While
Finish:
        End Using

        Dim toReturnArray = {Modid, Name, Desc, Version, Credits, logoFile, MCVersion, URL, UpdateURL, Authors, Parent, Screenshots, Dependencies}

        Return toReturnArray
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
