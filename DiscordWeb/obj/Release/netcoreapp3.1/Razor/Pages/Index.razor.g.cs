#pragma checksum "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f671ac9c2e4825a64c2885ba7bf022e00fee6ca"
// <auto-generated/>
#pragma warning disable 1591
namespace DiscordWeb.Pages
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
#nullable restore
#line 3 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row bg-light");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-bordered");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "colgroup");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 11 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
             if (string.IsNullOrEmpty(channel))
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "            <col style=\"width:10%\">\r\n");
#nullable restore
#line 14 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "            <col style=\"width:10%\">\r\n            <col style=\"width:60%\">\r\n            <col style=\"width:30%\">\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "thead");
            __builder.AddAttribute(12, "class", "thead-dark");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 21 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                 if (string.IsNullOrEmpty(channel))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.AddMarkupContent(17, "<th>Channel</th>\r\n");
#nullable restore
#line 24 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                ");
            __builder.AddMarkupContent(19, "<th>Username</th>\r\n                ");
            __builder.AddMarkupContent(20, "<th>Message</th>\r\n                ");
            __builder.AddMarkupContent(21, "<th>Links</th>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "tbody");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 31 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
             if (entries.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                 foreach (var entry in entries)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                    ");
            __builder.OpenElement(27, "tr");
            __builder.AddAttribute(28, "title", 
#nullable restore
#line 35 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                                entry.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 36 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                         if (string.IsNullOrEmpty(channel))
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 38 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                                 entry.ChannelName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 39 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                        ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 40 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                             entry.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "href", 
#nullable restore
#line 41 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                                      entry.MessageLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, 
#nullable restore
#line 41 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                                                          entry.Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "td");
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 43 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                             foreach (var link in GetLinks(entry.ChannelName, entry.Message))
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                                ");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "href", 
#nullable restore
#line 45 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                                          link.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "target", "_blank");
            __builder.AddContent(49, " ");
            __builder.AddContent(50, 
#nullable restore
#line 45 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                                                                        link.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 46 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 49 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "            ");
            __builder.AddMarkupContent(56, "<tr><td colspan=\"6\"><strong>No entries available</strong></td></tr>\r\n");
#nullable restore
#line 54 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\quiet\source\repos\DiscordWeb\DiscordWeb\Pages\Index.razor"
       

    List<DiscordEntry> entries = new List<DiscordEntry>();
    string channel = "";

    protected override async Task OnInitializedAsync()
    {
        GetQueryStringValues();
        NavManager.LocationChanged += HandleLocationChanged;
        await RefreshDiscordEntries();
    }

    async void HandleLocationChanged(object sender, LocationChangedEventArgs e)
    {
        GetQueryStringValues();
        await RefreshDiscordEntries();
        StateHasChanged();
    }

    void GetQueryStringValues()
    {
        var uri = NavManager.ToAbsoluteUri(NavManager.Uri);
        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("channel", out var _channel))
        {
            channel = Convert.ToString(_channel);
        }
    }

    private async Task RefreshDiscordEntries()
    {
        entries = await service.GetDiscordEntriesByChannelAsync(channel);
    }

    public void Dispose()
    {
        NavManager.LocationChanged -= HandleLocationChanged;
    }

    public Dictionary<string, string> GetLinks(string channelName, string message)
    {
        var result = new Dictionary<string, string>();

        if (channelName.ToLower().Contains("book"))
        {
            result.Add("google", "https://www.google.co.il/search?tbm=bks&hl=en&q=" + HttpUtility.UrlEncode(message));
            result.Add("amazon", "https://www.amazon.com/s?i=stripbooks-intl-ship&k=" + HttpUtility.UrlEncode(message));
            result.Add("libgen", "http://gen.lib.rus.ec/search.php?req=" + HttpUtility.UrlEncode(message));
            result.Add("zlibrary", "https://b-ok.asia/s/?q=" + HttpUtility.UrlEncode(message));
        }
        if (channelName.ToLower().Contains("movie"))
        {
            result.Add("imdb", "https://www.imdb.com/find?q=" + HttpUtility.UrlEncode(message));
        }
        if (channelName.ToLower().Contains("tv") || channelName.ToLower().Contains("show"))
        {
            result.Add("tvdb", "https://thetvdb.com/search?query=" + HttpUtility.UrlEncode(message));
        }

        return result;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DiscordDAL service { get; set; }
    }
}
#pragma warning restore 1591
