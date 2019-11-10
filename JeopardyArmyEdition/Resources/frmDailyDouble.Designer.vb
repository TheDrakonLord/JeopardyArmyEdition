<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyDouble
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyDouble))
        Me.txtBet = New System.Windows.Forms.TextBox()
        Me.btnSetBet = New System.Windows.Forms.Button()
        Me.btnIncorrect = New System.Windows.Forms.Button()
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.rtbQuestionAndAnswer = New System.Windows.Forms.RichTextBox()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBet
        '
        Me.txtBet.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtBet.Location = New System.Drawing.Point(0, 0)
        Me.txtBet.Name = "txtBet"
        Me.txtBet.Size = New System.Drawing.Size(115, 20)
        Me.txtBet.TabIndex = 0
        '
        'btnSetBet
        '
        Me.btnSetBet.BackColor = System.Drawing.Color.Red
        Me.btnSetBet.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSetBet.ForeColor = System.Drawing.Color.Black
        Me.btnSetBet.Location = New System.Drawing.Point(115, 0)
        Me.btnSetBet.Name = "btnSetBet"
        Me.btnSetBet.Size = New System.Drawing.Size(75, 29)
        Me.btnSetBet.TabIndex = 1
        Me.btnSetBet.Text = "Submit"
        Me.btnSetBet.UseVisualStyleBackColor = False
        '
        'btnIncorrect
        '
        Me.btnIncorrect.BackColor = System.Drawing.Color.Red
        Me.btnIncorrect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnIncorrect.ForeColor = System.Drawing.Color.Black
        Me.btnIncorrect.Location = New System.Drawing.Point(933, 0)
        Me.btnIncorrect.Name = "btnIncorrect"
        Me.btnIncorrect.Size = New System.Drawing.Size(75, 29)
        Me.btnIncorrect.TabIndex = 2
        Me.btnIncorrect.Text = "Incorrect"
        Me.btnIncorrect.UseVisualStyleBackColor = False
        '
        'btnCorrect
        '
        Me.btnCorrect.BackColor = System.Drawing.Color.Red
        Me.btnCorrect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCorrect.ForeColor = System.Drawing.Color.Black
        Me.btnCorrect.Location = New System.Drawing.Point(858, 0)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(75, 29)
        Me.btnCorrect.TabIndex = 3
        Me.btnCorrect.Text = "Correct"
        Me.btnCorrect.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.btnCorrect)
        Me.pnlTop.Controls.Add(Me.btnIncorrect)
        Me.pnlTop.Controls.Add(Me.btnSetBet)
        Me.pnlTop.Controls.Add(Me.txtBet)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1008, 29)
        Me.pnlTop.TabIndex = 4
        '
        'rtbQuestionAndAnswer
        '
        Me.rtbQuestionAndAnswer.BackColor = System.Drawing.Color.DarkRed
        Me.rtbQuestionAndAnswer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbQuestionAndAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbQuestionAndAnswer.ForeColor = System.Drawing.Color.White
        Me.rtbQuestionAndAnswer.Location = New System.Drawing.Point(0, 29)
        Me.rtbQuestionAndAnswer.Name = "rtbQuestionAndAnswer"
        Me.rtbQuestionAndAnswer.ReadOnly = True
        Me.rtbQuestionAndAnswer.Size = New System.Drawing.Size(1008, 701)
        Me.rtbQuestionAndAnswer.TabIndex = 6
        Me.rtbQuestionAndAnswer.Text = "This is a test question"
        '
        'frmDailyDouble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.rtbQuestionAndAnswer)
        Me.Controls.Add(Me.pnlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDailyDouble"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Jeopardy: Army Board Edition"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBet As System.Windows.Forms.TextBox
    Friend WithEvents btnSetBet As System.Windows.Forms.Button
    Friend WithEvents btnIncorrect As System.Windows.Forms.Button
    Friend WithEvents btnCorrect As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents rtbQuestionAndAnswer As System.Windows.Forms.RichTextBox
End Class
