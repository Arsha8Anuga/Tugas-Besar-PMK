<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbllogin = New Label()
        lbluser = New Label()
        lblpass = New Label()
        lblinfo = New Label()
        lblreg = New Label()
        tbuser = New TextBox()
        tbpass = New TextBox()
        linkreg = New LinkLabel()
        btnsubmit = New Button()
        SuspendLayout()
        ' 
        ' lbllogin
        ' 
        lbllogin.AutoSize = True
        lbllogin.Font = New Font("MS Reference Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbllogin.Location = New Point(327, 9)
        lbllogin.Name = "lbllogin"
        lbllogin.Size = New Size(135, 49)
        lbllogin.TabIndex = 0
        lbllogin.Text = "Login"
        ' 
        ' lbluser
        ' 
        lbluser.AutoSize = True
        lbluser.Font = New Font("Yu Gothic UI", 14F)
        lbluser.Location = New Point(86, 166)
        lbluser.Name = "lbluser"
        lbluser.Size = New Size(189, 32)
        lbluser.TabIndex = 1
        lbluser.Text = "Username         :"
        ' 
        ' lblpass
        ' 
        lblpass.AutoSize = True
        lblpass.Font = New Font("Yu Gothic UI", 14F)
        lblpass.Location = New Point(86, 208)
        lblpass.Name = "lblpass"
        lblpass.Size = New Size(187, 32)
        lblpass.TabIndex = 2
        lblpass.Text = "Password          :"
        ' 
        ' lblinfo
        ' 
        lblinfo.AutoSize = True
        lblinfo.Font = New Font("Yu Gothic UI", 10.2F)
        lblinfo.Location = New Point(100, 112)
        lblinfo.Name = "lblinfo"
        lblinfo.Size = New Size(298, 23)
        lblinfo.TabIndex = 3
        lblinfo.Text = "Please Insert Username and Password"
        ' 
        ' lblreg
        ' 
        lblreg.AutoSize = True
        lblreg.Font = New Font("Yu Gothic UI", 10.2F)
        lblreg.Location = New Point(284, 351)
        lblreg.Name = "lblreg"
        lblreg.Size = New Size(199, 23)
        lblreg.TabIndex = 4
        lblreg.Text = "Don't have any account?"
        ' 
        ' tbuser
        ' 
        tbuser.BackColor = SystemColors.ScrollBar
        tbuser.Location = New Point(268, 172)
        tbuser.Name = "tbuser"
        tbuser.Size = New Size(403, 27)
        tbuser.TabIndex = 5
        ' 
        ' tbpass
        ' 
        tbpass.BackColor = SystemColors.ScrollBar
        tbpass.Location = New Point(268, 214)
        tbpass.Name = "tbpass"
        tbpass.PasswordChar = "●"c
        tbpass.Size = New Size(403, 27)
        tbpass.TabIndex = 6
        ' 
        ' linkreg
        ' 
        linkreg.AutoSize = True
        linkreg.Font = New Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        linkreg.Location = New Point(489, 351)
        linkreg.Name = "linkreg"
        linkreg.Size = New Size(71, 23)
        linkreg.TabIndex = 7
        linkreg.TabStop = True
        linkreg.Text = "Register"
        ' 
        ' btnsubmit
        ' 
        btnsubmit.BackColor = SystemColors.ScrollBar
        btnsubmit.Font = New Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsubmit.Location = New Point(347, 286)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(115, 35)
        btnsubmit.TabIndex = 8
        btnsubmit.Text = "Submit"
        btnsubmit.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(797, 457)
        Controls.Add(btnsubmit)
        Controls.Add(linkreg)
        Controls.Add(tbpass)
        Controls.Add(tbuser)
        Controls.Add(lblreg)
        Controls.Add(lblinfo)
        Controls.Add(lblpass)
        Controls.Add(lbluser)
        Controls.Add(lbllogin)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbllogin As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents lblinfo As Label
    Friend WithEvents lblreg As Label
    Friend WithEvents tbuser As TextBox
    Friend WithEvents tbpass As TextBox
    Friend WithEvents linkreg As LinkLabel
    Friend WithEvents btnsubmit As Button

End Class
