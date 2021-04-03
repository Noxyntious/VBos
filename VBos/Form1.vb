Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub
    Private Sub Timer1_tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 5
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            LoginForm1.Show()
            ProgressBar1.Value = ProgressBar1.Minimum
            Timer1.Enabled = False


        End If



    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
