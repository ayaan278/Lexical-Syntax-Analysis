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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnExit = New Button()
        Label2 = New Label()
        ResultBlock = New ListBox()
        HelpProvider1 = New HelpProvider()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        btnParse = New Button()
        Label1 = New Label()
        Button3 = New Button()
        CodeBlock = New ListBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.AccessibleName = "btnExit"
        btnExit.BackColor = Color.Salmon
        btnExit.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.GhostWhite
        btnExit.Location = New Point(11, 497)
        btnExit.Margin = New Padding(2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(137, 36)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
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
        PictureBox1.Location = New Point(102, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(313, 130)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.AccessibleName = "btnParse"
        Button1.BackColor = Color.MidnightBlue
        Button1.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(11, 316)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 41)
        Button1.TabIndex = 9
        Button1.Text = "Final Analysis"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnParse
        ' 
        btnParse.AccessibleName = "btnParse"
        btnParse.BackColor = Color.CornflowerBlue
        btnParse.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnParse.ForeColor = Color.White
        btnParse.Location = New Point(11, 257)
        btnParse.Margin = New Padding(2)
        btnParse.Name = "btnParse"
        btnParse.Size = New Size(137, 39)
        btnParse.TabIndex = 0
        btnParse.Text = "Syntax Analysis"
        btnParse.UseVisualStyleBackColor = False
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
        ' Button3
        ' 
        Button3.BackColor = Color.CornflowerBlue
        Button3.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(11, 199)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(137, 38)
        Button3.TabIndex = 4
        Button3.Text = "Lexical Analysis"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' CodeBlock
        ' 
        CodeBlock.AccessibleName = "codeBlock"
        CodeBlock.BackColor = Color.AliceBlue
        CodeBlock.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CodeBlock.FormattingEnabled = True
        CodeBlock.ItemHeight = 22
        CodeBlock.Location = New Point(183, 183)
        CodeBlock.Margin = New Padding(2)
        CodeBlock.Name = "CodeBlock"
        CodeBlock.Size = New Size(338, 158)
        CodeBlock.TabIndex = 6
        ' 
        ' Form1
        ' 
        AccessibleName = "PLTAssignment"
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(532, 565)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(CodeBlock)
        Controls.Add(ResultBlock)
        Controls.Add(Button3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnParse)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ResultBlock As ListBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnParse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents CodeBlock As ListBox

End Class
