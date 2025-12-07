Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If username_txt.Text = "Admin" And password_txt.Text = "Admin123" Then
            AdminPage.Show()
            Me.Hide()
            Return

        Else
            Try
                openConn()

                Dim query As String = "SELECT * FROM users WHERE username=@username AND password=@password"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username_txt.Text)
                    cmd.Parameters.AddWithValue("@password", password_txt.Text)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then


                            UserPage.currentUserId = reader("user_id")
                            UserUpdateProfile.currentUserId = reader("user_id")



                            reader.Close()
                            closeConn()

                            UserPage.Show()
                            Me.Hide()
                            Return



                        Else
                            MsgBox("Invalid username or password!", MsgBoxStyle.Critical)
                        End If
                    End Using
                End Using



                closeConn()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SignUpForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
