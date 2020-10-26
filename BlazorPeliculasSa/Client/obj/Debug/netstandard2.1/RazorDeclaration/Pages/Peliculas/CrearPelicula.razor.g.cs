#pragma checksum "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "475a0a40e605ecf53799fd2817f889bc28d9efeb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPeliculasSa.Client.Pages.Peliculas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\_Imports.razor"
using BlazorPeliculasSa.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\CrearPelicula.razor"
       

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
