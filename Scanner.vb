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
        MyCompiler.ResultBlock.Text &= token.ToString() & Environment.NewLine

        Return token
    End Function

    ' Function to scan the current token and return the token
    Private Function scanToken() As Integer
        'Check for SOF (Start of File) token 
        If currentChar = "#" Then
            takeIt()
            If currentChar = "S" Then
                takeIt()
                If currentChar = "t" Then
                    takeIt()
                    If currentChar = "a" Then
                        takeIt()
                        If currentChar = "r" Then
                            takeIt()
                            If currentChar = "t" Then
                                takeIt()
                                Return Token.SOF
                            End If
                        End If
                    End If
                End If
            End If
        End If

        ' Check for separators
        If currentChar = ";" Then
            takeIt()
            Return Token.SEPARATORS
        End If

        ' Check for identidiers
        If Char.IsLetter(currentChar) Then
            takeIt()
            While Char.IsLetterOrDigit(currentChar)
                takeIt()
            End While
            'TODO: 
            ' Call the scanIdentifier function from 

        End If

        ' Check for integers
        If Char.IsDigit(currentChar) Then
            takeIt()
            While Char.IsDigit(currentChar)
                takeIt()
            End While
            Return Token.INTEGERS
        End If

        ' Check for operators
        If currentChar = "+" Or currentChar = "-" Or currentChar = "*" Or currentChar = "=" Or currentChar = "/" Then
            takeIt()
            Return Token.OPERATORS
        End If

        ' Check for keywords
        If currentChar = "i" Then
            takeIt()
            If currentChar = "f" Then
                takeIt()
                Return Token.KEYWORDS
            End If
        End If

        ' Check for EOF
        If currentIndex = MyCompiler.CodeBlock.Text.Length Then
            takeIt()
            Return Token.EOF
        End If

        ' Return UNKNOWN for any other characters
        takeIt()
        Return Token.UNKNOWN

    End Function
End Class
