<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helphome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(helphome))
        Me.HelpBrowser = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'HelpBrowser
        '
        Me.HelpBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpBrowser.Location = New System.Drawing.Point(0, 0)
        Me.HelpBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HelpBrowser.Name = "HelpBrowser"
        Me.HelpBrowser.Size = New System.Drawing.Size(399, 541)
        Me.HelpBrowser.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(399, 541)
        Me.WebBrowser1.TabIndex = 1
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(399, 541)
        Me.WebBrowser2.TabIndex = 2
        Me.WebBrowser2.Url = New System.Uri("http://minecraft-mod-installer.weebly.com/mobile/detailed-help-pages.html", System.UriKind.Absolute)
        '
        'helphome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 541)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.HelpBrowser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "helphome"
        Me.Text = "Help"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HelpBrowser As WebBrowser
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents WebBrowser2 As WebBrowser
End Class
