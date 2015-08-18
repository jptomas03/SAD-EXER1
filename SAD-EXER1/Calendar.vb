Public Class Calendar

    Private Sub timDisplay_Tick(sender As Object, e As EventArgs) Handles timDisplay.Tick
        Dim month As Integer = Date.Today.Month
        lblTime.Text = TimeOfDay()
        lblNumber.Text = Date.Today.Day
        lblDay.Text = Date.Today.DayOfWeek.ToString
        lblYear.Text = Date.Today.Year
        If month = 1 Then
            lblMonth.Text = "January"
        ElseIf month = 2 Then
            lblMonth.Text = "February"
        ElseIf month = 3 Then
            lblMonth.Text = "March"
        ElseIf month = 4 Then
            lblMonth.Text = "April"
        ElseIf month = 5 Then
            lblMonth.Text = "May"
        ElseIf month = 6 Then
            lblMonth.Text = "June"
        ElseIf month = 7 Then
            lblMonth.Text = "July"
        ElseIf month = 8 Then
            lblMonth.Text = "August"
        ElseIf month = 9 Then
            lblMonth.Text = "September"
        ElseIf month = 10 Then
            lblMonth.Text = "October"
        ElseIf month = 11 Then
            lblMonth.Text = "November"
        ElseIf month = 12 Then
            lblMonth.Text = "December"
        End If
    End Sub

    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles Me.Load
        timDisplay.Start()
    End Sub
End Class
