#pragma checksum "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d0e6dbd8a9832414b6910c146e75cd6a604aa3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_Index), @"mvc.1.0.view", @"/Views/Exam/Index.cshtml")]
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
#line 1 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d0e6dbd8a9832414b6910c146e75cd6a604aa3a", @"/Views/Exam/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210257964c41310cc652be9d4bdc17e51e617555", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Exam>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>ExamID</th>\r\n        <th>ArticleID/Başlık</th>\r\n        <th>ArticleURL</th>\r\n        <th>Tarih</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
       int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
           Write(item.ExamID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 483, "\"", 513, 2);
            WriteAttributeValue("", 490, "/Exam/Exam/", 490, 11, true);
#nullable restore
#line 22 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
WriteAttributeValue("", 501, item.ExamID, 501, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
                                             Write(item.Article.ArticleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
           Write(item.Article.ArticleUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
           Write(item.AddTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 671, "\"", 707, 2);
            WriteAttributeValue("", 678, "/Exam/DeleteExam/", 678, 17, true);
#nullable restore
#line 26 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
WriteAttributeValue("", 695, item.ExamID, 695, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Index.cshtml"
        i = i + 1;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Exam>> Html { get; private set; }
    }
}
#pragma warning restore 1591
