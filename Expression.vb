Public Class Expression
    Public word As String

    ' Function for SOF token
    Public Shared Function isSOF(ByRef c As String) As Boolean
        ' Check for SOF token
        If (c = "#Start") Then
            isSOF = True
        Else
            isSOF = False
        End If
    End Function

    ' Function for EOF token
    Public Shared Function isEOF(ByRef c As String) As Boolean
        ' Check for EOF token
        If (c = "#End") Then
            isEOF = True
        Else
            isEOF = False
        End If
    End Function

    ' Function to scan the current token if characters are valid, for identifiers and keywords pattern
    Public Shared Function isCharacter(ByRef c As Char) As Boolean
        ' Check for IDENTIFIERS token
        If (Asc(c) >= Asc("a") And Asc(c) <= Asc("z")) Or (Asc(c) >= Asc("A") And Asc(c) <= Asc("Z")) Then
            isCharacter = True
        Else
            isCharacter = False
        End If
    End Function

    ' Function to scan the current token with the number pattern
    Public Shared Function isDigit(ByRef c As Char) As Boolean
        ' Check for NUMBERS token
        If (Asc(c) >= Asc("0")) And (Asc(c) <= Asc("9")) Then
            isDigit = True
        Else
            isDigit = False
        End If
    End Function

    ' Function to scan the current token with the operator pattern
    Public Shared Function isOperator(ByRef c As Char) As Boolean
        ' Check for OPERATORS token
        If (c = "+" Or c = "-" Or c = "*" Or c = "/" Or c = "%" Or c = "=" Or c = ">" Or c = "<" Or c = "!") Then
            isOperator = True
        Else
            isOperator = False
        End If
    End Function

    ' Function to scan the current token with the separator pattern
    Public Shared Function isSeparator(ByRef c As Char) As Boolean
        ' Check for SEPARATORS token
        If (c = ";") Then
            isSeparator = True
        Else
            isSeparator = False
        End If
    End Function

    ' Function to scan the current token with the braces pattern
    Public Shared Function isBraces(ByRef c As Char) As Boolean
        ' Check for BRACES token
        If (c = "{" Or c = "}" Or c = "(" Or c = ")") Then
            isBraces = True
        Else
            isBraces = False
        End If
    End Function

    ' Function to scan the current token with the keyword pattern
    Public Shared Function isKeyword(ByRef keyword As String) As Boolean
        'Check for KEYWORDS token
        'Check first clause of first letter being capitalized
        If (Asc(keyword(0)) >= Asc("A") And Asc(keyword(0)) <= Asc("Z")) Then
            'Check for the whole spelling of the keyword now if it is a keyword Like If or Else
            If (keyword = "If" Or keyword = "Else" Or keyword = "Int" Or keyword = "Print") Then
                isKeyword = True
            Else
                isKeyword = False
            End If
        Else
            Return False
        End If
    End Function
End Class
