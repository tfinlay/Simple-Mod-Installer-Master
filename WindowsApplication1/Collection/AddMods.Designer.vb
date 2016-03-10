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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SingleAdd = New System.Windows.Forms.RadioButton()
        Me.FolderAdd = New System.Windows.Forms.RadioButton()
        Me.SinglePath = New System.Windows.Forms.TextBox()
        Me.SingleBrowse = New System.Windows.Forms.Button()
        Me.FolderBrowse = New System.Windows.Forms.Button()
        Me.FolderPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(708, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please either select a mod or a folder full of mods you wish to add to your colle" &
    "ction:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(724, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Mod(s)"
        Me.Button1.UseVisualStyleBackColor = True
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
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(13, 222)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(724, 173)
        Me.CheckedListBox1.TabIndex = 9
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
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FolderBrowse)
        Me.Controls.Add(Me.FolderPath)
        Me.Controls.Add(Me.SingleBrowse)
        Me.Controls.Add(Me.SinglePath)
        Me.Controls.Add(Me.FolderAdd)
        Me.Controls.Add(Me.SingleAdd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddMods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add a mod"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SingleAdd As RadioButton
    Friend WithEvents FolderAdd As RadioButton
    Friend WithEvents SinglePath As TextBox
    Friend WithEvents SingleBrowse As Button
    Friend WithEvents FolderBrowse As Button
    Friend WithEvents FolderPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckedListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
End Class
