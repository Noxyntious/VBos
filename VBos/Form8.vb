Imports MSTSCLib
Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click


        Try

            rdpView.Server = txtServer.Text
            rdpView.UserName = txtUserName.Text

            Dim isSecured As IMsTscNonScriptable =
               DirectCast(rdpView.GetOcx(), IMsTscNonScriptable)

            isSecured.ClearTextPassword = txtPassword.Text

            rdpView.Connect()

        Catch ex As Exception

            MessageBox.Show("Cannot Connect", "Cannot Connect to: " _
               + txtServer.Text + " Reason:  " + ex.Message,
               MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub BtnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click


        Try

            If rdpView.Connected.ToString() = "1" Then

                rdpView.Disconnect()

            End If

        Catch ex As Exception

            MessageBox.Show("Cannot Disconnect",
                "Cannot Disconnect from: " _
                + txtServer.Text + " Reason: " + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class
