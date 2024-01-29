Imports System.Linq.Expressions
Imports System.Threading

Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtExpression.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnParse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParse.Click
        Dim result As cToken
        lstResults.Items.Clear()
        result = chkExpression()
        lstResults.Items.Add(result.kind & " " & result.spelling)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

    End Sub

    Function IsDigit(ByVal c As Char) As Boolean
        If (Asc(c) >= Asc("0")) And (Asc(c) <= Asc("9")) Then
            IsDigit = True
        Else
            IsDigit = False
        End If
    End Function

End Class
