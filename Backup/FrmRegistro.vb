Imports System.Data
Imports System.Data.OleDb

Public Class FrmRegistro

#Region "Metodos y Funciones"

    Private Sub CargaCurso()
        Try
            Dim DA As New OleDbDataAdapter("Select * From Curso", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TCurso")
            CBoCurso.DataSource = DS.Tables("TCurso")
            CBoCurso.DisplayMember = "Cod_Curso"
            CBoCurso.ValueMember = "Cod_Curso"
            TxtDescrip.Text = DS.Tables("TCurso").Rows(0)("Nom_Curso")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Private Sub CargaProfe()
        Try
            Dim CodProfe As String
            CodProfe = CBoCurso.SelectedItem.Row("Cod_Profe")
            Dim DA As New OleDbDataAdapter("Select * From Profesor Where Cod_Profe='" & CodProfe & "'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TProfe")

            Dim Ape, Nom As String
            Ape = DS.Tables("TProfe").Rows(0)("Ape_Profe") 'Obtiene el Apellido
            Nom = DS.Tables("TProfe").Rows(0)("Nom_Profe") 'Obtiene el Nombre
            TxtProfe.Text = Nom & " " & Ape 'Concatena el Nombre mas el Apellido

            'Recuperando el Tipo "Image" que nos devuelve la Función, para mostrarlo luego el PictureBox
            Dim img As Image = Bytes2Image(CType(DS.Tables("TProfe").Rows(0)("Fot_Profe"), Byte()))
            PBFoto.Image = img 'Mostrando la imagen o Foto
            TxtDescrip.Text = CBoCurso.SelectedItem.Row("Nom_Curso")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Sub AgregaCampos()
        TablaRNotas.Columns.Add("Nombre")
        TablaRNotas.Columns.Add("N1")
        TablaRNotas.Columns.Add("N2")
        TablaRNotas.Columns.Add("N3")
        TablaRNotas.Columns.Add("Prom")

        TablaRNotas.Columns.Add("Espe")
        TablaRNotas.Columns.Add("Turno")
        TablaRNotas.Columns.Add("Ciclo")
        TablaRNotas.Columns.Add("CodigoAlu")


        DGVRNotas.DataSource = TablaRNotas
        DGVRNotas.Columns(0).Width = "140"
        DGVRNotas.Columns(1).Width = "30"
        DGVRNotas.Columns(2).Width = "30"
        DGVRNotas.Columns(3).Width = "30"
        DGVRNotas.Columns(4).Width = "35"

        'Ocultando las Columnas Espe, Turno, Ciclo
        DGVRNotas.Columns(5).Visible = False
        DGVRNotas.Columns(6).Visible = False
        DGVRNotas.Columns(7).Visible = False
        DGVRNotas.Columns(8).Visible = False

    End Sub

    Sub AgregarNotas()
        Try
            Dim Promedio As Double
            Dim Filas() As DataRow
            Dim Fila As DataRow
            'Obtiene el Indice de la Fila seleccionada del DataGridView
            Dim Valor As String
            'Cogemos el Valor del Codigo del Alumno, para agregar o actualizar sus notas
            Valor = DGVRNotas.Rows(DGVRNotas.CurrentRow.Index).Cells(8).Value
            'Nos devuelve una Fila, que representa a ese Alumno
            Filas = TablaRNotas.Select("CodigoAlu='" & Valor & "'")
            Fila = Filas(0)
            'Obtiene le Promedio
            Promedio = Math.Round((Val(TxtN1.Text) + Val(TxtN2.Text) + Val(TxtN3.Text)) / 3)
            'Se le asigna sus Notas
            Fila("N1") = TxtN1.Text
            Fila("N2") = TxtN2.Text
            Fila("N3") = TxtN3.Text
            Fila("Prom") = Promedio

            'DGVRNotas.DataSource = TablaRNotas 'Ver Todos despues de colocar las notas
            Filtra(CBoEspe.SelectedValue, CBoTurno.SelectedValue, CBoCiclo.SelectedValue) 'Ver de acuerdo a los combos
            TxtN1.Clear()
            TxtN2.Clear()
            TxtN3.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Sub CargaEspecilidad()
        Try
            Dim DA As New OleDbDataAdapter("Select * From Especialidad", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TEspe")
            CBoEspe.DataSource = DS.Tables("TEspe")
            CBoEspe.DisplayMember = "Nom_Espe"
            CBoEspe.ValueMember = "Cod_Espe"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Sub CargaTurno()
        Try
            Dim DA As New OleDbDataAdapter("Select * From Turno", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TTurno")
            CBoTurno.DataSource = DS.Tables("TTurno")
            CBoTurno.DisplayMember = "Nom_Turno"
            CBoTurno.ValueMember = "Cod_Turno"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Sub CargaCiclo()
        Try
            Dim DA As New OleDbDataAdapter("Select * From Ciclo", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TCiclo")
            CBoCiclo.DataSource = DS.Tables("TCiclo")
            CBoCiclo.DisplayMember = "Nom_Ciclo"
            CBoCiclo.ValueMember = "Cod_Ciclo"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Sub Filtra(ByVal Especialidad As String, ByVal Turno As String, ByVal Ciclo As String)
        Try
            Dim DT1 As New DataTable
            Dim LOSROWS As DataRow()
            DT1 = TablaRNotas.Clone
            'Realiza el Filtro por los 3 Campos
            LOSROWS = TablaRNotas.Select("Espe='" & Especialidad & "' AND Turno='" & Turno & "' AND Ciclo='" & Ciclo & "'")
            'Nos Devuelve un Conjunto de Filas, las cuales hay q mandarlas a una Tabla llamada "DT1"
            For Each DR As DataRow In LOSROWS
                DT1.ImportRow(DR) 'Se IMPORTA las filas a la Tabla "DT1"
            Next
            'Se muestra en la DataGridView dicha Tabla que ya tienes las Filas que se filtraron
            DGVRNotas.DataSource = DT1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Sub GuardarNotas()
        Try
            If DGVRNotas.Rows.Count = 0 Then
                MessageBox.Show("No existen Alumnos x Registrar", "Sistma de Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim Notas As String
                Notas = DGVRNotas.Rows(0).Cells(1).Value.ToString
                If Notas = "" Then
                    MessageBox.Show("No existen Notas", "Sistma de Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            Dim CodigoRegistro, N1, N2, N3, PROM As Double
            Dim CAL, CUR As String
            Dim TablaRegis As DataTable

            'Obtiene el Codigo del Curso
            CUR = CBoCurso.SelectedValue

            'Obtiene el Codigo del Registro que se Grabo
            CodigoRegistro = GuardarRegistro()

            'Obtenemos la Tabla Virtual que esta almacenando el DataGridView
            TablaRegis = DGVRNotas.DataSource

            'Abre la Conexion
            CN.Open()
            For X As Integer = 0 To TablaRegis.Rows.Count - 1
                Dim CMD As New OleDbCommand("Insert Into Notas(Num_Regis, Cod_Alu, Cod_Cur, Nota1, Nota2, Nota3, Promedio) Values(?,?,?,?,?,?,?)")
                'Obtiene los Datos de la Tabla "TablaRNotas"
                CAL = TablaRegis.Rows.Item(X)(8)
                N1 = TablaRegis.Rows.Item(X)(1)
                N2 = TablaRegis.Rows.Item(X)(2)
                N3 = TablaRegis.Rows.Item(X)(3)
                PROM = TablaRegis.Rows.Item(X)(4)
                'Los Datos son colocados en los Parametros, para mandar los a la Tabla Notas de la Base de Datos
                CMD.Parameters.AddWithValue("@NRE", CodigoRegistro)
                CMD.Parameters.AddWithValue("@CAL", CAL)
                CMD.Parameters.AddWithValue("@CUR", CUR)
                CMD.Parameters.AddWithValue("@N1", N1)
                CMD.Parameters.AddWithValue("@N2", N2)
                CMD.Parameters.AddWithValue("@N3", N3)
                CMD.Parameters.AddWithValue("@PROM", PROM)
                CMD.Connection = CN
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Next
            'Cierra la Conexión
            CN.Close()
            MessageBox.Show("Datos Guardados Correctamente", "Sistma de Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
            CN.Close()
        End Try
    End Sub

    Function GuardarRegistro() As Integer
        Dim CodiRegi As Integer
        Try

            Dim CodCur, CodPro, CodEspe, CodTur, CodCic As String
            CodCur = CBoCurso.SelectedValue
            CodPro = CBoCurso.SelectedItem.Row("Cod_Profe")
            CodEspe = CBoEspe.SelectedValue
            CodTur = CBoTurno.SelectedValue
            CodCic = CBoCiclo.SelectedValue
            'Abre la Conexión
            CN.Open()
            Dim CMD As New OleDbCommand("Insert Into Registro(Cod_Curso, Cod_Profe, Cod_Espe, Cod_Turno, Cod_Ciclo) Values(?,?,?,?,?)")
            'Los Datos son colocados en los Parametros, para mandar los a la Tabla Notas de la Base de Datos
            CMD.Parameters.AddWithValue("@CUR", CodCur)
            CMD.Parameters.AddWithValue("@PRO", CodPro)
            CMD.Parameters.AddWithValue("@ESP", CodEspe)
            CMD.Parameters.AddWithValue("@TUR", CodTur)
            CMD.Parameters.AddWithValue("@CIC", CodCic)
            CMD.Connection = CN
            CMD.ExecuteScalar()
            'Libera los Recursos de Memoria
            CMD.Dispose()
            'Cierra la Conexión
            CN.Close()

            'Obtiene el Código Regitro Insertado
            Dim DA As New OleDbDataAdapter("Select Top 1 Num_Regis From Registro Order By Num_Regis Desc", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TRegGra")
            CodiRegi = DS.Tables("TRegGra").Rows(0)(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
            CN.Close()
        End Try
        Return CodiRegi
    End Function


#End Region

    Private Sub FrmRegistro_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Filtra(CBoEspe.SelectedValue, CBoTurno.SelectedValue, CBoCiclo.SelectedValue)
    End Sub

    Private Sub FrmRegistro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCurso()
        CargaProfe()
        AgregaCampos()
        CargaEspecilidad()
        CargaTurno()
        CargaCiclo()
    End Sub

    Private Sub CBoCurso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoCurso.SelectedIndexChanged
        If CBoCurso.Focused = True Then
            CargaProfe()
        End If
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        'Llama al FrmBuscar
        FrmBuscar.ShowDialog()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        'Cierra el Formulario Actual
        Me.Close()
    End Sub

    Private Sub BtnGuAc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuAc.Click
        AgregarNotas()
    End Sub

    Private Sub CBoEspe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoEspe.SelectedIndexChanged
        If CBoEspe.Focused = True Then
            'Filtra en el DataGridView los Alumnos cuya Especialidad, Turno y Ciclo coincidan con lo
            'que se esta seleccionando de los ComboBox.
            Filtra(CBoEspe.SelectedValue, CBoTurno.SelectedValue, CBoCiclo.SelectedValue)
            BtnGuardar.Enabled = True
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub CBoTurno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoTurno.SelectedIndexChanged
        If CBoTurno.Focused = True Then
            'Filtra en el DataGridView los Alumnos cuya Especialidad, Turno y Ciclo coincidan con lo
            'que se esta seleccionando de los ComboBox.
            Filtra(CBoEspe.SelectedValue, CBoTurno.SelectedValue, CBoCiclo.SelectedValue)
            BtnGuardar.Enabled = True
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub CBoCiclo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoCiclo.SelectedIndexChanged
        If CBoCiclo.Focused = True Then
            'Filtra en el DataGridView los Alumnos cuya Especialidad, Turno y Ciclo coincidan con lo
            'que se esta seleccionando de los ComboBox.
            Filtra(CBoEspe.SelectedValue, CBoTurno.SelectedValue, CBoCiclo.SelectedValue)
            BtnGuardar.Enabled = True
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub BtnTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTodos.Click
        DGVRNotas.DataSource = TablaRNotas
        BtnGuardar.Enabled = True
        GroupBox3.Enabled = True
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        GuardarNotas()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        TablaRNotas.Clear()
        DGVRNotas.DataSource = TablaRNotas
    End Sub

    Private Sub BtnBoleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBoleta.Click
        'Llama a Boleta
        FrmBoleta.ShowDialog()
    End Sub

    Private Sub BtnInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInforme.Click
        'Llama a Informe
        FrmInforme.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TxtDescrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescrip.TextChanged

    End Sub
End Class

