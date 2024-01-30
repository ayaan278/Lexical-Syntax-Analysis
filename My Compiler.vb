Imports System.Linq.Expressions
Imports System.Threading

Public Class MyCompiler
    Private Sub MyCompiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1_TextChanged(sender, e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    'The Code block will be used to enter the code to be analyzed.
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CodeBlock.TextChanged
        'Check if CodeBlock is empty
        If CodeBlock.Text.Length = 0 Then
            lexicalButton.Enabled = False
            syntaxButton.Enabled = False
            analysisButton.Enabled = False
        Else
            lexicalButton.Enabled = True
            syntaxButton.Enabled = True
            analysisButton.Enabled = True
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'The Lexical Analysis button will be used to perform the lexical analysis of the code entered in the text box.
    Private Sub lexicalAnalysis_Click(sender As Object, e As EventArgs) Handles lexicalButton.Click
        Dim scanner As Scanner = New Scanner
        Dim currentToken As Token

        ResultBlock.Items.Clear()

        currentToken = scanner.scan
        While currentToken.kind <> Token.EOF
            ResultBlock.Items.Add(currentToken.ToString)
            currentToken = scanner.scan
        End While

    End Sub
    '-----------------------------------------------------------------------------------------------------------

    'The Syntax Analysis button will be used to perform the syntax analysis of the code entered in the text box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub syntaxAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles syntaxButton.Click

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
End Class
