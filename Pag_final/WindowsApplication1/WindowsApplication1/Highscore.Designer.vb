<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Highscore
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
        Me.lst_Highscore = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lst_Easy = New System.Windows.Forms.ListBox()
        Me.lst_Medium = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighscoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.HighscoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_Highscore
        '
        Me.lst_Highscore.BackColor = System.Drawing.Color.LightGray
        Me.lst_Highscore.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Highscore.FormattingEnabled = True
        Me.lst_Highscore.ItemHeight = 15
        Me.lst_Highscore.Location = New System.Drawing.Point(491, 39)
        Me.lst_Highscore.Name = "lst_Highscore"
        Me.lst_Highscore.Size = New System.Drawing.Size(185, 214)
        Me.lst_Highscore.Sorted = True
        Me.lst_Highscore.TabIndex = 0
        Me.lst_Highscore.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(562, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 21)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Go back to Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lst_Easy
        '
        Me.lst_Easy.BackColor = System.Drawing.Color.LightGray
        Me.lst_Easy.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Easy.FormattingEnabled = True
        Me.lst_Easy.ItemHeight = 15
        Me.lst_Easy.Location = New System.Drawing.Point(22, 39)
        Me.lst_Easy.Name = "lst_Easy"
        Me.lst_Easy.Size = New System.Drawing.Size(185, 214)
        Me.lst_Easy.Sorted = True
        Me.lst_Easy.TabIndex = 2
        Me.lst_Easy.Visible = False
        '
        'lst_Medium
        '
        Me.lst_Medium.BackColor = System.Drawing.Color.LightGray
        Me.lst_Medium.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Medium.FormattingEnabled = True
        Me.lst_Medium.ItemHeight = 15
        Me.lst_Medium.Location = New System.Drawing.Point(262, 39)
        Me.lst_Medium.Name = "lst_Medium"
        Me.lst_Medium.Size = New System.Drawing.Size(184, 214)
        Me.lst_Medium.Sorted = True
        Me.lst_Medium.TabIndex = 0
        Me.lst_Medium.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem, Me.MediumToolStripMenuItem, Me.HardToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(702, 30)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(67, 26)
        Me.EasyToolStripMenuItem.Text = "Easy"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(96, 26)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'HardToolStripMenuItem
        '
        Me.HardToolStripMenuItem.Name = "HardToolStripMenuItem"
        Me.HardToolStripMenuItem.Size = New System.Drawing.Size(73, 26)
        Me.HardToolStripMenuItem.Text = "Hard"
        '
        'Highscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 325)
        Me.Controls.Add(Me.lst_Medium)
        Me.Controls.Add(Me.lst_Easy)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lst_Highscore)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Highscore"
        Me.Text = "Highscore"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.HighscoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_Highscore As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lst_Easy As ListBox
    Friend WithEvents lst_Medium As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EasyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighscoreBindingSource As BindingSource
End Class
