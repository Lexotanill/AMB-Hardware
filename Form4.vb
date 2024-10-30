Imports MySql.Data.MySqlClient

Public Class Form4
    Dim conect As New MySqlConnection("Server=localhost;Database=reparaciones;Uid=root;Pwd=;")

    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarReparaciones()
    End Sub

    Private Sub MostrarReparaciones()
        Dim query As String = "SELECT * FROM Reparaciones"
        Dim dt As New DataTable()

        Using adapter As New MySqlDataAdapter(query, conect)
            Try
                adapter.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al leer las reparaciones: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
