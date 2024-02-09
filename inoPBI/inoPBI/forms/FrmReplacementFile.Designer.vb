<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReplacementFile
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
        SpReplacement = New SplitContainer()
        CmdDown = New Button()
        CmdUp = New Button()
        CmdDeleteEntry = New Button()
        CmdClose = New Button()
        CmdSaveAs = New Button()
        CmdSave = New Button()
        DgvReplacement = New DataGridView()
        NameDef = New DataGridViewTextBoxColumn()
        From = New DataGridViewTextBoxColumn()
        Traget = New DataGridViewTextBoxColumn()
        CType(SpReplacement, ComponentModel.ISupportInitialize).BeginInit()
        SpReplacement.Panel1.SuspendLayout()
        SpReplacement.Panel2.SuspendLayout()
        SpReplacement.SuspendLayout()
        CType(DgvReplacement, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SpReplacement
        ' 
        SpReplacement.Dock = DockStyle.Fill
        SpReplacement.FixedPanel = FixedPanel.Panel1
        SpReplacement.Location = New Point(0, 0)
        SpReplacement.Name = "SpReplacement"
        SpReplacement.Orientation = Orientation.Horizontal
        ' 
        ' SpReplacement.Panel1
        ' 
        SpReplacement.Panel1.Controls.Add(CmdDown)
        SpReplacement.Panel1.Controls.Add(CmdUp)
        SpReplacement.Panel1.Controls.Add(CmdDeleteEntry)
        SpReplacement.Panel1.Controls.Add(CmdClose)
        SpReplacement.Panel1.Controls.Add(CmdSaveAs)
        SpReplacement.Panel1.Controls.Add(CmdSave)
        ' 
        ' SpReplacement.Panel2
        ' 
        SpReplacement.Panel2.Controls.Add(DgvReplacement)
        SpReplacement.Size = New Size(800, 450)
        SpReplacement.SplitterDistance = 63
        SpReplacement.TabIndex = 0
        ' 
        ' CmdDown
        ' 
        CmdDown.Location = New Point(652, 12)
        CmdDown.Name = "CmdDown"
        CmdDown.Size = New Size(131, 36)
        CmdDown.TabIndex = 5
        CmdDown.Text = "Down"
        CmdDown.UseVisualStyleBackColor = True
        ' 
        ' CmdUp
        ' 
        CmdUp.Location = New Point(515, 12)
        CmdUp.Name = "CmdUp"
        CmdUp.Size = New Size(131, 36)
        CmdUp.TabIndex = 4
        CmdUp.Text = "Up"
        CmdUp.UseVisualStyleBackColor = True
        ' 
        ' CmdDeleteEntry
        ' 
        CmdDeleteEntry.Location = New Point(378, 12)
        CmdDeleteEntry.Name = "CmdDeleteEntry"
        CmdDeleteEntry.Size = New Size(131, 36)
        CmdDeleteEntry.TabIndex = 3
        CmdDeleteEntry.Text = "Delete entry"
        CmdDeleteEntry.UseVisualStyleBackColor = True
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(207, 12)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(70, 36)
        CmdClose.TabIndex = 2
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdSaveAs
        ' 
        CmdSaveAs.Location = New Point(114, 12)
        CmdSaveAs.Name = "CmdSaveAs"
        CmdSaveAs.Size = New Size(70, 36)
        CmdSaveAs.TabIndex = 1
        CmdSaveAs.Text = "Save as"
        CmdSaveAs.UseVisualStyleBackColor = True
        ' 
        ' CmdSave
        ' 
        CmdSave.Location = New Point(24, 12)
        CmdSave.Name = "CmdSave"
        CmdSave.Size = New Size(70, 36)
        CmdSave.TabIndex = 0
        CmdSave.Text = "Save"
        CmdSave.UseVisualStyleBackColor = True
        ' 
        ' DgvReplacement
        ' 
        DgvReplacement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvReplacement.Columns.AddRange(New DataGridViewColumn() {NameDef, From, Traget})
        DgvReplacement.Dock = DockStyle.Fill
        DgvReplacement.Location = New Point(0, 0)
        DgvReplacement.Name = "DgvReplacement"
        DgvReplacement.RowHeadersWidth = 51
        DgvReplacement.RowTemplate.Height = 29
        DgvReplacement.Size = New Size(800, 383)
        DgvReplacement.TabIndex = 0
        ' 
        ' NameDef
        ' 
        NameDef.HeaderText = "Name"
        NameDef.MinimumWidth = 6
        NameDef.Name = "NameDef"
        NameDef.Width = 125
        ' 
        ' From
        ' 
        From.HeaderText = "From"
        From.MinimumWidth = 6
        From.Name = "From"
        From.Width = 125
        ' 
        ' Traget
        ' 
        Traget.HeaderText = "To"
        Traget.MinimumWidth = 6
        Traget.Name = "Traget"
        Traget.Width = 125
        ' 
        ' FrmReplacementFile
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SpReplacement)
        Name = "FrmReplacementFile"
        Text = "FrmReplacementFile"
        SpReplacement.Panel1.ResumeLayout(False)
        SpReplacement.Panel2.ResumeLayout(False)
        CType(SpReplacement, ComponentModel.ISupportInitialize).EndInit()
        SpReplacement.ResumeLayout(False)
        CType(DgvReplacement, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SpReplacement As SplitContainer
    Friend WithEvents DgvReplacement As DataGridView
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdSaveAs As Button
    Friend WithEvents CmdSave As Button
    Friend WithEvents NameDef As DataGridViewTextBoxColumn
    Friend WithEvents From As DataGridViewTextBoxColumn
    Friend WithEvents Traget As DataGridViewTextBoxColumn
    Friend WithEvents CmdDeleteEntry As Button
    Friend WithEvents CmdDown As Button
    Friend WithEvents CmdUp As Button
End Class
