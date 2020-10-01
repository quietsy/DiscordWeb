#pragma checksum "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "238d5a5f87a061e266e6fe8d91974f0dad7f8b42"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DiscordWeb.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\_Imports.razor"
using DiscordWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\_Imports.razor"
using DiscordWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\_Imports.razor"
using DiscordWeb.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    List<string> channels = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        await RefreshDiscordChannels();
    }

    private async Task RefreshDiscordChannels()
    {
        channels = await service.GetDiscordChannelsAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DiscordDAL service { get; set; }
    }
}
#pragma warning restore 1591