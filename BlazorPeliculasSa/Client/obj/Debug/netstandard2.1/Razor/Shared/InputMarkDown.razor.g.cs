#pragma checksum "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\InputMarkDown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62995c86aa38cb18c06e6d8537cbd3e46c7508e2"
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
#nullable restore
#line 2 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\InputMarkDown.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
    public partial class InputMarkDown<TValue> : InputTextArea
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n    ");
            __builder.OpenElement(2, "label");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\InputMarkDown.razor"
            Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(7);
            __builder.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\InputMarkDown.razor"
                                    CurrentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentValue = __value, CurrentValue))));
            __builder.AddAttribute(10, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrentValue));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n        ");
            __Blazor.BlazorPeliculasSa.Client.Shared.InputMarkDown.TypeInference.CreateValidationMessage_0(__builder, 12, 13, 
#nullable restore
#line 11 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\InputMarkDown.razor"
                                For

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n\n");
            __builder.OpenElement(17, "div");
            __builder.AddMarkupContent(18, "\n    ");
            __builder.OpenElement(19, "label");
            __builder.AddContent(20, 
#nullable restore
#line 17 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\InputMarkDown.razor"
            Label

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " (preview):");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "markdown-container");
            __builder.AddAttribute(25, "style", "overflow: auto;");
            __builder.AddMarkupContent(26, "\n      ");
            __builder.OpenComponent<BlazorPeliculasSa.Client.Shared.MostrarMarkDawn>(27);
            __builder.AddAttribute(28, "ContenidoMarkDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\InputMarkDown.razor"
                                            CurrentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Owner\source\repos\ISBlazor\BlazorPeliculasSa\Client\Shared\InputMarkDown.razor"
       
        [Parameter] public Expression<Func<TValue>> For {get; set;}
        [Parameter] public string Label {get; set;}

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorPeliculasSa.Client.Shared.InputMarkDown
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591