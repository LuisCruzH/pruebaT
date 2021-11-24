@Code
    ViewData("Title") = "Index"
End Code
@ModelType IEnumerable(Of pruebaT.Marca)

<script type="text/javascript">
    $(document).ready(function () {
        $('#tabla1').DataTable({
            language: {
                "url": "https://cdn.datatables.net/plug-ins/1.10.22/i18n/Spanish.json",
                select: {
                    rows: "  -  %d Filas Seleccionadas"
                }
            }
        });
    });
</script>
<h2 style="margin-bottom:1rem;">Marca de Carros</h2>
@Html.ActionLink("Agregar", "Agregar", "Marca", Nothing, New With {.class = "btn btn-primary"})
<table id="tabla1" class="table table-bordered table-striped" style="margin-top:1rem; display:table;">
    <thead>
        <tr>
            <td>id</td>
            <td>nombre</td>
            <td>descripcion</td>
            <td></td>
        </tr>
    </thead>
    @For Each item In Model
        Dim currentItem = item
        @<tr>
            <td class="btn-pr">
                @Html.DisplayFor(Function(modelItem) currentItem.IIDMARCA)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) currentItem.NOMBRE)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) currentItem.DESCRIPCION)
            </td>
            <td>
                @Html.ActionLink("Edit", "Editar", New With {.id = currentItem.IIDMARCA}, New With {.class = "btn btn-primary"}) |
                @Html.ActionLink("Delete", "Eliminar", New With {.id = currentItem.IIDMARCA}, New With {.class = "btn btn-danger"})
            </td>
        </tr>
    Next
</table>
