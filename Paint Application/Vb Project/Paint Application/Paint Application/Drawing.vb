Public Class Drawing
    'Initializing and declaring Variables'
    Dim down = False
    Public mybrush = Brushes.Black
    Public colordot As Integer

    ''' <summary>
    ''' By clicking on Customize button we are directed to second form which is customization for bursh
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Customize_button_Click(sender As Object, e As EventArgs) Handles Customize_Button.Click
        Customize.Show()
    End Sub

    ''' <summary>
    ''' this is the  picture box where user will be able to draw
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Drawing_Box.Click

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles Drawing_Box.MouseDown
        down = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles Drawing_Box.MouseMove
        If down = True Then
            Drawing_Box.CreateGraphics.FillEllipse(mybrush, e.X, e.Y, colordot, colordot)
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles Drawing_Box.MouseUp
        down = False
    End Sub


    ''' <summary>
    ''' clear box clears the done drawing done in the picture box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub Clear_button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Drawing_Box.Refresh()

    End Sub

    ''' <summary>
    ''' exit button exits the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles Exit_button.Click
        Me.Close()
    End Sub
End Class
