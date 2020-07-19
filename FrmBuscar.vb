Imports System.Data
Imports System.Data.OleDb

Public Class FrmBuscar

#Region "Metodos y Funciones"

    Private Sub LLenarAlumno()
        Try
            Dim DA As New OleDbDataAdapter("Select * From Alu_Matri", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TAluMatri")
            DGGVAlumnos.DataSource = DS.Tables("TAluMatri")

            'Ocultando las Columnas Cod_Espe, Cod_Turno, Cod_Ciclo
            DGGVAlumnos.Columns(3).Visible = False
            DGGVAlumnos.Columns(4).Visible = False
            DGGVAlumnos.Columns(5).Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Private Sub BuscararAlumno()
        Try
            Dim DA As New OleDbDataAdapter("Select * From Alu_Matri Where Apellido Like '" & Me.TxtNombre.Text.ToUpper & "%'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TAluMatri")
            DGGVAlumnos.DataSource = DS.Tables("TAluMatri")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Private Sub PasarDatos()
        Try
            Dim F As Integer
            Dim CA, N, A, D, Esp, Tur, Cic As String
            'Cogemos el Indice de la Fila Seleccionada
            F = DGGVAlumnos.CurrentCell.RowIndex
            'Cogemos lo seleccionado en el DataGridView
            CA = DGGVAlumnos.Rows(F).Cells(0).Value
            N = DGGVAlumnos.Rows(F).Cells(1).Value
            A = DGGVAlumnos.Rows(F).Cells(2).Value
            Esp = DGGVAlumnos.Rows(F).Cells(3).Value
            Tur = DGGVAlumnos.Rows(F).Cells(4).Value
            Cic = DGGVAlumnos.Rows(F).Cells(5).Value
            'Concatenando el Nombre + el Apellido en "D"
            D = N & " " & A
            Dim DR As DataRow 'Representa a una Fila
            'Genera una Fila en Blanco en la Tabla "TablaRNotas"
            DR = TablaRNotas.NewRow
            'Dentro de esa Fila, se le esta asignando datos a cada
            'Campo que posea esa Fila
            DR("Nombre") = D
            DR("Espe") = Esp
            DR("Turno") = Tur
            DR("Ciclo") = Cic
            DR("CodigoAlu") = CA
            'Una vez que la Fila y sus Campos tengas Datos
            'se agrega dicha Fila a la Tabla "TablaRNotas"
            TablaRNotas.Rows.Add(DR)

            'Invocando al Filtro del FrmRegistro
            FrmRegistro.Filtra(FrmRegistro.CBoEspe.SelectedValue, FrmRegistro.CBoTurno.SelectedValue, FrmRegistro.CBoCiclo.SelectedValue)


            'Se muestra en el DataGridView del FrmRegistro
            'la Tabla
            'FrmRegistro.DGVRNotas.DataSource = TablaRNotas
            
            'Cierra el Formulario Actual
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

#End Region

    Private Sub FrmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LLenarAlumno()
    End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged
        BuscararAlumno()
    End Sub

    Private Sub DGGVAlumnos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGGVAlumnos.DoubleClick
        PasarDatos()
    End Sub
End Class