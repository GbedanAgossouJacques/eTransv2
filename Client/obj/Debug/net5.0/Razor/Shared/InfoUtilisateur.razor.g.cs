#pragma checksum "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Shared\InfoUtilisateur.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eb0fc99a01f84f08227eba98c7915cba1449bcc"
// <auto-generated/>
#pragma warning disable 1591
namespace eTrans.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using eTrans.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using eTrans.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using eTrans.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using eTrans.Client.Models.Transport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using eTrans.Client.Models.Visitors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using eTrans.Client.Services.ServicesChauffeur;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using eTrans.Client.Services.ServicesTranssport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\_Imports.razor"
using eTrans.Client.Services.ServicesClient;

#line default
#line hidden
#nullable disable
    public partial class InfoUtilisateur : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "list-unstyled");
#nullable restore
#line 4 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Shared\InfoUtilisateur.razor"
     foreach (var user in ClientService.Clients)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddAttribute(3, "class", "media my-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "media-img-wrapper mr-2");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", "/client/" + (
#nullable restore
#line 8 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Shared\InfoUtilisateur.razor"
                                  user.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "class", "media-img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 9 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Shared\InfoUtilisateur.razor"
                                                 user.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt", "aaaaaaaaaaaa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "media-body");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "/client/" + (
#nullable restore
#line 13 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Shared\InfoUtilisateur.razor"
                                  user.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(17, "h4");
            __builder.AddAttribute(18, "class", "mb-0");
#nullable restore
#line 14 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Shared\InfoUtilisateur.razor"
__builder.AddContent(19, user.Nom);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "p");
#nullable restore
#line 16 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Shared\InfoUtilisateur.razor"
__builder.AddContent(22, user.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "h5");
#nullable restore
#line 17 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Shared\InfoUtilisateur.razor"
__builder.AddContent(25, user.NumeroDeTelephone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Shared\InfoUtilisateur.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Shared\InfoUtilisateur.razor"
             
    protected override async Task OnInitializedAsync()
    {
        await ClientService.LoadClients();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientService ClientService { get; set; }
    }
}
#pragma warning restore 1591
