<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.exitButton = New System.Windows.Forms.Label()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.TextBox_nCasts = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_casts = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label_min = New System.Windows.Forms.Label()
        Me.TextBox_downMin = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label_max = New System.Windows.Forms.Label()
        Me.TextBox_downMax = New System.Windows.Forms.TextBox()
        Me.Button_toggle = New System.Windows.Forms.Button()
        Me.TextBox_clickInterval = New System.Windows.Forms.TextBox()
        Me.Label_interval = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ClickTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label_mousedown = New System.Windows.Forms.Label()
        Me.Label_clicksleft = New System.Windows.Forms.Label()
        Me.Label_clickInterval = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Picture_hat = New System.Windows.Forms.PictureBox()
        Me.Picture_icon = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Picture_hat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitButton.AutoSize = True
        Me.exitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitButton.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.Color.White
        Me.exitButton.Location = New System.Drawing.Point(221, 3)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(22, 24)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "x"
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label_Title.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_Title.Location = New System.Drawing.Point(3, 3)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(162, 19)
        Me.Label_Title.TabIndex = 1
        Me.Label_Title.Text = "Left_'s Alchemist"
        '
        'TextBox_nCasts
        '
        Me.TextBox_nCasts.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox_nCasts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_nCasts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_nCasts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.TextBox_nCasts.Location = New System.Drawing.Point(164, 6)
        Me.TextBox_nCasts.Name = "TextBox_nCasts"
        Me.TextBox_nCasts.Size = New System.Drawing.Size(35, 14)
        Me.TextBox_nCasts.TabIndex = 5
        Me.TextBox_nCasts.Text = "1000"
        Me.TextBox_nCasts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label_casts)
        Me.Panel1.Controls.Add(Me.TextBox_nCasts)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(7, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 23)
        Me.Panel1.TabIndex = 8
        '
        'Label_casts
        '
        Me.Label_casts.AutoSize = True
        Me.Label_casts.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label_casts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_casts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_casts.Location = New System.Drawing.Point(5, 4)
        Me.Label_casts.Name = "Label_casts"
        Me.Label_casts.Size = New System.Drawing.Size(113, 16)
        Me.Label_casts.TabIndex = 9
        Me.Label_casts.Text = "Number of casts"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(205, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Label8, "How many clicks are going to be performed. (Number of high alchemy spells you can" &
        " cast)")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label_min)
        Me.Panel2.Controls.Add(Me.TextBox_downMin)
        Me.Panel2.Location = New System.Drawing.Point(7, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 23)
        Me.Panel2.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(205, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 16)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Label12, "Shortest period of time of mouse down simulation (reccomend between 10 and 150)")
        '
        'Label_min
        '
        Me.Label_min.AutoSize = True
        Me.Label_min.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label_min.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label_min.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_min.Location = New System.Drawing.Point(5, 4)
        Me.Label_min.Name = "Label_min"
        Me.Label_min.Size = New System.Drawing.Size(149, 16)
        Me.Label_min.TabIndex = 9
        Me.Label_min.Text = "Mouse down min (ms)"
        '
        'TextBox_downMin
        '
        Me.TextBox_downMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox_downMin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_downMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_downMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.TextBox_downMin.Location = New System.Drawing.Point(164, 6)
        Me.TextBox_downMin.Name = "TextBox_downMin"
        Me.TextBox_downMin.Size = New System.Drawing.Size(35, 14)
        Me.TextBox_downMin.TabIndex = 5
        Me.TextBox_downMin.Text = "20"
        Me.TextBox_downMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label_max)
        Me.Panel3.Controls.Add(Me.TextBox_downMax)
        Me.Panel3.Location = New System.Drawing.Point(7, 192)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(227, 23)
        Me.Panel3.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(205, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Label11, "Longest period of time of mouse down simulation (MUST be higher than minimum valu" &
        "e above. Reccomended value 250)")
        '
        'Label_max
        '
        Me.Label_max.AutoSize = True
        Me.Label_max.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label_max.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label_max.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_max.Location = New System.Drawing.Point(5, 4)
        Me.Label_max.Name = "Label_max"
        Me.Label_max.Size = New System.Drawing.Size(153, 16)
        Me.Label_max.TabIndex = 9
        Me.Label_max.Text = "Mouse down max (ms)"
        '
        'TextBox_downMax
        '
        Me.TextBox_downMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox_downMax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_downMax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_downMax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.TextBox_downMax.Location = New System.Drawing.Point(164, 6)
        Me.TextBox_downMax.Name = "TextBox_downMax"
        Me.TextBox_downMax.Size = New System.Drawing.Size(35, 14)
        Me.TextBox_downMax.TabIndex = 5
        Me.TextBox_downMax.Text = "250"
        Me.TextBox_downMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_toggle
        '
        Me.Button_toggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Button_toggle.FlatAppearance.BorderSize = 0
        Me.Button_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_toggle.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button_toggle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Button_toggle.Location = New System.Drawing.Point(86, 265)
        Me.Button_toggle.Name = "Button_toggle"
        Me.Button_toggle.Size = New System.Drawing.Size(75, 23)
        Me.Button_toggle.TabIndex = 13
        Me.Button_toggle.Text = "Start"
        Me.Button_toggle.UseVisualStyleBackColor = True
        '
        'TextBox_clickInterval
        '
        Me.TextBox_clickInterval.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox_clickInterval.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_clickInterval.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_clickInterval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.TextBox_clickInterval.Location = New System.Drawing.Point(164, 6)
        Me.TextBox_clickInterval.Name = "TextBox_clickInterval"
        Me.TextBox_clickInterval.Size = New System.Drawing.Size(35, 14)
        Me.TextBox_clickInterval.TabIndex = 5
        Me.TextBox_clickInterval.Text = "1000"
        Me.TextBox_clickInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_interval
        '
        Me.Label_interval.AutoSize = True
        Me.Label_interval.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label_interval.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label_interval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_interval.Location = New System.Drawing.Point(5, 4)
        Me.Label_interval.Name = "Label_interval"
        Me.Label_interval.Size = New System.Drawing.Size(158, 16)
        Me.Label_interval.TabIndex = 9
        Me.Label_interval.Text = "Base click interval (ms)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(205, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Label10, "How often the clicks will be sent")
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label_interval)
        Me.Panel4.Controls.Add(Me.TextBox_clickInterval)
        Me.Panel4.Location = New System.Drawing.Point(7, 232)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(227, 23)
        Me.Panel4.TabIndex = 12
        '
        'ClickTimer
        '
        Me.ClickTimer.Interval = 1000
        '
        'Label_mousedown
        '
        Me.Label_mousedown.AutoSize = True
        Me.Label_mousedown.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label_mousedown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_mousedown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_mousedown.Location = New System.Drawing.Point(12, 291)
        Me.Label_mousedown.Name = "Label_mousedown"
        Me.Label_mousedown.Size = New System.Drawing.Size(81, 14)
        Me.Label_mousedown.TabIndex = 11
        Me.Label_mousedown.Text = "Mouse down:"
        '
        'Label_clicksleft
        '
        Me.Label_clicksleft.AutoSize = True
        Me.Label_clicksleft.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label_clicksleft.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_clicksleft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_clicksleft.Location = New System.Drawing.Point(129, 291)
        Me.Label_clicksleft.Name = "Label_clicksleft"
        Me.Label_clicksleft.Size = New System.Drawing.Size(61, 14)
        Me.Label_clicksleft.TabIndex = 15
        Me.Label_clicksleft.Text = "Clicks left:"
        '
        'Label_clickInterval
        '
        Me.Label_clickInterval.AutoSize = True
        Me.Label_clickInterval.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label_clickInterval.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_clickInterval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_clickInterval.Location = New System.Drawing.Point(12, 319)
        Me.Label_clickInterval.Name = "Label_clickInterval"
        Me.Label_clickInterval.Size = New System.Drawing.Size(77, 14)
        Me.Label_clickInterval.TabIndex = 16
        Me.Label_clickInterval.Text = "Click interval:"
        '
        'Picture_hat
        '
        Me.Picture_hat.Image = Global.Alchemist.My.Resources.Resources.Wizard_hat__g__detail_old
        Me.Picture_hat.Location = New System.Drawing.Point(94, 34)
        Me.Picture_hat.Name = "Picture_hat"
        Me.Picture_hat.Size = New System.Drawing.Size(54, 58)
        Me.Picture_hat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture_hat.TabIndex = 14
        Me.Picture_hat.TabStop = False
        '
        'Picture_icon
        '
        Me.Picture_icon.Image = Global.Alchemist.My.Resources.Resources.piq_6452_400x4001
        Me.Picture_icon.Location = New System.Drawing.Point(167, 3)
        Me.Picture_icon.Name = "Picture_icon"
        Me.Picture_icon.Size = New System.Drawing.Size(23, 19)
        Me.Picture_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture_icon.TabIndex = 4
        Me.Picture_icon.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BackgroundImage = Global.Alchemist.My.Resources.Resources.Splatter_PNG_Image1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(246, 342)
        Me.Controls.Add(Me.Picture_icon)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Picture_hat)
        Me.Controls.Add(Me.Label_clickInterval)
        Me.Controls.Add(Me.Label_clicksleft)
        Me.Controls.Add(Me.Label_mousedown)
        Me.Controls.Add(Me.Button_toggle)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.exitButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.Text = "Alchemist Clicker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Picture_hat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Label
    Friend WithEvents Label_Title As Label
    Friend WithEvents Picture_icon As PictureBox
    Friend WithEvents TextBox_nCasts As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_casts As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_min As Label
    Friend WithEvents TextBox_downMin As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label_max As Label
    Friend WithEvents TextBox_downMax As TextBox
    Friend WithEvents Button_toggle As Button
    Friend WithEvents Picture_hat As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox_clickInterval As TextBox
    Friend WithEvents Label_interval As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ClickTimer As Timer
    Friend WithEvents Label_mousedown As Label
    Friend WithEvents Label_clicksleft As Label
    Friend WithEvents Label_clickInterval As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
