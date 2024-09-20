<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        btncreate = New Button()
        btnactivity = New Button()
        Button3 = New Button()
        btnexit = New Button()
        btnlogout = New Button()
        lblgreet = New Label()
        SuspendLayout()
        ' 
        ' btncreate
        ' 
        btncreate.BackColor = SystemColors.ScrollBar
        btncreate.Font = New Font("Yu Gothic UI", 13.8F)
        btncreate.Location = New Point(156, 188)
        btncreate.Name = "btncreate"
        btncreate.Size = New Size(312, 61)
        btncreate.TabIndex = 0
        btncreate.Text = "Create Data"
        btncreate.UseVisualStyleBackColor = False
        ' 
        ' btnactivity
        ' 
        btnactivity.BackColor = SystemColors.ScrollBar
        btnactivity.Font = New Font("Yu Gothic UI", 13.8F)
        btnactivity.Location = New Point(156, 269)
        btnactivity.Name = "btnactivity"
        btnactivity.Size = New Size(312, 61)
        btnactivity.TabIndex = 1
        btnactivity.Text = "Log Activity"
        btnactivity.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ScrollBar
        Button3.Font = New Font("Yu Gothic UI", 13.8F)
        Button3.Location = New Point(156, 351)
        Button3.Name = "Button3"
        Button3.Size = New Size(312, 61)
        Button3.TabIndex = 2
        Button3.Text = "Tabel dan Visualisasi"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = SystemColors.ScrollBar
        btnexit.Font = New Font("Yu Gothic UI", 13.8F)
        btnexit.Location = New Point(156, 437)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(312, 61)
        btnexit.TabIndex = 3
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = SystemColors.ScrollBar
        btnlogout.Font = New Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnlogout.Location = New Point(25, 29)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(128, 44)
        btnlogout.TabIndex = 4
        btnlogout.Text = "Log Out"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Font = New Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblgreet.Location = New Point(421, 40)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(170, 23)
        lblgreet.TabIndex = 5
        lblgreet.Text = "Welcome Back, Users"
        ' 
        ' Homepage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(624, 642)
        Controls.Add(lblgreet)
        Controls.Add(btnlogout)
        Controls.Add(btnexit)
        Controls.Add(Button3)
        Controls.Add(btnactivity)
        Controls.Add(btncreate)
        Name = "Homepage"
        Text = "Homepage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btncreate As Button
    Friend WithEvents btnactivity As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents lblgreet As Label
End Class
