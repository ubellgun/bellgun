#pragma checksum "C:\Users\yu\source\repos\NetCore.Web\Views\Membership\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1153951175271d2317de80a6254397840e424552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Membership_Index), @"mvc.1.0.view", @"/Views/Membership/Index.cshtml")]
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
#line 1 "C:\Users\yu\source\repos\NetCore.Web\Views\_ViewImports.cshtml"
using NetCore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yu\source\repos\NetCore.Web\Views\_ViewImports.cshtml"
using NetCore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yu\source\repos\NetCore.Web\Views\_ViewImports.cshtml"
using NetCore.Data.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1153951175271d2317de80a6254397840e424552", @"/Views/Membership/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59ea6c56e5655097cd1a119e9f07c967221b761d", @"/Views/_ViewImports.cshtml")]
    public class Views_Membership_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\yu\source\repos\NetCore.Web\Views\Membership\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\yu\source\repos\NetCore.Web\Views\Membership\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"test-info\">");
#nullable restore
#line 8 "C:\Users\yu\source\repos\NetCore.Web\Views\Membership\Index.cshtml"
                  Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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