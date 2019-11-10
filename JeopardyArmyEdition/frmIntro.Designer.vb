<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntro))
        Me.btnMutePlay = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMutePlay
        '
        Me.btnMutePlay.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMutePlay.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMutePlay.Location = New System.Drawing.Point(0, 0)
        Me.btnMutePlay.Name = "btnMutePlay"
        Me.btnMutePlay.Size = New System.Drawing.Size(1008, 23)
        Me.btnMutePlay.TabIndex = 0
        Me.btnMutePlay.Text = "Mute"
        Me.btnMutePlay.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnContinue.Location = New System.Drawing.Point(0, 23)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(1008, 23)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'frmIntro
        '
        Me.AcceptButton = Me.btnContinue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JeopardyArmyEdition.My.Resources.Resources.jeopardyARMY
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnMutePlay
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnMutePlay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIntro"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Jeopardy: Army Board Edition"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMutePlay As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
End Class
