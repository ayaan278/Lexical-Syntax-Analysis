Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions

Public Class RegEx
    Public word As String
    Private identifierPattern As String

    ' Function to scan the current token and return the token
    Public Function scanIdentifier() As String
        ' Check for IDENTIFIERS token
        Dim regex As New RegEx()

        If regex.ToString() = "^[a-zA-Z]+$" Then
            Return "valid"
        Else
            Return "invalid"
        End If
    End Function
End Class
