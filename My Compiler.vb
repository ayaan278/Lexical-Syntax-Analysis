Imports System.Linq.Expressions
Imports System.Threading

Public Class MyCompiler
    'The Form will be used to create the GUI for the application.
    Private Sub MyCompiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1_TextChanged(sender, e)

        ' Add columns to the DataGridView
        LexicalResultTable.Columns.Add("Kind", "Kind")
        LexicalResultTable.Columns.Add("KindType", "Kind Type")
        LexicalResultTable.Columns.Add("Token", "Token")
        LexicalResultTable.Columns.Add("Validity", "Validity")

        ' Set the column widths
        LexicalResultTable.Columns(0).Width = 50
        LexicalResultTable.Columns(1).Width = 150
        LexicalResultTable.Columns(2).Width = 150
        LexicalResultTable.Columns(3).Width = 100

        'Disable the leftmost filter rows buttons
        LexicalResultTable.RowHeadersVisible = False


        ' Disable the maximize button
        Me.MaximizeBox = False

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
        LexicalResultTable.Rows.Clear()

        'Scan the tokens and add them to the table
        currentToken = scanner.scan


        While currentToken.kind <> Token.LAST
            'Create a new row only if the token is not the last token
            If Token.LAST Then
                ' Create a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()

                ' Create cells for each column and set their values
                Dim kindCell As New DataGridViewTextBoxCell()
                kindCell.Value = currentToken.kind

                Dim kindTypeCell As New DataGridViewTextBoxCell()
                kindTypeCell.Value = currentToken.GetKindType()

                Dim spellingCell As New DataGridViewTextBoxCell()
                spellingCell.Value = currentToken.spelling

                Dim isValidCell As New DataGridViewTextBoxCell()
                isValidCell.Value = currentToken.isValid()

                ' Add cells to the row in the correct order
                newRow.Cells.Add(kindCell)
                newRow.Cells.Add(kindTypeCell)
                newRow.Cells.Add(spellingCell)
                newRow.Cells.Add(isValidCell)

                ' Add the new row to the DataGridView
                LexicalResultTable.Rows.Add(newRow)

                ' Refresh the DataGridView to update the display
                LexicalResultTable.Refresh()
            End If
            currentToken = scanner.scan


        End While

    End Sub
    '-----------------------------------------------------------------------------------------------------------

    'The Syntax Analysis button will be used to perform the syntax analysis of the code entered in the text box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub syntaxAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles syntaxButton.Click
        Dim syntaxError As Boolean = False
        Dim scanner As Scanner = New Scanner
        Dim parser As Parser = New Parser

        'Clear the Result block before adding new tokens
        ResultBlock.Items.Clear()

        'Parse the program
        parser.nextToken = scanner.scan
        parser.parse_program()

        'Check for syntax error
        If syntaxError Then
            ResultBlock.Items.Add("Syntax Error!")
        Else
            ResultBlock.Items.Add("Syntax Correct!")
        End If


    End Sub
    '-----------------------------------------------------------------------------------------------------------

    'The Analysis button will be used to perform the lexical and syntax analysis of the code entered in the text box.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub analysisButton_Click(sender As Object, e As EventArgs) Handles analysisButton.Click
        'Clear the table before adding new tokens
        LexicalResultTable.Rows.Clear()
        'Clear the Result block before adding new tokens
        ResultBlock.Items.Clear()

        lexicalAnalysis_Click(sender, e)
        syntaxAnalysis_Click(sender, e)
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


    'The Lexical Result table will be used to display the results of the lexical analysis.
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LexicalResultTable.CellContentClick

    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'The Code blocks after this are for label that will be used to display the labels in the application.
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    '-----------------------------------------------------------------------------------------------------------
End Class
'-End of the MyCompiler.vb file