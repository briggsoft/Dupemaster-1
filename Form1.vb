Public Class Form1
    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim Loc As Point
        Select Case e.KeyCode
            Case Keys.Left
                If Not player.Location.X - 8 < 0 Then
                    Loc = New Point(player.Location.X - 8, player.Location.Y)
                    player.Location = Loc
                    player.BackgroundImage = My.Resources.gafL
                End If
            Case Keys.Right
                If Not player.Location.X + 8 > Me.Width - player.Width - 5 Then
                    Loc = New Point(player.Location.X + 8, player.Location.Y)
                    player.Location = Loc
                    player.BackgroundImage = My.Resources.gafR
                End If
            Case Keys.Up
                If Not player.Location.Y - 8 < 0 Then
                    Loc = New Point(player.Location.X, player.Location.Y - 8)
                    player.Location = Loc
                    player.BackgroundImage = My.Resources.gafup
                End If
            Case Keys.Down
                If Not player.Location.Y - 8 > Me.Height - player.Height * 1.5 Then
                    Loc = New Point(player.Location.X, player.Location.Y + 8)
                    player.Location = Loc
                    player.BackgroundImage = My.Resources.gaf
                End If
                If player.Bounds.IntersectsWith(Item.Bounds) Then
                    Item.Hide()
                    Item.Location = New Point(RandomNumber(Me.Width), RandomNumber(Me.Height))
                    My.Computer.Audio.Play(My.Resources.pi, _
                   AudioPlayMode.Background)
                    Item.Show()
                    'Hp
                    Label2.Text += 10
                End If
                If Label2.Text = 110 Then
                    Timer3.Enabled = True
                    Fag.Enabled = True
                End If
        End Select
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'start button
        BackColor = Color.Black
        PictureBox4.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        Label1.Hide()
        FagFall.Show()
        Fag.Enabled = False
        Timer1.Enabled = True
        Timer2.Enabled = True
        player.Show()
        Label3.Show()
        Label2.Show()
        item.Show()
        PictureBox5.Hide()
        shoot1.Enabled = True
        music.URL = "music\Dupe Dat Nigga.ogg"
        music.Ctlcontrols.play()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        player.Hide()
        FagFall.Hide()
        Label3.Hide()
        Label2.Hide()
        music.URL = "music\dupe.wav"
        music.Ctlcontrols.play()
        music.Hide()
        cloak.Hide()
        wall1.Hide()
        wall2.Hide()
        item.Hide()
        Label4.Hide()
        Label5.Hide()
        gameover.Hide()
        boss.Enabled = True
        dead.Enabled = True
        Chris.Boot.Enabled = False
    End Sub
    Private Sub StInfosBattery_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate 
        Me.Close()
        Chris.Close()
    End Sub

    Private Sub Fag_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fag.Tick
        Dim Loc As Point
        If Not FagFall.Location.Y - 8 > Me.Height - FagFall.Height * 1.5 Then
            Loc = New Point(FagFall.Location.X, FagFall.Location.Y + 8)
            FagFall.Location = Loc
        End If
        If FagFall.Left < 0 - FagFall.Height Then
            FagFall.Left = Me.Width
        End If
    End Sub
    Public Function RandomNumber(ByVal MaxNumber As Integer, _
    Optional ByVal MinNumber As Integer = 0) As Integer

        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)

        'if passed incorrect arguments, swap them
        'can also throw exception or return 0

        If MinNumber > MaxNumber Then
            Dim t As Integer = MinNumber
            MinNumber = MaxNumber
            MaxNumber = t
        End If

        Return r.Next(MinNumber, MaxNumber)

    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If FagFall.Bounds.IntersectsWith(player.Bounds) Then
            Label2.Text -= 1
        End If
        Chrus.Left = Chrus.Left - 5
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Chrus.Bounds.IntersectsWith(cloak.Bounds) Then
            Chrus.Hide()
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If FagFall.Bounds.IntersectsWith(Me.Bounds) Then
            FagFall.Location = New Point(RandomNumber(Me.Width), RandomNumber(Me.Height))
        End If
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        Chris.Close()
    End Sub
    Private Sub dead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dead.Tick
        If Label2.Text = 0 Then
            Label4.Hide()
            Label5.Hide()
            player.Hide()
            FagFall.Hide()
            Label3.Hide()
            Label2.Hide()
            cloak.Hide()
            wall1.Hide()
            wall2.Hide()
            item.Hide()
            Label4.Hide()
            Label5.Hide()
            BackgroundImage = My.Resources._4
            music.URL = "music\s.mp3"
            music.Ctlcontrols.play()
            gameover.Show()
        End If
    End Sub
    Private Sub boss_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boss.Tick
        If Label2.Text = 110 Then
            Timer3.Enabled = True
            Fag.Enabled = True
        End If
    End Sub
    Private Sub gameover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameover.Click
        Application.Restart()
    End Sub
End Class
