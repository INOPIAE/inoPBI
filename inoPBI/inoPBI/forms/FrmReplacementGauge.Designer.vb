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
        dgvReplace = New DataGridView()
        TypeInternal = New DataGridViewTextBoxColumn()
        Type = New DataGridViewTextBoxColumn()
        FromV = New DataGridViewTextBoxColumn()
        ToV = New DataGridViewTextBoxColumn()
        RangeV = New DataGridViewTextBoxColumn()
        CmdNew = New Button()
        CmdEdit = New Button()
        CmdDelete = New Button()
        CType(dgvReplace, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtVisual
        ' 
        TxtVisual.Location = New Point(200, 112)
        TxtVisual.Margin = New Padding(3, 2, 3, 2)
        TxtVisual.Name = "TxtVisual"
        TxtVisual.Size = New Size(151, 23)
        TxtVisual.TabIndex = 9
        ' 
        ' LblVisual
        ' 
        LblVisual.AutoSize = True
        LblVisual.Location = New Point(27, 116)
        LblVisual.Name = "LblVisual"
        LblVisual.Size = New Size(65, 15)
        LblVisual.TabIndex = 8
        LblVisual.Text = "Visual Type"
        ' 
        ' TxtPage
        ' 
        TxtPage.Location = New Point(200, 85)
        TxtPage.Margin = New Padding(3, 2, 3, 2)
        TxtPage.Name = "TxtPage"
        TxtPage.Size = New Size(151, 23)
        TxtPage.TabIndex = 7
        ' 
        ' LblPage
        ' 
        LblPage.AutoSize = True
        LblPage.Location = New Point(27, 89)
        LblPage.Name = "LblPage"
        LblPage.Size = New Size(33, 15)
        LblPage.TabIndex = 6
        LblPage.Text = "Page"
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(487, 417)
        CmdClose.Margin = New Padding(3, 2, 3, 2)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(110, 40)
        CmdClose.TabIndex = 14
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdReplace
        ' 
        CmdReplace.Location = New Point(365, 417)
        CmdReplace.Margin = New Padding(3, 2, 3, 2)
        CmdReplace.Name = "CmdReplace"
        CmdReplace.Size = New Size(110, 40)
        CmdReplace.TabIndex = 13
        CmdReplace.Text = "Replace"
        CmdReplace.UseVisualStyleBackColor = True
        ' 
        ' CmdFileReplacement
        ' 
        CmdFileReplacement.Location = New Point(649, 58)
        CmdFileReplacement.Margin = New Padding(3, 2, 3, 2)
        CmdFileReplacement.Name = "CmdFileReplacement"
        CmdFileReplacement.Size = New Size(26, 20)
        CmdFileReplacement.TabIndex = 5
        CmdFileReplacement.Text = "..."
        CmdFileReplacement.UseVisualStyleBackColor = True
        ' 
        ' CmdFileOriginal
        ' 
        CmdFileOriginal.Location = New Point(649, 34)
        CmdFileOriginal.Margin = New Padding(3, 2, 3, 2)
        CmdFileOriginal.Name = "CmdFileOriginal"
        CmdFileOriginal.Size = New Size(26, 20)
        CmdFileOriginal.TabIndex = 2
        CmdFileOriginal.Text = "..."
        CmdFileOriginal.UseVisualStyleBackColor = True
        ' 
        ' TxtReplace
        ' 
        TxtReplace.Location = New Point(200, 58)
        TxtReplace.Margin = New Padding(3, 2, 3, 2)
        TxtReplace.Name = "TxtReplace"
        TxtReplace.Size = New Size(444, 23)
        TxtReplace.TabIndex = 4
        ' 
        ' LblRepacementSave
        ' 
        LblRepacementSave.AutoSize = True
        LblRepacementSave.Location = New Point(27, 61)
        LblRepacementSave.Name = "LblRepacementSave"
        LblRepacementSave.Size = New Size(65, 15)
        LblRepacementSave.TabIndex = 3
        LblRepacementSave.Text = "Backup file"
        ' 
        ' TxtOrginal
        ' 
        TxtOrginal.Location = New Point(200, 33)
        TxtOrginal.Margin = New Padding(3, 2, 3, 2)
        TxtOrginal.Name = "TxtOrginal"
        TxtOrginal.Size = New Size(444, 23)
        TxtOrginal.TabIndex = 1
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(27, 430)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(28, 15)
        LblInfo.TabIndex = 16
        LblInfo.Text = "Info"
        ' 
        ' LblOriginal
        ' 
        LblOriginal.AutoSize = True
        LblOriginal.Location = New Point(27, 36)
        LblOriginal.Name = "LblOriginal"
        LblOriginal.Size = New Size(49, 15)
        LblOriginal.TabIndex = 0
        LblOriginal.Text = "Original"
        ' 
        ' CkbSwitchData
        ' 
        CkbSwitchData.AutoSize = True
        CkbSwitchData.Location = New Point(626, 112)
        CkbSwitchData.Name = "CkbSwitchData"
        CkbSwitchData.Size = New Size(85, 19)
        CkbSwitchData.TabIndex = 37
        CkbSwitchData.Text = "CheckBox1"
        CkbSwitchData.UseVisualStyleBackColor = True
        ' 
        ' dgvReplace
        ' 
        dgvReplace.AllowUserToAddRows = False
        dgvReplace.AllowUserToDeleteRows = False
        dgvReplace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReplace.Columns.AddRange(New DataGridViewColumn() {TypeInternal, Type, FromV, ToV, RangeV})
        dgvReplace.Location = New Point(27, 156)
        dgvReplace.MultiSelect = False
        dgvReplace.Name = "dgvReplace"
        dgvReplace.ReadOnly = True
        dgvReplace.RowTemplate.Height = 25
        dgvReplace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReplace.Size = New Size(566, 256)
        dgvReplace.TabIndex = 15
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
        ' CmdNew
        ' 
        CmdNew.Location = New Point(626, 154)
        CmdNew.Name = "CmdNew"
        CmdNew.Size = New Size(162, 35)
        CmdNew.TabIndex = 10
        CmdNew.Text = "Button1"
        CmdNew.UseVisualStyleBackColor = True
        ' 
        ' CmdEdit
        ' 
        CmdEdit.Location = New Point(626, 195)
        CmdEdit.Name = "CmdEdit"
        CmdEdit.Size = New Size(162, 35)
        CmdEdit.TabIndex = 11
        CmdEdit.Text = "Button1"
        CmdEdit.UseVisualStyleBackColor = True
        ' 
        ' CmdDelete
        ' 
        CmdDelete.Location = New Point(626, 236)
        CmdDelete.Name = "CmdDelete"
        CmdDelete.Size = New Size(162, 35)
        CmdDelete.TabIndex = 12
        CmdDelete.Text = "Button1"
        CmdDelete.UseVisualStyleBackColor = True
        ' 
        ' FrmReplacementGauge
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 468)
        Controls.Add(CmdDelete)
        Controls.Add(CmdEdit)
        Controls.Add(CmdNew)
        Controls.Add(dgvReplace)
        Controls.Add(CkbSwitchData)
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
    Friend WithEvents dgvReplace As DataGridView
    Friend WithEvents CmdNew As Button
    Friend WithEvents TypeInternal As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents FromV As DataGridViewTextBoxColumn
    Friend WithEvents ToV As DataGridViewTextBoxColumn
    Friend WithEvents RangeV As DataGridViewTextBoxColumn
    Friend WithEvents CmdEdit As Button
    Friend WithEvents CmdDelete As Button
End Class
