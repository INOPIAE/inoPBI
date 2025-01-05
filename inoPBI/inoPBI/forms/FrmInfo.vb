﻿Imports System.Reflection

Public NotInheritable Class FrmInfo

    Private Sub FrmInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Legen Sie den Titel des Formulars fest.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format(My.Resources.ResourcesLang.InfoTitle, ApplicationTitle)
        ' Initialisieren Sie den gesamten Text, der im Infofeld angezeigt wird.
        ' TODO: Die Assemblyinformationen der Anwendung im Bereich "Anwendung" des Dialogfelds für die 
        '    Projekteigenschaften (im Menü "Projekt") anpassen.
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format(My.Resources.ResourcesLang.InfoVersion, GetApplicationVersion)
        Me.LabelCopyright.Text = My.Resources.ResourcesLang.InfoCopyright & IIf(Year(Now) = 2023, Year(Now), "2023-" & Year(Now))
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
        OKButton.Text = My.Resources.ResourcesLang.BtnOK
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Function GetApplicationVersion() As String
        ' Retrieve the version from the assembly
        Dim version As Version = Assembly.GetExecutingAssembly().GetName().Version
        Return version.ToString()
    End Function
End Class
