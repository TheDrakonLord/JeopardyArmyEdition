<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnd))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rtbTeam3Score = New System.Windows.Forms.RichTextBox()
        Me.rtbTeam2Score = New System.Windows.Forms.RichTextBox()
        Me.rtbTeam1Score = New System.Windows.Forms.RichTextBox()
        Me.rtbWinner = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Blue
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(0, 707)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(1008, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rtbTeam3Score)
        Me.Panel1.Controls.Add(Me.rtbTeam2Score)
        Me.Panel1.Controls.Add(Me.rtbTeam1Score)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 282)
        Me.Panel1.TabIndex = 1
        '
        'rtbTeam3Score
        '
        Me.rtbTeam3Score.BackColor = System.Drawing.Color.Blue
        Me.rtbTeam3Score.Dock = System.Windows.Forms.DockStyle.Right
        Me.rtbTeam3Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTeam3Score.ForeColor = System.Drawing.Color.White
        Me.rtbTeam3Score.Location = New System.Drawing.Point(672, 0)
        Me.rtbTeam3Score.Name = "rtbTeam3Score"
        Me.rtbTeam3Score.Size = New System.Drawing.Size(336, 282)
        Me.rtbTeam3Score.TabIndex = 2
        Me.rtbTeam3Score.Text = "3000"
        '
        'rtbTeam2Score
        '
        Me.rtbTeam2Score.BackColor = System.Drawing.Color.Blue
        Me.rtbTeam2Score.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbTeam2Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTeam2Score.ForeColor = System.Drawing.Color.White
        Me.rtbTeam2Score.Location = New System.Drawing.Point(336, 0)
        Me.rtbTeam2Score.Name = "rtbTeam2Score"
        Me.rtbTeam2Score.Size = New System.Drawing.Size(336, 282)
        Me.rtbTeam2Score.TabIndex = 1
        Me.rtbTeam2Score.Text = "2000"
        '
        'rtbTeam1Score
        '
        Me.rtbTeam1Score.BackColor = System.Drawing.Color.Blue
        Me.rtbTeam1Score.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbTeam1Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTeam1Score.ForeColor = System.Drawing.Color.White
        Me.rtbTeam1Score.Location = New System.Drawing.Point(0, 0)
        Me.rtbTeam1Score.Name = "rtbTeam1Score"
        Me.rtbTeam1Score.Size = New System.Drawing.Size(336, 282)
        Me.rtbTeam1Score.TabIndex = 0
        Me.rtbTeam1Score.Text = "1000"
        '
        'rtbWinner
        '
        Me.rtbWinner.BackColor = System.Drawing.Color.Blue
        Me.rtbWinner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbWinner.ForeColor = System.Drawing.Color.White
        Me.rtbWinner.Location = New System.Drawing.Point(0, 282)
        Me.rtbWinner.Name = "rtbWinner"
        Me.rtbWinner.Size = New System.Drawing.Size(1008, 425)
        Me.rtbWinner.TabIndex = 2
        Me.rtbWinner.Text = "TEAM 3 WINS"
        '
        'frmEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.rtbWinner)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEnd"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Jeopardy: Army Board Edition"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rtbWinner As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbTeam3Score As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbTeam2Score As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbTeam1Score As System.Windows.Forms.RichTextBox
End Class
