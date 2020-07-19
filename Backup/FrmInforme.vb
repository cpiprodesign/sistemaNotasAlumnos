Imports System.Data
Imports System.Data.OleDb

Public Class FrmInforme

#Region "Metodos y Funciones"

    Private Sub CargaCurso()
        Try
            Dim DA As New OleDbDataAdapter("Select * From Curso", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TCurso")
            CboCurso.DataSource = DS.Tables("TCurso")
            CboCurso.DisplayMember = "Cod_Curso"
            CboCurso.ValueMember = "Cod_Curso"
            TxtDescrip.Text = DS.Tables("TCurso").Rows(0)("Nom_Curso")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Sub CargaEspecilidad()
        Try
            Dim DA As New OleDbDataAdapter("Select * From Especialidad", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TEspe")
            CboEspe.DataSource = DS.Tables("TEspe")
            CboEspe.DisplayMember = "Nom_Espe"
            CboEspe.ValueMember = "Cod_Espe"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Sub CargaTurno()
        Try
            Dim DA As New OleDbDataAdapter("Select * From Turno", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TTurno")
            CboTurno.DataSource = DS.Tables("TTurno")
            CboTurno.DisplayMember = "Nom_Turno"
            CboTurno.ValueMember = "Cod_Turno"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Sub CargaCiclo()
        Try
            Dim DA As New OleDbDataAdapter("Select * From Ciclo", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "TCiclo")
            CboCiclo.DataSource = DS.Tables("TCiclo")
            CboCiclo.DisplayMember = "Nom_Ciclo"
            CboCiclo.ValueMember = "Cod_Ciclo"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub
#End Region

    Private Sub FrmInforme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCurso()
        CargaEspecilidad()
        CargaTurno()
        CargaCiclo()
    End Sub

    Private Sub CboCurso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCurso.SelectedIndexChanged
        If CboCurso.Focused = True Then
            TxtDescrip.Text = CboCurso.SelectedItem.Row("Nom_Curso")
        End If
    End Sub

    Private Sub BtnMotsrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMotsrar.Click
        Try
            Dim DAInforme As New OleDbDataAdapter("Select Nombre, Nota1, Nota2, Nota3, Promedio From Alu_Informe Where Cod_Cur='" & Me.CboCurso.SelectedValue & "' AND Cod_Espe='" & Me.CboEspe.SelectedValue & "' AND Cod_Turno='" & Me.CboTurno.SelectedValue & "' AND Cod_Ciclo='" & Me.CboCiclo.SelectedValue & "'", CN)
            Dim DSInforme As New DataSet
            DAInforme.Fill(DSInforme, "TInforme")
            DGVDatos.DataSource = DSInforme.Tables("TInforme")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Controlado")
        End Try
    End Sub

    Private Sub TxtDescrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescrip.TextChanged

    End Sub
End Class