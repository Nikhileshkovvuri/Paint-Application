<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customize))
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.BrushColor_Label = New System.Windows.Forms.Label()
        Me.BrushSize_Label = New System.Windows.Forms.Label()
        Me.Red_Label = New System.Windows.Forms.Label()
        Me.Green_Label = New System.Windows.Forms.Label()
        Me.Blue_Label = New System.Windows.Forms.Label()
        Me.Red_Trackbar = New System.Windows.Forms.TrackBar()
        Me.Green_trackbar = New System.Windows.Forms.TrackBar()
        Me.Blue_Trackbar = New System.Windows.Forms.TrackBar()
        Me.Brushsize_Trackbar = New System.Windows.Forms.TrackBar()
        Me.Apply_button = New System.Windows.Forms.Button()
        Me.Brush_size = New System.Windows.Forms.Button()
        Me.Display_button = New System.Windows.Forms.Button()
        Me.Preview_colorbox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Red_Trackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Green_trackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blue_Trackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brushsize_Trackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Preview_colorbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Label.Location = New System.Drawing.Point(231, 9)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(280, 34)
        Me.Title_Label.TabIndex = 0
        Me.Title_Label.Text = "Brush Customization"
        '
        'BrushColor_Label
        '
        Me.BrushColor_Label.AutoSize = True
        Me.BrushColor_Label.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrushColor_Label.Location = New System.Drawing.Point(148, 102)
        Me.BrushColor_Label.Name = "BrushColor_Label"
        Me.BrushColor_Label.Size = New System.Drawing.Size(165, 32)
        Me.BrushColor_Label.TabIndex = 1
        Me.BrushColor_Label.Text = "Brush Color"
        '
        'BrushSize_Label
        '
        Me.BrushSize_Label.AutoSize = True
        Me.BrushSize_Label.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrushSize_Label.Location = New System.Drawing.Point(512, 91)
        Me.BrushSize_Label.Name = "BrushSize_Label"
        Me.BrushSize_Label.Size = New System.Drawing.Size(145, 32)
        Me.BrushSize_Label.TabIndex = 2
        Me.BrushSize_Label.Text = "Brush Size"
        '
        'Red_Label
        '
        Me.Red_Label.AutoSize = True
        Me.Red_Label.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Red_Label.Location = New System.Drawing.Point(12, 171)
        Me.Red_Label.Name = "Red_Label"
        Me.Red_Label.Size = New System.Drawing.Size(53, 26)
        Me.Red_Label.TabIndex = 3
        Me.Red_Label.Text = "Red"
        '
        'Green_Label
        '
        Me.Green_Label.AutoSize = True
        Me.Green_Label.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Green_Label.Location = New System.Drawing.Point(12, 267)
        Me.Green_Label.Name = "Green_Label"
        Me.Green_Label.Size = New System.Drawing.Size(76, 26)
        Me.Green_Label.TabIndex = 4
        Me.Green_Label.Text = "Green"
        '
        'Blue_Label
        '
        Me.Blue_Label.AutoSize = True
        Me.Blue_Label.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blue_Label.Location = New System.Drawing.Point(12, 347)
        Me.Blue_Label.Name = "Blue_Label"
        Me.Blue_Label.Size = New System.Drawing.Size(59, 26)
        Me.Blue_Label.TabIndex = 5
        Me.Blue_Label.Text = "Blue"
        '
        'Red_Trackbar
        '
        Me.Red_Trackbar.BackColor = System.Drawing.Color.Red
        Me.Red_Trackbar.LargeChange = 10
        Me.Red_Trackbar.Location = New System.Drawing.Point(103, 171)
        Me.Red_Trackbar.Maximum = 255
        Me.Red_Trackbar.Name = "Red_Trackbar"
        Me.Red_Trackbar.Size = New System.Drawing.Size(276, 56)
        Me.Red_Trackbar.TabIndex = 6
        '
        'Green_trackbar
        '
        Me.Green_trackbar.BackColor = System.Drawing.Color.Green
        Me.Green_trackbar.LargeChange = 10
        Me.Green_trackbar.Location = New System.Drawing.Point(103, 267)
        Me.Green_trackbar.Maximum = 255
        Me.Green_trackbar.Name = "Green_trackbar"
        Me.Green_trackbar.Size = New System.Drawing.Size(276, 56)
        Me.Green_trackbar.TabIndex = 7
        '
        'Blue_Trackbar
        '
        Me.Blue_Trackbar.BackColor = System.Drawing.Color.Blue
        Me.Blue_Trackbar.LargeChange = 10
        Me.Blue_Trackbar.Location = New System.Drawing.Point(103, 347)
        Me.Blue_Trackbar.Maximum = 255
        Me.Blue_Trackbar.Name = "Blue_Trackbar"
        Me.Blue_Trackbar.Size = New System.Drawing.Size(276, 56)
        Me.Blue_Trackbar.TabIndex = 8
        '
        'Brushsize_Trackbar
        '
        Me.Brushsize_Trackbar.BackColor = System.Drawing.Color.Black
        Me.Brushsize_Trackbar.LargeChange = 10
        Me.Brushsize_Trackbar.Location = New System.Drawing.Point(448, 171)
        Me.Brushsize_Trackbar.Maximum = 255
        Me.Brushsize_Trackbar.Name = "Brushsize_Trackbar"
        Me.Brushsize_Trackbar.Size = New System.Drawing.Size(275, 56)
        Me.Brushsize_Trackbar.TabIndex = 9
        '
        'Apply_button
        '
        Me.Apply_button.Location = New System.Drawing.Point(223, 446)
        Me.Apply_button.Name = "Apply_button"
        Me.Apply_button.Size = New System.Drawing.Size(102, 39)
        Me.Apply_button.TabIndex = 10
        Me.Apply_button.Text = "Apply button"
        Me.Apply_button.UseVisualStyleBackColor = True
        '
        'Brush_size
        '
        Me.Brush_size.Location = New System.Drawing.Point(536, 254)
        Me.Brush_size.Name = "Brush_size"
        Me.Brush_size.Size = New System.Drawing.Size(102, 39)
        Me.Brush_size.TabIndex = 11
        Me.Brush_size.Text = "Set Size"
        Me.Brush_size.UseVisualStyleBackColor = True
        '
        'Display_button
        '
        Me.Display_button.Location = New System.Drawing.Point(536, 320)
        Me.Display_button.Name = "Display_button"
        Me.Display_button.Size = New System.Drawing.Size(102, 39)
        Me.Display_button.TabIndex = 12
        Me.Display_button.Text = "Show Color"
        Me.Display_button.UseVisualStyleBackColor = True
        '
        'Preview_colorbox
        '
        Me.Preview_colorbox.BackColor = System.Drawing.Color.White
        Me.Preview_colorbox.Location = New System.Drawing.Point(489, 379)
        Me.Preview_colorbox.Name = "Preview_colorbox"
        Me.Preview_colorbox.Size = New System.Drawing.Size(202, 96)
        Me.Preview_colorbox.TabIndex = 13
        Me.Preview_colorbox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(108, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(347, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "255"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(108, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(108, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Green
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(347, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "255"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(347, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "255"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(452, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(699, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "70"
        '
        'Customize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(769, 512)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Preview_colorbox)
        Me.Controls.Add(Me.Display_button)
        Me.Controls.Add(Me.Brush_size)
        Me.Controls.Add(Me.Apply_button)
        Me.Controls.Add(Me.Brushsize_Trackbar)
        Me.Controls.Add(Me.Blue_Trackbar)
        Me.Controls.Add(Me.Green_trackbar)
        Me.Controls.Add(Me.Red_Trackbar)
        Me.Controls.Add(Me.Blue_Label)
        Me.Controls.Add(Me.Green_Label)
        Me.Controls.Add(Me.Red_Label)
        Me.Controls.Add(Me.BrushSize_Label)
        Me.Controls.Add(Me.BrushColor_Label)
        Me.Controls.Add(Me.Title_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Customize"
        Me.Text = "Customize"
        CType(Me.Red_Trackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Green_trackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blue_Trackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brushsize_Trackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Preview_colorbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_Label As Label
    Friend WithEvents BrushColor_Label As Label
    Friend WithEvents BrushSize_Label As Label
    Friend WithEvents Red_Label As Label
    Friend WithEvents Green_Label As Label
    Friend WithEvents Blue_Label As Label
    Friend WithEvents Red_Trackbar As TrackBar
    Friend WithEvents Green_trackbar As TrackBar
    Friend WithEvents Blue_Trackbar As TrackBar
    Friend WithEvents Brushsize_Trackbar As TrackBar
    Friend WithEvents Apply_button As Button
    Friend WithEvents Brush_size As Button
    Friend WithEvents Display_button As Button
    Friend WithEvents Preview_colorbox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
