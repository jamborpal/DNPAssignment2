#pragma checksum "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a622791c2f807c17b6d88651b610e0ebc3cedc95"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssignment2.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<DNPAssignment2.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "content px-4");
            __builder.OpenElement(8, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n        ");
            __builder.AddContent(10, 
#nullable restore
#line 11 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591