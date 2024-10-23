Imports System.Data.OleDb

Public Class Form1

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emili\OneDrive - NUC University Online\Desktop\NUC\PROG2280L\Empleados11.accdb;Persist Security Info=False;"
    Dim conexion As OleDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New OleDbConnection(connectionString)
        Try
            conexion.Open()
            MessageBox.Show("Conexión establecida correctamente.")
            ' Puedes realizar consultas, inserciones, actualizaciones, etc., aquí
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btn_GuardarDatos_Click(sender As Object, e As EventArgs) Handles btn_GuardarDatos.Click


        Dim IDEmpleado As Integer

        ' Intenta convertir el valor del IDEmpleado a Integer
        If Not Integer.TryParse(txt_IDEmpleado.Text, IDEmpleado) Then
            MessageBox.Show("El valor del ID de empleado no es válido. Por favor ingrese un número entero.")
            Return
        End If

        Dim Nombre As String = txt_Nombre.Text
        Dim Apellido As String = txt_Apellido.Text
        Dim FechaNacimiento As Date = DTP_FechadeNacimiento.Value
        Dim GradoObtenido As String = txt_GradoObtenido.Text
        Dim PuestoOcupar As String = txt_PuestoaOcupar.Text
        Dim TasaSalarial As Decimal

        ' Intenta convertir el valor de la TasaSalarial a Decimal
        If Not Decimal.TryParse(txt_TasaSalarial.Text, TasaSalarial) Then
            MessageBox.Show("El valor de la tasa salarial no es válido. Por favor ingrese un número decimal.")
            Return
        End If

        Dim FechaContrato As Date = DTP_FechadeContrato.Value

        ' Formatear las fechas en el formato adecuado para Access
        Dim strFechaNacimiento As String = FechaNacimiento.ToString("MM/dd/yyyy")
        Dim strFechaContrato As String = FechaContrato.ToString("MM/dd/yyyy")

        ' Consulta SQL para la inserción (sin incluir las nuevas columnas)
        Dim query As String = "INSERT INTO RegistroEmpleado (IDEmpleado, Nombre, Apellido, FechaNacimiento, GradoObtenido, PuestoOcupar, TasaSalarial, FechaContrato) VALUES (@IDEmpleado, @Nombre, @Apellido, @FechaNacimiento, @GradoObtenido, @PuestoOcupar, @TasaSalarial, @FechaContrato)"

        ' Crear el comando con la consulta SQL y la conexión
        Using conexion As New OleDbConnection(connectionString)
            Dim cmd As New OleDbCommand(query, conexion)

            ' Asignar los valores de los parámetros
            cmd.Parameters.AddWithValue("@IDEmpleado", IDEmpleado)
            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.Parameters.AddWithValue("@Apellido", Apellido)
            cmd.Parameters.AddWithValue("@FechaNacimiento", strFechaNacimiento)
            cmd.Parameters.AddWithValue("@GradoObtenido", GradoObtenido)
            cmd.Parameters.AddWithValue("@PuestoOcupar", PuestoOcupar)
            cmd.Parameters.AddWithValue("@TasaSalarial", TasaSalarial)
            cmd.Parameters.AddWithValue("@FechaContrato", strFechaContrato)

            Try
                ' Abrir la conexión y ejecutar la consulta
                conexion.Open()
                cmd.ExecuteNonQuery()

                ' Mostrar un mensaje de éxito
                MessageBox.Show("Empleado registrado correctamente.")
            Catch ex As Exception
                ' Mostrar un mensaje de error en caso de excepción
                MessageBox.Show("Error al registrar empleado: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_SiguientePag_Click(sender As Object, e As EventArgs) Handles btn_SiguientePag.Click
        Dim form2 As New Form2()

        ' Mostrar el formulario 2
        form2.Show()

        'Ocultar Formulario 1
        Me.Hide()

    End Sub

    Private Sub txt_IDEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_IDEmpleado.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Suprime el carácter ingresado
        End If
    End Sub

    Private Sub txt_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Nombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Suprime el carácter ingresado
        End If
    End Sub

    Private Sub txt_Apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Apellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Suprime el carácter ingresado
        End If
    End Sub

    Private Sub DTP_FechadeNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles DTP_FechadeNacimiento.ValueChanged
        Dim fechaNacimiento As Date = DTP_FechadeNacimiento.Value

        ' Calcular la edad actual
        Dim edad As Integer = Date.Now.Year - fechaNacimiento.Year

        ' Verificar si la fecha de nacimiento ha ocurrido hace 18 años o más
        If (Date.Now.Month < fechaNacimiento.Month) OrElse (Date.Now.Month = fechaNacimiento.Month AndAlso Date.Now.Day < fechaNacimiento.Day) Then
            edad -= 1
        End If

        ' Verificar si la edad es menor de 18 años
        If edad < 18 Then
            MessageBox.Show("Debe ser mayor de 18 años para registrarse.")
            ' Restaurar la fecha de nacimiento a una fecha válida
            DTP_FechadeNacimiento.Value = Date.Today.AddYears(-18)
        End If
    End Sub

    Private Sub txt_GradoObtenido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_GradoObtenido.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es una letra ni una tecla de control, cancelar la entrada
            e.Handled = True
        End If
    End Sub

    Private Sub txt_PuestoaOcupar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PuestoaOcupar.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es una letra ni una tecla de control, cancelar la entrada
            e.Handled = True
        End If
    End Sub

    Private Sub txt_TasaSalarial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TasaSalarial.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número, un punto decimal ni una tecla de control, cancelar la entrada
            e.Handled = True
        End If
    End Sub

    Private Sub DTP_FechadeContrato_ValueChanged(sender As Object, e As EventArgs) Handles DTP_FechadeContrato.ValueChanged
        Dim fechaActual As Date = Date.Today

        ' Obtener la fecha seleccionada en el DateTimePicker
        Dim fechaSeleccionada As Date = DTP_FechadeContrato.Value

        ' Verificar si la fecha seleccionada es anterior a la fecha actual
        If fechaSeleccionada < fechaActual Then
            MessageBox.Show("La fecha de contrato no puede ser anterior a la fecha actual.")
            DTP_FechadeContrato.Value = fechaActual ' Establecer la fecha actual como fecha seleccionada
        End If
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click

        Me.Close()
    End Sub
End Class








