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
        LblInfo = New Label()
        CmdClose = New Button()
        CmdRefresh = New Button()
        SpMeausres = New SplitContainer()
        DgvMeasures = New DataGridView()
        DgvReport = New DataGridView()
        Measure = New DataGridViewTextBoxColumn()
        Usage = New DataGridViewTextBoxColumn()
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
        SpMain.Name = "SpMain"
        SpMain.Orientation = Orientation.Horizontal
        ' 
        ' SpMain.Panel1
        ' 
        SpMain.Panel1.Controls.Add(LblInfo)
        SpMain.Panel1.Controls.Add(CmdClose)
        SpMain.Panel1.Controls.Add(CmdRefresh)
        ' 
        ' SpMain.Panel2
        ' 
        SpMain.Panel2.Controls.Add(SpMeausres)
        SpMain.Size = New Size(884, 450)
        SpMain.SplitterDistance = 76
        SpMain.TabIndex = 0
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Location = New Point(23, 9)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(53, 20)
        LblInfo.TabIndex = 1
        LblInfo.Text = "Label1"
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(767, 44)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(94, 29)
        CmdClose.TabIndex = 0
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' CmdRefresh
        ' 
        CmdRefresh.Location = New Point(767, 9)
        CmdRefresh.Name = "CmdRefresh"
        CmdRefresh.Size = New Size(94, 29)
        CmdRefresh.TabIndex = 0
        CmdRefresh.Text = "Refresh"
        CmdRefresh.UseVisualStyleBackColor = True
        ' 
        ' SpMeausres
        ' 
        SpMeausres.Dock = DockStyle.Fill
        SpMeausres.Location = New Point(0, 0)
        SpMeausres.Name = "SpMeausres"
        ' 
        ' SpMeausres.Panel1
        ' 
        SpMeausres.Panel1.Controls.Add(DgvMeasures)
        ' 
        ' SpMeausres.Panel2
        ' 
        SpMeausres.Panel2.Controls.Add(DgvReport)
        SpMeausres.Size = New Size(884, 370)
        SpMeausres.SplitterDistance = 430
        SpMeausres.TabIndex = 0
        ' 
        ' DgvMeasures
        ' 
        DgvMeasures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvMeasures.Columns.AddRange(New DataGridViewColumn() {Measure, Usage})
        DgvMeasures.Dock = DockStyle.Fill
        DgvMeasures.Location = New Point(0, 0)
        DgvMeasures.Name = "DgvMeasures"
        DgvMeasures.RowHeadersWidth = 51
        DgvMeasures.RowTemplate.Height = 29
        DgvMeasures.Size = New Size(430, 370)
        DgvMeasures.TabIndex = 0
        ' 
        ' DgvReport
        ' 
        DgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvReport.Columns.AddRange(New DataGridViewColumn() {Page, Table, Valuename})
        DgvReport.Dock = DockStyle.Fill
        DgvReport.Location = New Point(0, 0)
        DgvReport.Name = "DgvReport"
        DgvReport.RowHeadersWidth = 51
        DgvReport.RowTemplate.Height = 29
        DgvReport.Size = New Size(450, 370)
        DgvReport.TabIndex = 0
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
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 450)
        Controls.Add(SpMain)
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
    Friend WithEvents LblInfo As Label
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
End Class
