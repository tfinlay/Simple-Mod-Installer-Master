<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExportToModpack
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportToModpack))
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IncludedFoldersList = New System.Windows.Forms.CheckedListBox()
        Me.ExcludedFoldersList = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.IncludeButton = New System.Windows.Forms.Button()
        Me.ExcludeButton = New System.Windows.Forms.Button()
        Me.JarPath = New System.Windows.Forms.TextBox()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HiddenListBox = New System.Windows.Forms.CheckedListBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(13, 421)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(868, 23)
        Me.ExportButton.TabIndex = 0
        Me.ExportButton.Text = "Export to Technic"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(427, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Included Folders:"
        '
        'IncludedFoldersList
        '
        Me.IncludedFoldersList.CheckOnClick = True
        Me.IncludedFoldersList.FormattingEnabled = True
        Me.IncludedFoldersList.Location = New System.Drawing.Point(430, 80)
        Me.IncludedFoldersList.Name = "IncludedFoldersList"
        Me.IncludedFoldersList.Size = New System.Drawing.Size(207, 334)
        Me.IncludedFoldersList.TabIndex = 2
        '
        'ExcludedFoldersList
        '
        Me.ExcludedFoldersList.CheckOnClick = True
        Me.ExcludedFoldersList.FormattingEnabled = True
        Me.ExcludedFoldersList.Location = New System.Drawing.Point(677, 81)
        Me.ExcludedFoldersList.Name = "ExcludedFoldersList"
        Me.ExcludedFoldersList.Size = New System.Drawing.Size(209, 334)
        Me.ExcludedFoldersList.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(677, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Excluded Folders:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 51)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(411, 363)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'IncludeButton
        '
        Me.IncludeButton.Location = New System.Drawing.Point(643, 79)
        Me.IncludeButton.Name = "IncludeButton"
        Me.IncludeButton.Size = New System.Drawing.Size(28, 23)
        Me.IncludeButton.TabIndex = 6
        Me.IncludeButton.Text = " < "
        Me.IncludeButton.UseVisualStyleBackColor = True
        '
        'ExcludeButton
        '
        Me.ExcludeButton.Location = New System.Drawing.Point(644, 108)
        Me.ExcludeButton.Name = "ExcludeButton"
        Me.ExcludeButton.Size = New System.Drawing.Size(27, 23)
        Me.ExcludeButton.TabIndex = 7
        Me.ExcludeButton.Text = " > "
        Me.ExcludeButton.UseVisualStyleBackColor = True
        '
        'JarPath
        '
        Me.JarPath.Location = New System.Drawing.Point(430, 41)
        Me.JarPath.Name = "JarPath"
        Me.JarPath.Size = New System.Drawing.Size(372, 20)
        Me.JarPath.TabIndex = 8
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(808, 39)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(73, 23)
        Me.BrowseButton.TabIndex = 9
        Me.BrowseButton.Text = "Browse"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(359, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Please Select the ""Universal"" .jar for the Forge version this collection uses:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(430, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Download Them them from: "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(564, 26)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(144, 13)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://files.minecraftforge.net"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Instructions:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "< Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel2.Location = New System.Drawing.Point(221, 35)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(201, 13)
        Me.LinkLabel2.TabIndex = 17
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "http://minecraft-mod-installer.weebly.com"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(242, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "For Help and Tutorials Visit:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(270, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Created By Tfff1"
        '
        'HiddenListBox
        '
        Me.HiddenListBox.Enabled = False
        Me.HiddenListBox.FormattingEnabled = True
        Me.HiddenListBox.Location = New System.Drawing.Point(69, 13)
        Me.HiddenListBox.Name = "HiddenListBox"
        Me.HiddenListBox.Size = New System.Drawing.Size(95, 19)
        Me.HiddenListBox.TabIndex = 18
        Me.HiddenListBox.Visible = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "zip"
        Me.SaveFileDialog1.Filter = "Zip Files(*.zip)|*.zip"
        Me.SaveFileDialog1.Title = "Where would you like to save your Modpack?"
        '
        'ExportToModpack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 456)
        Me.Controls.Add(Me.HiddenListBox)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.JarPath)
        Me.Controls.Add(Me.ExcludeButton)
        Me.Controls.Add(Me.IncludeButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ExcludedFoldersList)
        Me.Controls.Add(Me.IncludedFoldersList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExportButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ExportToModpack"
        Me.Text = "Export To Modpack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExportButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IncludeButton As Button
    Friend WithEvents ExcludeButton As Button
    Friend WithEvents JarPath As TextBox
    Friend WithEvents BrowseButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Public WithEvents IncludedFoldersList As CheckedListBox
    Public WithEvents ExcludedFoldersList As CheckedListBox
    Friend WithEvents HiddenListBox As CheckedListBox
    Public WithEvents SaveFileDialog1 As SaveFileDialog
End Class
