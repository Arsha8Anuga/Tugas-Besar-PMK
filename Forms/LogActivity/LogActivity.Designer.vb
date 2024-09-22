<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogActivity
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
        Button1 = New Button()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 35)
        Button1.TabIndex = 0
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(12, 66)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(369, 360)
        Panel1.TabIndex = 1
        ' 
        ' LogActivity
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(393, 450)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "LogActivity"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
