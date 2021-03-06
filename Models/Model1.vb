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

Partial Public Class Asiento
    Public Property IIDASIENTO As Integer
    Public Property IIDVIAJE As Nullable(Of Integer)
    Public Property INDICEFILA As Nullable(Of Integer)
    Public Property INDICECOLUMNA As Nullable(Of Integer)
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Viaje As Viaje

End Class
Partial Public Class Bus
    Public Property IIDBUS As Integer
    Public Property IIDSUCURSAL As Nullable(Of Integer)
    Public Property IIDTIPOBUS As Nullable(Of Integer)
    Public Property PLACA As String
    Public Property FECHACOMPRA As Nullable(Of Date)
    Public Property IIDMODELO As Nullable(Of Integer)
    Public Property NUMEROFILAS As Nullable(Of Integer)
    Public Property NUMEROCOLUMNAS As Nullable(Of Integer)
    Public Property BHABILITADO As Nullable(Of Integer)
    Public Property DESCRIPCION As String
    Public Property OBSERVACION As String
    Public Property IIDMARCA As Nullable(Of Integer)

    Public Overridable Property Marca As Marca
    Public Overridable Property Modelo As Modelo
    Public Overridable Property Sucursal As Sucursal
    Public Overridable Property TipoBus As TipoBus
    Public Overridable Property DETALLEVENTA As ICollection(Of DETALLEVENTA) = New HashSet(Of DETALLEVENTA)
    Public Overridable Property Viaje As ICollection(Of Viaje) = New HashSet(Of Viaje)

End Class
Partial Public Class Cliente
    Public Property IIDCLIENTE As Integer
    Public Property NOMBRE As String
    Public Property APPATERNO As String
    Public Property APMATERNO As String
    Public Property EMAIL As String
    Public Property DIRECCION As String
    Public Property IIDSEXO As Nullable(Of Integer)
    Public Property TELEFONOFIJO As String
    Public Property TELEFONOCELULAR As String
    Public Property BHABILITADO As Nullable(Of Integer)
    Public Property bTieneUsuario As Nullable(Of Integer)
    Public Property TIPOUSUARIO As String

    Public Overridable Property Sexo As Sexo
    Public Overridable Property TIPOUSUARIOREGISTRO As TIPOUSUARIOREGISTRO
    Public Overridable Property VENTA As ICollection(Of VENTA) = New HashSet(Of VENTA)

End Class
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
Partial Public Class Empleado
    Public Property IIDEMPLEADO As Integer
    Public Property NOMBRE As String
    Public Property APPATERNO As String
    Public Property APMATERNO As String
    Public Property FECHACONTRATO As Nullable(Of Date)
    Public Property SUELDO As Nullable(Of Decimal)
    Public Property IIDTIPOUSUARIO As Nullable(Of Integer)
    Public Property IIDTIPOCONTRATO As Nullable(Of Integer)
    Public Property IIDSEXO As Nullable(Of Integer)
    Public Property BHABILITADO As Nullable(Of Integer)
    Public Property bTieneUsuario As Nullable(Of Integer)
    Public Property TIPOUSUARIO As String

    Public Overridable Property Sexo As Sexo
    Public Overridable Property TipoUsuario1 As TipoUsuario
    Public Overridable Property TipoContrato As TipoContrato
    Public Overridable Property TIPOUSUARIOREGISTRO As TIPOUSUARIOREGISTRO

End Class
Partial Public Class Lugar
    Public Property IIDLUGAR As Integer
    Public Property NOMBRE As String
    Public Property DESCRIPCION As String
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Viaje As ICollection(Of Viaje) = New HashSet(Of Viaje)
    Public Overridable Property Viaje1 As ICollection(Of Viaje) = New HashSet(Of Viaje)

End Class
Partial Public Class Marca
    Public Property IIDMARCA As Integer
    Public Property NOMBRE As String
    Public Property DESCRIPCION As String
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Bus As ICollection(Of Bus) = New HashSet(Of Bus)

End Class
Partial Public Class Modelo
    Public Property IIDMODELO As Integer
    Public Property NOMBRE As String
    Public Property DESCRIPCION As String
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Bus As ICollection(Of Bus) = New HashSet(Of Bus)

End Class
Partial Public Class Pagina
    Public Property IIDPAGINA As Integer
    Public Property MENSAJE As String
    Public Property ACCION As String
    Public Property CONTROLADOR As String
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property RolPagina As ICollection(Of RolPagina) = New HashSet(Of RolPagina)

End Class
Partial Public Class Rol
    Public Property IIDROL As Integer
    Public Property NOMBRE As String
    Public Property DESCRIPCION As String
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property RolPagina As ICollection(Of RolPagina) = New HashSet(Of RolPagina)
    Public Overridable Property Usuario As ICollection(Of Usuario) = New HashSet(Of Usuario)

End Class
Partial Public Class RolPagina
    Public Property IIDROLPAGINA As Integer
    Public Property IIDROL As Nullable(Of Integer)
    Public Property IIDPAGINA As Nullable(Of Integer)
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Pagina As Pagina
    Public Overridable Property Rol As Rol

End Class
Partial Public Class Sexo
    Public Property IIDSEXO As Integer
    Public Property NOMBRE As String
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Cliente As ICollection(Of Cliente) = New HashSet(Of Cliente)
    Public Overridable Property Empleado As ICollection(Of Empleado) = New HashSet(Of Empleado)

End Class
Partial Public Class Sucursal
    Public Property IIDSUCURSAL As Integer
    Public Property NOMBRE As String
    Public Property DIRECCION As String
    Public Property TELEFONO As String
    Public Property EMAIL As String
    Public Property FECHAAPERTURA As Nullable(Of Date)
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Bus As ICollection(Of Bus) = New HashSet(Of Bus)

End Class
Partial Public Class sysdiagrams
    Public Property name As String
    Public Property principal_id As Integer
    Public Property diagram_id As Integer
    Public Property version As Nullable(Of Integer)
    Public Property definition As Byte()

End Class
Partial Public Class TipoBus
    Public Property IIDTIPOBUS As Integer
    Public Property NOMBRE As String
    Public Property DESCRIPCION As String
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Bus As ICollection(Of Bus) = New HashSet(Of Bus)

End Class
Partial Public Class TipoContrato
    Public Property IIDTIPOCONTRATO As Integer
    Public Property NOMBRE As String
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Empleado As ICollection(Of Empleado) = New HashSet(Of Empleado)

End Class
Partial Public Class TipoUsuario
    Public Property IIDTIPOUSUARIO As Integer
    Public Property NOMBRE As String
    Public Property BHABILITADO As Nullable(Of Integer)
    Public Property DESCRIPCION As String

    Public Overridable Property Empleado As ICollection(Of Empleado) = New HashSet(Of Empleado)

End Class
Partial Public Class TIPOUSUARIOREGISTRO
    Public Property TIPOUSUARIO As String
    Public Property NOMBRE As String

    Public Overridable Property Cliente As ICollection(Of Cliente) = New HashSet(Of Cliente)
    Public Overridable Property Empleado As ICollection(Of Empleado) = New HashSet(Of Empleado)
    Public Overridable Property Usuario As ICollection(Of Usuario) = New HashSet(Of Usuario)

End Class
Partial Public Class Usuario
    Public Property IIDUSUARIO As Integer
    Public Property NOMBREUSUARIO As String
    Public Property CONTRA As String
    Public Property TIPOUSUARIO As String
    Public Property IID As Nullable(Of Integer)
    Public Property IIDROL As Nullable(Of Integer)
    Public Property bhabilitado As Nullable(Of Integer)

    Public Overridable Property Rol As Rol
    Public Overridable Property TIPOUSUARIOREGISTRO As TIPOUSUARIOREGISTRO

End Class
Partial Public Class VENTA
    Public Property IIDVENTA As Integer
    Public Property IIDCLIENTE As Nullable(Of Integer)
    Public Property TOTAL As Nullable(Of Decimal)
    Public Property FECHAVENTA As Nullable(Of Date)
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Cliente As Cliente
    Public Overridable Property DETALLEVENTA As ICollection(Of DETALLEVENTA) = New HashSet(Of DETALLEVENTA)

End Class
Partial Public Class Viaje
    Public Property IIDVIAJE As Integer
    Public Property IIDLUGARORIGEN As Nullable(Of Integer)
    Public Property IIDLUGARDESTINO As Nullable(Of Integer)
    Public Property PRECIO As Nullable(Of Decimal)
    Public Property FECHAVIAJE As Nullable(Of Date)
    Public Property IIDBUS As Nullable(Of Integer)
    Public Property NUMEROASIENTOSDISPONIBLES As Nullable(Of Integer)
    Public Property BHABILITADO As Nullable(Of Integer)
    Public Property FOTO As Byte()
    Public Property nombrefoto As String

    Public Overridable Property Asiento As ICollection(Of Asiento) = New HashSet(Of Asiento)
    Public Overridable Property Bus As Bus
    Public Overridable Property DETALLEVENTA As ICollection(Of DETALLEVENTA) = New HashSet(Of DETALLEVENTA)
    Public Overridable Property Lugar As Lugar
    Public Overridable Property Lugar1 As Lugar

End Class
