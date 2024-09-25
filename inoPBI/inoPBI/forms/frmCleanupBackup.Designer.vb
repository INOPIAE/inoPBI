<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCleanupBackup
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
        ClbBackup = New CheckedListBox()
        CmdClose = New Button()
        CmdDelete = New Button()
        LblInfo = New Label()
        LblFiles = New Label()
        CmdSelectAll = New Button()
        SuspendLayout()
        ' 
        ' ClbBackup
        ' 
        ClbBackup.FormattingEnabled = True
        ClbBackup.Location = New Point(28, 117)
        ClbBackup.Name = "ClbBackup"
        ClbBackup.Size = New Size(641, 130)
        ClbBackup.TabIndex = 0
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(399, 306)
        CmdClose.Margin = New Padding(3, 2, 3, 2)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(110, 40)
        CmdClose.TabIndex = 20
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdDelete
        ' 
        CmdDelete.Location = New Point(277, 306)
        CmdDelete.Margin = New Padding(3, 2, 3, 2)
        CmdDelete.Name = "CmdDelete"
        CmdDelete.Size = New Size(110, 40)
        CmdDelete.TabIndex = 19
        CmdDelete.Text = "Delete"
        CmdDelete.UseVisualStyleBackColor = True
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(28, 271)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(28, 15)
        LblInfo.TabIndex = 21
        LblInfo.Text = "Info"
        ' 
        ' LblFiles
        ' 
        LblFiles.AutoSize = True
        LblFiles.Location = New Point(28, 99)
        LblFiles.Name = "LblFiles"
        LblFiles.Size = New Size(28, 15)
        LblFiles.TabIndex = 21
        LblFiles.Text = "Info"
        ' 
        ' CmdSelectAll
        ' 
        CmdSelectAll.Location = New Point(150, 306)
        CmdSelectAll.Margin = New Padding(3, 2, 3, 2)
        CmdSelectAll.Name = "CmdSelectAll"
        CmdSelectAll.Size = New Size(110, 40)
        CmdSelectAll.TabIndex = 22
        CmdSelectAll.Text = "SelectAll"
        CmdSelectAll.UseVisualStyleBackColor = True
        ' 
        ' frmCleanupBackup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CmdSelectAll)
        Controls.Add(LblFiles)
        Controls.Add(LblInfo)
        Controls.Add(CmdClose)
        Controls.Add(CmdDelete)
        Controls.Add(ClbBackup)
        Name = "frmCleanupBackup"
        Text = "frmCleanuoBackup"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ClbBackup As CheckedListBox
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdDelete As Button
    Friend WithEvents LblInfo As Label
    Friend WithEvents LblFiles As Label
    Friend WithEvents CmdSelectAll As Button
End Class
