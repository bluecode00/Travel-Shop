#pragma checksum "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "748070415ef5c4f9e614e5eeb9a71639d9bbf21d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
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
#line 2 "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\_ViewImports.cshtml"
using TravelShop.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\_ViewImports.cshtml"
using TravelShop.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\_ViewImports.cshtml"
using TravelShop.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\_ViewImports.cshtml"
using TravelShop.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"748070415ef5c4f9e614e5eeb9a71639d9bbf21d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bce10f8ab86db8e2384c4ae647920752d24c571", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\Home\Index.cshtml"
             foreach (var product in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 12 "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\Home\Index.cshtml"
               Write(await Html.PartialAsync("_Product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 15 "C:\Users\Wissen\Desktop\Projeler\TravelShop\TravelShop\TravelShop.WebUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
