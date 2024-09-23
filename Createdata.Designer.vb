<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Createdata
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
        btnsubmit = New Button()
        btnmasuk = New Button()
        btnkeluar = New Button()
        btnback = New Button()
        gbform = New GroupBox()
        SuspendLayout()
        ' 
        ' btnsubmit
        ' 
        btnsubmit.BackColor = SystemColors.ScrollBar
        btnsubmit.Font = New Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsubmit.Location = New Point(460, 529)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(128, 44)
        btnsubmit.TabIndex = 0
        btnsubmit.Text = "Submit"
        btnsubmit.UseVisualStyleBackColor = False
        ' 
        ' btnmasuk
        ' 
        btnmasuk.BackColor = SystemColors.ScrollBar
        btnmasuk.Font = New Font("Yu Gothic UI", 13.8F)
        btnmasuk.Location = New Point(31, 145)
        btnmasuk.Name = "btnmasuk"
        btnmasuk.Size = New Size(265, 45)
        btnmasuk.TabIndex = 1
        btnmasuk.Text = "Pemasukan"
        btnmasuk.UseVisualStyleBackColor = False
        ' 
        ' btnkeluar
        ' 
        btnkeluar.BackColor = SystemColors.ScrollBar
        btnkeluar.Font = New Font("Yu Gothic UI", 13.8F)
        btnkeluar.Location = New Point(323, 145)
        btnkeluar.Name = "btnkeluar"
        btnkeluar.Size = New Size(265, 45)
        btnkeluar.TabIndex = 2
        btnkeluar.Text = "Pengeluaran"
        btnkeluar.UseVisualStyleBackColor = False
        ' 
        ' btnback
        ' 
        btnback.BackColor = SystemColors.ScrollBar
        btnback.Font = New Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnback.Location = New Point(31, 22)
        btnback.Name = "btnback"
        btnback.Size = New Size(128, 44)
        btnback.TabIndex = 3
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = False
        ' 
        ' gbform
        ' 
        gbform.Location = New Point(31, 205)
        gbform.Name = "gbform"
        gbform.Size = New Size(557, 303)
        gbform.TabIndex = 4
        gbform.TabStop = False
        gbform.Text = "Form Data"
        ' 
        ' Createdata
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(624, 642)
        ControlBox = False
        Controls.Add(gbform)
        Controls.Add(btnback)
        Controls.Add(btnkeluar)
        Controls.Add(btnmasuk)
        Controls.Add(btnsubmit)
        Name = "Createdata"
        Text = "Createdata"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnmasuk As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnback As Button
    Friend WithEvents gbform As GroupBox
End Class
