Public Class Products
    Dim myArrayList As New ArrayList()
    Dim databaseHelper As New DatabaseUtil()
    Dim uiStyle As New UIStyle()
    Dim productsSelect As String = "SELECT * FROM MyTable"
    Dim sendArray As New ArrayList()

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myArrayList.Add(btnUpdateProduct)
        myArrayList.Add(btnAddProduct)
        myArrayList.Add(btnDeleteProduct)
        uiStyle.ButtonStyle(myArrayList)
        FormBorderStyle = FormBorderStyle.None
        'databaseHelper.CreateDatabaseAndTable()
        databaseHelper.Data_Load(productsSelect, DataGridView1)
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim pac As New ProductCustomer
        Try
            pac.ProcessType = "Add"
            pac.Show()
            databaseHelper.Data_Load(productsSelect, DataGridView1)
        Catch myerror As Exception
            MessageBox.Show("".Concat(myerror))
        End Try
    End Sub
    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        Dim pac As New ProductCustomer
        DefaultSelection()

        If sendArray.Count > 0 Then
            Try
                pac.ProcessType = "Update"
                pac.DataToReceive = sendArray
                pac.Show()
            Catch myerror As Exception
                MessageBox.Show("".Concat(myerror))
            End Try
        End If
    End Sub
    Sub DefaultSelection()
        sendArray.Clear()
        sendArray.Add(DataGridView1.CurrentRow.Cells(0).Value.ToString())
        sendArray.Add(DataGridView1.CurrentRow.Cells(1).Value.ToString())
        sendArray.Add(DataGridView1.CurrentRow.Cells(2).Value.ToString())
        sendArray.Add(DataGridView1.CurrentRow.Cells(3).Value.ToString())
    End Sub


End Class