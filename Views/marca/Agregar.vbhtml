@Code
    ViewData("Title") = "Agregar"
End Code
@ModelType  MarcaCLS
<h2>Agregar Marca</h2>
<div class="container">
    <div class="row">
        <div class="col-auto">
            @Using Html.BeginForm("Agregar", "Marca", method:=FormMethod.Post)
                @<text>
                    <div class="form-group">
                        <label for="nombre">Nombre</label>
                        @Html.TextBox("nombre", Model, New With {.class = "form-control"})
                    </div>
                    <div class="form-group">
                        <label for="descripcion">Descripcion </label>
                        @Html.TextBox("descripcion", Model, Nothing, New With {.class = "form-control"})
                    </div>
                    <div style="margin:auto; margin-top:1rem;">
                        <input type="submit" class="btn btn-primary" value="Guardar" />
                    </div>
                </text>
            End Using
        </div>
        </div>
</div>