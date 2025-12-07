Imports MySql.Data.MySqlClient

Public Class AddUsersForm

    Private Sub AddUsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadUsers()
    End Sub
    Private Sub SetupListView()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.MultiSelect = False

        ListView1.Columns.Clear()
        ListView1.Columns.Add("ID", 60)
        ListView1.Columns.Add("Username", 120)
        ListView1.Columns.Add("Firstname", 150)
        ListView1.Columns.Add("Lastname", 150)
        ListView1.Columns.Add("Password", 120)
    End Sub

    Private Sub LoadUsers()
        ListView1.Items.Clear()

        Try
            openConn()

            Dim sql As String = "SELECT * FROM users"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim item As New ListViewItem(dr("user_id").ToString())
                        item.SubItems.Add(dr("username").ToString())
                        item.SubItems.Add(dr("firstname").ToString())
                        item.SubItems.Add(dr("lastname").ToString())
                        item.SubItems.Add(dr("password").ToString())
                        ListView1.Items.Add(item)
                    End While
                End Using
            End Using

            closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            closeConn()
        End Try
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If usernameTxt.Text = "" Or firstnameTxt.Text = "" Or lastnameTxt.Text = "" Or passwordTxt.Text = "" Then
            MsgBox("Please fill all fields!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            openConn()

            Dim sql As String = "INSERT INTO users (username, firstname, lastname, password) VALUES (@u, @f, @l, @p)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@u", usernameTxt.Text)
                cmd.Parameters.AddWithValue("@f", firstnameTxt.Text)
                cmd.Parameters.AddWithValue("@l", lastnameTxt.Text)
                cmd.Parameters.AddWithValue("@p", passwordTxt.Text)
                cmd.ExecuteNonQuery()
            End Using

            closeConn()
            MsgBox("User added successfully!")
            LoadUsers()
        Catch ex As Exception
            MsgBox(ex.Message)
            closeConn()
        End Try
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Select a user to update!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim id As Integer = ListView1.SelectedItems(0).Text

        Try
            openConn()

            Dim sql As String = "UPDATE users SET username=@u, firstname=@f, lastname=@l, password=@p WHERE user_id=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@u", usernameTxt.Text)
                cmd.Parameters.AddWithValue("@f", firstnameTxt.Text)
                cmd.Parameters.AddWithValue("@l", lastnameTxt.Text)
                cmd.Parameters.AddWithValue("@p", passwordTxt.Text)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            closeConn()
            MsgBox("User updated successfully!")
            LoadUsers()
        Catch ex As Exception
            MsgBox(ex.Message)
            closeConn()
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim item = ListView1.SelectedItems(0)
            usernameTxt.Text = item.SubItems(1).Text
            firstnameTxt.Text = item.SubItems(2).Text
            lastnameTxt.Text = item.SubItems(3).Text
            passwordTxt.Text = item.SubItems(4).Text
        End If
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
