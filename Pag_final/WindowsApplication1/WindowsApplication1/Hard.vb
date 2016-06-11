
Public Class Hard

    Dim interval As Integer
    Dim HP As Integer = 100
    Public Shared punctaj As Integer = 0
    Dim nr_gloante As Integer = 5
    Dim gloante_total As Integer = 0
    Dim gloante_nimerite As Integer = 0
    Dim coordx As Integer 'setam coordonata lui x pentru a face miscarea armei

    Dim seconds As Integer = 4

    Private Sub Timer_start_Tick(sender As Object, e As EventArgs) Handles Timer_start11.Tick
        Timer_start11.Interval = 1000
        seconds = seconds - 1
        If seconds = 3 Then
            Label111.Visible = True
            Label111.Text = seconds.ToString
        ElseIf seconds = 2 Then
            Label111.Text = seconds.ToString
        ElseIf seconds = 1 Then
            Label111.Text = seconds.ToString
        ElseIf seconds = 0 Then
            Label111.Text = "GO"
            Label111.Visible = False
            Timer_start11.Stop()
            Timer_start11.Enabled = False
            Timer_gen11.Start()
            Cursor.Show()
        End If
    End Sub

    Private Sub hp_minus()
        If HP <= 0 Then
            pierdut()

        Else
            HP = HP - 5
            lbl_Hp111.Text = "HP" & HP

        End If
    End Sub
    Private Sub reset()
        HP = 100
        punctaj = 0
        Timer_gen11.Start()
        Timer_soldat111.Start()
        Timer_soldat222.Start()
        Timer_soldat333.Start()
        Timer_soldat444.Start()
        Timer_soldat555.Start()
        Timer_soldat666.Start()
        Timer_soldat777.Start()
        Timer_soldat888.Start()
        Me.Close()
        Start.Show()

    End Sub
    Private Sub pierdut()
        Timer_gen11.Stop()
        Timer_soldat111.Stop()
        Timer_soldat222.Stop()
        Timer_soldat333.Stop()
        Timer_soldat444.Stop()
        Timer_soldat555.Stop()
        Timer_soldat666.Stop()
        Timer_soldat777.Stop()
        Timer_soldat888.Stop()
        HighScoreTable_Hard()

        Dim rezultat As Integer = MsgBox("ai pierdut si ai obtinut" & punctaj & "puncte" & vbCrLf & "Ai folosit:" & gloante_total & " Nimerite " & gloante_nimerite & vbCrLf & "Acuratete:" & gloante_nimerite * 100 / gloante_total & "%" & vbCrLf & "Doriti sa mai jucati?", vbYesNo)
        If rezultat = DialogResult.Yes Then
            reset()
        ElseIf rezultat = DialogResult.No Then
            Me.Close()
        End If
        'scorebaord
    End Sub

    Private Sub generare_soldati()
        Dim r As New System.Random
        interval = (r.Next(1, 60))
        If interval = 1 Then
            If soldat111.Visible = True Then
            Else
                soldat111.Visible = True
                Timer_soldat111.Start()

            End If
        ElseIf interval = 2 Then
            If Soldat222.Visible = True Then
            Else
                Soldat222.Visible = True
                Timer_soldat222.Start()

            End If
        ElseIf interval = 3 Then

            If soldat333.Visible = True Then
            Else
                soldat333.Visible = True
                Timer_soldat333.Start()

            End If
        ElseIf interval = 4 Then

            If soldat444.Visible = True Then
            Else
                soldat444.Visible = True
                Timer_soldat444.Start()

            End If
        ElseIf interval = 5 Then

            If soldat555.Visible = True Then
            Else
                soldat555.Visible = True
                Timer_soldat555.Start()

            End If
        ElseIf interval = 6 Then

            If soldat666.Visible = True Then
            Else
                soldat666.Visible = True
                Timer_soldat666.Start()

            End If
        ElseIf interval = 8 Then

            If soldat888.Visible = True Then
            Else

                soldat888.Visible = True
                Timer_soldat888.Start()

            End If
        ElseIf interval = 7 Then

            If soldat777.Visible = True Then
            Else
                soldat777.Visible = True
                Timer_soldat777.Start()

            End If


        End If

    End Sub

    Private Sub soldat1_Click(sender As Object, e As EventArgs) Handles soldat111.Click
        Timer_soldat111.Stop()
        soldat111.Visible = False
        punctaj = punctaj + 50
        lbl_Pct111.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub

    Private Sub Soldat2_Click(sender As Object, e As EventArgs) Handles Soldat222.Click
        Timer_soldat222.Stop()
        Soldat222.Visible = False
        punctaj = punctaj + 50
        lbl_Pct111.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub

    Private Sub soldat3_Click(sender As Object, e As EventArgs) Handles soldat333.Click
        Timer_soldat333.Stop()
        soldat333.Visible = False
        punctaj = punctaj + 50
        lbl_Pct111.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub

    Private Sub soldat4_Click(sender As Object, e As EventArgs) Handles soldat444.Click
        Timer_soldat444.Stop()
        soldat444.Visible = False
        punctaj = punctaj + 50
        lbl_Pct111.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub
    Private Sub soldat55_Click(sender As Object, e As EventArgs) Handles soldat555.Click
        Timer_soldat555.Stop()
        soldat555.Visible = False
        punctaj = punctaj + 50
        lbl_Pct111.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub
    Private Sub soldat66_Click(sender As Object, e As EventArgs) Handles soldat666.Click
        Timer_soldat666.Stop()
        soldat666.Visible = False
        punctaj = punctaj + 50
        lbl_Pct111.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub
    Private Sub soldat777_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles soldat777.MouseDoubleClick
        Timer_soldat777.Stop()
        soldat777.Visible = False
        punctaj = punctaj + 70
        lbl_Pct111.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 2
    End Sub
    Private Sub soldat777_Click(sender As Object, e As EventArgs) Handles soldat777.Click

    End Sub
    Private Sub soldat888_Click(sender As Object, e As EventArgs) Handles soldat888.Click
        Timer_soldat888.Stop()
        soldat888.Visible = False
        punctaj = punctaj + 50
        lbl_Pct111.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub



    Private Sub Timer_soldat1_Tick(sender As Object, e As EventArgs) Handles Timer_soldat111.Tick
        hp_minus()

    End Sub

    Private Sub Timer_soldat2_Tick(sender As Object, e As EventArgs) Handles Timer_soldat222.Tick
        hp_minus()
    End Sub

    Private Sub Timer_soldat3_Tick(sender As Object, e As EventArgs) Handles Timer_soldat333.Tick
        hp_minus()
    End Sub

    Private Sub Timer_soldat4_Tick(sender As Object, e As EventArgs) Handles Timer_soldat444.Tick
        hp_minus()
    End Sub
    Private Sub Timer_soldat5_Tick(sender As Object, e As EventArgs) Handles Timer_soldat333.Tick
        hp_minus()
    End Sub

    Private Sub Timer_soldat6_Tick(sender As Object, e As EventArgs) Handles Timer_soldat444.Tick
        hp_minus()
    End Sub
    Private Sub Timer_soldat7_Tick(sender As Object, e As EventArgs) Handles Timer_soldat777.Tick
        hp_minus()
    End Sub
    Private Sub Timer_soldat8_Tick(sender As Object, e As EventArgs) Handles Timer_soldat888.Tick
        hp_minus()

    End Sub

    Private Sub Timer_gen_Tick(sender As Object, e As EventArgs) Handles Timer_gen11.Tick
        generare_soldati()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
        Me.Location = New Point(100, 100)
        Me.Size = New Size(720, 540)
        ProgressBar111.Visible = False
        Timer_start11.Start()
        Timer_gen11.Stop()



    End Sub

    Private Sub reincarca()

        ProgressBar111.Visible = True
        ProgressBar111.Minimum = 0
        ProgressBar111.Maximum = 100
        Timer_reincarca11.Start()

    End Sub

    Private Sub Timer_reincarca_Tick(sender As Object, e As EventArgs) Handles Timer_reincarca11.Tick

        ProgressBar111.Increment(20)
        Timer_reincarca11.Interval = 100
        If ProgressBar111.Value = 100 Then
            glont111.Visible = True
            glont222.Visible = True
            glont333.Visible = True
            glont_4.Visible = True
            glont_5.Visible = True

            nr_gloante = 5
            ProgressBar111.Value = 0
            Timer_reincarca11.Stop()
            ProgressBar111.Visible = False

            My.Computer.Audio.Play(My.Resources.reload, AudioPlayMode.Background)
        End If
    End Sub



    Private Sub Easy_Click(sender As Object, e As EventArgs) Handles MyBase.Click, soldat111.Click, Soldat222.Click, soldat333.Click, soldat444.Click, soldat555.Click, soldat666.Click, soldat777.Click, soldat888.Click


        nr_gloante = nr_gloante - 1
        If nr_gloante = 4 Then
            glont_5.Visible = False
        ElseIf nr_gloante = 3 Then
            glont_4.Visible = False

        ElseIf nr_gloante = 2 Then
            glont111.Visible = False
        ElseIf nr_gloante = 1 Then
            glont222.Visible = False
        ElseIf nr_gloante = 0 Then
            glont333.Visible = False
            reincarca()


        End If
        gloante_total = gloante_total + 1
        My.Computer.Audio.Play(My.Resources.m1_converted, AudioPlayMode.Background)

    End Sub
    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer2.Tick
        arma2.Location = New Point(coordx, Me.Size.Height - 110)
    End Sub
    Private Sub Hard_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        coordx = e.X
    End Sub

    Public Sub Method()

    End Sub


End Class
