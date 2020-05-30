Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtValor1.Clear()
        txtValor2.Clear()
        txtResultado.Clear()
        checkSuma.Checked = False
        checkResta.Checked = False
        checkDiv.Checked = False
        checkMult.Checked = False
        checkRaiz.Checked = False
        checkPotencia.Checked = False
    End Sub

    Private Sub checkSuma_Click(sender As Object, e As EventArgs) Handles checkSuma.Click
        txtResultado.Text = Val(txtValor1.Text) + Val(txtValor2.Text)
        checkResta.Checked = False
        checkDiv.Checked = False
        checkMult.Checked = False
        checkRaiz.Checked = False
        checkPotencia.Checked = False
        If txtValor1.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkSuma.Checked = False
        ElseIf Not IsNumeric(txtValor1.text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor1.Text = ""
            checkSuma.Checked = False
        End If
        If txtValor2.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkSuma.Checked = False
        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor2.Text = ""
            checkSuma.Checked = False
        End If
    End Sub

    Private Sub checkResta_Click(sender As Object, e As EventArgs) Handles checkResta.Click
        txtResultado.Text = Val(txtValor1.Text) - Val(txtValor2.Text)
        checkSuma.Checked = False
        checkDiv.Checked = False
        checkMult.Checked = False
        checkRaiz.Checked = False
        checkPotencia.Checked = False
        If txtValor1.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkResta.Checked = False
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor1.Text = ""
            checkResta.Checked = False
        End If
        If txtValor2.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkResta.Checked = False
        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor2.Text = ""
            checkResta.Checked = False
        End If
    End Sub

    Private Sub checkDiv_Click(sender As Object, e As EventArgs) Handles checkDiv.Click
        If txtValor2.Text = 0 Then
            txtResultado.Text = "SYNTAX ERROR"
        ElseIf txtValor2.Text <> 0 Then
            txtResultado.Text = Val(txtValor1.Text) / Val(txtValor2.Text)
        End If
        checkSuma.Checked = False
        checkResta.Checked = False
        checkMult.Checked = False
        checkRaiz.Checked = False
        checkPotencia.Checked = False
        If txtValor1.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkDiv.Checked = False
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor1.Text = ""
            checkDiv.Checked = False
        End If
        If txtValor2.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkDiv.Checked = False
        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor2.Text = ""
            checkDiv.Checked = False
        End If
    End Sub

    Private Sub checkMult_Click(sender As Object, e As EventArgs) Handles checkMult.Click
        txtResultado.Text = Val(txtValor1.Text) * Val(txtValor2.Text)
        checkSuma.Checked = False
        checkResta.Checked = False
        checkDiv.Checked = False
        checkRaiz.Checked = False
        checkPotencia.Checked = False
        If txtValor1.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkMult.Checked = False
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor1.Text = ""
            checkMult.Checked = False
        End If
        If txtValor2.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkMult.Checked = False
        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor2.Text = ""
            checkMult.Checked = False
        End If
    End Sub

    Private Sub checkRaiz_Click(sender As Object, e As EventArgs) Handles checkRaiz.Click
        txtResultado.Text = Math.Sqrt(txtValor1.Text)
        checkSuma.Checked = False
        checkResta.Checked = False
        checkDiv.Checked = False
        checkMult.Checked = False
        checkPotencia.Checked = False
        If txtValor1.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkRaiz.Checked = False
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor1.Text = ""
            checkRaiz.Checked = False
        End If
    End Sub

    Private Sub checkPotencia_Click(sender As Object, e As EventArgs) Handles checkPotencia.Click
        txtResultado.Text = Math.Pow(txtValor1.Text, txtValor2.Text)
        checkSuma.Checked = False
        checkResta.Checked = False
        checkDiv.Checked = False
        checkMult.Checked = False
        checkRaiz.Checked = False
        If txtValor1.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkPotencia.Checked = False
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor1.Text = ""
            checkPotencia.Checked = False
        End If
        If txtValor2.Text = "" Then
            MsgBox("Ingrese un número", vbInformation)
            checkPotencia.Checked = False
        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor2.Text = ""
            checkPotencia.Checked = False
        End If
    End Sub
End Class
