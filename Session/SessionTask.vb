Imports System.Threading
Imports System.Threading.Tasks
Imports System.IO

Public Class SessionTask
    Private cts As CancellationTokenSource
    Private sessionCheckerTask As Task
    Public LoginFormClass As String = ConstantManagement.LOGIN_CLASS
    Private isStopped As Boolean = False

    Public Sub StartSessionChecker()
        cts = New CancellationTokenSource()
        Dim token As CancellationToken = cts.Token

        sessionCheckerTask = Task.Run(Sub() SessionChecker(token), token)
    End Sub

    Public Sub StopSessionChecker()

        If isStopped Then
            Return
        End If

        isStopped = True
        If cts IsNot Nothing Then
            cts.Cancel()
        End If

        If sessionCheckerTask IsNot Nothing Then
            Try
                sessionCheckerTask.Wait()
            Catch ex As AggregateException

            End Try
        End If

    End Sub

    Private Function SessionChecker(token As CancellationToken) As Integer
        Dim session As New SessionManager()

        While Not token.IsCancellationRequested
            If Not File.Exists(ConstantManagement.SESSION_FILE_PATH) OrElse session.ReadSession() Is Nothing Then
                Dim result As Integer = ShowLoginForm() ' Show the login form and capture the result
                If result = 1 Then ' Check if login was successful
                    StopSessionChecker() ' Stop the session checker
                End If
                Exit While
            End If

            Thread.Sleep(2000) ' Regular check delay
        End While

        Return -1
    End Function

    Private Function ShowLoginForm() As Integer
        Dim result As Integer = 0

        If Form.ActiveForm IsNot Nothing Then
            Form.ActiveForm.Invoke(Sub()
                                       CloseAllFormsExceptMain()

                                       Dim loginType As Type = Type.GetType(LoginFormClass)
                                       If loginType IsNot Nothing Then
                                           Dim loginForm As Form = CType(Activator.CreateInstance(loginType), Form)

                                           If loginForm.ShowDialog() = DialogResult.OK Then
                                               result = 1
                                           End If
                                       Else
                                           MsgBox("Login form type not found: " & LoginFormClass)
                                       End If
                                   End Sub)
        End If

        Return result
    End Function

    Private Sub CloseAllFormsExceptMain()
        Dim formsToClose As New List(Of Form)()


        For Each form As Form In Application.OpenForms
            If form.Name <> Form3.Name Then
                formsToClose.Add(form)
            End If
        Next


        For Each form As Form In formsToClose
            form.Close()
        Next
    End Sub
End Class