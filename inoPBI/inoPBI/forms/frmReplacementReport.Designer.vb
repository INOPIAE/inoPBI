<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReplacementReport
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
        CmdReplace = New Button()
        CmdFileReplacement = New Button()
        CmdFileOriginal = New Button()
        TxtReplace = New TextBox()
        Me.LblRepacementSave = New Label()
        TxtOrginal = New TextBox()
        LblInfo = New Label()
        LblOriginal = New Label()
        TxtPage = New TextBox()
        Me.LblPage = New Label()
        TxtVisual = New TextBox()
        Me.LblVisual = New Label()
        TxtReplacementFrom1 = New TextBox()
        Me.LblReplace1 = New Label()
        TxtReplacementFrom2 = New TextBox()
        LblReplace2 = New Label()
        TxtReplacementTo2 = New TextBox()
        TxtReplacementTo1 = New TextBox()
        LblFrom = New Label()
        LblTo = New Label()
        SuspendLayout()
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(491, 372)
        CmdClose.Margin = New Padding(3, 2, 3, 2)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(110, 40)
        CmdClose.TabIndex = 36
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdReplace
        ' 
        CmdReplace.Location = New Point(369, 372)
        CmdReplace.Margin = New Padding(3, 2, 3, 2)
        CmdReplace.Name = "CmdReplace"
        CmdReplace.Size = New Size(110, 40)
        CmdReplace.TabIndex = 35
        CmdReplace.Text = "Replace"
        CmdReplace.UseVisualStyleBackColor = True
        ' 
        ' CmdFileReplacement
        ' 
        CmdFileReplacement.Location = New Point(664, 54)
        CmdFileReplacement.Margin = New Padding(3, 2, 3, 2)
        CmdFileReplacement.Name = "CmdFileReplacement"
        CmdFileReplacement.Size = New Size(26, 20)
        CmdFileReplacement.TabIndex = 25
        CmdFileReplacement.Text = "..."
        CmdFileReplacement.UseVisualStyleBackColor = True
        ' 
        ' CmdFileOriginal
        ' 
        CmdFileOriginal.Location = New Point(664, 30)
        CmdFileOriginal.Margin = New Padding(3, 2, 3, 2)
        CmdFileOriginal.Name = "CmdFileOriginal"
        CmdFileOriginal.Size = New Size(26, 20)
        CmdFileOriginal.TabIndex = 22
        CmdFileOriginal.Text = "..."
        CmdFileOriginal.UseVisualStyleBackColor = True
        ' 
        ' TxtReplace
        ' 
        TxtReplace.Location = New Point(215, 54)
        TxtReplace.Margin = New Padding(3, 2, 3, 2)
        TxtReplace.Name = "TxtReplace"
        TxtReplace.Size = New Size(444, 23)
        TxtReplace.TabIndex = 24
        ' 
        ' LblRepacementSave
        ' 
        Me.LblRepacementSave.AutoSize = True
        Me.LblRepacementSave.Location = New Point(42, 57)
        Me.LblRepacementSave.Name = "LblRepacementSave"
        Me.LblRepacementSave.Size = New Size(65, 15)
        Me.LblRepacementSave.TabIndex = 23
        Me.LblRepacementSave.Text = "Backup file"
        ' 
        ' TxtOrginal
        ' 
        TxtOrginal.Location = New Point(215, 29)
        TxtOrginal.Margin = New Padding(3, 2, 3, 2)
        TxtOrginal.Name = "TxtOrginal"
        TxtOrginal.Size = New Size(444, 23)
        TxtOrginal.TabIndex = 21
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(50, 337)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(28, 15)
        LblInfo.TabIndex = 37
        LblInfo.Text = "Info"
        ' 
        ' LblOriginal
        ' 
        LblOriginal.AutoSize = True
        LblOriginal.Location = New Point(42, 32)
        LblOriginal.Name = "LblOriginal"
        LblOriginal.Size = New Size(49, 15)
        LblOriginal.TabIndex = 20
        LblOriginal.Text = "Original"
        ' 
        ' TxtPage
        ' 
        TxtPage.Location = New Point(215, 134)
        TxtPage.Margin = New Padding(3, 2, 3, 2)
        TxtPage.Name = "TxtPage"
        TxtPage.Size = New Size(151, 23)
        TxtPage.TabIndex = 39
        ' 
        ' LblPage
        ' 
        Me.LblPage.AutoSize = True
        Me.LblPage.Location = New Point(42, 138)
        Me.LblPage.Name = "LblPage"
        Me.LblPage.Size = New Size(33, 15)
        Me.LblPage.TabIndex = 38
        Me.LblPage.Text = "Page"
        ' 
        ' TxtVisual
        ' 
        TxtVisual.Location = New Point(215, 185)
        TxtVisual.Margin = New Padding(3, 2, 3, 2)
        TxtVisual.Name = "TxtVisual"
        TxtVisual.Size = New Size(151, 23)
        TxtVisual.TabIndex = 41
        ' 
        ' LblVisual
        ' 
        Me.LblVisual.AutoSize = True
        Me.LblVisual.Location = New Point(42, 189)
        Me.LblVisual.Name = "LblVisual"
        Me.LblVisual.Size = New Size(65, 15)
        Me.LblVisual.TabIndex = 40
        Me.LblVisual.Text = "Visual Type"
        ' 
        ' TxtReplacementFrom1
        ' 
        TxtReplacementFrom1.Location = New Point(215, 246)
        TxtReplacementFrom1.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementFrom1.Name = "TxtReplacementFrom1"
        TxtReplacementFrom1.Size = New Size(151, 23)
        TxtReplacementFrom1.TabIndex = 43
        ' 
        ' LblReplace1
        ' 
        Me.LblReplace1.AutoSize = True
        Me.LblReplace1.Location = New Point(42, 250)
        Me.LblReplace1.Name = "LblReplace1"
        Me.LblReplace1.Size = New Size(85, 15)
        Me.LblReplace1.TabIndex = 42
        Me.LblReplace1.Text = "Replacement 1"
        ' 
        ' TxtReplacementFrom2
        ' 
        TxtReplacementFrom2.Location = New Point(215, 273)
        TxtReplacementFrom2.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementFrom2.Name = "TxtReplacementFrom2"
        TxtReplacementFrom2.Size = New Size(151, 23)
        TxtReplacementFrom2.TabIndex = 45
        ' 
        ' LblReplace2
        ' 
        LblReplace2.AutoSize = True
        LblReplace2.Location = New Point(42, 277)
        LblReplace2.Name = "LblReplace2"
        LblReplace2.Size = New Size(85, 15)
        LblReplace2.TabIndex = 44
        LblReplace2.Text = "Replacement 2"
        ' 
        ' TxtReplacementTo2
        ' 
        TxtReplacementTo2.Location = New Point(431, 273)
        TxtReplacementTo2.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementTo2.Name = "TxtReplacementTo2"
        TxtReplacementTo2.Size = New Size(151, 23)
        TxtReplacementTo2.TabIndex = 47
        ' 
        ' TxtReplacementTo1
        ' 
        TxtReplacementTo1.Location = New Point(431, 246)
        TxtReplacementTo1.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementTo1.Name = "TxtReplacementTo1"
        TxtReplacementTo1.Size = New Size(151, 23)
        TxtReplacementTo1.TabIndex = 46
        ' 
        ' LblFrom
        ' 
        LblFrom.AutoSize = True
        LblFrom.Location = New Point(215, 229)
        LblFrom.Name = "LblFrom"
        LblFrom.Size = New Size(35, 15)
        LblFrom.TabIndex = 48
        LblFrom.Text = "From"
        ' 
        ' LblTo
        ' 
        LblTo.AutoSize = True
        LblTo.Location = New Point(431, 229)
        LblTo.Name = "LblTo"
        LblTo.Size = New Size(19, 15)
        LblTo.TabIndex = 49
        LblTo.Text = "To"
        ' 
        ' frmReplacementReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LblTo)
        Controls.Add(LblFrom)
        Controls.Add(TxtReplacementTo2)
        Controls.Add(TxtReplacementTo1)
        Controls.Add(TxtReplacementFrom2)
        Controls.Add(LblReplace2)
        Controls.Add(TxtReplacementFrom1)
        Controls.Add(Me.LblReplace1)
        Controls.Add(TxtVisual)
        Controls.Add(Me.LblVisual)
        Controls.Add(TxtPage)
        Controls.Add(Me.LblPage)
        Controls.Add(CmdClose)
        Controls.Add(CmdReplace)
        Controls.Add(CmdFileReplacement)
        Controls.Add(CmdFileOriginal)
        Controls.Add(TxtReplace)
        Controls.Add(Me.LblRepacementSave)
        Controls.Add(TxtOrginal)
        Controls.Add(LblInfo)
        Controls.Add(LblOriginal)
        Name = "frmReplacementReport"
        Text = "frmReplacementReport"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdReplace As Button
    Friend WithEvents CmdFileReplacement As Button
    Friend WithEvents CmdFileOriginal As Button
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents LblCustomer As Label
    Friend WithEvents TxtReplace As TextBox
    Friend WithEvents LblRepacementSave As Label
    Friend WithEvents TxtOrginal As TextBox
    Friend WithEvents LblInfo As Label
    Friend WithEvents LblOriginal As Label
    Friend WithEvents TxtPage As TextBox
    Friend WithEvents LblPage As Label
    Friend WithEvents TxtVisual As TextBox
    Friend WithEvents LblVisual As Label
    Friend WithEvents TxtReplacementFrom1 As TextBox
    Friend WithEvents LblReplace1 As Label
    Friend WithEvents TxtReplacementFrom2 As TextBox
    Friend WithEvents LblReplace2 As Label
    Friend WithEvents TxtReplacementTo2 As TextBox
    Friend WithEvents TxtReplacementTo1 As TextBox
    Friend WithEvents LblFrom As Label
    Friend WithEvents LblTo As Label
End Class
