<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Medium
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medium))
        Me.soldat11 = New System.Windows.Forms.PictureBox()
        Me.Soldat22 = New System.Windows.Forms.PictureBox()
        Me.soldat44 = New System.Windows.Forms.PictureBox()
        Me.soldat33 = New System.Windows.Forms.PictureBox()
        Me.Timer_soldat11 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_soldat22 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_soldat33 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_soldat44 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_gen1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Hp1 = New System.Windows.Forms.Label()
        Me.lbl_Pct1 = New System.Windows.Forms.Label()
        Me.glont11 = New System.Windows.Forms.PictureBox()
        Me.glont22 = New System.Windows.Forms.PictureBox()
        Me.glont33 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar11 = New System.Windows.Forms.ProgressBar()
        Me.Timer_reincarca1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer_start1 = New System.Windows.Forms.Timer(Me.components)
        Me.soldat55 = New System.Windows.Forms.PictureBox()
        Me.soldat66 = New System.Windows.Forms.PictureBox()
        Me.Timer_soldat55 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_soldat66 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.arma1 = New System.Windows.Forms.PictureBox()
        Me.animationTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.glont_4 = New System.Windows.Forms.PictureBox()
        CType(Me.soldat11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Soldat22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.soldat44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.soldat33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glont11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glont22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glont33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.soldat55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.soldat66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arma1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glont_4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'soldat11
        '
        Me.soldat11.BackColor = System.Drawing.Color.Transparent
        Me.soldat11.Image = CType(resources.GetObject("soldat11.Image"), System.Drawing.Image)
        Me.soldat11.Location = New System.Drawing.Point(599, 218)
        Me.soldat11.Name = "soldat11"
        Me.soldat11.Size = New System.Drawing.Size(81, 150)
        Me.soldat11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.soldat11.TabIndex = 4
        Me.soldat11.TabStop = False
        Me.soldat11.Visible = False
        '
        'Soldat22
        '
        Me.Soldat22.BackColor = System.Drawing.Color.Transparent
        Me.Soldat22.Image = CType(resources.GetObject("Soldat22.Image"), System.Drawing.Image)
        Me.Soldat22.Location = New System.Drawing.Point(314, 285)
        Me.Soldat22.Name = "Soldat22"
        Me.Soldat22.Size = New System.Drawing.Size(165, 144)
        Me.Soldat22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Soldat22.TabIndex = 6
        Me.Soldat22.TabStop = False
        Me.Soldat22.Visible = False
        '
        'soldat44
        '
        Me.soldat44.BackColor = System.Drawing.Color.Transparent
        Me.soldat44.Image = CType(resources.GetObject("soldat44.Image"), System.Drawing.Image)
        Me.soldat44.Location = New System.Drawing.Point(69, 196)
        Me.soldat44.Name = "soldat44"
        Me.soldat44.Size = New System.Drawing.Size(116, 131)
        Me.soldat44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.soldat44.TabIndex = 7
        Me.soldat44.TabStop = False
        Me.soldat44.Visible = False
        '
        'soldat33
        '
        Me.soldat33.BackColor = System.Drawing.Color.Transparent
        Me.soldat33.Image = CType(resources.GetObject("soldat33.Image"), System.Drawing.Image)
        Me.soldat33.Location = New System.Drawing.Point(263, 240)
        Me.soldat33.Name = "soldat33"
        Me.soldat33.Size = New System.Drawing.Size(45, 86)
        Me.soldat33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.soldat33.TabIndex = 8
        Me.soldat33.TabStop = False
        Me.soldat33.Visible = False
        '
        'Timer_soldat11
        '
        Me.Timer_soldat11.Interval = 2000
        '
        'Timer_soldat22
        '
        Me.Timer_soldat22.Interval = 1000
        '
        'Timer_soldat33
        '
        Me.Timer_soldat33.Interval = 1000
        '
        'Timer_soldat44
        '
        Me.Timer_soldat44.Interval = 1000
        '
        'Timer_gen1
        '
        '
        'lbl_Hp1
        '
        Me.lbl_Hp1.AutoSize = True
        Me.lbl_Hp1.Location = New System.Drawing.Point(54, 9)
        Me.lbl_Hp1.Name = "lbl_Hp1"
        Me.lbl_Hp1.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Hp1.TabIndex = 9
        Me.lbl_Hp1.Text = "HP 100"
        '
        'lbl_Pct1
        '
        Me.lbl_Pct1.AutoSize = True
        Me.lbl_Pct1.Location = New System.Drawing.Point(253, 9)
        Me.lbl_Pct1.Name = "lbl_Pct1"
        Me.lbl_Pct1.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Pct1.TabIndex = 10
        Me.lbl_Pct1.Text = "Punctaj 0"
        '
        'glont11
        '
        Me.glont11.BackColor = System.Drawing.Color.Transparent
        Me.glont11.Image = CType(resources.GetObject("glont11.Image"), System.Drawing.Image)
        Me.glont11.Location = New System.Drawing.Point(557, 379)
        Me.glont11.Name = "glont11"
        Me.glont11.Size = New System.Drawing.Size(67, 50)
        Me.glont11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.glont11.TabIndex = 21
        Me.glont11.TabStop = False
        '
        'glont22
        '
        Me.glont22.BackColor = System.Drawing.Color.Transparent
        Me.glont22.Image = CType(resources.GetObject("glont22.Image"), System.Drawing.Image)
        Me.glont22.Location = New System.Drawing.Point(600, 379)
        Me.glont22.Name = "glont22"
        Me.glont22.Size = New System.Drawing.Size(67, 50)
        Me.glont22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.glont22.TabIndex = 22
        Me.glont22.TabStop = False
        '
        'glont33
        '
        Me.glont33.BackColor = System.Drawing.Color.Transparent
        Me.glont33.Image = CType(resources.GetObject("glont33.Image"), System.Drawing.Image)
        Me.glont33.Location = New System.Drawing.Point(639, 379)
        Me.glont33.Name = "glont33"
        Me.glont33.Size = New System.Drawing.Size(67, 50)
        Me.glont33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.glont33.TabIndex = 23
        Me.glont33.TabStop = False
        '
        'ProgressBar11
        '
        Me.ProgressBar11.Location = New System.Drawing.Point(573, 396)
        Me.ProgressBar11.Name = "ProgressBar11"
        Me.ProgressBar11.Size = New System.Drawing.Size(124, 23)
        Me.ProgressBar11.TabIndex = 24
        '
        'Timer_reincarca1
        '
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(314, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 106)
        Me.Label11.TabIndex = 26
        '
        'Timer_start1
        '
        '
        'soldat55
        '
        Me.soldat55.BackColor = System.Drawing.Color.Transparent
        Me.soldat55.Image = CType(resources.GetObject("soldat55.Image"), System.Drawing.Image)
        Me.soldat55.Location = New System.Drawing.Point(511, 249)
        Me.soldat55.Name = "soldat55"
        Me.soldat55.Size = New System.Drawing.Size(45, 65)
        Me.soldat55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.soldat55.TabIndex = 27
        Me.soldat55.TabStop = False
        Me.soldat55.Visible = False
        '
        'soldat66
        '
        Me.soldat66.BackColor = System.Drawing.Color.Transparent
        Me.soldat66.Image = CType(resources.GetObject("soldat66.Image"), System.Drawing.Image)
        Me.soldat66.Location = New System.Drawing.Point(392, 80)
        Me.soldat66.Name = "soldat66"
        Me.soldat66.Size = New System.Drawing.Size(64, 109)
        Me.soldat66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.soldat66.TabIndex = 28
        Me.soldat66.TabStop = False
        Me.soldat66.Visible = False
        '
        'Timer_soldat55
        '
        Me.Timer_soldat55.Interval = 1500
        '
        'Timer_soldat66
        '
        Me.Timer_soldat66.Interval = 500
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Location = New System.Drawing.Point(0, 425)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(718, 88)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'arma1
        '
        Me.arma1.Image = CType(resources.GetObject("arma1.Image"), System.Drawing.Image)
        Me.arma1.Location = New System.Drawing.Point(279, 435)
        Me.arma1.Name = "arma1"
        Me.arma1.Size = New System.Drawing.Size(152, 69)
        Me.arma1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.arma1.TabIndex = 30
        Me.arma1.TabStop = False
        '
        'animationTimer1
        '
        Me.animationTimer1.Enabled = True
        Me.animationTimer1.Interval = 1
        '
        'glont_4
        '
        Me.glont_4.BackColor = System.Drawing.Color.Transparent
        Me.glont_4.Image = CType(resources.GetObject("glont_4.Image"), System.Drawing.Image)
        Me.glont_4.Location = New System.Drawing.Point(511, 379)
        Me.glont_4.Name = "glont_4"
        Me.glont_4.Size = New System.Drawing.Size(67, 50)
        Me.glont_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.glont_4.TabIndex = 31
        Me.glont_4.TabStop = False
        '
        'Medium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(708, 502)
        Me.Controls.Add(Me.arma1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.soldat66)
        Me.Controls.Add(Me.soldat55)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ProgressBar11)
        Me.Controls.Add(Me.glont33)
        Me.Controls.Add(Me.glont22)
        Me.Controls.Add(Me.glont11)
        Me.Controls.Add(Me.lbl_Pct1)
        Me.Controls.Add(Me.lbl_Hp1)
        Me.Controls.Add(Me.soldat33)
        Me.Controls.Add(Me.Soldat22)
        Me.Controls.Add(Me.soldat11)
        Me.Controls.Add(Me.soldat44)
        Me.Controls.Add(Me.glont_4)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Medium"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medium"
        CType(Me.soldat11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Soldat22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.soldat44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.soldat33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glont11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glont22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glont33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.soldat55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.soldat66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arma1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glont_4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents soldat11 As PictureBox
    Friend WithEvents Soldat22 As PictureBox
    Friend WithEvents soldat44 As PictureBox
    Friend WithEvents soldat33 As PictureBox
    Friend WithEvents Timer_soldat11 As Timer
    Friend WithEvents Timer_soldat22 As Timer
    Friend WithEvents Timer_soldat33 As Timer
    Friend WithEvents Timer_soldat44 As Timer
    Friend WithEvents Timer_gen1 As Timer
    Friend WithEvents lbl_Hp1 As Label
    Friend WithEvents lbl_Pct1 As Label
    Friend WithEvents glont11 As PictureBox
    Friend WithEvents glont22 As PictureBox
    Friend WithEvents glont33 As PictureBox
    Friend WithEvents ProgressBar11 As ProgressBar
    Friend WithEvents Timer_reincarca1 As Timer
    Friend WithEvents Label11 As Label
    Friend WithEvents Timer_start1 As Timer
    Friend WithEvents soldat55 As PictureBox
    Friend WithEvents soldat66 As PictureBox
    Friend WithEvents Timer_soldat55 As Timer
    Friend WithEvents Timer_soldat66 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents arma1 As PictureBox
    Friend WithEvents animationTimer1 As Timer
    Friend WithEvents glont_4 As PictureBox
End Class
