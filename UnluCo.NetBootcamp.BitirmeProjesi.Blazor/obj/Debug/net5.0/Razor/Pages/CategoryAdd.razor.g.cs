#pragma checksum "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\CategoryAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac932be52901c30f8e734438ac93f76e4a6c3dcd"
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
#line 3 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\CategoryAdd.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\CategoryAdd.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoryadd")]
    public partial class CategoryAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\CategoryAdd.razor"
                  category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\CategoryAdd.razor"
                                            Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "p");
                __builder2.AddMarkupContent(7, "<label for=\"CategoryName\">Kategori Adı:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "id", "CategoryName");
                __builder2.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\CategoryAdd.razor"
                                                  category.CategoryName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category.CategoryName = __value, category.CategoryName))));
                __builder2.AddAttribute(12, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => category.CategoryName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __Blazor.UnluCo.NetBootcamp.BitirmeProjesi.Blazor.Pages.CategoryAdd.TypeInference.CreateValidationMessage_0(__builder2, 14, 15, 
#nullable restore
#line 13 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\CategoryAdd.razor"
                                () => category.CategoryName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    \r\n    ");
                __builder2.AddMarkupContent(17, "<button type=\"submit\">Kategori Ekle</button>\r\n\r\n    ");
                __builder2.OpenElement(18, "h3");
                __builder2.AddContent(19, 
#nullable restore
#line 18 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\CategoryAdd.razor"
         result

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\CategoryAdd.razor"
       

    public CreateCategoryModel category= new();
    public string result;
   
    private async Task Submit()
    {
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        HttpClient client = new HttpClient(clientHandler);

        var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44301/api/Category");

        request.Content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");

        var token = await Storage.GetAsync<string>("token");

        request.Headers.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);

        var tokenResponse = await client.SendAsync(request);

        var jsonResult = await tokenResponse.Content.ReadFromJsonAsync<ResultModel>();
        result = jsonResult.Message;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage Storage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
namespace __Blazor.UnluCo.NetBootcamp.BitirmeProjesi.Blazor.Pages.CategoryAdd
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
