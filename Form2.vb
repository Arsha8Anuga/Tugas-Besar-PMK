Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim startup As KeyValuePair(Of Integer, String)

        startup = DBStartUp(ConstantManagement.SETTING_FILE_PATH, "INSERT INTO Employees (FirstName, LastName, Email, PhoneNumber, HireDate, Salary, Department) VALUES
('Luthfi', 'Rustian', 'john.doe@example.com', '123-456-7890', '2021-06-15', 60000.00, 'Engineering'),
('Jane', 'Smith', 'jane.smith@example.com', '987-654-3210', '2020-01-10', 75000.00, 'Marketing'),
('Emily', 'Johnson', 'emily.johnson@example.com', '555-123-4567', '2019-03-25', 50000.00, 'Sales'),
('Michael', 'Brown', 'michael.brown@example.com', '444-321-9876', '2022-11-05', 80000.00, 'Management');")


        Label1.Text = startup.Value

    End Sub
End Class