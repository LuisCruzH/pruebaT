'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class TipoBus
    Public Property IIDTIPOBUS As Integer
    Public Property NOMBRE As String
    Public Property DESCRIPCION As String
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Bus As ICollection(Of Bus) = New HashSet(Of Bus)

End Class
