#pragma checksum "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Shared/ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65c033b28c857ddfee463ebab7fbca1f5a7c2949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ProductSummary.cshtml", typeof(AspNetCore.Views_Shared_ProductSummary))]
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
#line 1 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#line 2 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c033b28c857ddfee463ebab7fbca1f5a7c2949", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d02e1652a955861aa4ebf44ba769d870b1c8b28", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 109, true);
            WriteLiteral("\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-1\">\r\n        <h4>\r\n            ");
            EndContext();
            BeginContext(126, 10, false);
#line 6 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Shared/ProductSummary.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(136, 81, true);
            WriteLiteral("\r\n            <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n");
            EndContext();
            BeginContext(280, 27, true);
            WriteLiteral("                <small>\"$\" ");
            EndContext();
            BeginContext(308, 11, false);
#line 9 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Shared/ProductSummary.cshtml"
                      Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(319, 89, true);
            WriteLiteral("</small>\r\n            </span>\r\n        </h4>\r\n    </div>\r\n    <div class=\"card-text p-1\">");
            EndContext();
            BeginContext(409, 17, false);
#line 13 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Shared/ProductSummary.cshtml"
                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(426, 16, true);
            WriteLiteral("</div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
