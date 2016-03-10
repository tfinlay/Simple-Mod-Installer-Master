<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollectionView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CollectionView))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.DelMod = New System.Windows.Forms.Button()
        Me.AddMod = New System.Windows.Forms.Button()
        Me.ModList = New System.Windows.Forms.CheckedListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MCversion = New System.Windows.Forms.Label()
        Me.ModCount = New System.Windows.Forms.Label()
        Me.ActivateCollection = New System.Windows.Forms.Button()
        Me.CollectionView_RefreshButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "< Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.LightCoral
        Me.LinkLabel1.Location = New System.Drawing.Point(14, 534)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(201, 13)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://minecraft-mod-installer.weebly.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 521)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "For Help and Tutorials Visit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(63, 508)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Created By Tfff1"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.SystemColors.Control
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Title.Location = New System.Drawing.Point(223, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(131, 42)
        Me.Title.TabIndex = 15
        Me.Title.Text = "Label1"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DelMod
        '
        Me.DelMod.Location = New System.Drawing.Point(826, 53)
        Me.DelMod.Name = "DelMod"
        Me.DelMod.Size = New System.Drawing.Size(75, 38)
        Me.DelMod.TabIndex = 16
        Me.DelMod.Text = "Remove Selected"
        Me.DelMod.UseVisualStyleBackColor = True
        '
        'AddMod
        '
        Me.AddMod.Location = New System.Drawing.Point(745, 53)
        Me.AddMod.Name = "AddMod"
        Me.AddMod.Size = New System.Drawing.Size(75, 38)
        Me.AddMod.TabIndex = 17
        Me.AddMod.Text = "Add Mods"
        Me.AddMod.UseVisualStyleBackColor = True
        '
        'ModList
        '
        Me.ModList.CheckOnClick = True
        Me.ModList.FormattingEnabled = True
        Me.ModList.Location = New System.Drawing.Point(745, 97)
        Me.ModList.Name = "ModList"
        Me.ModList.Size = New System.Drawing.Size(305, 424)
        Me.ModList.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(907, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 37)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Open Config Folder"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MCversion
        '
        Me.MCversion.AutoSize = True
        Me.MCversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCversion.Location = New System.Drawing.Point(15, 97)
        Me.MCversion.Name = "MCversion"
        Me.MCversion.Size = New System.Drawing.Size(252, 25)
        Me.MCversion.TabIndex = 20
        Me.MCversion.Text = "Minecraft Version: 1.7.10"
        '
        'ModCount
        '
        Me.ModCount.AutoSize = True
        Me.ModCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModCount.Location = New System.Drawing.Point(15, 126)
        Me.ModCount.Name = "ModCount"
        Me.ModCount.Size = New System.Drawing.Size(141, 25)
        Me.ModCount.TabIndex = 21
        Me.ModCount.Text = "Mod Count: 0"
        '
        'ActivateCollection
        '
        Me.ActivateCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivateCollection.Location = New System.Drawing.Point(12, 547)
        Me.ActivateCollection.Name = "ActivateCollection"
        Me.ActivateCollection.Size = New System.Drawing.Size(1038, 37)
        Me.ActivateCollection.TabIndex = 22
        Me.ActivateCollection.Text = "Activate Collection (this will deactivate your current Collection)"
        Me.ActivateCollection.UseVisualStyleBackColor = True
        '
        'CollectionView_RefreshButton
        '
        Me.CollectionView_RefreshButton.Location = New System.Drawing.Point(93, 12)
        Me.CollectionView_RefreshButton.Name = "CollectionView_RefreshButton"
        Me.CollectionView_RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.CollectionView_RefreshButton.TabIndex = 23
        Me.CollectionView_RefreshButton.Text = "Refresh"
        Me.CollectionView_RefreshButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 154)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(255, 55)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "View Modded Folders" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " \flan etc."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CollectionView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1062, 596)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CollectionView_RefreshButton)
        Me.Controls.Add(Me.ActivateCollection)
        Me.Controls.Add(Me.ModCount)
        Me.Controls.Add(Me.MCversion)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ModList)
        Me.Controls.Add(Me.AddMod)
        Me.Controls.Add(Me.DelMod)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CollectionView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CollectionView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Public WithEvents Title As Label
    Public WithEvents DelMod As Button
    Public WithEvents AddMod As Button
    Public WithEvents ModList As CheckedListBox
    Public WithEvents Button2 As Button
    Public WithEvents MCversion As Label
    Public WithEvents ModCount As Label
    Public WithEvents ActivateCollection As Button
    Public WithEvents CollectionView_RefreshButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button3 As Button
End Class
