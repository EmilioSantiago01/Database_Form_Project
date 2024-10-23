Imports System.Data.OleDb

Public Class Form2

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emili\OneDrive - NUC University Online\Desktop\NUC\PROG2280L\Empleados11.accdb;Persist Security Info=False;"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatosEnDataGridView("RegistroEmpleado", DataGridView2)
        MostrarDatosEnDataGridView("RegistroEmpleado", DataGridView1)
        MostrarDatosEnDataGridView("RegistroEmpleado", DataGridView3)
    End Sub

    Private Sub MostrarDatosEnDataGridView(nombreTabla As String, dataGridView As DataGridView)
        Dim query As String = $"SELECT * FROM {nombreTabla}"

        Using conexion As New OleDbConnection(connectionString)
            Dim adapter As New OleDbDataAdapter(query, conexion)
            Dim dataSet As New DataSet()

            Try
                conexion.Open()
                adapter.Fill(dataSet, nombreTabla)
                dataGridView.DataSource = dataSet.Tables(nombreTabla)
                For Each col As DataGridViewColumn In dataGridView.Columns
                    col.ReadOnly = True
                Next

                ' Habilitar edición solo para las columnas específicas
                For Each colName As String In {"Habilidades", "Certificaciones", "Beneficios"}
                    Dim col As DataGridViewColumn = dataGridView.Columns(colName)
                    If col IsNot Nothing Then
                        col.ReadOnly = False
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_GuardarDatos.Click
        GuardarInformacion(DataGridView2, "RegistroEmpleado")
        GuardarInformacion(DataGridView1, "RegistroEmpleado")
        GuardarInformacion(DataGridView3, "RegistroEmpleado")
    End Sub

    Private Sub GuardarInformacion(dataGridView As DataGridView, nombreTabla As String)
        For Each row As DataGridViewRow In dataGridView.Rows
            ' Verificar si la fila no es nueva
            If Not row.IsNewRow Then
                ' Obtener el IDEmpleado, Nombre y Apellido de la fila
                Dim idEmpleado As String = row.Cells("IDEmpleado").Value.ToString()
                Dim nombre As String = row.Cells("Nombre").Value.ToString()
                Dim apellido As String = row.Cells("Apellido").Value.ToString()

                ' Verificar desde qué DataGridView se están leyendo los datos
                Select Case dataGridView.Name
                    Case "DataGridView1"
                        ' Obtener los valores de Habilidades, Certificaciones y Beneficios
                        Dim habilidades As String = row.Cells("Habilidades").Value.ToString()
                        Dim certificaciones As String = row.Cells("Certificaciones").Value.ToString()
                        Dim beneficios As String = row.Cells("Beneficios").Value.ToString()

                        ' Actualizar los valores en la base de datos
                        ActualizarRegistro(nombreTabla, idEmpleado, nombre, apellido, habilidades, certificaciones, beneficios)
                    Case "DataGridView2"
                        ' Obtener los valores de Habilidades, Certificaciones y Beneficios
                        Dim habilidades As String = row.Cells("Habilidades").Value.ToString()
                        Dim certificaciones As String = row.Cells("Certificaciones").Value.ToString()
                        Dim beneficios As String = row.Cells("Beneficios").Value.ToString()

                        ' Actualizar los valores en la base de datos
                        ActualizarRegistro(nombreTabla, idEmpleado, nombre, apellido, habilidades, certificaciones, beneficios)
                    Case "DataGridView3"
                        ' Obtener los valores de Habilidades, Certificaciones y Beneficios
                        Dim habilidades As String = row.Cells("Habilidades").Value.ToString()
                        Dim certificaciones As String = row.Cells("Certificaciones").Value.ToString()
                        Dim beneficios As String = row.Cells("Beneficios").Value.ToString()

                        ' Actualizar los valores en la base de datos
                        ActualizarRegistro(nombreTabla, idEmpleado, nombre, apellido, habilidades, certificaciones, beneficios)
                End Select
            End If
        Next

        MessageBox.Show("Datos guardados correctamente en la base de datos.")
    End Sub

    Private Sub ActualizarRegistro(nombreTabla As String, idEmpleado As String, nombre As String, apellido As String, habilidades As String, certificaciones As String, beneficios As String)
        ' Ejecutar una consulta SQL para actualizar la fila correspondiente en la base de datos
        Dim query As String = $"UPDATE {nombreTabla} SET Habilidades = @Habilidades, Certificaciones = @Certificaciones, Beneficios = @Beneficios WHERE IDEmpleado = @IDEmpleado AND Nombre = @Nombre AND Apellido = @Apellido"
        Using conexion As New OleDbConnection(connectionString)
            Dim cmd As New OleDbCommand(query, conexion)
            cmd.Parameters.AddWithValue("@Habilidades", habilidades)
            cmd.Parameters.AddWithValue("@Certificaciones", certificaciones)
            cmd.Parameters.AddWithValue("@Beneficios", beneficios)
            cmd.Parameters.AddWithValue("@IDEmpleado", idEmpleado)
            cmd.Parameters.AddWithValue("@Nombre", nombre)
            cmd.Parameters.AddWithValue("@Apellido", apellido)
            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error al guardar datos en la base de datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_BuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btn_BuscarEmpleado.Click
        BuscarEmpleado(DataGridView2, txt_IDEmpleado.Text, txt_Nombre.Text, txt_Apellido.Text)
        BuscarEmpleado(DataGridView1, txt_IDEmpleado.Text, txt_Nombre.Text, txt_Apellido.Text)
        BuscarEmpleado(DataGridView3, txt_IDEmpleado.Text, txt_Nombre.Text, txt_Apellido.Text)
    End Sub

    Private Sub BuscarEmpleado(dataGridView As DataGridView, idEmpleado As String, nombre As String, apellido As String)
        Dim filtro As String = ""

        ' Construir el filtro en base a los valores de los TextBox
        If Not String.IsNullOrWhiteSpace(idEmpleado) Then
            filtro &= $"IDEmpleado = {idEmpleado} AND "
        End If

        If Not String.IsNullOrWhiteSpace(nombre) Then
            filtro &= $"Nombre = '{nombre}' AND "
        End If

        If Not String.IsNullOrWhiteSpace(apellido) Then
            filtro &= $"Apellido = '{apellido}' AND "
        End If

        ' Eliminar el último "AND"
        If filtro.EndsWith(" AND ") Then
            filtro = filtro.Substring(0, filtro.Length - 5)
        End If

        If Not String.IsNullOrWhiteSpace(filtro) Then
            CType(dataGridView.DataSource, DataTable).DefaultView.RowFilter = filtro
        Else
            CType(dataGridView.DataSource, DataTable).DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub btn_SiguientePag_Click(sender As Object, e As EventArgs) Handles btn_SiguientePag.Click
        Dim form3 As New Form3()

        ' Mostrar el formulario 2
        form3.Show()

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

    Private Sub btn_CLOSE_Click(sender As Object, e As EventArgs) Handles btn_CLOSE.Click

        Me.Close()

    End Sub
End Class



