<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJeopardy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJeopardy))
        Me.pnlScorePanel = New System.Windows.Forms.Panel()
        Me.rtbTeam3Score = New System.Windows.Forms.RichTextBox()
        Me.rtbTeam2Score = New System.Windows.Forms.RichTextBox()
        Me.rtbTeam1Score = New System.Windows.Forms.RichTextBox()
        Me.pnlCategoryPanel = New System.Windows.Forms.Panel()
        Me.rtbCategory6 = New System.Windows.Forms.RichTextBox()
        Me.rtbCategory5 = New System.Windows.Forms.RichTextBox()
        Me.rtbCategory4 = New System.Windows.Forms.RichTextBox()
        Me.rtbCategory3 = New System.Windows.Forms.RichTextBox()
        Me.rtbCategory2 = New System.Windows.Forms.RichTextBox()
        Me.rtbCategory1 = New System.Windows.Forms.RichTextBox()
        Me.pnlCat1Questions = New System.Windows.Forms.Panel()
        Me.btnCat1Row5 = New System.Windows.Forms.Button()
        Me.btnCat1Row4 = New System.Windows.Forms.Button()
        Me.btnCat1Row3 = New System.Windows.Forms.Button()
        Me.btnCat1Row2 = New System.Windows.Forms.Button()
        Me.btnCat1Row1 = New System.Windows.Forms.Button()
        Me.pnlCat2Questions = New System.Windows.Forms.Panel()
        Me.btnCat2Row5 = New System.Windows.Forms.Button()
        Me.btnCat2Row4 = New System.Windows.Forms.Button()
        Me.btnCat2Row3 = New System.Windows.Forms.Button()
        Me.btnCat2Row2 = New System.Windows.Forms.Button()
        Me.btnCat2Row1 = New System.Windows.Forms.Button()
        Me.pnlCat3Questions = New System.Windows.Forms.Panel()
        Me.btnCat3Row5 = New System.Windows.Forms.Button()
        Me.btnCat3Row4 = New System.Windows.Forms.Button()
        Me.btnCat3Row3 = New System.Windows.Forms.Button()
        Me.btnCat3Row2 = New System.Windows.Forms.Button()
        Me.btnCat3Row1 = New System.Windows.Forms.Button()
        Me.pnlCat4Questions = New System.Windows.Forms.Panel()
        Me.btnCat4Row5 = New System.Windows.Forms.Button()
        Me.btnCat4Row4 = New System.Windows.Forms.Button()
        Me.btnCat4Row3 = New System.Windows.Forms.Button()
        Me.btnCat4Row2 = New System.Windows.Forms.Button()
        Me.btnCat4Row1 = New System.Windows.Forms.Button()
        Me.pnlCat5Questions = New System.Windows.Forms.Panel()
        Me.btnCat5Row5 = New System.Windows.Forms.Button()
        Me.btnCat5Row4 = New System.Windows.Forms.Button()
        Me.btnCat5Row3 = New System.Windows.Forms.Button()
        Me.btnCat5Row2 = New System.Windows.Forms.Button()
        Me.btnCat5Row1 = New System.Windows.Forms.Button()
        Me.pnlCat6Questions = New System.Windows.Forms.Panel()
        Me.btnCat6Row5 = New System.Windows.Forms.Button()
        Me.btnCat6Row4 = New System.Windows.Forms.Button()
        Me.btnCat6Row3 = New System.Windows.Forms.Button()
        Me.btnCat6Row2 = New System.Windows.Forms.Button()
        Me.btnCat6Row1 = New System.Windows.Forms.Button()
        Me.pnlScorePanel.SuspendLayout()
        Me.pnlCategoryPanel.SuspendLayout()
        Me.pnlCat1Questions.SuspendLayout()
        Me.pnlCat2Questions.SuspendLayout()
        Me.pnlCat3Questions.SuspendLayout()
        Me.pnlCat4Questions.SuspendLayout()
        Me.pnlCat5Questions.SuspendLayout()
        Me.pnlCat6Questions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlScorePanel
        '
        Me.pnlScorePanel.Controls.Add(Me.rtbTeam3Score)
        Me.pnlScorePanel.Controls.Add(Me.rtbTeam2Score)
        Me.pnlScorePanel.Controls.Add(Me.rtbTeam1Score)
        Me.pnlScorePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlScorePanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlScorePanel.Name = "pnlScorePanel"
        Me.pnlScorePanel.Size = New System.Drawing.Size(1008, 100)
        Me.pnlScorePanel.TabIndex = 0
        '
        'rtbTeam3Score
        '
        Me.rtbTeam3Score.BackColor = System.Drawing.Color.CornflowerBlue
        Me.rtbTeam3Score.Dock = System.Windows.Forms.DockStyle.Right
        Me.rtbTeam3Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTeam3Score.ForeColor = System.Drawing.Color.White
        Me.rtbTeam3Score.Location = New System.Drawing.Point(672, 0)
        Me.rtbTeam3Score.Name = "rtbTeam3Score"
        Me.rtbTeam3Score.ReadOnly = True
        Me.rtbTeam3Score.Size = New System.Drawing.Size(336, 100)
        Me.rtbTeam3Score.TabIndex = 2
        Me.rtbTeam3Score.Text = "2000"
        '
        'rtbTeam2Score
        '
        Me.rtbTeam2Score.BackColor = System.Drawing.Color.CornflowerBlue
        Me.rtbTeam2Score.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbTeam2Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!)
        Me.rtbTeam2Score.ForeColor = System.Drawing.Color.White
        Me.rtbTeam2Score.Location = New System.Drawing.Point(336, 0)
        Me.rtbTeam2Score.Name = "rtbTeam2Score"
        Me.rtbTeam2Score.ReadOnly = True
        Me.rtbTeam2Score.Size = New System.Drawing.Size(336, 100)
        Me.rtbTeam2Score.TabIndex = 1
        Me.rtbTeam2Score.Text = "3000"
        '
        'rtbTeam1Score
        '
        Me.rtbTeam1Score.BackColor = System.Drawing.Color.CornflowerBlue
        Me.rtbTeam1Score.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbTeam1Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTeam1Score.ForeColor = System.Drawing.Color.White
        Me.rtbTeam1Score.Location = New System.Drawing.Point(0, 0)
        Me.rtbTeam1Score.Name = "rtbTeam1Score"
        Me.rtbTeam1Score.ReadOnly = True
        Me.rtbTeam1Score.Size = New System.Drawing.Size(336, 100)
        Me.rtbTeam1Score.TabIndex = 0
        Me.rtbTeam1Score.Text = "4000"
        '
        'pnlCategoryPanel
        '
        Me.pnlCategoryPanel.Controls.Add(Me.rtbCategory6)
        Me.pnlCategoryPanel.Controls.Add(Me.rtbCategory5)
        Me.pnlCategoryPanel.Controls.Add(Me.rtbCategory4)
        Me.pnlCategoryPanel.Controls.Add(Me.rtbCategory3)
        Me.pnlCategoryPanel.Controls.Add(Me.rtbCategory2)
        Me.pnlCategoryPanel.Controls.Add(Me.rtbCategory1)
        Me.pnlCategoryPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCategoryPanel.Location = New System.Drawing.Point(0, 100)
        Me.pnlCategoryPanel.Name = "pnlCategoryPanel"
        Me.pnlCategoryPanel.Size = New System.Drawing.Size(1008, 100)
        Me.pnlCategoryPanel.TabIndex = 1
        '
        'rtbCategory6
        '
        Me.rtbCategory6.BackColor = System.Drawing.Color.Blue
        Me.rtbCategory6.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbCategory6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCategory6.ForeColor = System.Drawing.Color.White
        Me.rtbCategory6.Location = New System.Drawing.Point(840, 0)
        Me.rtbCategory6.Name = "rtbCategory6"
        Me.rtbCategory6.ReadOnly = True
        Me.rtbCategory6.Size = New System.Drawing.Size(168, 100)
        Me.rtbCategory6.TabIndex = 6
        Me.rtbCategory6.Text = "Cat 6"
        '
        'rtbCategory5
        '
        Me.rtbCategory5.BackColor = System.Drawing.Color.Blue
        Me.rtbCategory5.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbCategory5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCategory5.ForeColor = System.Drawing.Color.White
        Me.rtbCategory5.Location = New System.Drawing.Point(672, 0)
        Me.rtbCategory5.Name = "rtbCategory5"
        Me.rtbCategory5.ReadOnly = True
        Me.rtbCategory5.Size = New System.Drawing.Size(168, 100)
        Me.rtbCategory5.TabIndex = 5
        Me.rtbCategory5.Text = "Cat 5"
        '
        'rtbCategory4
        '
        Me.rtbCategory4.BackColor = System.Drawing.Color.Blue
        Me.rtbCategory4.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbCategory4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCategory4.ForeColor = System.Drawing.Color.White
        Me.rtbCategory4.Location = New System.Drawing.Point(504, 0)
        Me.rtbCategory4.Name = "rtbCategory4"
        Me.rtbCategory4.ReadOnly = True
        Me.rtbCategory4.Size = New System.Drawing.Size(168, 100)
        Me.rtbCategory4.TabIndex = 4
        Me.rtbCategory4.Text = "Cat 4"
        '
        'rtbCategory3
        '
        Me.rtbCategory3.BackColor = System.Drawing.Color.Blue
        Me.rtbCategory3.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbCategory3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCategory3.ForeColor = System.Drawing.Color.White
        Me.rtbCategory3.Location = New System.Drawing.Point(336, 0)
        Me.rtbCategory3.Name = "rtbCategory3"
        Me.rtbCategory3.ReadOnly = True
        Me.rtbCategory3.Size = New System.Drawing.Size(168, 100)
        Me.rtbCategory3.TabIndex = 3
        Me.rtbCategory3.Text = "Cat 3"
        '
        'rtbCategory2
        '
        Me.rtbCategory2.BackColor = System.Drawing.Color.Blue
        Me.rtbCategory2.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbCategory2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCategory2.ForeColor = System.Drawing.Color.White
        Me.rtbCategory2.Location = New System.Drawing.Point(168, 0)
        Me.rtbCategory2.Name = "rtbCategory2"
        Me.rtbCategory2.ReadOnly = True
        Me.rtbCategory2.Size = New System.Drawing.Size(168, 100)
        Me.rtbCategory2.TabIndex = 2
        Me.rtbCategory2.Text = "Cat 2"
        '
        'rtbCategory1
        '
        Me.rtbCategory1.BackColor = System.Drawing.Color.Blue
        Me.rtbCategory1.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbCategory1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCategory1.ForeColor = System.Drawing.Color.White
        Me.rtbCategory1.Location = New System.Drawing.Point(0, 0)
        Me.rtbCategory1.Name = "rtbCategory1"
        Me.rtbCategory1.ReadOnly = True
        Me.rtbCategory1.Size = New System.Drawing.Size(168, 100)
        Me.rtbCategory1.TabIndex = 1
        Me.rtbCategory1.Text = "Cat 1"
        '
        'pnlCat1Questions
        '
        Me.pnlCat1Questions.Controls.Add(Me.btnCat1Row5)
        Me.pnlCat1Questions.Controls.Add(Me.btnCat1Row4)
        Me.pnlCat1Questions.Controls.Add(Me.btnCat1Row3)
        Me.pnlCat1Questions.Controls.Add(Me.btnCat1Row2)
        Me.pnlCat1Questions.Controls.Add(Me.btnCat1Row1)
        Me.pnlCat1Questions.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCat1Questions.Location = New System.Drawing.Point(0, 200)
        Me.pnlCat1Questions.Name = "pnlCat1Questions"
        Me.pnlCat1Questions.Size = New System.Drawing.Size(168, 530)
        Me.pnlCat1Questions.TabIndex = 2
        '
        'btnCat1Row5
        '
        Me.btnCat1Row5.BackColor = System.Drawing.Color.Blue
        Me.btnCat1Row5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat1Row5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat1Row5.ForeColor = System.Drawing.Color.Gold
        Me.btnCat1Row5.Location = New System.Drawing.Point(0, 424)
        Me.btnCat1Row5.Name = "btnCat1Row5"
        Me.btnCat1Row5.Size = New System.Drawing.Size(168, 106)
        Me.btnCat1Row5.TabIndex = 29
        Me.btnCat1Row5.Text = "1000"
        Me.btnCat1Row5.UseVisualStyleBackColor = False
        '
        'btnCat1Row4
        '
        Me.btnCat1Row4.BackColor = System.Drawing.Color.Blue
        Me.btnCat1Row4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat1Row4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat1Row4.ForeColor = System.Drawing.Color.Gold
        Me.btnCat1Row4.Location = New System.Drawing.Point(0, 318)
        Me.btnCat1Row4.Name = "btnCat1Row4"
        Me.btnCat1Row4.Size = New System.Drawing.Size(168, 106)
        Me.btnCat1Row4.TabIndex = 28
        Me.btnCat1Row4.Text = "800"
        Me.btnCat1Row4.UseVisualStyleBackColor = False
        '
        'btnCat1Row3
        '
        Me.btnCat1Row3.BackColor = System.Drawing.Color.Blue
        Me.btnCat1Row3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat1Row3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat1Row3.ForeColor = System.Drawing.Color.Gold
        Me.btnCat1Row3.Location = New System.Drawing.Point(0, 212)
        Me.btnCat1Row3.Name = "btnCat1Row3"
        Me.btnCat1Row3.Size = New System.Drawing.Size(168, 106)
        Me.btnCat1Row3.TabIndex = 27
        Me.btnCat1Row3.Text = "600"
        Me.btnCat1Row3.UseVisualStyleBackColor = False
        '
        'btnCat1Row2
        '
        Me.btnCat1Row2.BackColor = System.Drawing.Color.Blue
        Me.btnCat1Row2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat1Row2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat1Row2.ForeColor = System.Drawing.Color.Gold
        Me.btnCat1Row2.Location = New System.Drawing.Point(0, 106)
        Me.btnCat1Row2.Name = "btnCat1Row2"
        Me.btnCat1Row2.Size = New System.Drawing.Size(168, 106)
        Me.btnCat1Row2.TabIndex = 26
        Me.btnCat1Row2.Text = "400"
        Me.btnCat1Row2.UseVisualStyleBackColor = False
        '
        'btnCat1Row1
        '
        Me.btnCat1Row1.BackColor = System.Drawing.Color.Blue
        Me.btnCat1Row1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat1Row1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat1Row1.ForeColor = System.Drawing.Color.Gold
        Me.btnCat1Row1.Location = New System.Drawing.Point(0, 0)
        Me.btnCat1Row1.Name = "btnCat1Row1"
        Me.btnCat1Row1.Size = New System.Drawing.Size(168, 106)
        Me.btnCat1Row1.TabIndex = 25
        Me.btnCat1Row1.Text = "200"
        Me.btnCat1Row1.UseVisualStyleBackColor = False
        '
        'pnlCat2Questions
        '
        Me.pnlCat2Questions.Controls.Add(Me.btnCat2Row5)
        Me.pnlCat2Questions.Controls.Add(Me.btnCat2Row4)
        Me.pnlCat2Questions.Controls.Add(Me.btnCat2Row3)
        Me.pnlCat2Questions.Controls.Add(Me.btnCat2Row2)
        Me.pnlCat2Questions.Controls.Add(Me.btnCat2Row1)
        Me.pnlCat2Questions.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCat2Questions.Location = New System.Drawing.Point(168, 200)
        Me.pnlCat2Questions.Name = "pnlCat2Questions"
        Me.pnlCat2Questions.Size = New System.Drawing.Size(168, 530)
        Me.pnlCat2Questions.TabIndex = 3
        '
        'btnCat2Row5
        '
        Me.btnCat2Row5.BackColor = System.Drawing.Color.Blue
        Me.btnCat2Row5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat2Row5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat2Row5.ForeColor = System.Drawing.Color.Gold
        Me.btnCat2Row5.Location = New System.Drawing.Point(0, 424)
        Me.btnCat2Row5.Name = "btnCat2Row5"
        Me.btnCat2Row5.Size = New System.Drawing.Size(168, 106)
        Me.btnCat2Row5.TabIndex = 30
        Me.btnCat2Row5.Text = "1000"
        Me.btnCat2Row5.UseVisualStyleBackColor = False
        '
        'btnCat2Row4
        '
        Me.btnCat2Row4.BackColor = System.Drawing.Color.Blue
        Me.btnCat2Row4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat2Row4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat2Row4.ForeColor = System.Drawing.Color.Gold
        Me.btnCat2Row4.Location = New System.Drawing.Point(0, 318)
        Me.btnCat2Row4.Name = "btnCat2Row4"
        Me.btnCat2Row4.Size = New System.Drawing.Size(168, 106)
        Me.btnCat2Row4.TabIndex = 29
        Me.btnCat2Row4.Text = "800"
        Me.btnCat2Row4.UseVisualStyleBackColor = False
        '
        'btnCat2Row3
        '
        Me.btnCat2Row3.BackColor = System.Drawing.Color.Blue
        Me.btnCat2Row3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat2Row3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat2Row3.ForeColor = System.Drawing.Color.Gold
        Me.btnCat2Row3.Location = New System.Drawing.Point(0, 212)
        Me.btnCat2Row3.Name = "btnCat2Row3"
        Me.btnCat2Row3.Size = New System.Drawing.Size(168, 106)
        Me.btnCat2Row3.TabIndex = 28
        Me.btnCat2Row3.Text = "600"
        Me.btnCat2Row3.UseVisualStyleBackColor = False
        '
        'btnCat2Row2
        '
        Me.btnCat2Row2.BackColor = System.Drawing.Color.Blue
        Me.btnCat2Row2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat2Row2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat2Row2.ForeColor = System.Drawing.Color.Gold
        Me.btnCat2Row2.Location = New System.Drawing.Point(0, 106)
        Me.btnCat2Row2.Name = "btnCat2Row2"
        Me.btnCat2Row2.Size = New System.Drawing.Size(168, 106)
        Me.btnCat2Row2.TabIndex = 27
        Me.btnCat2Row2.Text = "400"
        Me.btnCat2Row2.UseVisualStyleBackColor = False
        '
        'btnCat2Row1
        '
        Me.btnCat2Row1.BackColor = System.Drawing.Color.Blue
        Me.btnCat2Row1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat2Row1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat2Row1.ForeColor = System.Drawing.Color.Gold
        Me.btnCat2Row1.Location = New System.Drawing.Point(0, 0)
        Me.btnCat2Row1.Name = "btnCat2Row1"
        Me.btnCat2Row1.Size = New System.Drawing.Size(168, 106)
        Me.btnCat2Row1.TabIndex = 26
        Me.btnCat2Row1.Text = "200"
        Me.btnCat2Row1.UseVisualStyleBackColor = False
        '
        'pnlCat3Questions
        '
        Me.pnlCat3Questions.Controls.Add(Me.btnCat3Row5)
        Me.pnlCat3Questions.Controls.Add(Me.btnCat3Row4)
        Me.pnlCat3Questions.Controls.Add(Me.btnCat3Row3)
        Me.pnlCat3Questions.Controls.Add(Me.btnCat3Row2)
        Me.pnlCat3Questions.Controls.Add(Me.btnCat3Row1)
        Me.pnlCat3Questions.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCat3Questions.Location = New System.Drawing.Point(336, 200)
        Me.pnlCat3Questions.Name = "pnlCat3Questions"
        Me.pnlCat3Questions.Size = New System.Drawing.Size(168, 530)
        Me.pnlCat3Questions.TabIndex = 4
        '
        'btnCat3Row5
        '
        Me.btnCat3Row5.BackColor = System.Drawing.Color.Blue
        Me.btnCat3Row5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat3Row5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat3Row5.ForeColor = System.Drawing.Color.Gold
        Me.btnCat3Row5.Location = New System.Drawing.Point(0, 424)
        Me.btnCat3Row5.Name = "btnCat3Row5"
        Me.btnCat3Row5.Size = New System.Drawing.Size(168, 106)
        Me.btnCat3Row5.TabIndex = 31
        Me.btnCat3Row5.Text = "1000"
        Me.btnCat3Row5.UseVisualStyleBackColor = False
        '
        'btnCat3Row4
        '
        Me.btnCat3Row4.BackColor = System.Drawing.Color.Blue
        Me.btnCat3Row4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat3Row4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat3Row4.ForeColor = System.Drawing.Color.Gold
        Me.btnCat3Row4.Location = New System.Drawing.Point(0, 318)
        Me.btnCat3Row4.Name = "btnCat3Row4"
        Me.btnCat3Row4.Size = New System.Drawing.Size(168, 106)
        Me.btnCat3Row4.TabIndex = 30
        Me.btnCat3Row4.Text = "800"
        Me.btnCat3Row4.UseVisualStyleBackColor = False
        '
        'btnCat3Row3
        '
        Me.btnCat3Row3.BackColor = System.Drawing.Color.Blue
        Me.btnCat3Row3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat3Row3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat3Row3.ForeColor = System.Drawing.Color.Gold
        Me.btnCat3Row3.Location = New System.Drawing.Point(0, 212)
        Me.btnCat3Row3.Name = "btnCat3Row3"
        Me.btnCat3Row3.Size = New System.Drawing.Size(168, 106)
        Me.btnCat3Row3.TabIndex = 29
        Me.btnCat3Row3.Text = "600"
        Me.btnCat3Row3.UseVisualStyleBackColor = False
        '
        'btnCat3Row2
        '
        Me.btnCat3Row2.BackColor = System.Drawing.Color.Blue
        Me.btnCat3Row2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat3Row2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat3Row2.ForeColor = System.Drawing.Color.Gold
        Me.btnCat3Row2.Location = New System.Drawing.Point(0, 106)
        Me.btnCat3Row2.Name = "btnCat3Row2"
        Me.btnCat3Row2.Size = New System.Drawing.Size(168, 106)
        Me.btnCat3Row2.TabIndex = 28
        Me.btnCat3Row2.Text = "400"
        Me.btnCat3Row2.UseVisualStyleBackColor = False
        '
        'btnCat3Row1
        '
        Me.btnCat3Row1.BackColor = System.Drawing.Color.Blue
        Me.btnCat3Row1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat3Row1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat3Row1.ForeColor = System.Drawing.Color.Gold
        Me.btnCat3Row1.Location = New System.Drawing.Point(0, 0)
        Me.btnCat3Row1.Name = "btnCat3Row1"
        Me.btnCat3Row1.Size = New System.Drawing.Size(168, 106)
        Me.btnCat3Row1.TabIndex = 27
        Me.btnCat3Row1.Text = "200"
        Me.btnCat3Row1.UseVisualStyleBackColor = False
        '
        'pnlCat4Questions
        '
        Me.pnlCat4Questions.Controls.Add(Me.btnCat4Row5)
        Me.pnlCat4Questions.Controls.Add(Me.btnCat4Row4)
        Me.pnlCat4Questions.Controls.Add(Me.btnCat4Row3)
        Me.pnlCat4Questions.Controls.Add(Me.btnCat4Row2)
        Me.pnlCat4Questions.Controls.Add(Me.btnCat4Row1)
        Me.pnlCat4Questions.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCat4Questions.Location = New System.Drawing.Point(504, 200)
        Me.pnlCat4Questions.Name = "pnlCat4Questions"
        Me.pnlCat4Questions.Size = New System.Drawing.Size(168, 530)
        Me.pnlCat4Questions.TabIndex = 5
        '
        'btnCat4Row5
        '
        Me.btnCat4Row5.BackColor = System.Drawing.Color.Blue
        Me.btnCat4Row5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat4Row5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat4Row5.ForeColor = System.Drawing.Color.Gold
        Me.btnCat4Row5.Location = New System.Drawing.Point(0, 424)
        Me.btnCat4Row5.Name = "btnCat4Row5"
        Me.btnCat4Row5.Size = New System.Drawing.Size(168, 106)
        Me.btnCat4Row5.TabIndex = 32
        Me.btnCat4Row5.Text = "1000"
        Me.btnCat4Row5.UseVisualStyleBackColor = False
        '
        'btnCat4Row4
        '
        Me.btnCat4Row4.BackColor = System.Drawing.Color.Blue
        Me.btnCat4Row4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat4Row4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat4Row4.ForeColor = System.Drawing.Color.Gold
        Me.btnCat4Row4.Location = New System.Drawing.Point(0, 318)
        Me.btnCat4Row4.Name = "btnCat4Row4"
        Me.btnCat4Row4.Size = New System.Drawing.Size(168, 106)
        Me.btnCat4Row4.TabIndex = 31
        Me.btnCat4Row4.Text = "800"
        Me.btnCat4Row4.UseVisualStyleBackColor = False
        '
        'btnCat4Row3
        '
        Me.btnCat4Row3.BackColor = System.Drawing.Color.Blue
        Me.btnCat4Row3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat4Row3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat4Row3.ForeColor = System.Drawing.Color.Gold
        Me.btnCat4Row3.Location = New System.Drawing.Point(0, 212)
        Me.btnCat4Row3.Name = "btnCat4Row3"
        Me.btnCat4Row3.Size = New System.Drawing.Size(168, 106)
        Me.btnCat4Row3.TabIndex = 30
        Me.btnCat4Row3.Text = "600"
        Me.btnCat4Row3.UseVisualStyleBackColor = False
        '
        'btnCat4Row2
        '
        Me.btnCat4Row2.BackColor = System.Drawing.Color.Blue
        Me.btnCat4Row2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat4Row2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat4Row2.ForeColor = System.Drawing.Color.Gold
        Me.btnCat4Row2.Location = New System.Drawing.Point(0, 106)
        Me.btnCat4Row2.Name = "btnCat4Row2"
        Me.btnCat4Row2.Size = New System.Drawing.Size(168, 106)
        Me.btnCat4Row2.TabIndex = 29
        Me.btnCat4Row2.Text = "400"
        Me.btnCat4Row2.UseVisualStyleBackColor = False
        '
        'btnCat4Row1
        '
        Me.btnCat4Row1.BackColor = System.Drawing.Color.Blue
        Me.btnCat4Row1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat4Row1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat4Row1.ForeColor = System.Drawing.Color.Gold
        Me.btnCat4Row1.Location = New System.Drawing.Point(0, 0)
        Me.btnCat4Row1.Name = "btnCat4Row1"
        Me.btnCat4Row1.Size = New System.Drawing.Size(168, 106)
        Me.btnCat4Row1.TabIndex = 28
        Me.btnCat4Row1.Text = "200"
        Me.btnCat4Row1.UseVisualStyleBackColor = False
        '
        'pnlCat5Questions
        '
        Me.pnlCat5Questions.Controls.Add(Me.btnCat5Row5)
        Me.pnlCat5Questions.Controls.Add(Me.btnCat5Row4)
        Me.pnlCat5Questions.Controls.Add(Me.btnCat5Row3)
        Me.pnlCat5Questions.Controls.Add(Me.btnCat5Row2)
        Me.pnlCat5Questions.Controls.Add(Me.btnCat5Row1)
        Me.pnlCat5Questions.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCat5Questions.Location = New System.Drawing.Point(672, 200)
        Me.pnlCat5Questions.Name = "pnlCat5Questions"
        Me.pnlCat5Questions.Size = New System.Drawing.Size(168, 530)
        Me.pnlCat5Questions.TabIndex = 6
        '
        'btnCat5Row5
        '
        Me.btnCat5Row5.BackColor = System.Drawing.Color.Blue
        Me.btnCat5Row5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat5Row5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat5Row5.ForeColor = System.Drawing.Color.Gold
        Me.btnCat5Row5.Location = New System.Drawing.Point(0, 424)
        Me.btnCat5Row5.Name = "btnCat5Row5"
        Me.btnCat5Row5.Size = New System.Drawing.Size(168, 106)
        Me.btnCat5Row5.TabIndex = 33
        Me.btnCat5Row5.Text = "1000"
        Me.btnCat5Row5.UseVisualStyleBackColor = False
        '
        'btnCat5Row4
        '
        Me.btnCat5Row4.BackColor = System.Drawing.Color.Blue
        Me.btnCat5Row4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat5Row4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat5Row4.ForeColor = System.Drawing.Color.Gold
        Me.btnCat5Row4.Location = New System.Drawing.Point(0, 318)
        Me.btnCat5Row4.Name = "btnCat5Row4"
        Me.btnCat5Row4.Size = New System.Drawing.Size(168, 106)
        Me.btnCat5Row4.TabIndex = 32
        Me.btnCat5Row4.Text = "800"
        Me.btnCat5Row4.UseVisualStyleBackColor = False
        '
        'btnCat5Row3
        '
        Me.btnCat5Row3.BackColor = System.Drawing.Color.Blue
        Me.btnCat5Row3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat5Row3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat5Row3.ForeColor = System.Drawing.Color.Gold
        Me.btnCat5Row3.Location = New System.Drawing.Point(0, 212)
        Me.btnCat5Row3.Name = "btnCat5Row3"
        Me.btnCat5Row3.Size = New System.Drawing.Size(168, 106)
        Me.btnCat5Row3.TabIndex = 31
        Me.btnCat5Row3.Text = "600"
        Me.btnCat5Row3.UseVisualStyleBackColor = False
        '
        'btnCat5Row2
        '
        Me.btnCat5Row2.BackColor = System.Drawing.Color.Blue
        Me.btnCat5Row2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat5Row2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat5Row2.ForeColor = System.Drawing.Color.Gold
        Me.btnCat5Row2.Location = New System.Drawing.Point(0, 106)
        Me.btnCat5Row2.Name = "btnCat5Row2"
        Me.btnCat5Row2.Size = New System.Drawing.Size(168, 106)
        Me.btnCat5Row2.TabIndex = 30
        Me.btnCat5Row2.Text = "400"
        Me.btnCat5Row2.UseVisualStyleBackColor = False
        '
        'btnCat5Row1
        '
        Me.btnCat5Row1.BackColor = System.Drawing.Color.Blue
        Me.btnCat5Row1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat5Row1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat5Row1.ForeColor = System.Drawing.Color.Gold
        Me.btnCat5Row1.Location = New System.Drawing.Point(0, 0)
        Me.btnCat5Row1.Name = "btnCat5Row1"
        Me.btnCat5Row1.Size = New System.Drawing.Size(168, 106)
        Me.btnCat5Row1.TabIndex = 29
        Me.btnCat5Row1.Text = "200"
        Me.btnCat5Row1.UseVisualStyleBackColor = False
        '
        'pnlCat6Questions
        '
        Me.pnlCat6Questions.Controls.Add(Me.btnCat6Row5)
        Me.pnlCat6Questions.Controls.Add(Me.btnCat6Row4)
        Me.pnlCat6Questions.Controls.Add(Me.btnCat6Row3)
        Me.pnlCat6Questions.Controls.Add(Me.btnCat6Row2)
        Me.pnlCat6Questions.Controls.Add(Me.btnCat6Row1)
        Me.pnlCat6Questions.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCat6Questions.Location = New System.Drawing.Point(840, 200)
        Me.pnlCat6Questions.Name = "pnlCat6Questions"
        Me.pnlCat6Questions.Size = New System.Drawing.Size(168, 530)
        Me.pnlCat6Questions.TabIndex = 7
        '
        'btnCat6Row5
        '
        Me.btnCat6Row5.BackColor = System.Drawing.Color.Blue
        Me.btnCat6Row5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat6Row5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat6Row5.ForeColor = System.Drawing.Color.Gold
        Me.btnCat6Row5.Location = New System.Drawing.Point(0, 424)
        Me.btnCat6Row5.Name = "btnCat6Row5"
        Me.btnCat6Row5.Size = New System.Drawing.Size(168, 106)
        Me.btnCat6Row5.TabIndex = 34
        Me.btnCat6Row5.Text = "1000"
        Me.btnCat6Row5.UseVisualStyleBackColor = False
        '
        'btnCat6Row4
        '
        Me.btnCat6Row4.BackColor = System.Drawing.Color.Blue
        Me.btnCat6Row4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat6Row4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat6Row4.ForeColor = System.Drawing.Color.Gold
        Me.btnCat6Row4.Location = New System.Drawing.Point(0, 318)
        Me.btnCat6Row4.Name = "btnCat6Row4"
        Me.btnCat6Row4.Size = New System.Drawing.Size(168, 106)
        Me.btnCat6Row4.TabIndex = 33
        Me.btnCat6Row4.Text = "800"
        Me.btnCat6Row4.UseVisualStyleBackColor = False
        '
        'btnCat6Row3
        '
        Me.btnCat6Row3.BackColor = System.Drawing.Color.Blue
        Me.btnCat6Row3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat6Row3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat6Row3.ForeColor = System.Drawing.Color.Gold
        Me.btnCat6Row3.Location = New System.Drawing.Point(0, 212)
        Me.btnCat6Row3.Name = "btnCat6Row3"
        Me.btnCat6Row3.Size = New System.Drawing.Size(168, 106)
        Me.btnCat6Row3.TabIndex = 32
        Me.btnCat6Row3.Text = "600"
        Me.btnCat6Row3.UseVisualStyleBackColor = False
        '
        'btnCat6Row2
        '
        Me.btnCat6Row2.BackColor = System.Drawing.Color.Blue
        Me.btnCat6Row2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat6Row2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat6Row2.ForeColor = System.Drawing.Color.Gold
        Me.btnCat6Row2.Location = New System.Drawing.Point(0, 106)
        Me.btnCat6Row2.Name = "btnCat6Row2"
        Me.btnCat6Row2.Size = New System.Drawing.Size(168, 106)
        Me.btnCat6Row2.TabIndex = 31
        Me.btnCat6Row2.Text = "400"
        Me.btnCat6Row2.UseVisualStyleBackColor = False
        '
        'btnCat6Row1
        '
        Me.btnCat6Row1.BackColor = System.Drawing.Color.Blue
        Me.btnCat6Row1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCat6Row1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat6Row1.ForeColor = System.Drawing.Color.Gold
        Me.btnCat6Row1.Location = New System.Drawing.Point(0, 0)
        Me.btnCat6Row1.Name = "btnCat6Row1"
        Me.btnCat6Row1.Size = New System.Drawing.Size(168, 106)
        Me.btnCat6Row1.TabIndex = 30
        Me.btnCat6Row1.Text = "200"
        Me.btnCat6Row1.UseVisualStyleBackColor = False
        '
        'frmJeopardy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.pnlCat6Questions)
        Me.Controls.Add(Me.pnlCat5Questions)
        Me.Controls.Add(Me.pnlCat4Questions)
        Me.Controls.Add(Me.pnlCat3Questions)
        Me.Controls.Add(Me.pnlCat2Questions)
        Me.Controls.Add(Me.pnlCat1Questions)
        Me.Controls.Add(Me.pnlCategoryPanel)
        Me.Controls.Add(Me.pnlScorePanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJeopardy"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Jeopardy: Army Board Edition"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlScorePanel.ResumeLayout(False)
        Me.pnlCategoryPanel.ResumeLayout(False)
        Me.pnlCat1Questions.ResumeLayout(False)
        Me.pnlCat2Questions.ResumeLayout(False)
        Me.pnlCat3Questions.ResumeLayout(False)
        Me.pnlCat4Questions.ResumeLayout(False)
        Me.pnlCat5Questions.ResumeLayout(False)
        Me.pnlCat6Questions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlScorePanel As System.Windows.Forms.Panel
    Friend WithEvents pnlCategoryPanel As System.Windows.Forms.Panel
    Friend WithEvents rtbTeam3Score As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbTeam2Score As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbTeam1Score As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbCategory6 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbCategory5 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbCategory4 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbCategory3 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbCategory2 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbCategory1 As System.Windows.Forms.RichTextBox
    Friend WithEvents pnlCat1Questions As System.Windows.Forms.Panel
    Friend WithEvents btnCat1Row5 As System.Windows.Forms.Button
    Friend WithEvents btnCat1Row4 As System.Windows.Forms.Button
    Friend WithEvents btnCat1Row3 As System.Windows.Forms.Button
    Friend WithEvents btnCat1Row2 As System.Windows.Forms.Button
    Friend WithEvents btnCat1Row1 As System.Windows.Forms.Button
    Friend WithEvents pnlCat2Questions As System.Windows.Forms.Panel
    Friend WithEvents btnCat2Row5 As System.Windows.Forms.Button
    Friend WithEvents btnCat2Row4 As System.Windows.Forms.Button
    Friend WithEvents btnCat2Row3 As System.Windows.Forms.Button
    Friend WithEvents btnCat2Row2 As System.Windows.Forms.Button
    Friend WithEvents btnCat2Row1 As System.Windows.Forms.Button
    Friend WithEvents pnlCat3Questions As System.Windows.Forms.Panel
    Friend WithEvents btnCat3Row5 As System.Windows.Forms.Button
    Friend WithEvents btnCat3Row4 As System.Windows.Forms.Button
    Friend WithEvents btnCat3Row3 As System.Windows.Forms.Button
    Friend WithEvents btnCat3Row2 As System.Windows.Forms.Button
    Friend WithEvents btnCat3Row1 As System.Windows.Forms.Button
    Friend WithEvents pnlCat4Questions As System.Windows.Forms.Panel
    Friend WithEvents btnCat4Row5 As System.Windows.Forms.Button
    Friend WithEvents btnCat4Row4 As System.Windows.Forms.Button
    Friend WithEvents btnCat4Row3 As System.Windows.Forms.Button
    Friend WithEvents btnCat4Row2 As System.Windows.Forms.Button
    Friend WithEvents btnCat4Row1 As System.Windows.Forms.Button
    Friend WithEvents pnlCat5Questions As System.Windows.Forms.Panel
    Friend WithEvents btnCat5Row5 As System.Windows.Forms.Button
    Friend WithEvents btnCat5Row4 As System.Windows.Forms.Button
    Friend WithEvents btnCat5Row3 As System.Windows.Forms.Button
    Friend WithEvents btnCat5Row2 As System.Windows.Forms.Button
    Friend WithEvents btnCat5Row1 As System.Windows.Forms.Button
    Friend WithEvents pnlCat6Questions As System.Windows.Forms.Panel
    Friend WithEvents btnCat6Row5 As System.Windows.Forms.Button
    Friend WithEvents btnCat6Row4 As System.Windows.Forms.Button
    Friend WithEvents btnCat6Row3 As System.Windows.Forms.Button
    Friend WithEvents btnCat6Row2 As System.Windows.Forms.Button
    Friend WithEvents btnCat6Row1 As System.Windows.Forms.Button
End Class
