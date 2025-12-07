Imports MySql.Data.MySqlClient

Public Class SignUpForm
    Private Sub signup_button_Click(sender As Object, e As EventArgs) Handles signup_button.Click
        Try
            openConn()

            Dim query As String = "INSERT INTO users(username, password, firstname, lastname, phonenumber, email) 
                                   VALUES(@username, @password, @firstname, @lastname, 'none', 'none')"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username_txt.Text)
            cmd.Parameters.AddWithValue("@password", password_txt.Text)
            cmd.Parameters.AddWithValue("@firstname", firstname_txt.Text)
            cmd.Parameters.AddWithValue("@lastname", lastname_txt.Text)


            cmd.ExecuteNonQuery()


            closeConn()
            Me.Hide()
            LoginForm.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub terms_checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles terms_checkbox.CheckedChanged
        MsgBox("By accessing, or using this Application, you agree to comply with and be bound by these Terms and Conditions. If you do not agree, please stop using the Service immediately.

Your use of the Service is also governed by our Privacy Policy, which outlines how we collect, use, and protect your data. By using the Service, you consent to the processing of your information as described in the Privacy Policy.", MsgBoxStyle.Information)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
