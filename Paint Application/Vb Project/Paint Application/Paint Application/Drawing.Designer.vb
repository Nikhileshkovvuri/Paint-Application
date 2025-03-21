<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Drawing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Drawing))
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.Drawing_Box = New System.Windows.Forms.PictureBox()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Customize_Button = New System.Windows.Forms.Button()
        Me.Exit_button = New System.Windows.Forms.Button()
        Me.Note_Label = New System.Windows.Forms.Label()
        Me.Info_Label = New System.Windows.Forms.Label()
        CType(Me.Drawing_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Label.Location = New System.Drawing.Point(217, 9)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(256, 38)
        Me.Title_Label.TabIndex = 0
        Me.Title_Label.Text = "Paint Application"
        '
        'Drawing_Box
        '
        Me.Drawing_Box.BackColor = System.Drawing.Color.White
        Me.Drawing_Box.Location = New System.Drawing.Point(30, 65)
        Me.Drawing_Box.Name = "Drawing_Box"
        Me.Drawing_Box.Size = New System.Drawing.Size(661, 356)
        Me.Drawing_Box.TabIndex = 1
        Me.Drawing_Box.TabStop = False
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(708, 65)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(81, 38)
        Me.Clear_Button.TabIndex = 2
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseMnemonic = False
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Customize_Button
        '
        Me.Customize_Button.Location = New System.Drawing.Point(708, 225)
        Me.Customize_Button.Name = "Customize_Button"
        Me.Customize_Button.Size = New System.Drawing.Size(86, 38)
        Me.Customize_Button.TabIndex = 3
        Me.Customize_Button.Text = "Customize_button"
        Me.Customize_Button.UseVisualStyleBackColor = True
        '
        'Exit_button
        '
        Me.Exit_button.Location = New System.Drawing.Point(708, 383)
        Me.Exit_button.Name = "Exit_button"
        Me.Exit_button.Size = New System.Drawing.Size(81, 38)
        Me.Exit_button.TabIndex = 4
        Me.Exit_button.Text = "Exit"
        Me.Exit_button.UseVisualStyleBackColor = True
        '
        'Note_Label
        '
        Me.Note_Label.AutoSize = True
        Me.Note_Label.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note_Label.Location = New System.Drawing.Point(25, 424)
        Me.Note_Label.Name = "Note_Label"
        Me.Note_Label.Size = New System.Drawing.Size(74, 26)
        Me.Note_Label.TabIndex = 5
        Me.Note_Label.Text = "Note :"
        '
        'Info_Label
        '
        Me.Info_Label.AutoSize = True
        Me.Info_Label.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_Label.Location = New System.Drawing.Point(119, 428)
        Me.Info_Label.Name = "Info_Label"
        Me.Info_Label.Size = New System.Drawing.Size(597, 54)
        Me.Info_Label.TabIndex = 6
        Me.Info_Label.Text = "Please set the Brush size and color (RGB) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from Customize button as we have kept" &
    " as 0 for user section."
        '
        'Drawing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(806, 501)
        Me.Controls.Add(Me.Info_Label)
        Me.Controls.Add(Me.Note_Label)
        Me.Controls.Add(Me.Exit_button)
        Me.Controls.Add(Me.Customize_Button)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.Drawing_Box)
        Me.Controls.Add(Me.Title_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Drawing"
        Me.Text = "Painting Application"
        CType(Me.Drawing_Box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_Label As Label
    Friend WithEvents Drawing_Box As PictureBox
    Friend WithEvents Clear_Button As Button
    Friend WithEvents Customize_Button As Button
    Friend WithEvents Exit_button As Button
    Friend WithEvents Note_Label As Label
    Friend WithEvents Info_Label As Label
End Class
