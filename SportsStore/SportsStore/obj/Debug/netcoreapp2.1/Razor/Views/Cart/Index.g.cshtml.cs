#pragma checksum "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Cart/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71f2f653ef0fe63d7b671d23ef92ad99ac675501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 3 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71f2f653ef0fe63d7b671d23ef92ad99ac675501", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cf74d9e78168fcb2aefa7fe6b3f6bda82b69627", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 296, true);
            WriteLiteral(@"<h2>Your cart</h2>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Quantity</th>
            <th>Item</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 13 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Cart/Index.cshtml"
         foreach (var line in Model.Cart.Lines) {

#line default
#line hidden
            BeginContext(374, 50, true);
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">");
            EndContext();
            BeginContext(425, 13, false);
#line 15 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Cart/Index.cshtml"
                               Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(438, 41, true);
            WriteLiteral("</td>\r\n            <td class=\"text-left\">");
            EndContext();
            BeginContext(480, 17, false);
#line 16 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Cart/Index.cshtml"
                             Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(497, 42, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
            EndContext();
            BeginContext(540, 32, false);
#line 17 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Cart/Index.cshtml"
                              Write(line.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(572, 60, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(634, 50, false);
#line 19 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Cart/Index.cshtml"
            Write((line.Quantity * line.Product.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(685, 35, true);
            WriteLiteral("\r\n            </td>\r\n        </tr> ");
            EndContext();
#line 21 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Cart/Index.cshtml"
              }

#line default
#line hidden
            BeginContext(723, 154, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(878, 44, false);
#line 27 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Cart/Index.cshtml"
           Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(922, 117, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1039, "\"", 1062, 1);
#line 33 "/Users/vaibhavdeoda/Projects/SportsStore/SportsStore/SportsStore/Views/Cart/Index.cshtml"
WriteAttributeValue("", 1046, Model.ReturnUrl, 1046, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1063, 30, true);
            WriteLiteral(">Continue shopping</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591