Public Class LOGIN
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "abhinav" And TextBox2.Text = "abhi123+++") Then
            Homepage.Show()


        Else
            MsgBox("Invalid User/Password!!", MsgBoxStyle.Critical, "SECURITY")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
