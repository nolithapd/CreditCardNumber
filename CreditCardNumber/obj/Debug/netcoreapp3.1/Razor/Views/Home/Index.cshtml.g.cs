#pragma checksum "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793133f4e82a7c34aeb734431d5a3c1c94ff22e6"
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
#line 1 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\_ViewImports.cshtml"
using CreditCardNumber;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\_ViewImports.cshtml"
using CreditCardNumber.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793133f4e82a7c34aeb734431d5a3c1c94ff22e6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e2988de65d10d18a1216c4dfe32e7f40ade3e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CreditCardNumber.Models.CreditCardModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml"
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-5\">Welcome to the Credit card application</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Enter Credit Card Number:  ");
#nullable restore
#line 12 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml"
                             Write(Html.TextBox("creditCardNumber"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n");
            WriteLiteral("     <input type=\"submit\" name=\"submit\" />\r\n");
            WriteLiteral("        <div>\r\n            <h3><strong>");
#nullable restore
#line 17 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml"
                   Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n               Credit Card Number\r\n            </th>\r\n            <th>\r\n                Credit Card Type\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreditCardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CardType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\portiad\Source\Repos\CreditCardNumber\CreditCardNumber\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CreditCardNumber.Models.CreditCardModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
