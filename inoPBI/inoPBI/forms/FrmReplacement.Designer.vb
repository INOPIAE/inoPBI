<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReplacement
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
        LblOriginal = New Label()
        TxtOrginal = New TextBox()
        CmdFileOriginal = New Button()
        LblRepacement = New Label()
        TxtReplace = New TextBox()
        CmdFileReplacement = New Button()
        LblTargetFolder = New Label()
        TxtTargetFolder = New TextBox()
        CmdFolderTarget = New Button()
        CmdReplace = New Button()
        CmdClose = New Button()
        LblCustomer = New Label()
        TxtCustomer = New TextBox()
        CmdInfo = New Button()
        LblInfo = New Label()
        LblFileDocu = New Label()
        TxtFileDocu = New TextBox()
        CmdFileDocu = New Button()
        CmdDocumentation = New Button()
        CmdEditReplacement = New Button()
        SuspendLayout()
        ' 
        ' LblOriginal
        ' 
        LblOriginal.AutoSize = True
        LblOriginal.Location = New Point(27, 39)
        LblOriginal.Name = "LblOriginal"
        LblOriginal.Size = New Size(62, 20)
        LblOriginal.TabIndex = 0
        LblOriginal.Text = "Original"
        ' 
        ' TxtOrginal
        ' 
        TxtOrginal.Location = New Point(165, 36)
        TxtOrginal.Name = "TxtOrginal"
        TxtOrginal.Size = New Size(507, 27)
        TxtOrginal.TabIndex = 1
        ' 
        ' CmdFileOriginal
        ' 
        CmdFileOriginal.Location = New Point(678, 37)
        CmdFileOriginal.Name = "CmdFileOriginal"
        CmdFileOriginal.Size = New Size(30, 27)
        CmdFileOriginal.TabIndex = 2
        CmdFileOriginal.Text = "..."
        CmdFileOriginal.UseVisualStyleBackColor = True
        ' 
        ' LblRepacement
        ' 
        LblRepacement.AutoSize = True
        LblRepacement.Location = New Point(27, 72)
        LblRepacement.Name = "LblRepacement"
        LblRepacement.Size = New Size(121, 20)
        LblRepacement.TabIndex = 3
        LblRepacement.Text = "Replacement file"
        ' 
        ' TxtReplace
        ' 
        TxtReplace.Location = New Point(165, 69)
        TxtReplace.Name = "TxtReplace"
        TxtReplace.Size = New Size(507, 27)
        TxtReplace.TabIndex = 4
        ' 
        ' CmdFileReplacement
        ' 
        CmdFileReplacement.Location = New Point(678, 69)
        CmdFileReplacement.Name = "CmdFileReplacement"
        CmdFileReplacement.Size = New Size(30, 27)
        CmdFileReplacement.TabIndex = 5
        CmdFileReplacement.Text = "..."
        CmdFileReplacement.UseVisualStyleBackColor = True
        ' 
        ' LblTargetFolder
        ' 
        LblTargetFolder.AutoSize = True
        LblTargetFolder.Location = New Point(27, 105)
        LblTargetFolder.Name = "LblTargetFolder"
        LblTargetFolder.Size = New Size(94, 20)
        LblTargetFolder.TabIndex = 7
        LblTargetFolder.Text = "Target folder"
        ' 
        ' TxtTargetFolder
        ' 
        TxtTargetFolder.Location = New Point(165, 101)
        TxtTargetFolder.Name = "TxtTargetFolder"
        TxtTargetFolder.Size = New Size(507, 27)
        TxtTargetFolder.TabIndex = 8
        ' 
        ' CmdFolderTarget
        ' 
        CmdFolderTarget.Location = New Point(678, 103)
        CmdFolderTarget.Name = "CmdFolderTarget"
        CmdFolderTarget.Size = New Size(30, 27)
        CmdFolderTarget.TabIndex = 9
        CmdFolderTarget.Text = "..."
        CmdFolderTarget.UseVisualStyleBackColor = True
        ' 
        ' CmdReplace
        ' 
        CmdReplace.Location = New Point(376, 344)
        CmdReplace.Name = "CmdReplace"
        CmdReplace.Size = New Size(117, 53)
        CmdReplace.TabIndex = 17
        CmdReplace.Text = "Replace"
        CmdReplace.UseVisualStyleBackColor = True
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(515, 343)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(117, 53)
        CmdClose.TabIndex = 18
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' LblCustomer
        ' 
        LblCustomer.AutoSize = True
        LblCustomer.Location = New Point(27, 139)
        LblCustomer.Name = "LblCustomer"
        LblCustomer.Size = New Size(139, 20)
        LblCustomer.TabIndex = 10
        LblCustomer.Text = "Customer Extension"
        ' 
        ' TxtCustomer
        ' 
        TxtCustomer.Location = New Point(165, 135)
        TxtCustomer.Name = "TxtCustomer"
        TxtCustomer.Size = New Size(172, 27)
        TxtCustomer.TabIndex = 11
        ' 
        ' CmdInfo
        ' 
        CmdInfo.Location = New Point(90, 344)
        CmdInfo.Name = "CmdInfo"
        CmdInfo.Size = New Size(46, 27)
        CmdInfo.TabIndex = 15
        CmdInfo.Text = "Info"
        CmdInfo.UseVisualStyleBackColor = True
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(79, 301)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(35, 20)
        LblInfo.TabIndex = 19
        LblInfo.Text = "Info"
        ' 
        ' LblFileDocu
        ' 
        LblFileDocu.AutoSize = True
        LblFileDocu.Location = New Point(27, 229)
        LblFileDocu.Name = "LblFileDocu"
        LblFileDocu.Size = New Size(137, 20)
        LblFileDocu.TabIndex = 12
        LblFileDocu.Text = "Dokumentation file"
        ' 
        ' TxtFileDocu
        ' 
        TxtFileDocu.Location = New Point(165, 227)
        TxtFileDocu.Name = "TxtFileDocu"
        TxtFileDocu.Size = New Size(507, 27)
        TxtFileDocu.TabIndex = 13
        ' 
        ' CmdFileDocu
        ' 
        CmdFileDocu.Location = New Point(678, 227)
        CmdFileDocu.Name = "CmdFileDocu"
        CmdFileDocu.Size = New Size(30, 27)
        CmdFileDocu.TabIndex = 14
        CmdFileDocu.Text = "..."
        CmdFileDocu.UseVisualStyleBackColor = True
        ' 
        ' CmdDocumentation
        ' 
        CmdDocumentation.Location = New Point(237, 344)
        CmdDocumentation.Name = "CmdDocumentation"
        CmdDocumentation.Size = New Size(117, 53)
        CmdDocumentation.TabIndex = 16
        CmdDocumentation.Text = "Create Documentation"
        CmdDocumentation.UseVisualStyleBackColor = True
        ' 
        ' CmdEditReplacement
        ' 
        CmdEditReplacement.Location = New Point(714, 69)
        CmdEditReplacement.Name = "CmdEditReplacement"
        CmdEditReplacement.Size = New Size(69, 29)
        CmdEditReplacement.TabIndex = 6
        CmdEditReplacement.Text = "Edit"
        CmdEditReplacement.UseVisualStyleBackColor = True
        ' 
        ' FrmReplacement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(CmdEditReplacement)
        Controls.Add(CmdInfo)
        Controls.Add(CmdClose)
        Controls.Add(CmdDocumentation)
        Controls.Add(CmdReplace)
        Controls.Add(CmdFolderTarget)
        Controls.Add(CmdFileDocu)
        Controls.Add(CmdFileReplacement)
        Controls.Add(CmdFileOriginal)
        Controls.Add(TxtCustomer)
        Controls.Add(LblCustomer)
        Controls.Add(TxtTargetFolder)
        Controls.Add(LblTargetFolder)
        Controls.Add(TxtFileDocu)
        Controls.Add(LblFileDocu)
        Controls.Add(TxtReplace)
        Controls.Add(LblRepacement)
        Controls.Add(TxtOrginal)
        Controls.Add(LblInfo)
        Controls.Add(LblOriginal)
        Name = "FrmReplacement"
        Text = "FrmReplacement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblOriginal As Label
    Friend WithEvents TxtOrginal As TextBox
    Friend WithEvents CmdFileOriginal As Button
    Friend WithEvents LblRepacement As Label
    Friend WithEvents TxtReplace As TextBox
    Friend WithEvents CmdFileReplacement As Button
    Friend WithEvents LblTargetFolder As Label
    Friend WithEvents TxtTargetFolder As TextBox
    Friend WithEvents CmdFolderTarget As Button
    Friend WithEvents CmdReplace As Button
    Friend WithEvents CmdClose As Button
    Friend WithEvents LblCustomer As Label
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents CmdInfo As Button
    Friend WithEvents LblInfo As Label
    Friend WithEvents LblFileDocu As Label
    Friend WithEvents TxtFileDocu As TextBox
    Friend WithEvents CmdFileDocu As Button
    Friend WithEvents CmdDocumentation As Button
    Friend WithEvents CmdEditReplacement As Button
End Class
