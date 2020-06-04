Public Class FuncionesconString
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txt3ro.TextChanged

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim cadena As String
        cadena = txtcadena.Text
        'Length retorna el numero de posiciones incluyendo los espacios
        txtlongitud.Text = cadena.Length
        txtUltcarac.Text = cadena.Substring(cadena.Length - 1, 1)
        txtPricarac.Text = cadena.Substring(1, 1)
        txt3ro.Text = cadena.Substring(2, 7)
        txtposB.Text = cadena.IndexOf("B", 8) + 1
        txtmayus.Text = cadena.ToUpper()
        txtmin.Text = cadena.ToLower()
        txtespacios.Text = cadena.Replace(" ", "")
    End Sub

    Private Sub FuncionesconString_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class