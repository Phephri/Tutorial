
Public Class Easy

    Dim interval As Integer 'variabila folosita pentru generarea random a soldatilor
    Dim HP As Integer = 100 'variabila folosita pentru indicarea Hp-ului
    Public Shared punctaj As Integer = 0 'Punctajul obtinut
    Dim nr_gloante As Integer = 3 'numar de gloante predefinite
    Dim gloante_total As Integer = 0 'numarul total de gloante folosite
    Dim gloante_nimerite As Integer = 0 'numarul de gloante nimerite
    Dim coordx As Integer 'setam coordonata lui x pentru a face miscarea armei
    Dim seconds As Integer = 4 'variabila folosita pentru animatia de intro 3,2,1 

    Private Sub Timer_start_Tick(sender As Object, e As EventArgs) Handles Timer_start.Tick
        Timer_start.Interval = 1000
        seconds = seconds - 1
        If seconds = 3 Then
            Label1.Visible = True
            Label1.Text = seconds.ToString
        ElseIf seconds = 2 Then
            Label1.Text = seconds.ToString
        ElseIf seconds = 1 Then
            Label1.Text = seconds.ToString
        ElseIf seconds = 0 Then
            Label1.Text = "GO"
            Label1.Visible = False
            Timer_start.Stop()
            Timer_start.Enabled = False
            Timer_gen.Start()
            Cursor.Show()
        End If
    End Sub

    Private Sub hp_minus()
        If HP <= 0 Then
            pierdut()
        Else
            HP = HP - 5
            lbl_Hp.Text = "HP" & HP

        End If
    End Sub
    Private Sub reset()
        HP = 100
        punctaj = 0
        Timer_gen.Start()
        Timer_soldat1.Start()
        Timer_soldat2.Start()
        Timer_soldat3.Start()
        Timer_soldat4.Start()
        Me.Close()
        Start.Show()

    End Sub
    Private Sub pierdut()
        Timer_gen.Stop()
        Timer_soldat1.Stop()
        Timer_soldat2.Stop()
        Timer_soldat3.Stop()
        Timer_soldat4.Stop()
        HighScoreTable_Easy()
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
        interval = (r.Next(1, 25))
        If interval = 1 Then
            If soldat1.Visible = True Then
            Else
                soldat1.Visible = True
                Timer_soldat1.Start()

            End If
        ElseIf interval = 2 Then
            If Soldat2.Visible = True Then
            Else
                Soldat2.Visible = True
                Timer_soldat2.Start()

            End If
        ElseIf interval = 3 Then

            If soldat3.Visible = True Then
            Else
                soldat3.Visible = True
                Timer_soldat3.Start()
            End If
        ElseIf interval = 4 Then
            If soldat4.Visible = True Then
            Else
                soldat4.Visible = True
                Timer_soldat4.Start()
            End If
        End If
    End Sub

    Private Sub soldat1_Click(sender As Object, e As EventArgs) Handles soldat1.Click
        Timer_soldat1.Stop()
        soldat1.Visible = False
        punctaj = punctaj + 50
        lbl_Pct.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub

    Private Sub Soldat2_Click(sender As Object, e As EventArgs) Handles Soldat2.Click
        Timer_soldat2.Stop()
        Soldat2.Visible = False
        punctaj = punctaj + 50
        lbl_Pct.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub

    Private Sub soldat3_Click(sender As Object, e As EventArgs) Handles soldat3.Click
        Timer_soldat3.Stop()
        soldat3.Visible = False
        punctaj = punctaj + 50
        lbl_Pct.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub

    Private Sub soldat4_Click(sender As Object, e As EventArgs) Handles soldat4.Click
        Timer_soldat4.Stop()
        soldat4.Visible = False
        punctaj = punctaj + 50
        lbl_Pct.Text = "Score" & punctaj
        gloante_nimerite = gloante_nimerite + 1
    End Sub

    Private Sub Timer_soldat1_Tick(sender As Object, e As EventArgs) Handles Timer_soldat1.Tick
        hp_minus()

    End Sub

    Private Sub Timer_soldat2_Tick(sender As Object, e As EventArgs) Handles Timer_soldat2.Tick
        hp_minus()
    End Sub

    Private Sub Timer_soldat3_Tick(sender As Object, e As EventArgs) Handles Timer_soldat3.Tick
        hp_minus()
    End Sub

    Private Sub Timer_soldat4_Tick(sender As Object, e As EventArgs) Handles Timer_soldat4.Tick
        hp_minus()
    End Sub

    Private Sub Timer_gen_Tick(sender As Object, e As EventArgs) Handles Timer_gen.Tick
        generare_soldati()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
        Me.Location = New Point(100, 100)
        Me.Size = New Size(720, 540)
        ProgressBar1.Visible = False
        Timer_start.Start()
        Timer_gen.Stop()
        My.Computer.Audio.Play(My.Resources.gameplay, AudioPlayMode.Background)


    End Sub

    Private Sub reincarca()

        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        Timer_reincarca.Start()

    End Sub

    Private Sub Timer_reincarca_Tick(sender As Object, e As EventArgs) Handles Timer_reincarca.Tick

        ProgressBar1.Increment(20)
        Timer_reincarca.Interval = 100
        If ProgressBar1.Value = 100 Then
            glont1.Visible = True
            glont2.Visible = True
            glont3.Visible = True
            nr_gloante = 3
            ProgressBar1.Value = 0
            Timer_reincarca.Stop()
            ProgressBar1.Visible = False
            My.Computer.Audio.Play(My.Resources.reload, AudioPlayMode.Background)
        End If
    End Sub



    Private Sub Easy_Click(sender As Object, e As EventArgs) Handles MyBase.Click, soldat1.Click, Soldat2.Click, soldat3.Click, soldat4.Click
        nr_gloante = nr_gloante - 1
        If nr_gloante = 2 Then
            glont1.Visible = False
        ElseIf nr_gloante = 1 Then
            glont2.Visible = False
        ElseIf nr_gloante = 0 Then
            glont3.Visible = False
            reincarca()
        End If
        gloante_total = gloante_total + 1
        My.Computer.Audio.Play(My.Resources.m1_converted, AudioPlayMode.Background)

    End Sub
    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        arma.Location = New Point(coordx, Me.Size.Height - 110)
    End Sub
    Private Sub Easy_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        coordx = e.X
    End Sub
End Class
