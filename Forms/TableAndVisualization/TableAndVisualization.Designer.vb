<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableAndVisualization
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
        PengeluaranBtn = New Button()
        DataGraph = New OxyPlot.WindowsForms.PlotView()
        TableData = New DataGridView()
        PemasukanBtn = New Button()
        Label1 = New Label()
        DateTimePicker = New DateTimePicker()
        CBTime = New ComboBox()
        CType(TableData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BackBtn
        ' 
        BackBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BackBtn.Location = New Point(25, 32)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(91, 34)
        BackBtn.TabIndex = 0
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' PengeluaranBtn
        ' 
        PengeluaranBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PengeluaranBtn.Location = New Point(707, 32)
        PengeluaranBtn.Name = "PengeluaranBtn"
        PengeluaranBtn.Size = New Size(145, 34)
        PengeluaranBtn.TabIndex = 1
        PengeluaranBtn.Text = "Pengeluaran"
        PengeluaranBtn.UseVisualStyleBackColor = True
        ' 
        ' DataGraph
        ' 
        DataGraph.BackColor = SystemColors.Control
        DataGraph.Location = New Point(25, 138)
        DataGraph.Name = "DataGraph"
        DataGraph.PanCursor = Cursors.Hand
        DataGraph.Size = New Size(495, 326)
        DataGraph.TabIndex = 2
        DataGraph.ZoomHorizontalCursor = Cursors.SizeWE
        DataGraph.ZoomRectangleCursor = Cursors.SizeNWSE
        DataGraph.ZoomVerticalCursor = Cursors.SizeNS
        ' 
        ' TableData
        ' 
        TableData.BackgroundColor = SystemColors.Control
        TableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TableData.Location = New Point(540, 72)
        TableData.Name = "TableData"
        TableData.Size = New Size(312, 440)
        TableData.TabIndex = 3
        ' 
        ' PemasukanBtn
        ' 
        PemasukanBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PemasukanBtn.Location = New Point(540, 32)
        PemasukanBtn.Name = "PemasukanBtn"
        PemasukanBtn.Size = New Size(151, 34)
        PemasukanBtn.TabIndex = 4
        PemasukanBtn.Text = "Pemasukan"
        PemasukanBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(181, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 24)
        Label1.TabIndex = 5
        Label1.Text = "Visualisasi Keuangan"
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.CalendarFont = New Font("Adobe Fan Heiti Std B", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DateTimePicker.CustomFormat = ""
        DateTimePicker.Font = New Font("Adobe Fan Heiti Std B", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        DateTimePicker.Location = New Point(25, 483)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(135, 29)
        DateTimePicker.TabIndex = 6
        ' 
        ' CBTime
        ' 
        CBTime.DropDownStyle = ComboBoxStyle.DropDownList
        CBTime.Font = New Font("Adobe Fan Heiti Std B", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CBTime.FormattingEnabled = True
        CBTime.Items.AddRange(New Object() {"1 Day", "1 Month"})
        CBTime.Location = New Point(343, 489)
        CBTime.Name = "CBTime"
        CBTime.Size = New Size(177, 23)
        CBTime.TabIndex = 7
        ' 
        ' TableAndVisualization
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 536)
        ControlBox = False
        Controls.Add(CBTime)
        Controls.Add(DateTimePicker)
        Controls.Add(Label1)
        Controls.Add(PemasukanBtn)
        Controls.Add(TableData)
        Controls.Add(DataGraph)
        Controls.Add(PengeluaranBtn)
        Controls.Add(BackBtn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "TableAndVisualization"
        CType(TableData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents PengeluaranBtn As Button
    Friend WithEvents DataGraph As OxyPlot.WindowsForms.PlotView
    Friend WithEvents TableData As DataGridView
    Friend WithEvents PemasukanBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents CBTime As ComboBox
End Class
