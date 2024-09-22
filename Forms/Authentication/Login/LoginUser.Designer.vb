<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        UsernameText = New TextBox()
        PasswordText = New TextBox()
        SubmitBtn = New Button()
        Label5 = New Label()
        Label1 = New Label()
        RegisterLink = New LinkLabel()
        ExitBtn = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Adobe Fan Heiti Std B", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(12, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(243, 23)
        Label2.TabIndex = 1
        Label2.Text = "Please Insert Username And Password"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Adobe Fan Heiti Std B", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(12, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 20)
        Label3.TabIndex = 2
        Label3.Text = "Username : "
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Adobe Fan Heiti Std B", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(12, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 20)
        Label4.TabIndex = 3
        Label4.Text = "Password : "
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UsernameText
        ' 
        UsernameText.BorderStyle = BorderStyle.None
        UsernameText.Font = New Font("Adobe Fan Heiti Std B", 10.0F, FontStyle.Bold)
        UsernameText.Location = New Point(114, 82)
        UsernameText.Name = "UsernameText"
        UsernameText.Size = New Size(355, 27)
        UsernameText.TabIndex = 4
        ' 
        ' PasswordText
        ' 
        PasswordText.BorderStyle = BorderStyle.None
        PasswordText.Font = New Font("Adobe Fan Heiti Std B", 10.0F, FontStyle.Bold)
        PasswordText.Location = New Point(114, 122)
        PasswordText.Name = "PasswordText"
        PasswordText.Size = New Size(355, 27)
        PasswordText.TabIndex = 5
        ' 
        ' SubmitBtn
        ' 
        SubmitBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitBtn.Location = New Point(200, 169)
        SubmitBtn.Name = "SubmitBtn"
        SubmitBtn.Size = New Size(91, 35)
        SubmitBtn.TabIndex = 6
        SubmitBtn.Text = "Login"
        SubmitBtn.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Adobe Fan Heiti Std B", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(131, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 23)
        Label5.TabIndex = 7
        Label5.Text = "Don't Have Any Account?"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(191, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RegisterLink
        ' 
        RegisterLink.AutoSize = True
        RegisterLink.Font = New Font("Adobe Fan Heiti Std B", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(128))
        RegisterLink.Location = New Point(297, 226)
        RegisterLink.Name = "RegisterLink"
        RegisterLink.Size = New Size(56, 16)
        RegisterLink.TabIndex = 8
        RegisterLink.TabStop = True
        RegisterLink.Text = "Register"
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Font = New Font("Adobe Fan Heiti Std B", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitBtn.Location = New Point(392, 9)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(77, 23)
        ExitBtn.TabIndex = 9
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' LoginUser
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(488, 255)
        ControlBox = False
        Controls.Add(ExitBtn)
        Controls.Add(RegisterLink)
        Controls.Add(Label5)
        Controls.Add(SubmitBtn)
        Controls.Add(PasswordText)
        Controls.Add(UsernameText)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginUser"
        ShowIcon = False
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UsernameText As TextBox
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RegisterLink As LinkLabel
    Friend WithEvents ExitBtn As Button
End Class
