Public Class Form1
    Dim myArrayList As New ArrayList()
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myArrayList.Add(Products)
        myArrayList.Add(Customers)
        myArrayList.Add(Orders)
        myArrayList.Add(OrderList)
        myArrayList.Add(Tasks)
        myArrayList.Add(Reports)
        Label1.Text = "P R O D U C T S"
        Label1.Location = New Point((Panel1.Width - Label1.Width) \ 2, (Panel1.Height - Label1.Height) \ 2)
        loadForm(Products)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Panel2.BackColor = ColorTranslator.FromHtml("#FF90BC")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "P R O D U C T S"
        openForm(Products)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        openForm(OrderList)
        Label1.Text = "O R D E R  L I S T"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        openForm(Tasks)
        Label1.Text = "T A S K S"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        openForm(Reports)
        Label1.Text = "R E P O R T S"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openForm(Customers)
        Label1.Text = "C U S T O M E R S"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openForm(Orders)
        Label1.Text = "O R D E R S"
    End Sub

    Private Sub openForm(ByVal myForm As Form)
        Panel3.Controls.Clear()
        CloseForm(myForm)
        With myForm
            .TopLevel = False
            Panel3.Controls.Add(myForm)

            .BringToFront()

            .Anchor = AnchorStyles.Bottom
            .Anchor = AnchorStyles.Top
            .Anchor = AnchorStyles.Left
            .Anchor = AnchorStyles.Right
            Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub loadForm(ByVal myForm As Form)

        Panel3.Controls.Clear()
        With myForm
            .TopLevel = False
            Panel3.Controls.Add(myForm)

            .BringToFront()

            .Anchor = AnchorStyles.Bottom
            .Anchor = AnchorStyles.Top
            .Anchor = AnchorStyles.Left
            .Anchor = AnchorStyles.Right
            Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub CloseForm(ByVal myForm As Form)
        For Each item In myArrayList
            If item.Equals(myForm) Then
                Continue For
            End If
            item.Close()
        Next

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
