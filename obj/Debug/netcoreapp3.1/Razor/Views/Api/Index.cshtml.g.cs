#pragma checksum "C:\Users\matth\source\repos\velov\Views\Api\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e292a13b3e3d747f1b114df4d33e057675172fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Api_Index), @"mvc.1.0.view", @"/Views/Api/Index.cshtml")]
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
#line 1 "C:\Users\matth\source\repos\velov\Views\_ViewImports.cshtml"
using velov;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matth\source\repos\velov\Views\_ViewImports.cshtml"
using velov.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e292a13b3e3d747f1b114df4d33e057675172fa", @"/Views/Api/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1019ed498a9c6d85c90f490d272bf492cfc88dbc", @"/Views/_ViewImports.cshtml")]
    public class Views_Api_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\matth\source\repos\velov\Views\Api\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matth\source\repos\velov\Views\Api\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 6 "C:\Users\matth\source\repos\velov\Views\Api\Index.cshtml"
  Write(item.pole);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <ul>\r\n        <li>available bikes : ");
#nullable restore
#line 8 "C:\Users\matth\source\repos\velov\Views\Api\Index.cshtml"
                         Write(item.available_bikes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>address : ");
#nullable restore
#line 9 "C:\Users\matth\source\repos\velov\Views\Api\Index.cshtml"
                 Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n");
#nullable restore
#line 11 "C:\Users\matth\source\repos\velov\Views\Api\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
