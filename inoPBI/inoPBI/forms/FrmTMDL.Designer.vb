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
        components = New ComponentModel.Container()
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
        TxtPowerBIFile = New TextBox()
        LblPowerBIFile = New Label()
        CmdPDF = New Button()
        LblInfo = New Label()
        TT = New ToolTip(components)
        ChkbReplacement = New CheckBox()
        LblInfoMD = New Label()
        SuspendLayout()
        ' 
        ' CmdEditReplacement
        ' 
        CmdEditReplacement.Location = New Point(636, 58)
        CmdEditReplacement.Margin = New Padding(3, 2, 3, 2)
        CmdEditReplacement.Name = "CmdEditReplacement"
        CmdEditReplacement.Size = New Size(94, 22)
        CmdEditReplacement.TabIndex = 6
        CmdEditReplacement.Text = "Edit"
        CmdEditReplacement.UseVisualStyleBackColor = True
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(521, 322)
        CmdClose.Margin = New Padding(3, 2, 3, 2)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(110, 40)
        CmdClose.TabIndex = 20
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdDocumentation
        ' 
        CmdDocumentation.Location = New Point(31, 322)
        CmdDocumentation.Margin = New Padding(3, 2, 3, 2)
        CmdDocumentation.Name = "CmdDocumentation"
        CmdDocumentation.Size = New Size(110, 40)
        CmdDocumentation.TabIndex = 18
        CmdDocumentation.Text = "Create Documentation"
        CmdDocumentation.UseVisualStyleBackColor = True
        ' 
        ' CmdReplace
        ' 
        CmdReplace.Location = New Point(31, 265)
        CmdReplace.Margin = New Padding(3, 2, 3, 2)
        CmdReplace.Name = "CmdReplace"
        CmdReplace.Size = New Size(110, 40)
        CmdReplace.TabIndex = 17
        CmdReplace.Text = "Replace"
        CmdReplace.UseVisualStyleBackColor = True
        ' 
        ' CmdFolderTarget
        ' 
        CmdFolderTarget.Location = New Point(605, 84)
        CmdFolderTarget.Margin = New Padding(3, 2, 3, 2)
        CmdFolderTarget.Name = "CmdFolderTarget"
        CmdFolderTarget.Size = New Size(26, 20)
        CmdFolderTarget.TabIndex = 9
        CmdFolderTarget.Text = "..."
        CmdFolderTarget.UseVisualStyleBackColor = True
        ' 
        ' CmdFileDocu
        ' 
        CmdFileDocu.Location = New Point(605, 177)
        CmdFileDocu.Margin = New Padding(3, 2, 3, 2)
        CmdFileDocu.Name = "CmdFileDocu"
        CmdFileDocu.Size = New Size(26, 20)
        CmdFileDocu.TabIndex = 15
        CmdFileDocu.Text = "..."
        CmdFileDocu.UseVisualStyleBackColor = True
        ' 
        ' CmdFileReplacement
        ' 
        CmdFileReplacement.Location = New Point(605, 58)
        CmdFileReplacement.Margin = New Padding(3, 2, 3, 2)
        CmdFileReplacement.Name = "CmdFileReplacement"
        CmdFileReplacement.Size = New Size(26, 20)
        CmdFileReplacement.TabIndex = 5
        CmdFileReplacement.Text = "..."
        CmdFileReplacement.UseVisualStyleBackColor = True
        ' 
        ' CmdFileOriginal
        ' 
        CmdFileOriginal.Location = New Point(605, 34)
        CmdFileOriginal.Margin = New Padding(3, 2, 3, 2)
        CmdFileOriginal.Name = "CmdFileOriginal"
        CmdFileOriginal.Size = New Size(26, 20)
        CmdFileOriginal.TabIndex = 2
        CmdFileOriginal.Text = "..."
        CmdFileOriginal.UseVisualStyleBackColor = True
        ' 
        ' TxtCustomer
        ' 
        TxtCustomer.Location = New Point(156, 108)
        TxtCustomer.Margin = New Padding(3, 2, 3, 2)
        TxtCustomer.Name = "TxtCustomer"
        TxtCustomer.Size = New Size(151, 23)
        TxtCustomer.TabIndex = 11
        ' 
        ' LblCustomer
        ' 
        LblCustomer.AutoSize = True
        LblCustomer.Location = New Point(10, 110)
        LblCustomer.Name = "LblCustomer"
        LblCustomer.Size = New Size(113, 15)
        LblCustomer.TabIndex = 10
        LblCustomer.Text = "Customer Extension"
        ' 
        ' TxtTargetFolder
        ' 
        TxtTargetFolder.Location = New Point(156, 82)
        TxtTargetFolder.Margin = New Padding(3, 2, 3, 2)
        TxtTargetFolder.Name = "TxtTargetFolder"
        TxtTargetFolder.Size = New Size(444, 23)
        TxtTargetFolder.TabIndex = 8
        ' 
        ' LblTargetFolder
        ' 
        LblTargetFolder.AutoSize = True
        LblTargetFolder.Location = New Point(10, 84)
        LblTargetFolder.Name = "LblTargetFolder"
        LblTargetFolder.Size = New Size(73, 15)
        LblTargetFolder.TabIndex = 7
        LblTargetFolder.Text = "Target folder"
        ' 
        ' TxtFileDocu
        ' 
        TxtFileDocu.Location = New Point(156, 177)
        TxtFileDocu.Margin = New Padding(3, 2, 3, 2)
        TxtFileDocu.Name = "TxtFileDocu"
        TxtFileDocu.Size = New Size(444, 23)
        TxtFileDocu.TabIndex = 14
        ' 
        ' LblFileDocu
        ' 
        LblFileDocu.AutoSize = True
        LblFileDocu.Location = New Point(10, 177)
        LblFileDocu.Name = "LblFileDocu"
        LblFileDocu.Size = New Size(109, 15)
        LblFileDocu.TabIndex = 13
        LblFileDocu.Text = "Dokumentation file"
        ' 
        ' TxtReplace
        ' 
        TxtReplace.Location = New Point(156, 58)
        TxtReplace.Margin = New Padding(3, 2, 3, 2)
        TxtReplace.Name = "TxtReplace"
        TxtReplace.Size = New Size(444, 23)
        TxtReplace.TabIndex = 4
        ' 
        ' LblRepacement
        ' 
        LblRepacement.AutoSize = True
        LblRepacement.Location = New Point(10, 59)
        LblRepacement.Name = "LblRepacement"
        LblRepacement.Size = New Size(95, 15)
        LblRepacement.TabIndex = 3
        LblRepacement.Text = "Replacement file"
        ' 
        ' TxtPowerBIFile
        ' 
        TxtPowerBIFile.Location = New Point(156, 34)
        TxtPowerBIFile.Margin = New Padding(3, 2, 3, 2)
        TxtPowerBIFile.Name = "TxtPowerBIFile"
        TxtPowerBIFile.Size = New Size(444, 23)
        TxtPowerBIFile.TabIndex = 1
        ' 
        ' LblPowerBIFile
        ' 
        LblPowerBIFile.AutoSize = True
        LblPowerBIFile.Location = New Point(10, 34)
        LblPowerBIFile.Name = "LblPowerBIFile"
        LblPowerBIFile.Size = New Size(72, 15)
        LblPowerBIFile.TabIndex = 0
        LblPowerBIFile.Text = "Power BI file"
        ' 
        ' CmdPDF
        ' 
        CmdPDF.Location = New Point(147, 322)
        CmdPDF.Margin = New Padding(3, 2, 3, 2)
        CmdPDF.Name = "CmdPDF"
        CmdPDF.Size = New Size(110, 40)
        CmdPDF.TabIndex = 19
        CmdPDF.Text = "Create PDF"
        CmdPDF.UseVisualStyleBackColor = True
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(12, 236)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(28, 15)
        LblInfo.TabIndex = 16
        LblInfo.Text = "Info"
        ' 
        ' ChkbReplacement
        ' 
        ChkbReplacement.AutoSize = True
        ChkbReplacement.Location = New Point(158, 143)
        ChkbReplacement.Name = "ChkbReplacement"
        ChkbReplacement.Size = New Size(114, 19)
        ChkbReplacement.TabIndex = 12
        ChkbReplacement.Text = "No Replacement"
        ChkbReplacement.UseVisualStyleBackColor = True
        ' 
        ' LblInfoMD
        ' 
        LblInfoMD.AutoSize = True
        LblInfoMD.Location = New Point(158, 202)
        LblInfoMD.Name = "LblInfoMD"
        LblInfoMD.Size = New Size(28, 15)
        LblInfoMD.TabIndex = 16
        LblInfoMD.Text = "Info"
        ' 
        ' FrmTMDL
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(737, 393)
        Controls.Add(ChkbReplacement)
        Controls.Add(LblInfoMD)
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
        Controls.Add(TxtPowerBIFile)
        Controls.Add(LblPowerBIFile)
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents TxtPowerBIFile As TextBox
    Friend WithEvents LblPowerBIFile As Label
    Friend WithEvents CmdPDF As Button
    Friend WithEvents LblInfo As Label
    Friend WithEvents TT As ToolTip
    Friend WithEvents ChkbReplacement As CheckBox
    Friend WithEvents LblInfoMD As Label
End Class
