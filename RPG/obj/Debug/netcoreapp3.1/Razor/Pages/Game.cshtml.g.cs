#pragma checksum "C:\Users\Aspir\OneDrive\Plocha\RPG_Game\RPG\Pages\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cf7640cc069ea99deb903dce0ef0e0cc24db825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RPG.Pages.Pages_Game), @"mvc.1.0.razor-page", @"/Pages/Game.cshtml")]
namespace RPG.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Aspir\OneDrive\Plocha\RPG_Game\RPG\Pages\_ViewImports.cshtml"
using RPG;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf7640cc069ea99deb903dce0ef0e0cc24db825", @"/Pages/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f55bdca3dc11af8930e175bf7ae226956281f648", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Game : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Aspir\OneDrive\Plocha\RPG_Game\RPG\Pages\Game.cshtml"
  
    ViewData["Title"] = "Game";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <p>");
#nullable restore
#line 8 "C:\Users\Aspir\OneDrive\Plocha\RPG_Game\RPG\Pages\Game.cshtml"
      Write(Model.Game.Player.CurrentPlace.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 9 "C:\Users\Aspir\OneDrive\Plocha\RPG_Game\RPG\Pages\Game.cshtml"
         foreach (string place in Model.Game.Player.CurrentPlace.TravelPsb)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 11 "C:\Users\Aspir\OneDrive\Plocha\RPG_Game\RPG\Pages\Game.cshtml"
          Write(place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\Aspir\OneDrive\Plocha\RPG_Game\RPG\Pages\Game.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RPG.Pages.GameModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RPG.Pages.GameModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RPG.Pages.GameModel>)PageContext?.ViewData;
        public RPG.Pages.GameModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
