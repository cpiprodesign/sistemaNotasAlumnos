<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInforme
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CboCiclo = New System.Windows.Forms.ComboBox
        Me.CboTurno = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnMotsrar = New System.Windows.Forms.Button
        Me.DGVDatos = New System.Windows.Forms.DataGridView
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtDescrip = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CboEspe = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CboCurso = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboCiclo
        '
        Me.CboCiclo.FormattingEnabled = True
        Me.CboCiclo.Location = New System.Drawing.Point(426, 49)
        Me.CboCiclo.Name = "CboCiclo"
        Me.CboCiclo.Size = New System.Drawing.Size(67, 21)
        Me.CboCiclo.TabIndex = 10
        '
        'CboTurno
        '
        Me.CboTurno.FormattingEnabled = True
        Me.CboTurno.Location = New System.Drawing.Point(273, 43)
        Me.CboTurno.Name = "CboTurno"
        Me.CboTurno.Size = New System.Drawing.Size(97, 21)
        Me.CboTurno.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Turno:"
        '
        'BtnMotsrar
        '
        Me.BtnMotsrar.Location = New System.Drawing.Point(7, 71)
        Me.BtnMotsrar.Name = "BtnMotsrar"
        Me.BtnMotsrar.Size = New System.Drawing.Size(109, 23)
        Me.BtnMotsrar.TabIndex = 11
        Me.BtnMotsrar.Text = "Mostrar Registro"
        Me.BtnMotsrar.UseVisualStyleBackColor = True
        '
        'DGVDatos
        '
        Me.DGVDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDatos.Location = New System.Drawing.Point(12, 123)
        Me.DGVDatos.Name = "DGVDatos"
        Me.DGVDatos.Size = New System.Drawing.Size(506, 150)
        Me.DGVDatos.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Turno:"
        '
        'TxtDescrip
        '
        Me.TxtDescrip.Location = New System.Drawing.Point(273, 17)
        Me.TxtDescrip.Name = "TxtDescrip"
        Me.TxtDescrip.Size = New System.Drawing.Size(220, 20)
        Me.TxtDescrip.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnMotsrar)
        Me.GroupBox1.Controls.Add(Me.CboCiclo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CboTurno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtDescrip)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CboEspe)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CboCurso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 105)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio de Busqueda:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripción:"
        '
        'CboEspe
        '
        Me.CboEspe.FormattingEnabled = True
        Me.CboEspe.Location = New System.Drawing.Point(80, 44)
        Me.CboEspe.Name = "CboEspe"
        Me.CboEspe.Size = New System.Drawing.Size(121, 21)
        Me.CboEspe.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Especialidad:"
        '
        'CboCurso
        '
        Me.CboCurso.FormattingEnabled = True
        Me.CboCurso.Location = New System.Drawing.Point(80, 17)
        Me.CboCurso.Name = "CboCurso"
        Me.CboCurso.Size = New System.Drawing.Size(121, 21)
        Me.CboCurso.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo Curso:"
        '
        'FrmInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 289)
        Me.Controls.Add(Me.DGVDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmInforme"
        Me.Text = "Informe del Registro"
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CboCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents CboTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnMotsrar As System.Windows.Forms.Button
    Friend WithEvents DGVDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboEspe As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
