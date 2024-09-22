<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        LogoutBtn = New Button()
        UserLabel = New Label()
        CreateDataBtn = New Button()
        LogActivityBtn = New Button()
        TableAndVisualizationBtn = New Button()
        ExitBtn = New Button()
        SuspendLayout()
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogoutBtn.Location = New Point(12, 12)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(114, 36)
        LogoutBtn.TabIndex = 0
        LogoutBtn.Text = "Logout"
        LogoutBtn.UseVisualStyleBackColor = True
        ' 
        ' UserLabel
        ' 
        UserLabel.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UserLabel.Location = New Point(145, 20)
        UserLabel.Name = "UserLabel"
        UserLabel.Size = New Size(361, 23)
        UserLabel.TabIndex = 1
        UserLabel.Text = "Label1"
        UserLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CreateDataBtn
        ' 
        CreateDataBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CreateDataBtn.Location = New Point(126, 158)
        CreateDataBtn.Name = "CreateDataBtn"
        CreateDataBtn.Size = New Size(270, 36)
        CreateDataBtn.TabIndex = 2
        CreateDataBtn.Text = "Create Data"
        CreateDataBtn.UseVisualStyleBackColor = True
        ' 
        ' LogActivityBtn
        ' 
        LogActivityBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogActivityBtn.Location = New Point(126, 211)
        LogActivityBtn.Name = "LogActivityBtn"
        LogActivityBtn.Size = New Size(270, 36)
        LogActivityBtn.TabIndex = 3
        LogActivityBtn.Text = "Log Activity"
        LogActivityBtn.UseVisualStyleBackColor = True
        ' 
        ' TableAndVisualizationBtn
        ' 
        TableAndVisualizationBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TableAndVisualizationBtn.Location = New Point(126, 264)
        TableAndVisualizationBtn.Name = "TableAndVisualizationBtn"
        TableAndVisualizationBtn.Size = New Size(270, 36)
        TableAndVisualizationBtn.TabIndex = 4
        TableAndVisualizationBtn.Text = "Table And Visualization"
        TableAndVisualizationBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitBtn.Location = New Point(126, 319)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(270, 36)
        ExitBtn.TabIndex = 5
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(530, 416)
        ControlBox = False
        Controls.Add(ExitBtn)
        Controls.Add(TableAndVisualizationBtn)
        Controls.Add(LogActivityBtn)
        Controls.Add(CreateDataBtn)
        Controls.Add(UserLabel)
        Controls.Add(LogoutBtn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Menu"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LogoutBtn As Button
    Friend WithEvents UserLabel As Label
    Friend WithEvents CreateDataBtn As Button
    Friend WithEvents LogActivityBtn As Button
    Friend WithEvents TableAndVisualizationBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
