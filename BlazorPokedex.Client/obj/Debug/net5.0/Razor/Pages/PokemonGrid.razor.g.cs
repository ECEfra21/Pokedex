#pragma checksum "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8c33819bab9718ecf08e8e3622fdc534a3a46e553eee83d34405835d9f1b1ca0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPokedex.Client.Pages
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
#nullable restore
#line 1 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
using BlazorPokedex.Model.pokemon;

#line default
#line hidden
#nullable disable
    public partial class PokemonGrid : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>PokemonGrid</h3>");
#nullable restore
#line 5 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
 if (Pokemons is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em> Loadin... </em></p>");
#nullable restore
#line 8 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
#nullable restore
#line 12 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
         for (int i = 0; i < NumbersRows; i++)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row sticktDiv");
#nullable restore
#line 15 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                 foreach (Pokemon item in Pokemons.Skip(i * 6).Take(4))
                {
                    if (!(item is null))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card" + " pokeCard" + " mb-4" + " bg-" + (
#nullable restore
#line 19 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                                            item.Types.FirstOrDefault().PokemonType.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h4");
            __builder.AddAttribute(10, "class", "card-title");
#nullable restore
#line 21 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
__builder.AddContent(11, item.Name.ToUpper());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 24 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                           item.Sprite.FrontShiny

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", "img-fluid imagesPoke");
            __builder.AddAttribute(18, "alt", 
#nullable restore
#line 24 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                                                                                      item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(20, "div");
            __builder.OpenElement(21, "fieldset");
            __builder.AddAttribute(22, "title", "Types");
            __builder.OpenElement(23, "ul");
            __builder.AddAttribute(24, "class", "list-group");
#nullable restore
#line 29 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                             foreach (var item2 in item.Types)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "list-group-item" + " d-flex" + " justify-content-between" + " align-items-lg-start" + " bg-" + (
#nullable restore
#line 31 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                                                                                                                    item2.PokemonType.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(27, "span");
            __builder.AddAttribute(28, "class", "badge bg-primary rounded-pill");
#nullable restore
#line 32 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
__builder.AddContent(29, item2.Slot);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                                    ");
            __builder.OpenElement(31, "p");
#nullable restore
#line 33 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
__builder.AddContent(32, item2.PokemonType.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card-footer");
            __builder.OpenElement(36, "div");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "/pokemondetail/" + (
#nullable restore
#line 44 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                                             item.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddContent(40, "Detail");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                    }

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
       
    [Parameter]
    public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
    [Parameter]
    public int NumbersRows { get; set; } = 5;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
