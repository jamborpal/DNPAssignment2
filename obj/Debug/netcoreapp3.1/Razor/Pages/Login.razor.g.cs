#pragma checksum "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32878bb960036849ce0e9406311aa6b8652db75a"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\_Imports.razor"
using Assignment2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Pages\Login.razor"
using Assignment2.Login;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n     *, ::after, ::before {\n       box-sizing: border-box;\n     }\n     \n     body {\n       \n       }\n       \n     \n     \n</style>\n");
            __builder.OpenElement(1, "body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "form");
                __builder2.AddAttribute(5, "autocomplete", "off");
                __builder2.AddAttribute(6, "class", "form");
                __builder2.AddMarkupContent(7, "<div class=\"control\"><h1>\n                    Please Sign In\n                </h1></div>\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "control block-cube block-input");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "name", "username");
                __builder2.AddAttribute(12, "placeholder", "Username");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Pages\Login.razor"
                                                                                      username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n                ");
                __builder2.AddMarkupContent(17, "<div class=\"bg-top\"><div class=\"bg-inner\"></div></div>\n                ");
                __builder2.AddMarkupContent(18, "<div class=\"bg-right\"><div class=\"bg-inner\"></div></div>\n                ");
                __builder2.AddMarkupContent(19, "<div class=\"bg\"><div class=\"bg-inner\"></div></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "control block-cube block-input");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "name", "password");
                __builder2.AddAttribute(25, "placeholder", "Password");
                __builder2.AddAttribute(26, "type", "password");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Pages\Login.razor"
                                                                                           password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n                ");
                __builder2.AddMarkupContent(30, "<div class=\"bg-top\"><div class=\"bg-inner\"></div></div>\n                ");
                __builder2.AddMarkupContent(31, "<div class=\"bg-right\"><div class=\"bg-inner\"></div></div>\n                ");
                __builder2.AddMarkupContent(32, "<div class=\"bg\"><div class=\"bg-inner\"></div></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n            ");
                __builder2.OpenElement(34, "button");
                __builder2.AddAttribute(35, "class", "btn block-cube block-cube-hover");
                __builder2.AddAttribute(36, "type", "button");
                __builder2.AddMarkupContent(37, "<div class=\"bg-top\"><div class=\"bg-inner\"></div></div>\n                ");
                __builder2.AddMarkupContent(38, "<div class=\"bg-right\"><div class=\"bg-inner\"></div></div>\n                ");
                __builder2.AddMarkupContent(39, "<div class=\"bg\"><div class=\"bg-inner\"></div></div>\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "text");
                __builder2.OpenElement(42, "a");
                __builder2.AddAttribute(43, "href", "");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Pages\Login.razor"
                                         PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(45, "<button class=\"btn btn-outline-dark\" type=\"submit\">Log in</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(46, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "container, space");
                __builder2.AddAttribute(49, "onclick", true);
                __builder2.AddMarkupContent(50, "<div class=\"top\"></div>\n            <div class=\"bottom\"></div>\n\n            ");
                __builder2.AddMarkupContent(51, "<h2>\n                We are sad to see you leave\n            </h2>\n\n            ");
                __builder2.OpenElement(52, "a");
                __builder2.AddAttribute(53, "href", "");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Pages\Login.razor"
                                 PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(55, "<button type=\"submit\">Log out</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            ((CustomAuthentication) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
        }
        catch (Exception e)
        {
            errorMessage = "User is not registered";
        }
    }

    public async Task PerformLogout()
    {
        errorMessage = "";
        username = "";
        password = "";
        try
        {
            ((CustomAuthentication) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/Login");
        }
        catch (Exception e)
        {
        }
    }

    protected override async Task OnInitializedAsync()
    {
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591