Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Runtime
Imports inoPBIDLL
Imports NUnit.Framework
Imports NUnit.Framework.Internal
Imports File = System.IO.File

Namespace TestInoPBI
    Public Class TestClsHelper
        Private testPath As String = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)).Replace("\bin", ""), "TestData")
        'Private DBFile As String = testPath & "\TestData\DB\pfalzenCurrentDB.accdb"
        Private cH As inoPBIDLL.ClsHelper
        Private cHelper As New ClsHelper
        Private testFolder As String


        <SetUp>
        Public Sub Setup()
            testFolder = cHelper.CreateTestFolder("currenttestdata")
            cHelper.DeleteTestFolder(testFolder)
            'DBFileTest = testFolder & "\pfalzenCurrentDB.accdb"
            'File.Copy(DBFile, DBFileTest)
            cH = New inoPBIDLL.ClsHelper
        End Sub

        <TearDown>
        Public Sub TearDown()
            cHelper.DeleteTestFolder(testFolder)
        End Sub

        <Test>
        Public Sub TestGetProjectType()

            Dim strFile As String = Path.Combine(testPath, "bim", "bim.pbip")
            Dim pt As New inoPBIDLL.ClsHelper.ProjectType
            pt = cH.GetProjectType(strFile)

            Assert.That(pt.Path, NUnit.Framework.Is.EqualTo(Path.Combine(testPath, "bim", "bim.Dataset")))
            Assert.That(pt.Type, NUnit.Framework.Is.EqualTo(1))

            strFile = Path.Combine(testPath, "tmdl", "nw.pbip")
            pt = cH.GetProjectType(strFile)

            Assert.That(pt.Path, NUnit.Framework.Is.EqualTo(Path.Combine(testPath, "tmdl", "Nordwind.Dataset")))
            Assert.That(pt.Type, NUnit.Framework.Is.EqualTo(2))
        End Sub

        <Test>
        Public Sub TestGetSaveTime()

            Dim strFile As String = Path.Combine(testPath, "bim", "bim.pbip")
            Dim lastTime As String = cH.GetSaveTime(strFile)

            Assert.That(lastTime, NUnit.Framework.Is.EqualTo("Letzte Speicherung: 07.01.2025 06:30:20"))

            strFile = Path.Combine(testPath, "bim", "bim.pbip1")
            lastTime = cH.GetSaveTime(strFile)

            Assert.That(lastTime, NUnit.Framework.Is.Null)

        End Sub

        <Test>
        Public Sub TestCheckFileFolder()

            Dim strFile As String = Path.Combine(testPath, "bim1", "bim.pbip")
            Dim result As String = cH.CheckFileFolder(strFile)

            Assert.That(result, NUnit.Framework.Is.EqualTo("Der angegebene Ordner existiert nicht."))

            strFile = Path.Combine(testPath, "bim", "bim.pbip")
            result = cH.CheckFileFolder(strFile)

            Assert.That(result, NUnit.Framework.Is.Null)

        End Sub

        <Test>
        Public Sub TestCheckFile()

            Dim strFile As String = Path.Combine(testPath, "bim", "bim1.pbip")
            Dim result As String = cH.CheckFile(strFile)

            Assert.That(result, NUnit.Framework.Is.EqualTo("Keine Datei angegeben."))

            strFile = Path.Combine(testPath, "bim", "bim.pbip")
            result = cH.CheckFile(strFile)
            Assert.That(result, NUnit.Framework.Is.Null)

            strFile = Path.Combine(testPath, "bim", "bim1.pbip")
            result = cH.CheckFile(strFile, False)
            Assert.That(result, NUnit.Framework.Is.EqualTo("Keine Datei angegeben."))

            strFile = Path.Combine(testPath, "bim", "bim1.pbip")
            result = cH.CheckFile(strFile, True)
            Assert.That(result, NUnit.Framework.Is.EqualTo("Keine Datei angegeben."))

            strFile = Path.Combine(testPath, "bim", "bim.pbip")
            result = cH.CheckFile(strFile, False)
            Assert.That(result, NUnit.Framework.Is.Null)

            strFile = Path.Combine(testPath, "bim", "bim.pbip")
            result = cH.CheckFile(strFile, True)
            Assert.That(result, NUnit.Framework.Is.Null)


            result = cH.CheckFile(vbNullString, False)
            Assert.That(result, NUnit.Framework.Is.EqualTo("Keine Datei angegeben."))

            result = cH.CheckFile(vbNullString, True)
            Assert.That(result, NUnit.Framework.Is.Null)
        End Sub
    End Class
End Namespace
