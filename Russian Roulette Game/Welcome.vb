Public Class Welcome
    Private Sub btnPlayGame_Click(sender As Object, e As EventArgs) Handles btnPlayGame.Click
        Me.Hide()
        Game.Show()
    End Sub

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        Me.Hide()
        Scores.Show()
    End Sub

    Private Sub btnInstrucitions_Click(sender As Object, e As EventArgs) Handles btnInstrucitions.Click
        Me.Hide()
        Instructions.Show()
    End Sub
End Class