<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabel
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
        btnmasuktbl = New Button()
        btnkeluartbl = New Button()
        btnwaktu = New Button()
        btnrange = New Button()
        btnback2 = New Button()
        gbgrafik = New GroupBox()
        gbtabel = New GroupBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnmasuktbl
        ' 
        btnmasuktbl.BackColor = SystemColors.ScrollBar
        btnmasuktbl.Font = New Font("Yu Gothic UI", 13.8F)
        btnmasuktbl.Location = New Point(731, 12)
        btnmasuktbl.Name = "btnmasuktbl"
        btnmasuktbl.Size = New Size(233, 45)
        btnmasuktbl.TabIndex = 0
        btnmasuktbl.Text = "Pemasukan"
        btnmasuktbl.UseVisualStyleBackColor = False
        ' 
        ' btnkeluartbl
        ' 
        btnkeluartbl.BackColor = SystemColors.ScrollBar
        btnkeluartbl.Font = New Font("Yu Gothic UI", 13.8F)
        btnkeluartbl.Location = New Point(1097, 12)
        btnkeluartbl.Name = "btnkeluartbl"
        btnkeluartbl.Size = New Size(233, 45)
        btnkeluartbl.TabIndex = 1
        btnkeluartbl.Text = "Pengeluaran"
        btnkeluartbl.UseVisualStyleBackColor = False
        ' 
        ' btnwaktu
        ' 
        btnwaktu.BackColor = SystemColors.ScrollBar
        btnwaktu.Font = New Font("Yu Gothic UI", 13.8F)
        btnwaktu.Location = New Point(31, 628)
        btnwaktu.Name = "btnwaktu"
        btnwaktu.Size = New Size(233, 45)
        btnwaktu.TabIndex = 2
        btnwaktu.Text = "Waktu"
        btnwaktu.UseVisualStyleBackColor = False
        ' 
        ' btnrange
        ' 
        btnrange.BackColor = SystemColors.ScrollBar
        btnrange.Font = New Font("Yu Gothic UI", 13.8F)
        btnrange.Location = New Point(469, 628)
        btnrange.Name = "btnrange"
        btnrange.Size = New Size(233, 45)
        btnrange.TabIndex = 3
        btnrange.Text = "Range Hari"
        btnrange.UseVisualStyleBackColor = False
        ' 
        ' btnback2
        ' 
        btnback2.BackColor = SystemColors.ScrollBar
        btnback2.Font = New Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnback2.Location = New Point(31, 22)
        btnback2.Name = "btnback2"
        btnback2.Size = New Size(113, 41)
        btnback2.TabIndex = 4
        btnback2.Text = "Back"
        btnback2.UseVisualStyleBackColor = False
        ' 
        ' gbgrafik
        ' 
        gbgrafik.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbgrafik.Location = New Point(31, 152)
        gbgrafik.Name = "gbgrafik"
        gbgrafik.Size = New Size(671, 455)
        gbgrafik.TabIndex = 5
        gbgrafik.TabStop = False
        ' 
        ' gbtabel
        ' 
        gbtabel.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbtabel.Location = New Point(731, 80)
        gbtabel.Name = "gbtabel"
        gbtabel.Size = New Size(584, 593)
        gbtabel.TabIndex = 0
        gbtabel.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(182, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(378, 31)
        Label1.TabIndex = 0
        Label1.Text = "Visualisasi Pemasukan/Pengeluaran"
        ' 
        ' Tabel
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1361, 721)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(gbtabel)
        Controls.Add(gbgrafik)
        Controls.Add(btnback2)
        Controls.Add(btnrange)
        Controls.Add(btnwaktu)
        Controls.Add(btnkeluartbl)
        Controls.Add(btnmasuktbl)
        Name = "Tabel"
        Text = "Tabel"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnmasuktbl As Button
    Friend WithEvents btnkeluartbl As Button
    Friend WithEvents btnwaktu As Button
    Friend WithEvents btnrange As Button
    Friend WithEvents btnback2 As Button
    Friend WithEvents gbgrafik As GroupBox
    Friend WithEvents gbtabel As GroupBox
    Friend WithEvents Label1 As Label
End Class
