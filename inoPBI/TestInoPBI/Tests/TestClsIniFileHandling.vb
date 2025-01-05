Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Runtime
Imports inoPBIDLL
Imports NUnit.Framework
Imports NUnit.Framework.Internal
Imports File = System.IO.File

Namespace TestInoPBI
    Public Class TestClsIniFileHandling
        Private testPath As String = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)).Replace("\bin", ""), "TestData")
        'Private DBFile As String = testPath & "\TestData\DB\pfalzenCurrentDB.accdb"
        Private cIFH As ClsIniFileHandling
        Private cHelper As New ClsHelper
        Private testFolder As String
        Private ProjectIniD As New ClsIniFileHandling.IniData

        <SetUp>
        Public Sub Setup()
            testFolder = cHelper.CreateTestFolder("currenttestdata")
            cHelper.DeleteTestFolder(testFolder)
            'DBFileTest = testFolder & "\pfalzenCurrentDB.accdb"
            'File.Copy(DBFile, DBFileTest)
            cIFH = New ClsIniFileHandling()
            FillProjectIniData()
        End Sub

        <TearDown>
        Public Sub TearDown()
            cHelper.DeleteTestFolder(testFolder)
        End Sub

        <Test>
        Public Sub TestGetProjectIniFromFile()
            Dim ProjectIniData As New ClsIniFileHandling.IniData
            Dim strFile As String = Path.Combine(testFolder, "testData.inoini")
            File.Copy(Path.Combine(testPath, "testData.inoini"), strFile)
            ProjectIniData = cIFH.GetProjectIniFromFile(strFile)

            TestProjectIniData(ProjectIniData)
        End Sub

        <Test>
        Public Sub TestWriteProjectIniFile()
            Dim ProjectIniData As New ClsIniFileHandling.IniData
            Dim strFile As String = Path.Combine(testFolder, "testDataTest.inoini")

            Dim testBln As Boolean = cIFH.WriteProjectIniFile(strFile, ProjectIniD)

            Assert.That(testBln, NUnit.Framework.Is.EqualTo(True))

            ProjectIniData = cIFH.GetProjectIniFromFile(strFile)

            TestProjectIniData(ProjectIniData)
        End Sub

        Private Sub TestProjectIniData(ProjectIniData As ClsIniFileHandling.IniData)
            Assert.That(ProjectIniData.LastOriginal, NUnit.Framework.Is.EqualTo(ProjectIniD.LastOriginal))
            Assert.That(ProjectIniData.LastReplacement, NUnit.Framework.Is.EqualTo(ProjectIniD.LastReplacement))
            Assert.That(ProjectIniData.LastFolder, NUnit.Framework.Is.EqualTo(ProjectIniD.LastFolder))
            Assert.That(ProjectIniData.LastCustomer, NUnit.Framework.Is.EqualTo(ProjectIniD.LastCustomer))
            Assert.That(ProjectIniData.LastDocumentation, NUnit.Framework.Is.EqualTo(ProjectIniD.LastDocumentation))
            Assert.That(ProjectIniData.LastFooter, NUnit.Framework.Is.EqualTo(ProjectIniD.LastFooter))
            Assert.That(ProjectIniData.LastHeader, NUnit.Framework.Is.EqualTo(ProjectIniD.LastHeader))
            Assert.That(ProjectIniData.LastPDFFile, NUnit.Framework.Is.EqualTo(ProjectIniD.LastPDFFile))
            Assert.That(ProjectIniData.LastTMDLFile, NUnit.Framework.Is.EqualTo(ProjectIniD.LastTMDLFile))
            Assert.That(ProjectIniData.LastReplacementOption, NUnit.Framework.Is.EqualTo(ProjectIniD.LastReplacementOption))
            Assert.That(ProjectIniData.LastPowerBIFile, NUnit.Framework.Is.EqualTo(ProjectIniD.LastPowerBIFile))
        End Sub

        Private Sub FillProjectIniData()
            ProjectIniD.LastOriginal = "model.bim"
            ProjectIniD.LastReplacement = "DataReplacement.txt"
            ProjectIniD.LastFolder = "demo"
            ProjectIniD.LastCustomer = "dem"
            ProjectIniD.LastDocumentation = "demo.md"
            ProjectIniD.LastFooter = "footer.html"
            ProjectIniD.LastHeader = "header.html"
            ProjectIniD.LastPDFFile = "demo.pdf"
            ProjectIniD.LastTMDLFile = "demo.SemanticModel"
            ProjectIniD.LastReplacementOption = False
            ProjectIniD.LastPowerBIFile = "test.pbip"
        End Sub
    End Class
End Namespace

