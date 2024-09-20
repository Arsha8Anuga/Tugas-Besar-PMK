

Public Class Form2

    Private userId As String = "1"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim result As KeyValuePair(Of Integer, Object) = DBReadUser(userId)

        If result.Key = 0 Then
            Dim userData As List(Of Dictionary(Of String, Object)) = CType(result.Value, List(Of Dictionary(Of String, Object)))


            Dim user As Dictionary(Of String, Object) = userData.FirstOrDefault()

            If user IsNot Nothing Then
                Dim userInfo As String = $"ID: {user("id")}, Email: {user("email")}, Username: {user("username")}, Password: {user("user_password")}"
                Label1.Text = userInfo
            End If
        Else
            Label1.Text = $"Error: {result.Value}"
        End If

    End Sub
End Class