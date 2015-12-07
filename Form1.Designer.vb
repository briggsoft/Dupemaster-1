<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.player = New System.Windows.Forms.PictureBox
        Me.FagFall = New System.Windows.Forms.PictureBox
        Me.Fag = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.music = New AxWMPLib.AxWindowsMediaPlayer
        Me.Chrus = New System.Windows.Forms.PictureBox
        Me.cloak = New System.Windows.Forms.PictureBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.wall1 = New System.Windows.Forms.PictureBox
        Me.shoot1 = New System.Windows.Forms.Timer(Me.components)
        Me.wall2 = New System.Windows.Forms.PictureBox
        Me.item = New System.Windows.Forms.PictureBox
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dead = New System.Windows.Forms.Timer(Me.components)
        Me.boss = New System.Windows.Forms.Timer(Me.components)
        Me.gameover = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FagFall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.music, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chrus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cloak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("hooge 05_54", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(143, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dupe Master"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(12, 374)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 56)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(138, 374)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(111, 56)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(37, 341)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 34)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Transparent
        Me.player.BackgroundImage = CType(resources.GetObject("player.BackgroundImage"), System.Drawing.Image)
        Me.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.player.Location = New System.Drawing.Point(3, 110)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(65, 60)
        Me.player.TabIndex = 5
        Me.player.TabStop = False
        '
        'FagFall
        '
        Me.FagFall.BackColor = System.Drawing.Color.Blue
        Me.FagFall.BackgroundImage = CType(resources.GetObject("FagFall.BackgroundImage"), System.Drawing.Image)
        Me.FagFall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FagFall.Location = New System.Drawing.Point(20, 12)
        Me.FagFall.Name = "FagFall"
        Me.FagFall.Size = New System.Drawing.Size(592, 26)
        Me.FagFall.TabIndex = 6
        Me.FagFall.TabStop = False
        '
        'Fag
        '
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("hooge 05_53", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(568, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("hooge 05_53", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(542, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "HP:"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(176, 325)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(39, 50)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'music
        '
        Me.music.Enabled = True
        Me.music.Location = New System.Drawing.Point(456, 401)
        Me.music.Name = "music"
        Me.music.OcxState = CType(resources.GetObject("music.OcxState"), System.Windows.Forms.AxHost.State)
        Me.music.Size = New System.Drawing.Size(39, 29)
        Me.music.TabIndex = 9
        Me.music.Visible = False
        '
        'Chrus
        '
        Me.Chrus.BackColor = System.Drawing.Color.Transparent
        Me.Chrus.BackgroundImage = CType(resources.GetObject("Chrus.BackgroundImage"), System.Drawing.Image)
        Me.Chrus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Chrus.Location = New System.Drawing.Point(588, 171)
        Me.Chrus.Name = "Chrus"
        Me.Chrus.Size = New System.Drawing.Size(259, 273)
        Me.Chrus.TabIndex = 10
        Me.Chrus.TabStop = False
        '
        'cloak
        '
        Me.cloak.BackColor = System.Drawing.Color.Transparent
        Me.cloak.Location = New System.Drawing.Point(389, 401)
        Me.cloak.Name = "cloak"
        Me.cloak.Size = New System.Drawing.Size(22, 43)
        Me.cloak.TabIndex = 11
        Me.cloak.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'wall1
        '
        Me.wall1.BackColor = System.Drawing.Color.Red
        Me.wall1.Location = New System.Drawing.Point(20, 1)
        Me.wall1.Name = "wall1"
        Me.wall1.Size = New System.Drawing.Size(13, 12)
        Me.wall1.TabIndex = 12
        Me.wall1.TabStop = False
        '
        'wall2
        '
        Me.wall2.BackColor = System.Drawing.Color.Red
        Me.wall2.Location = New System.Drawing.Point(3, 1)
        Me.wall2.Name = "wall2"
        Me.wall2.Size = New System.Drawing.Size(11, 12)
        Me.wall2.TabIndex = 12
        Me.wall2.TabStop = False
        '
        'item
        '
        Me.item.BackColor = System.Drawing.Color.Transparent
        Me.item.BackgroundImage = CType(resources.GetObject("item.BackgroundImage"), System.Drawing.Image)
        Me.item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.item.Location = New System.Drawing.Point(588, 229)
        Me.item.Name = "item"
        Me.item.Size = New System.Drawing.Size(40, 38)
        Me.item.TabIndex = 13
        Me.item.TabStop = False
        '
        'Timer3
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Get Ready for Boss"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(202, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "use mouse to attack"
        '
        'dead
        '
        '
        'boss
        '
        '
        'gameover
        '
        Me.gameover.BackColor = System.Drawing.Color.Transparent
        Me.gameover.BackgroundImage = CType(resources.GetObject("gameover.BackgroundImage"), System.Drawing.Image)
        Me.gameover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gameover.Location = New System.Drawing.Point(12, 341)
        Me.gameover.Name = "gameover"
        Me.gameover.Size = New System.Drawing.Size(188, 89)
        Me.gameover.TabIndex = 16
        Me.gameover.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.gameover)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.item)
        Me.Controls.Add(Me.wall2)
        Me.Controls.Add(Me.wall1)
        Me.Controls.Add(Me.cloak)
        Me.Controls.Add(Me.Chrus)
        Me.Controls.Add(Me.music)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FagFall)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dupe Master"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FagFall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.music, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chrus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cloak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents player As System.Windows.Forms.PictureBox
    Friend WithEvents FagFall As System.Windows.Forms.PictureBox
    Friend WithEvents Fag As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents music As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Chrus As System.Windows.Forms.PictureBox
    Friend WithEvents cloak As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents wall1 As System.Windows.Forms.PictureBox
    Friend WithEvents shoot1 As System.Windows.Forms.Timer
    Friend WithEvents wall2 As System.Windows.Forms.PictureBox
    Friend WithEvents item As System.Windows.Forms.PictureBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dead As System.Windows.Forms.Timer
    Friend WithEvents boss As System.Windows.Forms.Timer
    Friend WithEvents gameover As System.Windows.Forms.PictureBox

End Class
