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
        components = New ComponentModel.Container()
        SpMain = New SplitContainer()
        TxtInfo = New TextBox()
        CmdClose = New Button()
        CmdRefresh = New Button()
        SpMeausres = New SplitContainer()
        DgvMeasures = New DataGridView()
        Measure = New DataGridViewTextBoxColumn()
        Usage = New DataGridViewTextBoxColumn()
        SplitContainer1 = New SplitContainer()
        CmdClearFilterReport = New Button()
        TxtFilterMeasure = New TextBox()
        LblFilterMeasure = New Label()
        CkbHidden = New CheckBox()
        DgvReport = New DataGridView()
        BcReport = New BindingSource(components)
        CType(SpMain, ComponentModel.ISupportInitialize).BeginInit()
        SpMain.Panel1.SuspendLayout()
        SpMain.Panel2.SuspendLayout()
        SpMain.SuspendLayout()
        CType(SpMeausres, ComponentModel.ISupportInitialize).BeginInit()
        SpMeausres.Panel1.SuspendLayout()
        SpMeausres.Panel2.SuspendLayout()
        SpMeausres.SuspendLayout()
        CType(DgvMeasures, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(DgvReport, ComponentModel.ISupportInitialize).BeginInit()
        CType(BcReport, ComponentModel.ISupportInitialize).BeginInit()
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
        SpMain.Size = New Size(774, 481)
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
        SpMeausres.Panel2.Controls.Add(SplitContainer1)
        SpMeausres.Size = New Size(774, 402)
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
        DgvMeasures.Size = New Size(376, 402)
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
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel1
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(CmdClearFilterReport)
        SplitContainer1.Panel1.Controls.Add(TxtFilterMeasure)
        SplitContainer1.Panel1.Controls.Add(LblFilterMeasure)
        SplitContainer1.Panel1.Controls.Add(CkbHidden)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(DgvReport)
        SplitContainer1.Size = New Size(394, 402)
        SplitContainer1.SplitterDistance = 70
        SplitContainer1.TabIndex = 0
        ' 
        ' CmdClearFilterReport
        ' 
        CmdClearFilterReport.Location = New Point(291, 7)
        CmdClearFilterReport.Name = "CmdClearFilterReport"
        CmdClearFilterReport.Size = New Size(91, 23)
        CmdClearFilterReport.TabIndex = 3
        CmdClearFilterReport.Text = "Clear filter"
        CmdClearFilterReport.UseVisualStyleBackColor = True
        ' 
        ' TxtFilterMeasure
        ' 
        TxtFilterMeasure.Location = New Point(112, 37)
        TxtFilterMeasure.Name = "TxtFilterMeasure"
        TxtFilterMeasure.Size = New Size(173, 23)
        TxtFilterMeasure.TabIndex = 2
        ' 
        ' LblFilterMeasure
        ' 
        LblFilterMeasure.AutoSize = True
        LblFilterMeasure.Location = New Point(10, 40)
        LblFilterMeasure.Name = "LblFilterMeasure"
        LblFilterMeasure.Size = New Size(41, 15)
        LblFilterMeasure.TabIndex = 1
        LblFilterMeasure.Text = "Label1"
        ' 
        ' CkbHidden
        ' 
        CkbHidden.AutoSize = True
        CkbHidden.Location = New Point(10, 10)
        CkbHidden.Name = "CkbHidden"
        CkbHidden.Size = New Size(89, 19)
        CkbHidden.TabIndex = 0
        CkbHidden.Text = "hidden only"
        CkbHidden.UseVisualStyleBackColor = True
        ' 
        ' DgvReport
        ' 
        DgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvReport.Dock = DockStyle.Fill
        DgvReport.Location = New Point(0, 0)
        DgvReport.Margin = New Padding(3, 2, 3, 2)
        DgvReport.Name = "DgvReport"
        DgvReport.RowHeadersWidth = 51
        DgvReport.RowTemplate.Height = 29
        DgvReport.Size = New Size(394, 328)
        DgvReport.TabIndex = 1
        ' 
        ' FrmMeasuresUsage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(774, 481)
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
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(DgvReport, ComponentModel.ISupportInitialize).EndInit()
        CType(BcReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SpMain As SplitContainer
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdRefresh As Button
    Friend WithEvents SpMeausres As SplitContainer
    Friend WithEvents DgvMeasures As DataGridView
    Friend WithEvents Measure As DataGridViewTextBoxColumn
    Friend WithEvents Usage As DataGridViewTextBoxColumn
    Friend WithEvents TxtInfo As TextBox
    Friend WithEvents BcReport As BindingSource
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CkbHidden As CheckBox
    Friend WithEvents DgvReport As DataGridView
    Friend WithEvents CmdClearFilterReport As Button
    Friend WithEvents TxtFilterMeasure As TextBox
    Friend WithEvents LblFilterMeasure As Label
End Class
