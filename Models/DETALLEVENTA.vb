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

Partial Public Class DETALLEVENTA
    Public Property IIDETALLEVENTA As Integer
    Public Property IIDVENTA As Nullable(Of Integer)
    Public Property IIDVIAJE As Nullable(Of Integer)
    Public Property IIDBUS As Nullable(Of Integer)
    Public Property PRECIO As Nullable(Of Decimal)
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Bus As Bus
    Public Overridable Property VENTA As VENTA
    Public Overridable Property Viaje As Viaje

End Class
