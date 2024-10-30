Imports MySql.Data.MySqlClient

Public Class Form5
    Dim conect As New MySqlConnection("Server=localhost;Database=reparaciones;Uid=root;Pwd=;")

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim id As Integer = Integer.Parse(txtID.Text)
        Dim nombre As String = txtNombre.Text
        Dim telefono As String = txtTelefono.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim estado As String = txtEstado.Text

        Dim query As String = "UPDATE Reparaciones SET NombreCliente = @nombre, Telefono = @telefono, DescripcionProblema = @descripcion, Estado = @estado WHERE ID = @id"
        Using command As New MySqlCommand(query, conect)
            command.Parameters.AddWithValue("@nombre", nombre)
            command.Parameters.AddWithValue("@telefono", telefono)
            command.Parameters.AddWithValue("@descripcion", descripcion)
            command.Parameters.AddWithValue("@estado", estado)
            command.Parameters.AddWithValue("@id", id)

            Try
                conect.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Reparación actualizada correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error al modificar la reparación: " & ex.Message)
            Finally
                conect.Close()
            End Try
        End Using
    End Sub
End Class
