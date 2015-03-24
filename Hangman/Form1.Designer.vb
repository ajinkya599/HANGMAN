<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.answers = New System.Windows.Forms.Label()
        Me.questions = New System.Windows.Forms.Label()
        Me.Level_Button = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Buttons = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_l5 = New System.Windows.Forms.Button()
        Me.Button_l4 = New System.Windows.Forms.Button()
        Me.Button_l3 = New System.Windows.Forms.Button()
        Me.Button_l2 = New System.Windows.Forms.Button()
        Me.Button_l1 = New System.Windows.Forms.Button()
        Me.Buttons_Level = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.exit_button = New System.Windows.Forms.Button()
        Me.current_score = New System.Windows.Forms.Label()
        Me.score_high = New System.Windows.Forms.Label()
        Me.life = New System.Windows.Forms.Label()
        Me.level_display = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Buttons.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Buttons_Level.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BackgroundImage = Global.Hangman.My.Resources.Resources.bg_4
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(541, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 316)
        Me.Panel1.TabIndex = 1
        '
        'answers
        '
        Me.answers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.answers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answers.ForeColor = System.Drawing.Color.Yellow
        Me.answers.Image = Global.Hangman.My.Resources.Resources.bg_3
        Me.answers.Location = New System.Drawing.Point(542, 500)
        Me.answers.Margin = New System.Windows.Forms.Padding(0)
        Me.answers.MinimumSize = New System.Drawing.Size(350, 100)
        Me.answers.Name = "answers"
        Me.answers.Padding = New System.Windows.Forms.Padding(50, 30, 0, 0)
        Me.answers.Size = New System.Drawing.Size(350, 100)
        Me.answers.TabIndex = 3
        '
        'questions
        '
        Me.questions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questions.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.questions.Image = Global.Hangman.My.Resources.Resources.bg_3
        Me.questions.Location = New System.Drawing.Point(49, 500)
        Me.questions.MinimumSize = New System.Drawing.Size(475, 100)
        Me.questions.Name = "questions"
        Me.questions.Size = New System.Drawing.Size(475, 100)
        Me.questions.TabIndex = 2
        Me.questions.Tag = "questions"
        Me.questions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Level_Button
        '
        Me.Level_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Level_Button.Location = New System.Drawing.Point(842, 403)
        Me.Level_Button.Name = "Level_Button"
        Me.Level_Button.Size = New System.Drawing.Size(92, 52)
        Me.Level_Button.TabIndex = 5
        Me.Level_Button.Text = " CHANGE LEVEL"
        Me.Level_Button.UseVisualStyleBackColor = False
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.clear.Location = New System.Drawing.Point(842, 341)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(92, 52)
        Me.clear.TabIndex = 4
        Me.clear.Text = "REFRESH"
        Me.clear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(36, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "A"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Buttons
        '
        Me.Buttons.BackgroundImage = Global.Hangman.My.Resources.Resources.bg_2
        Me.Buttons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttons.Controls.Add(Me.Button11)
        Me.Buttons.Controls.Add(Me.Button1)
        Me.Buttons.Controls.Add(Me.Button9)
        Me.Buttons.Controls.Add(Me.Button30)
        Me.Buttons.Controls.Add(Me.Button10)
        Me.Buttons.Controls.Add(Me.Button8)
        Me.Buttons.Controls.Add(Me.Button20)
        Me.Buttons.Controls.Add(Me.Button22)
        Me.Buttons.Controls.Add(Me.Button29)
        Me.Buttons.Controls.Add(Me.Button7)
        Me.Buttons.Controls.Add(Me.Button23)
        Me.Buttons.Controls.Add(Me.Button21)
        Me.Buttons.Controls.Add(Me.Button2)
        Me.Buttons.Controls.Add(Me.Button19)
        Me.Buttons.Controls.Add(Me.Button6)
        Me.Buttons.Controls.Add(Me.Button24)
        Me.Buttons.Controls.Add(Me.Button27)
        Me.Buttons.Controls.Add(Me.Button26)
        Me.Buttons.Controls.Add(Me.Button28)
        Me.Buttons.Controls.Add(Me.Button13)
        Me.Buttons.Controls.Add(Me.Button14)
        Me.Buttons.Controls.Add(Me.Button5)
        Me.Buttons.Controls.Add(Me.Button25)
        Me.Buttons.Controls.Add(Me.Button3)
        Me.Buttons.Controls.Add(Me.Button4)
        Me.Buttons.Controls.Add(Me.Button12)
        Me.Buttons.Location = New System.Drawing.Point(24, 328)
        Me.Buttons.Name = "Buttons"
        Me.Buttons.Size = New System.Drawing.Size(592, 158)
        Me.Buttons.TabIndex = 3
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(182, 107)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(37, 37)
        Me.Button11.TabIndex = 12
        Me.Button11.Text = "C"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(213, 64)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(37, 37)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "F"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button30.BackgroundImage = CType(resources.GetObject("Button30.BackgroundImage"), System.Drawing.Image)
        Me.Button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.ForeColor = System.Drawing.Color.White
        Me.Button30.Location = New System.Drawing.Point(121, 107)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(37, 37)
        Me.Button30.TabIndex = 31
        Me.Button30.Text = "X"
        Me.Button30.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(130, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(37, 37)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "E"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(273, 64)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(37, 37)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "G"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button20.BackgroundImage = CType(resources.GetObject("Button20.BackgroundImage"), System.Drawing.Image)
        Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.Color.White
        Me.Button20.Location = New System.Drawing.Point(62, 107)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(37, 37)
        Me.Button20.TabIndex = 21
        Me.Button20.Text = "Z"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button22.BackgroundImage = CType(resources.GetObject("Button22.BackgroundImage"), System.Drawing.Image)
        Me.Button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.White
        Me.Button22.Location = New System.Drawing.Point(308, 18)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(37, 37)
        Me.Button22.TabIndex = 23
        Me.Button22.Text = "Y"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button29.BackgroundImage = CType(resources.GetObject("Button29.BackgroundImage"), System.Drawing.Image)
        Me.Button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button29.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.ForeColor = System.Drawing.Color.White
        Me.Button29.Location = New System.Drawing.Point(249, 18)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(37, 37)
        Me.Button29.TabIndex = 30
        Me.Button29.Text = "T"
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(425, 17)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(37, 37)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "I"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button23.BackgroundImage = CType(resources.GetObject("Button23.BackgroundImage"), System.Drawing.Image)
        Me.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.Color.White
        Me.Button23.Location = New System.Drawing.Point(367, 17)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(37, 37)
        Me.Button23.TabIndex = 24
        Me.Button23.Text = "U"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button21.BackgroundImage = CType(resources.GetObject("Button21.BackgroundImage"), System.Drawing.Image)
        Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.White
        Me.Button21.Location = New System.Drawing.Point(241, 107)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(37, 37)
        Me.Button21.TabIndex = 22
        Me.Button21.Text = "V"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(302, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "B"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button19.BackgroundImage = CType(resources.GetObject("Button19.BackgroundImage"), System.Drawing.Image)
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.White
        Me.Button19.Location = New System.Drawing.Point(71, 19)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(37, 37)
        Me.Button19.TabIndex = 20
        Me.Button19.Text = "W"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(389, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(37, 37)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "J"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button24.BackgroundImage = CType(resources.GetObject("Button24.BackgroundImage"), System.Drawing.Image)
        Me.Button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.Color.White
        Me.Button24.Location = New System.Drawing.Point(95, 64)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(37, 37)
        Me.Button24.TabIndex = 25
        Me.Button24.Text = "S"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button27.BackgroundImage = CType(resources.GetObject("Button27.BackgroundImage"), System.Drawing.Image)
        Me.Button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.Color.White
        Me.Button27.Location = New System.Drawing.Point(504, 64)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(37, 37)
        Me.Button27.TabIndex = 28
        Me.Button27.Text = "L"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button26.BackgroundImage = CType(resources.GetObject("Button26.BackgroundImage"), System.Drawing.Image)
        Me.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.Color.White
        Me.Button26.Location = New System.Drawing.Point(540, 17)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(37, 37)
        Me.Button26.TabIndex = 27
        Me.Button26.Text = "P"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button28.BackgroundImage = CType(resources.GetObject("Button28.BackgroundImage"), System.Drawing.Image)
        Me.Button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button28.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.ForeColor = System.Drawing.Color.White
        Me.Button28.Location = New System.Drawing.Point(331, 64)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(37, 37)
        Me.Button28.TabIndex = 29
        Me.Button28.Text = "H"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Location = New System.Drawing.Point(189, 18)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(37, 37)
        Me.Button13.TabIndex = 14
        Me.Button13.Text = "R"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"), System.Drawing.Image)
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(154, 64)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(37, 37)
        Me.Button14.TabIndex = 15
        Me.Button14.Text = "D"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(447, 64)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 37)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "K"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button25.BackgroundImage = CType(resources.GetObject("Button25.BackgroundImage"), System.Drawing.Image)
        Me.Button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.ForeColor = System.Drawing.Color.White
        Me.Button25.Location = New System.Drawing.Point(11, 19)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(37, 37)
        Me.Button25.TabIndex = 26
        Me.Button25.Text = "Q"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(483, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 37)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "O"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(419, 107)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(37, 37)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "M"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(360, 107)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(37, 37)
        Me.Button12.TabIndex = 13
        Me.Button12.Text = "N"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Hangman.My.Resources.Resources.bg_1
        Me.PictureBox1.Location = New System.Drawing.Point(134, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(391, 310)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button_l5
        '
        Me.Button_l5.BackColor = System.Drawing.Color.Navy
        Me.Button_l5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_l5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_l5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_l5.ForeColor = System.Drawing.Color.White
        Me.Button_l5.Location = New System.Drawing.Point(103, 67)
        Me.Button_l5.Name = "Button_l5"
        Me.Button_l5.Size = New System.Drawing.Size(41, 23)
        Me.Button_l5.TabIndex = 36
        Me.Button_l5.Text = "5"
        Me.Button_l5.UseVisualStyleBackColor = False
        '
        'Button_l4
        '
        Me.Button_l4.BackColor = System.Drawing.Color.Navy
        Me.Button_l4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_l4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_l4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_l4.ForeColor = System.Drawing.Color.White
        Me.Button_l4.Location = New System.Drawing.Point(43, 67)
        Me.Button_l4.Name = "Button_l4"
        Me.Button_l4.Size = New System.Drawing.Size(41, 23)
        Me.Button_l4.TabIndex = 32
        Me.Button_l4.Text = "4"
        Me.Button_l4.UseVisualStyleBackColor = False
        '
        'Button_l3
        '
        Me.Button_l3.BackColor = System.Drawing.Color.Navy
        Me.Button_l3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_l3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_l3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_l3.ForeColor = System.Drawing.Color.White
        Me.Button_l3.Location = New System.Drawing.Point(133, 36)
        Me.Button_l3.Name = "Button_l3"
        Me.Button_l3.Size = New System.Drawing.Size(41, 23)
        Me.Button_l3.TabIndex = 33
        Me.Button_l3.Text = "3"
        Me.Button_l3.UseVisualStyleBackColor = False
        '
        'Button_l2
        '
        Me.Button_l2.BackColor = System.Drawing.Color.Navy
        Me.Button_l2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_l2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_l2.ForeColor = System.Drawing.Color.White
        Me.Button_l2.Location = New System.Drawing.Point(74, 36)
        Me.Button_l2.Name = "Button_l2"
        Me.Button_l2.Size = New System.Drawing.Size(41, 23)
        Me.Button_l2.TabIndex = 34
        Me.Button_l2.Text = "2"
        Me.Button_l2.UseVisualStyleBackColor = False
        '
        'Button_l1
        '
        Me.Button_l1.BackColor = System.Drawing.Color.Navy
        Me.Button_l1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_l1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_l1.ForeColor = System.Drawing.Color.White
        Me.Button_l1.Location = New System.Drawing.Point(14, 36)
        Me.Button_l1.Name = "Button_l1"
        Me.Button_l1.Size = New System.Drawing.Size(41, 23)
        Me.Button_l1.TabIndex = 35
        Me.Button_l1.Text = "1"
        Me.Button_l1.UseVisualStyleBackColor = False
        '
        'Buttons_Level
        '
        Me.Buttons_Level.BackgroundImage = Global.Hangman.My.Resources.Resources.bg_1
        Me.Buttons_Level.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttons_Level.Controls.Add(Me.Label5)
        Me.Buttons_Level.Controls.Add(Me.Button_l1)
        Me.Buttons_Level.Controls.Add(Me.Button_l2)
        Me.Buttons_Level.Controls.Add(Me.Button_l3)
        Me.Buttons_Level.Controls.Add(Me.Button_l5)
        Me.Buttons_Level.Controls.Add(Me.Button_l4)
        Me.Buttons_Level.Location = New System.Drawing.Point(637, 360)
        Me.Buttons_Level.Name = "Buttons_Level"
        Me.Buttons_Level.Size = New System.Drawing.Size(187, 95)
        Me.Buttons_Level.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label5.Location = New System.Drawing.Point(45, 5)
        Me.Label5.MinimumSize = New System.Drawing.Size(100, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SELECT LEVEL"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exit_button
        '
        Me.exit_button.BackColor = System.Drawing.Color.Black
        Me.exit_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_button.ForeColor = System.Drawing.Color.Crimson
        Me.exit_button.Location = New System.Drawing.Point(9, 12)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(58, 33)
        Me.exit_button.TabIndex = 6
        Me.exit_button.Text = "EXIT"
        Me.exit_button.UseVisualStyleBackColor = False
        '
        'current_score
        '
        Me.current_score.AutoSize = True
        Me.current_score.BackColor = System.Drawing.Color.Black
        Me.current_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.current_score.ForeColor = System.Drawing.Color.Green
        Me.current_score.Location = New System.Drawing.Point(84, 65)
        Me.current_score.MinimumSize = New System.Drawing.Size(39, 30)
        Me.current_score.Name = "current_score"
        Me.current_score.Size = New System.Drawing.Size(39, 30)
        Me.current_score.TabIndex = 0
        Me.current_score.Text = " "
        Me.current_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'score_high
        '
        Me.score_high.AutoSize = True
        Me.score_high.BackColor = System.Drawing.Color.Black
        Me.score_high.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score_high.ForeColor = System.Drawing.Color.Green
        Me.score_high.Location = New System.Drawing.Point(84, 109)
        Me.score_high.MinimumSize = New System.Drawing.Size(39, 30)
        Me.score_high.Name = "score_high"
        Me.score_high.Size = New System.Drawing.Size(39, 30)
        Me.score_high.TabIndex = 7
        Me.score_high.Text = " "
        Me.score_high.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'life
        '
        Me.life.AutoSize = True
        Me.life.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.life.ForeColor = System.Drawing.Color.OliveDrab
        Me.life.Location = New System.Drawing.Point(81, 201)
        Me.life.MinimumSize = New System.Drawing.Size(39, 30)
        Me.life.Name = "life"
        Me.life.Size = New System.Drawing.Size(39, 30)
        Me.life.TabIndex = 8
        Me.life.Text = " "
        Me.life.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'level_display
        '
        Me.level_display.AutoSize = True
        Me.level_display.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.level_display.ForeColor = System.Drawing.Color.OliveDrab
        Me.level_display.Location = New System.Drawing.Point(82, 247)
        Me.level_display.MinimumSize = New System.Drawing.Size(39, 30)
        Me.level_display.Name = "level_display"
        Me.level_display.Size = New System.Drawing.Size(39, 30)
        Me.level_display.TabIndex = 9
        Me.level_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(7, 65)
        Me.Label1.MinimumSize = New System.Drawing.Size(74, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "SCORE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(7, 109)
        Me.Label2.MinimumSize = New System.Drawing.Size(60, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 30)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "HIGH SCORE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 201)
        Me.Label3.MinimumSize = New System.Drawing.Size(60, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 30)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "LIVES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 247)
        Me.Label4.MinimumSize = New System.Drawing.Size(60, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 30)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "LEVEL"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hangman.My.Resources.Resources.bg_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(969, 645)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.level_display)
        Me.Controls.Add(Me.life)
        Me.Controls.Add(Me.score_high)
        Me.Controls.Add(Me.current_score)
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.answers)
        Me.Controls.Add(Me.Level_Button)
        Me.Controls.Add(Me.questions)
        Me.Controls.Add(Me.Buttons_Level)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Buttons)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Buttons.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Buttons_Level.ResumeLayout(False)
        Me.Buttons_Level.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents questions As System.Windows.Forms.Label
    Friend WithEvents answers As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Buttons As System.Windows.Forms.Panel
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_l5 As System.Windows.Forms.Button
    Friend WithEvents Button_l4 As System.Windows.Forms.Button
    Friend WithEvents Button_l3 As System.Windows.Forms.Button
    Friend WithEvents Button_l2 As System.Windows.Forms.Button
    Friend WithEvents Button_l1 As System.Windows.Forms.Button
    Friend WithEvents Level_Button As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents Buttons_Level As System.Windows.Forms.Panel
    Friend WithEvents exit_button As System.Windows.Forms.Button
    Friend WithEvents current_score As System.Windows.Forms.Label
    Friend WithEvents score_high As System.Windows.Forms.Label
    Friend WithEvents life As System.Windows.Forms.Label
    Friend WithEvents level_display As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
