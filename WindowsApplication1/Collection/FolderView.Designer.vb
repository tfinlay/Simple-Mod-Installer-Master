<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolderView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolderView))
        Me.SubDirectoriesList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddFile = New System.Windows.Forms.Button()
        Me.DelFile = New System.Windows.Forms.Button()
        Me.EditFile = New System.Windows.Forms.Button()
        Me.ModList = New System.Windows.Forms.ListBox()
        Me.AddFolder = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Refresh_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SubDirectoriesList
        '
        Me.SubDirectoriesList.FormattingEnabled = True
        Me.SubDirectoriesList.Location = New System.Drawing.Point(12, 91)
        Me.SubDirectoriesList.Name = "SubDirectoriesList"
        Me.SubDirectoriesList.Size = New System.Drawing.Size(261, 329)
        Me.SubDirectoriesList.TabIndex = 0
        '
        'Label1
        '
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
        Me.AddFile.Location = New System.Drawing.Point(362, 63)
        Me.AddFile.Name = "AddFile"
        Me.AddFile.Size = New System.Drawing.Size(75, 23)
        Me.AddFile.TabIndex = 4
        Me.AddFile.Text = "Add File"
        Me.AddFile.UseVisualStyleBackColor = True
        '
        'DelFile
        '
        Me.DelFile.Location = New System.Drawing.Point(443, 63)
        Me.DelFile.Name = "DelFile"
        Me.DelFile.Size = New System.Drawing.Size(104, 23)
        Me.DelFile.TabIndex = 5
        Me.DelFile.Text = "Remove Selected"
        Me.DelFile.UseVisualStyleBackColor = True
        '
        'EditFile
        '
        Me.EditFile.Location = New System.Drawing.Point(553, 63)
        Me.EditFile.Name = "EditFile"
        Me.EditFile.Size = New System.Drawing.Size(165, 23)
        Me.EditFile.TabIndex = 7
        Me.EditFile.Text = "Edit Selected File"
        Me.EditFile.UseVisualStyleBackColor = True
        '
        'ModList
        '
        Me.ModList.FormattingEnabled = True
        Me.ModList.Location = New System.Drawing.Point(362, 91)
        Me.ModList.Name = "ModList"
        Me.ModList.Size = New System.Drawing.Size(356, 329)
        Me.ModList.TabIndex = 8
        '
        'AddFolder
        '
        Me.AddFolder.Location = New System.Drawing.Point(12, 63)
        Me.AddFolder.Name = "AddFolder"
        Me.AddFolder.Size = New System.Drawing.Size(107, 23)
        Me.AddFolder.TabIndex = 9
        Me.AddFolder.Text = "Add New Folder"
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
        'FolderView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(730, 434)
        Me.Controls.Add(Me.Refresh_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.AddFolder)
        Me.Controls.Add(Me.ModList)
        Me.Controls.Add(Me.EditFile)
        Me.Controls.Add(Me.DelFile)
        Me.Controls.Add(Me.AddFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubDirectoriesList)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FolderView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Modded Folders"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents SubDirectoriesList As ListBox
    Public WithEvents AddFile As Button
    Public WithEvents DelFile As Button
    Public WithEvents EditFile As Button
    Public WithEvents ModList As ListBox
    Public WithEvents AddFolder As Button
    Public WithEvents Back_Button As Button
    Public WithEvents Refresh_Button As Button
End Class
