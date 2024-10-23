Imports System.Data.OleDb

Public Class Form3
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emili\OneDrive - NUC University Online\Desktop\NUC\PROG2280L\Empleados11.accdb;Persist Security Info=False;"

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar los datos de los empleados en el DataGridView
        MostrarDatosEnDataGridView()
    End Sub

    Private Sub MostrarDatosEnDataGridView()
        Dim query As String = "SELECT IDEmpleado, Nombre, Apellido, TasaSalarial FROM RegistroEmpleado"

        Using conexion As New OleDbConnection(connectionString)
            Dim adapter As New OleDbDataAdapter(query, conexion)
            Dim dataSet As New DataSet()

            Try
                conexion.Open()
                adapter.Fill(dataSet, "Empleados")
                DataGridView1.DataSource = dataSet.Tables("Empleados")
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos de empleados: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_GuardarNomina_Click(sender As Object, e As EventArgs) Handles btn_GuardarenNomina.Click
        ' Verificar si se ha seleccionado un empleado
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim idEmpleado As String = selectedRow.Cells("IDEmpleado").Value.ToString()
            Dim tasaSalarial As Decimal = Convert.ToDecimal(selectedRow.Cells("TasaSalarial").Value)

            ' Calcular el sueldo bruto y sueldo neto
            Dim sueldoBruto As Decimal = tasaSalarial
            Dim sueldoNeto As Decimal = sueldoBruto * (1 - 0.12)

            ' Guardar los datos en la tabla "Nomina"
            GuardarEnNomina(idEmpleado, sueldoBruto, sueldoNeto)
        Else
            MessageBox.Show("Por favor, seleccione un empleado.")
        End If
    End Sub

    Private Sub GuardarEnNomina(idEmpleado As String, sueldoBruto As Decimal, sueldoNeto As Decimal)
        Dim query As String = "INSERT INTO Nomina (IDEmpleado, [Sueldo Bruto], [Sueldo Neto]) VALUES (@IDEmpleado, @SueldoBruto, @SueldoNeto)"

        Using conexion As New OleDbConnection(connectionString)
            Dim cmd As New OleDbCommand(query, conexion)
            cmd.Parameters.AddWithValue("@IDEmpleado", idEmpleado)
            cmd.Parameters.AddWithValue("@SueldoBruto", sueldoBruto)
            cmd.Parameters.AddWithValue("@SueldoNeto", sueldoNeto)

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Datos guardados en la tabla Nomina.")
            Catch ex As Exception
                MessageBox.Show("Error al guardar datos en la tabla Nomina: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            txt_IDEmpleado.Text = selectedRow.Cells("IDEmpleado").Value.ToString()
            txt_Nombre.Text = selectedRow.Cells("Nombre").Value.ToString()
            txt_Apellido.Text = selectedRow.Cells("Apellido").Value.ToString()
            txt_TasaSalarial.Text = selectedRow.Cells("TasaSalarial").Value.ToString()


            Dim tasaSalarial As Decimal = Convert.ToDecimal(selectedRow.Cells("TasaSalarial").Value)

            ' Calcular el salario bruto
            Dim salarioBruto As Decimal = tasaSalarial

            ' Calcular las deducciones (suponiendo una tasa fija del 12%)
            Dim deducciones As Decimal = salarioBruto * 0.12

            ' Calcular el salario neto
            Dim salarioNeto As Decimal = salarioBruto - deducciones

            ' Mostrar los resultados en los TextBox respectivos
            txt_SalarioBruto.Text = salarioBruto.ToString()
            txt_Deducciones.Text = deducciones.ToString()
            txt_SalarioNeto.Text = salarioNeto.ToString()

            txt_TOTAL.Text = salarioNeto.ToString()
        End If
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click

        Me.Close()
    End Sub
End Class





