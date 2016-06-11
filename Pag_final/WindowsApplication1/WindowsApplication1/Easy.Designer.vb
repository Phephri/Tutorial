<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Easy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Easy))
        Me.soldat1 = New System.Windows.Forms.PictureBox()
        Me.Soldat2 = New System.Windows.Forms.PictureBox()
        Me.soldat4 = New System.Windows.Forms.PictureBox()
        Me.soldat3 = New System.Windows.Forms.PictureBox()
        Me.Timer_soldat1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_soldat2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_soldat3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_soldat4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_gen = New System.Windows.Forms.Timer(Me.components)
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.lbl_Hp = New System.Windows.Forms.Label()
        Me.lbl_Pct = New System.Windows.Forms.Label()
        Me.glont1 = New System.Windows.Forms.PictureBox()
        Me.glont2 = New System.Windows.Forms.PictureBox()
        Me.glont3 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer_reincarca = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer_start = New System.Windows.Forms.Timer(Me.components)
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.arma = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.soldat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Soldat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.soldat4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.soldat3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glont1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glont2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glont3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'soldat1
        '
        Me.soldat1.BackColor = System.Drawing.Color.Transparent
        Me.soldat1.Image = CType(resources.GetObject("soldat1.Image"), System.Drawing.Image)
        Me.soldat1.Location = New System.Drawing.Point(521, 230)
        Me.soldat1.Name = "soldat1"
        Me.soldat1.Size = New System.Drawing.Size(46, 97)
        Me.soldat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.soldat1.TabIndex = 4
        Me.soldat1.TabStop = False
        Me.soldat1.Visible = False
        '
        'Soldat2
        '
        Me.Soldat2.BackColor = System.Drawing.Color.Transparent
        Me.Soldat2.Image = CType(resources.GetObject("Soldat2.Image"), System.Drawing.Image)
        Me.Soldat2.Location = New System.Drawing.Point(275, 213)
        Me.Soldat2.Name = "Soldat2"
        Me.Soldat2.Size = New System.Drawing.Size(89, 97)
        Me.Soldat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Soldat2.TabIndex = 6
        Me.Soldat2.TabStop = False
        Me.Soldat2.Visible = False
        '
        'soldat4
        '
        Me.soldat4.BackColor = System.Drawing.Color.Transparent
        Me.soldat4.Image = CType(resources.GetObject("soldat4.Image"), System.Drawing.Image)
        Me.soldat4.Location = New System.Drawing.Point(360, 242)
        Me.soldat4.Name = "soldat4"
        Me.soldat4.Size = New System.Drawing.Size(140, 166)
        Me.soldat4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.soldat4.TabIndex = 7
        Me.soldat4.TabStop = False
        Me.soldat4.Visible = False
        '
        'soldat3
        '
        Me.soldat3.BackColor = System.Drawing.Color.Transparent
        Me.soldat3.Image = CType(resources.GetObject("soldat3.Image"), System.Drawing.Image)
        Me.soldat3.Location = New System.Drawing.Point(586, 230)
        Me.soldat3.Name = "soldat3"
        Me.soldat3.Size = New System.Drawing.Size(32, 64)
        Me.soldat3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.soldat3.TabIndex = 8
        Me.soldat3.TabStop = False
        Me.soldat3.Visible = False
        '
        'Timer_soldat1
        '
        Me.Timer_soldat1.Interval = 1500
        '
        'Timer_soldat2
        '
        Me.Timer_soldat2.Interval = 1500
        '
        'Timer_soldat3
        '
        Me.Timer_soldat3.Interval = 1500
        '
        'Timer_soldat4
        '
        Me.Timer_soldat4.Interval = 1500
        '
        'Timer_gen
        '
        '
        'lbl_Hp
        '
        Me.lbl_Hp.AutoSize = True
        Me.lbl_Hp.Location = New System.Drawing.Point(54, 9)
        Me.lbl_Hp.Name = "lbl_Hp"
        Me.lbl_Hp.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Hp.TabIndex = 9
        Me.lbl_Hp.Text = "HP 100"
        '
        'lbl_Pct
        '
        Me.lbl_Pct.AutoSize = True
        Me.lbl_Pct.Location = New System.Drawing.Point(253, 9)
        Me.lbl_Pct.Name = "lbl_Pct"
        Me.lbl_Pct.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Pct.TabIndex = 10
        Me.lbl_Pct.Text = "Punctaj 0"
        '
        'glont1
        '
        Me.glont1.BackColor = System.Drawing.Color.Transparent
        Me.glont1.Image = CType(resources.GetObject("glont1.Image"), System.Drawing.Image)
        Me.glont1.Location = New System.Drawing.Point(556, 368)
        Me.glont1.Name = "glont1"
        Me.glont1.Size = New System.Drawing.Size(67, 50)
        Me.glont1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.glont1.TabIndex = 21
        Me.glont1.TabStop = False
        '
        'glont2
        '
        Me.glont2.BackColor = System.Drawing.Color.Transparent
        Me.glont2.Image = CType(resources.GetObject("glont2.Image"), System.Drawing.Image)
        Me.glont2.Location = New System.Drawing.Point(599, 368)
        Me.glont2.Name = "glont2"
        Me.glont2.Size = New System.Drawing.Size(67, 50)
        Me.glont2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.glont2.TabIndex = 22
        Me.glont2.TabStop = False
        '
        'glont3
        '
        Me.glont3.BackColor = System.Drawing.Color.Transparent
        Me.glont3.Image = CType(resources.GetObject("glont3.Image"), System.Drawing.Image)
        Me.glont3.Location = New System.Drawing.Point(638, 368)
        Me.glont3.Name = "glont3"
        Me.glont3.Size = New System.Drawing.Size(67, 50)
        Me.glont3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.glont3.TabIndex = 23
        Me.glont3.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(572, 385)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(124, 23)
        Me.ProgressBar1.TabIndex = 24
        '
        'Timer_reincarca
        '
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(320, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 106)
        Me.Label1.TabIndex = 26
        '
        'Timer_start
        '
        '
        'animationTimer
        '
        Me.animationTimer.Enabled = True
        Me.animationTimer.Interval = 1
        '
        'arma
        '
        Me.arma.BackColor = System.Drawing.Color.Tan
        Me.arma.Image = CType(resources.GetObject("arma.Image"), System.Drawing.Image)
        Me.arma.Location = New System.Drawing.Point(275, 424)
        Me.arma.Name = "arma"
        Me.arma.Size = New System.Drawing.Size(139, 78)
        Me.arma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.arma.TabIndex = 27
        Me.arma.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Tan
        Me.PictureBox1.Location = New System.Drawing.Point(0, 424)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(720, 78)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Easy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(708, 502)
        Me.Controls.Add(Me.arma)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.glont3)
        Me.Controls.Add(Me.glont2)
        Me.Controls.Add(Me.glont1)
        Me.Controls.Add(Me.lbl_Pct)
        Me.Controls.Add(Me.lbl_Hp)
        Me.Controls.Add(Me.soldat3)
        Me.Controls.Add(Me.Soldat2)
        Me.Controls.Add(Me.soldat1)
        Me.Controls.Add(Me.soldat4)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Easy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy"
        CType(Me.soldat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Soldat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.soldat4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.soldat3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glont1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glont2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glont3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents soldat1 As PictureBox
    Friend WithEvents Soldat2 As PictureBox
    Friend WithEvents soldat4 As PictureBox
    Friend WithEvents soldat3 As PictureBox
    Friend WithEvents Timer_soldat1 As Timer
    Friend WithEvents Timer_soldat2 As Timer
    Friend WithEvents Timer_soldat3 As Timer
    Friend WithEvents Timer_soldat4 As Timer
    Friend WithEvents Timer_gen As Timer
    Friend WithEvents ServiceController1 As ServiceProcess.ServiceController
    Friend WithEvents lbl_Hp As Label
    Friend WithEvents lbl_Pct As Label
    Friend WithEvents glont1 As PictureBox
    Friend WithEvents glont2 As PictureBox
    Friend WithEvents glont3 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer_reincarca As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer_start As Timer
    Friend WithEvents animationTimer As Timer
    Friend WithEvents arma As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
