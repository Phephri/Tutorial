
Public Class Highscore
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Me.Closed
        Me.Visible = False
        Start.Show()
    End Sub
    Private Const APP_NAME_easy As String = "SaveRestoreListBox_easy"
    Private Const SECTION_NAME_easy As String = "Items_easy"
    Private Const APP_NAME_medium As String = "SaveRestoreListBox_medium"
    Private Const SECTION_NAME_medium As String = "Items_medium"
    Private Const APP_NAME_hard As String = "SaveRestoreListBox_hard"
    Private Const SECTION_NAME_hard As String = "Items_hard"
    ' Load saved items from the Registry.
    Private Sub Highscore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'lst_Easy.Items.Clear()
        Dim i As Integer = 0
        Do
            Dim new_value As String = GetSetting(APP_NAME_easy, SECTION_NAME_easy, "Item" & i.ToString())
            If new_value.Length = 0 Then Exit Do
            lst_Easy.Items.Add(new_value)
            i += 1
        Loop
        Dim j As Integer = 0
        Do
            Dim new_value As String = GetSetting(APP_NAME_medium, SECTION_NAME_medium, "Item" & j.ToString())
            If new_value.Length = 0 Then Exit Do
            lst_Medium.Items.Add(new_value)
            j += 1
        Loop
        Dim k As Integer = 0
        Do
            Dim new_value As String = GetSetting(APP_NAME_hard, SECTION_NAME_hard, "Item" & k.ToString())
            If new_value.Length = 0 Then Exit Do
            lst_Highscore.Items.Add(new_value)
            k += 1
        Loop
    End Sub

    Private Sub Highscore_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Delete existing items.
        ' Catch errors in case the section doesn't exist.
        Try
            DeleteSetting(APP_NAME_easy, SECTION_NAME_easy)
        Catch ex As Exception
        End Try
        ' Save the items.
        For i As Integer = 0 To lst_Easy.Items.Count - 1
            SaveSetting(APP_NAME_easy, SECTION_NAME_easy, "Item" & i.ToString(), lst_Easy.Items(i).ToString())
        Next i
        Try
            DeleteSetting(APP_NAME_medium, SECTION_NAME_medium)
        Catch ex As Exception
        End Try
        For j As Integer = 0 To lst_Medium.Items.Count - 1
            SaveSetting(APP_NAME_medium, SECTION_NAME_medium, "Item" & j.ToString(), lst_Medium.Items(j).ToString())
        Next j
        Try
            DeleteSetting(APP_NAME_hard, SECTION_NAME_hard)
        Catch ex As Exception
        End Try
        For k As Integer = 0 To lst_Highscore.Items.Count - 1
            SaveSetting(APP_NAME_hard, SECTION_NAME_hard, "Item" & k.ToString(), lst_Highscore.Items(k).ToString())
        Next k
    End Sub

    Private Sub EasyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyToolStripMenuItem.Click
        lst_Easy.Visible = True
    End Sub

    Private Sub MediumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumToolStripMenuItem.Click
        lst_Medium.Visible = True
    End Sub

    Private Sub HardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardToolStripMenuItem.Click
        lst_Highscore.Visible = True
    End Sub

    Private Sub lst_Medium_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Medium.SelectedIndexChanged

    End Sub


End Class


