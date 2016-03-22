Public Class Game
    Public AvatarCount As Integer = 0
    Dim objRussianRoulette As New RussianRoulette
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        lblActionRequired.Text = objRussianRoulette.ActionRequired()
        UpdateAvatar()
    End Sub

    Private Sub UpdateAvatar()
        If AvatarCount = 0 Then
            pbPlayer.Image = My.Resources.clickhere
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage
            AvatarCount += 1
        ElseIf AvatarCount = 1 Then
            pbPlayer.Image = My.Resources.avater1
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage
            AvatarCount += 1
            tbPlayerName.Enabled = True
            lblActionRequired.Text = objRussianRoulette.ActionRequired()
        ElseIf AvatarCount = 2 Then
            pbPlayer.Image = My.Resources.avater2
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage
            AvatarCount += 1
        ElseIf AvatarCount = 3 Then
            pbPlayer.Image = My.Resources.avater3
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage
            AvatarCount += 1
        ElseIf AvatarCount = 4 Then
            pbPlayer.Image = My.Resources.avater4
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage
            AvatarCount += 1
        ElseIf AvatarCount = 5 Then
            pbPlayer.Image = My.Resources.avater5
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage
            AvatarCount = 1
        End If
    End Sub
    Private Sub UpdateInterface()
        ' Determine the options available to the user based on the status of the weapon and adjust the UI accordingly
        ' 0 = Unloaded; 1 = Loaded, Chambers Not Spun; 2 = Loaded, Chambers Spun; 3 = Gun is empty and game has just been completed
        ' Updates all available buttons, instructions for the user and game count and losses
        If objRussianRoulette.GetGunState() = 0 Then
            lblOutcome.Text = objRussianRoulette.GetGameOutcome
            btnLoadBullet.Enabled = True
            btnSpinChambers.Enabled = False
            btnFire.Enabled = False
            lblActionRequired.Text = objRussianRoulette.ActionRequired()
            tbGamesPlayed.Text = objRussianRoulette.GetGameCount()
            tbGamesLost.Text = objRussianRoulette.GetGameLossCount()
        ElseIf objRussianRoulette.GetGunState() = 1 Then
            btnLoadBullet.Enabled = False
            btnSpinChambers.Enabled = True
            btnFire.Enabled = False
            lblActionRequired.Text = objRussianRoulette.ActionRequired()
            tbGamesPlayed.Text = objRussianRoulette.GetGameCount()
            tbGamesLost.Text = objRussianRoulette.GetGameLossCount()
        ElseIf objRussianRoulette.GetGunState() = 2 Then
            btnLoadBullet.Enabled = False
            btnSpinChambers.Enabled = False
            btnFire.Enabled = True
            rbPointAtHead.Enabled = True
            If objRussianRoulette.CheckPointatHeadcount() = False Then
                ' Manage the Point Away option in the UI and determine if it should be available to the player in the UI
                rbPointAway.Enabled = False
            Else rbPointAway.Enabled = True
            End If
            If objRussianRoulette.GetPointAtHeadState() = True Then
                rbPointAtHead.Checked = True
            Else rbPointAway.Checked = True
            End If
            tbShotsFired.Text = objRussianRoulette.GetShotCount()
            tbScore.Text = objRussianRoulette.GetScore()
            lblActionRequired.Text = objRussianRoulette.ActionRequired()
            tbGamesPlayed.Text = objRussianRoulette.GetGameCount()
            If objRussianRoulette.GetGameCount >= 10 Then
                Me.lblScoreWarning.Text = ""
            End If
            tbGamesLost.Text = objRussianRoulette.GetGameLossCount()
        ElseIf objRussianRoulette.GetGunState() = 3 Then
            ' GunState 3 is an empty gun after a game has ended - The user is shown the game outcome and given the option to play again
            btnLoadBullet.Enabled = False
            btnSpinChambers.Enabled = False
            btnFire.Enabled = True
            rbPointAtHead.Enabled = False
            rbPointAway.Enabled = False
            lblOutcome.Text = objRussianRoulette.GetGameOutcome
            If objRussianRoulette.GetGameCount >= 10 Then
                Me.lblScoreWarning.Text = ""
            End If
            lblActionRequired.Text = objRussianRoulette.ActionRequired()
            tbGamesPlayed.Text = objRussianRoulette.GetGameCount()
            tbGamesLost.Text = objRussianRoulette.GetGameLossCount()
            tbScore.Text = objRussianRoulette.GetScore()
            btnFire.Text = "Play Again"
        End If
    End Sub

    Private Sub btnLoadBullet_Click(sender As Object, e As EventArgs) Handles btnLoadBullet.Click
        objRussianRoulette.UpdateGunState(1)
        UpdateInterface()
    End Sub

    Private Sub btnSpinChambers_Click(sender As Object, e As EventArgs) Handles btnSpinChambers.Click
        objRussianRoulette.UpdateGunState(2)
        UpdateInterface()
    End Sub

    Private Sub rbPointAtHead_CheckedChanged(sender As Object, e As EventArgs) Handles rbPointAtHead.CheckedChanged
        objRussianRoulette.UpdatePointAtHeadState(True)
    End Sub

    Private Sub rbPointAway_CheckedChanged(sender As Object, e As EventArgs) Handles rbPointAway.CheckedChanged
        objRussianRoulette.UpdatePointAtHeadState(False)
    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        If objRussianRoulette.GetGunState() = 2 Then
            objRussianRoulette.Fire()
            UpdateInterface()
        ElseIf objRussianRoulette.GetGunState() = 3 Then
            ' Button is used to fire but also changes to a New Game button at the end of play
            objRussianRoulette.NewGame()
            UpdateInterface()
            btnFire.Text = "Fire"
        End If
    End Sub

    Private Sub tbPlayerName_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPlayerName.KeyDown
        ' Detects the Enter keypress to lock in the players name
        If e.KeyCode = Keys.Enter Then
            objRussianRoulette.UpdatePlayerName(tbPlayerName.Text)
            tbPlayerName.Enabled = False
            pbPlayer.Enabled = False
            UpdateInterface()
        End If
    End Sub

    Private Sub Game_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        If objRussianRoulette.GetScore > 0 And objRussianRoulette.GetGameCount >= 10 Then
            objRussianRoulette.SaveScores()
        End If
        Scores.Show()
    End Sub

    Private Sub pbPlayer_Click(sender As Object, e As EventArgs) Handles pbPlayer.Click
        UpdateAvatar()
    End Sub
End Class