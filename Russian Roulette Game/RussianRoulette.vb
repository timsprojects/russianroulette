Imports System.IO
Public Class RussianRoulette
    Private rand As New Random
    Private strPlayerName As String
    Private intGunState As Integer = 0
    Private intScore As Integer = 0
    Private intGameCount As Integer = 0
    Private intGameLossCount As Integer = 0
    Private intShotCount As Integer = 0
    Private intPointatHeadCount As Integer = 2
    Private blnPointAtHead As Boolean = True
    Private intChamberPosition As Integer = 0
    Private strGameOutcome As String = ""

    Public Function GetGunState()
        Return intGunState
    End Function

    Public Function GetShotCount()
        Return intShotCount
    End Function

    Public Function GetScore()
        Return intScore
    End Function

    Public Function GetChamberPosition()
        Return intChamberPosition
    End Function

    Public Function GetGameCount()
        Return intGameCount
    End Function

    Public Function GetGameLossCount()
        Return intGameLossCount
    End Function

    Public Function GetGameOutcome()
        Return strGameOutcome
    End Function

    Public Sub CalculateScore()
        ' Score is calculated as the percentages of games won
        intScore = ((intGameCount - intGameLossCount) / intGameCount) * 100
    End Sub

    Public Function CheckPointatHeadcount()
        ' Manages the Point Away option to ensure that this is limited to two per game
        If intPointatHeadCount = 0 Then
            blnPointAtHead = True
            Return "False"
        Else Return "True"
        End If
    End Function

    Public Function GetPointAtHeadState()
        ' Checks if the gun is pointed at the players head
        Return blnPointAtHead
    End Function

    Public Sub UpdatePlayerName(EnteredName As String)
        ' Updates the player name in the variable from the data entered in the UI
        strPlayerName = EnteredName
    End Sub

    Public Sub UpdatePointAtHeadState(State As Boolean)
        blnPointAtHead = State
    End Sub

    Public Sub UpdateGunState(NewState As Integer)
        intGunState = NewState
        If intGunState = 1 Then
            intChamberPosition = 1
        ElseIf intGunState = 2 Then
            ' Determine a random position for the bullet after the chambers have been spun
            intChamberPosition = rand.Next(1, 7)
        End If
    End Sub

    Public Sub Fire()
        ' Manages the Fire Function - Increments the shot count, checks if the game has ended then moves the bullet to the next chamber
        If GetPointAtHeadState() = True Then
            My.Computer.Audio.Play(My.Resources.shot, AudioPlayMode.Background)
            intShotCount += 1
            EndGameCheck()
            intChamberPosition -= 1
        ElseIf GetPointAtHeadState() = False Then
            My.Computer.Audio.Play(My.Resources.shot, AudioPlayMode.Background)
            intShotCount += 1
            EndGameCheck()
            intPointatHeadCount -= 1
            intChamberPosition -= 1
        End If
    End Sub

    Public Sub EndGameCheck()
        ' Checks to determine if the current game has ended either as a result of the player shooting themself
        ' or if they can point away for the two remaining shots. Program assumes optimal play on the part of the player
        If intChamberPosition = 1 And blnPointAtHead = False Then
            EndGame(True)
        ElseIf intChamberPosition = 1 And blnPointAtHead = True Then
            EndGame(False)
        ElseIf intPointatHeadCount = 0 Then
            EndGame(False)
        ElseIf intShotCount = 4 And intPointatHeadCount = 2 Then
            EndGame(True)
        End If
    End Sub

    Public Sub EndGame(Success As Boolean)
        ' Manages the end game, increments the play count and loss count if applicable and advises the player
        If Success = True Then
            intGameCount += 1
            strGameOutcome = "You Win"
            intGunState = 3
            CalculateScore()
        ElseIf Success = False Then
            intGameLossCount += 1
            intGameCount += 1
            strGameOutcome = "You Lose"
            intGunState = 3
            CalculateScore()
        End If
    End Sub

    Public Function ActionRequired()
        ' Provides instructions to the player throughout play as to what action is required next
        Dim NextAction As String = ""
        If Game.AvatarCount = 0 Then
            NextAction = "Click the Player Image Box to select your avatar"
        ElseIf strPlayerName = "" And GetGunState() = 0 Then
            NextAction = "Type your name in the Player Name box and press Enter"
        ElseIf strPlayerName <> "" And GetGunState() = 0 Then
            NextAction = "You need to load the revolver to start"
        ElseIf GetGunState() = 1 Then
            NextAction = "You need to spin the chambers"
        ElseIf GetGunState() = 2 Then
            NextAction = "Fire when ready. You have " & intPointatHeadCount & " chances to point the gun away"
        ElseIf GetGunState() = 3 Then
            NextAction = strGameOutcome & "!" & " You have played " & intGameCount & " games and won " & intGameCount - intGameLossCount
        End If
        Return NextAction
    End Function

    Public Sub NewGame()
        ' Resets variables for a new game with the exception of the game and loss count which are running totals
        intShotCount = 0
        intPointatHeadCount = 2
        blnPointAtHead = True
        intChamberPosition = 0
        strGameOutcome = ""
        intGunState = 0
    End Sub

    Public Sub SaveScores()
        ' Saves scores to a txt file
        Dim profilepath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim path As String = profilepath & "\Saved Games\Scores.Txt"
        Dim sw As StreamWriter
        If File.Exists(path) = False Then
            sw = File.CreateText(path)
            sw.WriteLine(strPlayerName & "," & intGameCount & "," & intGameCount - intGameLossCount & "," & intScore)
            sw.Flush()
            sw.Close()

        Else sw = File.AppendText(path)
            sw.WriteLine(strPlayerName & "," & intGameCount & "," & intGameCount - intGameLossCount & "," & intScore)
            sw.Flush()
            sw.Close()
        End If
    End Sub

End Class
