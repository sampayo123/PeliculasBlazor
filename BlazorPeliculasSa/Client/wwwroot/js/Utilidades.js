function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorPeliculasSa.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("Conteo desde JS " + resultado);
        });
}

function pruebaPuntoNetInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}