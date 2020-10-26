#pragma checksum "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\VisualizarPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf16a90b45e590f750b9163283c795b11e596cdd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pelicula/{PeliculaId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pelicula/{PeliculaId:int}/{NombrePelicula}")]
    public partial class VisualizarPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\VisualizarPelicula.razor"
  
    [Parameter] public int PeliculaId { get; set; }
    [Parameter] public string NombrePelicula { get; set; }
    private PeliculaVisualizarDTO model;
    private RenderFragment<Genero> enlaceGenero = (genero) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "a");
            __builder2.AddAttribute(1, "href", "/peliculas/buscar?generoid=" + (
#nullable restore
#line 75 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                                   genero.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(2, 
#nullable restore
#line 75 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                                               genero.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 75 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                                                                ;

     private async Task OnVote(int votoSeleccionado)
     {
         model.VotoUsuario = votoSeleccionado;
         var votoPelicula = new VotosPelicula() { Voto = votoSeleccionado, PeliculaId = PeliculaId };
         var responseHttp = await repositorio.Post("api/votos", votoPelicula);
         if (responseHttp.Error)
         {
             await mostrarMensaje.MostrarMensajeError("Su voto no ha sido recibido");
         }
         else
         {
             await mostrarMensaje.MostrarMensajeExitoso("Su voto ha sido recibido");
         }
     }
     protected async override Task OnInitializedAsync()
     {
         var responseHttp = await repositorio.Get<PeliculaVisualizarDTO>($"api/peliculas/{PeliculaId}");
         if (responseHttp.Error)
         {
             if (responseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
             {
                 navigatorManager.NavigateTo("");
             }
             else
             {
                 var mensajeError = await responseHttp.GetBody();

                 await mostrarMensaje.MostrarMensajeError(mensajeError);
             }
         }
         else
         {
             model = responseHttp.Response;
         }
     }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensaje { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigatorManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
