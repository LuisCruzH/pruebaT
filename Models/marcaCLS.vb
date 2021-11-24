Imports System.Data.Entity

Public Class MarcaCLS
    Public Property iiMarca() As Integer
    Public Property nombre() As String
    Public Property descripcion() As String
    Public Property bHabilitado() As Integer
End Class
Public Class MarcaDBContext
    Inherits BDPasajeEntities
    Public Property Marcas() As DbSet(Of MarcaCLS)
End Class