<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModInfo
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
        Me.modName = New System.Windows.Forms.Label()
        Me.modID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.modLogo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.modDesc = New System.Windows.Forms.TextBox()
        Me.modVersion = New System.Windows.Forms.Label()
        Me.modMCVersion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.modCredits = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.modAuthors = New System.Windows.Forms.Label()
        Me.modURL = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.notFound = New System.Windows.Forms.Label()
        CType(Me.modLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'modName
        '
        Me.modName.AutoSize = True
        Me.modName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modName.Location = New System.Drawing.Point(12, 9)
        Me.modName.Name = "modName"
        Me.modName.Size = New System.Drawing.Size(116, 25)
        Me.modName.TabIndex = 0
        Me.modName.Text = "Mod Name"
        '
        'modID
        '
        Me.modID.AutoSize = True
        Me.modID.Location = New System.Drawing.Point(401, 60)
        Me.modID.Name = "modID"
        Me.modID.Size = New System.Drawing.Size(42, 13)
        Me.modID.TabIndex = 1
        Me.modID.Text = "Mod ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID: "
        '
        'modLogo
        '
        Me.modLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.modLogo.Location = New System.Drawing.Point(13, 38)
        Me.modLogo.Name = "modLogo"
        Me.modLogo.Size = New System.Drawing.Size(352, 124)
        Me.modLogo.TabIndex = 3
        Me.modLogo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Version: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Minecraft Version:"
        '
        'modDesc
        '
        Me.modDesc.BackColor = System.Drawing.Color.White
        Me.modDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.modDesc.ForeColor = System.Drawing.Color.Black
        Me.modDesc.Location = New System.Drawing.Point(12, 168)
        Me.modDesc.Multiline = True
        Me.modDesc.Name = "modDesc"
        Me.modDesc.ReadOnly = True
        Me.modDesc.Size = New System.Drawing.Size(605, 108)
        Me.modDesc.TabIndex = 6
        '
        'modVersion
        '
        Me.modVersion.AutoSize = True
        Me.modVersion.Location = New System.Drawing.Point(425, 85)
        Me.modVersion.Name = "modVersion"
        Me.modVersion.Size = New System.Drawing.Size(42, 13)
        Me.modVersion.TabIndex = 7
        Me.modVersion.Text = "Version"
        '
        'modMCVersion
        '
        Me.modMCVersion.AutoSize = True
        Me.modMCVersion.Location = New System.Drawing.Point(469, 102)
        Me.modMCVersion.Name = "modMCVersion"
        Me.modMCVersion.Size = New System.Drawing.Size(58, 13)
        Me.modMCVersion.TabIndex = 8
        Me.modMCVersion.Text = "MCVersion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Credits: "
        '
        'modCredits
        '
        Me.modCredits.AutoSize = True
        Me.modCredits.Location = New System.Drawing.Point(423, 128)
        Me.modCredits.Name = "modCredits"
        Me.modCredits.Size = New System.Drawing.Size(38, 13)
        Me.modCredits.TabIndex = 10
        Me.modCredits.Text = "credits"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(372, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Authors: "
        '
        'modAuthors
        '
        Me.modAuthors.AutoSize = True
        Me.modAuthors.Location = New System.Drawing.Point(427, 141)
        Me.modAuthors.Name = "modAuthors"
        Me.modAuthors.Size = New System.Drawing.Size(43, 13)
        Me.modAuthors.TabIndex = 12
        Me.modAuthors.Text = "Authors"
        '
        'modURL
        '
        Me.modURL.AutoSize = True
        Me.modURL.Location = New System.Drawing.Point(371, 38)
        Me.modURL.Name = "modURL"
        Me.modURL.Size = New System.Drawing.Size(29, 13)
        Me.modURL.TabIndex = 13
        Me.modURL.TabStop = True
        Me.modURL.Text = "URL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(608, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "NOTE: This mod file may contain more than one mod. The mod information displayed " &
    "is the first one found in the mcmod.info file."
        '
        'notFound
        '
        Me.notFound.AutoSize = True
        Me.notFound.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notFound.Location = New System.Drawing.Point(107, 97)
        Me.notFound.Name = "notFound"
        Me.notFound.Size = New System.Drawing.Size(147, 18)
        Me.notFound.TabIndex = 15
        Me.notFound.Text = "Mod Logo not Found"
        '
        'ModInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 296)
        Me.Controls.Add(Me.notFound)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.modURL)
        Me.Controls.Add(Me.modAuthors)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.modCredits)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.modMCVersion)
        Me.Controls.Add(Me.modVersion)
        Me.Controls.Add(Me.modDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.modLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.modID)
        Me.Controls.Add(Me.modName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ModInfo"
        Me.Text = "0"
        Me.TopMost = True
        CType(Me.modLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents modName As Label
    Friend WithEvents modID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents modLogo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents modDesc As TextBox
    Friend WithEvents modVersion As Label
    Friend WithEvents modMCVersion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents modCredits As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents modAuthors As Label
    Friend WithEvents modURL As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents notFound As Label
End Class
