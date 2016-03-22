<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.tbPlayerName = New System.Windows.Forms.TextBox()
        Me.rbPointAway = New System.Windows.Forms.RadioButton()
        Me.rbPointAtHead = New System.Windows.Forms.RadioButton()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.btnSpinChambers = New System.Windows.Forms.Button()
        Me.btnLoadBullet = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblNextAction = New System.Windows.Forms.Label()
        Me.lblShotsFired = New System.Windows.Forms.Label()
        Me.tbShotsFired = New System.Windows.Forms.TextBox()
        Me.tbScore = New System.Windows.Forms.TextBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblActionRequired = New System.Windows.Forms.Label()
        Me.lblGamesWon = New System.Windows.Forms.Label()
        Me.tbGamesPlayed = New System.Windows.Forms.TextBox()
        Me.lblGamesLost = New System.Windows.Forms.Label()
        Me.tbGamesLost = New System.Windows.Forms.TextBox()
        Me.lblScoreWarning = New System.Windows.Forms.Label()
        Me.lblOutcome = New System.Windows.Forms.Label()
        Me.pbPlayer = New System.Windows.Forms.PictureBox()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPlayerName
        '
        Me.tbPlayerName.Enabled = False
        Me.tbPlayerName.Location = New System.Drawing.Point(12, 153)
        Me.tbPlayerName.Name = "tbPlayerName"
        Me.tbPlayerName.Size = New System.Drawing.Size(126, 20)
        Me.tbPlayerName.TabIndex = 35
        '
        'rbPointAway
        '
        Me.rbPointAway.AutoSize = True
        Me.rbPointAway.Enabled = False
        Me.rbPointAway.Location = New System.Drawing.Point(410, 118)
        Me.rbPointAway.Name = "rbPointAway"
        Me.rbPointAway.Size = New System.Drawing.Size(78, 17)
        Me.rbPointAway.TabIndex = 28
        Me.rbPointAway.TabStop = True
        Me.rbPointAway.Text = "Point Away"
        Me.rbPointAway.UseVisualStyleBackColor = True
        '
        'rbPointAtHead
        '
        Me.rbPointAtHead.AutoSize = True
        Me.rbPointAtHead.Enabled = False
        Me.rbPointAtHead.Location = New System.Drawing.Point(410, 94)
        Me.rbPointAtHead.Name = "rbPointAtHead"
        Me.rbPointAtHead.Size = New System.Drawing.Size(90, 17)
        Me.rbPointAtHead.TabIndex = 27
        Me.rbPointAtHead.TabStop = True
        Me.rbPointAtHead.Text = "Point at Head"
        Me.rbPointAtHead.UseVisualStyleBackColor = True
        '
        'btnFire
        '
        Me.btnFire.Enabled = False
        Me.btnFire.Location = New System.Drawing.Point(355, 203)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(75, 23)
        Me.btnFire.TabIndex = 25
        Me.btnFire.Text = "Fire"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'btnSpinChambers
        '
        Me.btnSpinChambers.Enabled = False
        Me.btnSpinChambers.Location = New System.Drawing.Point(224, 203)
        Me.btnSpinChambers.Name = "btnSpinChambers"
        Me.btnSpinChambers.Size = New System.Drawing.Size(96, 23)
        Me.btnSpinChambers.TabIndex = 24
        Me.btnSpinChambers.Text = "Spin Chambers"
        Me.btnSpinChambers.UseVisualStyleBackColor = True
        '
        'btnLoadBullet
        '
        Me.btnLoadBullet.Enabled = False
        Me.btnLoadBullet.Location = New System.Drawing.Point(115, 203)
        Me.btnLoadBullet.Name = "btnLoadBullet"
        Me.btnLoadBullet.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadBullet.TabIndex = 23
        Me.btnLoadBullet.Text = "Load Bullet"
        Me.btnLoadBullet.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(398, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 61)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(12, 134)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(70, 13)
        Me.lblPlayerName.TabIndex = 36
        Me.lblPlayerName.Text = "Player Name:"
        '
        'lblNextAction
        '
        Me.lblNextAction.AutoSize = True
        Me.lblNextAction.Location = New System.Drawing.Point(200, 133)
        Me.lblNextAction.Name = "lblNextAction"
        Me.lblNextAction.Size = New System.Drawing.Size(71, 13)
        Me.lblNextAction.TabIndex = 37
        Me.lblNextAction.Text = "Game Status:"
        '
        'lblShotsFired
        '
        Me.lblShotsFired.AutoSize = True
        Me.lblShotsFired.Location = New System.Drawing.Point(395, 11)
        Me.lblShotsFired.Name = "lblShotsFired"
        Me.lblShotsFired.Size = New System.Drawing.Size(63, 13)
        Me.lblShotsFired.TabIndex = 38
        Me.lblShotsFired.Text = "Shots Fired:"
        '
        'tbShotsFired
        '
        Me.tbShotsFired.BackColor = System.Drawing.Color.White
        Me.tbShotsFired.Enabled = False
        Me.tbShotsFired.Location = New System.Drawing.Point(464, 4)
        Me.tbShotsFired.Name = "tbShotsFired"
        Me.tbShotsFired.Size = New System.Drawing.Size(75, 20)
        Me.tbShotsFired.TabIndex = 39
        '
        'tbScore
        '
        Me.tbScore.BackColor = System.Drawing.Color.White
        Me.tbScore.Enabled = False
        Me.tbScore.Location = New System.Drawing.Point(464, 36)
        Me.tbScore.Name = "tbScore"
        Me.tbScore.Size = New System.Drawing.Size(75, 20)
        Me.tbScore.TabIndex = 76
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(395, 43)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 13)
        Me.lblScore.TabIndex = 77
        Me.lblScore.Text = "Score:"
        '
        'lblActionRequired
        '
        Me.lblActionRequired.AutoSize = True
        Me.lblActionRequired.ForeColor = System.Drawing.Color.Red
        Me.lblActionRequired.Location = New System.Drawing.Point(200, 160)
        Me.lblActionRequired.Name = "lblActionRequired"
        Me.lblActionRequired.Size = New System.Drawing.Size(0, 13)
        Me.lblActionRequired.TabIndex = 78
        '
        'lblGamesWon
        '
        Me.lblGamesWon.AutoSize = True
        Me.lblGamesWon.Location = New System.Drawing.Point(12, 248)
        Me.lblGamesWon.Name = "lblGamesWon"
        Me.lblGamesWon.Size = New System.Drawing.Size(78, 13)
        Me.lblGamesWon.TabIndex = 80
        Me.lblGamesWon.Text = "Games Played:"
        '
        'tbGamesPlayed
        '
        Me.tbGamesPlayed.BackColor = System.Drawing.Color.White
        Me.tbGamesPlayed.Enabled = False
        Me.tbGamesPlayed.Location = New System.Drawing.Point(94, 241)
        Me.tbGamesPlayed.Name = "tbGamesPlayed"
        Me.tbGamesPlayed.Size = New System.Drawing.Size(75, 20)
        Me.tbGamesPlayed.TabIndex = 79
        '
        'lblGamesLost
        '
        Me.lblGamesLost.AutoSize = True
        Me.lblGamesLost.Location = New System.Drawing.Point(12, 280)
        Me.lblGamesLost.Name = "lblGamesLost"
        Me.lblGamesLost.Size = New System.Drawing.Size(66, 13)
        Me.lblGamesLost.TabIndex = 82
        Me.lblGamesLost.Text = "Games Lost:"
        '
        'tbGamesLost
        '
        Me.tbGamesLost.BackColor = System.Drawing.Color.White
        Me.tbGamesLost.Enabled = False
        Me.tbGamesLost.Location = New System.Drawing.Point(94, 273)
        Me.tbGamesLost.Name = "tbGamesLost"
        Me.tbGamesLost.Size = New System.Drawing.Size(75, 20)
        Me.tbGamesLost.TabIndex = 81
        '
        'lblScoreWarning
        '
        Me.lblScoreWarning.AutoSize = True
        Me.lblScoreWarning.ForeColor = System.Drawing.Color.Red
        Me.lblScoreWarning.Location = New System.Drawing.Point(175, 276)
        Me.lblScoreWarning.Name = "lblScoreWarning"
        Me.lblScoreWarning.Size = New System.Drawing.Size(369, 13)
        Me.lblScoreWarning.TabIndex = 83
        Me.lblScoreWarning.Text = "No score recorded till a minimum of 10 consecutive games have been played"
        '
        'lblOutcome
        '
        Me.lblOutcome.AutoSize = True
        Me.lblOutcome.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutcome.ForeColor = System.Drawing.Color.Red
        Me.lblOutcome.Location = New System.Drawing.Point(199, 58)
        Me.lblOutcome.Name = "lblOutcome"
        Me.lblOutcome.Size = New System.Drawing.Size(0, 23)
        Me.lblOutcome.TabIndex = 84
        '
        'pbPlayer
        '
        Me.pbPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPlayer.Location = New System.Drawing.Point(12, 11)
        Me.pbPlayer.Name = "pbPlayer"
        Me.pbPlayer.Size = New System.Drawing.Size(126, 116)
        Me.pbPlayer.TabIndex = 33
        Me.pbPlayer.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 302)
        Me.Controls.Add(Me.lblOutcome)
        Me.Controls.Add(Me.lblScoreWarning)
        Me.Controls.Add(Me.lblGamesLost)
        Me.Controls.Add(Me.tbGamesLost)
        Me.Controls.Add(Me.lblGamesWon)
        Me.Controls.Add(Me.tbGamesPlayed)
        Me.Controls.Add(Me.lblActionRequired)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.tbScore)
        Me.Controls.Add(Me.tbShotsFired)
        Me.Controls.Add(Me.lblShotsFired)
        Me.Controls.Add(Me.lblNextAction)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.tbPlayerName)
        Me.Controls.Add(Me.pbPlayer)
        Me.Controls.Add(Me.rbPointAway)
        Me.Controls.Add(Me.rbPointAtHead)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.btnSpinChambers)
        Me.Controls.Add(Me.btnLoadBullet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPlayerName As TextBox
    Friend WithEvents pbPlayer As PictureBox
    Friend WithEvents rbPointAway As RadioButton
    Friend WithEvents rbPointAtHead As RadioButton
    Friend WithEvents btnFire As Button
    Friend WithEvents btnSpinChambers As Button
    Friend WithEvents btnLoadBullet As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lblNextAction As Label
    Friend WithEvents lblShotsFired As Label
    Friend WithEvents tbShotsFired As TextBox
    Friend WithEvents tbScore As TextBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblActionRequired As Label
    Friend WithEvents lblGamesWon As Label
    Friend WithEvents tbGamesPlayed As TextBox
    Friend WithEvents lblGamesLost As Label
    Friend WithEvents tbGamesLost As TextBox
    Friend WithEvents lblScoreWarning As Label
    Friend WithEvents lblOutcome As Label
End Class
