Public Class Form9
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Hide()
        Form2.Close()
        Form1.Hide()
        Form10.Show()
        Form11.MdiParent = Form2
        Form11.Show()
        Close()
    End Sub
End Class