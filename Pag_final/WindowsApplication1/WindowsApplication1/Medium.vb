
Public Class Medium

    Dim interval As Integer
    Dim HP As Integer = 100
    Public Shared punctaj As Integer = 0
    Dim nr_gloante As Integer = 4
    Dim gloante_total As Integer = 0
    Dim gloante_nimerite As Integer = 0
    Dim coordx As Integer 'setam coordonata lui x pentru a face miscarea armei

    Dim seconds As Integer = 4

    Private Sub Timer_start_Tick(sender As Object, e As EventArgs) Handles Timer_start1.Tick
        Timer_start1.Interval = 1000
        seconds = seconds - 1
        If seconds = 3 Then
            Label11.Visible = True
            Label11.Text = seconds.ToString
        ElseIf seconds = 2 Then
            Label11.Text = seconds.ToString
        ElseIf seconds = 1 Then
            Label11.Text = seconds.ToString
        ElseIf seconds = 0 Then
            Label11.Text = "GO"
            Label11.Visible = False
            Timer_start1.Stop()
            Timer_start1.Enabled = False
            Timer_gen1.Start()
            Cursor.Show()
        End If
    End Sub

    Private Sub hp_minus()
        If HP <= 0 Then
            pierdut()

        Else
            HP = HP - 5
            lbl_Hp1.Text = "HP" & HP

        End If
    End Sub
    Private Sub reset()
        HP = 100
        punctaj = 0
        Timer_gen1.Start()
        Timer_soldat11.Start()
        Timer_soldat22.Start()
        Timer_soldat33.Start()
        Timer_soldat44.Start()
        Timer_soldat55.Start()
        Timer_soldat66.Start()
        Me.Close()
        Start.Show()

    End Sub
    Private Sub pierdut()
        Timer_gen1.Stop()
        Timer_soldat11.Stop()
        Timer_soldat22.Stop()
        Timer_soldat33.Stop()
        Timer_soldat44.Stop()
        Timer_soldat55.Stop()
        Timer_soldat66.Stop()
        HighScoreTable_Medium()

        Dim rezultat As Integer = MsgBox("ai pierdut si ai obtinut" & punctaj & "puncte" & vbCrLf & "Ai folosit:" & gloante_total & " Nimerite " & gloante_nimerite & vbCrLf & "Acuratete:" & gloante_nimerite * 100 / gloante_total & "%" & vbCrLf & "Doriti sa mai jucati?", vbYesNo)
        If rezultat = DialogResult.Yes Then
            reset()

            Return
        ElseIf rezultat = DialogResult.No Then
            End
        End If
        'scorebaord


    End Sub
    Private Sub generare_soldati()
        Dim r As New System.Random
        interval = (r.Next(1, 40))
        If interval = 1 Then
            If soldat11.Visible = True Then
            Else
                soldat11.Visible = True
                Timer_soldat11.Start()

            End If
        ElseIf interval = 2 Then
            If Soldat22.Visible = True Then
            Else
                Soldat22.Visible = True
                Timer_soldat22.Start()

            End If
        ElseIf interval = 3 Then

            If soldat33.Visible = True Then
            Else
                soldat33.Visible = True
                Timer_soldat33.Start()

            End If
        ElseIf interval = 4 Then

            If soldat44.Visible = True Then
            Else
                soldat44.Visible = True
                Timer_soldat44.Start()

            End If
        ElseIf interval = 5 Then

            If soldat55.Visible = True Then
            Else
                soldat55.Visible = True
                Timer_soldat55.Start()

            End If
        ElseIf interval = 6 Then

            If soldat66.Visible = True Then
            Else
                soldat66.Visible = True
                Timer_soldat66.Start()

            End If


        End If

    End Sub

    Private Sub soldat1_Click(sender As Object, e As EventArgs) Handles soldat11.Click
        Timer_soldat11.Stop()
        soldat11.Visible = False
        punctaj = punctaj + 50
        lbl_Pct1.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub

    Private Sub Soldat2_Click(sender As Object, e As EventArgs) Handles Soldat22.Click
        Timer_soldat22.Stop()
        Soldat22.Visible = False
        punctaj = punctaj + 50
        lbl_Pct1.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub

    Private Sub soldat3_Click(sender As Object, e As EventArgs) Handles soldat33.Click
        Timer_soldat33.Stop()
        soldat33.Visible = False
        punctaj = punctaj + 50
        lbl_Pct1.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub

    Private Sub soldat4_Click(sender As Object, e As EventArgs) Handles soldat44.Click
        Timer_soldat44.Stop()
        soldat44.Visible = False
        punctaj = punctaj + 50
        lbl_Pct1.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub
    Private Sub soldat55_Click(sender As Object, e As EventArgs) Handles soldat55.Click
        Timer_soldat55.Stop()
        soldat55.Visible = False
        punctaj = punctaj + 50
        lbl_Pct1.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub
    Private Sub soldat66_Click(sender As Object, e As EventArgs) Handles soldat66.Click
        Timer_soldat66.Stop()
        soldat66.Visible = False
        punctaj = punctaj + 50
        lbl_Pct1.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub



    Private Sub Timer_soldat1_Tick(sender As Object, e As EventArgs) Handles Timer_soldat11.Tick
        hp_minus()

    End Sub

    Private Sub Timer_soldat2_Tick(sender As Object, e As EventArgs) Handles Timer_soldat22.Tick
        hp_minus()
    End Sub

    Private Sub Timer_soldat3_Tick(sender As Object, e As EventArgs) Handles Timer_soldat33.Tick
        hp_minus()
    End Sub

    Private Sub Timer_soldat4_Tick(sender As Object, e As EventArgs) Handles Timer_soldat44.Tick
        hp_minus()
    End Sub
    Private Sub Timer_soldat5_Tick(sender As Object, e As EventArgs) Handles Timer_soldat55.Tick
        hp_minus()
    End Sub

    Private Sub Timer_soldat6_Tick(sender As Object, e As EventArgs) Handles Timer_soldat66.Tick
        hp_minus()
    End Sub

    Private Sub Timer_gen_Tick(sender As Object, e As EventArgs) Handles Timer_gen1.Tick
        generare_soldati()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
        Me.Location = New Point(100, 100)
        Me.Size = New Size(720, 540)
        ProgressBar11.Visible = False
        Timer_start1.Start()
        Timer_gen1.Stop()
        My.Computer.Audio.Play(My.Resources.gameplay, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub reincarca()

        ProgressBar11.Visible = True
        ProgressBar11.Minimum = 0
        ProgressBar11.Maximum = 100
        Timer_reincarca1.Start()

    End Sub

    Private Sub Timer_reincarca_Tick(sender As Object, e As EventArgs) Handles Timer_reincarca1.Tick
        ProgressBar11.Increment(20)
        Timer_reincarca1.Interval = 100
        If ProgressBar11.Value = 100 Then
            glont11.Visible = True
            glont22.Visible = True
            glont33.Visible = True
            glont_4.Visible = True
            nr_gloante = 4
            ProgressBar11.Value = 0
            Timer_reincarca1.Stop()
            ProgressBar11.Visible = False
            My.Computer.Audio.Play(My.Resources.reload, AudioPlayMode.Background)
        End If
    End Sub
    Private Sub Easy_Click(sender As Object, e As EventArgs) Handles MyBase.Click, soldat11.Click, Soldat22.Click, soldat33.Click, soldat44.Click, soldat55.Click, soldat66.Click
        nr_gloante = nr_gloante - 1
        If nr_gloante = 3 Then
            glont_4.Visible = False
        ElseIf nr_gloante = 2 Then
            glont11.Visible = False
        ElseIf nr_gloante = 1 Then
            glont22.Visible = False
        ElseIf nr_gloante = 0 Then
            glont33.Visible = False
            reincarca()
        End If
        gloante_total = gloante_total + 1
        My.Computer.Audio.Play(My.Resources.m1_converted, AudioPlayMode.Background)
    End Sub
    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer1.Tick
        arma1.Location = New Point(coordx, Me.Size.Height - 107)
    End Sub
    Private Sub Medium_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        coordx = e.X
    End Sub
End Class
