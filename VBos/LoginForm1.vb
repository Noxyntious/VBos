Public Class LoginForm1

    ' TODO: Vložte kód pro provedení vlastního ovìøení použitím poskytnutého uživatelského jména a hesla 
    ' (Viz https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Vlastní hlavní hodnota mùže být dále pøipojena k hlavní hodnotì aktuálního vlákna: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' kde CustomPrincipal je implementace rozhraní IPrincipal použita k provedení ovìøení. 
    ' Následnì bude My.User vracet informace o identitì zapouzdøené v objektu CustomPrincipal
    ' jako je uživatelské jméno, zobrazované jméno, atd.

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
