Public Class Instructions
    Private Sub btnPlayGame_Click(sender As Object, e As EventArgs) Handles btnPlayGame.Click
        Me.Hide()
        Game.Show()
    End Sub

    Private Sub Instructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbInstructions.Text = "Welcome to Russian Roulette" & vbCrLf & vbCrLf & "Objective: Survive death as long as you can by avoiding the bullet in a loaded revolver" & vbCrLf & vbCrLf & "Once you have selected your avatar and entered your name you will need to load the revolver and then spin the chamber." & vbCrLf & vbCrLf & "The weapon is a six shooter, you must try and avoid the bullet but you will only have two chances in each game to point the gun away from your head." & vbCrLf & vbCrLf & "Good luck, your going to need it!"
    End Sub
End Class