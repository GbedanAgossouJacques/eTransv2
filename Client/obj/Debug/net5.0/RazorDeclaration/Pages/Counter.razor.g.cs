// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/transport")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Gbedan Jacques\Desktop\ProjetGenieLogiciel\Application\2019\eTrans\Client\Pages\Counter.razor"
       

    protected override async Task OnInitializedAsync()
    {

        if (ChauffeurService.Chauffeurs == null || ChauffeurService.Chauffeurs.Count == 0)
        {
            await ChauffeurService.LoadChauffeurs();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChauffeurService ChauffeurService { get; set; }
    }
}
#pragma warning restore 1591
