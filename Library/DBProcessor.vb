Module DBProcessor

    Public Function DBReadUser(idRef As String, Optional column As String() = Nothing) As KeyValuePair(Of Integer, Object)

        Dim tableColumn As New List(Of String)()

        If column IsNot Nothing Then
            For i As Integer = 0 To column.Length - 1

                If ConstantManagement.UserTableColumn.Value.Contains(column(i)) Then

                    tableColumn.Add(column(i))

                End If

            Next
        End If

        If tableColumn.Count = 0 Then

            tableColumn.Add("*")

        End If

        Dim query As String = $"SELECT {String.Join(", ", tableColumn)} FROM user_table WHERE id = {idRef}"


        Dim result As KeyValuePair(Of Integer, Object) = DBConnector.DBStartUp(ConstantManagement.SETTING_FILE_PATH, query)

        If result.Key = 0 Then

            Dim results As List(Of Dictionary(Of String, Object)) = CType(result.Value, List(Of Dictionary(Of String, Object)))

            Return New KeyValuePair(Of Integer, Object)(0, results)
        Else

            Return New KeyValuePair(Of Integer, Object)(result.Key, result.Value)
        End If

    End Function

End Module
