<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rtbTeam1Bet = New System.Windows.Forms.RichTextBox()
        Me.rtbTeam2Bet = New System.Windows.Forms.RichTextBox()
        Me.rtbTeam3Bet = New System.Windows.Forms.RichTextBox()
        Me.pnlLower = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pnlTeam1 = New System.Windows.Forms.Panel()
        Me.pnlTeam2 = New System.Windows.Forms.Panel()
        Me.pnlTeam3 = New System.Windows.Forms.Panel()
        Me.rtbQuestionAndAnswer = New System.Windows.Forms.RichTextBox()
        Me.tmrGameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.radTeam1Correct = New System.Windows.Forms.RadioButton()
        Me.radTeam1Incorrect = New System.Windows.Forms.RadioButton()
        Me.radTeam2Correct = New System.Windows.Forms.RadioButton()
        Me.radTeam2Incorrect = New System.Windows.Forms.RadioButton()
        Me.radTeam3Correct = New System.Windows.Forms.RadioButton()
        Me.radTeam3Incorrect = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.pnlLower.SuspendLayout()
        Me.pnlTeam1.SuspendLayout()
        Me.pnlTeam2.SuspendLayout()
        Me.pnlTeam3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rtbTeam1Bet)
        Me.Panel1.Controls.Add(Me.rtbTeam2Bet)
        Me.Panel1.Controls.Add(Me.rtbTeam3Bet)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 100)
        Me.Panel1.TabIndex = 0
        '
        'rtbTeam1Bet
        '
        Me.rtbTeam1Bet.BackColor = System.Drawing.Color.Blue
        Me.rtbTeam1Bet.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbTeam1Bet.ForeColor = System.Drawing.Color.White
        Me.rtbTeam1Bet.Location = New System.Drawing.Point(0, 0)
        Me.rtbTeam1Bet.Name = "rtbTeam1Bet"
        Me.rtbTeam1Bet.Size = New System.Drawing.Size(336, 100)
        Me.rtbTeam1Bet.TabIndex = 2
        Me.rtbTeam1Bet.Text = ""
        '
        'rtbTeam2Bet
        '
        Me.rtbTeam2Bet.BackColor = System.Drawing.Color.Blue
        Me.rtbTeam2Bet.Dock = System.Windows.Forms.DockStyle.Right
        Me.rtbTeam2Bet.ForeColor = System.Drawing.Color.White
        Me.rtbTeam2Bet.Location = New System.Drawing.Point(336, 0)
        Me.rtbTeam2Bet.Name = "rtbTeam2Bet"
        Me.rtbTeam2Bet.Size = New System.Drawing.Size(336, 100)
        Me.rtbTeam2Bet.TabIndex = 1
        Me.rtbTeam2Bet.Text = ""
        '
        'rtbTeam3Bet
        '
        Me.rtbTeam3Bet.BackColor = System.Drawing.Color.Blue
        Me.rtbTeam3Bet.Dock = System.Windows.Forms.DockStyle.Right
        Me.rtbTeam3Bet.ForeColor = System.Drawing.Color.White
        Me.rtbTeam3Bet.Location = New System.Drawing.Point(672, 0)
        Me.rtbTeam3Bet.Name = "rtbTeam3Bet"
        Me.rtbTeam3Bet.Size = New System.Drawing.Size(336, 100)
        Me.rtbTeam3Bet.TabIndex = 0
        Me.rtbTeam3Bet.Text = ""
        '
        'pnlLower
        '
        Me.pnlLower.Controls.Add(Me.btnStart)
        Me.pnlLower.Controls.Add(Me.pnlTeam1)
        Me.pnlLower.Controls.Add(Me.pnlTeam2)
        Me.pnlLower.Controls.Add(Me.pnlTeam3)
        Me.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlLower.Location = New System.Drawing.Point(0, 630)
        Me.pnlLower.Name = "pnlLower"
        Me.pnlLower.Size = New System.Drawing.Size(1008, 100)
        Me.pnlLower.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Blue
        Me.btnStart.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(0, 0)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(252, 100)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'pnlTeam1
        '
        Me.pnlTeam1.Controls.Add(Me.radTeam1Incorrect)
        Me.pnlTeam1.Controls.Add(Me.radTeam1Correct)
        Me.pnlTeam1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTeam1.Location = New System.Drawing.Point(252, 0)
        Me.pnlTeam1.Name = "pnlTeam1"
        Me.pnlTeam1.Size = New System.Drawing.Size(252, 100)
        Me.pnlTeam1.TabIndex = 2
        '
        'pnlTeam2
        '
        Me.pnlTeam2.Controls.Add(Me.radTeam2Incorrect)
        Me.pnlTeam2.Controls.Add(Me.radTeam2Correct)
        Me.pnlTeam2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTeam2.Location = New System.Drawing.Point(504, 0)
        Me.pnlTeam2.Name = "pnlTeam2"
        Me.pnlTeam2.Size = New System.Drawing.Size(252, 100)
        Me.pnlTeam2.TabIndex = 1
        '
        'pnlTeam3
        '
        Me.pnlTeam3.Controls.Add(Me.radTeam3Incorrect)
        Me.pnlTeam3.Controls.Add(Me.radTeam3Correct)
        Me.pnlTeam3.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTeam3.Location = New System.Drawing.Point(756, 0)
        Me.pnlTeam3.Name = "pnlTeam3"
        Me.pnlTeam3.Size = New System.Drawing.Size(252, 100)
        Me.pnlTeam3.TabIndex = 0
        '
        'rtbQuestionAndAnswer
        '
        Me.rtbQuestionAndAnswer.BackColor = System.Drawing.Color.Blue
        Me.rtbQuestionAndAnswer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbQuestionAndAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbQuestionAndAnswer.ForeColor = System.Drawing.Color.White
        Me.rtbQuestionAndAnswer.Location = New System.Drawing.Point(0, 100)
        Me.rtbQuestionAndAnswer.Name = "rtbQuestionAndAnswer"
        Me.rtbQuestionAndAnswer.Size = New System.Drawing.Size(1008, 530)
        Me.rtbQuestionAndAnswer.TabIndex = 2
        Me.rtbQuestionAndAnswer.Text = "This is a test Category"
        '
        'radTeam1Correct
        '
        Me.radTeam1Correct.AutoSize = True
        Me.radTeam1Correct.ForeColor = System.Drawing.Color.White
        Me.radTeam1Correct.Location = New System.Drawing.Point(38, 21)
        Me.radTeam1Correct.Name = "radTeam1Correct"
        Me.radTeam1Correct.Size = New System.Drawing.Size(98, 17)
        Me.radTeam1Correct.TabIndex = 0
        Me.radTeam1Correct.TabStop = True
        Me.radTeam1Correct.Text = "Team 1 Correct"
        Me.radTeam1Correct.UseVisualStyleBackColor = True
        '
        'radTeam1Incorrect
        '
        Me.radTeam1Incorrect.AutoSize = True
        Me.radTeam1Incorrect.ForeColor = System.Drawing.Color.White
        Me.radTeam1Incorrect.Location = New System.Drawing.Point(38, 59)
        Me.radTeam1Incorrect.Name = "radTeam1Incorrect"
        Me.radTeam1Incorrect.Size = New System.Drawing.Size(106, 17)
        Me.radTeam1Incorrect.TabIndex = 1
        Me.radTeam1Incorrect.TabStop = True
        Me.radTeam1Incorrect.Text = "Team 1 Incorrect"
        Me.radTeam1Incorrect.UseVisualStyleBackColor = True
        '
        'radTeam2Correct
        '
        Me.radTeam2Correct.AutoSize = True
        Me.radTeam2Correct.ForeColor = System.Drawing.Color.White
        Me.radTeam2Correct.Location = New System.Drawing.Point(28, 21)
        Me.radTeam2Correct.Name = "radTeam2Correct"
        Me.radTeam2Correct.Size = New System.Drawing.Size(98, 17)
        Me.radTeam2Correct.TabIndex = 0
        Me.radTeam2Correct.TabStop = True
        Me.radTeam2Correct.Text = "Team 2 Correct"
        Me.radTeam2Correct.UseVisualStyleBackColor = True
        '
        'radTeam2Incorrect
        '
        Me.radTeam2Incorrect.AutoSize = True
        Me.radTeam2Incorrect.ForeColor = System.Drawing.Color.White
        Me.radTeam2Incorrect.Location = New System.Drawing.Point(28, 59)
        Me.radTeam2Incorrect.Name = "radTeam2Incorrect"
        Me.radTeam2Incorrect.Size = New System.Drawing.Size(106, 17)
        Me.radTeam2Incorrect.TabIndex = 1
        Me.radTeam2Incorrect.TabStop = True
        Me.radTeam2Incorrect.Text = "Team 2 Incorrect"
        Me.radTeam2Incorrect.UseVisualStyleBackColor = True
        '
        'radTeam3Correct
        '
        Me.radTeam3Correct.AutoSize = True
        Me.radTeam3Correct.ForeColor = System.Drawing.Color.White
        Me.radTeam3Correct.Location = New System.Drawing.Point(24, 21)
        Me.radTeam3Correct.Name = "radTeam3Correct"
        Me.radTeam3Correct.Size = New System.Drawing.Size(98, 17)
        Me.radTeam3Correct.TabIndex = 0
        Me.radTeam3Correct.TabStop = True
        Me.radTeam3Correct.Text = "Team 3 Correct"
        Me.radTeam3Correct.UseVisualStyleBackColor = True
        '
        'radTeam3Incorrect
        '
        Me.radTeam3Incorrect.AutoSize = True
        Me.radTeam3Incorrect.ForeColor = System.Drawing.Color.White
        Me.radTeam3Incorrect.Location = New System.Drawing.Point(24, 59)
        Me.radTeam3Incorrect.Name = "radTeam3Incorrect"
        Me.radTeam3Incorrect.Size = New System.Drawing.Size(106, 17)
        Me.radTeam3Incorrect.TabIndex = 1
        Me.radTeam3Incorrect.TabStop = True
        Me.radTeam3Incorrect.Text = "Team 3 Incorrect"
        Me.radTeam3Incorrect.UseVisualStyleBackColor = True
        '
        'frmFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.rtbQuestionAndAnswer)
        Me.Controls.Add(Me.pnlLower)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Jeopardy: Army Board Edition"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.pnlLower.ResumeLayout(False)
        Me.pnlTeam1.ResumeLayout(False)
        Me.pnlTeam1.PerformLayout()
        Me.pnlTeam2.ResumeLayout(False)
        Me.pnlTeam2.PerformLayout()
        Me.pnlTeam3.ResumeLayout(False)
        Me.pnlTeam3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rtbTeam1Bet As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbTeam2Bet As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbTeam3Bet As System.Windows.Forms.RichTextBox
    Friend WithEvents pnlLower As System.Windows.Forms.Panel
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents pnlTeam1 As System.Windows.Forms.Panel
    Friend WithEvents pnlTeam2 As System.Windows.Forms.Panel
    Friend WithEvents pnlTeam3 As System.Windows.Forms.Panel
    Friend WithEvents rtbQuestionAndAnswer As System.Windows.Forms.RichTextBox
    Friend WithEvents tmrGameTimer As System.Windows.Forms.Timer
    Friend WithEvents radTeam1Incorrect As System.Windows.Forms.RadioButton
    Friend WithEvents radTeam1Correct As System.Windows.Forms.RadioButton
    Friend WithEvents radTeam2Incorrect As System.Windows.Forms.RadioButton
    Friend WithEvents radTeam2Correct As System.Windows.Forms.RadioButton
    Friend WithEvents radTeam3Incorrect As System.Windows.Forms.RadioButton
    Friend WithEvents radTeam3Correct As System.Windows.Forms.RadioButton
End Class
