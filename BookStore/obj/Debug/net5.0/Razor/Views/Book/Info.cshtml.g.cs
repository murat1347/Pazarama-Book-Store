#pragma checksum "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf78eebf320ccd42e616ec2e3ec6d12d8c65e601"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Info), @"mvc.1.0.view", @"/Views/Book/Info.cshtml")]
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
#line 1 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf78eebf320ccd42e616ec2e3ec6d12d8c65e601", @"/Views/Book/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml"
  
    ViewData["Title"] = "Info";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml"
 foreach (var x in Model)
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"align-items-md-center\"> <h1>");
#nullable restore
#line 12 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml"
                                       Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n   <img width=\"300px\" height=\"500px\"  title=\" \" alt=\" \"");
            BeginWriteAttribute("src", " src=\"", 242, "\"", 267, 2);
            WriteAttributeValue("", 248, "/images/", 248, 8, true);
#nullable restore
#line 14 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml"
WriteAttributeValue("", 256, x.ImageUrl, 256, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n   <p><b>Descripton:</b></p> \r\n    <p>");
#nullable restore
#line 17 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml"
  Write(x.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>NAME</th>\r\n            <th>PRICE</th>\r\n            <th>STOCK</th>\r\n        </tr>\r\n    \r\n        <tr>\r\n            <th>");
#nullable restore
#line 28 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml"
           Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 29 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml"
           Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 30 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml"
           Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 31 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml"
           Write(x.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 34 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\Info.cshtml"
}

#line default
#line hidden
#nullable disable
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