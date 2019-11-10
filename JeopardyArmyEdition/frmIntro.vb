Public Class frmIntro

    Private Sub frmIntro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' plays audio when the form opens
        My.Computer.Audio.Play(My.Resources.jeopardy_intro, AudioPlayMode.Background)
    End Sub

    Private Sub btnMutePlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMutePlay.Click
        'stops audio if audio is playing (based on button text), plays audio if audio is not playing (based on button text)
        If btnMutePlay.Text.Equals("Mute") Then
            My.Computer.Audio.Stop()
            btnMutePlay.Text = "play"
        ElseIf btnMutePlay.Text.Equals("play") Then
            My.Computer.Audio.Play(My.Resources.jeopardy_intro, AudioPlayMode.Background)
            btnMutePlay.Text = "mute"
        Else
            My.Computer.Audio.Stop()
            btnMutePlay.Text = "play"

        End If
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        'hides the current form, stops audio, and opens the first round of the game
        My.Computer.Audio.Stop()
        Me.Hide()
        My.Forms.frmJeopardy.ShowDialog()
    End Sub
End Class