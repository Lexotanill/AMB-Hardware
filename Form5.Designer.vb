<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtID = New TextBox()
        txtNombre = New TextBox()
        txtTelefono = New TextBox()
        txtEstado = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtDescripcion = New RichTextBox()
        Label5 = New Label()
        btnActualizar = New Button()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(37, 34)
        txtID.Name = "txtID"
        txtID.Size = New Size(100, 23)
        txtID.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(188, 34)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(337, 34)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 2
        ' 
        ' txtEstado
        ' 
        txtEstado.Location = New Point(475, 34)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(100, 23)
        txtEstado.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 4
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(188, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 5
        Label2.Text = "Nombre Cliente"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(337, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 6
        Label3.Text = "Telefono"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(475, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 7
        Label4.Text = "Estado"
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(37, 112)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(538, 212)
        txtDescripcion.TabIndex = 8
        txtDescripcion.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 9
        Label5.Text = "Descripcion"
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(259, 340)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(92, 32)
        btnActualizar.TabIndex = 10
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(644, 393)
        Controls.Add(btnActualizar)
        Controls.Add(Label5)
        Controls.Add(txtDescripcion)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtEstado)
        Controls.Add(txtTelefono)
        Controls.Add(txtNombre)
        Controls.Add(txtID)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnActualizar As Button
End Class
