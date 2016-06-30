Imports Newtonsoft.Json
Public Class ModInfo
    Public ModInfo
    Public Workspace = "C:\Tfff1\Simple_MC\Mod_Workspace\"
    Public screenshots As Array

    Private Sub ModInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get the Info:
        ModInfo = parseModInfo(Workspace + "mcmod.info")

        modID.Text = ModInfo(0)
        Text = "Mod Information: " + ModInfo(1)
        modName.Text = ModInfo(1)
        modDesc.Text = ModInfo(2)
        modVersion.Text = ModInfo(3)
        modCredits.Text = ModInfo(4)
        modLogo.BackgroundImage = System.Drawing.Image.FromFile(Workspace + ModInfo(5))
        modMCVersion.Text = ModInfo(6)
        modURL.Text = ModInfo(7)

        If Not modMCVersion.Text = My.Settings.SelectedCollection_MCversion Then
            modMCVersion.ForeColor = Color.Red
            Dim ToolTip1 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()
            ToolTip1.SetToolTip(modMCVersion, "WARNING: This mod's Minecraft Version is not the same version that your Collection uses!")
        End If

    End Sub

    Private Sub ModInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CollectionView.Enabled = True
    End Sub

    Private Sub modURL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles modURL.LinkClicked
        Process.Start(ModInfo(7))
    End Sub
End Class