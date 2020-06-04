Public Class Form1

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        'for, dowhile
        Dim departamentos, mascarillas As Integer

        departamentos = Val(txtDepto.Text)

        If departamentos > 18 Or departamentos < 0 Then
            MessageBox.Show("El numero de departamentos no puede ser mayor que 0 ni menor que 18 ", "Departamentos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDepto.Clear()
            txtDepto.Focus()
            Exit Sub
        End If

        For i = 1 To departamentos Step 1
            Do
                Try
                    mascarillas = InputBox("Ingrese la cantidad de mascarillas(Entre 1 - 10,000)" & i, ", Ingresar")
                    If mascarillas = vbAbort Then
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)

                    mascarillas = -1

                End Try

            Loop While (mascarillas < 0 Or mascarillas > 10000)
            cmbdepto.Items.Add(mascarillas)


        Next

    End Sub

    Private Sub btnEntrega_Click(sender As Object, e As EventArgs) Handles btnEntrega.Click
        Dim cantidadDepartamento, cantidadEntregada As Integer
        Dim idDepartamento As Integer

        cantidadDepartamento = cmbdepto.SelectedItem
        idDepartamento = cmbdepto.SelectedIndex

        'MsgBox("Numero de municipios: " & numeroMunicipios & "Cantidad asignada a departamentos: " & cantidadDepartamento & "ID departamento: " & idDepartamento)

        Select Case idDepartamento
            Case 0
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 8)
            Case 1
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 10)
            Case 2
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 21)
            Case 3
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 23)
            Case 4
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 12)
            Case 5
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 16)
            Case 6
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 19)
            Case 7
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 28)
            Case 8
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 6)
            Case 9
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 17)
            Case 10
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 4)
            Case 11
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 19)
            Case 12
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 28)
            Case 13
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 16)
            Case 14
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 23)
            Case 15
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 28)
            Case 16
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 9)
            Case 17
                cantidadEntregada = EntregaMascarillas(cantidadDepartamento, 11)
            Case Else
                MessageBox.Show("Error, consulte con el encargado", "Entrega de Municipios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
        txtStock.Text = cantidadEntregada
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbdepto.DropDownStyle = ComboBoxStyle.DropDownList
        txtDepto.Focus()
    End Sub

    Private Sub cmbdepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdepto.SelectedIndexChanged
        Dim idDepartamento As Integer
        idDepartamento = cmbdepto.SelectedIndex
        txtStock.Text = cmbdepto.SelectedItem
        Select Case idDepartamento
            Case 0
                txtmunicipios.Text = 8
            Case 1
                txtmunicipios.Text = 10
            Case 2
                txtmunicipios.Text = 21
            Case 3
                txtmunicipios.Text = 23
            Case 4
                txtmunicipios.Text = 12
            Case 5
                txtmunicipios.Text = 16
            Case 6
                txtmunicipios.Text = 19
            Case 7
                txtmunicipios.Text = 28
            Case 8
                txtmunicipios.Text = 6
            Case 9
                txtmunicipios.Text = 17
            Case 10
                txtmunicipios.Text = 4
            Case 11
                txtmunicipios.Text = 19
            Case 12
                txtmunicipios.Text = 28
            Case 13
                txtmunicipios.Text = 16
            Case 14
                txtmunicipios.Text = 23
            Case 15
                txtmunicipios.Text = 28
            Case 16
                txtmunicipios.Text = 9
            Case 17
                txtmunicipios.Text = 11
            Case Else
                MessageBox.Show("Error, consulte con el encargado", "Entrega de Municipios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Function entregaMascarillas(stock As Integer, cantidadMunicipios As Integer) As Integer
        Dim entregadas As Integer
        For i = 1 To cantidadMunicipios Step 1
            If (stock <= 0) Then
                MessageBox.Show("No quedan mascarillas en inventario. ", "Entrega de Mascarillas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return 0
            End If
            entregadas = InputBox("Ingrese la cantidad de mascarillas para este Municipio ", "Asignacion por Municipios")
            stock -= entregadas
            txtStock.Text = stock
        Next
        Return stock
    End Function

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
