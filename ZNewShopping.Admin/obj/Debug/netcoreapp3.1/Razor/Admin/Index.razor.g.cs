#pragma checksum "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b24d529efe11a95ecfd77021fd1f25dcd5f0179f"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
 if (cars == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Loading...");
#nullable restore
#line 12 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                           
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
   
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.AddAttribute(4, "id", "ProductTable");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "thead");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddMarkupContent(10, "<th>코드</th>\r\n                ");
            __builder.AddMarkupContent(11, "<th>이름</th>\r\n                ");
            __builder.AddMarkupContent(12, "<th>공통코드1</th>\r\n                ");
            __builder.AddMarkupContent(13, "<th>공통코드2</th>\r\n                ");
            __builder.AddMarkupContent(14, "<th>가격</th>\r\n                ");
            __builder.AddMarkupContent(15, "<th>설명</th>\r\n                ");
            __builder.OpenElement(16, "th");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                                                                () => showModal()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "+ 제품추가");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "tbody");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 33 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
             foreach (var car in cars)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 36 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                         car.Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 37 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                         car.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 38 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                         car.Com1Code1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 39 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                         car.Com2Code2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 40 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                         car.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 41 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                         car.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "td");
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-success");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                                                                    () => showModal(@car.Code)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-danger");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                                                                   () => Delete(@car)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 48 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 51 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "\r\n");
            __builder.OpenComponent<ZNewShopping.Admin.Admin.Modal>(65);
            __builder.AddAttribute(66, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 53 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                ClickHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(67, "isCreate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                                                          isCreate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(68, (__value) => {
#nullable restore
#line 53 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
                                    EditModal = (ZNewShopping.Admin.Admin.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\Git\Study\ZNewShopping.Admin\Admin\Index.razor"
 

    List<Product> cars = new List<Product>();
    int intValue;
    Modal EditModal;
    string id = "#ProductTable";
    string isCreate;

    async Task Delete(Product product)
    {
        bool confirmed = await JSRuntime.InvokeAsync<bool>("confirm", "삭제하시겠습니까?");
        if (confirmed)
        {
            pro.DeleteProduct(product);
            cars = pro.GetProductList();
        }
    }

    private void showModal(int code = 0)
    {
        if (code == 0)
            isCreate = "C";
        else
            isCreate = "U";
        EditModal.showModal(code);
    }

    void ClickHandler()
    {
        cars = pro.GetProductList();
    }

    /**************************************************************************************************/
    /**************************************************************************************************/
    /**************************************************************************************************/

    protected override void OnInitialized()
    {
        cars = pro.GetProductList();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("TestDataTablesAdd", id);
    }
    void IDisposable.Dispose()
    {
        JSRuntime.InvokeVoidAsync("TestDataTablesRemove", id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductBLL pro { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
