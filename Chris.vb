Public NotInheritable Class Chris
    Private Sub Chris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        SFX.Hide()
        Boot.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Ch.Left = Ch.Left - 15
        If Ch.Bounds.IntersectsWith(gl.Bounds) Then
            Ch.Left = Ch.Left - 0
            Timer1.Enabled = False
            SFX.URL = "music\gt.mp3"
            SFX.Ctlcontrols.play()
        End If
    End Sub
    Private Sub Boot_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boot.Tick
        Form1.Show()
        Me.Hide()
    End Sub
End Class
