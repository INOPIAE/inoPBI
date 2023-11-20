<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReplacement
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
        LblOriginal = New Label()
        TxtOrginal = New TextBox()
        CmdFileOriginal = New Button()
        LblRepacement = New Label()
        TxtReplace = New TextBox()
        CmdFileReplacement = New Button()
        LblTargetFolder = New Label()
        TxtTargetFolder = New TextBox()
        CmdFolderTarget = New Button()
        CmdReplace = New Button()
        CmdClose = New Button()
        LblCustomer = New Label()
        TxtCustomer = New TextBox()
        CmdInfo = New Button()
        LblInfo = New Label()
        SuspendLayout()
        ' 
        ' LblOriginal
        ' 
        LblOriginal.AutoSize = True
        LblOriginal.Location = New Point(24, 29)
        LblOriginal.Name = "LblOriginal"
        LblOriginal.Size = New Size(49, 15)
        LblOriginal.TabIndex = 0
        LblOriginal.Text = "Original"
        ' 
        ' TxtOrginal
        ' 
        TxtOrginal.Location = New Point(144, 27)
        TxtOrginal.Margin = New Padding(3, 2, 3, 2)
        TxtOrginal.Name = "TxtOrginal"
        TxtOrginal.Size = New Size(444, 23)
        TxtOrginal.TabIndex = 1
        ' 
        ' CmdFileOriginal
        ' 
        CmdFileOriginal.Location = New Point(593, 28)
        CmdFileOriginal.Margin = New Padding(3, 2, 3, 2)
        CmdFileOriginal.Name = "CmdFileOriginal"
        CmdFileOriginal.Size = New Size(23, 20)
        CmdFileOriginal.TabIndex = 2
        CmdFileOriginal.Text = "..."
        CmdFileOriginal.UseVisualStyleBackColor = True
        ' 
        ' LblRepacement
        ' 
        LblRepacement.AutoSize = True
        LblRepacement.Location = New Point(24, 54)
        LblRepacement.Name = "LblRepacement"
        LblRepacement.Size = New Size(95, 15)
        LblRepacement.TabIndex = 0
        LblRepacement.Text = "Replacement file"
        ' 
        ' TxtReplace
        ' 
        TxtReplace.Location = New Point(144, 52)
        TxtReplace.Margin = New Padding(3, 2, 3, 2)
        TxtReplace.Name = "TxtReplace"
        TxtReplace.Size = New Size(444, 23)
        TxtReplace.TabIndex = 1
        ' 
        ' CmdFileReplacement
        ' 
        CmdFileReplacement.Location = New Point(593, 52)
        CmdFileReplacement.Margin = New Padding(3, 2, 3, 2)
        CmdFileReplacement.Name = "CmdFileReplacement"
        CmdFileReplacement.Size = New Size(23, 20)
        CmdFileReplacement.TabIndex = 2
        CmdFileReplacement.Text = "..."
        CmdFileReplacement.UseVisualStyleBackColor = True
        ' 
        ' LblTargetFolder
        ' 
        LblTargetFolder.AutoSize = True
        LblTargetFolder.Location = New Point(24, 79)
        LblTargetFolder.Name = "LblTargetFolder"
        LblTargetFolder.Size = New Size(73, 15)
        LblTargetFolder.TabIndex = 0
        LblTargetFolder.Text = "Target folder"
        ' 
        ' TxtTargetFolder
        ' 
        TxtTargetFolder.Location = New Point(144, 76)
        TxtTargetFolder.Margin = New Padding(3, 2, 3, 2)
        TxtTargetFolder.Name = "TxtTargetFolder"
        TxtTargetFolder.Size = New Size(444, 23)
        TxtTargetFolder.TabIndex = 1
        ' 
        ' CmdFolderTarget
        ' 
        CmdFolderTarget.Location = New Point(593, 77)
        CmdFolderTarget.Margin = New Padding(3, 2, 3, 2)
        CmdFolderTarget.Name = "CmdFolderTarget"
        CmdFolderTarget.Size = New Size(23, 20)
        CmdFolderTarget.TabIndex = 2
        CmdFolderTarget.Text = "..."
        CmdFolderTarget.UseVisualStyleBackColor = True
        ' 
        ' CmdReplace
        ' 
        CmdReplace.Location = New Point(326, 257)
        CmdReplace.Margin = New Padding(3, 2, 3, 2)
        CmdReplace.Name = "CmdReplace"
        CmdReplace.Size = New Size(82, 22)
        CmdReplace.TabIndex = 3
        CmdReplace.Text = "Replace"
        CmdReplace.UseVisualStyleBackColor = True
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(472, 257)
        CmdClose.Margin = New Padding(3, 2, 3, 2)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(82, 22)
        CmdClose.TabIndex = 3
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' LblCustomer
        ' 
        LblCustomer.AutoSize = True
        LblCustomer.Location = New Point(24, 104)
        LblCustomer.Name = "LblCustomer"
        LblCustomer.Size = New Size(113, 15)
        LblCustomer.TabIndex = 0
        LblCustomer.Text = "Customer Extension"
        ' 
        ' TxtCustomer
        ' 
        TxtCustomer.Location = New Point(144, 101)
        TxtCustomer.Margin = New Padding(3, 2, 3, 2)
        TxtCustomer.Name = "TxtCustomer"
        TxtCustomer.Size = New Size(151, 23)
        TxtCustomer.TabIndex = 1
        ' 
        ' CmdInfo
        ' 
        CmdInfo.Location = New Point(189, 257)
        CmdInfo.Margin = New Padding(3, 2, 3, 2)
        CmdInfo.Name = "CmdInfo"
        CmdInfo.Size = New Size(40, 20)
        CmdInfo.TabIndex = 4
        CmdInfo.Text = "Info"
        CmdInfo.UseVisualStyleBackColor = True
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(119, 167)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(28, 15)
        LblInfo.TabIndex = 0
        LblInfo.Text = "Info"
        ' 
        ' FrmReplacement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(CmdInfo)
        Controls.Add(CmdClose)
        Controls.Add(CmdReplace)
        Controls.Add(CmdFolderTarget)
        Controls.Add(CmdFileReplacement)
        Controls.Add(CmdFileOriginal)
        Controls.Add(TxtCustomer)
        Controls.Add(LblCustomer)
        Controls.Add(TxtTargetFolder)
        Controls.Add(LblTargetFolder)
        Controls.Add(TxtReplace)
        Controls.Add(LblRepacement)
        Controls.Add(TxtOrginal)
        Controls.Add(LblInfo)
        Controls.Add(LblOriginal)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FrmReplacement"
        Text = "FrmReplacement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblOriginal As Label
    Friend WithEvents TxtOrginal As TextBox
    Friend WithEvents CmdFileOriginal As Button
    Friend WithEvents LblRepacement As Label
    Friend WithEvents TxtReplace As TextBox
    Friend WithEvents CmdFileReplacement As Button
    Friend WithEvents LblTargetFolder As Label
    Friend WithEvents TxtTargetFolder As TextBox
    Friend WithEvents CmdFolderTarget As Button
    Friend WithEvents CmdReplace As Button
    Friend WithEvents CmdClose As Button
    Friend WithEvents LblCustomer As Label
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents CmdInfo As Button
    Friend WithEvents LblInfo As Label
End Class
