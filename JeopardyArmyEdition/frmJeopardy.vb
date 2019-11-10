Public Class frmJeopardy
    Dim intCatNum As Integer
    Public intCat1 As Integer
    Public intCat2 As Integer
    Public intCat3 As Integer
    Public intCat4 As Integer
    Public intCat5 As Integer
    Public intCat6 As Integer
    Public intCat7 As Integer
    Public intCat8 As Integer
    Public intCat9 As Integer
    Public intCat10 As Integer
    Public intCat11 As Integer
    Public intCat12 As Integer
    Public intCat13 As Integer
    Public strCat1(,) As String
    Public strCat2(,) As String
    Public strCat3(,) As String
    Public strCat4(,) As String
    Public strCat5(,) As String
    Public strCat6(,) As String
    Public strCat7(,) As String
    Public strCat8(,) As String
    Public strCat9(,) As String
    Public strCat10(,) As String
    Public strCat11(,) As String
    Public strCat12(,) As String
    Public strCat13(,) As String
    Public strCurrentQuestion As String
    Public strCurrentAnswer As String
    Dim rand As New Random

    Private Sub frmJeopardy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.jeopardy_board_fill, AudioPlayMode.Background)
        'declares variables used in loading
        Dim intWidth As Integer
        Dim dblThirdWidth As Double
        Dim intPanelhight As Integer

        'maximizes the window
        Me.WindowState = FormWindowState.Maximized

        'spaces the team score boxes evenly based on the heigth and width of the score panel

        'calculates the width of the panel and divides it based on the number of boxes (3)
        intWidth = pnlScorePanel.Width
        dblThirdWidth = intWidth / 3

        'sets the calcualted width
        rtbTeam1Score.Width = dblThirdWidth
        rtbTeam2Score.Width = dblThirdWidth
        rtbTeam3Score.Width = dblThirdWidth

        'sets the calculated heigth
        intPanelhight = pnlScorePanel.Height
        rtbTeam1Score.Height = intPanelhight
        rtbTeam2Score.Height = intPanelhight
        rtbTeam3Score.Height = intPanelhight

        'center aligns all the team score boxes
        rtbTeam1Score.SelectionAlignment = HorizontalAlignment.Center
        rtbTeam2Score.SelectionAlignment = HorizontalAlignment.Center
        rtbTeam3Score.SelectionAlignment = HorizontalAlignment.Center

        'spaces the category boxes based on the heigth and width of the category panel

        'calcualtes the width of the panel and divides it based on the number of boxes (6)
        intWidth = pnlCategoryPanel.Width
        dblThirdWidth = intWidth / 6

        'sets the calculated width
        rtbCategory1.Width = dblThirdWidth
        rtbCategory2.Width = dblThirdWidth
        rtbCategory3.Width = dblThirdWidth
        rtbCategory4.Width = dblThirdWidth
        rtbCategory5.Width = dblThirdWidth
        rtbCategory6.Width = dblThirdWidth

        'sets the calculated heigth
        intPanelhight = pnlCategoryPanel.Height
        rtbCategory1.Height = intPanelhight
        rtbCategory2.Height = intPanelhight
        rtbCategory3.Height = intPanelhight
        rtbCategory4.Height = intPanelhight
        rtbCategory5.Height = intPanelhight
        rtbCategory6.Height = intPanelhight

        'center aligns all the category boxes
        rtbCategory1.SelectionAlignment = HorizontalAlignment.Center
        rtbCategory2.SelectionAlignment = HorizontalAlignment.Center
        rtbCategory3.SelectionAlignment = HorizontalAlignment.Center
        rtbCategory4.SelectionAlignment = HorizontalAlignment.Center
        rtbCategory5.SelectionAlignment = HorizontalAlignment.Center
        rtbCategory6.SelectionAlignment = HorizontalAlignment.Center


        'calcualates and assigns question area heights and widths and distributes it evenly
        'creates new variables to calcualte questions dimensions
        Dim intheigth As Integer
        Dim dblfifthheigth As Double

        'calculates question dimensions
        intheigth = pnlCat6Questions.Height
        dblfifthheigth = intheigth / 5

        'assigns question dimensions
        btnCat1Row1.Height = dblfifthheigth
        btnCat1Row2.Height = dblfifthheigth
        btnCat1Row3.Height = dblfifthheigth
        btnCat1Row4.Height = dblfifthheigth
        btnCat1Row5.Height = dblfifthheigth
        btnCat2Row1.Height = dblfifthheigth
        btnCat2Row2.Height = dblfifthheigth
        btnCat2Row3.Height = dblfifthheigth
        btnCat2Row4.Height = dblfifthheigth
        btnCat2Row5.Height = dblfifthheigth
        btnCat3Row1.Height = dblfifthheigth
        btnCat3Row2.Height = dblfifthheigth
        btnCat3Row3.Height = dblfifthheigth
        btnCat3Row4.Height = dblfifthheigth
        btnCat3Row5.Height = dblfifthheigth
        btnCat4Row1.Height = dblfifthheigth
        btnCat4Row2.Height = dblfifthheigth
        btnCat4Row3.Height = dblfifthheigth
        btnCat4Row4.Height = dblfifthheigth
        btnCat4Row5.Height = dblfifthheigth
        btnCat5Row1.Height = dblfifthheigth
        btnCat5Row2.Height = dblfifthheigth
        btnCat5Row3.Height = dblfifthheigth
        btnCat5Row4.Height = dblfifthheigth
        btnCat5Row5.Height = dblfifthheigth
        btnCat6Row1.Height = dblfifthheigth
        btnCat6Row2.Height = dblfifthheigth
        btnCat6Row3.Height = dblfifthheigth
        btnCat6Row4.Height = dblfifthheigth
        btnCat6Row5.Height = dblfifthheigth

        'assigns question dimensions
        pnlCat1Questions.Width = dblThirdWidth
        pnlCat2Questions.Width = dblThirdWidth
        pnlCat3Questions.Width = dblThirdWidth
        pnlCat4Questions.Width = dblThirdWidth
        pnlCat5Questions.Width = dblThirdWidth
        pnlCat6Questions.Width = dblThirdWidth


        'adds additional question variables
        Dim dblQuestHeight As Double

        'calculates the heigth of the question area
        dblQuestHeight = Me.Height - (pnlCategoryPanel.Height + pnlScorePanel.Height)


        'assigns question area height
        pnlCat1Questions.Height = dblQuestHeight
        pnlCat2Questions.Height = dblQuestHeight
        pnlCat3Questions.Height = dblQuestHeight
        pnlCat4Questions.Height = dblQuestHeight
        pnlCat5Questions.Height = dblQuestHeight
        pnlCat6Questions.Height = dblQuestHeight

        rtbCategory1.SelectionAlignment = HorizontalAlignment.Center
        rtbCategory2.SelectionAlignment = HorizontalAlignment.Center
        rtbCategory3.SelectionAlignment = HorizontalAlignment.Center
        rtbCategory4.SelectionAlignment = HorizontalAlignment.Center
        rtbCategory5.SelectionAlignment = HorizontalAlignment.Center
        rtbCategory6.SelectionAlignment = HorizontalAlignment.Center





        intCatNum = strCatNames.Length
        intCat1 = rand.Next(intCatNum)
        intCat2 = rand.Next(intCatNum)
        intCat3 = rand.Next(intCatNum)
        intCat4 = rand.Next(intCatNum)
        intCat5 = rand.Next(intCatNum)
        intCat6 = rand.Next(intCatNum)
        intCat7 = rand.Next(intCatNum)
        intCat8 = rand.Next(intCatNum)
        intCat9 = rand.Next(intCatNum)
        intCat10 = rand.Next(intCatNum)
        intCat11 = rand.Next(intCatNum)
        intCat12 = rand.Next(intCatNum)
        intCat13 = rand.Next(intCatNum)




        Dim bolDoubleCheck As Boolean
        Do
            If intCat1 = intCat2 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat3 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat4 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat5 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat6 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat7 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat8 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat9 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat10 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat11 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat12 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat1 = intCat13 Then
                intCat1 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat3 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat4 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat5 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat6 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat7 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat8 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat9 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat10 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat11 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat12 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat2 = intCat13 Then
                intCat2 = rand.Next(intCatNum)
            End If
            If intCat3 = intCat4 Then
                intCat3 = rand.Next(intCatNum)
            End If
            If intCat3 = intCat5 Then
                intCat3 = rand.Next(intCatNum)
            End If
            If intCat3 = intCat6 Then
                intCat3 = rand.Next(intCatNum)
            End If
            If intCat3 = intCat7 Then
                intCat3 = rand.Next(intCatNum)
            End If
            If intCat3 = intCat8 Then
                intCat3 = rand.Next(intCatNum)
            End If
            If intCat3 = intCat9 Then
                intCat3 = rand.Next(intCatNum)
            End If
            If intCat3 = intCat10 Then
                intCat3 = rand.Next(intCatNum)
            End If
            If intCat3 = intCat11 Then
                intCat3 = rand.Next(intCatNum)
            End If
            If intCat3 = intCat12 Then
                intCat3 = rand.Next(intCatNum)
            End If
            If intCat3 = intCat13 Then
                intCat3 = rand.Next(intCatNum)
            End If
            If intCat4 = intCat5 Then
                intCat4 = rand.Next(intCatNum)
            End If
            If intCat4 = intCat6 Then
                intCat4 = rand.Next(intCatNum)
            End If
            If intCat4 = intCat7 Then
                intCat4 = rand.Next(intCatNum)
            End If
            If intCat4 = intCat8 Then
                intCat4 = rand.Next(intCatNum)
            End If
            If intCat4 = intCat9 Then
                intCat4 = rand.Next(intCatNum)
            End If
            If intCat4 = intCat10 Then
                intCat4 = rand.Next(intCatNum)
            End If
            If intCat4 = intCat11 Then
                intCat4 = rand.Next(intCatNum)
            End If
            If intCat4 = intCat12 Then
                intCat4 = rand.Next(intCatNum)
            End If
            If intCat4 = intCat13 Then
                intCat4 = rand.Next(intCatNum)
            End If
            If intCat5 = intCat6 Then
                intCat5 = rand.Next(intCatNum)
            End If
            If intCat5 = intCat7 Then
                intCat5 = rand.Next(intCatNum)
            End If
            If intCat5 = intCat8 Then
                intCat5 = rand.Next(intCatNum)
            End If
            If intCat5 = intCat9 Then
                intCat5 = rand.Next(intCatNum)
            End If
            If intCat5 = intCat10 Then
                intCat5 = rand.Next(intCatNum)
            End If
            If intCat5 = intCat11 Then
                intCat5 = rand.Next(intCatNum)
            End If
            If intCat5 = intCat12 Then
                intCat5 = rand.Next(intCatNum)
            End If
            If intCat5 = intCat13 Then
                intCat5 = rand.Next(intCatNum)
            End If
            If intCat6 = intCat7 Then
                intCat6 = rand.Next(intCatNum)
            End If
            If intCat6 = intCat8 Then
                intCat6 = rand.Next(intCatNum)
            End If
            If intCat6 = intCat9 Then
                intCat6 = rand.Next(intCatNum)
            End If
            If intCat6 = intCat10 Then
                intCat6 = rand.Next(intCatNum)
            End If
            If intCat6 = intCat11 Then
                intCat6 = rand.Next(intCatNum)
            End If
            If intCat6 = intCat12 Then
                intCat6 = rand.Next(intCatNum)
            End If
            If intCat6 = intCat13 Then
                intCat6 = rand.Next(intCatNum)
            End If
            If intCat7 = intCat8 Then
                intCat7 = rand.Next(intCatNum)
            End If
            If intCat7 = intCat9 Then
                intCat7 = rand.Next(intCatNum)
            End If
            If intCat7 = intCat10 Then
                intCat7 = rand.Next(intCatNum)
            End If
            If intCat7 = intCat11 Then
                intCat7 = rand.Next(intCatNum)
            End If
            If intCat7 = intCat12 Then
                intCat7 = rand.Next(intCatNum)
            End If
            If intCat7 = intCat13 Then
                intCat7 = rand.Next(intCatNum)
            End If
            If intCat8 = intCat9 Then
                intCat8 = rand.Next(intCatNum)
            End If
            If intCat8 = intCat10 Then
                intCat8 = rand.Next(intCatNum)
            End If
            If intCat8 = intCat11 Then
                intCat8 = rand.Next(intCatNum)
            End If
            If intCat8 = intCat12 Then
                intCat8 = rand.Next(intCatNum)
            End If
            If intCat8 = intCat13 Then
                intCat8 = rand.Next(intCatNum)
            End If
            If intCat9 = intCat10 Then
                intCat9 = rand.Next(intCatNum)
            End If
            If intCat9 = intCat11 Then
                intCat9 = rand.Next(intCatNum)
            End If
            If intCat9 = intCat12 Then
                intCat9 = rand.Next(intCatNum)
            End If
            If intCat9 = intCat13 Then
                intCat9 = rand.Next(intCatNum)
            End If
            If intCat10 = intCat11 Then
                intCat10 = rand.Next(intCatNum)
            End If
            If intCat10 = intCat12 Then
                intCat10 = rand.Next(intCatNum)
            End If
            If intCat10 = intCat13 Then
                intCat10 = rand.Next(intCatNum)
            End If
            If intCat11 = intCat12 Then
                intCat11 = rand.Next(intCatNum)
            End If
            If intCat11 = intCat13 Then
                intCat11 = rand.Next(intCatNum)
            End If
            If intCat12 = intCat13 Then
                intCat12 = rand.Next(intCatNum)
            End If

            If intCat1 <> intCat2 And intCat1 <> intCat3 And intCat1 <> intCat4 And intCat1 <> intCat5 And intCat1 <> intCat6 And intCat1 <> intCat7 And intCat1 <> intCat8 And intCat1 <> intCat9 And intCat1 <> intCat10 And intCat1 <> intCat11 And intCat1 <> intCat12 And intCat1 <> intCat13 And intCat2 <> intCat3 And intCat2 <> intCat4 And intCat2 <> intCat5 And intCat2 <> intCat6 And intCat2 <> intCat7 And intCat2 <> intCat8 And intCat2 <> intCat9 And intCat2 <> intCat10 And intCat2 <> intCat11 And intCat2 <> intCat12 And intCat2 <> intCat13 And intCat3 <> intCat4 And intCat3 <> intCat5 And intCat3 <> intCat6 And intCat3 <> intCat7 And intCat3 <> intCat8 And intCat3 <> intCat9 And intCat3 <> intCat10 And intCat3 <> intCat11 And intCat3 <> intCat12 And intCat3 <> intCat13 And intCat4 <> intCat5 And intCat4 <> intCat6 And intCat4 <> intCat7 And intCat4 <> intCat8 And intCat4 <> intCat9 And intCat4 <> intCat10 And intCat4 <> intCat11 And intCat4 <> intCat12 And intCat4 <> intCat13 And intCat5 <> intCat6 And intCat5 <> intCat7 And intCat5 <> intCat8 And intCat5 <> intCat9 And intCat5 <> intCat10 And intCat5 <> intCat11 And intCat5 <> intCat12 And intCat5 <> intCat13 And intCat6 <> intCat7 And intCat6 <> intCat8 And intCat6 <> intCat9 And intCat6 <> intCat10 And intCat6 <> intCat11 And intCat6 <> intCat12 And intCat6 <> intCat13 And intCat7 <> intCat8 And intCat7 <> intCat9 And intCat7 <> intCat10 And intCat7 <> intCat11 And intCat7 <> intCat12 And intCat7 <> intCat13 And intCat8 <> intCat9 And intCat8 <> intCat10 And intCat8 <> intCat11 And intCat8 <> intCat12 And intCat8 <> intCat13 And intCat9 <> intCat10 And intCat9 <> intCat11 And intCat9 <> intCat12 And intCat9 <> intCat13 And intCat10 <> intCat11 And intCat10 <> intCat12 And intCat10 <> intCat13 And intCat11 <> intCat12 And intCat11 <> intCat13 And intCat12 <> intCat13 Then
                bolDoubleCheck = True

            Else
                bolDoubleCheck = False

            End If
        Loop Until bolDoubleCheck





        rtbCategory1.Text = strCatNames(intCat1)
        rtbCategory2.Text = strCatNames(intCat2)
        rtbCategory3.Text = strCatNames(intCat3)
        rtbCategory4.Text = strCatNames(intCat4)
        rtbCategory5.Text = strCatNames(intCat5)
        rtbCategory6.Text = strCatNames(intCat6)


        strCat1 = objCatIndex(0)
        ' strCat1 = objCatIndex(intCat1)
        'strCat2 = objCatIndex(intCat2)
        'strCat3 = objCatIndex(intCat3)
        'strCat4 = objCatIndex(intCat4)
        'strCat5 = objCatIndex(intCat5)
        'strCat6 = objCatIndex(intCat6)
        'strCat7 = objCatIndex(intCat7)
        'strCat8 = objCatIndex(intCat8)
        'strCat9 = objCatIndex(intCat9)
        'strCat10 = objCatIndex(intCat10)
        'strCat11 = objCatIndex(intCat11)
        'strCat12 = objCatIndex(intCat12)
        'strCat13 = objCatIndex(intCat13)
        If bolTestMode Then
            MessageBox.Show(intCat1.ToString + "," + intCat2.ToString + "," + intCat3.ToString + "," + intCat4.ToString + "," + intCat5.ToString + "," + intCat6.ToString + "," + intCat7.ToString + "," + intCat8.ToString + "," + intCat9.ToString + "," + intCat10.ToString + "," + intCat11.ToString + "," + intCat12.ToString + "," + intCat13.ToString, bolDoubleCheck.ToString)
            strCat1 = objCatIndex(0)
        End If


    End Sub




    Private Sub btnCat1Row1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat1Row1.Click
        If bolTestMode Then
            rtbCategory1.Text = strCatNames(intCat7)
            rtbCategory2.Text = strCatNames(intCat8)
            rtbCategory3.Text = strCatNames(intCat9)
            rtbCategory4.Text = strCatNames(intCat10)
            rtbCategory5.Text = strCatNames(intCat11)
            rtbCategory6.Text = strCatNames(intCat12)
        End If

    End Sub

    Private Sub btnCat2Row1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat2Row1.Click
        If bolTestMode Then
            rtbCategory1.Text = strCatNames(intCat13)
            rtbCategory2.Text = "final"
            rtbCategory3.Text = "final"
            rtbCategory4.Text = "final"
            rtbCategory5.Text = "final"
            rtbCategory6.Text = "final"
        End If

    End Sub

    Private Sub btnCat3Row1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat3Row1.Click
        If bolTestMode Then
            rtbCategory1.Text = strCatNames(intCat1)
            rtbCategory2.Text = strCatNames(intCat2)
            rtbCategory3.Text = strCatNames(intCat3)
            rtbCategory4.Text = strCatNames(intCat4)
            rtbCategory5.Text = strCatNames(intCat5)
            rtbCategory6.Text = strCatNames(intCat6)
        End If

    End Sub

    Private Sub btnCat1Row2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat1Row2.Click
        If bolTestMode Then
            strCurrentQuestion = strCat1(0, 3)
            strCurrentAnswer = strCat1(1, 3)



            Me.Hide()
            frmQuestion.ShowDialog()

        Else
            Me.Hide()
            frmQuestion.ShowDialog()

        End If
    End Sub

    Private Sub btnCat2Row2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat2Row2.Click
        If bolTestMode Then
            strCurrentQuestion = strCat1(0, 3)
            strCurrentAnswer = strCat1(1, 3)



            Me.Hide()
            frmDailyDouble.ShowDialog()

        Else
            Me.Hide()
            frmDailyDouble.ShowDialog()

        End If
    End Sub

    Private Sub btnCat3Row2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat3Row2.Click
        If bolTestMode Then
            strCurrentQuestion = strCat1(0, 3)
            strCurrentAnswer = strCat1(1, 3)



            Me.Hide()
            frmFinal.ShowDialog()

        Else
            Me.Hide()
            frmFinal.ShowDialog()

        End If
    End Sub
End Class