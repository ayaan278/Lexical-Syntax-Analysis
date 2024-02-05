Imports Microsoft.VisualBasic

Public Class Parser
    Public nextToken As Token
    Dim scanner As Scanner = New Scanner
    Public sofFound As Boolean = False
    Public eofFound As Boolean = False

    Private Sub acceptToken(ByVal k As Integer)
        If nextToken.kind = k Then
            nextToken = scanner.scan
        Else
            syntaxError = True
            Debug.WriteLine("Parse Accept Token Error " + nextToken.spelling + nextToken.GetKindType)
            MyCompiler.ResultBlock.Items.Add("Parse Accept Token Error " + nextToken.spelling)
        End If
    End Sub

    ' 
    Public Sub ResetSyntaxError()
        syntaxError = False
    End Sub


    'The parse_program function will be used to parse the whole program.
    Public Sub parse_program()
        Select Case nextToken.kind
            Case Token.SOF
                parse_start()
            Case Token.INTEGERS, Token.IDENTIFIERS, Token.BRACES, Token.SEPARATORS, Token.OPERATORS, Token.KEYWORDS
                parse_statement_list()
            Case Token.EOF
                parse_end()
            Case Token.LAST
                ' Do nothing
            Case Else
                syntaxError = True
                MyCompiler.ResultBlock.Items.Add("Parse Program Error " + nextToken.spelling)
        End Select
    End Sub

    Private Sub parse_start()
        ' Parsing logic for "#Start"
        If sofFound = False Then
            acceptToken(Token.SOF)
            sofFound = True
        Else
            syntaxError = True
            MyCompiler.ResultBlock.Items.Add("Parse Start Error " + nextToken.spelling)
        End If

    End Sub
    Private Sub parse_end()
        ' Parsing logic for "#End"
        If eofFound = False Then
            acceptToken(Token.EOF)
            eofFound = True
        Else
            syntaxError = True
            MyCompiler.ResultBlock.Items.Add("Parse End Error " + nextToken.spelling)
        End If
    End Sub

    Private Sub parse_statement_list()
        'Debug.WriteLine(nextToken.spelling)

        ' Parsing logic for <statement_list>
        parse_statement()

        ' Check for { <seperator> <statement> }
        While nextToken.kind = Token.SEPARATORS
            parse_separators()
            parse_statement()
        End While
    End Sub

    Private Sub parse_statement()
        ' Parsing logic for <statement>
        Select Case nextToken.kind
            Case Token.KEYWORDS
                If nextToken.spelling = "Int" Then
                    parse_declaration()
                ElseIf nextToken.spelling = "Print" Then
                    parse_command()
                ElseIf nextToken.spelling = "If" Then
                    parse_if_statement()
                End If
            Case Token.IDENTIFIERS
                parse_assignment()
            Case Token.SEPARATORS, Token.BRACES, Token.INTEGERS, Token.OPERATORS, Token.LAST, Token.EOF, Token.SOF
                ' Do nothing for separators
        End Select
    End Sub


    Private Sub parse_if_statement()
        ' Parsing logic for <if_statement>
        ' Check for "If"
        If nextToken.spelling = "If" Then
            ' Accept the "If" keyword
            acceptToken(Token.KEYWORDS)

            Debug.WriteLine("If Statement: " + nextToken.spelling)

            ' Check for "("
            If nextToken.kind = Token.BRACES Then
                If nextToken.spelling = "(" Then
                    acceptToken(Token.BRACES)
                Else
                    syntaxError = True
                    MyCompiler.ResultBlock.Items.Add("Parse If Missing Brackets Error (")
                    Return ' Return to avoid further processing
                End If
            End If

            parse_condition()

            ' Check for ")"
            If nextToken.kind = Token.BRACES Then
                If nextToken.spelling = ")" Then
                    acceptToken(Token.BRACES)
                Else
                    syntaxError = True
                    MyCompiler.ResultBlock.Items.Add("Parse If Missing Brackets Error )")
                    Return ' Return to avoid further processing
                End If
            End If

            ' Check for "{"
            If nextToken.kind = Token.BRACES Then
                If nextToken.spelling = "{" Then
                    acceptToken(Token.BRACES)
                Else
                    syntaxError = True
                    MyCompiler.ResultBlock.Items.Add("Parse If Missing Brackets Error {")
                    Return ' Return to avoid further processing
                End If
            End If

            parse_statement_list()

            ' Check for "}"
            If nextToken.kind = Token.BRACES Then
                If nextToken.spelling = "}" Then
                    acceptToken(Token.BRACES)
                Else
                    syntaxError = True
                    MyCompiler.ResultBlock.Items.Add("Parse If Missing Brackets Error }")
                End If
            End If

        Else
            syntaxError = True
            MyCompiler.ResultBlock.Items.Add("Parse Error in IF Block" + nextToken.spelling)
        End If
    End Sub

    Private Sub parse_declaration()
        ' Parsing logic for <declaration>
        Debug.WriteLine("Declaration: 0 " + nextToken.spelling)
        parse_type()
        Debug.WriteLine("Declaration: 1 " + nextToken.spelling)
        parse_identifier()
    End Sub

    Private Sub parse_assignment()
        ' Parsing logic for <assignment>
        parse_identifier()
        ' Check for equals sign also
        If nextToken.kind = Token.OPERATORS Then
            If nextToken.spelling = "=" Then
                acceptToken(Token.OPERATORS)
            Else
                syntaxError = True
                MyCompiler.ResultBlock.Items.Add("Parse Assignment Error " + nextToken.spelling)
            End If
        End If
        parse_expression()
    End Sub

    Private Sub parse_command()
        ' Parsing logic for <command>
        If nextToken.kind = Token.KEYWORDS Then
            If nextToken.spelling = "Print" Then
                acceptToken(Token.KEYWORDS)
                If nextToken.kind = Token.IDENTIFIERS Then
                    parse_identifier()
                ElseIf nextToken.kind = Token.INTEGERS Then
                    parse_integer()
                ElseIf nextToken.kind = Token.OPERATORS Then
                    ' Parsing logic for <message>
                    If nextToken.spelling = "<" Then
                        acceptToken(Token.OPERATORS)
                    Else
                        syntaxError = True
                        MyCompiler.ResultBlock.Items.Add("Parse Message Missing < Brackets Error " + nextToken.spelling)
                    End If
                    parse_message()
                    If nextToken.spelling = ">" Then
                        acceptToken(Token.OPERATORS)
                    Else
                        syntaxError = True
                        MyCompiler.ResultBlock.Items.Add("Parse Message Missing > Brackets Error " + nextToken.spelling)
                    End If
                End If
            Else
                syntaxError = True
                MyCompiler.ResultBlock.Items.Add("Parse Command Error " + nextToken.spelling)
            End If
        End If
    End Sub

    Private Sub parse_expression()
        Select Case nextToken.kind
            Case Token.IDENTIFIERS
                parse_identifier()
            Case Token.INTEGERS
                parse_integer()
            Case Token.OPERATORS, Token.BRACES, Token.SEPARATORS, Token.KEYWORDS, Token.LAST, Token.EOF, Token.SOF
                ' Do nothing
        End Select
    End Sub

    Private Sub parse_condition()
        ' Parsing logic for <condition>
        parse_expression()
        parse_comparison_operator()
        parse_expression()
    End Sub

    Private Sub parse_message()
        ' Check for { <letter> | <digit> }
        While nextToken.kind = Token.IDENTIFIERS
            acceptToken(nextToken.kind)
        End While
    End Sub

    Private Sub parse_comparison_operator()
        ' Parsing logic for <comparison_operator>
        If nextToken.kind = Token.OPERATORS Then
            If nextToken.spelling = "=" Or nextToken.spelling = "!" Or nextToken.spelling = "<" Or nextToken.spelling = ">" Then
                acceptToken(Token.OPERATORS)
                If nextToken.spelling = "=" Then
                    acceptToken(Token.OPERATORS)
                End If
            Else
                syntaxError = True
                MyCompiler.ResultBlock.Items.Add("Parse Comparison Operator Error " + nextToken.spelling)
            End If
        End If
    End Sub

    Private Sub parse_operator()
        ' Parsing logic for <arithmetic_operator>
        If nextToken.kind = Token.OPERATORS Then
            If nextToken.spelling = "+" Or nextToken.spelling = "-" Or nextToken.spelling = "*" Or nextToken.spelling = "/" Then
                acceptToken(Token.OPERATORS)
            Else
                syntaxError = True
                MyCompiler.ResultBlock.Items.Add("Parse Arithmetic Operator Error " + nextToken.spelling)
            End If
        End If
    End Sub

    Private Sub parse_type()
        ' Parsing logic for <type>
        If nextToken.kind = Token.KEYWORDS Then
            If nextToken.spelling = "Int" Then
                acceptToken(Token.KEYWORDS)
                'Debug.WriteLine("Type: " + nextToken.spelling)
            End If
        Else
            syntaxError = True
            MyCompiler.ResultBlock.Items.Add("Parse Type Error -" + nextToken.spelling)
        End If
    End Sub

    Private Sub parse_identifier()
        ' Parsing logic for <identifier>
        'Debug.WriteLine("Identifier: " + nextToken.spelling)
        If nextToken.kind = Token.IDENTIFIERS Then
            acceptToken(Token.IDENTIFIERS)
        Else
            syntaxError = True
            MyCompiler.ResultBlock.Items.Add("Parse Identifier Error " + nextToken.spelling)
        End If
    End Sub

    Private Sub parse_integer()
        ' Parsing logic for <integer>
        'Debug.WriteLine("Integer: " + nextToken.spelling)
        acceptToken(Token.INTEGERS)
    End Sub

    Private Sub parse_separators()
        ' Parsing logic for <separators>
        If nextToken.kind = Token.SEPARATORS Then
            acceptToken(Token.SEPARATORS)
        Else
            syntaxError = True
            Debug.WriteLine("Parse Separators Error " + nextToken.spelling)
            MyCompiler.ResultBlock.Items.Add("Parse Separators Error Missing ;")
        End If
    End Sub

End Class
