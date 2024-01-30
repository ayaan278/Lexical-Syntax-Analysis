Imports Microsoft.VisualBasic

Public Class Token
    Public kind As Integer
    Public spelling As String = ""
    Public Sub New(ByVal kind As Integer, ByVal spelling As String)
        Me.kind = kind
        Me.spelling = spelling
    End Sub

    Public Shared SOF As Integer = 0
    Public Shared EOF As Integer = 1
    Public Shared IDENTIFIERS As Integer = 2
    Public Shared INTEGERS As Integer = 3
    Public Shared OPERATORS As Integer = 4
    Public Shared SEPARATORS As Integer = 5
    Public Shared KEYWORDS As Integer = 6
    Public Shared UNKNOWN As Integer = 7

    Public Overrides Function ToString() As String
        'Return the token in the form <kind, spelling, {valid or invalid}>
        Return "<" & kind & ", " & spelling & ", " & isValid() & ">"
    End Function

    Private Function isValid() As String
        'Check if the token is valid or invalid
        Select Case kind
            Case SOF
                Return "valid"
            Case EOF
                Return "valid"
            Case IDENTIFIERS
                If spelling = "if" Then
                    Return "valid"
                Else
                    Return "invalid"
                End If
            Case INTEGERS
                Return "valid"
            Case OPERATORS
                If spelling = "+" Or spelling = "-" Or spelling = "*" Or spelling = "/" Or spelling = "=" Or spelling = "<" Or spelling = ">" Then
                    Return "valid"
                Else
                    Return "invalid"
                End If
            Case SEPARATORS
                If spelling = ";" Then
                    Return "valid"
                Else
                    Return "invalid"
                End If
            Case KEYWORDS
                If spelling = "if" Or spelling = "then" Or spelling = "else" Or spelling = "end" Then
                    Return "valid"
                Else
                    Return "invalid"
                End If
            Case Else
                Return "invalid"
        End Select
    End Function
End Class
