<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VersionText = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CompareCollectionTitles = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.showunreachables = New System.Windows.Forms.CheckBox()
        Me.SortBoxes = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TestEnvironment = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Version:"
        '
        'VersionText
        '
        Me.VersionText.AutoSize = True
        Me.VersionText.Location = New System.Drawing.Point(63, 291)
        Me.VersionText.Name = "VersionText"
        Me.VersionText.Size = New System.Drawing.Size(22, 13)
        Me.VersionText.TabIndex = 1
        Me.VersionText.Text = "1.6"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save and Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.LightSalmon
        Me.LinkLabel1.Location = New System.Drawing.Point(1, 35)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(201, 13)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://minecraft-mod-installer.weebly.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "For Help and Tutorials Visit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Created By Tfff1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(27, 251)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 20)
        Me.TextBox1.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(248, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Please select a folder to save world backups to:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(6, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(180, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Automatically Check for Updates"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CompareCollectionTitles
        '
        Me.CompareCollectionTitles.AutoSize = True
        Me.CompareCollectionTitles.Checked = True
        Me.CompareCollectionTitles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CompareCollectionTitles.Location = New System.Drawing.Point(3, 0)
        Me.CompareCollectionTitles.Name = "CompareCollectionTitles"
        Me.CompareCollectionTitles.Size = New System.Drawing.Size(105, 17)
        Me.CompareCollectionTitles.TabIndex = 17
        Me.CompareCollectionTitles.Text = "Safer Collections"
        Me.ToolTip1.SetToolTip(Me.CompareCollectionTitles, resources.GetString("CompareCollectionTitles.ToolTip"))
        Me.CompareCollectionTitles.UseVisualStyleBackColor = True
        '
        'showunreachables
        '
        Me.showunreachables.AutoSize = True
        Me.showunreachables.Location = New System.Drawing.Point(2, 46)
        Me.showunreachables.Name = "showunreachables"
        Me.showunreachables.Size = New System.Drawing.Size(194, 17)
        Me.showunreachables.TabIndex = 18
        Me.showunreachables.Text = "Show Potentially unreachable Items"
        Me.ToolTip1.SetToolTip(Me.showunreachables, "Can be very unstable - useful for viewing files in subdirectories - VERY ERROR PR" &
        "ONE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DEFAULT: Disabled")
        Me.showunreachables.UseVisualStyleBackColor = True
        '
        'SortBoxes
        '
        Me.SortBoxes.AutoSize = True
        Me.SortBoxes.Checked = True
        Me.SortBoxes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SortBoxes.Location = New System.Drawing.Point(2, 23)
        Me.SortBoxes.Name = "SortBoxes"
        Me.SortBoxes.Size = New System.Drawing.Size(69, 17)
        Me.SortBoxes.TabIndex = 19
        Me.SortBoxes.Text = "Sort Lists"
        Me.ToolTip1.SetToolTip(Me.SortBoxes, "Whether or not to sort items in some lists by name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Not very noticable")
        Me.SortBoxes.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(6, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(327, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "DELETE ALL COLLECTIONS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 54)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(347, 164)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(339, 138)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(192, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Check Now"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.showunreachables)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.CompareCollectionTitles)
        Me.TabPage2.Controls.Add(Me.SortBoxes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(339, 138)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Collections"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TestEnvironment)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(339, 138)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Advanced"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TestEnvironment
        '
        Me.TestEnvironment.AutoSize = True
        Me.TestEnvironment.Location = New System.Drawing.Point(4, 7)
        Me.TestEnvironment.Name = "TestEnvironment"
        Me.TestEnvironment.Size = New System.Drawing.Size(109, 17)
        Me.TestEnvironment.TabIndex = 0
        Me.TestEnvironment.Text = "Test Environment"
        Me.TestEnvironment.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(371, 313)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VersionText)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings"
        Me.Text = "Options"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents VersionText As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CompareCollectionTitles As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents showunreachables As CheckBox
    Friend WithEvents SortBoxes As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Public WithEvents Button4 As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TestEnvironment As CheckBox
End Class
