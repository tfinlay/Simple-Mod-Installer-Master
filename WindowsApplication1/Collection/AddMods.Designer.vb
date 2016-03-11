<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMods
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMods))
        Me.AddFile_Title = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SingleAdd = New System.Windows.Forms.RadioButton()
        Me.FolderAdd = New System.Windows.Forms.RadioButton()
        Me.SinglePath = New System.Windows.Forms.TextBox()
        Me.SingleBrowse = New System.Windows.Forms.Button()
        Me.FolderBrowse = New System.Windows.Forms.Button()
        Me.FolderPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ModList = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'AddFile_Title
        '
        Me.AddFile_Title.AutoSize = True
        Me.AddFile_Title.BackColor = System.Drawing.Color.Transparent
        Me.AddFile_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddFile_Title.ForeColor = System.Drawing.Color.White
        Me.AddFile_Title.Location = New System.Drawing.Point(13, 13)
        Me.AddFile_Title.Name = "AddFile_Title"
        Me.AddFile_Title.Size = New System.Drawing.Size(708, 24)
        Me.AddFile_Title.TabIndex = 0
        Me.AddFile_Title.Text = "Please either select a mod or a folder full of mods you wish to add to your colle" &
    "ction:"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(13, 409)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(724, 23)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add Mod(s)"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'SingleAdd
        '
        Me.SingleAdd.AutoSize = True
        Me.SingleAdd.Checked = True
        Me.SingleAdd.Location = New System.Drawing.Point(13, 80)
        Me.SingleAdd.Name = "SingleAdd"
        Me.SingleAdd.Size = New System.Drawing.Size(112, 17)
        Me.SingleAdd.TabIndex = 2
        Me.SingleAdd.TabStop = True
        Me.SingleAdd.Text = "Add a Single Mod:"
        Me.SingleAdd.UseVisualStyleBackColor = True
        '
        'FolderAdd
        '
        Me.FolderAdd.AutoSize = True
        Me.FolderAdd.Location = New System.Drawing.Point(12, 155)
        Me.FolderAdd.Name = "FolderAdd"
        Me.FolderAdd.Size = New System.Drawing.Size(141, 17)
        Me.FolderAdd.TabIndex = 3
        Me.FolderAdd.Text = "Add a folder full of mods:"
        Me.FolderAdd.UseVisualStyleBackColor = True
        '
        'SinglePath
        '
        Me.SinglePath.Location = New System.Drawing.Point(12, 103)
        Me.SinglePath.Name = "SinglePath"
        Me.SinglePath.Size = New System.Drawing.Size(560, 20)
        Me.SinglePath.TabIndex = 4
        '
        'SingleBrowse
        '
        Me.SingleBrowse.Location = New System.Drawing.Point(578, 101)
        Me.SingleBrowse.Name = "SingleBrowse"
        Me.SingleBrowse.Size = New System.Drawing.Size(75, 23)
        Me.SingleBrowse.TabIndex = 5
        Me.SingleBrowse.Text = "Browse"
        Me.SingleBrowse.UseVisualStyleBackColor = True
        '
        'FolderBrowse
        '
        Me.FolderBrowse.Location = New System.Drawing.Point(578, 176)
        Me.FolderBrowse.Name = "FolderBrowse"
        Me.FolderBrowse.Size = New System.Drawing.Size(75, 23)
        Me.FolderBrowse.TabIndex = 7
        Me.FolderBrowse.Text = "Browse"
        Me.FolderBrowse.UseVisualStyleBackColor = True
        '
        'FolderPath
        '
        Me.FolderPath.Location = New System.Drawing.Point(12, 178)
        Me.FolderPath.Name = "FolderPath"
        Me.FolderPath.Size = New System.Drawing.Size(560, 20)
        Me.FolderPath.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Files that will be imported:"
        '
        'ModList
        '
        Me.ModList.FormattingEnabled = True
        Me.ModList.Location = New System.Drawing.Point(13, 222)
        Me.ModList.Name = "ModList"
        Me.ModList.Size = New System.Drawing.Size(724, 173)
        Me.ModList.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AddMods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(749, 444)
        Me.Controls.Add(Me.ModList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FolderBrowse)
        Me.Controls.Add(Me.FolderPath)
        Me.Controls.Add(Me.SingleBrowse)
        Me.Controls.Add(Me.SinglePath)
        Me.Controls.Add(Me.FolderAdd)
        Me.Controls.Add(Me.SingleAdd)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.AddFile_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddMods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add a mod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Public WithEvents AddButton As Button
    Public WithEvents SingleAdd As RadioButton
    Public WithEvents FolderAdd As RadioButton
    Public WithEvents SinglePath As TextBox
    Public WithEvents SingleBrowse As Button
    Public WithEvents FolderBrowse As Button
    Public WithEvents FolderPath As TextBox
    Public WithEvents ModList As ListBox
    Public WithEvents AddFile_Title As Label
End Class
