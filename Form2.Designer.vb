<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodAluDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDNotasDataSet = New ANotas.BDNotasDataSet()
        Me.AlumnoTableAdapter = New ANotas.BDNotasDataSetTableAdapters.AlumnoTableAdapter()
        Me.AlumnoMatriculaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatriculaTableAdapter = New ANotas.BDNotasDataSetTableAdapters.MatriculaTableAdapter()
        Me.AlumnoNotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotasTableAdapter = New ANotas.BDNotasDataSetTableAdapters.NotasTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDNotasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoMatriculaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoNotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodAluDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AlumnoNotasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(416, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'CodAluDataGridViewTextBoxColumn
        '
        Me.CodAluDataGridViewTextBoxColumn.DataPropertyName = "Cod_Alu"
        Me.CodAluDataGridViewTextBoxColumn.HeaderText = "Cod_Alu"
        Me.CodAluDataGridViewTextBoxColumn.Name = "CodAluDataGridViewTextBoxColumn"
        '
        'AlumnoBindingSource
        '
        Me.AlumnoBindingSource.DataMember = "Alumno"
        Me.AlumnoBindingSource.DataSource = Me.BDNotasDataSet
        '
        'BDNotasDataSet
        '
        Me.BDNotasDataSet.DataSetName = "BDNotasDataSet"
        Me.BDNotasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnoTableAdapter
        '
        Me.AlumnoTableAdapter.ClearBeforeFill = True
        '
        'AlumnoMatriculaBindingSource
        '
        Me.AlumnoMatriculaBindingSource.DataMember = "AlumnoMatricula"
        Me.AlumnoMatriculaBindingSource.DataSource = Me.AlumnoBindingSource
        '
        'MatriculaTableAdapter
        '
        Me.MatriculaTableAdapter.ClearBeforeFill = True
        '
        'AlumnoNotasBindingSource
        '
        Me.AlumnoNotasBindingSource.DataMember = "AlumnoNotas"
        Me.AlumnoNotasBindingSource.DataSource = Me.AlumnoBindingSource
        '
        'NotasTableAdapter
        '
        Me.NotasTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDNotasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoMatriculaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoNotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BDNotasDataSet As BDNotasDataSet
    Friend WithEvents AlumnoBindingSource As BindingSource
    Friend WithEvents AlumnoTableAdapter As BDNotasDataSetTableAdapters.AlumnoTableAdapter
    Friend WithEvents CodAluDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlumnoMatriculaBindingSource As BindingSource
    Friend WithEvents MatriculaTableAdapter As BDNotasDataSetTableAdapters.MatriculaTableAdapter
    Friend WithEvents AlumnoNotasBindingSource As BindingSource
    Friend WithEvents NotasTableAdapter As BDNotasDataSetTableAdapters.NotasTableAdapter
End Class
