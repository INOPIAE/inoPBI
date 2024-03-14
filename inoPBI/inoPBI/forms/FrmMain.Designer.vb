<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        MenuStrip = New MenuStrip()
        FileMenu = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem = New ToolStripMenuItem()
        PrintSetupToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditMenu = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator7 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        ViewMenu = New ToolStripMenuItem()
        ToolBarToolStripMenuItem = New ToolStripMenuItem()
        StatusBarToolStripMenuItem = New ToolStripMenuItem()
        ToolsMenu = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        WindowsMenu = New ToolStripMenuItem()
        NewWindowToolStripMenuItem = New ToolStripMenuItem()
        CascadeToolStripMenuItem = New ToolStripMenuItem()
        TileVerticalToolStripMenuItem = New ToolStripMenuItem()
        TileHorizontalToolStripMenuItem = New ToolStripMenuItem()
        CloseAllToolStripMenuItem = New ToolStripMenuItem()
        ArrangeIconsToolStripMenuItem = New ToolStripMenuItem()
        HelpMenu = New ToolStripMenuItem()
        ContentsToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator8 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        PowerBIToolsToolStripMenuItem = New ToolStripMenuItem()
        ReplacementToolStripMenuItem = New ToolStripMenuItem()
        DocumentationToolStripMenuItem = New ToolStripMenuItem()
        SelectProjectToolStripMenuItem = New ToolStripMenuItem()
        EditFooterHeaderToolStripMenuItem = New ToolStripMenuItem()
        ReplacementTMDLToolStripMenuItem = New ToolStripMenuItem()
        UsageToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip = New ToolStrip()
        NewToolStripButton = New ToolStripButton()
        OpenToolStripButton = New ToolStripButton()
        SaveToolStripButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        PrintToolStripButton = New ToolStripButton()
        PrintPreviewToolStripButton = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        HelpToolStripButton = New ToolStripButton()
        StatusStrip = New StatusStrip()
        ToolStripStatusLabel = New ToolStripStatusLabel()
        TslCurrentProject = New ToolStripStatusLabel()
        ToolTip = New ToolTip(components)
        MenuStrip.SuspendLayout()
        ToolStrip.SuspendLayout()
        StatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.ImageScalingSize = New Size(20, 20)
        MenuStrip.Items.AddRange(New ToolStripItem() {FileMenu, EditMenu, ViewMenu, ToolsMenu, WindowsMenu, HelpMenu, PowerBIToolsToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.MdiWindowListItem = WindowsMenu
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(8, 3, 0, 3)
        MenuStrip.Size = New Size(843, 30)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' FileMenu
        ' 
        FileMenu.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, ToolStripSeparator3, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator4, PrintToolStripMenuItem, PrintPreviewToolStripMenuItem, PrintSetupToolStripMenuItem, ToolStripSeparator5, ExitToolStripMenuItem})
        FileMenu.ImageTransparentColor = SystemColors.ActiveBorder
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(59, 24)
        FileMenu.Text = "&Datei"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), Image)
        NewToolStripMenuItem.ImageTransparentColor = Color.Black
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(224, 26)
        NewToolStripMenuItem.Text = "&Neu"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), Image)
        OpenToolStripMenuItem.ImageTransparentColor = Color.Black
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(224, 26)
        OpenToolStripMenuItem.Text = "&Öffnen"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(221, 6)
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), Image)
        SaveToolStripMenuItem.ImageTransparentColor = Color.Black
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(224, 26)
        SaveToolStripMenuItem.Text = "&Speichern"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(224, 26)
        SaveAsToolStripMenuItem.Text = "Speichern &unter"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(221, 6)
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), Image)
        PrintToolStripMenuItem.ImageTransparentColor = Color.Black
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        PrintToolStripMenuItem.Size = New Size(224, 26)
        PrintToolStripMenuItem.Text = "&Drucken"
        ' 
        ' PrintPreviewToolStripMenuItem
        ' 
        PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), Image)
        PrintPreviewToolStripMenuItem.ImageTransparentColor = Color.Black
        PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        PrintPreviewToolStripMenuItem.Size = New Size(224, 26)
        PrintPreviewToolStripMenuItem.Text = "&Seitenansicht"
        ' 
        ' PrintSetupToolStripMenuItem
        ' 
        PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        PrintSetupToolStripMenuItem.Size = New Size(224, 26)
        PrintSetupToolStripMenuItem.Text = "Druckeinrichtung"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(221, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = "&Beenden"
        ' 
        ' EditMenu
        ' 
        EditMenu.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, RedoToolStripMenuItem, ToolStripSeparator6, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripSeparator7, SelectAllToolStripMenuItem})
        EditMenu.Name = "EditMenu"
        EditMenu.Size = New Size(95, 24)
        EditMenu.Text = "&Bearbeiten"
        EditMenu.Visible = False
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), Image)
        UndoToolStripMenuItem.ImageTransparentColor = Color.Black
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        UndoToolStripMenuItem.Size = New Size(247, 26)
        UndoToolStripMenuItem.Text = "&Rückgängig"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), Image)
        RedoToolStripMenuItem.ImageTransparentColor = Color.Black
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Y
        RedoToolStripMenuItem.Size = New Size(247, 26)
        RedoToolStripMenuItem.Text = "&Wiederholen"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(244, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), Image)
        CutToolStripMenuItem.ImageTransparentColor = Color.Black
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CutToolStripMenuItem.Size = New Size(247, 26)
        CutToolStripMenuItem.Text = "&Ausschneiden"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), Image)
        CopyToolStripMenuItem.ImageTransparentColor = Color.Black
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopyToolStripMenuItem.Size = New Size(247, 26)
        CopyToolStripMenuItem.Text = "&Kopieren"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), Image)
        PasteToolStripMenuItem.ImageTransparentColor = Color.Black
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PasteToolStripMenuItem.Size = New Size(247, 26)
        PasteToolStripMenuItem.Text = "&Einfügen"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(244, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        SelectAllToolStripMenuItem.Size = New Size(247, 26)
        SelectAllToolStripMenuItem.Text = "&Alle auswählen"
        ' 
        ' ViewMenu
        ' 
        ViewMenu.DropDownItems.AddRange(New ToolStripItem() {ToolBarToolStripMenuItem, StatusBarToolStripMenuItem})
        ViewMenu.Name = "ViewMenu"
        ViewMenu.Size = New Size(71, 24)
        ViewMenu.Text = "&Ansicht"
        ViewMenu.Visible = False
        ' 
        ' ToolBarToolStripMenuItem
        ' 
        ToolBarToolStripMenuItem.Checked = True
        ToolBarToolStripMenuItem.CheckOnClick = True
        ToolBarToolStripMenuItem.CheckState = CheckState.Checked
        ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        ToolBarToolStripMenuItem.Size = New Size(224, 26)
        ToolBarToolStripMenuItem.Text = "&Symbolleiste"
        ' 
        ' StatusBarToolStripMenuItem
        ' 
        StatusBarToolStripMenuItem.Checked = True
        StatusBarToolStripMenuItem.CheckOnClick = True
        StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        StatusBarToolStripMenuItem.Size = New Size(224, 26)
        StatusBarToolStripMenuItem.Text = "Status&leiste"
        ' 
        ' ToolsMenu
        ' 
        ToolsMenu.DropDownItems.AddRange(New ToolStripItem() {OptionsToolStripMenuItem})
        ToolsMenu.Name = "ToolsMenu"
        ToolsMenu.Size = New Size(58, 24)
        ToolsMenu.Text = "&Tools"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(224, 26)
        OptionsToolStripMenuItem.Text = "&Optionen"
        ' 
        ' WindowsMenu
        ' 
        WindowsMenu.DropDownItems.AddRange(New ToolStripItem() {NewWindowToolStripMenuItem, CascadeToolStripMenuItem, TileVerticalToolStripMenuItem, TileHorizontalToolStripMenuItem, CloseAllToolStripMenuItem, ArrangeIconsToolStripMenuItem})
        WindowsMenu.Name = "WindowsMenu"
        WindowsMenu.Size = New Size(70, 24)
        WindowsMenu.Text = "&Fenster"
        ' 
        ' NewWindowToolStripMenuItem
        ' 
        NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        NewWindowToolStripMenuItem.Size = New Size(224, 26)
        NewWindowToolStripMenuItem.Text = "&Neues Fenster"
        ' 
        ' CascadeToolStripMenuItem
        ' 
        CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        CascadeToolStripMenuItem.Size = New Size(224, 26)
        CascadeToolStripMenuItem.Text = "Ü&berlappend"
        ' 
        ' TileVerticalToolStripMenuItem
        ' 
        TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        TileVerticalToolStripMenuItem.Size = New Size(224, 26)
        TileVerticalToolStripMenuItem.Text = "&Nebeneinander"
        ' 
        ' TileHorizontalToolStripMenuItem
        ' 
        TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        TileHorizontalToolStripMenuItem.Size = New Size(224, 26)
        TileHorizontalToolStripMenuItem.Text = "&Untereinander"
        ' 
        ' CloseAllToolStripMenuItem
        ' 
        CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        CloseAllToolStripMenuItem.Size = New Size(224, 26)
        CloseAllToolStripMenuItem.Text = "&Alle schließen"
        ' 
        ' ArrangeIconsToolStripMenuItem
        ' 
        ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        ArrangeIconsToolStripMenuItem.Size = New Size(224, 26)
        ArrangeIconsToolStripMenuItem.Text = "Symbole &anordnen"
        ' 
        ' HelpMenu
        ' 
        HelpMenu.DropDownItems.AddRange(New ToolStripItem() {ContentsToolStripMenuItem, IndexToolStripMenuItem, SearchToolStripMenuItem, ToolStripSeparator8, AboutToolStripMenuItem})
        HelpMenu.Name = "HelpMenu"
        HelpMenu.Size = New Size(55, 24)
        HelpMenu.Text = "&Hilfe"
        ' 
        ' ContentsToolStripMenuItem
        ' 
        ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        ContentsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F1
        ContentsToolStripMenuItem.Size = New Size(224, 26)
        ContentsToolStripMenuItem.Text = "&Inhalt"
        ContentsToolStripMenuItem.Visible = False
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), Image)
        IndexToolStripMenuItem.ImageTransparentColor = Color.Black
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.Size = New Size(224, 26)
        IndexToolStripMenuItem.Text = "&Index"
        IndexToolStripMenuItem.Visible = False
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), Image)
        SearchToolStripMenuItem.ImageTransparentColor = Color.Black
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.Size = New Size(224, 26)
        SearchToolStripMenuItem.Text = "&Suchen"
        SearchToolStripMenuItem.Visible = False
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(221, 6)
        ToolStripSeparator8.Visible = False
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(224, 26)
        AboutToolStripMenuItem.Text = "&Info..."
        ' 
        ' PowerBIToolsToolStripMenuItem
        ' 
        PowerBIToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ReplacementToolStripMenuItem, DocumentationToolStripMenuItem, SelectProjectToolStripMenuItem, EditFooterHeaderToolStripMenuItem, ReplacementTMDLToolStripMenuItem, UsageToolStripMenuItem})
        PowerBIToolsToolStripMenuItem.Name = "PowerBIToolsToolStripMenuItem"
        PowerBIToolsToolStripMenuItem.Size = New Size(119, 24)
        PowerBIToolsToolStripMenuItem.Text = "Power BI Tools"
        ' 
        ' ReplacementToolStripMenuItem
        ' 
        ReplacementToolStripMenuItem.Name = "ReplacementToolStripMenuItem"
        ReplacementToolStripMenuItem.Size = New Size(222, 26)
        ReplacementToolStripMenuItem.Text = "Replacement"
        ' 
        ' DocumentationToolStripMenuItem
        ' 
        DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        DocumentationToolStripMenuItem.Size = New Size(222, 26)
        DocumentationToolStripMenuItem.Text = "Documentation"
        ' 
        ' SelectProjectToolStripMenuItem
        ' 
        SelectProjectToolStripMenuItem.Name = "SelectProjectToolStripMenuItem"
        SelectProjectToolStripMenuItem.Size = New Size(222, 26)
        SelectProjectToolStripMenuItem.Text = "Select Project"
        ' 
        ' EditFooterHeaderToolStripMenuItem
        ' 
        EditFooterHeaderToolStripMenuItem.Name = "EditFooterHeaderToolStripMenuItem"
        EditFooterHeaderToolStripMenuItem.Size = New Size(222, 26)
        EditFooterHeaderToolStripMenuItem.Text = "Edit Footer/Header"
        ' 
        ' ReplacementTMDLToolStripMenuItem
        ' 
        ReplacementTMDLToolStripMenuItem.Name = "ReplacementTMDLToolStripMenuItem"
        ReplacementTMDLToolStripMenuItem.Size = New Size(222, 26)
        ReplacementTMDLToolStripMenuItem.Text = "Replacement TMDL"
        ' 
        ' UsageToolStripMenuItem
        ' 
        UsageToolStripMenuItem.Name = "UsageToolStripMenuItem"
        UsageToolStripMenuItem.Size = New Size(222, 26)
        UsageToolStripMenuItem.Text = "Usage"
        ' 
        ' ToolStrip
        ' 
        ToolStrip.ImageScalingSize = New Size(20, 20)
        ToolStrip.Items.AddRange(New ToolStripItem() {NewToolStripButton, OpenToolStripButton, SaveToolStripButton, ToolStripSeparator1, PrintToolStripButton, PrintPreviewToolStripButton, ToolStripSeparator2, HelpToolStripButton})
        ToolStrip.Location = New Point(0, 30)
        ToolStrip.Name = "ToolStrip"
        ToolStrip.Size = New Size(843, 27)
        ToolStrip.TabIndex = 6
        ToolStrip.Text = "ToolStrip"
        ' 
        ' NewToolStripButton
        ' 
        NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), Image)
        NewToolStripButton.ImageTransparentColor = Color.Black
        NewToolStripButton.Name = "NewToolStripButton"
        NewToolStripButton.Size = New Size(29, 24)
        NewToolStripButton.Text = "Neu"
        ' 
        ' OpenToolStripButton
        ' 
        OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), Image)
        OpenToolStripButton.ImageTransparentColor = Color.Black
        OpenToolStripButton.Name = "OpenToolStripButton"
        OpenToolStripButton.Size = New Size(29, 24)
        OpenToolStripButton.Text = "Öffnen"
        ' 
        ' SaveToolStripButton
        ' 
        SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), Image)
        SaveToolStripButton.ImageTransparentColor = Color.Black
        SaveToolStripButton.Name = "SaveToolStripButton"
        SaveToolStripButton.Size = New Size(29, 24)
        SaveToolStripButton.Text = "Speichern"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 27)
        ' 
        ' PrintToolStripButton
        ' 
        PrintToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), Image)
        PrintToolStripButton.ImageTransparentColor = Color.Black
        PrintToolStripButton.Name = "PrintToolStripButton"
        PrintToolStripButton.Size = New Size(29, 24)
        PrintToolStripButton.Text = "Drucken"
        ' 
        ' PrintPreviewToolStripButton
        ' 
        PrintPreviewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PrintPreviewToolStripButton.Image = CType(resources.GetObject("PrintPreviewToolStripButton.Image"), Image)
        PrintPreviewToolStripButton.ImageTransparentColor = Color.Black
        PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        PrintPreviewToolStripButton.Size = New Size(29, 24)
        PrintPreviewToolStripButton.Text = "Seitenansicht"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 27)
        ' 
        ' HelpToolStripButton
        ' 
        HelpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), Image)
        HelpToolStripButton.ImageTransparentColor = Color.Black
        HelpToolStripButton.Name = "HelpToolStripButton"
        HelpToolStripButton.Size = New Size(29, 24)
        HelpToolStripButton.Text = "Hilfe"
        ' 
        ' StatusStrip
        ' 
        StatusStrip.ImageScalingSize = New Size(20, 20)
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel, TslCurrentProject})
        StatusStrip.Location = New Point(0, 671)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(1, 0, 19, 0)
        StatusStrip.Size = New Size(843, 26)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"
        ' 
        ' ToolStripStatusLabel
        ' 
        ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        ToolStripStatusLabel.Size = New Size(49, 20)
        ToolStripStatusLabel.Text = "Status"
        ' 
        ' TslCurrentProject
        ' 
        TslCurrentProject.Name = "TslCurrentProject"
        TslCurrentProject.Size = New Size(153, 20)
        TslCurrentProject.Text = "ToolStripStatusLabel1"
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(843, 697)
        Controls.Add(ToolStrip)
        Controls.Add(MenuStrip)
        Controls.Add(StatusStrip)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 5, 4, 5)
        Name = "FrmMain"
        Text = "FrmMain"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ToolStrip.ResumeLayout(False)
        ToolStrip.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PowerBIToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplacementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TslCurrentProject As ToolStripStatusLabel
    Friend WithEvents EditFooterHeaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplacementTMDLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsageToolStripMenuItem As ToolStripMenuItem

End Class
