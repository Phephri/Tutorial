Module Module1
    Friend Form1 As New Easy
    Friend Form2 As New Start
    Sub main()
        Form2.ShowDialog()


    End Sub
    Public Nume_player As String
    Public Sub HighScoreTable_Hard()
        Dim Nume_player As String
        Nume_player = InputBox("Introduceti numele", "Nume jucator")
        If Nume_player <> Nothing And IsNumeric(Nume_player) = False Then
            For i As Integer = 0 To Highscore.lst_Highscore.Items.Count - 1
                If Highscore.lst_Highscore.Items(i) = Nume_player Then
                    MsgBox("Numele se afla deja in lista!")
                    Exit Sub
                End If
            Next
            Highscore.lst_Highscore.Items.Add(Nume_player & vbTab & vbTab & Hard.punctaj)
        Else
            MsgBox("Eroare la introducerea numelui!")
        End If

    End Sub

    Public Sub HighScoreTable_Easy()
        Dim Nume_player As String
        Nume_player = InputBox("Introduceti numele", "Nume jucator")
        If Nume_player <> Nothing And IsNumeric(Nume_player) = False Then
            For i As Integer = 0 To Highscore.lst_Easy.Items.Count - 1
                If Highscore.lst_Easy.Items(i) = Nume_player Then
                    MsgBox("Numele se afla deja in lista!")
                    Exit Sub

                End If
            Next
            Highscore.lst_Easy.Items.Add(Nume_player & vbTab & vbTab & Easy.punctaj)
        Else
            MsgBox("Eroare la introducerea numelui!")
        End If

    End Sub

    Public Sub HighScoreTable_Medium()
        Dim Nume_player As String
        Nume_player = InputBox("Introduceti numele", "Nume jucator")
        If Nume_player <> Nothing And IsNumeric(Nume_player) = False Then
            For i As Integer = 0 To Highscore.lst_Medium.Items.Count - 1
                If Highscore.lst_Medium.Items(i) = Nume_player Then
                    MsgBox("Numele se afla deja in lista!")
                    Exit Sub

                End If
            Next
            Highscore.lst_Medium.Items.Add(Nume_player & vbTab & vbTab & Medium.punctaj)
        Else
            MsgBox("Eroare la introducerea numelui!")
        End If

    End Sub
End Module
