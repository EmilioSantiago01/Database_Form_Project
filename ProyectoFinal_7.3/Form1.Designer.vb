<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_IDEmpleado = New System.Windows.Forms.Label()
        Me.txt_IDEmpleado = New System.Windows.Forms.TextBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.lbl_FechadeNacimiento = New System.Windows.Forms.Label()
        Me.DTP_FechadeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lbl_GradoObtenido = New System.Windows.Forms.Label()
        Me.txt_GradoObtenido = New System.Windows.Forms.TextBox()
        Me.lbl_PuestoaOcupar = New System.Windows.Forms.Label()
        Me.txt_PuestoaOcupar = New System.Windows.Forms.TextBox()
        Me.lbl_TasaSalarial = New System.Windows.Forms.Label()
        Me.txt_TasaSalarial = New System.Windows.Forms.TextBox()
        Me.lbl_FechadeContrato = New System.Windows.Forms.Label()
        Me.DTP_FechadeContrato = New System.Windows.Forms.DateTimePicker()
        Me.btn_GuardarDatos = New System.Windows.Forms.Button()
        Me.btn_SiguientePag = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_IDEmpleado
        '
        Me.lbl_IDEmpleado.AutoSize = True
        Me.lbl_IDEmpleado.Location = New System.Drawing.Point(29, 59)
        Me.lbl_IDEmpleado.Name = "lbl_IDEmpleado"
        Me.lbl_IDEmpleado.Size = New System.Drawing.Size(86, 16)
        Me.lbl_IDEmpleado.TabIndex = 0
        Me.lbl_IDEmpleado.Text = "ID Empleado"
        '
        'txt_IDEmpleado
        '
        Me.txt_IDEmpleado.Location = New System.Drawing.Point(131, 53)
        Me.txt_IDEmpleado.Name = "txt_IDEmpleado"
        Me.txt_IDEmpleado.Size = New System.Drawing.Size(100, 22)
        Me.txt_IDEmpleado.TabIndex = 1
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(29, 105)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Nombre.TabIndex = 2
        Me.lbl_Nombre.Text = "Nombre"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(131, 99)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 22)
        Me.txt_Nombre.TabIndex = 3
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Location = New System.Drawing.Point(29, 149)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(57, 16)
        Me.lbl_Apellido.TabIndex = 4
        Me.lbl_Apellido.Text = "Apellido"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(131, 149)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(100, 22)
        Me.txt_Apellido.TabIndex = 5
        '
        'lbl_FechadeNacimiento
        '
        Me.lbl_FechadeNacimiento.AutoSize = True
        Me.lbl_FechadeNacimiento.Location = New System.Drawing.Point(29, 196)
        Me.lbl_FechadeNacimiento.Name = "lbl_FechadeNacimiento"
        Me.lbl_FechadeNacimiento.Size = New System.Drawing.Size(135, 16)
        Me.lbl_FechadeNacimiento.TabIndex = 6
        Me.lbl_FechadeNacimiento.Text = "Fecha de Nacimiento"
        '
        'DTP_FechadeNacimiento
        '
        Me.DTP_FechadeNacimiento.Location = New System.Drawing.Point(186, 191)
        Me.DTP_FechadeNacimiento.Name = "DTP_FechadeNacimiento"
        Me.DTP_FechadeNacimiento.Size = New System.Drawing.Size(200, 22)
        Me.DTP_FechadeNacimiento.TabIndex = 7
        '
        'lbl_GradoObtenido
        '
        Me.lbl_GradoObtenido.AutoSize = True
        Me.lbl_GradoObtenido.Location = New System.Drawing.Point(29, 239)
        Me.lbl_GradoObtenido.Name = "lbl_GradoObtenido"
        Me.lbl_GradoObtenido.Size = New System.Drawing.Size(103, 16)
        Me.lbl_GradoObtenido.TabIndex = 8
        Me.lbl_GradoObtenido.Text = "Grado Obtenido"
        '
        'txt_GradoObtenido
        '
        Me.txt_GradoObtenido.Location = New System.Drawing.Point(186, 236)
        Me.txt_GradoObtenido.Name = "txt_GradoObtenido"
        Me.txt_GradoObtenido.Size = New System.Drawing.Size(112, 22)
        Me.txt_GradoObtenido.TabIndex = 9
        '
        'lbl_PuestoaOcupar
        '
        Me.lbl_PuestoaOcupar.AutoSize = True
        Me.lbl_PuestoaOcupar.Location = New System.Drawing.Point(29, 284)
        Me.lbl_PuestoaOcupar.Name = "lbl_PuestoaOcupar"
        Me.lbl_PuestoaOcupar.Size = New System.Drawing.Size(107, 16)
        Me.lbl_PuestoaOcupar.TabIndex = 10
        Me.lbl_PuestoaOcupar.Text = "Puesto a Ocupar"
        '
        'txt_PuestoaOcupar
        '
        Me.txt_PuestoaOcupar.Location = New System.Drawing.Point(186, 278)
        Me.txt_PuestoaOcupar.Name = "txt_PuestoaOcupar"
        Me.txt_PuestoaOcupar.Size = New System.Drawing.Size(112, 22)
        Me.txt_PuestoaOcupar.TabIndex = 11
        '
        'lbl_TasaSalarial
        '
        Me.lbl_TasaSalarial.AutoSize = True
        Me.lbl_TasaSalarial.Location = New System.Drawing.Point(29, 329)
        Me.lbl_TasaSalarial.Name = "lbl_TasaSalarial"
        Me.lbl_TasaSalarial.Size = New System.Drawing.Size(88, 16)
        Me.lbl_TasaSalarial.TabIndex = 12
        Me.lbl_TasaSalarial.Text = "Tasa Salarial"
        '
        'txt_TasaSalarial
        '
        Me.txt_TasaSalarial.Location = New System.Drawing.Point(186, 329)
        Me.txt_TasaSalarial.Name = "txt_TasaSalarial"
        Me.txt_TasaSalarial.Size = New System.Drawing.Size(112, 22)
        Me.txt_TasaSalarial.TabIndex = 13
        '
        'lbl_FechadeContrato
        '
        Me.lbl_FechadeContrato.AutoSize = True
        Me.lbl_FechadeContrato.Location = New System.Drawing.Point(32, 375)
        Me.lbl_FechadeContrato.Name = "lbl_FechadeContrato"
        Me.lbl_FechadeContrato.Size = New System.Drawing.Size(117, 16)
        Me.lbl_FechadeContrato.TabIndex = 14
        Me.lbl_FechadeContrato.Text = "Fecha de Contrato"
        '
        'DTP_FechadeContrato
        '
        Me.DTP_FechadeContrato.Location = New System.Drawing.Point(186, 375)
        Me.DTP_FechadeContrato.Name = "DTP_FechadeContrato"
        Me.DTP_FechadeContrato.Size = New System.Drawing.Size(200, 22)
        Me.DTP_FechadeContrato.TabIndex = 15
        '
        'btn_GuardarDatos
        '
        Me.btn_GuardarDatos.Location = New System.Drawing.Point(485, 329)
        Me.btn_GuardarDatos.Name = "btn_GuardarDatos"
        Me.btn_GuardarDatos.Size = New System.Drawing.Size(145, 37)
        Me.btn_GuardarDatos.TabIndex = 16
        Me.btn_GuardarDatos.Text = "Guardar Datos"
        Me.btn_GuardarDatos.UseVisualStyleBackColor = True
        '
        'btn_SiguientePag
        '
        Me.btn_SiguientePag.Location = New System.Drawing.Point(650, 330)
        Me.btn_SiguientePag.Name = "btn_SiguientePag"
        Me.btn_SiguientePag.Size = New System.Drawing.Size(138, 36)
        Me.btn_SiguientePag.TabIndex = 17
        Me.btn_SiguientePag.Text = "Siguiente Pagina"
        Me.btn_SiguientePag.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(485, 393)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(145, 32)
        Me.btn_Close.TabIndex = 18
        Me.btn_Close.Text = "CLOSE"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_SiguientePag)
        Me.Controls.Add(Me.btn_GuardarDatos)
        Me.Controls.Add(Me.DTP_FechadeContrato)
        Me.Controls.Add(Me.lbl_FechadeContrato)
        Me.Controls.Add(Me.txt_TasaSalarial)
        Me.Controls.Add(Me.lbl_TasaSalarial)
        Me.Controls.Add(Me.txt_PuestoaOcupar)
        Me.Controls.Add(Me.lbl_PuestoaOcupar)
        Me.Controls.Add(Me.txt_GradoObtenido)
        Me.Controls.Add(Me.lbl_GradoObtenido)
        Me.Controls.Add(Me.DTP_FechadeNacimiento)
        Me.Controls.Add(Me.lbl_FechadeNacimiento)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.lbl_Apellido)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.txt_IDEmpleado)
        Me.Controls.Add(Me.lbl_IDEmpleado)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_IDEmpleado As Label
    Friend WithEvents txt_IDEmpleado As TextBox
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents lbl_Apellido As Label
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents lbl_FechadeNacimiento As Label
    Friend WithEvents DTP_FechadeNacimiento As DateTimePicker
    Friend WithEvents lbl_GradoObtenido As Label
    Friend WithEvents txt_GradoObtenido As TextBox
    Friend WithEvents lbl_PuestoaOcupar As Label
    Friend WithEvents txt_PuestoaOcupar As TextBox
    Friend WithEvents lbl_TasaSalarial As Label
    Friend WithEvents txt_TasaSalarial As TextBox
    Friend WithEvents lbl_FechadeContrato As Label
    Friend WithEvents DTP_FechadeContrato As DateTimePicker
    Friend WithEvents btn_GuardarDatos As Button
    Friend WithEvents btn_SiguientePag As Button
    Friend WithEvents btn_Close As Button
End Class
