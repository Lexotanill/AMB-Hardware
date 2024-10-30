<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        btnInsertar = New Button()
        btnVer = New Button()
        btnModificar = New Button()
        SuspendLayout()
        ' 
        ' btnInsertar
        ' 
        btnInsertar.Location = New Point(124, 142)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Size = New Size(75, 23)
        btnInsertar.TabIndex = 0
        btnInsertar.Text = "Insercion"
        btnInsertar.UseVisualStyleBackColor = True
        ' 
        ' btnVer
        ' 
        btnVer.Location = New Point(333, 142)
        btnVer.Name = "btnVer"
        btnVer.Size = New Size(75, 23)
        btnVer.TabIndex = 1
        btnVer.Text = "Ver"
        btnVer.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(546, 142)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 23)
        btnModificar.TabIndex = 2
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnModificar)
        Controls.Add(btnVer)
        Controls.Add(btnInsertar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnModificar As Button
End Class
