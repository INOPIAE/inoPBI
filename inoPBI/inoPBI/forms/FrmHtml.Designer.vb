<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHtml
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
        SpText = New SplitContainer()
        CmdClose = New Button()
        CmdSaveAs = New Button()
        CmdSave = New Button()
        CmdOpen = New Button()
        TxtText = New TextBox()
        CType(SpText, ComponentModel.ISupportInitialize).BeginInit()
        SpText.Panel1.SuspendLayout()
        SpText.Panel2.SuspendLayout()
        SpText.SuspendLayout()
        SuspendLayout()
        ' 
        ' SpText
        ' 
        SpText.Dock = DockStyle.Fill
        SpText.Location = New Point(0, 0)
        SpText.Name = "SpText"
        ' 
        ' SpText.Panel1
        ' 
        SpText.Panel1.Controls.Add(CmdClose)
        SpText.Panel1.Controls.Add(CmdSaveAs)
        SpText.Panel1.Controls.Add(CmdSave)
        SpText.Panel1.Controls.Add(CmdOpen)
        ' 
        ' SpText.Panel2
        ' 
        SpText.Panel2.Controls.Add(TxtText)
        SpText.Size = New Size(800, 450)
        SpText.SplitterDistance = 149
        SpText.TabIndex = 0
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(12, 135)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(125, 29)
        CmdClose.TabIndex = 3
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdSaveAs
        ' 
        CmdSaveAs.Location = New Point(12, 100)
        CmdSaveAs.Name = "CmdSaveAs"
        CmdSaveAs.Size = New Size(125, 29)
        CmdSaveAs.TabIndex = 2
        CmdSaveAs.Text = "Save As"
        CmdSaveAs.UseVisualStyleBackColor = True
        ' 
        ' CmdSave
        ' 
        CmdSave.Location = New Point(12, 65)
        CmdSave.Name = "CmdSave"
        CmdSave.Size = New Size(125, 29)
        CmdSave.TabIndex = 1
        CmdSave.Text = "Save"
        CmdSave.UseVisualStyleBackColor = True
        ' 
        ' CmdOpen
        ' 
        CmdOpen.Location = New Point(12, 30)
        CmdOpen.Name = "CmdOpen"
        CmdOpen.Size = New Size(125, 29)
        CmdOpen.TabIndex = 0
        CmdOpen.Text = "Open"
        CmdOpen.UseVisualStyleBackColor = True
        ' 
        ' TxtText
        ' 
        TxtText.Dock = DockStyle.Fill
        TxtText.Location = New Point(0, 0)
        TxtText.Multiline = True
        TxtText.Name = "TxtText"
        TxtText.Size = New Size(647, 450)
        TxtText.TabIndex = 0
        ' 
        ' FrmHtml
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SpText)
        Name = "FrmHtml"
        Text = "FrmHtml"
        SpText.Panel1.ResumeLayout(False)
        SpText.Panel2.ResumeLayout(False)
        SpText.Panel2.PerformLayout()
        CType(SpText, ComponentModel.ISupportInitialize).EndInit()
        SpText.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SpText As SplitContainer
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdSaveAs As Button
    Friend WithEvents CmdSave As Button
    Friend WithEvents CmdOpen As Button
    Friend WithEvents TxtText As TextBox
End Class
