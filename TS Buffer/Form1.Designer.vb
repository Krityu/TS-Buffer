<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ReactorTheme1 = New TS_Buffer.ReactorTheme()
        Me.ReactorTabControl1 = New TS_Buffer.ReactorTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        Me.ReactorTheme1.SuspendLayout()
        Me.ReactorTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReactorTheme1
        '
        Me.ReactorTheme1.BackColor = System.Drawing.SystemColors.ControlText
        Me.ReactorTheme1.Controls.Add(Me.ReactorTabControl1)
        Me.ReactorTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReactorTheme1.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.ReactorTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ReactorTheme1.Name = "ReactorTheme1"
        Me.ReactorTheme1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ReactorTheme1.Size = New System.Drawing.Size(274, 342)
        Me.ReactorTheme1.TabIndex = 0
        Me.ReactorTheme1.Text = "TS Buffer - RoninsfromPS"
        '
        'ReactorTabControl1
        '
        Me.ReactorTabControl1.Controls.Add(Me.TabPage1)
        Me.ReactorTabControl1.Controls.Add(Me.TabPage2)
        Me.ReactorTabControl1.Controls.Add(Me.TabPage3)
        Me.ReactorTabControl1.Location = New System.Drawing.Point(-6, 23)
        Me.ReactorTabControl1.Name = "ReactorTabControl1"
        Me.ReactorTabControl1.SelectedIndex = 2
        Me.ReactorTabControl1.Size = New System.Drawing.Size(285, 329)
        Me.ReactorTabControl1.TabBorderColor = System.Drawing.Color.White
        Me.ReactorTabControl1.TabIndex = 2
        Me.ReactorTabControl1.TabTextColor = System.Drawing.Color.White
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(277, 300)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Buffer"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(-2, -16)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(278, 313)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://neizrt.eu/ts3wi2", System.UriKind.Absolute)
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.WebBrowser2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(277, 300)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "News"
        '
        'WebBrowser2
        '
        Me.WebBrowser2.AllowWebBrowserDrop = False
        Me.WebBrowser2.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser2.Location = New System.Drawing.Point(1, -16)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScrollBarsEnabled = False
        Me.WebBrowser2.Size = New System.Drawing.Size(278, 317)
        Me.WebBrowser2.TabIndex = 0
        Me.WebBrowser2.Url = New System.Uri("http://krityu.eu/tsbuffer/news.html", System.UriKind.Absolute)
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.WebBrowser3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(277, 300)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Anoucments"
        '
        'WebBrowser3
        '
        Me.WebBrowser3.AllowWebBrowserDrop = False
        Me.WebBrowser3.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser3.Location = New System.Drawing.Point(1, -16)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.ScrollBarsEnabled = False
        Me.WebBrowser3.Size = New System.Drawing.Size(278, 313)
        Me.WebBrowser3.TabIndex = 0
        Me.WebBrowser3.Url = New System.Uri("http://krityu.eu/tsbuffer/anoucments.html", System.UriKind.Absolute)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 342)
        Me.Controls.Add(Me.ReactorTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "TS Buffer - RoninsfromPS"
        Me.ReactorTheme1.ResumeLayout(False)
        Me.ReactorTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReactorTheme1 As ReactorTheme
    Friend WithEvents ReactorTabControl1 As ReactorTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents WebBrowser2 As WebBrowser
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents WebBrowser3 As WebBrowser
End Class
