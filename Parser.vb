Imports Microsoft.VisualBasic

Public Class Parser
    Public nextToken As Token
    Dim scanner As Scanner = New Scanner
    Public sofFound As Boolean = False
    Public eofFound As Boolean = False
    Public lineError As Boolean = False

    Private Sub acceptToken(ByVal k As Integer)
        If nextToken.kind = k Then
            Debug.WriteLine("Scanning Token: " & nextToken.spelling & " - " & nextToken.GetKindType())
            nextToken = scanner.scan
        Else
            syntaxError = True
            'Debug.WriteLine("Parse Accept Token Error " + nextToken.spelling + nextToken.GetKindType)
            MyCompiler.ResultBlock.Items.Add("Parse Accept Token Error " + nextToken.spelling)
        End If
    End Sub

    ' The syntaxError variable will be used to check if there is a syntax error in the program.
    ' The function ResetSyntaxError will be used to reset the syntaxError variable.
    Public Sub ResetSyntaxError()
        syntaxError = False

    End Sub

    ' The start_parse function will be used to start the parsing process.
    Public Sub start_parse()
        nextToken = scanner.scan()

        ' Parse the whole program
        While nextToken.kind <> Token.LAST
            parse_program()
        End While

    End Sub

    'The parse_program function will be used to parse the whole program.
    Public Sub parse_program()
        ' Parsing logic for <program>
        ' Check for "#Start"
        If nextToken.kind = Token.SOF And sofFound = False Then
            parse_start()
        Else
            syntaxError = True
            MyCompiler.ResultBlock.Items.Add("Parse Program Error Missing #Start")
            peekToken()
        End If
        Select Case nextToken.kind
            Case Token.SOF
                parse_start()
            Case Token.INTEGERS, Token.IDENTIFIERS, Token.BRACES, Token.SEPARATORS, Token.OPERATORS, Token.KEYWORDS
                parse_statement_list()
            Case Token.EOF
            Case Token.LAST
                ' Do nothing
            Case Else
                syntaxError = True
                MyCompiler.ResultBlock.Items.Add("Parse Program Error " + nextToken.spelling)
        End Select
        ' Check for "#End"
        If nextToken.kind = Token.EOF And eofFound = False Then
            parse_end()
            Return
        Else
            syntaxError = True
            MyCompiler.ResultBlock.Items.Add("Parse Program Error Missing #End")
        End If
    End Sub

    Private Sub parse_start()
        ' Parsing logic for "#Start"
        If sofFound = False Then
            acceptToken(Token.SOF)
            sofFound = True
        Else
            syntaxError = True
            MyCompiler.ResultBlock.Items.Add("Parse Start Error Already found #Start")
        End If

    End Sub
    Private Sub parse_end()
        ' Parsing logic for "#End"
        If eofFound = False Then
            acceptToken(Token.EOF)
            eofFound = True
        Else
            syntaxError = True
            MyCompiler.ResultBlock.Items.Add("Parse End Error Already Found #End")
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
        'TODO: Prevent them from breaking and freezing screen
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
            Debug.WriteLine("Parse If Statement Error " + nextToken.spelling)
            MyCompiler.ResultBlock.Items.Add("Parse Error in IF Block" + nextToken.spelling)
        End If

        parse_else_statement()

        peekToken()
    End Sub

    Private Sub parse_else_statement()
        ' Check for "Else"
        If nextToken.spelling = "Else" Then
            ' Accept the "Else" keyword
            acceptToken(Token.KEYWORDS)

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
        End If
    End Sub

    Private Sub parse_declaration()
        ' Parsing logic for <declaration>
        parse_type()
        parse_identifier()
        peekToken()
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
                Debug.WriteLine("Parse Assignment Error " + nextToken.spelling)
                MyCompiler.ResultBlock.Items.Add("Parse Assignment Error Expected  =  found " + nextToken.spelling)
            End If
        Else
            syntaxError = True
            Debug.WriteLine("Parse Assignment Error " + nextToken.spelling)
            MyCompiler.ResultBlock.Items.Add("Parse Assignment Error Expected  =  found " + nextToken.spelling)
        End If
        parse_expression()
        peekToken()
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
                ElseIf nextToken.kind = Token.BRACES Then
                    ' Parsing logic for <message>
                    If nextToken.spelling = "(" Then
                        acceptToken(Token.BRACES)
                    Else
                        syntaxError = True
                        MyCompiler.ResultBlock.Items.Add("Parse Message Missing ( Brackets Error " + nextToken.spelling)
                    End If
                    parse_message()
                    If nextToken.spelling = ")" Then
                        acceptToken(Token.BRACES)
                    Else
                        syntaxError = True
                        MyCompiler.ResultBlock.Items.Add("Parse Message Missing ) Brackets Error " + nextToken.spelling)
                    End If
                Else
                    syntaxError = True
                    MyCompiler.ResultBlock.Items.Add("Parse Command Error Nothing to Print")

                End If
            Else
                syntaxError = True
                MyCompiler.ResultBlock.Items.Add("Parse Command Error " + nextToken.spelling)
            End If
        End If
        peekToken()
    End Sub

    Private Sub parse_expression()
        Select Case nextToken.kind
            Case Token.IDENTIFIERS
                parse_identifier()
            Case Token.INTEGERS
                parse_integer()
            Case Token.OPERATORS

            Case Token.BRACES, Token.SEPARATORS, Token.KEYWORDS, Token.LAST, Token.EOF, Token.SOF
                ' Do nothing
        End Select
        If nextToken.kind = Token.OPERATORS And nextToken.spelling = "+" Or nextToken.spelling = "-" Or nextToken.spelling = "*" Or nextToken.spelling = "/" Or nextToken.spelling = "%" Then
            parse_calculation()
        End If
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
        While nextToken.kind = Token.INTEGERS
            acceptToken(nextToken.kind)
        End While

    End Sub

    Private Sub parse_comparison_operator()
        ' Parsing logic for <comparison_operator>
        If nextToken.kind = Token.OPERATORS Then
            If nextToken.spelling = "=" Or nextToken.spelling = "!" Then
                acceptToken(Token.OPERATORS)
                If nextToken.spelling = "=" Then
                    acceptToken(Token.OPERATORS)
                Else
                    syntaxError = True
                    Debug.WriteLine("Parse Comparison Operator Error Expected  =  got " + nextToken.spelling)
                    MyCompiler.ResultBlock.Items.Add("Parse Comparison Operator Error Expected  =  got " + nextToken.spelling)
                End If
            ElseIf nextToken.spelling = "<" Or nextToken.spelling = ">" Then
                acceptToken(Token.OPERATORS)
                If nextToken.spelling = "=" Then
                    acceptToken(Token.OPERATORS)
                ElseIf nextToken.spelling = "<" Or nextToken.spelling = ">" Then
                    syntaxError = True
                    Debug.WriteLine("Parse Comparison Operator Error " + nextToken.spelling)
                    MyCompiler.ResultBlock.Items.Add("Parse Comparison Operator Error " + nextToken.spelling)
                Else
                    ' Do nothing
                End If
            Else
                syntaxError = True
                MyCompiler.ResultBlock.Items.Add("Parse Comparison Operator Error " + nextToken.spelling)
            End If
        End If
    End Sub

    Private Sub parse_calculation()
        parse_operator()
        If nextToken.kind = Token.IDENTIFIERS Or nextToken.kind = Token.INTEGERS Then
            parse_expression()
        Else
            syntaxError = True
            Debug.WriteLine("Parse Calculation Error " + nextToken.spelling)
            MyCompiler.ResultBlock.Items.Add("Parse Calculation Error Missing Identifiers or Integers")
        End If
    End Sub

    Private Sub parse_operator()
        ' Parsing logic for <arithmetic_operator>
        If nextToken.kind = Token.OPERATORS Then
            If nextToken.spelling = "+" Or nextToken.spelling = "-" Or nextToken.spelling = "*" Or nextToken.spelling = "/" Or nextToken.spelling = "%" Then
                acceptToken(Token.OPERATORS)
            ElseIf nextToken.spelling = "=" Or nextToken.spelling = ">" Or nextToken.spelling = "<" Or nextToken.spelling = "!" Then
                parse_comparison_operator()
            Else
                syntaxError = True
                Debug.WriteLine("Parse Operator Error Wrong Operator for Calculation " + nextToken.spelling)
                MyCompiler.ResultBlock.Items.Add("Parse Operator Error Wrong Operator for Calculation " + nextToken.spelling)
            End If
        End If
    End Sub

    Private Sub parse_type()
        ' Parsing logic for <type>
        'Debug.WriteLine("Type: " + nextToken.spelling)
        acceptToken(Token.KEYWORDS)
    End Sub

    Private Sub parse_identifier()
        ' Parsing logic for <identifier>
        'Debug.WriteLine("Identifier: " + nextToken.spelling)
        If nextToken.kind = Token.IDENTIFIERS Then
            acceptToken(Token.IDENTIFIERS)
        Else
            syntaxError = True
            Debug.WriteLine("Parse Identifier Error " + nextToken.spelling)
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

    Private Sub peekToken()
        ' Check for next element if it is semi colon then okay otherwise skip next token with errors
        While nextToken.kind <> Token.SEPARATORS
            syntaxError = True
            Debug.WriteLine("Parse Peek Error " + nextToken.spelling)
            If lineError = False Then
                lineError = True
                Debug.WriteLine("Parse Peek Error " + nextToken.spelling)
                MyCompiler.ResultBlock.Items.Add("Parse Peek Error Next to the token " + nextToken.spelling)
            End If

            ' Skip the next token
            nextToken = scanner.scan
            If nextToken.kind = Token.SEPARATORS Then
                Return
            End If

            'Check if it is end of file then break out of the loop and whole program
            If nextToken.kind = Token.LAST Then
                Return
            End If
        End While
        lineError = False
    End Sub

End Class
