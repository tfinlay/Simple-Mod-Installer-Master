<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Activation))
        Me.FolderList = New System.Windows.Forms.ListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentlyActivated = New System.Windows.Forms.Label()
        Me.SubDirectoriesList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SpecialDirectoriesList = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuccessList = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FolderList
        '
        Me.FolderList.Enabled = False
        Me.FolderList.FormattingEnabled = True
        Me.FolderList.Location = New System.Drawing.Point(12, 63)
        Me.FolderList.Name = "FolderList"
        Me.FolderList.Size = New System.Drawing.Size(233, 264)
        Me.FolderList.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 403)
        Me.ProgressBar1.MarqueeAnimationSpeed = 2
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(716, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folders to Activate/Deactivate:"
        '
        'CurrentlyActivated
        '
        Me.CurrentlyActivated.AutoSize = True
        Me.CurrentlyActivated.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentlyActivated.Location = New System.Drawing.Point(8, 9)
        Me.CurrentlyActivated.Name = "CurrentlyActivated"
        Me.CurrentlyActivated.Size = New System.Drawing.Size(150, 20)
        Me.CurrentlyActivated.TabIndex = 3
        Me.CurrentlyActivated.Text = "Currently Activated: "
        '
        'SubDirectoriesList
        '
        Me.SubDirectoriesList.Enabled = False
        Me.SubDirectoriesList.FormattingEnabled = True
        Me.SubDirectoriesList.Location = New System.Drawing.Point(251, 63)
        Me.SubDirectoriesList.Name = "SubDirectoriesList"
        Me.SubDirectoriesList.Size = New System.Drawing.Size(237, 264)
        Me.SubDirectoriesList.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Subfolders to Activate/Deactivate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(0, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(737, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "This Form is vital to the process of Activating your Collection, you can not clos" &
    "e it until the process is complete."
        Me.Label3.Visible = False
        '
        'SpecialDirectoriesList
        '
        Me.SpecialDirectoriesList.Enabled = False
        Me.SpecialDirectoriesList.FormattingEnabled = True
        Me.SpecialDirectoriesList.Location = New System.Drawing.Point(12, 354)
        Me.SpecialDirectoriesList.Name = "SpecialDirectoriesList"
        Me.SpecialDirectoriesList.Size = New System.Drawing.Size(715, 43)
        Me.SpecialDirectoriesList.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Special Directories ot Activate/Deactivate:"
        '
        'SuccessList
        '
        Me.SuccessList.Enabled = False
        Me.SuccessList.FormattingEnabled = True
        Me.SuccessList.Location = New System.Drawing.Point(495, 63)
        Me.SuccessList.Name = "SuccessList"
        Me.SuccessList.Size = New System.Drawing.Size(232, 264)
        Me.SuccessList.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(494, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Successful Items:"
        '
        'Activation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 438)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SuccessList)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SpecialDirectoriesList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SubDirectoriesList)
        Me.Controls.Add(Me.CurrentlyActivated)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.FolderList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Activation"
        Me.Text = "Activation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents FolderList As ListBox
    Public WithEvents ProgressBar1 As ProgressBar
    Public WithEvents Label1 As Label
    Public WithEvents CurrentlyActivated As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents SubDirectoriesList As ListBox
    Public WithEvents SpecialDirectoriesList As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Public WithEvents SuccessList As ListBox
End Class
