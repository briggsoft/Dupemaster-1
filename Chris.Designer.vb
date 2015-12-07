<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chris
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chris))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.SFX = New AxWMPLib.AxWindowsMediaPlayer
        Me.gl = New System.Windows.Forms.PictureBox
        Me.Ch = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Boot = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SFX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dungeon", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Syncrazy Productions"
        '
        'SFX
        '
        Me.SFX.Enabled = True
        Me.SFX.Location = New System.Drawing.Point(0, 237)
        Me.SFX.Name = "SFX"
        Me.SFX.OcxState = CType(resources.GetObject("SFX.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SFX.Size = New System.Drawing.Size(47, 12)
        Me.SFX.TabIndex = 3
        '
        'gl
        '
        Me.gl.BackColor = System.Drawing.Color.Transparent
        Me.gl.Location = New System.Drawing.Point(251, 199)
        Me.gl.Name = "gl"
        Me.gl.Size = New System.Drawing.Size(21, 50)
        Me.gl.TabIndex = 1
        Me.gl.TabStop = False
        '
        'Ch
        '
        Me.Ch.BackgroundImage = CType(resources.GetObject("Ch.BackgroundImage"), System.Drawing.Image)
        Me.Ch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ch.Location = New System.Drawing.Point(492, 41)
        Me.Ch.Name = "Ch"
        Me.Ch.Size = New System.Drawing.Size(288, 208)
        Me.Ch.TabIndex = 0
        Me.Ch.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dungeon", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dupe Master"
        '
        'Boot
        '
        Me.Boot.Interval = 8000
        '
        'Chris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(510, 251)
        Me.ControlBox = False
        Me.Controls.Add(Me.SFX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gl)
        Me.Controls.Add(Me.Ch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Chris"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.SFX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ch As System.Windows.Forms.PictureBox
    Friend WithEvents gl As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SFX As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Boot As System.Windows.Forms.Timer

End Class
