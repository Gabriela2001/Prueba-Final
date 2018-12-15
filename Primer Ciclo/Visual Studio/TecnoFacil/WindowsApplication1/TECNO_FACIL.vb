Public Class TECNO_FACIL
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PRODUCTOS.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        COMPRA_VENTAS.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FACTURACION.Show()
        Me.Hide()
    End Sub
End Class