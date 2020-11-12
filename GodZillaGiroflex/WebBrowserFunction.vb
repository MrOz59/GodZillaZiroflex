Public Class WebBrowserFunction
    Inherits WebBrowser
    Private Sub WebBrowserDocCompl() Handles Me.DocumentCompleted
        Dim tabpage As TabPage = Me.Tag
        Dim Usercontrol1 As New UserControl1
        tabpage.Text = Me.DocumentTitle
        Usercontrol1.LTextBox1.Text = Me.Url.ToString


    End Sub
End Class
