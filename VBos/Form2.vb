Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        TimerText.Text = Format(Now, "dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MDIchild1.MdiParent = Me
        MDIchild1.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerText.Text = TimeString
        DaterText.Text = DateString
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles DaterText.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AboutBox1.MdiParent = Me
        AboutBox1.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PONE.MdiParent = Me
        PONE.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Form4.MdiParent = Me
        Form4.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form5.MdiParent = Me
        Form5.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form6.MdiParent = Me
        Form6.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        disc.MdiParent = Me
        disc.Show()
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Form7.MdiParent = Me
        Form7.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim oForm As New Form8
        oForm.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Form1.Show()
        Form1.Timer1.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form9.MdiParent = Me
        Form9.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        disc.MdiParent = Me
        disc.Show()
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs)
        calc.MdiParent = Me
        calc.Show()
    End Sub

    Private Sub Button13_Click_2(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub
End Class