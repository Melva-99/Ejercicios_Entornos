Public Class ValidarNumeros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Int16
        If txtNum.text = "" Then
            MsgBox("Ingrese un número", vbInformation)
        ElseIf Not IsNumeric(txtNum.text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtNum.text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtNum.text)
            If valor = 0 Then
                MsgBox("Número cero", vbInformation)
            ElseIf valor > 0 Then
                MsgBox("Número Positivo")
            ElseIf valor < 0 Then
                MsgBox("Número negativo")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged

    End Sub
End Class