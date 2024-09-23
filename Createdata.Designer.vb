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
        lblnominal = New Label()
        Label2 = New Label()
        lblketerangan = New Label()
        tbket = New TextBox()
        tbnominal = New TextBox()
        gbform.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnsubmit
        ' 
        btnsubmit.BackColor = SystemColors.ScrollBar
        btnsubmit.Font = New Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsubmit.Location = New Point(462, 529)
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
        btnmasuk.Location = New Point(33, 145)
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
        btnkeluar.Location = New Point(325, 145)
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
        gbform.Controls.Add(tbnominal)
        gbform.Controls.Add(tbket)
        gbform.Controls.Add(lblnominal)
        gbform.Controls.Add(Label2)
        gbform.Controls.Add(lblketerangan)
        gbform.Location = New Point(33, 205)
        gbform.Name = "gbform"
        gbform.Size = New Size(557, 303)
        gbform.TabIndex = 4
        gbform.TabStop = False
        gbform.Text = "Form Data"
        ' 
        ' lblnominal
        ' 
        lblnominal.AutoSize = True
        lblnominal.Font = New Font("Yu Gothic UI", 12F)
        lblnominal.Location = New Point(15, 34)
        lblnominal.Name = "lblnominal"
        lblnominal.Size = New Size(87, 28)
        lblnominal.TabIndex = 5
        lblnominal.Text = "Nominal"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 12F)
        Label2.Location = New Point(15, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 28)
        Label2.TabIndex = 6
        Label2.Text = "Label2"
        ' 
        ' lblketerangan
        ' 
        lblketerangan.AutoSize = True
        lblketerangan.Font = New Font("Yu Gothic UI", 12F)
        lblketerangan.Location = New Point(15, 134)
        lblketerangan.Name = "lblketerangan"
        lblketerangan.Size = New Size(112, 28)
        lblketerangan.TabIndex = 7
        lblketerangan.Text = "Keterangan"
        ' 
        ' tbket
        ' 
        tbket.Location = New Point(131, 138)
        tbket.Multiline = True
        tbket.Name = "tbket"
        tbket.Size = New Size(391, 120)
        tbket.TabIndex = 8
        ' 
        ' tbnominal
        ' 
        tbnominal.Location = New Point(131, 38)
        tbnominal.Name = "tbnominal"
        tbnominal.Size = New Size(391, 27)
        tbnominal.TabIndex = 9
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
        gbform.ResumeLayout(False)
        gbform.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnmasuk As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnback As Button
    Friend WithEvents gbform As GroupBox
    Friend WithEvents lblnominal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblketerangan As Label
    Friend WithEvents tbnominal As TextBox
    Friend WithEvents tbket As TextBox
End Class
