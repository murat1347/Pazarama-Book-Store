#pragma checksum "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe66a0ecd0cfc3ef1fad5b73f09d1b778fe90d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe66a0ecd0cfc3ef1fad5b73f09d1b778fe90d7", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Category List</h1>\r\n<br/>\r\n");
#nullable restore
#line 10 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        FoodName: ");
#nullable restore
#line 14 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
             Write(Html.TextBox("p"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Find\"/>\r\n    </p>\r\n");
#nullable restore
#line 17 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>CATEGORY NAME</th>\r\n        <th>Status</th>\r\n        <th>DELETE</th>\r\n        <th>UPDATE</th>\r\n    </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 29 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
           Write(x.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 30 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
           Write(x.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 31 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
           Write(x.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 667, "\"", 704, 2);
            WriteAttributeValue("", 674, "/Category/CategoryDelete/", 674, 25, true);
#nullable restore
#line 32 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
WriteAttributeValue("", 699, x.ID, 699, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">DELETE</a></th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 764, "\"", 798, 2);
            WriteAttributeValue("", 771, "/Category/CategoryGet/", 771, 22, true);
#nullable restore
#line 33 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
WriteAttributeValue("", 793, x.ID, 793, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">UPDATE</a></th>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Category/CategoryAdd\" class=\"btn btn-success\">NEW CATEGORY</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
