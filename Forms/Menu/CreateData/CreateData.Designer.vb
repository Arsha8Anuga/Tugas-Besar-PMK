<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateData
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
        BackBtn = New Button()
        PemasukanBtn = New Button()
        PengeluaranBtn = New Button()
        SubmitBtn = New Button()
        FormGroupBox = New GroupBox()
        FormPanel = New Panel()
        PerincianText = New TextBox()
        NominalText = New TextBox()
        MetodeCB = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        FormGroupBox.SuspendLayout()
        FormPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' BackBtn
        ' 
        BackBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BackBtn.Location = New Point(12, 12)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(111, 30)
        BackBtn.TabIndex = 0
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' PemasukanBtn
        ' 
        PemasukanBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PemasukanBtn.Location = New Point(12, 64)
        PemasukanBtn.Name = "PemasukanBtn"
        PemasukanBtn.Size = New Size(268, 30)
        PemasukanBtn.TabIndex = 1
        PemasukanBtn.Text = "Pemasukan"
        PemasukanBtn.UseVisualStyleBackColor = True
        ' 
        ' PengeluaranBtn
        ' 
        PengeluaranBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PengeluaranBtn.Location = New Point(286, 64)
        PengeluaranBtn.Name = "PengeluaranBtn"
        PengeluaranBtn.Size = New Size(253, 30)
        PengeluaranBtn.TabIndex = 2
        PengeluaranBtn.Text = "Pengeluaran"
        PengeluaranBtn.UseVisualStyleBackColor = True
        ' 
        ' SubmitBtn
        ' 
        SubmitBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitBtn.Location = New Point(428, 392)
        SubmitBtn.Name = "SubmitBtn"
        SubmitBtn.Size = New Size(111, 30)
        SubmitBtn.TabIndex = 4
        SubmitBtn.Text = "Submit"
        SubmitBtn.UseVisualStyleBackColor = True
        ' 
        ' FormGroupBox
        ' 
        FormGroupBox.Controls.Add(FormPanel)
        FormGroupBox.Location = New Point(17, 112)
        FormGroupBox.Name = "FormGroupBox"
        FormGroupBox.Size = New Size(522, 264)
        FormGroupBox.TabIndex = 5
        FormGroupBox.TabStop = False
        FormGroupBox.Text = "GroupBox1"
        ' 
        ' FormPanel
        ' 
        FormPanel.AutoScroll = True
        FormPanel.Controls.Add(PerincianText)
        FormPanel.Controls.Add(NominalText)
        FormPanel.Controls.Add(MetodeCB)
        FormPanel.Controls.Add(Label3)
        FormPanel.Controls.Add(Label2)
        FormPanel.Controls.Add(Label1)
        FormPanel.Location = New Point(0, 22)
        FormPanel.Name = "FormPanel"
        FormPanel.Size = New Size(522, 242)
        FormPanel.TabIndex = 0
        ' 
        ' PerincianText
        ' 
        PerincianText.BorderStyle = BorderStyle.FixedSingle
        PerincianText.Location = New Point(113, 112)
        PerincianText.Multiline = True
        PerincianText.Name = "PerincianText"
        PerincianText.Size = New Size(382, 108)
        PerincianText.TabIndex = 5
        ' 
        ' NominalText
        ' 
        NominalText.Location = New Point(113, 18)
        NominalText.Name = "NominalText"
        NominalText.Size = New Size(382, 23)
        NominalText.TabIndex = 4
        ' 
        ' MetodeCB
        ' 
        MetodeCB.DropDownStyle = ComboBoxStyle.DropDownList
        MetodeCB.FormattingEnabled = True
        MetodeCB.Items.AddRange(New Object() {"Cash", "Non-Cash"})
        MetodeCB.Location = New Point(113, 60)
        MetodeCB.Name = "MetodeCB"
        MetodeCB.Size = New Size(121, 23)
        MetodeCB.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 19)
        Label3.TabIndex = 2
        Label3.Text = "Perincian"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 19)
        Label2.TabIndex = 1
        Label2.Text = "Metode"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 19)
        Label1.TabIndex = 0
        Label1.Text = "Nominal"
        ' 
        ' CreateData
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(562, 444)
        ControlBox = False
        Controls.Add(SubmitBtn)
        Controls.Add(FormGroupBox)
        Controls.Add(PengeluaranBtn)
        Controls.Add(PemasukanBtn)
        Controls.Add(BackBtn)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "CreateData"
        ShowIcon = False
        FormGroupBox.ResumeLayout(False)
        FormPanel.ResumeLayout(False)
        FormPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents PemasukanBtn As Button
    Friend WithEvents PengeluaranBtn As Button
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents FormGroupBox As GroupBox
    Friend WithEvents FormPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PerincianText As TextBox
    Friend WithEvents NominalText As TextBox
    Friend WithEvents MetodeCB As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
