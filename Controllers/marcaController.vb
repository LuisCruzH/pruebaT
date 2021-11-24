Imports System.Data.Entity
Imports System.Web.Mvc

Namespace Controllers
    Public Class marcaController
        Inherits Controller

        Private db As BDPasajeEntities = New BDPasajeEntities
        ' GET: marca
        Function Index() As ActionResult
            Return View(db.Marca.ToList())
        End Function

        Function Agregar() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Agregar(marca As Marca) As ActionResult
            If ModelState.IsValid Then
                db.Entry(marca).State = EntityState.Added
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(marca)
        End Function

        Function Editar() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Editar(marca As Marca) As ActionResult
            If ModelState.IsValid Then
                db.Entry(marca).State = EntityState.Added
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(marca)
        End Function
        Function Eliminar() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Eliminar(marca As Marca) As ActionResult
            If ModelState.IsValid Then
                db.Entry(marca).State = EntityState.Added
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(marca)
        End Function
    End Class
End Namespace