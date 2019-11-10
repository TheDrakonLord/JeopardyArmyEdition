Public Class frmDailyDouble
    Dim intCurrentBet As Integer
    Dim strQuestion As String = frmJeopardy.strCurrentQuestion
    Private Sub frmDailyDouble_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.jeopardy_Daily_Double, AudioPlayMode.Background)
        rtbQuestionAndAnswer.Text = "DAILY DOUBLE! Set your wager"
        btnCorrect.Visible = False
        btnIncorrect.Visible = False
        btnSetBet.Visible = True
        txtBet.Visible = True
    End Sub

    Private Sub btnSetBet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetBet.Click

        If IsNumeric(txtBet.Text) Then
            intCurrentBet = txtBet.Text
            rtbQuestionAndAnswer.Text = strQuestion
            txtBet.Visible = False
            btnSetBet.Visible = False
            btnCorrect.Visible = True
            btnIncorrect.Visible = True
        Else
            MessageBox.Show("your bet must be a intger number", "invalid bet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnCorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click
        frmJeopardy.Show()
        Me.Hide()

    End Sub

    Private Sub btnIncorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncorrect.Click
        frmJeopardy.Show()
        Me.Hide()
    End Sub

  
End Class