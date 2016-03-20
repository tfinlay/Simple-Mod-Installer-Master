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
        Me.FolderList = New System.Windows.Forms.ListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentlyActivated = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FolderList
        '
        Me.FolderList.Enabled = False
        Me.FolderList.FormattingEnabled = True
        Me.FolderList.Location = New System.Drawing.Point(463, 37)
        Me.FolderList.Name = "FolderList"
        Me.FolderList.Size = New System.Drawing.Size(233, 303)
        Me.FolderList.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 346)
        Me.ProgressBar1.MarqueeAnimationSpeed = 2
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(684, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(460, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folders to Activate/Deactivate:"
        '
        'CurrentlyActivated
        '
        Me.CurrentlyActivated.AutoSize = True
        Me.CurrentlyActivated.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentlyActivated.Location = New System.Drawing.Point(13, 13)
        Me.CurrentlyActivated.Name = "CurrentlyActivated"
        Me.CurrentlyActivated.Size = New System.Drawing.Size(150, 20)
        Me.CurrentlyActivated.TabIndex = 3
        Me.CurrentlyActivated.Text = "Currently Activated: "
        '
        'Activation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 381)
        Me.Controls.Add(Me.CurrentlyActivated)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.FolderList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Activation"
        Me.Text = "Activation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents FolderList As ListBox
    Public WithEvents ProgressBar1 As ProgressBar
    Public WithEvents Label1 As Label
    Public WithEvents CurrentlyActivated As Label
End Class
