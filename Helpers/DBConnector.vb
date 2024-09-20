Imports System.Linq
Imports MySql.Data.MySqlClient

Module DBConnector

    Private ReadOnly envSearch As String = "database"
    Public Function DBStartUp(filePath As String, Optional query As String = Nothing) As KeyValuePair(Of Integer, String)

        Dim dbEnv As Dictionary(Of String, List(Of String)) = FileHandler.IniReader(filePath, envSearch)


        If dbEnv.Count > 0 AndAlso dbEnv.ContainsKey(envSearch) Then

            Dim dbKeyVal As KeyValuePair(Of String, List(Of String)) = dbEnv.First()


            If dbKeyVal.Value.Count = 4 Then

                'Dim concat As String = dbKeyVal.Value(0) & dbKeyVal.Value(1) & dbKeyVal.Value(2) & dbKeyVal.Value(3)
                'Return New KeyValuePair(Of Integer, String)(0, concat)

                Dim connectionStr As String = $"Server={dbKeyVal.Value(0)};Database={dbKeyVal.Value(1)};User ID={dbKeyVal.Value(2)};Password={dbKeyVal.Value(3)};"

                Using getConnection As New MySqlConnection(connectionStr)

                    Try
                        getConnection.Open()

                        If Not String.IsNullOrWhiteSpace(query) Then

                            Using command As New MySqlCommand(query, getConnection)

                                command.ExecuteNonQuery()

                            End Using

                        End If

                        Return New KeyValuePair(Of Integer, String)(0, "Success")

                    Catch ex As MySqlException

                        Return New KeyValuePair(Of Integer, String)(ex.Number, ex.Message)

                    End Try

                End Using

            End If

        End If

        Return New KeyValuePair(Of Integer, String)(-1, "Configuration not valid or not found.")

    End Function

End Module
