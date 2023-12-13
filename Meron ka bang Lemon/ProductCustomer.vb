Public Class ProductCustomer
    Public Property DataToReceive As ArrayList
    Public Property ProcessType As String
    Dim databaseUtil As New DatabaseUtil()
    Dim uiStyle As New UIStyle()
    Dim dynamicButton As Button
    Dim dynamicUI As New DynamicUI()

    Private Sub ProductCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim labelArray As New ArrayList
        uiStyle.PanelStyle(Panel1, "Add")
        uiStyle.LabelStyle(labelTitle, "title")
        labelTitle.Text = "Add Data"

        labelArray.Clear()
        labelArray.Add("Name")
        labelArray.Add("Description")
        labelArray.Add("Price")
        dynamicUI.CreateDynamicControls(Me, 3, labelArray)
        dynamicButton = DirectCast(Me.Controls("btnSaveProduct"), Button)
        If ProcessType.Equals("Update") Then
            For i As Integer = 1 To 3
                Dim dynamicTextBox As TextBox = DirectCast(Me.Controls("TextBox" & i.ToString()), TextBox)
                dynamicTextBox.Text = CStr(DataToReceive(i))
            Next
            dynamicButton.Text = "Update"
            uiStyle.PanelStyle(Panel1, "Update")
            labelTitle.Text = "Update Data"
        End If
        uiStyle.ButtonStyle(dynamicButton)
        AddHandler dynamicButton.Click, AddressOf dynamicButton_Click
        uiStyle.LabelCenter(labelTitle, Panel1)
    End Sub

    Private Sub dynamicButton_Click(sender As Object, e As EventArgs)
        If dynamicButton.Text.Equals("Add") Then

            databaseUtil.Query("INSERT INTO MyTable (Name, Desc, Price) VALUES('chakie', 'Chakay Kikay', 2500);",
                               "SELECT * FROM MyTable", Products.DataGridView1, "Added")
            Me.Close()
        End If
        If dynamicButton.Text.Equals("Update") Then

            databaseUtil.Query("UPDATE MyTable SET Name = 'NewName', Desc = 'NewDescription', Price = 3000 WHERE ID = 1;",
                               "SELECT * FROM MyTable", Products.DataGridView1, "Updated")
            Me.Close()
        End If
    End Sub

End Class