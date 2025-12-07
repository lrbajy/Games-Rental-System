Imports MySql.Data.MySqlClient

Public Class AdminCustomerOrders

    Private Sub AdminCustomerOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setupListView()
        loadCustomerOrders()
    End Sub

    Private Sub setupListView()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.Columns.Clear()

        ListView1.Columns.Add("Rent ID", 80)
        ListView1.Columns.Add("Customer", 120)
        ListView1.Columns.Add("Product", 150)
        ListView1.Columns.Add("Quantity", 80)
        ListView1.Columns.Add("Rent Date", 150)
    End Sub

    Private Sub loadCustomerOrders()
        Try
            ListView1.Items.Clear()
            openConn()

            Dim query As String =
                "SELECT rents.rent_id, users.username, products.product_name, 
                        rents.quantity, rents.rent_at 
                 FROM rents
                 INNER JOIN users ON rents.user_id = users.user_id
                 INNER JOIN products ON rents.product_id = products.product_id
                 ORDER BY rents.rent_id DESC"

            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim item As New ListViewItem(reader("rent_id").ToString())
                item.SubItems.Add(reader("username").ToString())
                item.SubItems.Add(reader("product_name").ToString())
                item.SubItems.Add(reader("quantity").ToString())
                item.SubItems.Add(reader("rent_at").ToString())

                ListView1.Items.Add(item)
            End While

            closeConn()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
    End Sub
End Class
