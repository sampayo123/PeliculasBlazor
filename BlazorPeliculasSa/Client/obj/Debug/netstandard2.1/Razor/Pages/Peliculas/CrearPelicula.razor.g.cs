#pragma checksum "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1c438639cb16e1510265b2fe04f4a039f5ac5e"
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
#line 5 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculas/crear")]
    public partial class CrearPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Crear Pelicula</h3>\n\n");
#nullable restore
#line 9 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor"
 if (MostrarFormulario)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorPeliculasSa.Client.Pages.Peliculas.FormularioPeliculas>(2);
            __builder.AddAttribute(3, "Pelicula", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorPeliculasSa.Shared.Entidades.Pelicula>(
#nullable restore
#line 11 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor"
                                   Pelicula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 11 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor"
                                                            Crear

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "GenerosNoSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorPeliculasSa.Shared.Entidades.Genero>>(
#nullable restore
#line 12 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor"
                                                 GenerosNoSeleccionados

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n");
#nullable restore
#line 13 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "Cargando...");
#nullable restore
#line 16 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor"
                            
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor"
       

    private bool MostrarFormulario { get; set; } = false;
    private Pelicula Pelicula = new Pelicula();
    private List<Genero> GenerosNoSeleccionados = new List<Genero>();

    protected async override Task OnInitializedAsync()
    {
        var responseHttp = await repositorio.Get<List<Genero>>("api/generos");
        GenerosNoSeleccionados = responseHttp.Response;
        MostrarFormulario = true;

    }
    async Task Crear()
    {
        var httpResponse = await repositorio.Post<Pelicula, int>("api/peliculas", Pelicula);


        if (httpResponse.Error)
        {
            var mensajeError = await httpResponse.GetBody();
            Console.WriteLine("SOY TU ERROR");
            await mostrarMensaje.MostrarMensajeError(mensajeError);

        }
        else
        {
            var PeliculaId = httpResponse.Response;
            //  Console.WriteLine("Se creo la pelicula");
            navigationManager.NavigateTo($"/pelicula/{PeliculaId}/{Pelicula.Titulo.Replace(" ", "-")}");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensaje { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
