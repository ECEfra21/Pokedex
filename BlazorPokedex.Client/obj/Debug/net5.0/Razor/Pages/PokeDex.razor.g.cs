#pragma checksum "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dcd456dffa9ffd1bda6beb911010c9099b690672ff642748243d17baeef06431"
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
#line 2 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor"
using BlazorPokedex.Model.peager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor"
using BlazorPokedex.Model.pokemon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor"
using BlazorPokedex.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor"
using Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class PokeDex : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col");
            __builder.OpenComponent<global::BlazorPokedex.Client.Pages.Pagination>(5);
            __builder.AddAttribute(6, "Metadata", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::BlazorPokedex.Model.peager.PaginationMetadata>(
#nullable restore
#line 12 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor"
                                  Paginacion

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "Spred", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 12 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor"
                                                     5

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "SelectPage", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 12 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor"
                                                                    SelectedPage

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenComponent<global::BlazorPokedex.Client.Pages.PokemonGrid>(10);
            __builder.AddAttribute(11, "Pokemons", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<BlazorPokedex.Model.pokemon.Pokemon>>(
#nullable restore
#line 15 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor"
                           Pokemons

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "NumbersRows", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 15 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor"
                                                  5

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Desarrollo\Net\BlazorPokedex\BlazorPokedex.Client\Pages\PokeDex.razor"
       

    public List<Pokemon> Pokemons { get; set; }
    public PaginationMetadata Paginacion { get; set; } = new PaginationMetadata();
    public PaginationParameters Parametros { get; set; } = new PaginationParameters();
    public int Spread { get; set; }
    // public int NumbersRows { get; set; } = 5;
    protected override async Task OnInitializedAsync()
    {
        await GetPagerPokemons();
    }
    private async Task SelectedPage(int page)
    {
        Parametros.PageNumber = page;
        await GetPagerPokemons();
    }
    private async Task GetPagerPokemons()
    {
        List<Pokemon> poks = new List<Pokemon>();
        ResultObjetc res =await Client.GetAll(Parametros);
        foreach (Pokemon item in res.Pokemons)
            poks.Add(await Client.Get(item.Name));
        Pokemons = poks;
        Paginacion.Items = res.Count;
        Paginacion.TotalPages = res.Count / Parametros.PageSize;

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPokeApiClient Client { get; set; }
    }
}
#pragma warning restore 1591