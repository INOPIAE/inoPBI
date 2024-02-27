<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTMDL
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
        CmdEditReplacement = New Button()
        CmdClose = New Button()
        CmdDocumentation = New Button()
        CmdReplace = New Button()
        CmdFolderTarget = New Button()
        CmdFileDocu = New Button()
        CmdFileReplacement = New Button()
        CmdFileOriginal = New Button()
        TxtCustomer = New TextBox()
        LblCustomer = New Label()
        TxtTargetFolder = New TextBox()
        LblTargetFolder = New Label()
        TxtFileDocu = New TextBox()
        LblFileDocu = New Label()
        TxtReplace = New TextBox()
        LblRepacement = New Label()
        TxtOrginal = New TextBox()
        LblOriginal = New Label()
        CmdPDF = New Button()
        LblInfo = New Label()
        SuspendLayout()
        ' 
        ' CmdEditReplacement
        ' 
        CmdEditReplacement.Location = New Point(709, 78)
        CmdEditReplacement.Name = "CmdEditReplacement"
        CmdEditReplacement.Size = New Size(69, 29)
        CmdEditReplacement.TabIndex = 26
        CmdEditReplacement.Text = "Edit"
        CmdEditReplacement.UseVisualStyleBackColor = True
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(604, 353)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(126, 53)
        CmdClose.TabIndex = 38
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdDocumentation
        ' 
        CmdDocumentation.Location = New Point(189, 353)
        CmdDocumentation.Name = "CmdDocumentation"
        CmdDocumentation.Size = New Size(126, 53)
        CmdDocumentation.TabIndex = 36
        CmdDocumentation.Text = "Create Documentation"
        CmdDocumentation.UseVisualStyleBackColor = True
        ' 
        ' CmdReplace
        ' 
        CmdReplace.Location = New Point(35, 353)
        CmdReplace.Name = "CmdReplace"
        CmdReplace.Size = New Size(126, 53)
        CmdReplace.TabIndex = 37
        CmdReplace.Text = "Replace"
        CmdReplace.UseVisualStyleBackColor = True
        ' 
        ' CmdFolderTarget
        ' 
        CmdFolderTarget.Location = New Point(673, 112)
        CmdFolderTarget.Name = "CmdFolderTarget"
        CmdFolderTarget.Size = New Size(30, 27)
        CmdFolderTarget.TabIndex = 29
        CmdFolderTarget.Text = "..."
        CmdFolderTarget.UseVisualStyleBackColor = True
        ' 
        ' CmdFileDocu
        ' 
        CmdFileDocu.Location = New Point(673, 236)
        CmdFileDocu.Name = "CmdFileDocu"
        CmdFileDocu.Size = New Size(30, 27)
        CmdFileDocu.TabIndex = 34
        CmdFileDocu.Text = "..."
        CmdFileDocu.UseVisualStyleBackColor = True
        ' 
        ' CmdFileReplacement
        ' 
        CmdFileReplacement.Location = New Point(673, 78)
        CmdFileReplacement.Name = "CmdFileReplacement"
        CmdFileReplacement.Size = New Size(30, 27)
        CmdFileReplacement.TabIndex = 25
        CmdFileReplacement.Text = "..."
        CmdFileReplacement.UseVisualStyleBackColor = True
        ' 
        ' CmdFileOriginal
        ' 
        CmdFileOriginal.Location = New Point(673, 46)
        CmdFileOriginal.Name = "CmdFileOriginal"
        CmdFileOriginal.Size = New Size(30, 27)
        CmdFileOriginal.TabIndex = 22
        CmdFileOriginal.Text = "..."
        CmdFileOriginal.UseVisualStyleBackColor = True
        ' 
        ' TxtCustomer
        ' 
        TxtCustomer.Location = New Point(160, 144)
        TxtCustomer.Name = "TxtCustomer"
        TxtCustomer.Size = New Size(172, 27)
        TxtCustomer.TabIndex = 31
        ' 
        ' LblCustomer
        ' 
        LblCustomer.AutoSize = True
        LblCustomer.Location = New Point(22, 148)
        LblCustomer.Name = "LblCustomer"
        LblCustomer.Size = New Size(139, 20)
        LblCustomer.TabIndex = 30
        LblCustomer.Text = "Customer Extension"
        ' 
        ' TxtTargetFolder
        ' 
        TxtTargetFolder.Location = New Point(160, 110)
        TxtTargetFolder.Name = "TxtTargetFolder"
        TxtTargetFolder.Size = New Size(507, 27)
        TxtTargetFolder.TabIndex = 28
        ' 
        ' LblTargetFolder
        ' 
        LblTargetFolder.AutoSize = True
        LblTargetFolder.Location = New Point(22, 114)
        LblTargetFolder.Name = "LblTargetFolder"
        LblTargetFolder.Size = New Size(94, 20)
        LblTargetFolder.TabIndex = 27
        LblTargetFolder.Text = "Target folder"
        ' 
        ' TxtFileDocu
        ' 
        TxtFileDocu.Location = New Point(160, 236)
        TxtFileDocu.Name = "TxtFileDocu"
        TxtFileDocu.Size = New Size(507, 27)
        TxtFileDocu.TabIndex = 33
        ' 
        ' LblFileDocu
        ' 
        LblFileDocu.AutoSize = True
        LblFileDocu.Location = New Point(22, 238)
        LblFileDocu.Name = "LblFileDocu"
        LblFileDocu.Size = New Size(137, 20)
        LblFileDocu.TabIndex = 32
        LblFileDocu.Text = "Dokumentation file"
        ' 
        ' TxtReplace
        ' 
        TxtReplace.Location = New Point(160, 78)
        TxtReplace.Name = "TxtReplace"
        TxtReplace.Size = New Size(507, 27)
        TxtReplace.TabIndex = 24
        ' 
        ' LblRepacement
        ' 
        LblRepacement.AutoSize = True
        LblRepacement.Location = New Point(22, 81)
        LblRepacement.Name = "LblRepacement"
        LblRepacement.Size = New Size(121, 20)
        LblRepacement.TabIndex = 23
        LblRepacement.Text = "Replacement file"
        ' 
        ' TxtOrginal
        ' 
        TxtOrginal.Location = New Point(160, 45)
        TxtOrginal.Name = "TxtOrginal"
        TxtOrginal.Size = New Size(507, 27)
        TxtOrginal.TabIndex = 21
        ' 
        ' LblOriginal
        ' 
        LblOriginal.AutoSize = True
        LblOriginal.Location = New Point(22, 48)
        LblOriginal.Name = "LblOriginal"
        LblOriginal.Size = New Size(62, 20)
        LblOriginal.TabIndex = 20
        LblOriginal.Text = "Original"
        ' 
        ' CmdPDF
        ' 
        CmdPDF.Location = New Point(321, 353)
        CmdPDF.Name = "CmdPDF"
        CmdPDF.Size = New Size(126, 53)
        CmdPDF.TabIndex = 36
        CmdPDF.Text = "Create PDF"
        CmdPDF.UseVisualStyleBackColor = True
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(22, 301)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(35, 20)
        LblInfo.TabIndex = 39
        LblInfo.Text = "Info"
        ' 
        ' FrmTMDL
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LblInfo)
        Controls.Add(CmdEditReplacement)
        Controls.Add(CmdClose)
        Controls.Add(CmdPDF)
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
        Controls.Add(LblOriginal)
        Name = "FrmTMDL"
        Text = "FrmTMDL"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmdEditReplacement As Button
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdDocumentation As Button
    Friend WithEvents CmdReplace As Button
    Friend WithEvents CmdFolderTarget As Button
    Friend WithEvents CmdFileDocu As Button
    Friend WithEvents CmdFileReplacement As Button
    Friend WithEvents CmdFileOriginal As Button
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents LblCustomer As Label
    Friend WithEvents TxtTargetFolder As TextBox
    Friend WithEvents LblTargetFolder As Label
    Friend WithEvents TxtFileDocu As TextBox
    Friend WithEvents LblFileDocu As Label
    Friend WithEvents TxtReplace As TextBox
    Friend WithEvents LblRepacement As Label
    Friend WithEvents TxtOrginal As TextBox
    Friend WithEvents LblOriginal As Label
    Friend WithEvents CmdPDF As Button
    Friend WithEvents LblInfo As Label
End Class
