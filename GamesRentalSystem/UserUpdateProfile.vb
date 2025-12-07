Imports MySql.Data.MySqlClient

Public Class UserUpdateProfile

    Public Shared currentUserId As Integer
    Public CurrentUserRole As String

    Private Sub UserUpdateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
    End Sub

    Private Sub LoadUserData()

        If currentUserId <= 0 Then
            MessageBox.Show("No user selected. Make sure currentUserId is set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            openConn()

            Dim sql As String = "SELECT firstname, lastname, username, phonenumber, email FROM users WHERE user_id = @id LIMIT 1"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", currentUserId)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then

                        firstnameTxt.Text = If(IsDBNull(dr("firstname")), "", dr("firstname").ToString())
                        lastnameTxt.Text = If(IsDBNull(dr("lastname")), "", dr("lastname").ToString())
                        usernameTxt.Text = If(IsDBNull(dr("username")), "", dr("username").ToString())
                        phonenumberTxt.Text = If(IsDBNull(dr("phonenumber")), "", dr("phonenumber").ToString())
                        emailTxt.Text = If(IsDBNull(dr("email")), "", dr("email").ToString())


                    Else
                        MessageBox.Show("User not found in database.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        firstnameTxt.Text = ""
                        lastnameTxt.Text = ""
                        usernameTxt.Text = ""
                        phonenumberTxt.Text = ""
                        emailTxt.Text = ""

                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("LoadUserData error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If currentUserId <= 0 Then
            MessageBox.Show("No user selected. Cannot update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(usernameTxt.Text) Then
            MessageBox.Show("Username cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            usernameTxt.Focus()
            Return
        End If

        Try
            openConn()

            Dim sql As String =
                "UPDATE users SET
                    firstname = @fn,
                    lastname = @ln,
                    username = @un,
                    phonenumber = @ph,
                    email = @em
                 WHERE user_id = @id"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@fn", firstnameTxt.Text.Trim())
                cmd.Parameters.AddWithValue("@ln", lastnameTxt.Text.Trim())
                cmd.Parameters.AddWithValue("@un", usernameTxt.Text.Trim())
                cmd.Parameters.AddWithValue("@ph", phonenumberTxt.Text.Trim())
                cmd.Parameters.AddWithValue("@em", emailTxt.Text.Trim())
                cmd.Parameters.AddWithValue("@id", currentUserId)

                Dim affected As Integer = cmd.ExecuteNonQuery()
                If affected > 0 Then
                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No rows updated. Make sure the user exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

            LoadUserData()

        Catch ex As Exception
            MessageBox.Show("Update error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()

    End Sub
End Class
