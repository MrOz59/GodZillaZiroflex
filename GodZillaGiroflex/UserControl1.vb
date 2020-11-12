Imports System.IO
Imports System.Net
Public Class UserControl1
    Dim WebBrowser As WebBrowserFunction
    Dim histo As New Historico
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Search.Items.Add("Google")
        Search.Items.Add("Bing")
        Search.SelectedIndex = 0
        If My.Settings.HomeOrBlank = 0 Then

        End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub reload_Click(sender As Object, e As EventArgs) Handles reload.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub up_Click_1(sender As Object, e As EventArgs) Handles up.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub downloads_Click(sender As Object, e As EventArgs) Handles downloads.Click
        Dim tab As New TabPage
        Dim close As New TabPage
        Dim aba As New Historico
        tab.Text = ("Historico")
        close.Text = ("X")
        Form1.TabControl1.TabPages.Add(tab)
        tab.Controls.Add(aba)
        Form1.TabControl1.TabPages.Add(close)
        If Form1.TabControl1.SelectedTab.Tag.Equals("Close") Then
            Form1.TabControl1.SelectTab(Form1.TabControl1.TabPages.Count - 1)
        End If

    End Sub

    Public Sub Ico()
        Dim wc As New WebClient
        Dim memorystream As New MemoryStream(wc.DownloadData("https://" & New Uri(WebBrowser1.Url.ToString).Host & "favicon.ico"))
        Try
            Dim icons As New Icon(memorystream)
            If Form1.ImageList1.Images.Count = -1 Then
                Form1.ImageList1.Images.Add(icons.ToBitmap)
                Form1.TabControl1.SelectedTab.ImageIndex = 0
            Else
                Form1.ImageList1.Images.Clear()
                Form1.ImageList1.Images.Add(icons.ToBitmap)
                Form1.TabControl1.SelectedTab.ImageIndex = 0
            End If
        Catch ex As Exception

        End Try


    End Sub 'Icones das Paginas

    Private Sub SearchTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchTextBox.KeyUp
        Select Case (Search.SelectedIndex)
            Case 0
                If e.KeyCode = Keys.Enter Then
                    WebBrowser1.Navigate("http://www.google.com/?gws_rd=ssl#q=" & SearchTextBox.Text)
                End If'google
            Case 1
                If e.KeyCode = Keys.Enter Then
                    WebBrowser1.Navigate("https://www.bing.com/search?q=" & SearchTextBox.Text)
                End If 'bing

        End Select
    End Sub

    Private Sub LTextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles LTextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(LTextBox1.Text)
        End If

    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim tab As New TabPage
        Dim aba As New Historico
        tab.Text = ("Historico")
        Form1.TabControl1.TabPages.Add(tab)
        tab.Controls.Add(aba)
        Me.Dock = DockStyle.Fill
        aba.Dock = DockStyle.Fill
    End Sub

    Private Sub options_Click(sender As Object, e As EventArgs) Handles options.Click
        ' If Form1.TabControl1.TabPages.Count > 1 Then
        'Form1.TabControl1.TabPages.RemoveAt(Form1.TabControl1.SelectedIndex)
        'Form1.TabControl1.SelectTab(Form1.TabControl1.TabPages.Count - 1)
        'else
        'Form1.Close()
        'End If
        Dim tab As New TabPage
        Dim aba As New Historico
        tab.Text = ("Historico")
        Form1.TabControl1.TabPages.Add(tab)
        tab.Controls.Add(aba)
        Me.Dock = DockStyle.Fill
        aba.Dock = DockStyle.Fill
    End Sub
    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        histo.ListBox1.Items.Add(WebBrowser1.Url.ToString)
    End Sub
End Class
