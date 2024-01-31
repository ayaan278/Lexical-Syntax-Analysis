<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyCompiler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyCompiler))
        exitButton = New Button()
        Label2 = New Label()
        ResultBlock = New ListBox()
        HelpProvider1 = New HelpProvider()
        PictureBox1 = New PictureBox()
        analysisButton = New Button()
        syntaxButton = New Button()
        Label1 = New Label()
        lexicalButton = New Button()
        CodeBlock = New TextBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' exitButton
        ' 
        exitButton.AccessibleName = "exitButton"
        exitButton.BackColor = Color.Salmon
        exitButton.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exitButton.ForeColor = Color.GhostWhite
        exitButton.Location = New Point(11, 497)
        exitButton.Margin = New Padding(2)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(137, 36)
        exitButton.TabIndex = 1
        exitButton.Text = "Exit"
        exitButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(183, 368)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 3
        Label2.Text = "Results"
        ' 
        ' ResultBlock
        ' 
        ResultBlock.AccessibleName = "resultBlock"
        ResultBlock.BackColor = Color.SlateGray
        ResultBlock.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ResultBlock.ForeColor = Color.White
        ResultBlock.FormattingEnabled = True
        ResultBlock.ItemHeight = 24
        ResultBlock.Location = New Point(183, 385)
        ResultBlock.Margin = New Padding(2)
        ResultBlock.Name = "ResultBlock"
        ResultBlock.Size = New Size(338, 148)
        ResultBlock.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(101, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(313, 130)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' analysisButton
        ' 
        analysisButton.AccessibleName = "analysisButton"
        analysisButton.BackColor = Color.MidnightBlue
        analysisButton.FlatStyle = FlatStyle.Flat
        analysisButton.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        analysisButton.ForeColor = Color.White
        analysisButton.Location = New Point(11, 316)
        analysisButton.Margin = New Padding(2)
        analysisButton.Name = "analysisButton"
        analysisButton.Size = New Size(137, 40)
        analysisButton.TabIndex = 9
        analysisButton.Text = "Final Analysis"
        analysisButton.UseVisualStyleBackColor = False
        ' 
        ' syntaxButton
        ' 
        syntaxButton.AccessibleName = "syntaxButton"
        syntaxButton.BackColor = Color.CornflowerBlue
        syntaxButton.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        syntaxButton.ForeColor = Color.White
        syntaxButton.Location = New Point(11, 257)
        syntaxButton.Margin = New Padding(2)
        syntaxButton.Name = "syntaxButton"
        syntaxButton.Size = New Size(137, 39)
        syntaxButton.TabIndex = 0
        syntaxButton.Text = "Syntax Analysis"
        syntaxButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AccessibleName = "txtExpression"
        Label1.AutoSize = True
        Label1.Location = New Point(183, 166)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 15)
        Label1.TabIndex = 2
        Label1.Text = "Enter Expression"
        ' 
        ' lexicalButton
        ' 
        lexicalButton.AccessibleName = "lexicalButton"
        lexicalButton.BackColor = Color.CornflowerBlue
        lexicalButton.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lexicalButton.ForeColor = Color.White
        lexicalButton.Location = New Point(11, 199)
        lexicalButton.Margin = New Padding(2)
        lexicalButton.Name = "lexicalButton"
        lexicalButton.Size = New Size(137, 38)
        lexicalButton.TabIndex = 4
        lexicalButton.Text = "Lexical Analysis"
        lexicalButton.UseVisualStyleBackColor = False
        ' 
        ' CodeBlock
        ' 
        CodeBlock.AccessibleName = "codeBlock"
        CodeBlock.BackColor = Color.AliceBlue
        CodeBlock.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CodeBlock.Location = New Point(183, 184)
        CodeBlock.Multiline = True
        CodeBlock.Name = "CodeBlock"
        CodeBlock.Size = New Size(337, 164)
        CodeBlock.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LightSkyBlue
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(152, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 20)
        Label3.TabIndex = 11
        Label3.Text = "Ahmad Ayaan - 1191302794" & vbCrLf
        ' 
        ' MyCompiler
        ' 
        AccessibleName = "PLTAssignment"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(532, 554)
        Controls.Add(Label3)
        Controls.Add(CodeBlock)
        Controls.Add(analysisButton)
        Controls.Add(PictureBox1)
        Controls.Add(ResultBlock)
        Controls.Add(lexicalButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(exitButton)
        Controls.Add(syntaxButton)
        Margin = New Padding(2)
        Name = "MyCompiler"
        Text = "Mini Project Compiler"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents exitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ResultBlock As ListBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents analysisButton As Button
    Friend WithEvents syntaxButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lexicalButton As Button
    Friend WithEvents CodeBlock As TextBox
    Friend WithEvents Label3 As Label

End Class
