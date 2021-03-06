#pragma checksum "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ca184c6f4edaa4adb07eca1913b1c3fb449d33e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculasSa.Client.Pages.Peliculas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculas/editar/{PeliculaId:int}")]
    public partial class EditarPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Pelicula</h3>\n\n\n");
#nullable restore
#line 9 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor"
 if (Pelicula == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Cargando...</p>\n");
#nullable restore
#line 12 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<BlazorPeliculasSa.Client.Pages.Peliculas.FormularioPeliculas>(4);
            __builder.AddAttribute(5, "Pelicula", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorPeliculasSa.Shared.Entidades.Pelicula>(
#nullable restore
#line 15 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor"
                                   Pelicula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor"
                                        Editar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ActoresSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorPeliculasSa.Shared.Entidades.Persona>>(
#nullable restore
#line 17 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor"
                                               ActoresSeleccionados

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "GenerosNoSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorPeliculasSa.Shared.Entidades.Genero>>(
#nullable restore
#line 18 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor"
                                                 GenerosNoSeleccionados

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "GenerosSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorPeliculasSa.Shared.Entidades.Genero>>(
#nullable restore
#line 19 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor"
                                               GenerosSeleccionados

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 20 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\EditarPelicula.razor"
       

    [Parameter] public int PeliculaId { get; set; }
    Pelicula Pelicula;
    private List<Genero> GenerosSeleccionados = new List<Genero>();
    private List<Genero> GenerosNoSeleccionados = new List<Genero>();
    private List<Persona> ActoresSeleccionados { get; set; }

    protected async override Task OnInitializedAsync()
    {
        var httpResponse = await repositorio.Get<PeliculaActualizacionDTO>
            ($"api/peliculas/actualizar/{PeliculaId}");

        if (httpResponse.Error)
        {
            if (httpResponse.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                navigationManager.NavigateTo("");
            }
            else
            {
                await mostrarMensaje.MostrarMensajeError(await httpResponse.GetBody());
            }
        }
        else
        {
            var model = httpResponse.Response;
            ActoresSeleccionados = model.Actores;
            GenerosNoSeleccionados = model.GeneroNoSeleccionado;
            GenerosSeleccionados = model.GeneroSeleccionado;
            Pelicula = model.Pelicula;

        }


    }



    private async Task Editar()
    {
        var httpResponse = await repositorio.Put("api/peliculas", Pelicula);
        if (httpResponse.Error)
        {
            await mostrarMensaje.MostrarMensajeError(await httpResponse.GetBody());
        }
        else
        {
            navigationManager.NavigateTo($"/pelicula/{PeliculaId}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensaje { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
