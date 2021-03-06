#pragma checksum "D:\Git\Study\ZNewShopping.Admin\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47aca1dc6dc2dbcd6d9ee92f92a2a0a790dbea2d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "D:\Git\Study\ZNewShopping.Admin\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Git\Study\ZNewShopping.Admin\Pages\Index.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\Git\Study\ZNewShopping.Admin\Pages\Index.razor"
 
    ElementReference inputReference;
    string message = string.Empty;
    string imagePath = null;

    string fileName = string.Empty;
    string type = string.Empty;
    string size = string.Empty;

    Stream fileStream = null;

    async Task OpenFileAsync()
    {
        // Read the files
        var file = (await fileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

        if (file == null)
            return;

        // Get the info of that files
        var fileInfo = await file.ReadFileInfoAsync();
        fileName = fileInfo.Name;
        size = $"{fileInfo.Size}b";
        type = fileInfo.Type;

        using (var ms = await file.CreateMemoryStreamAsync((int)fileInfo.Size))
        {
            fileStream = new MemoryStream(ms.ToArray());
        }
    }

    async Task UploadFileAsync()
    {

        // Create the content
        var file = new MultipartFormDataContent();
        file.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");

        file.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName);//파라미터지정

        //string url = "http://3.34.209.209:8000"
        string url = "https://localhost:44309";

        var response = await client.PostAsync($"{url}/api/upload", file);

        if (response.IsSuccessStatusCode)
        {
            var uploadedFileName = await response.Content.ReadAsStringAsync();
            imagePath = $"{url}/{uploadedFileName}";
            message = "File has been uploaded successfully!";
        }
        else
        {
            message = "File has been filed";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReader { get; set; }
    }
}
#pragma warning restore 1591
