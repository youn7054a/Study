#pragma checksum "D:\Git\Study\ZNewShopping.Admin\Admin\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "235bde4a46e692a02395b29cebfc44aa3ff34740"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ZNewShopping.Admin.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using ZNewShopping.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using ZNewShopping.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using SHOP.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using SHOP.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Git\Study\ZNewShopping.Admin\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Edit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Edit/{code}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Git\Study\ZNewShopping.Admin\Admin\Edit.razor"
       
    [Parameter]
    public int Code { get; set; }


    protected override void OnInitialized()
    {

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
