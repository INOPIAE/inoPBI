Imports System.Runtime.CompilerServices

Public Class ClsReplacementInfo
    Public StartPos As Int16
    Public EndPos As Int16
    Private _ReplaceValue As String
    Private _ReplaceLine As String

    Public Sub New(ReplaceValue As String, ReplaceLine As String)
        _ReplaceValue = ReplaceValue
        _ReplaceLine = ReplaceLine
    End Sub

    Public Function GetValue(Optional AddStart As Int16 = 0)
        StartPos = _ReplaceLine.IndexOf(_ReplaceValue, AddStart)
        EndPos = _ReplaceLine.IndexOf(",", StartPos)
        Return _ReplaceLine.Substring(StartPos + _ReplaceValue.Length, EndPos - StartPos - _ReplaceValue.Length).Trim
    End Function

End Class
