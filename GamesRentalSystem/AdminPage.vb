Imports MySql.Data.MySqlClient

Public Class AdminPage
    Private Sub BGameBtn_Click(sender As Object, e As EventArgs) Handles BGameBtn.Click
        BGameBtn.Text = "| Browse Game"
        AddGameBtn.Text = "Add Game"
        UsersBtn.Text = "User"
        Label7.Text = "Customer Rents"
        AddUsersForm.Hide()
        AdminCustomerOrders.Hide()
        AddGameFormM.Hide()

    End Sub

    Private Sub AddGameBtn_Click(sender As Object, e As EventArgs) Handles AddGameBtn.Click
        BGameBtn.Text = "Browse Game"
        AddGameBtn.Text = "| Add Game"
        UsersBtn.Text = "User"
        Label7.Text = "Customer Rents"
        AddGameFormM.Show()
        AddUsersForm.Hide()
        AdminCustomerOrders.Hide()



    End Sub

    Private Sub UsersBtn_Click(sender As Object, e As EventArgs) Handles UsersBtn.Click
        AddGameBtn.Text = "Add Game"
        UsersBtn.Text = "| User"
        BGameBtn.Text = "Browse Game"
        Label7.Text = "Customer Rents"
        AddUsersForm.Show()
        AddGameFormM.Hide()
        AdminCustomerOrders.Hide()


    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        AddGameFormM.Hide()
        AdminCustomerOrders.Hide()
        AddUsersForm.Hide()

        LoginForm.Show()
    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        AdminCustomerOrders.Show()
        AddGameFormM.Hide()
        AddUsersForm.Hide()
        Label7.Text = "| Customer Rents"
        BGameBtn.Text = "Browse Game"
        UsersBtn.Text = "User"
        AddGameBtn.Text = "Add Game"

    End Sub

    Private Sub add_game_panel_Paint(sender As Object, e As PaintEventArgs) Handles add_game_panel.Paint

    End Sub
End Class