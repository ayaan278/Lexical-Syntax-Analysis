Imports Microsoft.VisualBasic

Public Class Token
    'Token kind
    Public kind As Integer
    'Spelling of the token
    Public spelling As String = ""


    'Constructor to initialize the token with the kind and spelling
    Public Sub New(ByVal kind As Integer, ByVal spelling As String)
        Me.kind = kind
        Me.spelling = spelling
    End Sub

    'Token kinds
    Public Shared SOF As Integer = 0
    Public Shared EOF As Integer = 1
    Public Shared IDENTIFIERS As Integer = 2
    Public Shared INTEGERS As Integer = 3
    Public Shared OPERATORS As Integer = 4
    Public Shared SEPARATORS As Integer = 5
    Public Shared KEYWORDS As Integer = 6
    Public Shared UNKNOWN As Integer = 7
    Public Shared LAST As Integer = 8

    'Check if the token is valid or invalid based on the kind
    Private checkOperator As String = "+-*/=<>"
    Private checkSeparator As String = ";"
    Private checkNumber As String = "0123456789"


    ' Check if the token is valid or invalid
    Public Function isValid() As String
        ' Check if the token is valid or invalid
        Select Case kind
            Case Token.SOF, Token.EOF, Token.OPERATORS, Token.SEPARATORS, Token.KEYWORDS, Token.INTEGERS, Token.IDENTIFIERS
                Return "valid"
            Case Else
                Return "invalid"
        End Select
    End Function

    'Get the kind type of the token
    Public Function GetKindType() As String
        Select Case kind
            Case SOF
                Return "SOF"
            Case EOF
                Return "EOF"
            Case IDENTIFIERS
                Return "IDENTIFIERS"
            Case INTEGERS
                Return "INTEGERS"
            Case OPERATORS
                Return "OPERATORS"
            Case SEPARATORS
                Return "SEPARATORS"
            Case KEYWORDS
                Return "KEYWORDS"
            Case UNKNOWN
                Return "UNKNOWN"
            Case LAST
                Return "LAST"
            Case Else
                Return "INVALID"
        End Select
    End Function

End Class
