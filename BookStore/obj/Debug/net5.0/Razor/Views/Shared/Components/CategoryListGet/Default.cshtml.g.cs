#pragma checksum "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Shared\Components\CategoryListGet\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c9aba5570289a20be3fd3a20c9459ebd2fc49b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryListGet_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryListGet/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c9aba5570289a20be3fd3a20c9459ebd2fc49b2", @"/Views/Shared/Components/CategoryListGet/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryListGet_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookStore.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"collapse navbar-collapse\" id=\"bs-megadropdown-tabs\">\r\n    <ul class=\"nav navbar-nav nav_1\">\r\n");
#nullable restore
#line 5 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Shared\Components\CategoryListGet\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 221, "\"", 262, 2);
            WriteAttributeValue("", 228, "/Category/CategoryDetails/", 228, 26, true);
#nullable restore
#line 7 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Shared\Components\CategoryListGet\Default.cshtml"
WriteAttributeValue("", 254, item.ID, 254, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Shared\Components\CategoryListGet\Default.cshtml"
                                                        Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 8 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Shared\Components\CategoryListGet\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookStore.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
