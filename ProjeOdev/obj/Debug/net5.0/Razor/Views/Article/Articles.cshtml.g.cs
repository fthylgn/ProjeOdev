#pragma checksum "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abdfbf9df5c63ec48c266a6127f093f297845e24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Articles), @"mvc.1.0.view", @"/Views/Article/Articles.cshtml")]
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
#line 1 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\_ViewImports.cshtml"
using ProjeOdev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\_ViewImports.cshtml"
using ProjeOdev.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abdfbf9df5c63ec48c266a6127f093f297845e24", @"/Views/Article/Articles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210257964c41310cc652be9d4bdc17e51e617555", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Articles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
  
    ViewData["Title"] = "Articles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Articles</h1>\r\n\r\n\r\n<div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 12 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
      int a = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
     foreach (var item in Model)
    {
        string id = "#collapse" + a;
        string id2 = "collapse" + a;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=", 370, "", 376, 1);
#nullable restore
#line 18 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
WriteAttributeValue("", 374, a, 374, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2 class=\"mb-0\">\r\n                    <button class=\"btn btn-link btn-block text-left\" type=\"button\" data-toggle=\"collapse\" data-target=\"");
#nullable restore
#line 20 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
                                                                                                                  Write(id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 559, "\"", 579, 1);
#nullable restore
#line 20 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
WriteAttributeValue("", 575, id2, 575, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 21 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
                   Write(item.ArticleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </button>\r\n                </h2>\r\n            </div>\r\n            \r\n            <div");
            BeginWriteAttribute("id", " id=\"", 731, "\"", 740, 1);
#nullable restore
#line 26 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
WriteAttributeValue("", 736, id2, 736, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingOne\" data-parent=\"#accordionExample\">\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 28 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
                     foreach (var p in item.Paragraphs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 30 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
                      Write(p.ParagraphText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
                      item.ArticleID = a;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 34 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"
               Write(await Html.PartialAsync("EmptyExam", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 38 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Article\Articles.cshtml"

        a = a + 1;

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
