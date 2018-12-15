Public Class FACTURACION
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub FACTURACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = Module1.cliente
        TextBox2.Text = Module1.fecha
        TextBox3.Text = Module1.nit
        TextBox4.Text = Module1.cantidad * Module1.precio

        DataGridView1.Rows.Add(Module1.cantidad, Module1.nombre, Module1.precio)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class