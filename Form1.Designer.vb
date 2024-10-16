<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        nombreTxt = New TextBox()
        apellidoTxt = New TextBox()
        telefonoTxt = New TextBox()
        direccionTxt = New TextBox()
        emailTxt = New TextBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        equipoTxt = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label12 = New Label()
        ingresoDate = New DateTimePicker()
        descripcionTxt = New RichTextBox()
        enviarPedidoBtn = New Button()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft JhengHei", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(14, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 20)
        Label1.TabIndex = 0
        Label1.Text = "INSERCIÓN DE CLIENTE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft JhengHei", 8.25F)
        Label2.Location = New Point(29, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft JhengHei", 9.0F)
        Label4.Location = New Point(29, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 16)
        Label4.TabIndex = 2
        Label4.Text = "Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft JhengHei", 8.25F)
        Label3.Location = New Point(200, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 3
        Label3.Text = "Telefono"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft JhengHei", 9.0F)
        Label5.Location = New Point(200, 108)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 16)
        Label5.TabIndex = 4
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft JhengHei", 8.25F)
        Label6.Location = New Point(392, 46)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 4
        Label6.Text = "Dirección"
        ' 
        ' nombreTxt
        ' 
        nombreTxt.Font = New Font("Microsoft JhengHei", 9.0F)
        nombreTxt.Location = New Point(29, 68)
        nombreTxt.Name = "nombreTxt"
        nombreTxt.Size = New Size(139, 23)
        nombreTxt.TabIndex = 5
        ' 
        ' apellidoTxt
        ' 
        apellidoTxt.Font = New Font("Microsoft JhengHei", 9.0F)
        apellidoTxt.Location = New Point(29, 129)
        apellidoTxt.Name = "apellidoTxt"
        apellidoTxt.Size = New Size(139, 23)
        apellidoTxt.TabIndex = 6
        ' 
        ' telefonoTxt
        ' 
        telefonoTxt.Font = New Font("Microsoft JhengHei", 9.0F)
        telefonoTxt.Location = New Point(200, 68)
        telefonoTxt.Name = "telefonoTxt"
        telefonoTxt.Size = New Size(178, 23)
        telefonoTxt.TabIndex = 7
        ' 
        ' direccionTxt
        ' 
        direccionTxt.Font = New Font("Microsoft JhengHei", 9.0F)
        direccionTxt.Location = New Point(392, 68)
        direccionTxt.Name = "direccionTxt"
        direccionTxt.Size = New Size(178, 23)
        direccionTxt.TabIndex = 8
        ' 
        ' emailTxt
        ' 
        emailTxt.Font = New Font("Microsoft JhengHei", 9.0F)
        emailTxt.Location = New Point(200, 129)
        emailTxt.Name = "emailTxt"
        emailTxt.Size = New Size(178, 23)
        emailTxt.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft JhengHei", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(14, 168)
        Label7.Name = "Label7"
        Label7.Size = New Size(188, 20)
        Label7.TabIndex = 10
        Label7.Text = "INSERCIÓN DE EQUIPO"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(600, 190)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(254, 222)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' equipoTxt
        ' 
        equipoTxt.Font = New Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        equipoTxt.Location = New Point(29, 212)
        equipoTxt.Name = "equipoTxt"
        equipoTxt.Size = New Size(182, 25)
        equipoTxt.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft JhengHei", 9.0F)
        Label9.Location = New Point(29, 247)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 16)
        Label9.TabIndex = 16
        Label9.Text = "Fecha de ingreso"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft JhengHei", 9.0F)
        Label10.Location = New Point(232, 190)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 16)
        Label10.TabIndex = 14
        Label10.Text = "Descripción"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft JhengHei", 9.0F)
        Label12.Location = New Point(29, 190)
        Label12.Name = "Label12"
        Label12.Size = New Size(48, 16)
        Label12.TabIndex = 12
        Label12.Text = "Equipo"
        ' 
        ' ingresoDate
        ' 
        ingresoDate.CalendarFont = New Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ingresoDate.Location = New Point(29, 269)
        ingresoDate.Name = "ingresoDate"
        ingresoDate.Size = New Size(182, 25)
        ingresoDate.TabIndex = 22
        ' 
        ' descripcionTxt
        ' 
        descripcionTxt.Font = New Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        descripcionTxt.Location = New Point(232, 212)
        descripcionTxt.Name = "descripcionTxt"
        descripcionTxt.Size = New Size(338, 82)
        descripcionTxt.TabIndex = 23
        descripcionTxt.Text = ""
        ' 
        ' enviarPedidoBtn
        ' 
        enviarPedidoBtn.Font = New Font("Microsoft JhengHei", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        enviarPedidoBtn.Location = New Point(343, 325)
        enviarPedidoBtn.Name = "enviarPedidoBtn"
        enviarPedidoBtn.Size = New Size(94, 36)
        enviarPedidoBtn.TabIndex = 24
        enviarPedidoBtn.Text = "Enviar"
        enviarPedidoBtn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft JhengHei", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(656, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(98, 30)
        Button1.TabIndex = 25
        Button1.Text = "Ver Equipos"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Microsoft JhengHei", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(656, 61)
        Button2.Name = "Button2"
        Button2.Size = New Size(98, 30)
        Button2.TabIndex = 25
        Button2.Text = "Ver Equipos"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(775, 375)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(enviarPedidoBtn)
        Controls.Add(descripcionTxt)
        Controls.Add(ingresoDate)
        Controls.Add(equipoTxt)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label12)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(emailTxt)
        Controls.Add(direccionTxt)
        Controls.Add(telefonoTxt)
        Controls.Add(apellidoTxt)
        Controls.Add(nombreTxt)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "ABM"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents apellidoTxt As TextBox
    Friend WithEvents telefonoTxt As TextBox
    Friend WithEvents direccionTxt As TextBox
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents equipoTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ingresoDate As DateTimePicker
    Friend WithEvents descripcionTxt As RichTextBox
    Friend WithEvents enviarPedidoBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
