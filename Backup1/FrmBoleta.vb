Imports System.Data
Imports System.Data.OleDb

Public Class FrmBoleta

#Region "Metodos y Funciones"

    Sub CargaCodigoAlumno()
        Try
            'Se obtiene el Codigo, Apellido y Nombre
            Dim DA As New OleDbDataAdapter("Select Cod_Alu From Alumno Order By Cod_Alu Asc", CN)
            Dim DS As New DataSet 'Contenedor de los Datos del Alumno

            DA.Fill(DS, "TAlu")
            'Cargando el Combo de los Codigos
            CboCodigo.DataSource = DS.Tables("TAlu")
            CboCodigo.DisplayMember = "Cod_Alu"
            CboCodigo.ValueMember = "Cod_Alu"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Sub CargaDatosAlumno()
        Try
            'Obtiene los Datos del Alumno
            Dim DA As New OleDbDataAdapter("Select Ape_Alu, Nom_Alu, Fot_Alu From Alumno Where Cod_Alu='" & Me.CboCodigo.SelectedValue & "'", CN)
            Dim DS As New DataSet 'Contenedor de los Datos del Alumno
            Dim N, A, Datos As String
            DA.Fill(DS, "TAlu")
            'Obteniendo...
            'El Nombre
            N = DS.Tables("TAlu").Rows(0)(0)
            'El Apellido
            A = DS.Tables("TAlu").Rows(0)(1)
            'Concatenando
            Datos = N & " " & A


            'Recuperando el Tipo "Image" que nos devuelve la Función, para mostrarlo luego el PictureBox
            Dim img As Image = Bytes2Image(CType(DS.Tables("TAlu").Rows(0)("Fot_Alu"), Byte()))
            PBFoto.Image = img 'Mostrando la imagen o Foto


            '==========================================
            'Se obtiene el Codigo de la Especialidad, Turno y Ciclo 
            Dim DAMatriAlu As New OleDbDataAdapter("Select Cod_Espe, Cod_Turno, Cod_Ciclo From Matricula Where Cod_Alu='" & Me.CboCodigo.SelectedValue & "'", CN)

            Dim DSMatriAlu As New DataSet 'Contenedor de los Codigos
            Dim CodEAlu, CodTAlu, CodCAlu, NomEAlu, NomTAlu, NomCAlu As String


            '==================================
            'Obteniendo los Codigos
            DAMatriAlu.Fill(DSMatriAlu, "TCodidos")
            'Codigo Especialidad
            CodEAlu = DSMatriAlu.Tables("TCodidos").Rows(0)(0)
            'Codigo Turno
            CodTAlu = DSMatriAlu.Tables("TCodidos").Rows(0)(1)
            'Codigo Ciclo
            CodCAlu = DSMatriAlu.Tables("TCodidos").Rows(0)(2)
            '=============================================

            'Obteniendo los Nombres
            'Trae la Especialidad dependiendo del Codigo
            Dim DAEspe As New OleDbDataAdapter("Select Nom_Espe From Especialidad Where Cod_Espe='" & CodEAlu & "'", CN)
            'Trae la Turno dependiendo del Codigo
            Dim DATurno As New OleDbDataAdapter("Select Nom_Turno From Turno Where Cod_Turno='" & CodTAlu & "'", CN)
            'Trae la Ciclo dependiendo del Codigo
            Dim DACiclo As New OleDbDataAdapter("Select Nom_Ciclo From Ciclo Where Cod_Ciclo='" & CodCAlu & "'", CN)

            Dim DSEspe As New DataSet
            Dim DSTurno As New DataSet
            Dim DSCiclo As New DataSet

            'Depositando los Datos traidos en sus contenedores
            DAEspe.Fill(DSEspe, "TEspe")
            DATurno.Fill(DSTurno, "TTurno")
            DACiclo.Fill(DSCiclo, "TCiclo")

            'Nombre Especialidad
            NomEAlu = DSEspe.Tables("TEspe").Rows(0)(0)
            'Codigo Turno
            NomTAlu = DSTurno.Tables("TTurno").Rows(0)(0)
            'Codigo Ciclo
            NomCAlu = DSCiclo.Tables("TCiclo").Rows(0)(0)
            '=============================================

            'Mostrando los Datos
            '==============================================
            TxtNombre.Text = Datos
            TxtEspe.Text = NomEAlu
            TxtTurno.Text = NomTAlu
            TxtCiclo.Text = NomCAlu

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Private Sub LLenarNotas()
        Try
            'Traendo los Datos de la Tabla Notas de la Base de Datos
            Dim DA As New OleDbDataAdapter("SELECT Curso, Nota1, Nota2, Nota3, Promedio FROM Alu_Notas Where Cod_Alu='" & CboCodigo.SelectedValue & "'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TNotas")
            DGVNotas.DataSource = DS.Tables("TNotas")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub
#End Region

    Private Sub FrmBoleta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCodigoAlumno()
    End Sub

   
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        CargaDatosAlumno()
        LLenarNotas()
    End Sub

    Private Sub CboCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCodigo.SelectedIndexChanged

    End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged

    End Sub
End Class