Imports System.Linq.Expressions
Imports System.Threading

Public Class MyCompiler
    'The Form will be used to create the GUI for the application.
    Private Sub MyCompiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1_TextChanged(sender, e)
        lexicalResultTable.Columns.Add("Kind", "Kind")
        lexicalResultTable.Columns.Add("KindType", "Kind Type")
        lexicalResultTable.Columns.Add("Spelling", "Spelling")
        lexicalResultTable.Columns.Add("Validity", "Validity")
        ' Disable the maximize button
        Me.MaximizeBox = False
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
    '-----------------------------------------------------------------------------------------------------------
    Private Sub lexicalAnalysis_Click(sender As Object, e As EventArgs) Handles lexicalButton.Click
        Dim scanner As Scanner = New Scanner
        Dim currentToken As Token

        'Clear the table before adding new tokens
        lexicalResultTable.Rows.Clear()

        'Scan the tokens and add them to the table
        currentToken = scanner.scan
        While currentToken.kind <> Token.LAST
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lexicalResultTable.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
