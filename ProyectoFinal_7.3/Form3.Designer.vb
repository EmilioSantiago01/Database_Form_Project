<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lbl_TasaSalarial = New System.Windows.Forms.Label()
        Me.txt_TasaSalarial = New System.Windows.Forms.TextBox()
        Me.lbl_SalarioBruto = New System.Windows.Forms.Label()
        Me.txt_SalarioBruto = New System.Windows.Forms.TextBox()
        Me.lbl_SalarioNeto = New System.Windows.Forms.Label()
        Me.txt_SalarioNeto = New System.Windows.Forms.TextBox()
        Me.btn_GuardarenNomina = New System.Windows.Forms.Button()
        Me.lbl_Deducciones = New System.Windows.Forms.Label()
        Me.txt_Deducciones = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.txt_TOTAL = New System.Windows.Forms.TextBox()
        Me.btn_Close = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_IDEmpleado
        '
        Me.lbl_IDEmpleado.AutoSize = True
        Me.lbl_IDEmpleado.Location = New System.Drawing.Point(12, 44)
        Me.lbl_IDEmpleado.Name = "lbl_IDEmpleado"
        Me.lbl_IDEmpleado.Size = New System.Drawing.Size(83, 16)
        Me.lbl_IDEmpleado.TabIndex = 0
        Me.lbl_IDEmpleado.Text = "IDEmpleado"
        '
        'txt_IDEmpleado
        '
        Me.txt_IDEmpleado.Location = New System.Drawing.Point(114, 38)
        Me.txt_IDEmpleado.Name = "txt_IDEmpleado"
        Me.txt_IDEmpleado.ReadOnly = True
        Me.txt_IDEmpleado.Size = New System.Drawing.Size(100, 22)
        Me.txt_IDEmpleado.TabIndex = 1
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(12, 75)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Nombre.TabIndex = 2
        Me.lbl_Nombre.Text = "Nombre"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(114, 75)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 22)
        Me.txt_Nombre.TabIndex = 3
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Location = New System.Drawing.Point(13, 110)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(57, 16)
        Me.lbl_Apellido.TabIndex = 4
        Me.lbl_Apellido.Text = "Apellido"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(114, 110)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.ReadOnly = True
        Me.txt_Apellido.Size = New System.Drawing.Size(100, 22)
        Me.txt_Apellido.TabIndex = 5
        '
        'lbl_TasaSalarial
        '
        Me.lbl_TasaSalarial.AutoSize = True
        Me.lbl_TasaSalarial.Location = New System.Drawing.Point(12, 159)
        Me.lbl_TasaSalarial.Name = "lbl_TasaSalarial"
        Me.lbl_TasaSalarial.Size = New System.Drawing.Size(88, 16)
        Me.lbl_TasaSalarial.TabIndex = 6
        Me.lbl_TasaSalarial.Text = "Tasa Salarial"
        '
        'txt_TasaSalarial
        '
        Me.txt_TasaSalarial.Location = New System.Drawing.Point(114, 156)
        Me.txt_TasaSalarial.Name = "txt_TasaSalarial"
        Me.txt_TasaSalarial.ReadOnly = True
        Me.txt_TasaSalarial.Size = New System.Drawing.Size(100, 22)
        Me.txt_TasaSalarial.TabIndex = 7
        '
        'lbl_SalarioBruto
        '
        Me.lbl_SalarioBruto.AutoSize = True
        Me.lbl_SalarioBruto.Location = New System.Drawing.Point(13, 267)
        Me.lbl_SalarioBruto.Name = "lbl_SalarioBruto"
        Me.lbl_SalarioBruto.Size = New System.Drawing.Size(84, 16)
        Me.lbl_SalarioBruto.TabIndex = 10
        Me.lbl_SalarioBruto.Text = "Salario Bruto"
        '
        'txt_SalarioBruto
        '
        Me.txt_SalarioBruto.Location = New System.Drawing.Point(147, 267)
        Me.txt_SalarioBruto.Name = "txt_SalarioBruto"
        Me.txt_SalarioBruto.ReadOnly = True
        Me.txt_SalarioBruto.Size = New System.Drawing.Size(100, 22)
        Me.txt_SalarioBruto.TabIndex = 11
        '
        'lbl_SalarioNeto
        '
        Me.lbl_SalarioNeto.AutoSize = True
        Me.lbl_SalarioNeto.Location = New System.Drawing.Point(12, 301)
        Me.lbl_SalarioNeto.Name = "lbl_SalarioNeto"
        Me.lbl_SalarioNeto.Size = New System.Drawing.Size(82, 16)
        Me.lbl_SalarioNeto.TabIndex = 12
        Me.lbl_SalarioNeto.Text = "Salario Neto"
        '
        'txt_SalarioNeto
        '
        Me.txt_SalarioNeto.Location = New System.Drawing.Point(147, 298)
        Me.txt_SalarioNeto.Name = "txt_SalarioNeto"
        Me.txt_SalarioNeto.ReadOnly = True
        Me.txt_SalarioNeto.Size = New System.Drawing.Size(100, 22)
        Me.txt_SalarioNeto.TabIndex = 13
        '
        'btn_GuardarenNomina
        '
        Me.btn_GuardarenNomina.Location = New System.Drawing.Point(642, 390)
        Me.btn_GuardarenNomina.Name = "btn_GuardarenNomina"
        Me.btn_GuardarenNomina.Size = New System.Drawing.Size(146, 48)
        Me.btn_GuardarenNomina.TabIndex = 14
        Me.btn_GuardarenNomina.Text = "Guardar Nomina"
        Me.btn_GuardarenNomina.UseVisualStyleBackColor = True
        '
        'lbl_Deducciones
        '
        Me.lbl_Deducciones.AutoSize = True
        Me.lbl_Deducciones.Location = New System.Drawing.Point(14, 235)
        Me.lbl_Deducciones.Name = "lbl_Deducciones"
        Me.lbl_Deducciones.Size = New System.Drawing.Size(87, 16)
        Me.lbl_Deducciones.TabIndex = 15
        Me.lbl_Deducciones.Text = "Deducciones"
        '
        'txt_Deducciones
        '
        Me.txt_Deducciones.Location = New System.Drawing.Point(147, 235)
        Me.txt_Deducciones.Name = "txt_Deducciones"
        Me.txt_Deducciones.ReadOnly = True
        Me.txt_Deducciones.Size = New System.Drawing.Size(100, 22)
        Me.txt_Deducciones.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(253, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(541, 279)
        Me.DataGridView1.TabIndex = 17
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Location = New System.Drawing.Point(14, 365)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(51, 16)
        Me.lbl_Total.TabIndex = 18
        Me.lbl_Total.Text = "TOTAL"
        '
        'txt_TOTAL
        '
        Me.txt_TOTAL.Location = New System.Drawing.Point(86, 362)
        Me.txt_TOTAL.Name = "txt_TOTAL"
        Me.txt_TOTAL.ReadOnly = True
        Me.txt_TOTAL.Size = New System.Drawing.Size(100, 22)
        Me.txt_TOTAL.TabIndex = 19
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(491, 390)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(134, 48)
        Me.btn_Close.TabIndex = 20
        Me.btn_Close.Text = "CLOSE"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.txt_TOTAL)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_Deducciones)
        Me.Controls.Add(Me.lbl_Deducciones)
        Me.Controls.Add(Me.btn_GuardarenNomina)
        Me.Controls.Add(Me.txt_SalarioNeto)
        Me.Controls.Add(Me.lbl_SalarioNeto)
        Me.Controls.Add(Me.txt_SalarioBruto)
        Me.Controls.Add(Me.lbl_SalarioBruto)
        Me.Controls.Add(Me.txt_TasaSalarial)
        Me.Controls.Add(Me.lbl_TasaSalarial)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.lbl_Apellido)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.txt_IDEmpleado)
        Me.Controls.Add(Me.lbl_IDEmpleado)
        Me.Name = "Form3"
        Me.Text = "Form3"
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
    Friend WithEvents lbl_TasaSalarial As Label
    Friend WithEvents txt_TasaSalarial As TextBox
    Friend WithEvents lbl_SalarioBruto As Label
    Friend WithEvents txt_SalarioBruto As TextBox
    Friend WithEvents lbl_SalarioNeto As Label
    Friend WithEvents txt_SalarioNeto As TextBox
    Friend WithEvents btn_GuardarenNomina As Button
    Friend WithEvents lbl_Deducciones As Label
    Friend WithEvents txt_Deducciones As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_Total As Label
    Friend WithEvents txt_TOTAL As TextBox
    Friend WithEvents btn_Close As Button
End Class
