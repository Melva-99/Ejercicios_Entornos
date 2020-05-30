Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim itemId As Integer
        Dim itemNom As String

        itemId = cmblista.SelectedIndex
        itemNom = cmblista.SelectedItem.ToString

        Select Case itemId
            Case 0
                MsgBox(itemNom)
            Case 1
                MsgBox(itemNom)
            Case 2
                MsgBox(itemNom)
            Case 3
                MsgBox(itemNom)
            Case 4
                MsgBox(itemNom)
            Case 5
                MsgBox(itemNom)
            Case 6
                MsgBox(itemNom)
            Case Else
                MsgBox("Seleccione un valor correcto")
        End Select
    End Sub
End Class
