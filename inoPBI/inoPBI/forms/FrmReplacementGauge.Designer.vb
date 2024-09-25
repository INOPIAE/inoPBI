<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReplacementGauge
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
        LblTo = New Label()
        LblFrom = New Label()
        TxtReplacementTo2 = New TextBox()
        TxtReplacementTo1 = New TextBox()
        TxtReplacementFrom2 = New TextBox()
        LblReplace2 = New Label()
        TxtReplacementFrom1 = New TextBox()
        LblReplace1 = New Label()
        TxtVisual = New TextBox()
        LblVisual = New Label()
        TxtPage = New TextBox()
        LblPage = New Label()
        CmdClose = New Button()
        CmdReplace = New Button()
        CmdFileReplacement = New Button()
        CmdFileOriginal = New Button()
        TxtReplace = New TextBox()
        LblRepacementSave = New Label()
        TxtOrginal = New TextBox()
        LblInfo = New Label()
        LblOriginal = New Label()
        CkbSwitchData = New CheckBox()
        TxtReplacementTo3 = New TextBox()
        TxtReplacementFrom3 = New TextBox()
        Label1 = New Label()
        TxtReplacementTo4 = New TextBox()
        TxtReplacementFrom4 = New TextBox()
        Label2 = New Label()
        TxtReplacementTo5 = New TextBox()
        TxtReplacementFrom5 = New TextBox()
        Label3 = New Label()
        TxtReplacementTo6 = New TextBox()
        TxtReplacementFrom6 = New TextBox()
        Label4 = New Label()
        dgvReplace = New DataGridView()
        CmdNew = New Button()
        TypeInternal = New DataGridViewTextBoxColumn()
        Type = New DataGridViewTextBoxColumn()
        FromV = New DataGridViewTextBoxColumn()
        ToV = New DataGridViewTextBoxColumn()
        RangeV = New DataGridViewTextBoxColumn()
        CType(dgvReplace, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblTo
        ' 
        LblTo.AutoSize = True
        LblTo.Location = New Point(465, 151)
        LblTo.Name = "LblTo"
        LblTo.Size = New Size(19, 15)
        LblTo.TabIndex = 70
        LblTo.Text = "To"
        ' 
        ' LblFrom
        ' 
        LblFrom.AutoSize = True
        LblFrom.Location = New Point(249, 151)
        LblFrom.Name = "LblFrom"
        LblFrom.Size = New Size(35, 15)
        LblFrom.TabIndex = 69
        LblFrom.Text = "From"
        ' 
        ' TxtReplacementTo2
        ' 
        TxtReplacementTo2.Location = New Point(465, 195)
        TxtReplacementTo2.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementTo2.Name = "TxtReplacementTo2"
        TxtReplacementTo2.Size = New Size(151, 23)
        TxtReplacementTo2.TabIndex = 68
        ' 
        ' TxtReplacementTo1
        ' 
        TxtReplacementTo1.Location = New Point(465, 168)
        TxtReplacementTo1.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementTo1.Name = "TxtReplacementTo1"
        TxtReplacementTo1.Size = New Size(151, 23)
        TxtReplacementTo1.TabIndex = 67
        ' 
        ' TxtReplacementFrom2
        ' 
        TxtReplacementFrom2.Location = New Point(249, 195)
        TxtReplacementFrom2.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementFrom2.Name = "TxtReplacementFrom2"
        TxtReplacementFrom2.Size = New Size(151, 23)
        TxtReplacementFrom2.TabIndex = 66
        ' 
        ' LblReplace2
        ' 
        LblReplace2.AutoSize = True
        LblReplace2.Location = New Point(76, 199)
        LblReplace2.Name = "LblReplace2"
        LblReplace2.Size = New Size(85, 15)
        LblReplace2.TabIndex = 65
        LblReplace2.Text = "Replacement 2"
        ' 
        ' TxtReplacementFrom1
        ' 
        TxtReplacementFrom1.Location = New Point(249, 168)
        TxtReplacementFrom1.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementFrom1.Name = "TxtReplacementFrom1"
        TxtReplacementFrom1.Size = New Size(151, 23)
        TxtReplacementFrom1.TabIndex = 64
        ' 
        ' LblReplace1
        ' 
        LblReplace1.AutoSize = True
        LblReplace1.Location = New Point(76, 172)
        LblReplace1.Name = "LblReplace1"
        LblReplace1.Size = New Size(85, 15)
        LblReplace1.TabIndex = 63
        LblReplace1.Text = "Replacement 1"
        ' 
        ' TxtVisual
        ' 
        TxtVisual.Location = New Point(249, 113)
        TxtVisual.Margin = New Padding(3, 2, 3, 2)
        TxtVisual.Name = "TxtVisual"
        TxtVisual.Size = New Size(151, 23)
        TxtVisual.TabIndex = 62
        ' 
        ' LblVisual
        ' 
        LblVisual.AutoSize = True
        LblVisual.Location = New Point(76, 117)
        LblVisual.Name = "LblVisual"
        LblVisual.Size = New Size(65, 15)
        LblVisual.TabIndex = 61
        LblVisual.Text = "Visual Type"
        ' 
        ' TxtPage
        ' 
        TxtPage.Location = New Point(249, 86)
        TxtPage.Margin = New Padding(3, 2, 3, 2)
        TxtPage.Name = "TxtPage"
        TxtPage.Size = New Size(151, 23)
        TxtPage.TabIndex = 60
        ' 
        ' LblPage
        ' 
        LblPage.AutoSize = True
        LblPage.Location = New Point(76, 90)
        LblPage.Name = "LblPage"
        LblPage.Size = New Size(33, 15)
        LblPage.TabIndex = 59
        LblPage.Text = "Page"
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(536, 503)
        CmdClose.Margin = New Padding(3, 2, 3, 2)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(110, 40)
        CmdClose.TabIndex = 57
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdReplace
        ' 
        CmdReplace.Location = New Point(414, 503)
        CmdReplace.Margin = New Padding(3, 2, 3, 2)
        CmdReplace.Name = "CmdReplace"
        CmdReplace.Size = New Size(110, 40)
        CmdReplace.TabIndex = 56
        CmdReplace.Text = "Replace"
        CmdReplace.UseVisualStyleBackColor = True
        ' 
        ' CmdFileReplacement
        ' 
        CmdFileReplacement.Location = New Point(698, 59)
        CmdFileReplacement.Margin = New Padding(3, 2, 3, 2)
        CmdFileReplacement.Name = "CmdFileReplacement"
        CmdFileReplacement.Size = New Size(26, 20)
        CmdFileReplacement.TabIndex = 55
        CmdFileReplacement.Text = "..."
        CmdFileReplacement.UseVisualStyleBackColor = True
        ' 
        ' CmdFileOriginal
        ' 
        CmdFileOriginal.Location = New Point(698, 35)
        CmdFileOriginal.Margin = New Padding(3, 2, 3, 2)
        CmdFileOriginal.Name = "CmdFileOriginal"
        CmdFileOriginal.Size = New Size(26, 20)
        CmdFileOriginal.TabIndex = 52
        CmdFileOriginal.Text = "..."
        CmdFileOriginal.UseVisualStyleBackColor = True
        ' 
        ' TxtReplace
        ' 
        TxtReplace.Location = New Point(249, 59)
        TxtReplace.Margin = New Padding(3, 2, 3, 2)
        TxtReplace.Name = "TxtReplace"
        TxtReplace.Size = New Size(444, 23)
        TxtReplace.TabIndex = 54
        ' 
        ' LblRepacementSave
        ' 
        LblRepacementSave.AutoSize = True
        LblRepacementSave.Location = New Point(76, 62)
        LblRepacementSave.Name = "LblRepacementSave"
        LblRepacementSave.Size = New Size(65, 15)
        LblRepacementSave.TabIndex = 53
        LblRepacementSave.Text = "Backup file"
        ' 
        ' TxtOrginal
        ' 
        TxtOrginal.Location = New Point(249, 34)
        TxtOrginal.Margin = New Padding(3, 2, 3, 2)
        TxtOrginal.Name = "TxtOrginal"
        TxtOrginal.Size = New Size(444, 23)
        TxtOrginal.TabIndex = 51
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(87, 516)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(28, 15)
        LblInfo.TabIndex = 58
        LblInfo.Text = "Info"
        ' 
        ' LblOriginal
        ' 
        LblOriginal.AutoSize = True
        LblOriginal.Location = New Point(76, 37)
        LblOriginal.Name = "LblOriginal"
        LblOriginal.Size = New Size(49, 15)
        LblOriginal.TabIndex = 50
        LblOriginal.Text = "Original"
        ' 
        ' CkbSwitchData
        ' 
        CkbSwitchData.AutoSize = True
        CkbSwitchData.Location = New Point(675, 169)
        CkbSwitchData.Name = "CkbSwitchData"
        CkbSwitchData.Size = New Size(85, 19)
        CkbSwitchData.TabIndex = 71
        CkbSwitchData.Text = "CheckBox1"
        CkbSwitchData.UseVisualStyleBackColor = True
        ' 
        ' TxtReplacementTo3
        ' 
        TxtReplacementTo3.Location = New Point(465, 231)
        TxtReplacementTo3.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementTo3.Name = "TxtReplacementTo3"
        TxtReplacementTo3.Size = New Size(151, 23)
        TxtReplacementTo3.TabIndex = 74
        ' 
        ' TxtReplacementFrom3
        ' 
        TxtReplacementFrom3.Location = New Point(249, 231)
        TxtReplacementFrom3.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementFrom3.Name = "TxtReplacementFrom3"
        TxtReplacementFrom3.Size = New Size(151, 23)
        TxtReplacementFrom3.TabIndex = 73
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(76, 235)
        Label1.Name = "Label1"
        Label1.Size = New Size(20, 15)
        Label1.TabIndex = 72
        Label1.Text = "X1"
        ' 
        ' TxtReplacementTo4
        ' 
        TxtReplacementTo4.Location = New Point(465, 258)
        TxtReplacementTo4.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementTo4.Name = "TxtReplacementTo4"
        TxtReplacementTo4.Size = New Size(151, 23)
        TxtReplacementTo4.TabIndex = 77
        ' 
        ' TxtReplacementFrom4
        ' 
        TxtReplacementFrom4.Location = New Point(249, 258)
        TxtReplacementFrom4.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementFrom4.Name = "TxtReplacementFrom4"
        TxtReplacementFrom4.Size = New Size(151, 23)
        TxtReplacementFrom4.TabIndex = 76
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(76, 262)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 15)
        Label2.TabIndex = 75
        Label2.Text = "X2"
        ' 
        ' TxtReplacementTo5
        ' 
        TxtReplacementTo5.Location = New Point(465, 295)
        TxtReplacementTo5.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementTo5.Name = "TxtReplacementTo5"
        TxtReplacementTo5.Size = New Size(151, 23)
        TxtReplacementTo5.TabIndex = 80
        ' 
        ' TxtReplacementFrom5
        ' 
        TxtReplacementFrom5.Location = New Point(249, 295)
        TxtReplacementFrom5.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementFrom5.Name = "TxtReplacementFrom5"
        TxtReplacementFrom5.Size = New Size(151, 23)
        TxtReplacementFrom5.TabIndex = 79
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(76, 299)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 15)
        Label3.TabIndex = 78
        Label3.Text = "Y1"
        ' 
        ' TxtReplacementTo6
        ' 
        TxtReplacementTo6.Location = New Point(465, 322)
        TxtReplacementTo6.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementTo6.Name = "TxtReplacementTo6"
        TxtReplacementTo6.Size = New Size(151, 23)
        TxtReplacementTo6.TabIndex = 83
        ' 
        ' TxtReplacementFrom6
        ' 
        TxtReplacementFrom6.Location = New Point(249, 322)
        TxtReplacementFrom6.Margin = New Padding(3, 2, 3, 2)
        TxtReplacementFrom6.Name = "TxtReplacementFrom6"
        TxtReplacementFrom6.Size = New Size(151, 23)
        TxtReplacementFrom6.TabIndex = 82
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(76, 325)
        Label4.Name = "Label4"
        Label4.Size = New Size(20, 15)
        Label4.TabIndex = 81
        Label4.Text = "Y2"
        ' 
        ' dgvReplace
        ' 
        dgvReplace.AllowUserToAddRows = False
        dgvReplace.AllowUserToDeleteRows = False
        dgvReplace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReplace.Columns.AddRange(New DataGridViewColumn() {TypeInternal, Type, FromV, ToV, RangeV})
        dgvReplace.Location = New Point(80, 375)
        dgvReplace.Name = "dgvReplace"
        dgvReplace.ReadOnly = True
        dgvReplace.RowTemplate.Height = 25
        dgvReplace.Size = New Size(566, 115)
        dgvReplace.TabIndex = 84
        ' 
        ' CmdNew
        ' 
        CmdNew.Location = New Point(690, 374)
        CmdNew.Name = "CmdNew"
        CmdNew.Size = New Size(89, 35)
        CmdNew.TabIndex = 85
        CmdNew.Text = "Button1"
        CmdNew.UseVisualStyleBackColor = True
        ' 
        ' TypeInternal
        ' 
        TypeInternal.HeaderText = "TypeInternal"
        TypeInternal.Name = "TypeInternal"
        TypeInternal.ReadOnly = True
        ' 
        ' Type
        ' 
        Type.HeaderText = "Type"
        Type.Name = "Type"
        Type.ReadOnly = True
        ' 
        ' FromV
        ' 
        FromV.HeaderText = "From"
        FromV.Name = "FromV"
        FromV.ReadOnly = True
        ' 
        ' ToV
        ' 
        ToV.HeaderText = "To"
        ToV.Name = "ToV"
        ToV.ReadOnly = True
        ' 
        ' RangeV
        ' 
        RangeV.HeaderText = "Range"
        RangeV.Name = "RangeV"
        RangeV.ReadOnly = True
        ' 
        ' FrmReplacementGauge
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 573)
        Controls.Add(CmdNew)
        Controls.Add(dgvReplace)
        Controls.Add(TxtReplacementTo6)
        Controls.Add(TxtReplacementFrom6)
        Controls.Add(Label4)
        Controls.Add(TxtReplacementTo5)
        Controls.Add(TxtReplacementFrom5)
        Controls.Add(Label3)
        Controls.Add(TxtReplacementTo4)
        Controls.Add(TxtReplacementFrom4)
        Controls.Add(Label2)
        Controls.Add(TxtReplacementTo3)
        Controls.Add(TxtReplacementFrom3)
        Controls.Add(Label1)
        Controls.Add(CkbSwitchData)
        Controls.Add(LblTo)
        Controls.Add(LblFrom)
        Controls.Add(TxtReplacementTo2)
        Controls.Add(TxtReplacementTo1)
        Controls.Add(TxtReplacementFrom2)
        Controls.Add(LblReplace2)
        Controls.Add(TxtReplacementFrom1)
        Controls.Add(LblReplace1)
        Controls.Add(TxtVisual)
        Controls.Add(LblVisual)
        Controls.Add(TxtPage)
        Controls.Add(LblPage)
        Controls.Add(CmdClose)
        Controls.Add(CmdReplace)
        Controls.Add(CmdFileReplacement)
        Controls.Add(CmdFileOriginal)
        Controls.Add(TxtReplace)
        Controls.Add(LblRepacementSave)
        Controls.Add(TxtOrginal)
        Controls.Add(LblInfo)
        Controls.Add(LblOriginal)
        Name = "FrmReplacementGauge"
        Text = "FrmReplacementGauge"
        CType(dgvReplace, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblTo As Label
    Friend WithEvents LblFrom As Label
    Friend WithEvents TxtReplacementTo2 As TextBox
    Friend WithEvents TxtReplacementTo1 As TextBox
    Friend WithEvents TxtReplacementFrom2 As TextBox
    Friend WithEvents LblReplace2 As Label
    Friend WithEvents TxtReplacementFrom1 As TextBox
    Friend WithEvents LblReplace1 As Label
    Friend WithEvents TxtVisual As TextBox
    Friend WithEvents LblVisual As Label
    Friend WithEvents TxtPage As TextBox
    Friend WithEvents LblPage As Label
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdReplace As Button
    Friend WithEvents CmdFileReplacement As Button
    Friend WithEvents CmdFileOriginal As Button
    Friend WithEvents TxtReplace As TextBox
    Friend WithEvents LblRepacementSave As Label
    Friend WithEvents TxtOrginal As TextBox
    Friend WithEvents LblInfo As Label
    Friend WithEvents LblOriginal As Label
    Friend WithEvents CkbSwitchData As CheckBox
    Friend WithEvents TxtReplacementTo3 As TextBox
    Friend WithEvents TxtReplacementFrom3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtReplacementTo4 As TextBox
    Friend WithEvents TxtReplacementFrom4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtReplacementTo5 As TextBox
    Friend WithEvents TxtReplacementFrom5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtReplacementTo6 As TextBox
    Friend WithEvents TxtReplacementFrom6 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvReplace As DataGridView
    Friend WithEvents CmdNew As Button
    Friend WithEvents TypeInternal As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents FromV As DataGridViewTextBoxColumn
    Friend WithEvents ToV As DataGridViewTextBoxColumn
    Friend WithEvents RangeV As DataGridViewTextBoxColumn
End Class
