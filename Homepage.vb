Public Class Homepage
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Createdata.Show()
        Me.Hide()
    End Sub

    Private Sub btnactivity_Click(sender As Object, e As EventArgs) Handles btnactivity.Click
        Logactivity.Show()
        Me.Hide()
    End Sub
End Class