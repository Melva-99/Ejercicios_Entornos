Public Class AcumuladorContador
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim precio, total, totalPagar, orden As Integer

            orden = txtPedido.Text
            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el precio del platillo No." & i, "Precio del platillo")
                'Acumulador: guarda los valores ingrsados previamente
                totalPagar += precio
            Next
            total = totalPagar / orden
            txtPagar.Text = totalPagar
            txtIndividual.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPedido.Clear()
        txtPagar.Clear()
        txtIndividual.Clear()
    End Sub
End Class
