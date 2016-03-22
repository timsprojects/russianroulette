Imports System.IO
Public Class Scores
    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetScores()
        dgvScores.Sort(dgvScores.Columns(3), System.ComponentModel.ListSortDirection.Descending)
        dgvScores.ClearSelection()
    End Sub
    Private Sub GetScores()
        Dim profilepath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim path As String = profilepath & "\Saved Games\Scores.Txt"
        Dim Line As String

        Try
            Dim fileread As StreamReader
            fileread = New StreamReader(path)

            Do Until fileread.EndOfStream
                Line = fileread.ReadLine
                Dim Scores() As String = Line.Split(",")
                dgvScores.Rows.Add(Scores(0), Scores(1), Scores(2), Scores(3))
            Loop

            fileread.Close()
        Catch ex As FileNotFoundException
            MsgBox("There are no scores recorded yet on this computer. Play 10 games now to automatically become top of the score table.")
        Catch ex As Exception
            MsgBox("File reading error: " & ex.Message)
        End Try
    End Sub
End Class