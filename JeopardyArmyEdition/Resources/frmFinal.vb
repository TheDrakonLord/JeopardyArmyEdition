Public Class frmFinal
    Dim strQuestion As String = frmJeopardy.strCurrentQuestion
    Dim strCategory As String = strCatNames(frmJeopardy.intCat13)
    Dim bolComplete As Boolean
    Dim bolTeam1Correct As Boolean
    Dim bolTeam2Correct As Boolean
    Dim bolTeam3correct As Boolean


    Dim intWidth As Integer
    Dim dblQuarterWidth As Double
    Dim intPanelhight As Integer
    Dim dblThirdWidth As Double

    Private Sub frmFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intWidth = pnlLower.Width()
        dblQuarterWidth = intWidth / 4
        intPanelhight = pnlLower.Height
        btnStart.Height = intPanelhight
        btnStart.Width = dblQuarterWidth
        pnlTeam1.Height = intPanelhight
        pnlTeam1.Width = dblQuarterWidth
        pnlTeam2.Height = intPanelhight
        pnlTeam2.Width = dblQuarterWidth
        pnlTeam3.Height = intPanelhight
        pnlTeam3.Width = dblQuarterWidth

        dblThirdWidth = intWidth / 3
        rtbTeam1Bet.Width = dblThirdWidth
        rtbTeam2Bet.Width = dblThirdWidth
        rtbTeam3Bet.Width = dblThirdWidth


        bolComplete = False
        bolTeam1Correct = False
        bolTeam2Correct = False
        bolTeam3correct = False
        rtbQuestionAndAnswer.Text = strCategory
        radTeam1Correct.Visible = False
        radTeam2Correct.Visible = False
        radTeam3Correct.Visible = False
        radTeam1Incorrect.Visible = False
        radTeam2Incorrect.Visible = False
        radTeam3Incorrect.Visible = False

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If bolComplete Then
            frmEnd.Show()
            Me.Hide()
        Else
            rtbQuestionAndAnswer.Text = strQuestion
            radTeam1Correct.Visible = True
            radTeam2Correct.Visible = True
            radTeam3Correct.Visible = True
            radTeam1Incorrect.Visible = True
            radTeam2Incorrect.Visible = True
            radTeam3Incorrect.Visible = True
            btnStart.Text = "Finish"
            rtbTeam1Bet.ReadOnly = True
            rtbTeam2Bet.ReadOnly = True
            rtbTeam3Bet.ReadOnly = True
            bolComplete = True
            My.Computer.Audio.Play(My.Resources.jeopardy_think, AudioPlayMode.Background)
            
        End If
        
    End Sub

End Class