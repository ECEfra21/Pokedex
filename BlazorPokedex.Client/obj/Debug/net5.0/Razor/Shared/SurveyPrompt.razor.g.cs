#pragma checksum "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Shared\SurveyPrompt.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "214960f9237b524914a1d23ce57413632494014d28e84e28c88a7e3d81998676"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPokedex.Client.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using BlazorPokedex.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using BlazorPokedex.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class SurveyPrompt : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "<span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(4, "strong");
#nullable restore
#line 3 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Shared\SurveyPrompt.razor"
__builder.AddContent(5, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2137916\">brief survey</a></span>\r\n    and tell us what you think.\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
