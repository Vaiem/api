#pragma checksum "C:\Users\User\source\repos\ReservateAPI\ReservateAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8414cb7720252c3989ec46d8a96b5bad95691ce3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\User\source\repos\ReservateAPI\ReservateAPI\Views\_ViewImports.cshtml"
using ReservateAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8414cb7720252c3989ec46d8a96b5bad95691ce3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b654516ae84500cb629a9655b99bf8fa2e5efb19", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Resrvation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\source\repos\ReservateAPI\ReservateAPI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Reservations";
    

#line default
#line hidden
            BeginContext(86, 204, true);
            WriteLiteral("<button style=\"margin-left:20px;\" class=\"btn btn-primary\">APi</button>\r\n<table class=\"table\">\r\n    <tbody>\r\n        <tr>\r\n            <th>Number</th>\r\n            <th>Name</th>\r\n        </tr>\r\n       \r\n\r\n");
            EndContext();
#line 15 "C:\Users\User\source\repos\ReservateAPI\ReservateAPI\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(339, 36, true);
            WriteLiteral("           <tr>\r\n               <td>");
            EndContext();
            BeginContext(376, 16, false);
#line 18 "C:\Users\User\source\repos\ReservateAPI\ReservateAPI\Views\Home\Index.cshtml"
              Write(item?.AutoNumber);

#line default
#line hidden
            EndContext();
            BeginContext(392, 26, true);
            WriteLiteral("</td>\r\n               <td>");
            EndContext();
            BeginContext(419, 16, false);
#line 19 "C:\Users\User\source\repos\ReservateAPI\ReservateAPI\Views\Home\Index.cshtml"
              Write(item?.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(435, 25, true);
            WriteLiteral("</td>\r\n           </tr>\r\n");
            EndContext();
#line 21 "C:\Users\User\source\repos\ReservateAPI\ReservateAPI\Views\Home\Index.cshtml"
        } 

#line default
#line hidden
            BeginContext(472, 57, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n        <h2>Reservations</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Resrvation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
