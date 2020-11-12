Public Class Historico
    Private Sub Historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.hist = 0 Then
            Button2.Text = ("Desativar o Historico")
        Else
            Button2.Text = ("Ativar o Historico")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.hist = 0 Then
            My.Settings.hist = 1
            Button2.Text = ("Ativar o Historico")
        Else
            My.Settings.hist = 0
            Button2.Text = ("Desativar o Historico")
        End If
    End Sub
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        If Form1.TabControl1.TabPages.Count > 1 Then
            Form1.TabControl1.TabPages.RemoveAt(Form1.TabControl1.SelectedIndex)
            Form1.TabControl1.SelectTab(Form1.TabControl1.TabPages.Count - 1)
        Else
            Form1.Close()
        End If
    End Sub
    Private Sub Close_MouseHover(sender As Object, e As EventArgs) Handles Close.MouseHover
        Close.Image = My.Resources.closebutton2
    End Sub
    Private Sub Close_MouseLeave(sender As Object, e As EventArgs) Handles Close.MouseLeave
        Close.Image = My.Resources.closebutton1
    End Sub
End Class
