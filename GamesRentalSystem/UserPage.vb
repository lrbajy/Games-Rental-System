
Imports MySql.Data.MySqlClient

Public Class UserPage
    Public Shared currentUserId As Integer

    Private Sub UserPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUserData()
    End Sub

    Private Sub UserProfileBtn_Click(sender As Object, e As EventArgs) Handles UserProfileBtn.Click
        UserProfileBtn.Text = "| Profile"

        AddRentFormBtn.Text = "Rent"
    End Sub

    Private Sub ViewRentForm_Click(sender As Object, e As EventArgs)
        UserProfileBtn.Text = "Profile"

        AddRentFormBtn.Text = " Rent"
        UserAddRentForm.Hide()


    End Sub

    Private Sub AddRentForm_Click(sender As Object, e As EventArgs) Handles AddRentFormBtn.Click

        UserProfileBtn.Text = "Profile"
        AddRentFormBtn.Text = "| Rent"

        UserAddRentForm.Show()

    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        UserAddRentForm.Hide()

        LoginForm.Show()
    End Sub

    Private Sub loadUserData()
        Try
            openConn()

            Dim query As String = "SELECT * FROM users WHERE user_id=@uid"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", currentUserId)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                firstname.Text = reader("firstname") & " " & reader("lastname")
                '' lastname.Text = reader("lastname")
                firstnameTxt.Text = reader("firstname") & " " & reader("lastname")
                '' lastnameTxt.Text = reader("lastname")
                usernameTxt.Text = reader("username")
                phonenumberTxt.Text = reader("phonenumber")
                emailTxt.Text = reader("email")
            End If

            closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        UserUpdateProfile.Show()

    End Sub
End Class
