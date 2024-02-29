Imports System.IO
Imports System.Net
Imports System.Runtime
Imports System.Security.Cryptography.X509Certificates
Imports inoPBIDLL
Imports inoPBIDLL.ClsReportJson
Imports Newtonsoft.Json.Linq
Imports NUnit.Framework
Imports NUnit.Framework.Interfaces
Imports NUnit.Framework.Internal

Namespace TestInoPBI

    Public Class TestClsJSONReport
        Private testPath As String = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)).Replace("\bin", "")
        'Private DBFile As String = testPath & "\TestData\DB\pfalzenCurrentDB.accdb"
        Private cJR As ClsJSONReport
        Private cHelper As New ClsHelper
        Private testFolder As String
        Private DBFileTest As String

        <SetUp>
        Public Sub Setup()
            testFolder = cHelper.CreateTestFolder("currenttestdata")
            cHelper.DeleteTestFolder(testFolder)
            'DBFileTest = testFolder & "\pfalzenCurrentDB.accdb"
            'File.Copy(DBFile, DBFileTest)
            cJR = New ClsJSONReport
        End Sub

        <TearDown>
        Public Sub TearDown()
            cHelper.DeleteTestFolder(testFolder)
        End Sub

        <Test>
        Public Sub TestReadReport()

            Dim strFile As String = testPath & "\TestData\tmdl\Nordwind.Report\report.json"
            cJR.ReadReport(strFile)
            Dim testMeasures As List(Of ClsJSONReport.ReportMeasure) = cJR.ReportMeasures
            Assert.That(testMeasures.Count, NUnit.Framework.Is.EqualTo(54))

            Dim pos As Int16 = 0
            Dim page As String = "Übersicht"
            Dim table As String = "Datumstabelle"
            Dim valuename As String = "Monat Jahr"

            testSingleReportMeasure(testMeasures, pos, page, table, valuename)
        End Sub

        <Test>
        Public Sub TestReadVC()

            Dim strFile As String = testPath & "\TestData\vcConfig1.json"

            Dim json As String = File.ReadAllText(strFile)

            cJR.ReportMeasures.Clear()

            cJR.ReadVC(json, "Testing")
            Dim testMeasures As List(Of ClsJSONReport.ReportMeasure) = cJR.ReportMeasures

            Assert.That(testMeasures.Count, NUnit.Framework.Is.EqualTo(4))
            Dim pos As Int16 = 0
            Dim page As String = "Testing"
            Dim table As String = "Nordwind2021"
            Dim valuename As String = "Artikelname"

            testSingleReportMeasure(testMeasures, pos, page, table, valuename)

            pos = 1
            table = "Nordwind2021"
            valuename = "Kategoriename"

            testSingleReportMeasure(testMeasures, pos, page, table, valuename)

            pos = 2
            table = "_Measures"
            valuename = "Umsatz"

            testSingleReportMeasure(testMeasures, pos, page, table, valuename)

            pos = 3
            table = "_Measures"
            valuename = "Menge"

            testSingleReportMeasure(testMeasures, pos, page, table, valuename)

        End Sub

        Private Shared Sub testSingleReportMeasure(testMeasures As List(Of ClsJSONReport.ReportMeasure), pos As Short, page As String, table As String, valuename As String)
            Assert.That(testMeasures(pos).Page, NUnit.Framework.Is.EqualTo(page))
            Assert.That(testMeasures(pos).Table, NUnit.Framework.Is.EqualTo(table))
            Assert.That(testMeasures(pos).Valuename, NUnit.Framework.Is.EqualTo(valuename))
        End Sub
    End Class
End Namespace
