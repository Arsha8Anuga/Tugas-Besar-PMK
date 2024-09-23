<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        UernameTxt = New TextBox()
        EmailTxt = New TextBox()
        PasswordTxt = New TextBox()
        SubmitBtn = New Button()
        BackBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(206, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 24)
        Label1.TabIndex = 0
        Label1.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Adobe Fan Heiti Std B", 12.25F, FontStyle.Bold)
        Label2.Location = New Point(12, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 21)
        Label2.TabIndex = 1
        Label2.Text = "Username :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Adobe Fan Heiti Std B", 12.25F, FontStyle.Bold)
        Label3.Location = New Point(12, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 21)
        Label3.TabIndex = 2
        Label3.Text = "Email :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Adobe Fan Heiti Std B", 12.25F, FontStyle.Bold)
        Label4.Location = New Point(12, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 21)
        Label4.TabIndex = 3
        Label4.Text = "Password :"
        ' 
        ' UernameTxt
        ' 
        UernameTxt.Font = New Font("Adobe Fan Heiti Std B", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UernameTxt.Location = New Point(113, 68)
        UernameTxt.Multiline = True
        UernameTxt.Name = "UernameTxt"
        UernameTxt.Size = New Size(349, 23)
        UernameTxt.TabIndex = 4
        ' 
        ' EmailTxt
        ' 
        EmailTxt.Font = New Font("Adobe Fan Heiti Std B", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmailTxt.Location = New Point(113, 103)
        EmailTxt.Multiline = True
        EmailTxt.Name = "EmailTxt"
        EmailTxt.Size = New Size(349, 23)
        EmailTxt.TabIndex = 5
        ' 
        ' PasswordTxt
        ' 
        PasswordTxt.Font = New Font("Adobe Fan Heiti Std B", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PasswordTxt.Location = New Point(113, 142)
        PasswordTxt.Multiline = True
        PasswordTxt.Name = "PasswordTxt"
        PasswordTxt.Size = New Size(349, 23)
        PasswordTxt.TabIndex = 6
        ' 
        ' SubmitBtn
        ' 
        SubmitBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitBtn.Location = New Point(191, 203)
        SubmitBtn.Name = "SubmitBtn"
        SubmitBtn.Size = New Size(94, 29)
        SubmitBtn.TabIndex = 7
        SubmitBtn.Text = "Submit"
        SubmitBtn.UseVisualStyleBackColor = True
        ' 
        ' BackBtn
        ' 
        BackBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BackBtn.Location = New Point(12, 12)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(95, 33)
        BackBtn.TabIndex = 8
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(488, 255)
        ControlBox = False
        Controls.Add(BackBtn)
        Controls.Add(SubmitBtn)
        Controls.Add(PasswordTxt)
        Controls.Add(EmailTxt)
        Controls.Add(UernameTxt)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UernameTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents BackBtn As Button
End Class
