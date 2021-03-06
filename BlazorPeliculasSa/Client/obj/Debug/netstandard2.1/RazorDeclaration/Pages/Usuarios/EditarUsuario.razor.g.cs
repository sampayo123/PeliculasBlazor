#pragma checksum "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Pages\Usuarios\EditarUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fcf91e02afd464bf73f391bca2cf6cc689774b7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPeliculasSa.Client.Pages.Usuarios
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/usuarios/editar/{UserId}")]
    public partial class EditarUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\isampayo\Desktop\Nueva carpeta (2)\PeliculasBlazor\BlazorPeliculasSa\Client\Pages\Usuarios\EditarUsuario.razor"
       
    [Parameter] public string UserId { get; set; }
    private List<RolDTO> roles = new List<RolDTO>();
    private string rolSeleccionado = "0";

    protected override async Task OnInitializedAsync()
    {
        var httpResponse = await repositorio.Get<List<RolDTO>>("api/usuarios/roles");

        if (httpResponse.Error)
        {
            await mostrarMensajes.MostrarMensajeError(await httpResponse.GetBody());
        }
        else
        {
            roles = httpResponse.Response;
        }
    }

    private async Task AsignarRol()
    {
        await EditarRol("api/usuarios/asignarRol");
    }

    private async Task RemoverRol()
    {
        await EditarRol("api/usuarios/removerRol");
    }

    private async Task EditarRol(string url)
    {
        if (rolSeleccionado == "0")
        {
            await mostrarMensajes.MostrarMensajeError("Debe seleccionar un rol");
            return;
        }

        var rolDTO = new EditarRolDTO() { RoleId = rolSeleccionado, UserId = UserId };

        var httpResponse = await repositorio.Post<EditarRolDTO>(url, rolDTO);

        if (httpResponse.Error)
        {
            await mostrarMensajes.MostrarMensajeError(await httpResponse.GetBody());
        }
        else
        {
            await mostrarMensajes.MostrarMensajeExitoso("Operación realizada");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
