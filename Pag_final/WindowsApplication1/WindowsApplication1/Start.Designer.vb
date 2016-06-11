<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.btn_Help = New System.Windows.Forms.Button()
        Me.btn_info = New System.Windows.Forms.Button()
        Me.btn_highscore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton1.Location = New System.Drawing.Point(23, 43)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(69, 28)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Easy"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton2.Location = New System.Drawing.Point(49, 77)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(97, 28)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Medium"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton3.Location = New System.Drawing.Point(77, 111)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(69, 28)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Hard"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.Color.Black
        Me.btn_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Start.Location = New System.Drawing.Point(23, 230)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(126, 42)
        Me.btn_Start.TabIndex = 3
        Me.btn_Start.Text = "START"
        Me.btn_Start.UseVisualStyleBackColor = False
        '
        'btn_Help
        '
        Me.btn_Help.Location = New System.Drawing.Point(509, 314)
        Me.btn_Help.Name = "btn_Help"
        Me.btn_Help.Size = New System.Drawing.Size(75, 23)
        Me.btn_Help.TabIndex = 4
        Me.btn_Help.Text = "Help"
        Me.btn_Help.UseVisualStyleBackColor = True
        '
        'btn_info
        '
        Me.btn_info.Location = New System.Drawing.Point(428, 314)
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(75, 23)
        Me.btn_info.TabIndex = 5
        Me.btn_info.Text = "Info"
        Me.btn_info.UseVisualStyleBackColor = True
        '
        'btn_highscore
        '
        Me.btn_highscore.Location = New System.Drawing.Point(347, 314)
        Me.btn_highscore.Name = "btn_highscore"
        Me.btn_highscore.Size = New System.Drawing.Size(75, 23)
        Me.btn_highscore.TabIndex = 6
        Me.btn_highscore.Text = "Highscore"
        Me.btn_highscore.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.soldier_wallpaper_18
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(586, 349)
        Me.Controls.Add(Me.btn_highscore)
        Me.Controls.Add(Me.btn_info)
        Me.Controls.Add(Me.btn_Help)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RIFLE WAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents btn_Start As Button
    Friend WithEvents btn_Help As Button
    Friend WithEvents btn_info As Button
    Friend WithEvents btn_highscore As Button
End Class
