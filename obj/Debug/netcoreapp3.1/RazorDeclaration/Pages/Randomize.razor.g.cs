// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNPAssignment2.Pages
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
#line 2 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Pages\Randomize.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Pages\Randomize.razor"
using Assignment2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Randomize")]
    public partial class Randomize : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\jambo\Desktop\DNPAssignment2-ac2ac2232a887bcef0a52122d165cfbffe2e0060\Pages\Randomize.razor"
       
    IList<Adult> adults = new List<Adult>();
    Adult adult = new Adult();
    string color = "#000000";

    protected override async Task OnInitializedAsync()
    {
        adults = await AdultService.GetAdultsAsync();
        adult = Randomizing();
        switch (adult.Sex)
        {
            case "M":
                color = "#87cefa";
                break;
            case "F":
                color = "#ffbcd9";
                break;
        }
    }

    private Adult Randomizing()
    {
        var random = new Random();
        int index = random.Next(adults.Count);
        return adults[index];
    }

    private void refresh()
    {
        NavigationManager.NavigateTo("/Randomize",true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
