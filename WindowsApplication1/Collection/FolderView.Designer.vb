<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FolderView
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolderView))
        Me.SubDirectoriesList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddFile = New System.Windows.Forms.Button()
        Me.DelFile = New System.Windows.Forms.Button()
        Me.EditFile = New System.Windows.Forms.Button()
        Me.AddFolder = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Refresh_Button = New System.Windows.Forms.Button()
        Me.delfolder = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.openFolder = New System.Windows.Forms.Button()
        Me.ModList = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NothingHereLabel = New System.Windows.Forms.Label()
        Me.SelectSubDirLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.InvisibleListBox = New System.Windows.Forms.ListBox()
        Me.EmptySubs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SubDirectoriesList
        '
        Me.SubDirectoriesList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SubDirectoriesList.FormattingEnabled = True
        Me.SubDirectoriesList.Location = New System.Drawing.Point(12, 91)
        Me.SubDirectoriesList.Name = "SubDirectoriesList"
        Me.SubDirectoriesList.Size = New System.Drawing.Size(261, 329)
        Me.SubDirectoriesList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folders:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(367, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Files: "
        '
        'AddFile
        '
        Me.AddFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddFile.Location = New System.Drawing.Point(362, 63)
        Me.AddFile.Name = "AddFile"
        Me.AddFile.Size = New System.Drawing.Size(75, 23)
        Me.AddFile.TabIndex = 4
        Me.AddFile.Text = "Add File"
        Me.AddFile.UseVisualStyleBackColor = True
        '
        'DelFile
        '
        Me.DelFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelFile.Location = New System.Drawing.Point(443, 63)
        Me.DelFile.Name = "DelFile"
        Me.DelFile.Size = New System.Drawing.Size(104, 23)
        Me.DelFile.TabIndex = 5
        Me.DelFile.Text = "Remove Selected"
        Me.DelFile.UseVisualStyleBackColor = True
        '
        'EditFile
        '
        Me.EditFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditFile.Location = New System.Drawing.Point(553, 63)
        Me.EditFile.Name = "EditFile"
        Me.EditFile.Size = New System.Drawing.Size(165, 23)
        Me.EditFile.TabIndex = 7
        Me.EditFile.Text = "Edit Selected File"
        Me.EditFile.UseVisualStyleBackColor = True
        '
        'AddFolder
        '
        Me.AddFolder.Location = New System.Drawing.Point(12, 63)
        Me.AddFolder.Name = "AddFolder"
        Me.AddFolder.Size = New System.Drawing.Size(85, 23)
        Me.AddFolder.TabIndex = 9
        Me.AddFolder.Text = "Create Folder"
        Me.AddFolder.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(12, 11)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(75, 23)
        Me.Back_Button.TabIndex = 10
        Me.Back_Button.Text = "< Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Refresh_Button
        '
        Me.Refresh_Button.Location = New System.Drawing.Point(93, 11)
        Me.Refresh_Button.Name = "Refresh_Button"
        Me.Refresh_Button.Size = New System.Drawing.Size(75, 23)
        Me.Refresh_Button.TabIndex = 11
        Me.Refresh_Button.Text = "Refresh"
        Me.Refresh_Button.UseVisualStyleBackColor = True
        '
        'delfolder
        '
        Me.delfolder.Location = New System.Drawing.Point(195, 63)
        Me.delfolder.Name = "delfolder"
        Me.delfolder.Size = New System.Drawing.Size(78, 23)
        Me.delfolder.TabIndex = 12
        Me.delfolder.Text = "Delete Folder"
        Me.delfolder.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'openFolder
        '
        Me.openFolder.Location = New System.Drawing.Point(103, 37)
        Me.openFolder.Name = "openFolder"
        Me.openFolder.Size = New System.Drawing.Size(85, 23)
        Me.openFolder.TabIndex = 13
        Me.openFolder.Text = "Open Folder"
        Me.openFolder.UseVisualStyleBackColor = True
        '
        'ModList
        '
        Me.ModList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModList.CheckOnClick = True
        Me.ModList.FormattingEnabled = True
        Me.ModList.HorizontalScrollbar = True
        Me.ModList.Location = New System.Drawing.Point(362, 93)
        Me.ModList.Name = "ModList"
        Me.ModList.Size = New System.Drawing.Size(356, 334)
        Me.ModList.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Import Folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NothingHereLabel
        '
        Me.NothingHereLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NothingHereLabel.AutoSize = True
        Me.NothingHereLabel.BackColor = System.Drawing.SystemColors.Window
        Me.NothingHereLabel.Location = New System.Drawing.Point(387, 114)
        Me.NothingHereLabel.Name = "NothingHereLabel"
        Me.NothingHereLabel.Size = New System.Drawing.Size(308, 39)
        Me.NothingHereLabel.TabIndex = 16
        Me.NothingHereLabel.Text = "Just because nothing is showing here does not mean this folder" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "doesn't contain a" &
    "nything, it could contain subfolders which don't" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "show up here"
        Me.NothingHereLabel.Visible = False
        '
        'SelectSubDirLabel
        '
        Me.SelectSubDirLabel.AutoSize = True
        Me.SelectSubDirLabel.BackColor = System.Drawing.SystemColors.Window
        Me.SelectSubDirLabel.Location = New System.Drawing.Point(361, 114)
        Me.SelectSubDirLabel.Name = "SelectSubDirLabel"
        Me.SelectSubDirLabel.Size = New System.Drawing.Size(357, 13)
        Me.SelectSubDirLabel.TabIndex = 17
        Me.SelectSubDirLabel.Text = "Please Select a Folder in the list to the left for it's contents to show up here"
        Me.SelectSubDirLabel.Visible = False
        '
        'SearchButton
        '
        Me.SearchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchButton.Location = New System.Drawing.Point(496, 37)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(51, 23)
        Me.SearchButton.TabIndex = 18
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SearchText
        '
        Me.SearchText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchText.Location = New System.Drawing.Point(553, 37)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(165, 20)
        Me.SearchText.TabIndex = 19
        '
        'InvisibleListBox
        '
        Me.InvisibleListBox.FormattingEnabled = True
        Me.InvisibleListBox.Location = New System.Drawing.Point(209, 11)
        Me.InvisibleListBox.Name = "InvisibleListBox"
        Me.InvisibleListBox.Size = New System.Drawing.Size(80, 17)
        Me.InvisibleListBox.TabIndex = 20
        Me.InvisibleListBox.Visible = False
        '
        'EmptySubs
        '
        Me.EmptySubs.AutoSize = True
        Me.EmptySubs.BackColor = System.Drawing.SystemColors.Window
        Me.EmptySubs.Location = New System.Drawing.Point(27, 147)
        Me.EmptySubs.Name = "EmptySubs"
        Me.EmptySubs.Size = New System.Drawing.Size(210, 26)
        Me.EmptySubs.TabIndex = 21
        Me.EmptySubs.Text = "                 Nothing to show here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Try restarting the Installer or adding a " &
    "folder"
        Me.EmptySubs.Visible = False
        '
        'FolderView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(730, 439)
        Me.Controls.Add(Me.EmptySubs)
        Me.Controls.Add(Me.InvisibleListBox)
        Me.Controls.Add(Me.SearchText)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SelectSubDirLabel)
        Me.Controls.Add(Me.NothingHereLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ModList)
        Me.Controls.Add(Me.openFolder)
        Me.Controls.Add(Me.delfolder)
        Me.Controls.Add(Me.Refresh_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.AddFolder)
        Me.Controls.Add(Me.EditFile)
        Me.Controls.Add(Me.DelFile)
        Me.Controls.Add(Me.AddFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubDirectoriesList)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FolderView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Modded Folders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents SubDirectoriesList As ListBox
    Public WithEvents AddFile As Button
    Public WithEvents DelFile As Button
    Public WithEvents EditFile As Button
    Public WithEvents AddFolder As Button
    Public WithEvents Back_Button As Button
    Public WithEvents Refresh_Button As Button
    Friend WithEvents delfolder As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents openFolder As Button
    Public WithEvents ModList As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NothingHereLabel As Label
    Friend WithEvents SelectSubDirLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchText As TextBox
    Friend WithEvents InvisibleListBox As ListBox
    Friend WithEvents EmptySubs As Label
End Class
