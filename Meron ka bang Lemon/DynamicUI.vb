Public Class DynamicUI
    Dim uiStyle As New UIStyle()
    Public Sub CreateDynamicControls(ByVal myForm As Form, ByVal noControls As Integer, ByVal labelArray As ArrayList)
        Dim startX As Integer = 0
        Dim startY As Integer = 44
        myForm.Height = 44
        For i As Integer = 1 To noControls
            Dim label As New Label()
            label.Name = "Label" & i
            label.Text = labelArray(i - 1)
            label.Location = New Point(40, startY)
            label.Size = New Size(myForm.Width - 95, 34)
            uiStyle.LabelStyle(label)
            myForm.Controls.Add(label)
            startY += 34
            Dim textBox As New TextBox()
            textBox.Multiline = True
            textBox.Name = "TextBox" & i
            textBox.Size = New Size(myForm.Width - 95, 34)
            textBox.Location = New Point(40, startY)
            uiStyle.TextBoxStyle(textBox)
            myForm.Controls.Add(textBox)
            startY += 34
        Next
        myForm.Height += (68 * noControls) + 10
        Dim button As New Button()
        button.Size = New Size(myForm.Width - 95, 34)
        button.Name = "btnSaveProduct"
        button.Text = "Add"
        button.Location = New Point(40, myForm.Height)
        myForm.Height += 87
        myForm.Controls.Add(button)
    End Sub

End Class
