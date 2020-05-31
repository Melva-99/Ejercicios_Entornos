Public Class Form1
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim valor As Integer
        valor = InputBox("Ingrese número", "Ingreso")
        txtIngresar.Text = valor
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim suma, resta, multiplicacion, valor As Integer
        Dim division As Double
        valor = Val(txtIngresar.Text)
        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            multiplicacion = valor * i
            division = Format((valor / i).ToString, 2)
            cmbSuma.Items.Add(valor & " + " & i & "=" & suma)
            cbmResta.Items.Add(valor & " - " & i & "=" & resta)
            cbmMult.Items.Add(valor & " x " & i & "=" & multiplicacion)
            cbmDiv.Items.Add(valor & " / " & i & "=" & division)
        Next


    End Sub
End Class
