@ModelType pruebaT.MarcaCLS
@Code
    ViewData("Title") = "Editar"
End Code

<h2>Editar Marca</h2>
<div class="container">
    <div class="row">
        <div class="col-lg-6">
            @Using Html.BeginForm()
                @Html.ValidationSummary(True)
                @<fieldset>
                    @Html.HiddenFor(Function(model) model.iiMarca)
                    <div class="editor-label">
                        @Html.LabelFor(Function(model) model.nombre)
                    </div>
                    <div class="editor-field">
                        @Html.EditorFor(Function(model) model.nombre, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(model) model.nombre)
                    </div>
                    <div class="editor-label" style="margin-top:1rem;">
                        @Html.LabelFor(Function(model) model.descripcion)
                    </div>
                    <div class="editor-field">
                        @Html.EditorFor(Function(model) model.descripcion, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(model) model.descripcion)
                    </div>
                    <div style="margin-top:1rem;">
                        <input type="submit" class="btn btn-primary" value="Modificar" />
                    </div>
                </fieldset>
            End Using
        </div>
    </div>
</div>

