Public Class UIStyle
    Dim fStyle As String = "Microsoft YaHei UI"
    Dim generalFont As Font = New Font(fStyle, 12, FontStyle.Regular)
    Dim generalFontBold As Font = New Font(fStyle, 12, FontStyle.Bold)
    Dim generalFontTitle As Font = New Font(fStyle, 16.5, FontStyle.Bold)
    Sub TableStyle(ByVal myTable As DataGridView)
        myTable.EnableHeadersVisualStyles = False
        myTable.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8ACDD7")
        myTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        myTable.BackgroundColor = Color.White
        Dim headerFont As New Font(fStyle, 10, FontStyle.Bold)
        myTable.ColumnHeadersDefaultCellStyle.Font = headerFont
        myTable.CellBorderStyle = DataGridViewCellBorderStyle.None
        myTable.RowHeadersVisible = False
        myTable.EnableHeadersVisualStyles = False
        myTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Dim cellFont As New Font(fStyle, 10, FontStyle.Regular)
        myTable.DefaultCellStyle.Font = cellFont
        myTable.BorderStyle = BorderStyle.None
        myTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dim selectedCellStyle As New DataGridViewCellStyle()
        selectedCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FFC0D9")
        myTable.DefaultCellStyle.SelectionBackColor = selectedCellStyle.SelectionBackColor
        myTable.ReadOnly = True
        For Each column As DataGridViewColumn In myTable.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub
    Sub PanelStyle(ByVal panel As Panel, ByVal type As String)
        ColorCasing(panel, type)
    End Sub
    Sub ButtonStyle(ByVal buttonArray As ArrayList)
        For Each item In buttonArray
            item.Size = New Size(100, 34)
            item.Padding = New Padding(0)
            ButtonStyle(item)
        Next
    End Sub

    Sub ButtonStyle(ByVal button As Button)
        button.Font = generalFontBold
        button.FlatStyle = FlatStyle.Flat
        button.ForeColor = Color.White
        button.FlatAppearance.BorderSize = 0
        button.TextAlign = ContentAlignment.MiddleCenter
        ColorCasing(button, button.Text)
    End Sub
    Sub TextBoxStyle(ByVal textBoxArray As ArrayList)
        For Each item In textBoxArray
            TextBoxStyle(item)
        Next
    End Sub
    Sub TextBoxStyle(ByVal textBox As TextBox)
        textBox.Font = generalFont
    End Sub
    Sub LabelStyle(ByVal label As Label)
        label.Font = generalFontBold
        label.TextAlign = ContentAlignment.MiddleCenter
    End Sub
    Sub LabelStyle(ByVal label As Label, ByVal type As String)
        label.Font = generalFontTitle
        label.ForeColor = Color.White
        label.TextAlign = ContentAlignment.MiddleCenter
    End Sub
    Sub LabelCenter(ByVal label As Label, ByVal panel As Panel)
        Dim xCoordinate As Integer = (panel.Width - label.Width) \ 2
        Dim yCoordinate As Integer = (panel.Height - label.Height) \ 2
        label.Location = New Point(xCoordinate, yCoordinate)
    End Sub

    Sub ColorCasing(ByVal control As Control, ByVal type As String)
        Select Case type
            Case "Add"
                control.BackColor = ColorTranslator.FromHtml("#b4d8c4")
            Case "Update"
                control.BackColor = ColorTranslator.FromHtml("#6cb8f4")
            Case "Delete"
                control.BackColor = ColorTranslator.FromHtml("#fba7b6")
            Case Else
        End Select
    End Sub

End Class
