#pragma checksum "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f18899561fb18704b3544d381a9a48ab024d537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_BookGet), @"mvc.1.0.view", @"/Views/Book/BookGet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f18899561fb18704b3544d381a9a48ab024d537", @"/Views/Book/BookGet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_BookGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStore.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
  
    ViewData["Title"] = "BookGet";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>FoodGet</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
 using (Html.BeginForm("BookUpdate", "Book", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 12 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.LabelFor(x=>x.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.TextBoxFor(x=>x.Id,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 16 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.LabelFor(x=>x.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.TextBoxFor(x=>x.Name,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.LabelFor(x=>x.Price));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.TextBoxFor(x=>x.Price,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.LabelFor(x=>x.Stock));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.TextBoxFor(x=>x.Stock,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.LabelFor(x=>x.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.TextBoxFor(x=>x.Description,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.LabelFor(x=>x.ImageUrl));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 31 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.LabelFor(x=>x.Category.CategoryName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryId,(List<SelectListItem>)ViewBag.cat1,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Submit</button>\r\n");
#nullable restore
#line 35 "C:\Users\Murat\source\repos\BookStore\BookStore\Views\Book\BookGet.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591