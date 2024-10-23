<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lbl_Habilidades = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.lbl_Beneficios = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.lbl_Certificaciones = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_GuardarDatos = New System.Windows.Forms.Button()
        Me.btn_BuscarEmpleado = New System.Windows.Forms.Button()
        Me.btn_SiguientePag = New System.Windows.Forms.Button()
        Me.btn_CLOSE = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_IDEmpleado
        '
        Me.lbl_IDEmpleado.AutoSize = True
        Me.lbl_IDEmpleado.Location = New System.Drawing.Point(12, 27)
        Me.lbl_IDEmpleado.Name = "lbl_IDEmpleado"
        Me.lbl_IDEmpleado.Size = New System.Drawing.Size(86, 16)
        Me.lbl_IDEmpleado.TabIndex = 0
        Me.lbl_IDEmpleado.Text = "ID Empleado"
        '
        'txt_IDEmpleado
        '
        Me.txt_IDEmpleado.Location = New System.Drawing.Point(104, 21)
        Me.txt_IDEmpleado.Name = "txt_IDEmpleado"
        Me.txt_IDEmpleado.Size = New System.Drawing.Size(92, 22)
        Me.txt_IDEmpleado.TabIndex = 1
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(229, 27)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Nombre.TabIndex = 2
        Me.lbl_Nombre.Text = "Nombre"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(291, 24)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(109, 22)
        Me.txt_Nombre.TabIndex = 3
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Location = New System.Drawing.Point(434, 27)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(57, 16)
        Me.lbl_Apellido.TabIndex = 4
        Me.lbl_Apellido.Text = "Apellido"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(497, 24)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(117, 22)
        Me.txt_Apellido.TabIndex = 5
        '
        'lbl_Habilidades
        '
        Me.lbl_Habilidades.AutoSize = True
        Me.lbl_Habilidades.Location = New System.Drawing.Point(12, 286)
        Me.lbl_Habilidades.Name = "lbl_Habilidades"
        Me.lbl_Habilidades.Size = New System.Drawing.Size(81, 16)
        Me.lbl_Habilidades.TabIndex = 8
        Me.lbl_Habilidades.Text = "Habilidades"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 305)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(908, 163)
        Me.DataGridView2.TabIndex = 9
        '
        'lbl_Beneficios
        '
        Me.lbl_Beneficios.AutoSize = True
        Me.lbl_Beneficios.Location = New System.Drawing.Point(12, 503)
        Me.lbl_Beneficios.Name = "lbl_Beneficios"
        Me.lbl_Beneficios.Size = New System.Drawing.Size(70, 16)
        Me.lbl_Beneficios.TabIndex = 10
        Me.lbl_Beneficios.Text = "Beneficios"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(12, 522)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(908, 172)
        Me.DataGridView3.TabIndex = 11
        '
        'lbl_Certificaciones
        '
        Me.lbl_Certificaciones.AutoSize = True
        Me.lbl_Certificaciones.Location = New System.Drawing.Point(9, 54)
        Me.lbl_Certificaciones.Name = "lbl_Certificaciones"
        Me.lbl_Certificaciones.Size = New System.Drawing.Size(95, 16)
        Me.lbl_Certificaciones.TabIndex = 6
        Me.lbl_Certificaciones.Text = "Certificaciones"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(908, 166)
        Me.DataGridView1.TabIndex = 7
        '
        'btn_GuardarDatos
        '
        Me.btn_GuardarDatos.Location = New System.Drawing.Point(792, 10)
        Me.btn_GuardarDatos.Name = "btn_GuardarDatos"
        Me.btn_GuardarDatos.Size = New System.Drawing.Size(128, 53)
        Me.btn_GuardarDatos.TabIndex = 12
        Me.btn_GuardarDatos.Text = "Guardar Datos"
        Me.btn_GuardarDatos.UseVisualStyleBackColor = True
        '
        'btn_BuscarEmpleado
        '
        Me.btn_BuscarEmpleado.Location = New System.Drawing.Point(638, 10)
        Me.btn_BuscarEmpleado.Name = "btn_BuscarEmpleado"
        Me.btn_BuscarEmpleado.Size = New System.Drawing.Size(136, 53)
        Me.btn_BuscarEmpleado.TabIndex = 13
        Me.btn_BuscarEmpleado.Text = "Buscar Empleado"
        Me.btn_BuscarEmpleado.UseVisualStyleBackColor = True
        '
        'btn_SiguientePag
        '
        Me.btn_SiguientePag.Location = New System.Drawing.Point(780, 700)
        Me.btn_SiguientePag.Name = "btn_SiguientePag"
        Me.btn_SiguientePag.Size = New System.Drawing.Size(140, 71)
        Me.btn_SiguientePag.TabIndex = 14
        Me.btn_SiguientePag.Text = "Siguiente pagina"
        Me.btn_SiguientePag.UseVisualStyleBackColor = True
        '
        'btn_CLOSE
        '
        Me.btn_CLOSE.Location = New System.Drawing.Point(622, 700)
        Me.btn_CLOSE.Name = "btn_CLOSE"
        Me.btn_CLOSE.Size = New System.Drawing.Size(152, 71)
        Me.btn_CLOSE.TabIndex = 15
        Me.btn_CLOSE.Text = "CLOSE"
        Me.btn_CLOSE.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 772)
        Me.Controls.Add(Me.btn_CLOSE)
        Me.Controls.Add(Me.btn_SiguientePag)
        Me.Controls.Add(Me.btn_BuscarEmpleado)
        Me.Controls.Add(Me.btn_GuardarDatos)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.lbl_Beneficios)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.lbl_Habilidades)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_Certificaciones)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.lbl_Apellido)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.txt_IDEmpleado)
        Me.Controls.Add(Me.lbl_IDEmpleado)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_IDEmpleado As Label
    Friend WithEvents txt_IDEmpleado As TextBox
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents lbl_Apellido As Label
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents lbl_Habilidades As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents lbl_Beneficios As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents lbl_Certificaciones As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_GuardarDatos As Button
    Friend WithEvents btn_BuscarEmpleado As Button
    Friend WithEvents btn_SiguientePag As Button
    Friend WithEvents btn_CLOSE As Button
End Class
