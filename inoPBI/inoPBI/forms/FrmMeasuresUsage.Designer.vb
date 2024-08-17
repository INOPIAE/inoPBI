<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMeasuresUsage
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
        SpMain = New SplitContainer()
        TxtInfo = New TextBox()
        CmdClose = New Button()
        CmdRefresh = New Button()
        SpMeausres = New SplitContainer()
        DgvMeasures = New DataGridView()
        Measure = New DataGridViewTextBoxColumn()
        Usage = New DataGridViewTextBoxColumn()
        DgvReport = New DataGridView()
        Page = New DataGridViewTextBoxColumn()
        Table = New DataGridViewTextBoxColumn()
        Valuename = New DataGridViewTextBoxColumn()
        CType(SpMain, ComponentModel.ISupportInitialize).BeginInit()
        SpMain.Panel1.SuspendLayout()
        SpMain.Panel2.SuspendLayout()
        SpMain.SuspendLayout()
        CType(SpMeausres, ComponentModel.ISupportInitialize).BeginInit()
        SpMeausres.Panel1.SuspendLayout()
        SpMeausres.Panel2.SuspendLayout()
        SpMeausres.SuspendLayout()
        CType(DgvMeasures, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SpMain
        ' 
        SpMain.Dock = DockStyle.Fill
        SpMain.FixedPanel = FixedPanel.Panel1
        SpMain.Location = New Point(0, 0)
        SpMain.Margin = New Padding(3, 2, 3, 2)
        SpMain.Name = "SpMain"
        SpMain.Orientation = Orientation.Horizontal
        ' 
        ' SpMain.Panel1
        ' 
        SpMain.Panel1.Controls.Add(TxtInfo)
        SpMain.Panel1.Controls.Add(CmdClose)
        SpMain.Panel1.Controls.Add(CmdRefresh)
        ' 
        ' SpMain.Panel2
        ' 
        SpMain.Panel2.Controls.Add(SpMeausres)
        SpMain.Size = New Size(774, 338)
        SpMain.SplitterDistance = 76
        SpMain.SplitterWidth = 3
        SpMain.TabIndex = 0
        ' 
        ' TxtInfo
        ' 
        TxtInfo.BackColor = SystemColors.Control
        TxtInfo.Enabled = False
        TxtInfo.Location = New Point(12, 7)
        TxtInfo.Multiline = True
        TxtInfo.Name = "TxtInfo"
        TxtInfo.Size = New Size(653, 66)
        TxtInfo.TabIndex = 1
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(671, 33)
        CmdClose.Margin = New Padding(3, 2, 3, 2)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(92, 22)
        CmdClose.TabIndex = 0
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdRefresh
        ' 
        CmdRefresh.Location = New Point(671, 7)
        CmdRefresh.Margin = New Padding(3, 2, 3, 2)
        CmdRefresh.Name = "CmdRefresh"
        CmdRefresh.Size = New Size(92, 22)
        CmdRefresh.TabIndex = 0
        CmdRefresh.Text = "Refresh"
        CmdRefresh.UseVisualStyleBackColor = True
        ' 
        ' SpMeausres
        ' 
        SpMeausres.Dock = DockStyle.Fill
        SpMeausres.Location = New Point(0, 0)
        SpMeausres.Margin = New Padding(3, 2, 3, 2)
        SpMeausres.Name = "SpMeausres"
        ' 
        ' SpMeausres.Panel1
        ' 
        SpMeausres.Panel1.Controls.Add(DgvMeasures)
        ' 
        ' SpMeausres.Panel2
        ' 
        SpMeausres.Panel2.Controls.Add(DgvReport)
        SpMeausres.Size = New Size(774, 259)
        SpMeausres.SplitterDistance = 376
        SpMeausres.TabIndex = 0
        ' 
        ' DgvMeasures
        ' 
        DgvMeasures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvMeasures.Columns.AddRange(New DataGridViewColumn() {Measure, Usage})
        DgvMeasures.Dock = DockStyle.Fill
        DgvMeasures.Location = New Point(0, 0)
        DgvMeasures.Margin = New Padding(3, 2, 3, 2)
        DgvMeasures.Name = "DgvMeasures"
        DgvMeasures.RowHeadersWidth = 51
        DgvMeasures.RowTemplate.Height = 29
        DgvMeasures.Size = New Size(376, 259)
        DgvMeasures.TabIndex = 0
        ' 
        ' Measure
        ' 
        Measure.HeaderText = "Measure"
        Measure.MinimumWidth = 6
        Measure.Name = "Measure"
        Measure.Width = 125
        ' 
        ' Usage
        ' 
        Usage.HeaderText = "Usage"
        Usage.MinimumWidth = 6
        Usage.Name = "Usage"
        Usage.Width = 125
        ' 
        ' DgvReport
        ' 
        DgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvReport.Columns.AddRange(New DataGridViewColumn() {Page, Table, Valuename})
        DgvReport.Dock = DockStyle.Fill
        DgvReport.Location = New Point(0, 0)
        DgvReport.Margin = New Padding(3, 2, 3, 2)
        DgvReport.Name = "DgvReport"
        DgvReport.RowHeadersWidth = 51
        DgvReport.RowTemplate.Height = 29
        DgvReport.Size = New Size(394, 259)
        DgvReport.TabIndex = 0
        ' 
        ' Page
        ' 
        Page.HeaderText = "Page"
        Page.MinimumWidth = 6
        Page.Name = "Page"
        Page.Width = 125
        ' 
        ' Table
        ' 
        Table.HeaderText = "Table"
        Table.MinimumWidth = 6
        Table.Name = "Table"
        Table.Width = 125
        ' 
        ' Valuename
        ' 
        Valuename.HeaderText = "Name"
        Valuename.MinimumWidth = 6
        Valuename.Name = "Valuename"
        Valuename.Width = 125
        ' 
        ' FrmMeasuresUsage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(774, 338)
        Controls.Add(SpMain)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FrmMeasuresUsage"
        Text = "FrmMeasuresUsage"
        SpMain.Panel1.ResumeLayout(False)
        SpMain.Panel1.PerformLayout()
        SpMain.Panel2.ResumeLayout(False)
        CType(SpMain, ComponentModel.ISupportInitialize).EndInit()
        SpMain.ResumeLayout(False)
        SpMeausres.Panel1.ResumeLayout(False)
        SpMeausres.Panel2.ResumeLayout(False)
        CType(SpMeausres, ComponentModel.ISupportInitialize).EndInit()
        SpMeausres.ResumeLayout(False)
        CType(DgvMeasures, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SpMain As SplitContainer
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdRefresh As Button
    Friend WithEvents SpMeausres As SplitContainer
    Friend WithEvents DgvMeasures As DataGridView
    Friend WithEvents DgvReport As DataGridView
    Friend WithEvents Measure As DataGridViewTextBoxColumn
    Friend WithEvents Usage As DataGridViewTextBoxColumn
    Friend WithEvents Page As DataGridViewTextBoxColumn
    Friend WithEvents Table As DataGridViewTextBoxColumn
    Friend WithEvents Valuename As DataGridViewTextBoxColumn
    Friend WithEvents TxtInfo As TextBox
End Class
