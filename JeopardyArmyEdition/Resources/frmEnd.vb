
Public Class frmEnd
    Dim intWidth As Integer
    Dim dblThridWidht As Double

    Private Sub frmEnd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intWidth = btnExit.Width
        dblThridWidht = intWidth / 3
        rtbTeam1Score.Width = dblThridWidht
        rtbTeam2Score.Width = dblThridWidht
        rtbTeam3Score.Width = dblThridWidht

        My.Computer.Audio.Play(My.Resources.jeopardy_intro, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class