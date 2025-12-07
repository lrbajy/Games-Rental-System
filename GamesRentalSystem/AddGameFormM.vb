Imports MySql.Data.MySqlClient

Public Class AddGameFormM

    Private Sub AddGameFormM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadGames()
    End Sub

    Private Sub SetupListView()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.MultiSelect = False

        ListView1.Columns.Clear()
        ListView1.Columns.Add("ID", 80)
        ListView1.Columns.Add("Product Name", 150)
        ListView1.Columns.Add("Price", 80)
        ListView1.Columns.Add("Stock", 80)
    End Sub

    Private Sub LoadGames()
        ListView1.Items.Clear()

        Try
            openConn()

            Dim sql As String = "SELECT * FROM products"
            Using cmd As New MySqlCommand(sql, conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim item As New ListViewItem(dr("product_id").ToString())
                        item.SubItems.Add(dr("product_name").ToString())
                        item.SubItems.Add(dr("price").ToString())
                        item.SubItems.Add(dr("stock").ToString())
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
        Try
            If productnameTxt.Text = "" Or priceTxt.Text = "" Or stockTxt.Text = "" Then
                MsgBox("Please fill all fields!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            openConn()

            Dim sql As String = "INSERT INTO products (product_name, price, stock) VALUES (@name, @price, @stock)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", productnameTxt.Text)
                cmd.Parameters.AddWithValue("@price", priceTxt.Text)
                cmd.Parameters.AddWithValue("@stock", stockTxt.Text)
                cmd.ExecuteNonQuery()
            End Using

            closeConn()
            MsgBox("Game added successfully!")
            LoadGames()
        Catch ex As Exception
            MsgBox(ex.Message)
            closeConn()
        End Try
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Select a game to update!")
            Exit Sub
        End If

        Dim id As String = ListView1.SelectedItems(0).Text

        Try
            If productnameTxt.Text = "" Or priceTxt.Text = "" Or stockTxt.Text = "" Then
                MsgBox("Please fill all fields!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            openConn()

            Dim sql As String = "UPDATE products SET product_name=@name, price=@price, stock=@stock WHERE product_id=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", productnameTxt.Text)
                cmd.Parameters.AddWithValue("@price", priceTxt.Text)
                cmd.Parameters.AddWithValue("@stock", stockTxt.Text)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            closeConn()
            MsgBox("Game updated successfully!")
            LoadGames()
        Catch ex As Exception
            MsgBox(ex.Message)
            closeConn()
        End Try
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim item = ListView1.SelectedItems(0)
            productnameTxt.Text = item.SubItems(1).Text
            priceTxt.Text = item.SubItems(2).Text
            stockTxt.Text = item.SubItems(3).Text
        End If
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
    End Sub

End Class
