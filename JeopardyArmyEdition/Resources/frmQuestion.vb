Public Class frmQuestion

    Dim strQuestion As String = frmJeopardy.strCurrentQuestion
    Dim intGameClock As Integer = 100
    Dim intPlayerClock As Integer = 100
    Dim intBuzzCount As Integer = 0
    Dim intCurrentBuzzer As Integer
    Dim bolPlayerMode As Boolean

    Private Sub frmQuestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intBuzzCount = 0
        intCurrentBuzzer = 0
        intGameClock = 100
        intPlayerClock = 100
        rtbQuestionAndAnswer.Text = strQuestion
        tmrMain.Start()
        btnStop.Visible = False
        bolPlayerMode = False
    End Sub

    Private Sub btnTeam1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeam1.Click
        intPlayerClock = 100
        intCurrentBuzzer = 1
        btnStop.Visible = True
        bolPlayerMode = True
    End Sub

    Private Sub btnTeam2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeam2.Click
        intPlayerClock = 100
        intCurrentBuzzer = 2
        btnStop.Visible = True
        bolPlayerMode = True
    End Sub

    Private Sub btnTeam3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeam3.Click
        intPlayerClock = 100
        intCurrentBuzzer = 3
        btnStop.Visible = True
        bolPlayerMode = True
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tmrMain.Stop()
        btnStop.Visible = False
        btnCorrect.Visible = True
        btnIncorrect.Visible = True
    End Sub

    Private Sub btnCorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click
        tmrMain.Stop()
        btnCorrect.Visible = False
        btnIncorrect.Visible = False
        frmJeopardy.Show()
        Me.Hide()
    End Sub

    Private Sub btnIncorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncorrect.Click
        If intBuzzCount = 3 Then
            tmrMain.Stop()
            frmJeopardy.Show()
            Me.Hide()
        Else
            If intCurrentBuzzer = 1 Then
                btnTeam1.Visible = False
                bolPlayerMode = False
                tmrMain.Start()
            ElseIf intCurrentBuzzer = 2 Then
                btnTeam2.Visible = False
                bolPlayerMode = False
                tmrMain.Start()
            ElseIf intCurrentBuzzer = 3 Then
                btnTeam3.Visible = False
                bolPlayerMode = False
                tmrMain.Start()
            End If
        End If
    End Sub

    Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
        If bolPlayerMode = False Then
            tmrMain.Interval = 100
            pbrGameClock.Value = intGameClock
            intGameClock -= 1
            If intGameClock = 0 Then
                tmrMain.Stop()
                frmJeopardy.Show()
                Me.Hide()
            End If
        ElseIf bolPlayerMode = True Then
            tmrMain.Interval = 20
            pbrGameClock.Value = intPlayerClock
            intPlayerClock -= 1
            If intPlayerClock = 0 Then
                If intBuzzCount = 3 Then
                    tmrMain.Stop()
                    frmJeopardy.Show()
                    Me.Hide()
                Else
                    If intCurrentBuzzer = 1 Then
                        btnTeam1.Visible = False
                        bolPlayerMode = False
                    ElseIf intCurrentBuzzer = 2 Then
                        btnTeam2.Visible = False
                        bolPlayerMode = False
                    ElseIf intCurrentBuzzer = 3 Then
                        btnTeam3.Visible = False
                        bolPlayerMode = False
                    End If
                End If
            End If
        End If

    End Sub
End Class
