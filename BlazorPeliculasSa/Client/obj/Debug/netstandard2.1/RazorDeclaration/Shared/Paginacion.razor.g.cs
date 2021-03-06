#pragma checksum "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Shared\Paginacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5ecbb7a36154681113934da6c205d5361c4472f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPeliculasSa.Client.Shared
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
    public partial class Paginacion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Shared\Paginacion.razor"
       
    [Parameter] public int PaginaActual { get; set; } = 1;
    [Parameter] public int PaginasTotales { get; set; }
    [Parameter] public int Radio { get; set; } = 3;
    [Parameter] public EventCallback<int> PaginaSeleccionada { get; set; }
    List<PaginasModel> Enlaces = new List<PaginasModel>();

    private async Task PaginaSeleccionadaInterno(PaginasModel paginaModel)
    {
        if (paginaModel.Pagina == PaginaActual)
        {
            return;
        }

        if (!paginaModel.Habilitada)
        {
            return;
        }

        await PaginaSeleccionada.InvokeAsync(paginaModel.Pagina);
    }

    protected override void OnParametersSet()
    {
        Enlaces = new List<PaginasModel>();

        var enlaceAnteriorHabilitada = PaginaActual != 1;
        var enlaceAnterior = PaginaActual - 1;
        Enlaces.Add(new PaginasModel(enlaceAnterior, enlaceAnteriorHabilitada, "Anterior"));

        for (int i = 1; i <= PaginasTotales; i++)
        {
            if (i >= PaginaActual - Radio && i <= PaginaActual + Radio)
            {
                Enlaces.Add(new PaginasModel(i) { Activa = PaginaActual == i });
            }
        }

        var enlaceSiguienteHabilitada = PaginaActual != PaginasTotales;
        var enlaceSiguiente = PaginaActual + 1;
        Enlaces.Add(new PaginasModel(enlaceSiguiente, enlaceSiguienteHabilitada, "Siguiente"));
    }


    class PaginasModel
    {

        public PaginasModel(int pagina)
            : this(pagina, true)
        { }

        public PaginasModel(int pagina, bool habilitada)
            : this(pagina, habilitada, pagina.ToString())
        { }

        public PaginasModel(int pagina, bool habilitada, string texto)
        {
            Pagina = pagina;
            Habilitada = habilitada;
            Texto = texto;
        }

        public string Texto { get; set; }
        public int Pagina { get; set; }
        public bool Habilitada { get; set; } = true;
        public bool Activa { get; set; } = false;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
