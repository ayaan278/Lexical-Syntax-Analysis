Imports Microsoft.VisualBasic

Public Class Parser
    Public nextToken As Token

    Private Sub acceptToken(ByVal k As Integer)
        Dim scanner As Scanner = New Scanner

        If nextToken.kind = k Then
            MyCompiler.ResultBlock.Items.Add(nextToken.ToString)
            nextToken = scanner.scan
        Else
            syntaxError = True
        End If
    End Sub

    Private Sub parse_statement()
        'Parser for the statement


    End Sub

    Public Sub parse_program()
        Select Case nextToken.kind
            Case Token.SOF
                acceptToken(Token.SOF)
                parse_statement()
            Case Token.EOF
                acceptToken(Token.EOF)
                parse_statement()
            Case Token.IDENTIFIERS
                acceptToken(Token.IDENTIFIERS)
                parse_statement()
            Case Token.INTEGERS
                acceptToken(Token.INTEGERS)
                parse_statement()
            Case Token.OPERATORS
                acceptToken(Token.OPERATORS)
                parse_statement()
            Case Token.SEPARATORS
                acceptToken(Token.SEPARATORS)
                parse_statement()
            Case Token.KEYWORDS
                acceptToken(Token.KEYWORDS)
                parse_statement()
            Case Else
                syntaxError = True
        End Select
    End Sub

End Class
