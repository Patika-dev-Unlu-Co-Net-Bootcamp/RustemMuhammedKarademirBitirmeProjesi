#pragma checksum "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7d17390a581754f00e2dad4e73688990b445b17"
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
#line 3 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Kay??t</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
                  User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
                                        Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "p");
                __builder2.AddMarkupContent(8, "<label for=\"FirstName\">Ad</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "id", "FirstName");
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
                                               User.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.FirstName = __value, User.FirstName))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __Blazor.UnluCo.NetBootcamp.BitirmeProjesi.Blazor.Pages.Register.TypeInference.CreateValidationMessage_0(__builder2, 15, 16, 
#nullable restore
#line 14 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
                                () => User.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "p");
                __builder2.AddMarkupContent(19, "<label for=\"LastName\">Soyad</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "LastName");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
                                              User.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.LastName = __value, User.LastName))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __Blazor.UnluCo.NetBootcamp.BitirmeProjesi.Blazor.Pages.Register.TypeInference.CreateValidationMessage_1(__builder2, 26, 27, 
#nullable restore
#line 19 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
                                () => User.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenElement(29, "p");
                __builder2.AddMarkupContent(30, "<label for=\"Email\">Email</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "id", "Email");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
                                           User.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Email = __value, User.Email))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __Blazor.UnluCo.NetBootcamp.BitirmeProjesi.Blazor.Pages.Register.TypeInference.CreateValidationMessage_2(__builder2, 37, 38, 
#nullable restore
#line 24 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
                                () => User.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenElement(40, "p");
                __builder2.AddMarkupContent(41, "<label for=\"Password\">??ifre</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "id", "Password");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
                                              User.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Password = __value, User.Password))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __Blazor.UnluCo.NetBootcamp.BitirmeProjesi.Blazor.Pages.Register.TypeInference.CreateValidationMessage_3(__builder2, 48, 49, 
#nullable restore
#line 29 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
                                () => User.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n\r\n    ");
                __builder2.AddMarkupContent(51, "<button type=\"submit\">Kay??t ol</button>\r\n\r\n    ");
                __builder2.OpenElement(52, "h3");
                __builder2.AddContent(53, 
#nullable restore
#line 34 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
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
#line 38 "C:\Users\ruste\source\repos\UnluCo.Egitim\UnluCo.NetBootcamp.BitirmeProjesi\UnluCo.NetBootcamp.BitirmeProjesi.Blazor\Pages\Register.razor"
       

    public UserForRegisterModel User = new();
    public string result;
    private async Task Submit()
    {
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        HttpClient client = new HttpClient(clientHandler);

        var response = await client.PostAsJsonAsync("https://localhost:44301/api/Auth/register", User);
        var jsonResult = await response.Content.ReadFromJsonAsync<ResultModel>();
        result = jsonResult.Message;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage Storage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
namespace __Blazor.UnluCo.NetBootcamp.BitirmeProjesi.Blazor.Pages.Register
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
