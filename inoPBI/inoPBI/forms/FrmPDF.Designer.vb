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
        CmdPDF = New Button()
        CmdTargetFile = New Button()
        CmdFileDocu = New Button()
        CmdFooterFile = New Button()
        CmdHeaderFile = New Button()
        TxtDocTitle = New TextBox()
        LblDocTitle = New Label()
        TxtTargetFile = New TextBox()
        LblTargetFile = New Label()
        TxtFileDocu = New TextBox()
        LblFileDocu = New Label()
        TxtFooter = New TextBox()
        LblFooter = New Label()
        TxtHeader = New TextBox()
        LblInfo = New Label()
        LblHeader = New Label()
        CbShowPDF = New CheckBox()
        CmdEditHeader = New Button()
        CmdEditFooter = New Button()
        LblPowerBIFile = New Label()
        TxtPowerBIFile = New TextBox()
        CmdPowerBIFile = New Button()
        CmdDocumentation = New Button()
        LblInfoMD = New Label()
        SuspendLayout()
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(516, 265)
        CmdClose.Margin = New Padding(3, 2, 3, 2)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(102, 40)
        CmdClose.TabIndex = 22
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdPDF
        ' 
        CmdPDF.Location = New Point(341, 265)
        CmdPDF.Margin = New Padding(3, 2, 3, 2)
        CmdPDF.Name = "CmdPDF"
        CmdPDF.Size = New Size(102, 40)
        CmdPDF.TabIndex = 21
        CmdPDF.Text = "Create PDF"
        CmdPDF.UseVisualStyleBackColor = True
        ' 
        ' CmdTargetFile
        ' 
        CmdTargetFile.Location = New Point(622, 145)
        CmdTargetFile.Margin = New Padding(3, 2, 3, 2)
        CmdTargetFile.Name = "CmdTargetFile"
        CmdTargetFile.Size = New Size(26, 20)
        CmdTargetFile.TabIndex = 16
        CmdTargetFile.Text = "..."
        CmdTargetFile.UseVisualStyleBackColor = True
        ' 
        ' CmdFileDocu
        ' 
        CmdFileDocu.Location = New Point(622, 70)
        CmdFileDocu.Margin = New Padding(3, 2, 3, 2)
        CmdFileDocu.Name = "CmdFileDocu"
        CmdFileDocu.Size = New Size(26, 20)
        CmdFileDocu.TabIndex = 5
        CmdFileDocu.Text = "..."
        CmdFileDocu.UseVisualStyleBackColor = True
        ' 
        ' CmdFooterFile
        ' 
        CmdFooterFile.Location = New Point(622, 119)
        CmdFooterFile.Margin = New Padding(3, 2, 3, 2)
        CmdFooterFile.Name = "CmdFooterFile"
        CmdFooterFile.Size = New Size(26, 20)
        CmdFooterFile.TabIndex = 12
        CmdFooterFile.Text = "..."
        CmdFooterFile.UseVisualStyleBackColor = True
        ' 
        ' CmdHeaderFile
        ' 
        CmdHeaderFile.Location = New Point(622, 95)
        CmdHeaderFile.Margin = New Padding(3, 2, 3, 2)
        CmdHeaderFile.Name = "CmdHeaderFile"
        CmdHeaderFile.Size = New Size(26, 20)
        CmdHeaderFile.TabIndex = 8
        CmdHeaderFile.Text = "..."
        CmdHeaderFile.UseVisualStyleBackColor = True
        ' 
        ' TxtDocTitle
        ' 
        TxtDocTitle.Location = New Point(174, 169)
        TxtDocTitle.Margin = New Padding(3, 2, 3, 2)
        TxtDocTitle.Name = "TxtDocTitle"
        TxtDocTitle.Size = New Size(444, 23)
        TxtDocTitle.TabIndex = 18
        ' 
        ' LblDocTitle
        ' 
        LblDocTitle.AutoSize = True
        LblDocTitle.Location = New Point(22, 172)
        LblDocTitle.Name = "LblDocTitle"
        LblDocTitle.Size = New Size(86, 15)
        LblDocTitle.TabIndex = 17
        LblDocTitle.Text = "Document title"
        ' 
        ' TxtTargetFile
        ' 
        TxtTargetFile.Location = New Point(174, 143)
        TxtTargetFile.Margin = New Padding(3, 2, 3, 2)
        TxtTargetFile.Name = "TxtTargetFile"
        TxtTargetFile.Size = New Size(444, 23)
        TxtTargetFile.TabIndex = 15
        ' 
        ' LblTargetFile
        ' 
        LblTargetFile.AutoSize = True
        LblTargetFile.Location = New Point(22, 147)
        LblTargetFile.Name = "LblTargetFile"
        LblTargetFile.Size = New Size(58, 15)
        LblTargetFile.TabIndex = 14
        LblTargetFile.Text = "Target file"
        ' 
        ' TxtFileDocu
        ' 
        TxtFileDocu.Location = New Point(174, 70)
        TxtFileDocu.Margin = New Padding(3, 2, 3, 2)
        TxtFileDocu.Name = "TxtFileDocu"
        TxtFileDocu.Size = New Size(444, 23)
        TxtFileDocu.TabIndex = 4
        ' 
        ' LblFileDocu
        ' 
        LblFileDocu.AutoSize = True
        LblFileDocu.Location = New Point(22, 72)
        LblFileDocu.Name = "LblFileDocu"
        LblFileDocu.Size = New Size(109, 15)
        LblFileDocu.TabIndex = 3
        LblFileDocu.Text = "Dokumentation file"
        ' 
        ' TxtFooter
        ' 
        TxtFooter.Location = New Point(174, 119)
        TxtFooter.Margin = New Padding(3, 2, 3, 2)
        TxtFooter.Name = "TxtFooter"
        TxtFooter.Size = New Size(444, 23)
        TxtFooter.TabIndex = 11
        ' 
        ' LblFooter
        ' 
        LblFooter.AutoSize = True
        LblFooter.Location = New Point(22, 122)
        LblFooter.Name = "LblFooter"
        LblFooter.Size = New Size(97, 15)
        LblFooter.TabIndex = 10
        LblFooter.Text = "Footer HTML File"
        ' 
        ' TxtHeader
        ' 
        TxtHeader.Location = New Point(174, 94)
        TxtHeader.Margin = New Padding(3, 2, 3, 2)
        TxtHeader.Name = "TxtHeader"
        TxtHeader.Size = New Size(444, 23)
        TxtHeader.TabIndex = 7
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(22, 232)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(28, 15)
        LblInfo.TabIndex = 23
        LblInfo.Text = "Info"
        ' 
        ' LblHeader
        ' 
        LblHeader.AutoSize = True
        LblHeader.Location = New Point(22, 98)
        LblHeader.Name = "LblHeader"
        LblHeader.Size = New Size(99, 15)
        LblHeader.TabIndex = 6
        LblHeader.Text = "Header HTML file"
        ' 
        ' CbShowPDF
        ' 
        CbShowPDF.AutoSize = True
        CbShowPDF.CheckAlign = ContentAlignment.MiddleRight
        CbShowPDF.Location = New Point(19, 201)
        CbShowPDF.Margin = New Padding(3, 2, 3, 2)
        CbShowPDF.Name = "CbShowPDF"
        CbShowPDF.Size = New Size(100, 19)
        CbShowPDF.TabIndex = 19
        CbShowPDF.Text = "Show PDF File"
        CbShowPDF.UseVisualStyleBackColor = True
        ' 
        ' CmdEditHeader
        ' 
        CmdEditHeader.Location = New Point(684, 93)
        CmdEditHeader.Margin = New Padding(3, 2, 3, 2)
        CmdEditHeader.Name = "CmdEditHeader"
        CmdEditHeader.Size = New Size(102, 22)
        CmdEditHeader.TabIndex = 9
        CmdEditHeader.Text = "Edit"
        CmdEditHeader.UseVisualStyleBackColor = True
        ' 
        ' CmdEditFooter
        ' 
        CmdEditFooter.Location = New Point(684, 117)
        CmdEditFooter.Margin = New Padding(3, 2, 3, 2)
        CmdEditFooter.Name = "CmdEditFooter"
        CmdEditFooter.Size = New Size(102, 22)
        CmdEditFooter.TabIndex = 13
        CmdEditFooter.Text = "Edit"
        CmdEditFooter.UseVisualStyleBackColor = True
        ' 
        ' LblPowerBIFile
        ' 
        LblPowerBIFile.AutoSize = True
        LblPowerBIFile.Location = New Point(22, 45)
        LblPowerBIFile.Name = "LblPowerBIFile"
        LblPowerBIFile.Size = New Size(72, 15)
        LblPowerBIFile.TabIndex = 0
        LblPowerBIFile.Text = "Power BI file"
        ' 
        ' TxtPowerBIFile
        ' 
        TxtPowerBIFile.Location = New Point(174, 43)
        TxtPowerBIFile.Margin = New Padding(3, 2, 3, 2)
        TxtPowerBIFile.Name = "TxtPowerBIFile"
        TxtPowerBIFile.Size = New Size(444, 23)
        TxtPowerBIFile.TabIndex = 1
        ' 
        ' CmdPowerBIFile
        ' 
        CmdPowerBIFile.Location = New Point(622, 43)
        CmdPowerBIFile.Margin = New Padding(3, 2, 3, 2)
        CmdPowerBIFile.Name = "CmdPowerBIFile"
        CmdPowerBIFile.Size = New Size(26, 20)
        CmdPowerBIFile.TabIndex = 2
        CmdPowerBIFile.Text = "..."
        CmdPowerBIFile.UseVisualStyleBackColor = True
        ' 
        ' CmdDocumentation
        ' 
        CmdDocumentation.Location = New Point(174, 265)
        CmdDocumentation.Margin = New Padding(3, 2, 3, 2)
        CmdDocumentation.Name = "CmdDocumentation"
        CmdDocumentation.Size = New Size(102, 40)
        CmdDocumentation.TabIndex = 20
        CmdDocumentation.Text = "Create Documentation"
        CmdDocumentation.UseVisualStyleBackColor = True
        ' 
        ' LblInfoMD
        ' 
        LblInfoMD.AutoSize = True
        LblInfoMD.Location = New Point(654, 73)
        LblInfoMD.Name = "LblInfoMD"
        LblInfoMD.Size = New Size(41, 15)
        LblInfoMD.TabIndex = 24
        LblInfoMD.Text = "Label1"
        ' 
        ' FrmPDF
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(825, 338)
        Controls.Add(LblInfoMD)
        Controls.Add(CmdEditFooter)
        Controls.Add(CmdEditHeader)
        Controls.Add(CbShowPDF)
        Controls.Add(CmdClose)
        Controls.Add(CmdDocumentation)
        Controls.Add(CmdPDF)
        Controls.Add(CmdTargetFile)
        Controls.Add(CmdPowerBIFile)
        Controls.Add(CmdFileDocu)
        Controls.Add(CmdFooterFile)
        Controls.Add(CmdHeaderFile)
        Controls.Add(TxtDocTitle)
        Controls.Add(LblDocTitle)
        Controls.Add(TxtTargetFile)
        Controls.Add(LblTargetFile)
        Controls.Add(TxtPowerBIFile)
        Controls.Add(LblPowerBIFile)
        Controls.Add(TxtFileDocu)
        Controls.Add(LblFileDocu)
        Controls.Add(TxtFooter)
        Controls.Add(LblFooter)
        Controls.Add(TxtHeader)
        Controls.Add(LblInfo)
        Controls.Add(LblHeader)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FrmPDF"
        Text = "FrmPDF"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdPDF As Button
    Friend WithEvents CmdTargetFile As Button
    Friend WithEvents CmdFileDocu As Button
    Friend WithEvents CmdFooterFile As Button
    Friend WithEvents CmdHeaderFile As Button
    Friend WithEvents TxtDocTitle As TextBox
    Friend WithEvents LblDocTitle As Label
    Friend WithEvents TxtTargetFile As TextBox
    Friend WithEvents LblTargetFile As Label
    Friend WithEvents TxtFileDocu As TextBox
    Friend WithEvents LblFileDocu As Label
    Friend WithEvents TxtFooter As TextBox
    Friend WithEvents LblFooter As Label
    Friend WithEvents TxtHeader As TextBox
    Friend WithEvents LblInfo As Label
    Friend WithEvents LblHeader As Label
    Friend WithEvents CbShowPDF As CheckBox
    Friend WithEvents CmdEditHeader As Button
    Friend WithEvents CmdEditFooter As Button
    Friend WithEvents LblPowerBIFile As Label
    Friend WithEvents TxtPowerBIFile As TextBox
    Friend WithEvents CmdPowerBIFile As Button
    Friend WithEvents CmdDocumentation As Button
    Friend WithEvents LblInfoMD As Label
End Class
