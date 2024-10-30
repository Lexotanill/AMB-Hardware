<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        txtNombre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTelefono = New TextBox()
        txtEstado = New TextBox()
        txtDescripcion = New RichTextBox()
        dtpFecha = New DateTimePicker()
        Label5 = New Label()
        btnGuardar = New Button()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(54, 47)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 15)
        Label1.TabIndex = 1
        Label1.Text = "Nombre Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(255, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 2
        Label2.Text = "Telefono"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 3
        Label3.Text = "Descripción"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(430, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 4
        Label4.Text = "Estado"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(255, 47)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 5
        ' 
        ' txtEstado
        ' 
        txtEstado.Location = New Point(430, 47)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(100, 23)
        txtEstado.TabIndex = 6
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(54, 120)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(345, 165)
        txtDescripcion.TabIndex = 7
        txtDescripcion.Text = ""
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Location = New Point(430, 120)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(231, 23)
        dtpFecha.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(430, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 15)
        Label5.TabIndex = 9
        Label5.Text = "Fecha de Recepción"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(430, 262)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(735, 358)
        Controls.Add(btnGuardar)
        Controls.Add(Label5)
        Controls.Add(dtpFecha)
        Controls.Add(txtDescripcion)
        Controls.Add(txtEstado)
        Controls.Add(txtTelefono)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNombre)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtDescripcion As RichTextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGuardar As Button
End Class
