Imports System.IO
Imports inoPBIDLL

Public Class FrmProjects
    Private cProjectIni As New ClsIniFileHandling

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdSelect_Click(sender As Object, e As EventArgs) Handles CmdSelect.Click
        If LbProjects.SelectedItems.Count = 0 Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgNothingSelected)
            Exit Sub
        End If
        Dim strCurProject As String = LbProjects.SelectedItem.ToString
        Dim File As String
        File = Path.Combine(FrmMain.AppDataPath, strCurProject & ".inoini")
        FrmMain.ProjectIniData = cProjectIni.GetProjectIniFromFile(File)
        My.Settings.CurrentProject = strCurProject
        FrmMain.SaveProjectIni()
        FrmMain.TslCurrentProject.Text = String.Format(My.Resources.ResourcesLang.MainTslCurrentProject, strCurProject)
    End Sub

    Private Sub CmdNewProject_Click(sender As Object, e As EventArgs) Handles CmdNewProject.Click
        Dim strProject As String = InputBox(My.Resources.ResourcesLang.ProjectsEnterProjectName)
        If strProject <> vbNullString Then

            Dim pi As New ClsIniFileHandling.IniData
            cProjectIni.WriteProjectIniFile(Path.Combine(FrmMain.AppDataPath, strProject & ".inoini"), pi)
            FrmMain.SaveProjectIni()
            My.Settings.CurrentProject = strProject
            My.Settings.Save()

            Me.LbProjects.Items.Add(strProject)
            LbProjects.SelectedIndex = LbProjects.Items.Count - 1
            FrmMain.TslCurrentProject.Text = String.Format(My.Resources.ResourcesLang.MainTslCurrentProject, strProject)
        End If
    End Sub

    Private Sub FrmProjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Directory.Exists(FrmMain.AppDataPath)) = False Then
            Directory.CreateDirectory(FrmMain.AppDataPath)
        End If
        Dim intCount As Integer = 0
        Dim ListIndex As Integer = Nothing
        For Each FileName As String In My.Computer.FileSystem.GetFiles(FrmMain.AppDataPath, FileIO.SearchOption.SearchTopLevelOnly, "*.inoini")
            Dim strFile As String = Path.GetFileNameWithoutExtension(FileName)
            Me.LbProjects.Items.Add(strFile)
            If strFile = My.Settings.CurrentProject Then
                ListIndex = intCount
            End If
            intCount += 1
        Next

        If LbProjects.Items.Count > 0 Then
            LbProjects.SelectedIndex = ListIndex
        End If

        TranslateForm()
    End Sub

    Private Sub CmdRenameProject_Click(sender As Object, e As EventArgs) Handles CmdRenameProject.Click
        If LbProjects.SelectedItems.Count = 0 Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgNothingSelected)
            Exit Sub
        End If
        Dim strCurProject As String = LbProjects.SelectedItem.ToString
        Dim ListIndex As Integer = LbProjects.SelectedIndex
        Dim strProject As String = InputBox(My.Resources.ResourcesLang.ProjectsEnterProjectName, My.Resources.ResourcesLang.ProjectsRenameProjectName, strCurProject)
        If strProject <> vbNullString Then
            Dim OldFile As String = Path.Combine(FrmMain.AppDataPath, strCurProject & ".inoini")
            My.Computer.FileSystem.RenameFile(OldFile, strProject & ".inoini")
            LbProjects.Items.RemoveAt(ListIndex)
            LbProjects.Items.Insert(ListIndex, strProject)
            If strCurProject = My.Settings.CurrentProject Then
                My.Settings.CurrentProject = strProject
                My.Settings.Save()
                FrmMain.TslCurrentProject.Text = String.Format(My.Resources.ResourcesLang.MainTslCurrentProject, strProject)
            End If
        End If
    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.ProjectsTitle
        LblProjects.Text = My.Resources.ResourcesLang.ProjectsProject

        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdNewProject.Text = My.Resources.ResourcesLang.BtnNewProject
        CmdSelect.Text = My.Resources.ResourcesLang.BtnSelectProject
        CmdRenameProject.Text = My.Resources.ResourcesLang.BtnRenameProject
    End Sub
End Class