﻿Imports System.Collections.ObjectModel
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.IO
Imports System.Runtime
Imports System.Security.Cryptography.X509Certificates
Imports inoPBIDLL
Imports inoPBIDLL.ClsReportJson
Imports Newtonsoft.Json.Linq
Imports NUnit.Framework
Imports NUnit.Framework.Internal

Namespace TestInoPBI
    Public Class TestClsTMDLHandling
        Private testPath As String = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)).Replace("\bin", "")
        'Private DBFile As String = testPath & "\TestData\DB\pfalzenCurrentDB.accdb"
        Private cTMDL As ClsTMDLHandling
        Private cHelper As New ClsHelper
        Private testFolder As String
        Private DBFileTest As String

        <SetUp>
        Public Sub Setup()
            testFolder = cHelper.CreateTestFolder("currenttestdata")
            cHelper.DeleteTestFolder(testFolder)
            'DBFileTest = testFolder & "\pfalzenCurrentDB.accdb"
            'File.Copy(DBFile, DBFileTest)
            cTMDL = New ClsTMDLHandling(testPath & "\TestData\tmdl\Nordwind.Dataset")
        End Sub

        <TearDown>
        Public Sub TearDown()
            cHelper.DeleteTestFolder(testFolder)
        End Sub

        <Test>
        Public Sub TestReadMeasuresFile()
            Dim strFile As String = Path.Combine(cTMDL.FolderPathTables, "_Measures.tmdl")

            cTMDL.Elements.Clear()
            cTMDL.ReadTable(strFile)

            Dim testElements As List(Of ClsTMDLHandling.Element) = cTMDL.Elements

            Assert.That(testElements.Count, NUnit.Framework.Is.EqualTo(10))


            Dim table As String = "_Measures"
            Dim mName As String = "Umsatz"
            Dim description As String = vbNullString
            Dim value As String = "sum(Nordwind[Endpreis])"
            Dim displayFolder As String = "Umsatz"
            Dim eType As ClsTMDLHandling.ElementType = ClsTMDLHandling.ElementType.Measure
            Dim pos As Long = 0

            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos)

            pos = 1
            mName = "Umsatz Vorjahr"
            value = "CALCULATE(_Measures[Umsatz],SAMEPERIODLASTYEAR(Datumstabelle[Datum]))"
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos)

            pos = 2
            mName = "Menge"
            value = "SUM(Nordwind[Anzahl])"
            displayFolder = Nothing
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos)

            pos = 3
            mName = "Tacho_Max"
            value = "IF(_Measures[Umsatz Vorjahr]>_Measures[Umsatz],_Measures[Umsatz Vorjahr]*1.2,_Measures[Umsatz]*1.2)"
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos)


            pos = 4
            mName = "Tacho_Min"
            value = "IF(_Measures[Umsatz Vorjahr]<_Measures[Umsatz],_Measures[Umsatz Vorjahr]*0.8,_Measures[Umsatz]*0.8)"
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos)

            pos = 5
            mName = "Kunden"
            value = "DISTINCTCOUNT(Nordwind[Firma])"
            description = "Anzahl der eindeutigen Kunden"
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos)

            pos = 6
            mName = "Deckungsbeitrag Vorjahr gesamt"
            value = "```" & vbCrLf & "    VAR Jahr = Year("
            description = vbNullString
            displayFolder = "Lfd Jahr"
            eType = ClsTMDLHandling.ElementType.Measure
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos, True)

            pos = 7
            mName = "Rohertrag BWA"
            value = "CALCULATE([Ist],'BWA-Plan-Controlling'[Kostenart]=""Rohertrag"")"
            description = vbNullString
            displayFolder = "BWA"
            eType = ClsTMDLHandling.ElementType.Measure
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos)

            pos = 8
            mName = "Durchschnittlich Score pro FrageNr"
            value = vbCrLf _
                & "AVERAGEX(" _
                & vbCrLf & "KEEPFILTERS(VALUES('Antworten 2024'[FrageNr]))," _
                & vbCrLf & "CALCULATE(AVERAGE('Antworten 2024'[Score]))" _
                & vbCrLf & ")"
            description = vbNullString
            displayFolder = "Auswertung"
            eType = ClsTMDLHandling.ElementType.Measure
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos)

            pos = 9
            mName = "_Measures"
            value = "let" & vbCrLf & "    Quelle = Table.FromRows"
            description = vbNullString
            displayFolder = Nothing
            eType = ClsTMDLHandling.ElementType.PowerQuery
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos, True)
        End Sub

        Private Shared Sub TestSingleElement(testElements As List(Of ClsTMDLHandling.Element), table As String, mName As String, description As String, value As String, displayFolder As String, eType As ClsTMDLHandling.ElementType, pos As Long, Optional blnSource As Boolean = False)
            Assert.That(testElements(pos).TableName, NUnit.Framework.Is.EqualTo(table))
            Assert.That(testElements(pos).Name, NUnit.Framework.Is.EqualTo(mName))
            Assert.That(testElements(pos).Description, NUnit.Framework.Is.EqualTo(description))

            If blnSource = True Then
                Assert.That(testElements(pos).Value.Substring(0, value.Length), NUnit.Framework.Is.EqualTo(value))
            Else
                Assert.That(testElements(pos).Value, NUnit.Framework.Is.EqualTo(value))
            End If
            Assert.That(testElements(pos).Displayfolder, NUnit.Framework.Is.EqualTo(displayFolder))
            Assert.That(testElements(pos).Type, NUnit.Framework.Is.EqualTo(eType))
        End Sub

        <Test>
        Public Sub TestReadNeukundenFile()
            Dim strFile As String = Path.Combine(cTMDL.FolderPathTables, "Neukunden.tmdl")

            cTMDL.Elements.Clear()
            cTMDL.ReadTable(strFile)

            Dim testElements As List(Of ClsTMDLHandling.Element) = cTMDL.Elements

            Assert.That(testElements.Count, NUnit.Framework.Is.EqualTo(1))


            Dim table As String = "Neukunden"
            Dim mName As String = "Neukunden"
            Dim description As String = vbNullString
            Dim value As String = "SUMMARIZE(" & vbCrLf & "    Nordwind,"
            Dim displayFolder As String = Nothing
            Dim eType As ClsTMDLHandling.ElementType = ClsTMDLHandling.ElementType.PowerQuery
            Dim pos As Long = 0

            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos, True)
        End Sub

        <Test>
        Public Sub TestReadGewinnVariabel()
            Dim strFile As String = Path.Combine(cTMDL.FolderPathTables, "Gewinn variabel.tmdl")

            cTMDL.Elements.Clear()
            cTMDL.ReadTable(strFile)

            Dim testElements As List(Of ClsTMDLHandling.Element) = cTMDL.Elements

            Assert.That(testElements.Count, NUnit.Framework.Is.EqualTo(2))


            Dim table As String = "Gewinn variabel"
            Dim mName As String = "Gewinn variabel Wert"
            Dim description As String = vbNullString
            Dim value As String = "SELECTEDVALUE('Gewinn variabel'[Gewinn variabel], 250000)"
            Dim displayFolder As String = Nothing
            Dim eType As ClsTMDLHandling.ElementType = ClsTMDLHandling.ElementType.Measure
            Dim pos As Long = 0

            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos, False)

            pos = 1
            mName = "Gewinn variabel"
            value = "GENERATESERIES(100000, 500000, 50000)"
            description = vbNullString
            displayFolder = Nothing
            eType = ClsTMDLHandling.ElementType.PowerQuery
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos)

        End Sub

        <Test>
        Public Sub TestReadNordwindFile()
            Dim strFile As String = Path.Combine(cTMDL.FolderPathTables, "Nordwind.tmdl")

            cTMDL.Elements.Clear()
            cTMDL.ReadTable(strFile)

            Dim testElements As List(Of ClsTMDLHandling.Element) = cTMDL.Elements

            Assert.That(testElements.Count, NUnit.Framework.Is.EqualTo(2))


            Dim table As String = "Nordwind"
            Dim mName As String = "Region"
            Dim description As String = vbNullString
            Dim value As String = "RELATED(Regionen[Region])"
            Dim displayFolder As String = Nothing
            Dim eType As ClsTMDLHandling.ElementType = ClsTMDLHandling.ElementType.Column
            Dim pos As Long = 0

            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos)

            pos = 1
            mName = "Nordwind"
            value = "let" & vbCrLf & "    Quelle = Csv.Document(File.Contents("
            description = vbNullString
            eType = ClsTMDLHandling.ElementType.PowerQuery
            TestSingleElement(testElements, table, mName, description, value, displayFolder, eType, pos, True)
        End Sub

        <Test>
        Public Sub TestReadTables()

            Dim testElements As List(Of ClsTMDLHandling.Element) = cTMDL.Elements

            Assert.That(testElements.Count, NUnit.Framework.Is.EqualTo(0))

            cTMDL.ReadTables()

            testElements = cTMDL.Elements

            Assert.That(testElements.Count, NUnit.Framework.Is.EqualTo(16))

            Dim tables As New List(Of String)()
            For Each el As ClsTMDLHandling.Element In testElements
                Dim strTable As String = el.TableName
                If tables.FirstOrDefault(Function(x) x = strTable) <> strTable Then
                    tables.Add(strTable)
                End If
            Next

            Assert.That(tables.Count, NUnit.Framework.Is.EqualTo(6))
            Assert.That(tables, Has.Member("_Measures"))
            Assert.That(tables, Has.Member("Datumstabelle"))
            Assert.That(tables, Has.Member("Neukunden"))
            Assert.That(tables, Has.Member("Nordwind"))
            Assert.That(tables, Has.Member("Regionen"))
            Assert.That(tables, Has.Member("Gewinn variabel"))

            Assert.That(tables, Has.No.Member("DateTableTemplate_hash"))
            Assert.That(tables, Has.No.Member("LocalDateTable_hash"))


        End Sub

        <Test>
        Public Sub TestCheckMeasures()
            cTMDL.CheckMeasures()



            Assert.That(cTMDL.measuresCheck.Count, NUnit.Framework.Is.EqualTo(9))

            Dim strM As String = "Umsatz"
            Dim strTarget As String = "Umsatz Vorjahr, Tacho_Max, Tacho_Min, Deckungsbeitrag Vorjahr gesamt"
            Dim pos As Int16 = 1

            Assert.That(cTMDL.measuresCheck.ElementAt(pos).Key, NUnit.Framework.Is.EqualTo(strM))
            Assert.That(cTMDL.measuresCheck.ElementAt(pos).Value, NUnit.Framework.Is.EqualTo(strTarget))

            strM = "Umsatz Vorjahr"
            strTarget = "Tacho_Max, Tacho_Min"
            pos = 2

            Assert.That(cTMDL.measuresCheck.ElementAt(pos).Key, NUnit.Framework.Is.EqualTo(strM))
            Assert.That(cTMDL.measuresCheck.ElementAt(pos).Value, NUnit.Framework.Is.EqualTo(strTarget))

            strM = "Menge"
            strTarget = Nothing
            pos = 3

            Assert.That(cTMDL.measuresCheck.ElementAt(pos).Key, NUnit.Framework.Is.EqualTo(strM))
            Assert.That(cTMDL.measuresCheck.ElementAt(pos).Value, NUnit.Framework.Is.EqualTo(strTarget))
        End Sub

        <Test>
        Public Sub TestSplitLine()

            Dim strInput As String = "				    SharepointDatei = NavigationSharepoint{[Name=""dietestdatei.xlsx"",#""Folder Path""=""https://mydomain.sharepoint.com/sites/0113400001/Datentransfer/powerbi/Daten/Bestandsliste/""]}[Content],"
            Dim strResult As String = cTMDL.splitLine(strInput)
            Dim strTarget As String = "				    SharepointDatei = NavigationSharepoint{[Name=""dietestdatei.xlsx"",#""Folder" & vbCrLf &
                "           Path""=""https://mydomain.sharepoint.com/sites/0113400001/Datentransfer/powerbi" & vbCrLf &
                "           /Daten/Bestandsliste/""]}[Content],"

            Assert.That(strResult, NUnit.Framework.Is.EqualTo(strTarget))

            strInput = "				    #Geänderter Typ = Table.TransformColumnTypes(#Höher gestufte Header,{{WE Nr., type text}, {Asset, type text}, {Plz Ort, type text}, {Mandant, type text}, {Standort, type text}, {Altersklasse, type text}, {Verwaltung, type text}, {Baujahr, Int64.Type}, {Anz. Gebäude, Int64.Type}, {Kauf, Int64.Type}, {Verkauf, type any}, {Aktiv ab, Int64.Type}, {Aktiv bis, type any}, { Wohnungseinheiten, Int64.Type}, {Gewerbeeinheiten, Int64.Type}, {Garagen/Stellplätze, Int64.Type}, {Anzahl Sonstiges, Int64.Type}, {Wohnfläche, type number}, {Gewerbefläche, type number}, {VMF, type number}, {GF, Int64.Type}}),"
            strTarget = "				    #Geänderter Typ = Table.TransformColumnTypes(#Höher gestufte Header,{{WE Nr., type" & vbCrLf &
                "           text}, {Asset, type text}, {Plz Ort, type text}, {Mandant, type text}, {Standort," & vbCrLf &
                "           type text}, {Altersklasse, type text}, {Verwaltung, type text}, {Baujahr," & vbCrLf &
                "           Int64.Type}, {Anz. Gebäude, Int64.Type}, {Kauf, Int64.Type}, {Verkauf, type any}," & vbCrLf &
                "           {Aktiv ab, Int64.Type}, {Aktiv bis, type any}, { Wohnungseinheiten, Int64.Type}," & vbCrLf &
                "           {Gewerbeeinheiten, Int64.Type}, {Garagen/Stellplätze, Int64.Type}, {Anzahl" & vbCrLf &
                "           Sonstiges, Int64.Type}, {Wohnfläche, type number}, {Gewerbefläche, type number}," & vbCrLf &
                "           {VMF, type number}, {GF, Int64.Type}}),"
            strResult = cTMDL.splitLine(strInput)
            Assert.That(strResult, NUnit.Framework.Is.EqualTo(strTarget))

            strInput = "				    SharepointDatei = NavigationSharepoint{[Name=""dietestdatei.xlsx"",#""Folder Path""=""C:\mydomain.sharepoint.com\sites\0113400001\Datentransfer\powerbi\Daten\Bestandsliste\""]}[Content],"
            strResult = cTMDL.splitLine(strInput)
            strTarget = "				    SharepointDatei = NavigationSharepoint{[Name=""dietestdatei.xlsx"",#""Folder" & vbCrLf &
                "           Path""=""C:\mydomain.sharepoint.com\sites\0113400001\Datentransfer\powerbi" & vbCrLf &
                "           \Daten\Bestandsliste\""]}[Content],"

            Assert.That(strResult, NUnit.Framework.Is.EqualTo(strTarget))
        End Sub

    End Class
End Namespace
