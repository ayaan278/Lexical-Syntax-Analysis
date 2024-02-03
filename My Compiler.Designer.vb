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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        lexicalResultTable = New DataGridView()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(lexicalResultTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' exitButton
        ' 
        exitButton.AccessibleName = "exitButton"
        exitButton.BackColor = Color.Salmon
        exitButton.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exitButton.ForeColor = Color.GhostWhite
        exitButton.Location = New Point(25, 866)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(196, 60)
        exitButton.TabIndex = 1
        exitButton.Text = "Exit"
        exitButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(267, 629)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 25)
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
        ResultBlock.ItemHeight = 37
        ResultBlock.Location = New Point(682, 288)
        ResultBlock.Name = "ResultBlock"
        ResultBlock.Size = New Size(397, 337)
        ResultBlock.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Azure
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(25, 26)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(561, 208)
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
        analysisButton.Location = New Point(25, 488)
        analysisButton.Name = "analysisButton"
        analysisButton.Size = New Size(196, 67)
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
        syntaxButton.Location = New Point(25, 388)
        syntaxButton.Name = "syntaxButton"
        syntaxButton.Size = New Size(196, 65)
        syntaxButton.TabIndex = 0
        syntaxButton.Text = "Syntax Analysis"
        syntaxButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AccessibleName = "txtExpression"
        Label1.AutoSize = True
        Label1.Location = New Point(261, 258)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 25)
        Label1.TabIndex = 2
        Label1.Text = "Enter Code"
        ' 
        ' lexicalButton
        ' 
        lexicalButton.AccessibleName = "lexicalButton"
        lexicalButton.BackColor = Color.CornflowerBlue
        lexicalButton.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lexicalButton.ForeColor = Color.White
        lexicalButton.Location = New Point(25, 288)
        lexicalButton.Name = "lexicalButton"
        lexicalButton.Size = New Size(196, 63)
        lexicalButton.TabIndex = 4
        lexicalButton.Text = "Lexical Analysis"
        lexicalButton.UseVisualStyleBackColor = False
        ' 
        ' CodeBlock
        ' 
        CodeBlock.AccessibleName = "codeBlock"
        CodeBlock.BackColor = Color.AliceBlue
        CodeBlock.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CodeBlock.Location = New Point(267, 288)
        CodeBlock.Margin = New Padding(4, 5, 4, 5)
        CodeBlock.Multiline = True
        CodeBlock.Name = "CodeBlock"
        CodeBlock.Size = New Size(408, 334)
        CodeBlock.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Azure
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(594, 26)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(5)
        Label3.Size = New Size(489, 208)
        Label3.TabIndex = 11
        Label3.Text = "TCP2451- Programming Language Translation" & vbCrLf & vbCrLf & "Name - Ahmad Ayaan " & vbCrLf & "StudentID - 1191302794" & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' lexicalResultTable
        ' 
        lexicalResultTable.AllowUserToAddRows = False
        lexicalResultTable.AllowUserToDeleteRows = False
        lexicalResultTable.BackgroundColor = Color.LightSkyBlue
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkBlue
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        lexicalResultTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        lexicalResultTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        lexicalResultTable.DefaultCellStyle = DataGridViewCellStyle2
        lexicalResultTable.GridColor = SystemColors.WindowText
        lexicalResultTable.Location = New Point(267, 657)
        lexicalResultTable.Name = "lexicalResultTable"
        lexicalResultTable.ReadOnly = True
        lexicalResultTable.RowHeadersWidth = 62
        lexicalResultTable.Size = New Size(812, 269)
        lexicalResultTable.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(682, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 13
        Label4.Text = "Syntax Result"
        ' 
        ' MyCompiler
        ' 
        AccessibleName = "PLTAssignment"
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1127, 959)
        Controls.Add(Label4)
        Controls.Add(lexicalResultTable)
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
        Name = "MyCompiler"
        Text = "Mini Project Compiler"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(lexicalResultTable, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lexicalResultTable As DataGridView
    Friend WithEvents Label4 As Label

End Class
