
Imports System.Data.Common
Imports System.Data.OleDb
Public Class Form1
    Dim conect As New OleDbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Romeo\abm-hardware.accdb"
            conect.Open()
            MsgBox("Conectado con la Base de Datos", vbInformation, "Aviso")

        Catch ex As Exception
            MsgBox("No se conecto la Base de Datos", vbCritical, "Aviso")
        End Try
    End Sub
    Private Sub Mostrar()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select * from clientes"
        oda = New OleDbDataAdapter(consulta, conect)
        ods.Tables.Add("clientes")
    End Sub

    Private Sub enviarPedidoBtn_Click(sender As Object, e As EventArgs) Handles enviarPedidoBtn.Click

    End Sub
End Class
