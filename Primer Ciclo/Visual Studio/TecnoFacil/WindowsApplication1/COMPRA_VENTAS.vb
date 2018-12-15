Public Class COMPRA_VENTAS
    Private Sub COMPRA_VENTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TECNOFACILDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.TECNOFACILDataSet.Productos)

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TECNOFACILDataSet)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.nombre = NombreComboBox.Text
        Module1.precio = ComboBox1.Text
        Module1.cantidad = TextBox2.Text
        Module1.cliente = TextBox3.Text
        Module1.nit = TextBox4.Text
        Module1.fecha = TextBox5.Text
        PRODUCTOS.Hide()
        Me.Hide()
        FACTURACION.Show()

    End Sub
End Class