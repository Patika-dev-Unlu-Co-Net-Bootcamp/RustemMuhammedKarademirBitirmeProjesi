// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UnluCo.NetBootcamp.BitirmeProjesi.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using UnluCo.NetBootcamp.BitirmeProjesi.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using UnluCo.NetBootcamp.BitirmeProjesi.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using Blazor.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using UnluCo.NetBootcamp.BitirmeProjesi.Application.SecurityOperations.JWT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using UnluCo.NetBootcamp.BitirmeProjesi.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\_Imports.razor"
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
