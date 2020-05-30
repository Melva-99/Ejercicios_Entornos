Imports System.ComponentModel

Public Class Form2
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        'Try Catch
        'ValidateChildren boton
        'validating cajas de texto
        Try
            'si las casillas estan vacias
            If Me.ValidateChildren And txtProducto.Text <> String.Empty And Val(txtPrecio.Text) <> String.Empty And Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
                MessageBox.Show("Producto Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidation.SetError(sender, "")
        Else
            Me.ErrorValidation.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidation.SetError(sender, "")
        Else
            Me.ErrorValidation.SetError(sender, "Ingrese un precio")
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
            Me.ErrorValidation.SetError(sender, "")
        Else
            Me.ErrorValidation.SetError(sender, "Ingrese un numero entero")
        End If
    End Sub

    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged

    End Sub

    Private Sub txtProducto_MouseHover(sender As Object, e As EventArgs) Handles txtProducto.MouseHover
        ToolTip1.SetToolTip(txtProducto, "Ingrese un producto")
        ToolTip1.ToolTipTitle = "Producto"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info

    End Sub
    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        ToolTip1.SetToolTip(txtCantidad, "Ingrese una cantidad")
        ToolTip1.ToolTipTitle = "Cantidad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        ToolTip1.SetToolTip(txtPrecio, "Ingrese un precio")
        ToolTip1.ToolTipTitle = "Precio"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class