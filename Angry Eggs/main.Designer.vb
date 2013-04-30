<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.restart = New System.Windows.Forms.Button()
        Me.ExitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bat = New System.Windows.Forms.PictureBox()
        Me.egg = New System.Windows.Forms.PictureBox()
        Me.bg = New System.Windows.Forms.PictureBox()
        Me.bgbottom = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.bat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.egg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgbottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'scoreLabel
        '
        Me.scoreLabel.BackColor = System.Drawing.Color.White
        Me.scoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLabel.Location = New System.Drawing.Point(529, 6)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(66, 30)
        Me.scoreLabel.TabIndex = 2
        Me.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem, Me.ExitGameToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 48)
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'restart
        '
        Me.restart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restart.Location = New System.Drawing.Point(10, 9)
        Me.restart.Name = "restart"
        Me.restart.Size = New System.Drawing.Size(113, 23)
        Me.restart.TabIndex = 7
        Me.restart.Text = "RESTART GAME"
        Me.restart.UseVisualStyleBackColor = True
        '
        'ExitGameToolStripMenuItem
        '
        Me.ExitGameToolStripMenuItem.Name = "ExitGameToolStripMenuItem"
        Me.ExitGameToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ExitGameToolStripMenuItem.Text = "Exit Game"
        '
        'bat
        '
        Me.bat.BackgroundImage = Global.Angry_Eggs.My.Resources.Resources.bat
        Me.bat.Location = New System.Drawing.Point(191, 474)
        Me.bat.Name = "bat"
        Me.bat.Size = New System.Drawing.Size(180, 26)
        Me.bat.TabIndex = 6
        Me.bat.TabStop = False
        '
        'egg
        '
        Me.egg.BackColor = System.Drawing.Color.Transparent
        Me.egg.Image = Global.Angry_Eggs.My.Resources.Resources.egg
        Me.egg.Location = New System.Drawing.Point(340, 417)
        Me.egg.Name = "egg"
        Me.egg.Size = New System.Drawing.Size(40, 40)
        Me.egg.TabIndex = 4
        Me.egg.TabStop = False
        '
        'bg
        '
        Me.bg.BackgroundImage = Global.Angry_Eggs.My.Resources.Resources.bg
        Me.bg.Location = New System.Drawing.Point(0, 1)
        Me.bg.Name = "bg"
        Me.bg.Size = New System.Drawing.Size(600, 39)
        Me.bg.TabIndex = 3
        Me.bg.TabStop = False
        '
        'bgbottom
        '
        Me.bgbottom.BackgroundImage = Global.Angry_Eggs.My.Resources.Resources.bg2
        Me.bgbottom.Location = New System.Drawing.Point(0, 461)
        Me.bgbottom.Name = "bgbottom"
        Me.bgbottom.Size = New System.Drawing.Size(600, 39)
        Me.bgbottom.TabIndex = 5
        Me.bgbottom.TabStop = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.restart)
        Me.Controls.Add(Me.bat)
        Me.Controls.Add(Me.egg)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.bg)
        Me.Controls.Add(Me.bgbottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Angry Eggs"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.bat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.egg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgbottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents scoreLabel As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bg As System.Windows.Forms.PictureBox
    Friend WithEvents egg As System.Windows.Forms.PictureBox
    Friend WithEvents bgbottom As System.Windows.Forms.PictureBox
    Friend WithEvents bat As System.Windows.Forms.PictureBox
    Friend WithEvents restart As System.Windows.Forms.Button
    Friend WithEvents ExitGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
