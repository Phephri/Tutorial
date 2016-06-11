Public Class Start
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(100, 100)
        Me.Size = New Size(720, 540)
        Me.btn_Help.Location = New Point(620, 470)
        Me.btn_info.Location = New Point(540, 470)
        Me.btn_highscore.Location = New Point(450, 470)
        My.Computer.Audio.Play(My.Resources.intro, AudioPlayMode.Background)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        If RadioButton1.Checked = True Then
            Easy.Show()
            Me.Visible = False
            My.Computer.Audio.Stop()
            'dificulate=easy 'marim viteza inamicilor
        ElseIf RadioButton2.Checked = True Then
            Medium.Show()
            Me.Visible = False
            My.Computer.Audio.Stop()
        ElseIf RadioButton3.Checked = True Then
            Hard.Show()
            Me.Visible = False
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub btn_Help_Click(sender As Object, e As EventArgs) Handles btn_Help.Click
        MsgBox("Folositi mouse-ul pentru a tinti,iar pentru a trage foloseste click stanga.Nimereste cat mai multi inamici pentru a castiga.", , "Help")
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        MsgBox("Gemene Petru_USV_FIESC_C3121b",, "Proiect realizat de")
    End Sub

    Private Sub btn_highscore_Click(sender As Object, e As EventArgs) Handles btn_highscore.Click
        Me.Visible = False
        Highscore.Show()
    End Sub
End Class