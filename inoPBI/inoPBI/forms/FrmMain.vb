Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports inoPBIDLL

Public Class FrmMain

    Public AppDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\INOPIAE\inoPBI"
    Public ProjectIniData As New ClsIniFileHandling.IniData
    Private cProjectIni As New ClsIniFileHandling

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Neue Instanz des untergeordneten Formulars erstellen.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Vor der Anzeige dem MDI-Formular unterordnen.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Fenster " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Hier Code zum Öffnen der Datei hinzufügen
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Hier Code einfügen, um den aktuellen Inhalt des Formulars in einer Datei zu speichern
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Mithilfe von My.Computer.Clipboard den ausgewählten Text bzw. die ausgewählten Bilder in die Zwischenablage kopieren
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Mithilfe von My.Computer.Clipboard den ausgewählten Text bzw. die ausgewählten Bilder in die Zwischenablage kopieren
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Mithilfe von My.Computer.Clipboard.GetText() oder My.Computer.Clipboard.GetData Informationen aus der Zwischenablage abrufen
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Alle untergeordneten Formulare des übergeordneten Formulars schließen
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ReplacementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplacementToolStripMenuItem.Click
        FrmReplacement.Show()
    End Sub

    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        FrmPDF.Show()
    End Sub

    Private Sub SelectProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectProjectToolStripMenuItem.Click
        FrmProjects.Show()
    End Sub

    Public Sub FillProjectIni()
        With ProjectIniData
            .LastCustomer = My.Settings.LastCustomer
            .LastDocTitle = My.Settings.LastDocTitle
            .LastDocumentation = My.Settings.LastDocumentation
            .LastFolder = My.Settings.LastFolder
            .LastFooter = My.Settings.LastFooter
            .LastHeader = My.Settings.LastHeader
            .LastOriginal = My.Settings.LastOriginal
            .LastReplacement = My.Settings.LastReplacement
            .LastPDFFile = My.Settings.LastPDFFile
        End With
    End Sub

    Public Sub SaveProjectIni()
        With ProjectIniData
            My.Settings.LastCustomer = .LastCustomer
            My.Settings.LastDocTitle = .LastDocTitle
            My.Settings.LastDocumentation = .LastDocumentation
            My.Settings.LastFolder = .LastFolder
            My.Settings.LastFooter = .LastFooter
            My.Settings.LastHeader = .LastHeader
            My.Settings.LastOriginal = .LastOriginal
            My.Settings.LastReplacement = .LastReplacement
        End With
        My.Settings.Save()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TslCurrentProject.Text = My.Settings.CurrentProject
        Me.ToolStrip.Visible = False
    End Sub

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing

        FillProjectIni()
        Dim pi = ProjectIniData
        cProjectIni.WriteProjectIniFile(Path.Combine(AppDataPath, My.Settings.CurrentProject & ".inoini"), pi)
    End Sub

    Private Sub EditFooterHeaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditFooterHeaderToolStripMenuItem.Click
        FrmHtml.Show()
    End Sub

    Private Sub ReplacementTMDLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplacementTMDLToolStripMenuItem.Click
        FrmTMDL.Show()
    End Sub

    Private Sub UsageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsageToolStripMenuItem.Click
        FrmMeasuresUsage.Show()
    End Sub
End Class
