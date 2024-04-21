<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        CboLanguage = New ComboBox()
        LblLanguage = New Label()
        CmdCancel = New Button()
        CmdOK = New Button()
        CmdSave = New Button()
        SuspendLayout()
        ' 
        ' CboLanguage
        ' 
        CboLanguage.FormattingEnabled = True
        CboLanguage.Location = New Point(235, 34)
        CboLanguage.Name = "CboLanguage"
        CboLanguage.Size = New Size(151, 28)
        CboLanguage.TabIndex = 0
        ' 
        ' LblLanguage
        ' 
        LblLanguage.AutoSize = True
        LblLanguage.Location = New Point(49, 36)
        LblLanguage.Name = "LblLanguage"
        LblLanguage.Size = New Size(74, 20)
        LblLanguage.TabIndex = 1
        LblLanguage.Text = "Language"
        ' 
        ' CmdCancel
        ' 
        CmdCancel.Location = New Point(152, 324)
        CmdCancel.Name = "CmdCancel"
        CmdCancel.Size = New Size(111, 32)
        CmdCancel.TabIndex = 2
        CmdCancel.Text = "Cancel"
        CmdCancel.UseVisualStyleBackColor = True
        ' 
        ' CmdOK
        ' 
        CmdOK.Location = New Point(555, 324)
        CmdOK.Name = "CmdOK"
        CmdOK.Size = New Size(111, 32)
        CmdOK.TabIndex = 2
        CmdOK.Text = "OK"
        CmdOK.UseVisualStyleBackColor = True
        ' 
        ' CmdSave
        ' 
        CmdSave.Location = New Point(340, 324)
        CmdSave.Name = "CmdSave"
        CmdSave.Size = New Size(111, 32)
        CmdSave.TabIndex = 2
        CmdSave.Text = "Save"
        CmdSave.UseVisualStyleBackColor = True
        ' 
        ' FrmSettings
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CmdSave)
        Controls.Add(CmdOK)
        Controls.Add(CmdCancel)
        Controls.Add(LblLanguage)
        Controls.Add(CboLanguage)
        Name = "FrmSettings"
        Text = "FrmSettings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CboLanguage As ComboBox
    Friend WithEvents LblLanguage As Label
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdOK As Button
    Friend WithEvents CmdSave As Button
End Class
