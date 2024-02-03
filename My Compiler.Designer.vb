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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        LexicalResultTable = New DataGridView()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(LexicalResultTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' exitButton
        ' 
        exitButton.AccessibleName = "exitButton"
        exitButton.BackColor = Color.Salmon
        exitButton.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exitButton.ForeColor = Color.GhostWhite
        exitButton.Location = New Point(18, 518)
        exitButton.Margin = New Padding(2)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(140, 40)
        exitButton.TabIndex = 1
        exitButton.Text = "Exit"
        exitButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(482, 155)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 15)
        Label2.TabIndex = 3
        Label2.Text = "Lexical Result"
        ' 
        ' ResultBlock
        ' 
        ResultBlock.AccessibleName = "resultBlock"
        ResultBlock.BackColor = Color.LightSkyBlue
        ResultBlock.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ResultBlock.ForeColor = Color.White
        ResultBlock.FormattingEnabled = True
        ResultBlock.ItemHeight = 24
        ResultBlock.Location = New Point(482, 384)
        ResultBlock.Margin = New Padding(2)
        ResultBlock.Name = "ResultBlock"
        ResultBlock.Size = New Size(456, 172)
        ResultBlock.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveCaptionText
        PictureBox1.BackgroundImage = My.Resources.Resources.Banner
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(-4, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(960, 146)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
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
        analysisButton.Location = New Point(18, 293)
        analysisButton.Margin = New Padding(2)
        analysisButton.Name = "analysisButton"
        analysisButton.Size = New Size(140, 40)
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
        syntaxButton.Location = New Point(18, 233)
        syntaxButton.Margin = New Padding(2)
        syntaxButton.Name = "syntaxButton"
        syntaxButton.Size = New Size(140, 40)
        syntaxButton.TabIndex = 0
        syntaxButton.Text = "Syntax Analysis"
        syntaxButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AccessibleName = "txtExpression"
        Label1.AutoSize = True
        Label1.Location = New Point(178, 155)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 2
        Label1.Text = "Enter Code"
        ' 
        ' lexicalButton
        ' 
        lexicalButton.AccessibleName = "lexicalButton"
        lexicalButton.BackColor = Color.CornflowerBlue
        lexicalButton.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lexicalButton.ForeColor = Color.White
        lexicalButton.Location = New Point(18, 173)
        lexicalButton.Margin = New Padding(2)
        lexicalButton.Name = "lexicalButton"
        lexicalButton.Size = New Size(140, 40)
        lexicalButton.TabIndex = 4
        lexicalButton.Text = "Lexical Analysis"
        lexicalButton.UseVisualStyleBackColor = False
        ' 
        ' CodeBlock
        ' 
        CodeBlock.AccessibleName = "codeBlock"
        CodeBlock.BackColor = Color.AliceBlue
        CodeBlock.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CodeBlock.Location = New Point(178, 173)
        CodeBlock.Multiline = True
        CodeBlock.Name = "CodeBlock"
        CodeBlock.ScrollBars = ScrollBars.Both
        CodeBlock.Size = New Size(296, 383)
        CodeBlock.TabIndex = 10
        ' 
        ' LexicalResultTable
        ' 
        LexicalResultTable.AllowUserToAddRows = False
        LexicalResultTable.AllowUserToDeleteRows = False
        LexicalResultTable.BackgroundColor = Color.LightSkyBlue
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.DarkBlue
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        LexicalResultTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        LexicalResultTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        LexicalResultTable.DefaultCellStyle = DataGridViewCellStyle4
        LexicalResultTable.GridColor = SystemColors.WindowText
        LexicalResultTable.Location = New Point(482, 172)
        LexicalResultTable.Margin = New Padding(2)
        LexicalResultTable.Name = "LexicalResultTable"
        LexicalResultTable.ReadOnly = True
        LexicalResultTable.RowHeadersWidth = 62
        LexicalResultTable.Size = New Size(456, 193)
        LexicalResultTable.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(483, 367)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 13
        Label4.Text = "Syntax Result"
        ' 
        ' MyCompiler
        ' 
        AccessibleName = "PLTAssignment"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(949, 573)
        Controls.Add(Label4)
        Controls.Add(LexicalResultTable)
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
        MaximizeBox = False
        Name = "MyCompiler"
        Text = "Mini Project Compiler"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(LexicalResultTable, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LexicalResultTable As DataGridView
    Friend WithEvents Label4 As Label

End Class
