Imports System.IO
Imports System.Text.Json

Public Class SessionManager

    Public Function GenerateSession(userData As List(Of Dictionary(Of String, Object))) As Boolean

        Try

            Dim sessionData As New Dictionary(Of String, Object)()

            sessionData.Add("userData", userData)
            sessionData.Add("expirationTime", DateTime.Now.AddHours(ConstantManagement.SESSION_TIME))


            Dim jsonString As String = JsonSerializer.Serialize(sessionData)


            File.WriteAllText(ConstantManagement.SESSION_FILE_PATH, jsonString)

            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function


    Public Function ReadSession() As List(Of Dictionary(Of String, Object))
        Dim sessionData As New Dictionary(Of String, Object)()

        Try
            Dim jsonString As String = File.ReadAllText(ConstantManagement.SESSION_FILE_PATH)
            sessionData = JsonSerializer.Deserialize(Of Dictionary(Of String, Object))(jsonString)


            Dim expirationElement As JsonElement = CType(sessionData("expirationTime"), JsonElement)
            Dim expirationTimeString As String = expirationElement.GetString()
            Dim expirationTime As DateTime

            If Not DateTime.TryParse(expirationTimeString, expirationTime) Then
                Throw New Exception("Invalid expiration time format.")
            End If


            If DateTime.Now >= expirationTime Then
                File.Delete(ConstantManagement.SESSION_FILE_PATH)
                Return Nothing
            End If


            If sessionData.ContainsKey("userData") AndAlso TypeOf sessionData("userData") Is JsonElement Then
                Dim userDataElement As JsonElement = CType(sessionData("userData"), JsonElement)
                Return JsonSerializer.Deserialize(Of List(Of Dictionary(Of String, Object)))(userDataElement.ToString())
            End If

        Catch ex As Exception
            Console.WriteLine("Error reading session: " & ex.Message)
        End Try

        Return Nothing
    End Function


End Class
