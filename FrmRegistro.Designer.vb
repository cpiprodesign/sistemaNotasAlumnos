<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistro
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtProfe = New System.Windows.Forms.TextBox()
        Me.TxtDescrip = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CBoCurso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnTodos = New System.Windows.Forms.Button()
        Me.CBoCiclo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBoTurno = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBoEspe = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVRNotas = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnGuAc = New System.Windows.Forms.Button()
        Me.TxtN3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtN2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtN1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnBoleta = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnInforme = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVRNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PBFoto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtProfe)
        Me.GroupBox1.Controls.Add(Me.TxtDescrip)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.CBoCurso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Curso:"
        '
        'PBFoto
        '
        Me.PBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBFoto.Location = New System.Drawing.Point(331, 13)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(100, 82)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFoto.TabIndex = 8
        Me.PBFoto.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Profesor del Curso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descripción:"
        '
        'TxtProfe
        '
        Me.TxtProfe.Location = New System.Drawing.Point(121, 68)
        Me.TxtProfe.Name = "TxtProfe"
        Me.TxtProfe.Size = New System.Drawing.Size(203, 20)
        Me.TxtProfe.TabIndex = 5
        '
        'TxtDescrip
        '
        Me.TxtDescrip.Location = New System.Drawing.Point(121, 42)
        Me.TxtDescrip.Name = "TxtDescrip"
        Me.TxtDescrip.Size = New System.Drawing.Size(203, 20)
        Me.TxtDescrip.TabIndex = 4
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(245, 15)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CBoCurso
        '
        Me.CBoCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoCurso.FormattingEnabled = True
        Me.CBoCurso.Location = New System.Drawing.Point(121, 13)
        Me.CBoCurso.Name = "CBoCurso"
        Me.CBoCurso.Size = New System.Drawing.Size(118, 21)
        Me.CBoCurso.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo Curso:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnTodos)
        Me.GroupBox2.Controls.Add(Me.CBoCiclo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CBoTurno)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CBoEspe)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 57)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Aula:"
        '
        'BtnTodos
        '
        Me.BtnTodos.Location = New System.Drawing.Point(375, 22)
        Me.BtnTodos.Name = "BtnTodos"
        Me.BtnTodos.Size = New System.Drawing.Size(56, 23)
        Me.BtnTodos.TabIndex = 7
        Me.BtnTodos.Text = "Todos"
        Me.BtnTodos.UseVisualStyleBackColor = True
        '
        'CBoCiclo
        '
        Me.CBoCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoCiclo.FormattingEnabled = True
        Me.CBoCiclo.Location = New System.Drawing.Point(321, 22)
        Me.CBoCiclo.Name = "CBoCiclo"
        Me.CBoCiclo.Size = New System.Drawing.Size(48, 21)
        Me.CBoCiclo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ciclo:"
        '
        'CBoTurno
        '
        Me.CBoTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoTurno.FormattingEnabled = True
        Me.CBoTurno.Location = New System.Drawing.Point(219, 19)
        Me.CBoTurno.Name = "CBoTurno"
        Me.CBoTurno.Size = New System.Drawing.Size(63, 21)
        Me.CBoTurno.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Turno:"
        '
        'CBoEspe
        '
        Me.CBoEspe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoEspe.FormattingEnabled = True
        Me.CBoEspe.Location = New System.Drawing.Point(72, 22)
        Me.CBoEspe.Name = "CBoEspe"
        Me.CBoEspe.Size = New System.Drawing.Size(107, 21)
        Me.CBoEspe.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Especialidad:"
        '
        'DGVRNotas
        '
        Me.DGVRNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRNotas.Location = New System.Drawing.Point(12, 169)
        Me.DGVRNotas.Name = "DGVRNotas"
        Me.DGVRNotas.ReadOnly = True
        Me.DGVRNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRNotas.Size = New System.Drawing.Size(308, 150)
        Me.DGVRNotas.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnGuAc)
        Me.GroupBox3.Controls.Add(Me.TxtN3)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtN2)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtN1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(326, 169)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(111, 150)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese de Notas:"
        '
        'BtnGuAc
        '
        Me.BtnGuAc.Location = New System.Drawing.Point(14, 106)
        Me.BtnGuAc.Name = "BtnGuAc"
        Me.BtnGuAc.Size = New System.Drawing.Size(84, 38)
        Me.BtnGuAc.TabIndex = 4
        Me.BtnGuAc.Text = "G&uardar / Actualizar"
        Me.BtnGuAc.UseVisualStyleBackColor = True
        '
        'TxtN3
        '
        Me.TxtN3.Location = New System.Drawing.Point(59, 73)
        Me.TxtN3.Name = "TxtN3"
        Me.TxtN3.Size = New System.Drawing.Size(43, 20)
        Me.TxtN3.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Nota 3:"
        '
        'TxtN2
        '
        Me.TxtN2.Location = New System.Drawing.Point(59, 47)
        Me.TxtN2.Name = "TxtN2"
        Me.TxtN2.Size = New System.Drawing.Size(43, 20)
        Me.TxtN2.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Nota 2:"
        '
        'TxtN1
        '
        Me.TxtN1.Location = New System.Drawing.Point(59, 21)
        Me.TxtN1.Name = "TxtN1"
        Me.TxtN1.Size = New System.Drawing.Size(43, 20)
        Me.TxtN1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nota 1:"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(10, 325)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 4
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(91, 325)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(119, 23)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar &Registro"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnBoleta
        '
        Me.BtnBoleta.Location = New System.Drawing.Point(216, 325)
        Me.BtnBoleta.Name = "BtnBoleta"
        Me.BtnBoleta.Size = New System.Drawing.Size(75, 23)
        Me.BtnBoleta.TabIndex = 6
        Me.BtnBoleta.Text = "&Boleta"
        Me.BtnBoleta.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(385, 325)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(52, 23)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnInforme
        '
        Me.BtnInforme.Location = New System.Drawing.Point(304, 325)
        Me.BtnInforme.Name = "BtnInforme"
        Me.BtnInforme.Size = New System.Drawing.Size(75, 23)
        Me.BtnInforme.TabIndex = 8
        Me.BtnInforme.Text = "&Informe"
        Me.BtnInforme.UseVisualStyleBackColor = True
        '
        'FrmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 359)
        Me.Controls.Add(Me.BtnInforme)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnBoleta)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DGVRNotas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmRegistro"
        Me.Text = "Registro de Notas ."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVRNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBoCurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PBFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtProfe As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CBoTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBoEspe As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBoCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DGVRNotas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtN1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnGuAc As System.Windows.Forms.Button
    Friend WithEvents TxtN3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtN2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnBoleta As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnTodos As System.Windows.Forms.Button
    Friend WithEvents BtnInforme As System.Windows.Forms.Button

End Class
