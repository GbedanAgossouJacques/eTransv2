#pragma checksum "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe574a20aa310b7e1778e52dd4fe9811331dc29"
// <auto-generated/>
#pragma warning disable 1591
namespace eTrans.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/historique")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Historique des transports</h1>");
#nullable restore
#line 9 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor"
 if (TransportService.Transports == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Identifiant</th>\r\n                <th>Date de commande</th>\r\n                <th>Distance</th>\r\n                <th>Prix</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 25 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor"
             foreach (var transport in TransportService.Transports)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 28 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor"
__builder.AddContent(8, transport.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 29 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor"
__builder.AddContent(11, transport.Datecommande);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 30 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor"
__builder.AddContent(14, transport.Distance);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 31 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor"
__builder.AddContent(17, transport.Prix);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\FetchData.razor"
       

    protected override async Task OnInitializedAsync()
    {
        await TransportService.LoadTransports();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITransportService TransportService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
