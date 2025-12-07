Imports MySql.Data.MySqlClient

Public Class UserAddRentForm

    Private Sub UserAddRentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setupListViews()
        loadAvailableProducts()
        loadUserRents()
    End Sub
    Private Sub setupListViews()
        ListView1.Columns.Clear()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.Columns.Add("Product ID", 90)
        ListView1.Columns.Add("Product Name", 150)
        ListView1.Columns.Add("Price", 80)
        ListView1.Columns.Add("Stock", 80)

        ListView2.Columns.Clear()
        ListView2.View = View.Details
        ListView2.FullRowSelect = True
        ListView2.Columns.Add("Rent ID", 80)
        ListView2.Columns.Add("Product Name", 150)
        ListView2.Columns.Add("Quantity", 80)
        ListView2.Columns.Add("Rent Date", 120)
    End Sub

    Private Sub loadAvailableProducts()
        Try
            ListView1.Items.Clear()
            openConn()

            Dim query As String = "SELECT * FROM products"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(reader("product_id").ToString())
                        item.SubItems.Add(reader("product_name").ToString())
                        item.SubItems.Add(reader("price").ToString())
                        item.SubItems.Add(reader("stock").ToString())
                        ListView1.Items.Add(item)
                    End While
                End Using
            End Using

            closeConn()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loadUserRents()
        Try
            ListView2.Items.Clear()
            openConn()

            Dim query As String =
                "SELECT rents.rent_id, products.product_name, rents.quantity, rents.rent_at 
                 FROM rents 
                 INNER JOIN products ON rents.product_id = products.product_id
                 WHERE rents.user_id=@uid"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", UserPage.currentUserId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(reader("rent_id").ToString())
                        item.SubItems.Add(reader("product_name").ToString())
                        item.SubItems.Add(reader("quantity").ToString())
                        item.SubItems.Add(reader("rent_at").ToString())
                        ListView2.Items.Add(item)
                    End While
                End Using
            End Using

            closeConn()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            productIdTxt.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Try
            If productIdTxt.Text = "" Or quantityTxt.Text = "" Then
                MsgBox("Please select a product and enter quantity.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            openConn()

            Dim query As String =
                "INSERT INTO rents(user_id, product_id, quantity) 
                 VALUES(@uid, @pid, @qty)"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", UserPage.currentUserId)
                cmd.Parameters.AddWithValue("@pid", productIdTxt.Text)
                cmd.Parameters.AddWithValue("@qty", quantityTxt.Text)
                cmd.ExecuteNonQuery()
            End Using

            closeConn()

            MsgBox("Rent added successfully!", MsgBoxStyle.Information)
            loadAvailableProducts()
            loadUserRents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
