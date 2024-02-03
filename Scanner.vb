Imports Microsoft.VisualBasic

Public Class Scanner
    Private currentChar As Char
    Private currentIndex As Integer = 0
    Private currentKind As Integer
    Private currentSpelling As String

    ' Constructor to initialize the scanner with the code block text
    Public Sub New()
        If MyCompiler.CodeBlock.Text.Length > 0 Then
            currentChar = MyCompiler.CodeBlock.Text(0)
        Else
            currentChar = ChrW(0)
        End If
    End Sub

    ' Function to take the current character and add it to the current spelling
    Private Sub takeIt()
        currentSpelling &= currentChar
        currentIndex += 1

        If currentIndex < MyCompiler.CodeBlock.Text.Length Then
            currentChar = MyCompiler.CodeBlock.Text(currentIndex)
        Else
            currentChar = ""
        End If
    End Sub

    ' Function to scan the current character and return the token
    Public Function scan() As Token
        ' Ignore white spaces and take the next character
        While Char.IsWhiteSpace(currentChar)
            takeIt()
        End While

        currentSpelling = ""
        currentKind = scanToken()
        Dim token As New Token(currentKind, currentSpelling)

        ' Display the token in ResultBlock
        ' MyCompiler.ResultBlock.Text &= token.ToString() & Environment.NewLine

        Return token
    End Function

    ' Function to scan the current token and return the token
    Private Function scanToken() As Integer
        'Check for SOF (Start of File) token and (End of File) token 
        If currentChar = "#" Then
            takeIt()
            While Expression.isCharacter(currentChar)
                takeIt()
            End While
            If Expression.isSOF(currentSpelling) Then
                takeIt()
                Return Token.SOF
            ElseIf Expression.isEOF(currentSpelling) Then
                takeIt()
                Return Token.EOF
            End If

            ' Return UNKNOWN for any other characters
            While Char.IsLetterOrDigit(currentChar)
                takeIt()
            End While
            Return Token.UNKNOWN
        End If

        ' Check for separators
        If Expression.isSeparator(currentChar) Then
            takeIt()
            Return Token.SEPARATORS
        End If

        ' Check for identifiers and keywords using regular expression class
        If Expression.isCharacter(currentChar) Then
            takeIt()
            While Expression.isCharacter(currentChar) Or Expression.isDigit(currentChar)
                takeIt()
            End While
            If Expression.isKeyword(currentSpelling) Then
                Return Token.KEYWORDS
            End If
            Return Token.IDENTIFIERS
        End If

        ' Check for integers using regular expression class
        If Expression.isDigit(currentChar) Then
            takeIt()
            While Expression.isDigit(currentChar)
                takeIt()
            End While
            Return Token.INTEGERS
        End If

        ' Check for operators
        If Expression.isOperator(currentChar) Then
            takeIt()
            Return Token.OPERATORS
        End If

        ' Check for braces
        If Expression.isBraces(currentChar) Then
            takeIt()
            Return Token.BRACES
        End If

        ' Check LAST Token
        If currentIndex = MyCompiler.CodeBlock.Text.Length Then
            takeIt()
            Return Token.LAST
        End If

        ' Return UNKNOWN for any other characters
        takeIt()
        Return Token.UNKNOWN

    End Function
End Class
