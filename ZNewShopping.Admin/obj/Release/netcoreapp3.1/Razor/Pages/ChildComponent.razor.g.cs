#pragma checksum "D:\Git\Study\ZNewShopping.Admin\Pages\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc7d7601b1f7cdb9be74c5993292184540493e04"
// <auto-generated/>
#pragma warning disable 1591
namespace ZNewShopping.Admin.Pages
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
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "panel panel-default");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "panel-heading");
            __builder.AddContent(5, 
#nullable restore
#line 2 "D:\Git\Study\ZNewShopping.Admin\Pages\ChildComponent.razor"
                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel-body");
            __builder.AddContent(9, 
#nullable restore
#line 3 "D:\Git\Study\ZNewShopping.Admin\Pages\ChildComponent.razor"
                             ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\Git\Study\ZNewShopping.Admin\Pages\ChildComponent.razor"
                                              OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\r\n        Trigger a Parent component method\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\Git\Study\ZNewShopping.Admin\Pages\ChildComponent.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClickCallback { get; set; }


    void set()
    {
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
