Public Class login
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtUser.Clear()
        TxtPass.Clear()
    End Sub

    Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click

        If BtnLogIn.Text = "" Then
            MessageBox.Show("Please Enter Username")
            TxtUser.Focus()
            Exit Sub
        ElseIf TxtPass.Text = "" Then
            MessageBox.Show("Please Enter Password")
            TxtPass.Focus()
            Exit Sub
        End If
        If TxtUser.Text = "krim" And TxtPass.Text = "krimmy" Then
            Dim StudentInfo As New StudentInfo()
            StudentInfo.Show()
        Else
            MessageBox.Show("Incorrect username or Password")
        End If
    End Sub

    Private Sub passShow_CheckedChanged(sender As Object, e As EventArgs) Handles passShow.CheckedChanged
        If passShow.Checked = True Then
            TxtPass.PasswordChar = ""
        Else
            TxtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged

    End Sub
End Class
