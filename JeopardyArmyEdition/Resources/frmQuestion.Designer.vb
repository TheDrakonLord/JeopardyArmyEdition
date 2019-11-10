<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion))
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnTeam3 = New System.Windows.Forms.Button()
        Me.btnTeam2 = New System.Windows.Forms.Button()
        Me.btnTeam1 = New System.Windows.Forms.Button()
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.btnIncorrect = New System.Windows.Forms.Button()
        Me.rtbQuestionAndAnswer = New System.Windows.Forms.RichTextBox()
        Me.pbrGameClock = New System.Windows.Forms.ProgressBar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrMain
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.btnTeam3)
        Me.Panel1.Controls.Add(Me.btnTeam2)
        Me.Panel1.Controls.Add(Me.btnTeam1)
        Me.Panel1.Controls.Add(Me.btnCorrect)
        Me.Panel1.Controls.Add(Me.btnIncorrect)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 85)
        Me.Panel1.TabIndex = 0
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Blue
        Me.btnStop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(225, 0)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(633, 85)
        Me.btnStop.TabIndex = 8
        Me.btnStop.Text = "Answer"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnTeam3
        '
        Me.btnTeam3.BackColor = System.Drawing.Color.Blue
        Me.btnTeam3.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnTeam3.ForeColor = System.Drawing.Color.White
        Me.btnTeam3.Location = New System.Drawing.Point(150, 0)
        Me.btnTeam3.Name = "btnTeam3"
        Me.btnTeam3.Size = New System.Drawing.Size(75, 85)
        Me.btnTeam3.TabIndex = 2
        Me.btnTeam3.Text = "Team 3"
        Me.btnTeam3.UseVisualStyleBackColor = False
        '
        'btnTeam2
        '
        Me.btnTeam2.BackColor = System.Drawing.Color.Blue
        Me.btnTeam2.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnTeam2.ForeColor = System.Drawing.Color.White
        Me.btnTeam2.Location = New System.Drawing.Point(75, 0)
        Me.btnTeam2.Name = "btnTeam2"
        Me.btnTeam2.Size = New System.Drawing.Size(75, 85)
        Me.btnTeam2.TabIndex = 3
        Me.btnTeam2.Text = "Team 2"
        Me.btnTeam2.UseVisualStyleBackColor = False
        '
        'btnTeam1
        '
        Me.btnTeam1.BackColor = System.Drawing.Color.Blue
        Me.btnTeam1.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnTeam1.ForeColor = System.Drawing.Color.White
        Me.btnTeam1.Location = New System.Drawing.Point(0, 0)
        Me.btnTeam1.Name = "btnTeam1"
        Me.btnTeam1.Size = New System.Drawing.Size(75, 85)
        Me.btnTeam1.TabIndex = 4
        Me.btnTeam1.Text = "Team 1"
        Me.btnTeam1.UseVisualStyleBackColor = False
        '
        'btnCorrect
        '
        Me.btnCorrect.BackColor = System.Drawing.Color.Blue
        Me.btnCorrect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCorrect.ForeColor = System.Drawing.Color.White
        Me.btnCorrect.Location = New System.Drawing.Point(858, 0)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(75, 85)
        Me.btnCorrect.TabIndex = 6
        Me.btnCorrect.Text = "Correct"
        Me.btnCorrect.UseVisualStyleBackColor = False
        '
        'btnIncorrect
        '
        Me.btnIncorrect.BackColor = System.Drawing.Color.Blue
        Me.btnIncorrect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnIncorrect.ForeColor = System.Drawing.Color.White
        Me.btnIncorrect.Location = New System.Drawing.Point(933, 0)
        Me.btnIncorrect.Name = "btnIncorrect"
        Me.btnIncorrect.Size = New System.Drawing.Size(75, 85)
        Me.btnIncorrect.TabIndex = 7
        Me.btnIncorrect.Text = "Incorrect"
        Me.btnIncorrect.UseVisualStyleBackColor = False
        '
        'rtbQuestionAndAnswer
        '
        Me.rtbQuestionAndAnswer.BackColor = System.Drawing.Color.Blue
        Me.rtbQuestionAndAnswer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbQuestionAndAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbQuestionAndAnswer.ForeColor = System.Drawing.Color.White
        Me.rtbQuestionAndAnswer.Location = New System.Drawing.Point(0, 85)
        Me.rtbQuestionAndAnswer.Name = "rtbQuestionAndAnswer"
        Me.rtbQuestionAndAnswer.Size = New System.Drawing.Size(1008, 645)
        Me.rtbQuestionAndAnswer.TabIndex = 1
        Me.rtbQuestionAndAnswer.Text = "this is a test question"
        '
        'pbrGameClock
        '
        Me.pbrGameClock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbrGameClock.Location = New System.Drawing.Point(0, 707)
        Me.pbrGameClock.Name = "pbrGameClock"
        Me.pbrGameClock.Size = New System.Drawing.Size(1008, 23)
        Me.pbrGameClock.TabIndex = 2
        Me.pbrGameClock.Value = 100
        '
        'frmQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.pbrGameClock)
        Me.Controls.Add(Me.rtbQuestionAndAnswer)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuestion"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Jeopardy: Army Board Edition"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rtbQuestionAndAnswer As System.Windows.Forms.RichTextBox
    Friend WithEvents btnTeam3 As System.Windows.Forms.Button
    Friend WithEvents btnTeam2 As System.Windows.Forms.Button
    Friend WithEvents btnTeam1 As System.Windows.Forms.Button
    Friend WithEvents btnCorrect As System.Windows.Forms.Button
    Friend WithEvents btnIncorrect As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents pbrGameClock As System.Windows.Forms.ProgressBar
End Class
