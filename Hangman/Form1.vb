Public Class Form1
    Private answers_word_list() As String
    Private score1_list() As String                '  the global variables being used 
    Private answers_word As String
    Private questions_word_list() As String
    Private questions_word As String
    Private hints_word_list() As String
    Private hints_word As String
    Private r As New Random
    Private damage As Single
    Private level As Single
    Private score As Integer
    Private high_score As Integer
    Private lives As Integer
    Private correct As Integer



#Region "Button Clicks"  '' This region handles what happens when buttons are pressed

    Private Sub btn_click(ByVal btn As Button)     ''buttons related to alphabet selection
        btn.Enabled = False
        btn.Visible = False
        Call check(btn.Text)

    End Sub

    Private Sub btn_level_click(ByVal btn As Button)   '' buttons related to level selection

        level = btn.Text
        Call newgame()

    End Sub

    Private Sub Buttons_level_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_l1.Click,
        Button_l2.Click, Button_l3.Click, Button_l4.Click, Button_l5.Click
        Dim btn As Button = DirectCast(sender, Button)
        correct = 1
        Call btn_level_click(btn)
    End Sub
    Private Sub Buttons_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_button.Click
        Environment.Exit(0)
    End Sub

    Private Sub Buttons_escape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click '' function related to level refresh
        score = 0
        Call newgame()

    End Sub


    Private Sub Buttons_escape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level_Button.Click '' function related to level select
        level = 0
        answers.Text = ""
        questions.Text = ""
        clear.Enabled = False
        clear.Visible = False
        Level_Button.Enabled = False
        Level_Button.Visible = False

        For Each btn As Button In Buttons_Level.Controls.OfType(Of Button)()
            btn.Enabled = True
            btn.Visible = True
        Next
        For Each btn As Button In Buttons.Controls.OfType(Of Button)()
            btn.Enabled = False
            btn.Visible = False
        Next
        Call newgame()

    End Sub


    Private Sub Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click,
        Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click,
         Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button30.Click, Button28.Click, Button29.Click, Button27.Click,
          Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click

        Dim btn As Button = DirectCast(sender, Button)

        Call btn_click(btn)
    End Sub

    Private Sub Buttons_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave, Button1.MouseLeave,
        Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave, Button6.MouseLeave, Button7.MouseLeave, Button8.MouseLeave, Button9.MouseLeave, Button10.MouseLeave,
         Button11.MouseLeave, Button12.MouseLeave, Button13.MouseLeave, Button14.MouseLeave, Button30.MouseLeave, Button28.MouseLeave, Button29.MouseLeave, Button27.MouseLeave,
          Button19.MouseLeave, Button20.MouseLeave, Button21.MouseLeave, Button22.MouseLeave, Button23.MouseLeave, Button24.MouseLeave, Button25.MouseLeave, Button26.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)          '' common function to handle the properties of all 26 buttons
        btn.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Buttons_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter, Button1.MouseEnter,
        Button3.MouseEnter, Button4.MouseEnter, Button5.MouseEnter, Button6.MouseEnter, Button7.MouseEnter, Button8.MouseEnter, Button9.MouseEnter, Button10.MouseEnter,
         Button11.MouseEnter, Button12.MouseEnter, Button13.MouseEnter, Button14.MouseEnter, Button30.MouseEnter, Button28.MouseEnter, Button29.MouseEnter, Button27.MouseEnter,
          Button19.MouseEnter, Button20.MouseEnter, Button21.MouseEnter, Button22.MouseEnter, Button23.MouseEnter, Button24.MouseEnter, Button25.MouseEnter, Button26.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)            '' common function to handle the properties of all 26 buttons
        btn.BackColor = Color.Black
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        For Each btn As Button In Panel1.Controls.OfType(Of Button)()
            If e.KeyCode.ToString.ToLower = btn.Text.ToLower Then          '' function to extract the value of the alphabet selected on pressing the button
                Call btn_click(btn)
            End If
        Next
    End Sub

#End Region

    Private Sub check(ByVal letter As String)     '' function checking if guess matches any letter of the answer if it matches then blank spaces are filled
        '' else depending upon level actions are taken
        If answers_word.Contains(letter.ToLower) Then
            'Match
            Dim indexes As New List(Of Integer)
            For i As Integer = 0 To answers_word.Length - 1
                If answers_word.Substring(i, 1).ToLower = letter.ToLower Then
                    indexes.Add(i)
                End If
            Next

            For Each Int As Integer In indexes
                answers.Text = answers.Text.Remove(Int * 4, 4).Insert(Int * 4, letter.ToUpper & "   ")
            Next

            If answers.Text.Contains("_") = False Then
                score = score + 10 * level             '' the score is calculated
                If score > high_score Then               '' if the score is more than high score it is updated
                    high_score = score
                    My.Settings.Setting = score
                    My.Settings.Save()
                End If
                'PictureBox1.Image = My.Resources._8
                MessageBox.Show("Congratulations, you've won!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                correct = correct + 1
                Call newgame()
            End If
        Else                                           '' if the score is not matched it deducts point lost depending upon the level it is
            'Not a match
            damage += 1
            lives = lives - 1
            life.Text = ""
            life.Text = lives
            Select Case level
                Case 1
                    Select Case damage
                        Case 1
                            PictureBox1.Image = My.Resources._1_1
                        Case 2
                            PictureBox1.Image = My.Resources._1_2
                        Case 3
                            PictureBox1.Image = My.Resources._1_3
                        Case 4
                            PictureBox1.Image = My.Resources._1_4
                        Case 5
                            PictureBox1.Image = My.Resources._1_5
                        Case 6
                            life.Visible = False
                            PictureBox1.Image = My.Resources._1_6
                            score = 0
                            answers.Text = answers_word
                            MessageBox.Show("Sorry, but you lost.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Call newgame()
                    End Select
                Case 2
                    Select Case damage
                        Case 1
                            PictureBox1.Image = My.Resources._2_1
                        Case 2
                            PictureBox1.Image = My.Resources._2_2
                        Case 3
                            PictureBox1.Image = My.Resources._2_3
                        Case 4
                            PictureBox1.Image = My.Resources._2_4
                        Case 5
                            life.Visible = False
                            PictureBox1.Image = My.Resources._2_5
                            score = 0
                            answers.Text = answers_word
                            MessageBox.Show("Sorry, but you lost.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Call newgame()
                    End Select
                Case 3
                    Select Case damage
                        Case 1
                            PictureBox1.Image = My.Resources._3_1
                        Case 2
                            PictureBox1.Image = My.Resources._3_2
                        Case 3
                            PictureBox1.Image = My.Resources._3_3
                        Case 4
                            life.Visible = False
                            PictureBox1.Image = My.Resources._3_4
                            score = 0
                            answers.Text = answers_word
                            MessageBox.Show("Sorry, but you lost.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Call newgame()
                    End Select
                Case 4
                    Select Case damage
                        Case 1
                            PictureBox1.Image = My.Resources._4_1
                        Case 2
                            PictureBox1.Image = My.Resources._4_2
                        Case 3
                            life.Visible = False
                            PictureBox1.Image = My.Resources._4_3
                            score = 0
                            answers.Text = answers_word
                            MessageBox.Show("Sorry, but you lost.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Call newgame()
                    End Select
                Case 5
                    Select Case damage
                        Case 1
                            PictureBox1.Image = My.Resources._5_1
                        Case 2
                            life.Visible = False
                            PictureBox1.Image = My.Resources._5_2
                            score = 0
                            answers.Text = answers_word
                            MessageBox.Show("Sorry, but you lost.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Call newgame()
                    End Select
            End Select
        End If
    End Sub


    Private Sub newgame()          ' this starts  a newgame of hangman
        'Reset Body
        life.Visible = False
        current_score.Visible = False
        score_high.Visible = True
        score_high.Text = ""
        current_score.Text = ""
        score_high.Text = high_score
        current_score.Text = score
        level_display.Visible = False
        If correct = 5 And level <> 5 Then
            MessageBox.Show("You have qualifeid to the next level", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            level = level + 1
            correct = 0
        End If
        If correct = 5 And level = 5 Then
            MessageBox.Show("All Levels Conquered", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            score = 0
            correct = 0
            level = 0
        End If


        'No more damage
        If level = 0 Then
            current_score.Visible = False
            score_high.Visible = True
            answers.Text = ""
            questions.Text = ""
            clear.Enabled = False
            clear.Visible = False
            Level_Button.Enabled = False
            Level_Button.Visible = False
            For Each btn As Button In Buttons_Level.Controls.OfType(Of Button)()
                btn.Enabled = True
                btn.Visible = True
            Next
            For Each btn As Button In Buttons.Controls.OfType(Of Button)()
                btn.Enabled = False
                btn.Visible = False
            Next

        Else
            current_score.Visible = True
            score_high.Visible = True
            current_score.Text = score

            damage = 0
            answers.Text = ""
            questions.Text = ""
            clear.Enabled = True
            clear.Visible = True
            Level_Button.Enabled = True
            Level_Button.Visible = True
            For Each btn As Button In Buttons.Controls.OfType(Of Button)()
                btn.Enabled = True
                btn.Visible = True
            Next
            For Each btn As Button In Buttons_Level.Controls.OfType(Of Button)()
                btn.Enabled = False
                btn.Visible = False
            Next
            'Choosing  random word difficulty depending upon the level '
            lives = 6 - level
            life.Text = ""
            life.Text = lives
            life.Visible = True
            level_display.Visible = True
            level_display.Text = level
            Select Case level
                Case 1
                    PictureBox1.Image = Nothing
                    Dim del() As String = {Environment.NewLine}
                    answers_word_list = My.Resources.answers_01.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    questions_word_list = My.Resources.questions_01.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    hints_word_list = My.Resources.hints_01.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    Dim i As Integer = correct
                    answers_word = answers_word_list(i)
                    answers.Text = ""
                    questions.Text = ""
                    questions.Text = questions_word_list(i)
                    For j As Integer = 0 To answers_word.Length - 1
                        If GetChar(answers_word_list(i), j + 1) <> " " Then
                            answers.Text &= "__  "
                        Else
                            answers.Text &= "    "
                        End If
                    Next


                Case 2
                    PictureBox1.Image = Nothing
                    Dim del() As String = {Environment.NewLine}
                    answers_word_list = My.Resources.answers_02.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    questions_word_list = My.Resources.questions_02.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    hints_word_list = My.Resources.hints_02.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    Dim i As Integer = correct
                    answers_word = answers_word_list(i)
                    questions.Text = ""
                    answers.Text = ""
                    questions.Text = questions_word_list(i)
                    questions.Text = questions_word_list(i)
                    For j As Integer = 0 To answers_word.Length - 1
                        If GetChar(answers_word_list(i), j + 1) <> " " Then
                            answers.Text &= "__  "
                        Else
                            answers.Text &= "    "
                        End If
                    Next
                Case 3
                    PictureBox1.Image = Nothing
                    Dim del() As String = {Environment.NewLine}
                    answers_word_list = My.Resources.answers_03.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    questions_word_list = My.Resources.questions_03.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    hints_word_list = My.Resources.hints_03.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    Dim i As Integer = correct
                    answers_word = answers_word_list(i)
                    questions.Text = ""
                    answers.Text = ""
                    questions.Text = questions_word_list(i)
                    questions.Text = questions_word_list(i)
                    For j As Integer = 0 To answers_word.Length - 1
                        If GetChar(answers_word_list(i), j + 1) <> " " Then
                            answers.Text &= "__  "
                        Else
                            answers.Text &= "    "
                        End If
                    Next
                Case 4
                    PictureBox1.Image = Nothing
                    Dim del() As String = {Environment.NewLine}
                    answers_word_list = My.Resources.answers_04.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    questions_word_list = My.Resources.questions_04.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    hints_word_list = My.Resources.hints_04.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    Dim i As Integer = correct
                    answers_word = answers_word_list(i)
                    questions.Text = ""
                    answers.Text = ""
                    questions.Text = questions_word_list(i)
                    questions.Text = questions_word_list(i)
                    For j As Integer = 0 To answers_word.Length - 1
                        If GetChar(answers_word_list(i), j + 1) <> " " Then
                            answers.Text &= "__  "
                        Else
                            answers.Text &= "    "
                        End If
                    Next
                Case 5
                    PictureBox1.Image = Nothing
                    Dim del() As String = {Environment.NewLine}
                    answers_word_list = My.Resources.answers_05.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    questions_word_list = My.Resources.questions_05.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    hints_word_list = My.Resources.hints_05.Split(del, StringSplitOptions.RemoveEmptyEntries)
                    Dim i As Integer = correct
                    answers_word = answers_word_list(i)
                    questions.Text = ""
                    answers.Text = ""
                    questions.Text = questions_word_list(i)
                    questions.Text = questions_word_list(i)
                    For j As Integer = 0 To answers_word.Length - 1
                        If GetChar(answers_word_list(i), j + 1) <> " " Then
                            answers.Text &= "__  "
                        Else
                            answers.Text &= "    "
                        End If
                    Next
            End Select

        End If


    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  '' the function which starts on loading the form
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        score = 0
        high_score = My.Settings.Setting    '' initial settings of the high score and score
        score_high.Text = ""
        current_score.Text = ""
        score_high.Text = high_score
        current_score.Text = score
        Call newgame()
    End Sub

   
End Class
