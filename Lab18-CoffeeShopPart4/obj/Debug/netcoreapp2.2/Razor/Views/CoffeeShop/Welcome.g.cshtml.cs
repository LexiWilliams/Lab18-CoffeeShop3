#pragma checksum "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5623efe127ab09786afd62d241d557ca03e5bb7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoffeeShop_Welcome), @"mvc.1.0.view", @"/Views/CoffeeShop/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoffeeShop/Welcome.cshtml", typeof(AspNetCore.Views_CoffeeShop_Welcome))]
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
#line 1 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\_ViewImports.cshtml"
using Lab18_CoffeeShopPart4;

#line default
#line hidden
#line 2 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\_ViewImports.cshtml"
using Lab18_CoffeeShopPart4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5623efe127ab09786afd62d241d557ca03e5bb7b", @"/Views/CoffeeShop/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ac7eadd4c9fc1b39201b74208049d913e52a30", @"/Views/_ViewImports.cshtml")]
    public class Views_CoffeeShop_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab18_CoffeeShopPart4.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(45, 22, true);
            WriteLiteral("\r\n<h1>Welcome</h1>\r\n\r\n");
            EndContext();
            BeginContext(109, 273, true);
            WriteLiteral(@"
<table class=""table"">
    <tr>
        <th>Email</th>
        <th>FirstName</th>
        <th>LastName</th>
        <th>Password</th>
        <th>Dob</th>
        <th>Gender</th>
        <th>ZipCode</th>
        <th>Funds</th>
    </tr>

    <tr>
        <td>");
            EndContext();
            BeginContext(383, 11, false);
#line 23 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Welcome.cshtml"
       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(394, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(414, 15, false);
#line 24 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Welcome.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(429, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(449, 14, false);
#line 25 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Welcome.cshtml"
       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(463, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(483, 14, false);
#line 26 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Welcome.cshtml"
       Write(Model.Password);

#line default
#line hidden
            EndContext();
            BeginContext(497, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(517, 9, false);
#line 27 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Welcome.cshtml"
       Write(Model.Dob);

#line default
#line hidden
            EndContext();
            BeginContext(526, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(546, 12, false);
#line 28 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Welcome.cshtml"
       Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(558, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(578, 13, false);
#line 29 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Welcome.cshtml"
       Write(Model.ZipCode);

#line default
#line hidden
            EndContext();
            BeginContext(591, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(611, 11, false);
#line 30 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Welcome.cshtml"
       Write(Model.Funds);

#line default
#line hidden
            EndContext();
            BeginContext(622, 78, true);
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>\r\n        </td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab18_CoffeeShopPart4.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591