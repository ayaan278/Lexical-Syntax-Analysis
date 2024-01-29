Imports System.Linq.Expressions
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    'The Code block will be used to enter the code to be analyzed.
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'The Lexical Analysis button will be used to perform the lexical analysis of the code entered in the text box.
    Private Sub lexicalAnalysis_Click(sender As Object, e As EventArgs) Handles lexicalButton.Click

    End Sub
    '-----------------------------------------------------------------------------------------------------------

    'The Syntax Analysis button will be used to perform the syntax analysis of the code entered in the text box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub syntaxAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles syntaxButton.Click
        Dim i As Integer
        Dim current As Char
        Dim operand1, operand2 As String
        Dim oper As Char

        i = 0
        operand1 = ""
        operand2 = ""
        ResultBlock.Items.Clear()

        current = CodeBlock.Text(i)
        While IsDigit(current) And i < CodeBlock.Text.Length
            operand1 &= current
            i += 1
            current = CodeBlock.Text(i)
        End While

        ' skip space
        i += 1
        current = CodeBlock.Text(i)

        oper = current
        i += 1

        ' skip space
        i += 1
        current = CodeBlock.Text(i)

        While IsDigit(current) And i < CodeBlock.Text.Length
            operand2 &= current
            i += 1
            If i < CodeBlock.Text.Length Then
                current = CodeBlock.Text(i)
            End If
        End While
        ResultBlock.Items.Add("operand1:" & operand1)
        ResultBlock.Items.Add("operator:" & oper)
        ResultBlock.Items.Add("operand2:" & operand2)
    End Sub
    '-----------------------------------------------------------------------------------------------------------

    'The Analysis button will be used to perform the lexical and syntax analysis of the code entered in the text box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub analysisButton_Click(sender As Object, e As EventArgs) Handles analysisButton.Click

    End Sub
    '-----------------------------------------------------------------------------------------------------------

    'The Exit button will be used to exit the application.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub
    '-----------------------------------------------------------------------------------------------------------

    'The Result block will be used to display the results of the lexical and syntax analysis.
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ResultBlock.SelectedIndexChanged

    End Sub

    'The IsDigit function will be used to determine if a character is a digit.
    Function IsDigit(ByVal c As Char) As Boolean
        If (Asc(c) >= Asc("0")) And (Asc(c) <= Asc("9")) Then
            IsDigit = True
        Else
            IsDigit = False
        End If
    End Function


End Class
