<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(563, 310)
        Me.DataGridView1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDeleteProduct)
        Me.Panel1.Controls.Add(Me.btnAddProduct)
        Me.Panel1.Controls.Add(Me.btnUpdateProduct)
        Me.Panel1.Location = New System.Drawing.Point(34, 337)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 34)
        Me.Panel1.TabIndex = 6
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteProduct.Location = New System.Drawing.Point(464, 0)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(75, 12)
        Me.btnDeleteProduct.TabIndex = 8
        Me.btnDeleteProduct.Text = "Delete"
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(0, 0)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnAddProduct.TabIndex = 7
        Me.btnAddProduct.Text = "Add"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.Location = New System.Drawing.Point(219, 0)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateProduct.TabIndex = 6
        Me.btnUpdateProduct.Text = "Update"
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 374)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Products"
        Me.Text = "Products"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnUpdateProduct As Button
End Class
