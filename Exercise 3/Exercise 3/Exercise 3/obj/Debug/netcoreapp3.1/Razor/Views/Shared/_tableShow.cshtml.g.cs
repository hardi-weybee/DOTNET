#pragma checksum "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\Shared\_tableShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "186eb1b14fae5c15fa26b0ee8573659a77f9f91c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__tableShow), @"mvc.1.0.view", @"/Views/Shared/_tableShow.cshtml")]
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
#line 1 "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\_ViewImports.cshtml"
using Exercise_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\_ViewImports.cshtml"
using Exercise_3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186eb1b14fae5c15fa26b0ee8573659a77f9f91c", @"/Views/Shared/_tableShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e987492596a5431b18ecd0d9bfca4492e44db743", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__tableShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InvoiceModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""py-5"">
    <div class=""container"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Party Name</th>
                    <th scope=""col"">Product Name</th>
                    <th scope=""col"">Rate Of Product</th>
                    <th scope=""col"">Quantity</th>
                    <th scope=""col"">Total</th>
                </tr>
            </thead>

");
#nullable restore
#line 17 "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\Shared\_tableShow.cshtml"
             foreach (var assign in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 21 "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\Shared\_tableShow.cshtml"
                                       Write(assign.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 22 "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\Shared\_tableShow.cshtml"
                           Write(assign.PartyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 23 "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\Shared\_tableShow.cshtml"
                           Write(assign.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\Shared\_tableShow.cshtml"
                           Write(assign.CurrentRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\Shared\_tableShow.cshtml"
                           Write(assign.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\Shared\_tableShow.cshtml"
                           Write(assign.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 29 "D:\.net\.net\Exercise 3\Exercise 3\Exercise 3\Views\Shared\_tableShow.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>        \r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InvoiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
