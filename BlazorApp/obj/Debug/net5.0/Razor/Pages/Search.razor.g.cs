#pragma checksum "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/Pages/Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c444a105b4d27f55bd6289c6ca9cb509a05a807a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/runner/Zhiostkaia-viorstka-saita/BlazorApp/_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Поиск</h1>\n\n    ");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "size", "1");
            __builder.AddAttribute(3, "style", "width:1045px;height:40px;margin-bottom: 30px;");
            __builder.OpenElement(4, "option");
            __builder.AddAttribute(5, "value", "h1");
            __builder.AddMarkupContent(6, "футбол");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", "h2");
            __builder.AddMarkupContent(10, "хоккей");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", "h3");
            __builder.AddMarkupContent(14, "сноуборд");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "h4");
            __builder.AddMarkupContent(18, "аниме");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n        ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "h5");
            __builder.AddMarkupContent(22, "игра на гитаре");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n        ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "h6");
            __builder.AddMarkupContent(26, "стартапы");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n\n    ");
            __builder.AddMarkupContent(28, "<button type=\"submit\" style=\"float: right; width:100px;height:40px\">Найти похожее</button>\n    ");
            __builder.AddMarkupContent(29, "<button type=\"submit\" style=\"float: right; width:100px;height:40px\">Поиск</button>\n\n\n");
            __builder.AddMarkupContent(30, @"<div style=""display: flex;""><article style=""background-color: gray;border-radius: 30px;padding: 25px;width:390px;height:300px;margin-bottom: 10px;margin-right: 10px;"">ajyfdahfdaghfd</article>
  <article style=""background-color: gray;border-radius: 30px;padding: 25px;width:390px;height:300px;margin-bottom: 10px;margin-right: 10px;"">ajyfdahfdaghfd</article>
  <article style=""background-color: gray;border-radius: 30px;padding: 25px;width:390px;height:300px;margin-bottom: 10px;margin-right: 10px;"">ajyfdahfdaghfd</article></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591