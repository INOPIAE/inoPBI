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
        SuspendLayout()
        ' 
        ' LblOriginal
        ' 
        LblOriginal.AutoSize = True
        LblOriginal.Location = New Point(28, 39)
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
        CmdFileOriginal.Size = New Size(26, 26)
        CmdFileOriginal.TabIndex = 2
        CmdFileOriginal.Text = "..."
        CmdFileOriginal.UseVisualStyleBackColor = True
        ' 
        ' LblRepacement
        ' 
        LblRepacement.AutoSize = True
        LblRepacement.Location = New Point(28, 72)
        LblRepacement.Name = "LblRepacement"
        LblRepacement.Size = New Size(121, 20)
        LblRepacement.TabIndex = 0
        LblRepacement.Text = "Replacement file"
        ' 
        ' TxtReplace
        ' 
        TxtReplace.Location = New Point(165, 69)
        TxtReplace.Name = "TxtReplace"
        TxtReplace.Size = New Size(507, 27)
        TxtReplace.TabIndex = 1
        ' 
        ' CmdFileReplacement
        ' 
        CmdFileReplacement.Location = New Point(678, 70)
        CmdFileReplacement.Name = "CmdFileReplacement"
        CmdFileReplacement.Size = New Size(26, 26)
        CmdFileReplacement.TabIndex = 2
        CmdFileReplacement.Text = "..."
        CmdFileReplacement.UseVisualStyleBackColor = True
        ' 
        ' LblTargetFolder
        ' 
        LblTargetFolder.AutoSize = True
        LblTargetFolder.Location = New Point(28, 105)
        LblTargetFolder.Name = "LblTargetFolder"
        LblTargetFolder.Size = New Size(94, 20)
        LblTargetFolder.TabIndex = 0
        LblTargetFolder.Text = "Target folder"
        ' 
        ' TxtTargetFolder
        ' 
        TxtTargetFolder.Location = New Point(165, 102)
        TxtTargetFolder.Name = "TxtTargetFolder"
        TxtTargetFolder.Size = New Size(507, 27)
        TxtTargetFolder.TabIndex = 1
        ' 
        ' CmdFolderTarget
        ' 
        CmdFolderTarget.Location = New Point(678, 103)
        CmdFolderTarget.Name = "CmdFolderTarget"
        CmdFolderTarget.Size = New Size(26, 26)
        CmdFolderTarget.TabIndex = 2
        CmdFolderTarget.Text = "..."
        CmdFolderTarget.UseVisualStyleBackColor = True
        ' 
        ' CmdReplace
        ' 
        CmdReplace.Location = New Point(373, 343)
        CmdReplace.Name = "CmdReplace"
        CmdReplace.Size = New Size(94, 29)
        CmdReplace.TabIndex = 3
        CmdReplace.Text = "Replace"
        CmdReplace.UseVisualStyleBackColor = True
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(539, 343)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(94, 29)
        CmdClose.TabIndex = 3
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' LblCustomer
        ' 
        LblCustomer.AutoSize = True
        LblCustomer.Location = New Point(28, 138)
        LblCustomer.Name = "LblCustomer"
        LblCustomer.Size = New Size(139, 20)
        LblCustomer.TabIndex = 0
        LblCustomer.Text = "Customer Extension"
        ' 
        ' TxtCustomer
        ' 
        TxtCustomer.Location = New Point(165, 135)
        TxtCustomer.Name = "TxtCustomer"
        TxtCustomer.Size = New Size(172, 27)
        TxtCustomer.TabIndex = 1
        ' 
        ' CmdInfo
        ' 
        CmdInfo.Location = New Point(216, 343)
        CmdInfo.Name = "CmdInfo"
        CmdInfo.Size = New Size(46, 26)
        CmdInfo.TabIndex = 4
        CmdInfo.Text = "Info"
        CmdInfo.UseVisualStyleBackColor = True
        ' 
        ' FrmReplacement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CmdInfo)
        Controls.Add(CmdClose)
        Controls.Add(CmdReplace)
        Controls.Add(CmdFolderTarget)
        Controls.Add(CmdFileReplacement)
        Controls.Add(CmdFileOriginal)
        Controls.Add(TxtCustomer)
        Controls.Add(LblCustomer)
        Controls.Add(TxtTargetFolder)
        Controls.Add(LblTargetFolder)
        Controls.Add(TxtReplace)
        Controls.Add(LblRepacement)
        Controls.Add(TxtOrginal)
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
End Class
