<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPDF
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
        CmdClose = New Button()
        CmdDocumentation = New Button()
        CmdReplace = New Button()
        CmdFolderTarget = New Button()
        CmdFileDocu = New Button()
        CmdFooterFile = New Button()
        CmdHeaderFile = New Button()
        TxtDocTitle = New TextBox()
        LblDocTitle = New Label()
        TxtTargetFolder = New TextBox()
        LblTargetFolder = New Label()
        TxtFileDocu = New TextBox()
        LblFileDocu = New Label()
        TxtFooter = New TextBox()
        LblFooter = New Label()
        TxtHeader = New TextBox()
        LblInfo = New Label()
        LblHeader = New Label()
        CbShowPDF = New CheckBox()
        SuspendLayout()
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(548, 352)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(117, 53)
        CmdClose.TabIndex = 17
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdDocumentation
        ' 
        CmdDocumentation.Location = New Point(270, 353)
        CmdDocumentation.Name = "CmdDocumentation"
        CmdDocumentation.Size = New Size(117, 53)
        CmdDocumentation.TabIndex = 15
        CmdDocumentation.Text = "Create PDF"
        CmdDocumentation.UseVisualStyleBackColor = True
        ' 
        ' CmdReplace
        ' 
        CmdReplace.Location = New Point(409, 353)
        CmdReplace.Name = "CmdReplace"
        CmdReplace.Size = New Size(117, 53)
        CmdReplace.TabIndex = 16
        CmdReplace.Text = "Replace"
        CmdReplace.UseVisualStyleBackColor = True
        ' 
        ' CmdFolderTarget
        ' 
        CmdFolderTarget.Location = New Point(709, 145)
        CmdFolderTarget.Name = "CmdFolderTarget"
        CmdFolderTarget.Size = New Size(30, 27)
        CmdFolderTarget.TabIndex = 11
        CmdFolderTarget.Text = "..."
        CmdFolderTarget.UseVisualStyleBackColor = True
        ' 
        ' CmdFileDocu
        ' 
        CmdFileDocu.Location = New Point(709, 45)
        CmdFileDocu.Name = "CmdFileDocu"
        CmdFileDocu.Size = New Size(30, 27)
        CmdFileDocu.TabIndex = 2
        CmdFileDocu.Text = "..."
        CmdFileDocu.UseVisualStyleBackColor = True
        ' 
        ' CmdFooterFile
        ' 
        CmdFooterFile.Location = New Point(709, 111)
        CmdFooterFile.Name = "CmdFooterFile"
        CmdFooterFile.Size = New Size(30, 27)
        CmdFooterFile.TabIndex = 8
        CmdFooterFile.Text = "..."
        CmdFooterFile.UseVisualStyleBackColor = True
        ' 
        ' CmdHeaderFile
        ' 
        CmdHeaderFile.Location = New Point(709, 79)
        CmdHeaderFile.Name = "CmdHeaderFile"
        CmdHeaderFile.Size = New Size(30, 27)
        CmdHeaderFile.TabIndex = 5
        CmdHeaderFile.Text = "..."
        CmdHeaderFile.UseVisualStyleBackColor = True
        ' 
        ' TxtDocTitle
        ' 
        TxtDocTitle.Location = New Point(196, 177)
        TxtDocTitle.Name = "TxtDocTitle"
        TxtDocTitle.Size = New Size(507, 27)
        TxtDocTitle.TabIndex = 13
        ' 
        ' LblDocTitle
        ' 
        LblDocTitle.AutoSize = True
        LblDocTitle.Location = New Point(58, 181)
        LblDocTitle.Name = "LblDocTitle"
        LblDocTitle.Size = New Size(108, 20)
        LblDocTitle.TabIndex = 12
        LblDocTitle.Text = "Document title"
        ' 
        ' TxtTargetFolder
        ' 
        TxtTargetFolder.Location = New Point(196, 143)
        TxtTargetFolder.Name = "TxtTargetFolder"
        TxtTargetFolder.Size = New Size(507, 27)
        TxtTargetFolder.TabIndex = 10
        ' 
        ' LblTargetFolder
        ' 
        LblTargetFolder.AutoSize = True
        LblTargetFolder.Location = New Point(58, 147)
        LblTargetFolder.Name = "LblTargetFolder"
        LblTargetFolder.Size = New Size(94, 20)
        LblTargetFolder.TabIndex = 9
        LblTargetFolder.Text = "Target folder"
        ' 
        ' TxtFileDocu
        ' 
        TxtFileDocu.Location = New Point(196, 45)
        TxtFileDocu.Name = "TxtFileDocu"
        TxtFileDocu.Size = New Size(507, 27)
        TxtFileDocu.TabIndex = 1
        ' 
        ' LblFileDocu
        ' 
        LblFileDocu.AutoSize = True
        LblFileDocu.Location = New Point(58, 47)
        LblFileDocu.Name = "LblFileDocu"
        LblFileDocu.Size = New Size(137, 20)
        LblFileDocu.TabIndex = 0
        LblFileDocu.Text = "Dokumentation file"
        ' 
        ' TxtFooter
        ' 
        TxtFooter.Location = New Point(196, 111)
        TxtFooter.Name = "TxtFooter"
        TxtFooter.Size = New Size(507, 27)
        TxtFooter.TabIndex = 7
        ' 
        ' LblFooter
        ' 
        LblFooter.AutoSize = True
        LblFooter.Location = New Point(58, 114)
        LblFooter.Name = "LblFooter"
        LblFooter.Size = New Size(122, 20)
        LblFooter.TabIndex = 6
        LblFooter.Text = "Footer HTML File"
        ' 
        ' TxtHeader
        ' 
        TxtHeader.Location = New Point(196, 78)
        TxtHeader.Name = "TxtHeader"
        TxtHeader.Size = New Size(507, 27)
        TxtHeader.TabIndex = 4
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(112, 310)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(35, 20)
        LblInfo.TabIndex = 18
        LblInfo.Text = "Info"
        ' 
        ' LblHeader
        ' 
        LblHeader.AutoSize = True
        LblHeader.Location = New Point(58, 81)
        LblHeader.Name = "LblHeader"
        LblHeader.Size = New Size(126, 20)
        LblHeader.TabIndex = 3
        LblHeader.Text = "Header HTML file"
        ' 
        ' CbShowPDF
        ' 
        CbShowPDF.AutoSize = True
        CbShowPDF.CheckAlign = ContentAlignment.MiddleRight
        CbShowPDF.Location = New Point(92, 219)
        CbShowPDF.Name = "CbShowPDF"
        CbShowPDF.Size = New Size(124, 24)
        CbShowPDF.TabIndex = 14
        CbShowPDF.Text = "Show PDF File"
        CbShowPDF.UseVisualStyleBackColor = True
        ' 
        ' FrmPDF
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CbShowPDF)
        Controls.Add(CmdClose)
        Controls.Add(CmdDocumentation)
        Controls.Add(CmdReplace)
        Controls.Add(CmdFolderTarget)
        Controls.Add(CmdFileDocu)
        Controls.Add(CmdFooterFile)
        Controls.Add(CmdHeaderFile)
        Controls.Add(TxtDocTitle)
        Controls.Add(LblDocTitle)
        Controls.Add(TxtTargetFolder)
        Controls.Add(LblTargetFolder)
        Controls.Add(TxtFileDocu)
        Controls.Add(LblFileDocu)
        Controls.Add(TxtFooter)
        Controls.Add(LblFooter)
        Controls.Add(TxtHeader)
        Controls.Add(LblInfo)
        Controls.Add(LblHeader)
        Name = "FrmPDF"
        Text = "FrmPDF"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdDocumentation As Button
    Friend WithEvents CmdReplace As Button
    Friend WithEvents CmdFolderTarget As Button
    Friend WithEvents CmdFileDocu As Button
    Friend WithEvents CmdFooterFile As Button
    Friend WithEvents CmdHeaderFile As Button
    Friend WithEvents TxtDocTitle As TextBox
    Friend WithEvents LblDocTitle As Label
    Friend WithEvents TxtTargetFolder As TextBox
    Friend WithEvents LblTargetFolder As Label
    Friend WithEvents TxtFileDocu As TextBox
    Friend WithEvents LblFileDocu As Label
    Friend WithEvents TxtFooter As TextBox
    Friend WithEvents LblFooter As Label
    Friend WithEvents TxtHeader As TextBox
    Friend WithEvents LblInfo As Label
    Friend WithEvents LblHeader As Label
    Friend WithEvents CbShowPDF As CheckBox
End Class
