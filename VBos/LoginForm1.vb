Public Class LoginForm1

    ' TODO: Vlo�te k�d pro proveden� vlastn�ho ov��en� pou�it�m poskytnut�ho u�ivatelsk�ho jm�na a hesla 
    ' (Viz https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Vlastn� hlavn� hodnota m��e b�t d�le p�ipojena k hlavn� hodnot� aktu�ln�ho vl�kna: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' kde CustomPrincipal je implementace rozhran� IPrincipal pou�ita k proveden� ov��en�. 
    ' N�sledn� bude My.User vracet informace o identit� zapouzd�en� v objektu CustomPrincipal
    ' jako je u�ivatelsk� jm�no, zobrazovan� jm�no, atd.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If ComboBox1.Text = "Noxyntious" And PasswordTextBox.Text = "speakersxd" Then
            Form2.Show()
            Me.Close()
        Else

        End If
        If ComboBox1.Text = "Administrator" And PasswordTextBox.Text = "admin2003" Then
            Form2.Show()
            Me.Close()
        Else

        End If
        If ComboBox1.Text = "SilentHaxxor" And PasswordTextBox.Text = "silent1999password1" Then
            Form2.Show()
            Me.Close()
        Else

        End If
        If ComboBox1.Text = "Guest" Then
            Form2.Show()
            Me.Close()
        Else

        End If
        If ComboBox1.Text = "defaultuser0" Then

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Form1.Close()
    End Sub
End Class
