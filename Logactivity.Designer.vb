<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logactivity
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
        btnback2 = New Button()
        tblog4 = New TextBox()
        tblog3 = New TextBox()
        tblog2 = New TextBox()
        tblog1 = New TextBox()
        SuspendLayout()
        ' 
        ' btnback2
        ' 
        btnback2.BackColor = SystemColors.ScrollBar
        btnback2.Font = New Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnback2.Location = New Point(31, 22)
        btnback2.Name = "btnback2"
        btnback2.Size = New Size(113, 41)
        btnback2.TabIndex = 0
        btnback2.Text = "Back"
        btnback2.UseVisualStyleBackColor = False
        ' 
        ' tblog4
        ' 
        tblog4.BackColor = SystemColors.ScrollBar
        tblog4.Font = New Font("Yu Gothic UI", 13.8F)
        tblog4.Location = New Point(50, 518)
        tblog4.Multiline = True
        tblog4.Name = "tblog4"
        tblog4.ReadOnly = True
        tblog4.Size = New Size(530, 126)
        tblog4.TabIndex = 4
        ' 
        ' tblog3
        ' 
        tblog3.BackColor = SystemColors.ScrollBar
        tblog3.Font = New Font("Yu Gothic UI", 13.8F)
        tblog3.Location = New Point(50, 380)
        tblog3.Multiline = True
        tblog3.Name = "tblog3"
        tblog3.ReadOnly = True
        tblog3.Size = New Size(530, 126)
        tblog3.TabIndex = 3
        ' 
        ' tblog2
        ' 
        tblog2.BackColor = SystemColors.ScrollBar
        tblog2.Font = New Font("Yu Gothic UI", 13.8F)
        tblog2.Location = New Point(50, 246)
        tblog2.Multiline = True
        tblog2.Name = "tblog2"
        tblog2.ReadOnly = True
        tblog2.Size = New Size(530, 126)
        tblog2.TabIndex = 2
        ' 
        ' tblog1
        ' 
        tblog1.BackColor = SystemColors.ScrollBar
        tblog1.Font = New Font("Yu Gothic UI", 13.8F)
        tblog1.Location = New Point(50, 113)
        tblog1.Multiline = True
        tblog1.Name = "tblog1"
        tblog1.ReadOnly = True
        tblog1.Size = New Size(530, 126)
        tblog1.TabIndex = 1
        ' 
        ' Logactivity
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(624, 668)
        ControlBox = False
        Controls.Add(tblog4)
        Controls.Add(tblog3)
        Controls.Add(tblog2)
        Controls.Add(tblog1)
        Controls.Add(btnback2)
        Name = "Logactivity"
        Text = "Logactivity"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnback2 As Button
    Friend WithEvents tblog4 As TextBox
    Friend WithEvents tblog3 As TextBox
    Friend WithEvents tblog2 As TextBox
    Friend WithEvents tblog1 As TextBox
End Class
