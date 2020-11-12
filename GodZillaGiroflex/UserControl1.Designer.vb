<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.back = New System.Windows.Forms.ToolStripButton()
        Me.reload = New System.Windows.Forms.ToolStripButton()
        Me.up = New System.Windows.Forms.ToolStripButton()
        Me.LTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.Search = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.downloads = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.options = New System.Windows.Forms.ToolStripButton()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.back, Me.reload, Me.up, Me.LTextBox1, Me.Search, Me.SearchTextBox, Me.downloads, Me.ToolStripButton1, Me.options})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(787, 28)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'back
        '
        Me.back.AutoSize = False
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.back.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(40, 25)
        Me.back.Text = "ToolStripButton1"
        '
        'reload
        '
        Me.reload.AutoSize = False
        Me.reload.BackgroundImage = CType(resources.GetObject("reload.BackgroundImage"), System.Drawing.Image)
        Me.reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.reload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.reload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.reload.Name = "reload"
        Me.reload.Size = New System.Drawing.Size(40, 25)
        Me.reload.Text = "ToolStripButton1"
        '
        'up
        '
        Me.up.AutoSize = False
        Me.up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.up.Image = Global.GodZillaGiroflex.My.Resources.Resources.BotãoAvancarDireito
        Me.up.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.up.Name = "up"
        Me.up.Size = New System.Drawing.Size(40, 25)
        Me.up.Text = "ToolStripButton1"
        '
        'LTextBox1
        '
        Me.LTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.LTextBox1.AutoSize = False
        Me.LTextBox1.Name = "LTextBox1"
        Me.LTextBox1.Size = New System.Drawing.Size(400, 25)
        '
        'Search
        '
        Me.Search.AutoSize = False
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(80, 23)
        '
        'SearchTextBox
        '
        Me.SearchTextBox.AutoSize = False
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(150, 28)
        '
        'downloads
        '
        Me.downloads.AutoSize = False
        Me.downloads.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.downloads.Image = CType(resources.GetObject("downloads.Image"), System.Drawing.Image)
        Me.downloads.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.downloads.Name = "downloads"
        Me.downloads.Size = New System.Drawing.Size(40, 25)
        Me.downloads.Text = "ToolStripButton1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(40, 25)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'options
        '
        Me.options.AutoSize = False
        Me.options.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.options.Image = CType(resources.GetObject("options.Image"), System.Drawing.Image)
        Me.options.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.options.Name = "options"
        Me.options.Size = New System.Drawing.Size(40, 25)
        Me.options.Text = "ToolStripButton1"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 28)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(787, 122)
        Me.WebBrowser1.TabIndex = 5
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(787, 150)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As ToolStripButton
    Friend WithEvents reload As ToolStripButton
    Friend WithEvents up As ToolStripButton
    Friend WithEvents LTextBox1 As ToolStripTextBox
    Friend WithEvents Search As ToolStripComboBox
    Friend WithEvents SearchTextBox As ToolStripTextBox
    Friend WithEvents downloads As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents options As ToolStripButton
    Public WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
