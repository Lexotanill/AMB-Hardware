Imports MySql.Data.MySqlClient

Public Class Form3
    Dim conect As New MySqlConnection("Server=localhost;Database=reparaciones;Uid=root;Pwd=;")

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String = txtNombre.Text
        Dim telefono As String = txtTelefono.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim fecha As Date = dtpFecha.Value
        Dim estado As String = txtEstado.Text

        Dim query As String = "INSERT INTO Reparaciones (NombreCliente, Telefono, DescripcionProblema, FechaRecepcion, Estado) VALUES (@nombre, @telefono, @descripcion, @fecha, @estado)"
        Using command As New MySqlCommand(query, conect)
            command.Parameters.AddWithValue("@nombre", nombre)
            command.Parameters.AddWithValue("@telefono", telefono)
            command.Parameters.AddWithValue("@descripcion", descripcion)
            command.Parameters.AddWithValue("@fecha", fecha)
            command.Parameters.AddWithValue("@estado", estado)

            Try
                conect.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Reparación insertada correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error al agregar la reparación: " & ex.Message)
            Finally
                conect.Close()
            End Try
        End Using
    End Sub
End Class
