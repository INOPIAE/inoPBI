<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReplaceElement
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
        CmdCancel = New Button()
        CmdSave = New Button()
        LblType = New Label()
        CboType = New ComboBox()
        LblFrom = New Label()
        TxtFrom = New TextBox()
        LblTo = New Label()
        TxtTo = New TextBox()
        LblRange = New Label()
        TxtRange = New TextBox()
        SuspendLayout()
        ' 
        ' CmdCancel
        ' 
        CmdCancel.Location = New Point(125, 179)
        CmdCancel.Name = "CmdCancel"
        CmdCancel.Size = New Size(75, 23)
        CmdCancel.TabIndex = 9
        CmdCancel.Text = "Button1"
        CmdCancel.UseVisualStyleBackColor = True
        ' 
        ' CmdSave
        ' 
        CmdSave.Location = New Point(290, 179)
        CmdSave.Name = "CmdSave"
        CmdSave.Size = New Size(75, 23)
        CmdSave.TabIndex = 8
        CmdSave.Text = "Button1"
        CmdSave.UseVisualStyleBackColor = True
        ' 
        ' LblType
        ' 
        LblType.AutoSize = True
        LblType.Location = New Point(30, 35)
        LblType.Name = "LblType"
        LblType.Size = New Size(41, 15)
        LblType.TabIndex = 0
        LblType.Text = "Label1"
        ' 
        ' CboType
        ' 
        CboType.FormattingEnabled = True
        CboType.Location = New Point(154, 32)
        CboType.Name = "CboType"
        CboType.Size = New Size(182, 23)
        CboType.TabIndex = 1
        ' 
        ' LblFrom
        ' 
        LblFrom.AutoSize = True
        LblFrom.Location = New Point(30, 65)
        LblFrom.Name = "LblFrom"
        LblFrom.Size = New Size(41, 15)
        LblFrom.TabIndex = 2
        LblFrom.Text = "Label1"
        ' 
        ' TxtFrom
        ' 
        TxtFrom.Location = New Point(154, 62)
        TxtFrom.Name = "TxtFrom"
        TxtFrom.Size = New Size(291, 23)
        TxtFrom.TabIndex = 3
        ' 
        ' LblTo
        ' 
        LblTo.AutoSize = True
        LblTo.Location = New Point(30, 94)
        LblTo.Name = "LblTo"
        LblTo.Size = New Size(41, 15)
        LblTo.TabIndex = 4
        LblTo.Text = "Label1"
        ' 
        ' TxtTo
        ' 
        TxtTo.Location = New Point(154, 91)
        TxtTo.Name = "TxtTo"
        TxtTo.Size = New Size(291, 23)
        TxtTo.TabIndex = 5
        ' 
        ' LblRange
        ' 
        LblRange.AutoSize = True
        LblRange.Location = New Point(30, 123)
        LblRange.Name = "LblRange"
        LblRange.Size = New Size(41, 15)
        LblRange.TabIndex = 6
        LblRange.Text = "Label1"
        ' 
        ' TxtRange
        ' 
        TxtRange.Location = New Point(154, 120)
        TxtRange.Name = "TxtRange"
        TxtRange.Size = New Size(291, 23)
        TxtRange.TabIndex = 7
        ' 
        ' FrmReplaceElement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 229)
        Controls.Add(TxtRange)
        Controls.Add(TxtTo)
        Controls.Add(LblRange)
        Controls.Add(TxtFrom)
        Controls.Add(LblTo)
        Controls.Add(CboType)
        Controls.Add(LblFrom)
        Controls.Add(LblType)
        Controls.Add(CmdSave)
        Controls.Add(CmdCancel)
        Name = "FrmReplaceElement"
        Text = "FrmReplaceElement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdSave As Button
    Friend WithEvents LblType As Label
    Friend WithEvents CboType As ComboBox
    Friend WithEvents LblFrom As Label
    Friend WithEvents TxtFrom As TextBox
    Friend WithEvents LblTo As Label
    Friend WithEvents TxtTo As TextBox
    Friend WithEvents LblRange As Label
    Friend WithEvents TxtRange As TextBox
End Class
