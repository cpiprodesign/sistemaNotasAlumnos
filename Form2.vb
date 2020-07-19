Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDNotasDataSet.Notas' Puede moverla o quitarla según sea necesario.
        Me.NotasTableAdapter.Fill(Me.BDNotasDataSet.Notas)
        'TODO: esta línea de código carga datos en la tabla 'BDNotasDataSet.Matricula' Puede moverla o quitarla según sea necesario.
        Me.MatriculaTableAdapter.Fill(Me.BDNotasDataSet.Matricula)


    End Sub
End Class