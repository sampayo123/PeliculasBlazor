#pragma checksum "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\Paginacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f28646995044af49cde78fb7bf1022dc77e3503"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculasSa.Client.Shared
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
    public partial class Paginacion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 3 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\Paginacion.razor"
         foreach (var enlace in Enlaces)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\Paginacion.razor"
                            () => PaginaSeleccionadaInterno(enlace)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "style", "cursor: pointer;");
            __builder.AddAttribute(10, "class", "page-item" + " " + (
#nullable restore
#line 7 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\Paginacion.razor"
                                   enlace.Habilitada ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 7 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\Paginacion.razor"
                                                                            enlace.Activa ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "\n                ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "page-link");
            __builder.AddAttribute(14, "href", "#");
            __builder.AddContent(15, 
#nullable restore
#line 8 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\Paginacion.razor"
                                                  enlace.Texto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
#nullable restore
#line 10 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\Paginacion.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\Paginacion.razor"
       
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