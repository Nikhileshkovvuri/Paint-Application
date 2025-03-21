Public Class Customize
    'Declaring and initializing variables 
    Public red As Integer
    Public green As Integer
    Public blue As Integer
    Public brushsize As Integer

    ''' <summary>
    ''' The method that handles th sliders value when the user uses red trackbar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Red_trackbar_Scroll(sender As Object, e As EventArgs) Handles Red_Trackbar.Scroll
        red = Red_Trackbar.Value
    End Sub

    ''' <summary>
    ''' The method that handles th sliders value when the user uses green trackbar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Green_trackbar_Scroll(sender As Object, e As EventArgs) Handles Green_trackbar.Scroll
        green = Green_trackbar.Value
    End Sub

    ''' <summary>
    ''' The method that handles th sliders value when the user uses blue trackbar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Blue_trackbar_Scroll(sender As Object, e As EventArgs) Handles Blue_Trackbar.Scroll
        blue = Blue_Trackbar.Value
    End Sub

    ''' <summary>
    ''' The method that handles the sliders value when the user uses brush size between 0 to 70
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Brush_trackbar_Scroll(sender As Object, e As EventArgs) Handles Brushsize_trackbar.Scroll
        brushsize = Brushsize_trackbar.Value
    End Sub

    Private Sub Brush_size_Click(sender As Object, e As EventArgs) Handles Brush_size.Click
        Drawing.colordot = brushsize
    End Sub

    ''' <summary>
    ''' The apply button is used in class customization which update the color value in the mybrush which in drawing class
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Apply_button_Click(sender As Object, e As EventArgs) Handles Apply_button.Click
        Dim brush As Brush
        brush = New SolidBrush(Color.FromArgb(255, red, green, blue))
        Drawing.mybrush = brush
        Me.Hide()
    End Sub

    ''' <summary>
    ''' The display color button displays the rgb color that is choosed and is going to be displayed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Display_color_Click(sender As Object, e As EventArgs) Handles Display_button.Click
        Preview_colorbox.BackColor = Color.FromArgb(red, green, blue)
    End Sub

End Class