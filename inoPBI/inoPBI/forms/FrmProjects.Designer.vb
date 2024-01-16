<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProjects
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LblProjects = New Label()
        LbProjects = New ListBox()
        CmdSelect = New Button()
        CmdNewProject = New Button()
        CmdClose = New Button()
        CmdRenameProject = New Button()
        SuspendLayout()
        ' 
        ' LblProjects
        ' 
        LblProjects.AutoSize = True
        LblProjects.Location = New Point(43, 36)
        LblProjects.Name = "LblProjects"
        LblProjects.Size = New Size(61, 20)
        LblProjects.TabIndex = 0
        LblProjects.Text = "Projects"
        ' 
        ' LbProjects
        ' 
        LbProjects.FormattingEnabled = True
        LbProjects.ItemHeight = 20
        LbProjects.Location = New Point(42, 72)
        LbProjects.Name = "LbProjects"
        LbProjects.Size = New Size(490, 304)
        LbProjects.TabIndex = 1
        ' 
        ' CmdSelect
        ' 
        CmdSelect.Location = New Point(596, 77)
        CmdSelect.Name = "CmdSelect"
        CmdSelect.Size = New Size(132, 28)
        CmdSelect.TabIndex = 2
        CmdSelect.Text = "Select Project"
        CmdSelect.UseVisualStyleBackColor = True
        ' 
        ' CmdNewProject
        ' 
        CmdNewProject.Location = New Point(596, 111)
        CmdNewProject.Name = "CmdNewProject"
        CmdNewProject.Size = New Size(132, 28)
        CmdNewProject.TabIndex = 2
        CmdNewProject.Text = "New Project"
        CmdNewProject.UseVisualStyleBackColor = True
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(596, 348)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(132, 28)
        CmdClose.TabIndex = 2
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdRenameProject
        ' 
        CmdRenameProject.Location = New Point(596, 145)
        CmdRenameProject.Name = "CmdRenameProject"
        CmdRenameProject.Size = New Size(132, 28)
        CmdRenameProject.TabIndex = 2
        CmdRenameProject.Text = "Rename Project"
        CmdRenameProject.UseVisualStyleBackColor = True
        ' 
        ' FrmProjects
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CmdClose)
        Controls.Add(CmdRenameProject)
        Controls.Add(CmdNewProject)
        Controls.Add(CmdSelect)
        Controls.Add(LbProjects)
        Controls.Add(LblProjects)
        Name = "FrmProjects"
        Text = "FrmProjects"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblProjects As Label
    Friend WithEvents LbProjects As ListBox
    Friend WithEvents CmdSelect As Button
    Friend WithEvents CmdNewProject As Button
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdRenameProject As Button
End Class
