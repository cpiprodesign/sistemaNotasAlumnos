'Namespace para conectarse con Access
Imports System.Data.OleDb
Imports System.IO

Module Conexion
    'Conexion a la Base de Datos
    Public CN As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data source=D:\CRISTIAN\BDNotas.mdb")
    'Tabla Virtual, donde se almacenara los Datos a Grabar
    Public TablaRNotas As New DataTable

    Sub Main()
        Application.Run(New FrmRegistro)
    End Sub

    Public Function Bytes2Image(ByVal bytes() As Byte) As Image
        'Funcion que convierte la imagen de la foto que esta almacenado en Access
        'el cual esta en Formato "Bits" al tipo "Image", para poder luego msotrarlo en un PictureBox
        If bytes Is Nothing Then Return Nothing
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function
End Module
