#pragma checksum "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bd5fec1664b7bbf9e6f5d68c73c7ca3a76acb24"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 3 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor"
 if(categories is not null)
{   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, "<tr><th>S/N</th>\r\n            <th>Kategoriler</th></tr>\r\n        <hr>");
#nullable restore
#line 17 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor"
     foreach (var category in categories)
    {   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "tr");
            __builder.OpenElement(4, "th");
            __builder.AddContent(5, 
#nullable restore
#line 20 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor"
                 counter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "th");
            __builder.AddContent(8, 
#nullable restore
#line 21 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor"
                 category.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor"
        counter++;
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 27 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor"
     result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Categories.razor"
       

    protected List<CategoriesViewModel> categories = new List<CategoriesViewModel>();
    private int counter=1;
    public string result;
    protected override async Task OnInitializedAsync()
    {
        counter = 1;
        result = "";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        HttpClient client = new HttpClient(clientHandler);

        var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44301/api/Category");

        var token = await Storage.GetAsync<string>("token");

        request.Headers.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);

        var response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            categories = await response.Content.ReadFromJsonAsync<List<CategoriesViewModel>>();
        }
        else
        {
            categories.Clear();
            var jsonResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            result = jsonResult.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage Storage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
