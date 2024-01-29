<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnParse = New Button()
        btnExit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button3 = New Button()
        lstResults = New ListBox()
        txtExpression = New TextBox()
        SuspendLayout()
        ' 
        ' btnParse
        ' 
        btnParse.AccessibleName = "btnParse"
        btnParse.Location = New Point(183, 347)
        btnParse.Name = "btnParse"
        btnParse.Size = New Size(111, 52)
        btnParse.TabIndex = 0
        btnParse.Text = "Parse"
        btnParse.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.AccessibleName = "btnExit"
        btnExit.Location = New Point(551, 347)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(111, 52)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AccessibleName = "txtExpression"
        Label1.AutoSize = True
        Label1.Location = New Point(34, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 25)
        Label1.TabIndex = 2
        Label1.Text = "Enter Expression"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 25)
        Label2.TabIndex = 3
        Label2.Text = "Results"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(366, 347)
        Button3.Name = "Button3"
        Button3.Size = New Size(111, 52)
        Button3.TabIndex = 4
        Button3.Text = "Evaluate"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' lstResults
        ' 
        lstResults.AccessibleName = "lstResults"
        lstResults.FormattingEnabled = True
        lstResults.ItemHeight = 25
        lstResults.Location = New Point(183, 173)
        lstResults.Name = "lstResults"
        lstResults.Size = New Size(481, 129)
        lstResults.TabIndex = 5
        ' 
        ' txtExpression
        ' 
        txtExpression.AccessibleName = "txtExpression"
        txtExpression.Font = New Font("Segoe UI", 12.0F)
        txtExpression.Location = New Point(183, 38)
        txtExpression.Name = "txtExpression"
        txtExpression.Size = New Size(481, 39)
        txtExpression.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtExpression)
        Controls.Add(lstResults)
        Controls.Add(Button3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnParse)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnParse As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents txtExpression As TextBox

End Class
